using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL.BLL_NEG;
using BLL.BLL_SER;
using Servicio;

namespace UI
{
    public partial class FormDevolucion_351FI : Form, IObservadorIdioma_351FI
    {
        BLL_Idioma_351FI bll_idioma_351FI = new BLL_Idioma_351FI();
        BLL_Prestamo_351FI bll_Prestamo_351FI;
        BLL_Devolucion_351FI bll_Devolucion_351FI;
        BLL_Multa_351FI bll_Multa_351FI;
        BLL_Comprobante_351FI bll_Comprobante_351FI;
        List<BE_Prestamo_351FI> prestamosMostrados_351FI = new List<BE_Prestamo_351FI>();
        BE_Prestamo_351FI? prestamoSeleccionado_351FI;
        // Devolución armada con el resumen (fecha real y multa si hay atraso); se registra al confirmar
        BE_Devolucion_351FI? devolucion_351FI;
        bool cargandoPrestamos_351FI;

        public FormDevolucion_351FI()
        {
            InitializeComponent();
            bll_idioma_351FI.Suscribir_351FI(this);
        }

        private void FormDevolucion_351FI_Load(object sender_351FI, EventArgs e_351FI)
        {
            bll_Prestamo_351FI = new BLL_Prestamo_351FI();
            bll_Devolucion_351FI = new BLL_Devolucion_351FI();
            bll_Multa_351FI = new BLL_Multa_351FI();
            bll_Comprobante_351FI = new BLL_Comprobante_351FI();

            dgvPrestamos_351FI.AutoGenerateColumns = false;
            colPreNumero_351FI.DataPropertyName = "Numero";
            colPreSocio_351FI.DataPropertyName = "Socio";
            colPreDni_351FI.DataPropertyName = "Dni";
            colPreFecha_351FI.DataPropertyName = "FechaPrestamo";
            colPrePrevista_351FI.DataPropertyName = "FechaDevolucionPrevista";

            dgvEjemplares_351FI.AutoGenerateColumns = false;
            colCodigo_351FI.DataPropertyName = "Codigo";
            colTitulo_351FI.DataPropertyName = "Titulo";
            colAutor_351FI.DataPropertyName = "Autor";

            BuscarPrestamos_351FI();
            ActualizarIdioma_351FI();
            this.Shown += FormDevolucion_351FI_Shown;
        }

        // La grilla selecciona la primera fila al mostrarse; se limpia para que el usuario elija el préstamo
        private void FormDevolucion_351FI_Shown(object? sender_351FI, EventArgs e_351FI)
        {
            dgvPrestamos_351FI.ClearSelection();
            LimpiarPrestamo_351FI();
        }

        // ------------------------------------------------------------ Préstamos vigentes
        // Préstamos vigentes que coinciden con el número de préstamo o el DNI del socio
        private void BuscarPrestamos_351FI()
        {
            prestamosMostrados_351FI = bll_Prestamo_351FI.BuscarVigentes_351FI(txtBuscar_351FI.Text);
            MostrarPrestamos_351FI();
        }

        private void MostrarPrestamos_351FI()
        {
            // Mientras se recarga la grilla no se cargan préstamos por el cambio de selección
            cargandoPrestamos_351FI = true;
            var filas = from p in prestamosMostrados_351FI
                        select new
                        {
                            Numero = p.NumeroPrestamo_351FI,
                            Socio = $"{p.Socio_351FI.Apellido_351FI}, {p.Socio_351FI.Nombre_351FI}",
                            Dni = p.Socio_351FI.Dni_351FI,
                            FechaPrestamo = p.FechaPrestamo_351FI.ToString("dd/MM/yyyy"),
                            FechaDevolucionPrevista = p.FechaDevolucionPrevista_351FI.ToString("dd/MM/yyyy")
                        };
            dgvPrestamos_351FI.DataSource = null;
            dgvPrestamos_351FI.DataSource = filas.ToList();
            MarcarVencidos_351FI();
            dgvPrestamos_351FI.ClearSelection();
            cargandoPrestamos_351FI = false;
            LimpiarPrestamo_351FI();

            // Si la búsqueda deja un solo préstamo, se selecciona directamente
            if (txtBuscar_351FI.Text.Trim() != "" && dgvPrestamos_351FI.Rows.Count == 1)
                dgvPrestamos_351FI.Rows[0].Selected = true;
        }

        // La fecha de devolución prevista se muestra en rojo en los préstamos atrasados
        private void MarcarVencidos_351FI()
        {
            foreach (DataGridViewRow fila in dgvPrestamos_351FI.Rows)
            {
                BE_Prestamo_351FI prestamo = prestamosMostrados_351FI[fila.Index];
                if (prestamo.FechaDevolucionPrevista_351FI.Date < DateTime.Today)
                    fila.Cells[colPrePrevista_351FI.Index].Style.ForeColor = Color.FromArgb(185, 28, 28);
            }
        }

        private void txtBuscar_351FI_TextChanged(object sender_351FI, EventArgs e_351FI)
        {
            BuscarPrestamos_351FI();
        }

        // Selección del préstamo: se trae con sus ejemplares y se arma el resumen de la devolución
        private void dgvPrestamos_351FI_SelectionChanged(object sender_351FI, EventArgs e_351FI)
        {
            if (cargandoPrestamos_351FI || dgvPrestamos_351FI.SelectedRows.Count == 0) return;

            BE_Prestamo_351FI elegido = prestamosMostrados_351FI[dgvPrestamos_351FI.SelectedRows[0].Index];
            if (prestamoSeleccionado_351FI != null && prestamoSeleccionado_351FI.NumeroPrestamo_351FI == elegido.NumeroPrestamo_351FI) return;

            try
            {
                LimpiarPrestamo_351FI();
                prestamoSeleccionado_351FI = bll_Prestamo_351FI.BuscarVigente_351FI(elegido.NumeroPrestamo_351FI);
                MostrarPrestamo_351FI();

                // La fecha actual es la fecha real de devolución; si hay atraso se calcula la multa
                DateTime fechaDevolucion = DateTime.Today;
                devolucion_351FI = new BE_Devolucion_351FI(0, prestamoSeleccionado_351FI, fechaDevolucion);
                int diasAtraso = bll_Devolucion_351FI.CalcularDiasAtraso_351FI(prestamoSeleccionado_351FI, fechaDevolucion);
                if (diasAtraso > 0)
                    devolucion_351FI.Multa_351FI = bll_Multa_351FI.CalcularMulta_351FI(diasAtraso, fechaDevolucion);
                MostrarResumen_351FI();
            }
            catch (Exception ex)
            {
                LimpiarPrestamo_351FI();
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Socio, fechas y ejemplares del préstamo seleccionado
        private void MostrarPrestamo_351FI()
        {
            BE_Prestamo_351FI prestamo = prestamoSeleccionado_351FI!;
            lblSocio_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.lblSocio_351FI")} {prestamo.Socio_351FI.Apellido_351FI}, {prestamo.Socio_351FI.Nombre_351FI} - {bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.dni")} {prestamo.Socio_351FI.Dni_351FI}";
            lblFechaPrestamo_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.lblFechaPrestamo_351FI")} {prestamo.FechaPrestamo_351FI:dd/MM/yyyy}";
            lblFechaDevolucionPrevista_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.lblFechaDevolucionPrevista_351FI")} {prestamo.FechaDevolucionPrevista_351FI:dd/MM/yyyy}";
            var filas = from ej in prestamo.Ejemplares_351FI
                        select new
                        {
                            Codigo = ej.CodigoEjemplar_351FI,
                            Titulo = ej.Libro_351FI.Titulo_351FI,
                            Autor = string.Join(", ", ej.Libro_351FI.Autores_351FI.Select(a => a.Nombre_351FI + " " + a.Apellido_351FI))
                        };
            dgvEjemplares_351FI.DataSource = filas.ToList();
        }

        // Resumen: fecha real de devolución, días de atraso y multa
        private void MostrarResumen_351FI()
        {
            BE_Multa_351FI? multa = devolucion_351FI!.Multa_351FI;
            lblFechaDevolucion_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.lblFechaDevolucion_351FI")} {devolucion_351FI.FechaDevolucion_351FI:dd/MM/yyyy}";
            lblDiasAtraso_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.lblDiasAtraso_351FI")} {(multa == null ? 0 : multa.DiasAtraso_351FI)}";
            lblMulta_351FI.Text = multa == null
                ? $"{bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.lblMulta_351FI")} {bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.sinMulta")}"
                : $"{bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.lblMulta_351FI")} $ {multa.Monto_351FI:N2} ({multa.DiasAtraso_351FI} {bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.dias")} x $ {multa.MontoPorDia_351FI:N2})";
        }

        private void LimpiarPrestamo_351FI()
        {
            prestamoSeleccionado_351FI = null;
            devolucion_351FI = null;
            dgvEjemplares_351FI.DataSource = null;
            chkRecepcionCompleta_351FI.Checked = false;
            MostrarSinPrestamo_351FI();
        }

        private void MostrarSinPrestamo_351FI()
        {
            lblSocio_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.lblSocio_351FI")} —";
            lblFechaPrestamo_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.lblFechaPrestamo_351FI")} —";
            lblFechaDevolucionPrevista_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.lblFechaDevolucionPrevista_351FI")} —";
            lblFechaDevolucion_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.lblFechaDevolucion_351FI")} —";
            lblDiasAtraso_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.lblDiasAtraso_351FI")} —";
            lblMulta_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.lblMulta_351FI")} —";
        }

        // ------------------------------------------------------ Confirmar / Cancelar
        private void btnConfirmar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (devolucion_351FI == null) throw new Exception("Seleccione un préstamo vigente de la grilla.");
                if (!chkRecepcionCompleta_351FI.Checked)
                    throw new Exception("Debe confirmar que recibió todos los ejemplares del préstamo. Si el socio no los devuelve todos, la devolución no se registra.");

                if (MessageBox.Show($"¿Confirma la devolución del préstamo N° {devolucion_351FI.Prestamo_351FI.NumeroPrestamo_351FI}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_Devolucion_351FI.Registrar_351FI(devolucion_351FI, chkRecepcionCompleta_351FI.Checked);

                string mensaje = $"Devolución N° {devolucion_351FI.NumeroDevolucion_351FI} registrada correctamente.";
                if (devolucion_351FI.Multa_351FI != null)
                {
                    mensaje += $"\n\nSe registró una multa de $ {devolucion_351FI.Multa_351FI.Monto_351FI:N2} por {devolucion_351FI.Multa_351FI.DiasAtraso_351FI} días de atraso." +
                               "\nEl socio no podrá realizar nuevos préstamos hasta abonarla.";
                }
                MessageBox.Show(mensaje, "Devolución registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    bll_Comprobante_351FI.Emitir_351FI(bll_Devolucion_351FI.ArmarComprobante_351FI(devolucion_351FI));
                }
                catch (Exception exPdf)
                {
                    MessageBox.Show($"La devolución quedó registrada, pero no se pudo generar el comprobante en PDF.\n{exPdf.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            this.Close();
        }

        // ------------------------------------------------------------ Idioma
        public void ActualizarIdioma_351FI()
        {
            this.Text = bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.Form");
            lblSeccionPrestamo_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.lblSeccionPrestamo_351FI");
            lblBuscar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.lblBuscar_351FI");
            txtBuscar_351FI.PlaceholderText = bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.txtBuscar_351FI");
            colPreNumero_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.colPreNumero_351FI");
            colPreSocio_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.colPreSocio_351FI");
            colPreDni_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.colPreDni_351FI");
            colPreFecha_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.colPreFecha_351FI");
            colPrePrevista_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.colPrePrevista_351FI");
            lblSeccionResumen_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.lblSeccionResumen_351FI");
            chkRecepcionCompleta_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.chkRecepcionCompleta_351FI");
            lblSeccionEjemplares_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.lblSeccionEjemplares_351FI");
            colCodigo_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.colCodigo_351FI");
            colTitulo_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.colTitulo_351FI");
            colAutor_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.colAutor_351FI");
            btnConfirmar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.btnConfirmar_351FI");
            btnCancelar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDevolucion_351FI.btnCancelar_351FI");
            if (prestamoSeleccionado_351FI != null && devolucion_351FI != null)
            {
                MostrarPrestamo_351FI();
                MostrarResumen_351FI();
            }
            else MostrarSinPrestamo_351FI();
            AyudaFormulario_351FI.Aplicar_351FI(this, bll_idioma_351FI);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma_351FI.Desuscribir_351FI(this);
            base.OnFormClosed(e);
        }
    }
}
