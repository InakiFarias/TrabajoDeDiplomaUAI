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
    public partial class FormDevolucion : Form, IObservadorIdioma
    {
        BLL_Idioma bll_idioma = new BLL_Idioma();
        BLL_Prestamo bll_Prestamo;
        BLL_Devolucion bll_Devolucion;
        BLL_Ejemplar bll_Ejemplar;
        List<BE_Prestamo> prestamosMostrados = new List<BE_Prestamo>();
        BE_Prestamo? prestamoSeleccionado;
        bool cargandoPrestamos;

        public FormDevolucion()
        {
            InitializeComponent();
            bll_idioma.Suscribir(this);
        }

        private void FormDevolucion_Load(object sender, EventArgs e)
        {
            bll_Prestamo = new BLL_Prestamo();
            bll_Devolucion = new BLL_Devolucion();
            bll_Ejemplar = new BLL_Ejemplar();

            dgvPrestamos.AutoGenerateColumns = false;
            colPreNumero.DataPropertyName = "Numero";
            colPreSocio.DataPropertyName = "Socio";
            colPreDni.DataPropertyName = "Dni";
            colPreFecha.DataPropertyName = "FechaPrestamo";
            colPrePrevista.DataPropertyName = "FechaDevolucionPrevista";

            dgvEjemplares.AutoGenerateColumns = false;
            colCodigo.DataPropertyName = "Codigo";
            colTitulo.DataPropertyName = "Titulo";
            colAutor.DataPropertyName = "Autor";

            CargarPrestamos();
            ActualizarIdioma();
            this.Shown += FormDevolucion_Shown;
        }

        // La grilla selecciona la primera fila al mostrarse; se limpia para que el usuario elija el préstamo
        private void FormDevolucion_Shown(object? sender, EventArgs e)
        {
            dgvPrestamos.ClearSelection();
            LimpiarPrestamo();
        }

        // ------------------------------------------------------------ Préstamos vigentes
        private void CargarPrestamos()
        {
            // Mientras se recarga la grilla no se cargan préstamos por el cambio de selección
            cargandoPrestamos = true;
            prestamosMostrados = bll_Prestamo.BuscarVigentes(txtBuscar.Text);
            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = bll_Prestamo.ConsultarParaGrilla(prestamosMostrados);
            MarcarVencidos();
            dgvPrestamos.ClearSelection();
            cargandoPrestamos = false;
            LimpiarPrestamo();

            // Si la búsqueda deja un solo préstamo, se selecciona directamente
            if (txtBuscar.Text.Trim() != "" && dgvPrestamos.Rows.Count == 1)
                dgvPrestamos.Rows[0].Selected = true;
        }

        // La fecha de devolución prevista se muestra en rojo en los préstamos atrasados
        private void MarcarVencidos()
        {
            foreach (DataGridViewRow fila in dgvPrestamos.Rows)
            {
                BE_Prestamo prestamo = prestamosMostrados[fila.Index];
                if (prestamo.FechaDevolucionPrevista.Date < DateTime.Today)
                    fila.Cells[colPrePrevista.Index].Style.ForeColor = Color.FromArgb(185, 28, 28);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarPrestamos();
        }

        private void dgvPrestamos_SelectionChanged(object sender, EventArgs e)
        {
            if (cargandoPrestamos || dgvPrestamos.SelectedRows.Count == 0) return;

            BE_Prestamo elegido = prestamosMostrados[dgvPrestamos.SelectedRows[0].Index];
            if (prestamoSeleccionado != null && prestamoSeleccionado.NumeroPrestamo == elegido.NumeroPrestamo) return;

            try
            {
                LimpiarPrestamo();
                // Se vuelve a buscar el préstamo para traer sus ejemplares
                prestamoSeleccionado = bll_Prestamo.BuscarVigente(elegido.NumeroPrestamo.ToString());
                MostrarPrestamo(prestamoSeleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarPrestamo(BE_Prestamo prestamo)
        {
            lblSocio.Text = $"{bll_idioma.Traducir("FormDevolucion.lblSocio")} {prestamo.Socio.Apellido}, {prestamo.Socio.Nombre} - {bll_idioma.Traducir("FormDevolucion.dni")} {prestamo.Socio.Dni}";
            lblFechaPrestamo.Text = $"{bll_idioma.Traducir("FormDevolucion.lblFechaPrestamo")} {prestamo.FechaPrestamo:dd/MM/yyyy}";
            lblFechaDevolucionPrevista.Text = $"{bll_idioma.Traducir("FormDevolucion.lblFechaDevolucionPrevista")} {prestamo.FechaDevolucionPrevista:dd/MM/yyyy}";
            dgvEjemplares.DataSource = bll_Ejemplar.ConsultarParaGrilla(prestamo.Ejemplares);

            // Resumen: fecha real de devolución, atraso y multa
            DateTime hoy = DateTime.Today;
            BE_Multa? multa = bll_Devolucion.CalcularMulta(prestamo, hoy);
            lblFechaDevolucion.Text = $"{bll_idioma.Traducir("FormDevolucion.lblFechaDevolucion")} {hoy:dd/MM/yyyy}";
            lblDiasAtraso.Text = $"{bll_idioma.Traducir("FormDevolucion.lblDiasAtraso")} {bll_Devolucion.CalcularDiasAtraso(prestamo, hoy)}";
            lblMulta.Text = multa == null
                ? $"{bll_idioma.Traducir("FormDevolucion.lblMulta")} {bll_idioma.Traducir("FormDevolucion.sinMulta")}"
                : $"{bll_idioma.Traducir("FormDevolucion.lblMulta")} $ {multa.Monto:N2} ({multa.DiasAtraso} {bll_idioma.Traducir("FormDevolucion.dias")} x $ {multa.MontoPorDia:N2})";
        }

        private void LimpiarPrestamo()
        {
            prestamoSeleccionado = null;
            dgvEjemplares.DataSource = null;
            chkRecepcionCompleta.Checked = false;
            MostrarSinPrestamo();
        }

        private void MostrarSinPrestamo()
        {
            lblSocio.Text = $"{bll_idioma.Traducir("FormDevolucion.lblSocio")} —";
            lblFechaPrestamo.Text = $"{bll_idioma.Traducir("FormDevolucion.lblFechaPrestamo")} —";
            lblFechaDevolucionPrevista.Text = $"{bll_idioma.Traducir("FormDevolucion.lblFechaDevolucionPrevista")} —";
            lblFechaDevolucion.Text = $"{bll_idioma.Traducir("FormDevolucion.lblFechaDevolucion")} —";
            lblDiasAtraso.Text = $"{bll_idioma.Traducir("FormDevolucion.lblDiasAtraso")} —";
            lblMulta.Text = $"{bll_idioma.Traducir("FormDevolucion.lblMulta")} —";
        }

        // ------------------------------------------------------ Confirmar / Cancelar
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (prestamoSeleccionado == null) throw new Exception("Seleccione un préstamo vigente de la grilla.");
                if (!chkRecepcionCompleta.Checked)
                    throw new Exception("Debe confirmar que recibió todos los ejemplares del préstamo. Si el socio no los devuelve todos, la devolución no se registra.");

                if (MessageBox.Show($"¿Confirma la devolución del préstamo N° {prestamoSeleccionado.NumeroPrestamo}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                BE_Devolucion devolucion = bll_Devolucion.Registrar(prestamoSeleccionado, chkRecepcionCompleta.Checked);

                string mensaje = $"Devolución N° {devolucion.NumeroDevolucion} registrada correctamente.";
                if (devolucion.Multa != null)
                {
                    mensaje += $"\n\nSe registró una multa de $ {devolucion.Multa.Monto:N2} por {devolucion.Multa.DiasAtraso} días de atraso." +
                               "\nEl socio no podrá realizar nuevos préstamos hasta abonarla.";
                }
                MessageBox.Show(mensaje, "Devolución registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ------------------------------------------------------------ Idioma
        public void ActualizarIdioma()
        {
            this.Text = bll_idioma.Traducir("FormDevolucion.Form");
            lblSeccionPrestamo.Text = bll_idioma.Traducir("FormDevolucion.lblSeccionPrestamo");
            lblBuscar.Text = bll_idioma.Traducir("FormDevolucion.lblBuscar");
            txtBuscar.PlaceholderText = bll_idioma.Traducir("FormDevolucion.txtBuscar");
            colPreNumero.HeaderText = bll_idioma.Traducir("FormDevolucion.colPreNumero");
            colPreSocio.HeaderText = bll_idioma.Traducir("FormDevolucion.colPreSocio");
            colPreDni.HeaderText = bll_idioma.Traducir("FormDevolucion.colPreDni");
            colPreFecha.HeaderText = bll_idioma.Traducir("FormDevolucion.colPreFecha");
            colPrePrevista.HeaderText = bll_idioma.Traducir("FormDevolucion.colPrePrevista");
            lblSeccionResumen.Text = bll_idioma.Traducir("FormDevolucion.lblSeccionResumen");
            chkRecepcionCompleta.Text = bll_idioma.Traducir("FormDevolucion.chkRecepcionCompleta");
            lblSeccionEjemplares.Text = bll_idioma.Traducir("FormDevolucion.lblSeccionEjemplares");
            colCodigo.HeaderText = bll_idioma.Traducir("FormDevolucion.colCodigo");
            colTitulo.HeaderText = bll_idioma.Traducir("FormDevolucion.colTitulo");
            colAutor.HeaderText = bll_idioma.Traducir("FormDevolucion.colAutor");
            btnConfirmar.Text = bll_idioma.Traducir("FormDevolucion.btnConfirmar");
            btnCancelar.Text = bll_idioma.Traducir("FormDevolucion.btnCancelar");
            if (prestamoSeleccionado != null) MostrarPrestamo(prestamoSeleccionado);
            else MostrarSinPrestamo();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma.Desuscribir(this);
            base.OnFormClosed(e);
        }
    }
}
