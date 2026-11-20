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
    public partial class FormPrestamo_351FI : Form, IObservadorIdioma_351FI
    {
        BLL_Idioma_351FI bll_idioma_351FI = new BLL_Idioma_351FI();
        BLL_Socio_351FI bll_Socio_351FI;
        BLL_Ejemplar_351FI bll_Ejemplar_351FI;
        BLL_Prestamo_351FI bll_Prestamo_351FI;
        BLL_Comprobante_351FI bll_Comprobante_351FI;
        BE_Socio_351FI? socioSeleccionado_351FI;
        BE_Socio_351FI? socioConsultado_351FI;
        string habilitacionConsultada_351FI = "";
        List<BE_Ejemplar_351FI> detalle_351FI = new List<BE_Ejemplar_351FI>();
        List<BE_Ejemplar_351FI> resultados_351FI = new List<BE_Ejemplar_351FI>();

        public FormPrestamo_351FI()
        {
            InitializeComponent();
            bll_idioma_351FI.Suscribir_351FI(this);
        }

        private void FormPrestamo_351FI_Load(object sender_351FI, EventArgs e_351FI)
        {
            bll_Socio_351FI = new BLL_Socio_351FI();
            bll_Ejemplar_351FI = new BLL_Ejemplar_351FI();
            bll_Prestamo_351FI = new BLL_Prestamo_351FI();
            bll_Comprobante_351FI = new BLL_Comprobante_351FI();
            foreach (Control control in this.Controls)
            {
                if (control is DataGridView)
                {
                    ((DataGridView)control).MultiSelect = false;
                    ((DataGridView)control).SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            ConfigurarGrillas_351FI();

            Mostrar_351FI(dgvSocios_351FI, bll_Socio_351FI.ObtenerActivos_351FI());
            BuscarEjemplares_351FI();
            ActualizarIdioma_351FI();
        }

        private void ConfigurarGrillas_351FI()
        {
            dgvSocios_351FI.AutoGenerateColumns = false;
            colSocNumero_351FI.DataPropertyName = "NumeroSocio_351FI";
            colSocApellido_351FI.DataPropertyName = "Apellido_351FI";
            colSocNombre_351FI.DataPropertyName = "Nombre_351FI";
            colSocDni_351FI.DataPropertyName = "Dni_351FI";
            colSocEstado_351FI.DataPropertyName = "Estado_351FI";

            dgvResultados_351FI.AutoGenerateColumns = false;
            colResCodigo_351FI.DataPropertyName = "Codigo";
            colResTitulo_351FI.DataPropertyName = "Titulo";
            colResAutor_351FI.DataPropertyName = "Autor";
            colResEstado_351FI.DataPropertyName = "Estado";

            dgvDetalle_351FI.AutoGenerateColumns = false;
            colDetCodigo_351FI.DataPropertyName = "Codigo";
            colDetTitulo_351FI.DataPropertyName = "Titulo";
            colDetAutor_351FI.DataPropertyName = "Autor";
        }
        private void Mostrar_351FI(DataGridView grilla_351FI, object datos_351FI)
        {
            grilla_351FI.DataSource = null;
            grilla_351FI.DataSource = datos_351FI;
        }
        private void MostrarFechas_351FI()
        {
            lblFechaPrestamo_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.lblFechaPrestamo_351FI")} {DateTime.Today:dd/MM/yyyy}";
            lblFechaDevolucion_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.lblFechaDevolucion_351FI")} {bll_Prestamo_351FI.CalcularFechaDevolucionPrevista_351FI(DateTime.Today):dd/MM/yyyy}";
        }

        // Datos del último socio consultado y su habilitación para préstamos
        private void MostrarSocio_351FI()
        {
            if (socioConsultado_351FI == null)
            {
                lblDatosSocio_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.lblDatosSocio_351FI")} —";
                lblEstadoSocio_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.lblEstadoSocio_351FI")} —";
                return;
            }
            lblDatosSocio_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.lblDatosSocio_351FI")} {socioConsultado_351FI.Apellido_351FI}, {socioConsultado_351FI.Nombre_351FI} - {bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.colSocDni_351FI")} {socioConsultado_351FI.Dni_351FI}";
            lblEstadoSocio_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.lblEstadoSocio_351FI")} {habilitacionConsultada_351FI}";
        }

        // ------------------------------------------------------------ Socio
        private void txtDni_351FI_TextChanged(object sender_351FI, EventArgs e_351FI)
        {
            Mostrar_351FI(dgvSocios_351FI, bll_Socio_351FI.BuscarActivosPorDni_351FI(txtDni_351FI.Text));
        }

        private void btnAgregarSocio_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (dgvSocios_351FI.Rows.Count == 0) throw new Exception("El socio no se encuentra registrado o está dado de baja. Debe registrarse o darse de alta mediante la gestión de socios.");
                if (dgvSocios_351FI.SelectedRows.Count == 0) throw new Exception("Seleccione un socio.");

                BE_Socio_351FI socio = (BE_Socio_351FI)dgvSocios_351FI.SelectedRows[0].DataBoundItem;
                string habilitacion = bll_Socio_351FI.ValidarHabilitacion_351FI(socio);

                socioConsultado_351FI = socio;
                habilitacionConsultada_351FI = habilitacion;
                MostrarSocio_351FI();

                if (habilitacion != BLL_Socio_351FI.HABILITADO)
                {
                    socioSeleccionado_351FI = null;
                    MostrarDetalle_351FI();
                    throw new Exception($"El socio no puede realizar préstamos. Motivo: {habilitacion}.");
                }

                socioSeleccionado_351FI = socio;
                MostrarDetalle_351FI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // ------------------------------------------------------------ Ejemplares
        private void txtBuscarEjemplar_351FI_TextChanged(object sender_351FI, EventArgs e_351FI)
        {
            BuscarEjemplares_351FI();
        }

        // Ejemplares que coinciden con la búsqueda (código, título o autor), sin los dados de baja y con su estado
        private void BuscarEjemplares_351FI()
        {
            resultados_351FI = bll_Ejemplar_351FI.BuscarParaPrestamo_351FI(txtBuscarEjemplar_351FI.Text);
            MostrarResultados_351FI();
        }

        // No se listan los ejemplares que ya están en el detalle
        private void MostrarResultados_351FI()
        {
            List<BE_Ejemplar_351FI> resultados = resultados_351FI
                .Where(ej => !detalle_351FI.Any(d => d.CodigoEjemplar_351FI == ej.CodigoEjemplar_351FI))
                .ToList();
            Mostrar_351FI(dgvResultados_351FI, ArmarFilas_351FI(resultados));
        }

        private List<object> ArmarFilas_351FI(List<BE_Ejemplar_351FI> ejemplares_351FI)
        {
            var filas = from ej in ejemplares_351FI
                        select new
                        {
                            Codigo = ej.CodigoEjemplar_351FI,
                            Titulo = ej.Libro_351FI.Titulo_351FI,
                            Autor = string.Join(", ", ej.Libro_351FI.Autores_351FI.Select(a => a.Nombre_351FI + " " + a.Apellido_351FI)),
                            Estado = ej.Estado_351FI
                        };
            return filas.ToList<object>();
        }

        // Detalle del préstamo: socio elegido y ejemplares agregados
        private void MostrarDetalle_351FI()
        {
            Mostrar_351FI(dgvDetalle_351FI, ArmarFilas_351FI(detalle_351FI));
            lblDetalleSocio_351FI.Text = socioSeleccionado_351FI == null
                ? $"{bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.lblDetalleSocio_351FI")} —"
                : $"{bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.lblDetalleSocio_351FI")} {socioSeleccionado_351FI.Apellido_351FI}, {socioSeleccionado_351FI.Nombre_351FI} - {bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.colSocDni_351FI")} {socioSeleccionado_351FI.Dni_351FI}";
            lblDetalleCantidad_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.lblDetalleCantidad_351FI")} {detalle_351FI.Count} / {BLL_Prestamo_351FI.MAXIMO_EJEMPLARES_POR_PRESTAMO}";
        }
        private void btnAgregarEjemplar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (socioSeleccionado_351FI == null) throw new Exception("Primero debe agregar un socio habilitado.");
                if (dgvResultados_351FI.Rows.Count == 0) throw new Exception("No hay ejemplares que coincidan con la búsqueda.");
                if (dgvResultados_351FI.SelectedRows.Count == 0) throw new Exception("Seleccione un ejemplar.");

                string codigo = dgvResultados_351FI.SelectedRows[0].Cells[colResCodigo_351FI.Index].Value.ToString();

                bll_Prestamo_351FI.AgregarEjemplar_351FI(detalle_351FI, codigo);
                MostrarDetalle_351FI();
                MostrarResultados_351FI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgvResultados_351FI_CellDoubleClick(object sender_351FI, DataGridViewCellEventArgs e_351FI)
        {
            btnAgregarEjemplar_351FI_Click(sender_351FI, e_351FI);
        }
        private void btnQuitarEjemplar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            if (dgvDetalle_351FI.SelectedRows.Count == 0) return;

            string codigo = dgvDetalle_351FI.SelectedRows[0].Cells[colDetCodigo_351FI.Index].Value.ToString();
            detalle_351FI.RemoveAll(ej => ej.CodigoEjemplar_351FI == codigo);
            MostrarDetalle_351FI();
            MostrarResultados_351FI();
        }

        // ------------------------------------------------------ Confirmar / Cancelar

        // Finalizar selección: calcula la fecha de devolución prevista, muestra el resumen y, si el bibliotecario confirma, registra el préstamo
        private void btnConfirmar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (socioSeleccionado_351FI == null) throw new Exception("Debe agregar un socio habilitado.");
                if (detalle_351FI.Count == 0) throw new Exception("Debe seleccionar al menos un ejemplar.");

                DateTime fechaPrestamo = DateTime.Today;
                DateTime fechaDevolucionPrevista = bll_Prestamo_351FI.CalcularFechaDevolucionPrevista_351FI(fechaPrestamo);
                string resumen = $"Socio: {socioSeleccionado_351FI.Apellido_351FI}, {socioSeleccionado_351FI.Nombre_351FI}\n" +
                                 $"Ejemplares: {detalle_351FI.Count}\n" +
                                 $"Fecha del préstamo: {fechaPrestamo:dd/MM/yyyy}\n" +
                                 $"Fecha de devolución prevista: {fechaDevolucionPrevista:dd/MM/yyyy}\n\n" +
                                 "¿Confirma el préstamo?";

                if (MessageBox.Show(resumen, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                BE_Prestamo_351FI prestamo = new BE_Prestamo_351FI();
                prestamo.Socio_351FI = socioSeleccionado_351FI;
                prestamo.Ejemplares_351FI = detalle_351FI;
                prestamo.FechaPrestamo_351FI = fechaPrestamo;
                prestamo.FechaDevolucionPrevista_351FI = fechaDevolucionPrevista;

                bll_Prestamo_351FI.Registrar_351FI(prestamo);

                MessageBox.Show($"Préstamo N° {prestamo.NumeroPrestamo_351FI} registrado correctamente.\n" +
                                $"Devolver antes del: {prestamo.FechaDevolucionPrevista_351FI:dd/MM/yyyy}",
                                "Préstamo registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    bll_Comprobante_351FI.Emitir_351FI(bll_Prestamo_351FI.ArmarComprobante_351FI(prestamo));
                }
                catch (Exception exPdf)
                {
                    MessageBox.Show($"El préstamo quedó registrado, pero no se pudo generar el comprobante en PDF.\n{exPdf.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            this.Text = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.Form");
            lblSeccionSocio_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.lblSeccionSocio_351FI");
            lblDni_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.lblDni_351FI");
            txtDni_351FI.PlaceholderText = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.txtDni_351FI");
            btnAgregarSocio_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.btnAgregarSocio_351FI");
            colSocNumero_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.colSocNumero_351FI");
            colSocApellido_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.colSocApellido_351FI");
            colSocNombre_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.colSocNombre_351FI");
            colSocDni_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.colSocDni_351FI");
            colSocEstado_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.colSocEstado_351FI");
            lblSeccionEjemplares_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.lblSeccionEjemplares_351FI");
            lblBuscarEjemplar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.lblBuscarEjemplar_351FI");
            btnAgregarEjemplar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.btnAgregarEjemplar_351FI");
            colResCodigo_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.colResCodigo_351FI");
            colResTitulo_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.colResTitulo_351FI");
            colResAutor_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.colResAutor_351FI");
            colResEstado_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.colResEstado_351FI");
            lblSeccionDetalle_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.lblSeccionDetalle_351FI");
            colDetCodigo_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.colDetCodigo_351FI");
            colDetTitulo_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.colDetTitulo_351FI");
            colDetAutor_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.colDetAutor_351FI");
            btnQuitarEjemplar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.btnQuitarEjemplar_351FI");
            btnConfirmar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.btnConfirmar_351FI");
            btnCancelar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormPrestamo_351FI.btnCancelar_351FI");
            MostrarSocio_351FI();
            if (bll_Prestamo_351FI == null) return;
            MostrarFechas_351FI();
            MostrarDetalle_351FI();
            AyudaFormulario_351FI.Aplicar_351FI(this, bll_idioma_351FI);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma_351FI.Desuscribir_351FI(this);
            base.OnFormClosed(e);
        }
    }
}
