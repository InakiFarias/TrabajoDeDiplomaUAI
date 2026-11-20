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
    public partial class FormDonacion_351FI : Form, IObservadorIdioma_351FI
    {
        BLL_Idioma_351FI bll_idioma_351FI = new BLL_Idioma_351FI();
        BLL_Socio_351FI bll_Socio_351FI;
        BLL_Libro_351FI bll_Libro_351FI;
        BLL_Donacion_351FI bll_Donacion_351FI;
        BLL_Comprobante_351FI bll_Comprobante_351FI;
        BE_Socio_351FI? socioSeleccionado_351FI;
        List<BE_Libro_351FI> librosMostrados_351FI = new List<BE_Libro_351FI>();
        // Ejemplares nuevos que se crean al confirmar la donación (uno por copia donada)
        List<BE_Ejemplar_351FI> detalle_351FI = new List<BE_Ejemplar_351FI>();

        public FormDonacion_351FI()
        {
            InitializeComponent();
            bll_idioma_351FI.Suscribir_351FI(this);
        }

        private void FormDonacion_351FI_Load(object sender_351FI, EventArgs e_351FI)
        {
            bll_Socio_351FI = new BLL_Socio_351FI();
            bll_Libro_351FI = new BLL_Libro_351FI();
            bll_Donacion_351FI = new BLL_Donacion_351FI();
            bll_Comprobante_351FI = new BLL_Comprobante_351FI();

            dgvSocios_351FI.AutoGenerateColumns = false;
            colSocNumero_351FI.DataPropertyName = "NumeroSocio_351FI";
            colSocApellido_351FI.DataPropertyName = "Apellido_351FI";
            colSocNombre_351FI.DataPropertyName = "Nombre_351FI";
            colSocDni_351FI.DataPropertyName = "Dni_351FI";

            dgvLibros_351FI.AutoGenerateColumns = false;
            colLibCodigo_351FI.DataPropertyName = "Codigo";
            colLibTitulo_351FI.DataPropertyName = "Titulo";
            colLibAutores_351FI.DataPropertyName = "Autores";

            dgvDetalle_351FI.AutoGenerateColumns = false;
            colDetLibro_351FI.DataPropertyName = "Codigo";
            colDetTitulo_351FI.DataPropertyName = "Titulo";
            colDetAutor_351FI.DataPropertyName = "Autor";

            dgvDonaciones_351FI.AutoGenerateColumns = false;
            colDonNumero_351FI.DataPropertyName = "Numero";
            colDonFecha_351FI.DataPropertyName = "Fecha";
            colDonSocio_351FI.DataPropertyName = "Socio";
            colDonCantidad_351FI.DataPropertyName = "Cantidad";
            colDonLibros_351FI.DataPropertyName = "Libros";

            Mostrar_351FI(dgvSocios_351FI, bll_Socio_351FI.ObtenerActivos_351FI());
            BuscarLibros_351FI();
            CargarDonaciones_351FI();
            ActualizarIdioma_351FI();
        }

        // Donaciones ya registradas, para consulta
        private void CargarDonaciones_351FI()
        {
            Mostrar_351FI(dgvDonaciones_351FI, bll_Donacion_351FI.ConsultarDonacionesParaGrilla_351FI(bll_Donacion_351FI.ObtenerDonaciones_351FI()));
            dgvDonaciones_351FI.ClearSelection();
        }

        private void MostrarSocio_351FI()
        {
            lblDatosSocio_351FI.Text = socioSeleccionado_351FI == null
                ? $"{bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.lblDatosSocio_351FI")} —"
                : $"{bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.lblDatosSocio_351FI")} {socioSeleccionado_351FI.Apellido_351FI}, {socioSeleccionado_351FI.Nombre_351FI} - {bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.colSocDni_351FI")} {socioSeleccionado_351FI.Dni_351FI}";
        }

        private void Mostrar_351FI(DataGridView grilla_351FI, object datos_351FI)
        {
            grilla_351FI.DataSource = null;
            grilla_351FI.DataSource = datos_351FI;
        }

        // ------------------------------------------------------------ Socio donante
        private void txtDni_351FI_TextChanged(object sender_351FI, EventArgs e_351FI)
        {
            Mostrar_351FI(dgvSocios_351FI, bll_Socio_351FI.BuscarActivosPorDni_351FI(txtDni_351FI.Text));
        }

        private void dgvSocios_351FI_CellDoubleClick(object sender_351FI, DataGridViewCellEventArgs e_351FI)
        {
            if (e_351FI.RowIndex < 0) return;
            btnAgregarSocio_351FI_Click(sender_351FI, e_351FI);
        }

        private void btnAgregarSocio_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (dgvSocios_351FI.Rows.Count == 0) throw new Exception("El socio no se encuentra registrado o está dado de baja. Debe registrarse o darse de alta mediante la gestión de socios.");
                if (dgvSocios_351FI.SelectedRows.Count == 0) throw new Exception("Seleccione un socio.");

                socioSeleccionado_351FI = (BE_Socio_351FI)dgvSocios_351FI.SelectedRows[0].DataBoundItem;
                MostrarSocio_351FI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ------------------------------------------------------------ Libros donados
        private void txtBuscarLibro_351FI_TextChanged(object sender_351FI, EventArgs e_351FI)
        {
            BuscarLibros_351FI();
        }

        // Libros activos que coinciden por código, título o autor; con el buscador vacío se listan todos
        private void BuscarLibros_351FI()
        {
            librosMostrados_351FI = bll_Libro_351FI.BuscarActivos_351FI(txtBuscarLibro_351FI.Text);
            MostrarLibros_351FI();
        }

        private void MostrarLibros_351FI()
        {
            var filas = from l in librosMostrados_351FI
                        select new
                        {
                            Codigo = l.CodigoLibro_351FI,
                            Titulo = l.Titulo_351FI,
                            Autores = string.Join(", ", l.Autores_351FI.Select(a => a.Nombre_351FI + " " + a.Apellido_351FI))
                        };
            Mostrar_351FI(dgvLibros_351FI, filas.ToList<object>());
        }

        private void dgvLibros_351FI_CellDoubleClick(object sender_351FI, DataGridViewCellEventArgs e_351FI)
        {
            if (e_351FI.RowIndex < 0) return;
            btnAgregarEjemplar_351FI_Click(sender_351FI, e_351FI);
        }

        // Cada clic agrega un ejemplar nuevo del libro elegido; si se donan varias copias, se agrega varias veces
        private void btnAgregarEjemplar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (socioSeleccionado_351FI == null) throw new Exception("Primero debe seleccionar al socio donante.");
                if (dgvLibros_351FI.Rows.Count == 0) throw new Exception("No existe un libro que coincida con la búsqueda. Regístrelo primero en Gestión de libros.");
                if (dgvLibros_351FI.SelectedRows.Count == 0) throw new Exception("Seleccione un libro.");

                BE_Libro_351FI libro = librosMostrados_351FI[dgvLibros_351FI.SelectedRows[0].Index];
                bll_Donacion_351FI.AgregarLibro_351FI(detalle_351FI, libro);
                MostrarDetalle_351FI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnQuitarEjemplar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            if (dgvDetalle_351FI.SelectedRows.Count == 0) return;

            detalle_351FI.RemoveAt(dgvDetalle_351FI.SelectedRows[0].Index);
            MostrarDetalle_351FI();
        }

        private void MostrarDetalle_351FI()
        {
            // Los ejemplares todavía no tienen código: se muestra el libro de cada uno
            var filas = from ej in detalle_351FI
                        select new
                        {
                            Codigo = ej.Libro_351FI.CodigoLibro_351FI,
                            Titulo = ej.Libro_351FI.Titulo_351FI,
                            Autor = string.Join(", ", ej.Libro_351FI.Autores_351FI.Select(a => a.Nombre_351FI + " " + a.Apellido_351FI))
                        };
            Mostrar_351FI(dgvDetalle_351FI, filas.ToList<object>());
            lblDetalleCantidad_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.lblDetalleCantidad_351FI")} {detalle_351FI.Count}";
        }

        // ------------------------------------------------------ Confirmar / Cancelar
        private void btnConfirmar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (socioSeleccionado_351FI == null) throw new Exception("Debe seleccionar al socio donante.");
                if (detalle_351FI.Count == 0) throw new Exception("Debe seleccionar al menos un libro.");

                if (!MostrarResumen_351FI()) return;

                BE_Donacion_351FI donacion = new BE_Donacion_351FI();
                donacion.Socio_351FI = socioSeleccionado_351FI;
                donacion.FechaDonacion_351FI = DateTime.Today;
                donacion.Ejemplares_351FI = detalle_351FI;

                bll_Donacion_351FI.Registrar_351FI(donacion);

                string codigos = string.Join(", ", donacion.Ejemplares_351FI.Select(ej => ej.CodigoEjemplar_351FI));
                MessageBox.Show($"Donación N° {donacion.NumeroDonacion_351FI} registrada correctamente.\nEjemplares dados de alta: {codigos}",
                                "Donación registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    bll_Comprobante_351FI.Emitir_351FI(bll_Donacion_351FI.ArmarComprobante_351FI(donacion));
                }
                catch (Exception exPdf)
                {
                    MessageBox.Show($"La donación quedó registrada, pero no se pudo generar el comprobante en PDF.\n{exPdf.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Resumen de la donación; devuelve true si el bibliotecario confirma la donación
        private bool MostrarResumen_351FI()
        {
            string libros = string.Join("\n", detalle_351FI.GroupBy(ej => ej.Libro_351FI.CodigoLibro_351FI)
                                                          .Select(g => $"  - {g.First().Libro_351FI.Titulo_351FI} ({g.Count()})"));
            string resumen = $"Socio donante: {socioSeleccionado_351FI!.Apellido_351FI}, {socioSeleccionado_351FI.Nombre_351FI}\n" +
                             $"Ejemplares donados: {detalle_351FI.Count}\n{libros}\n\n" +
                             "Se dará de alta un ejemplar disponible por cada libro del detalle.\n¿Confirma la donación?";
            return MessageBox.Show(resumen, "Confirmar donación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void btnCancelar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            this.Close();
        }

        // ------------------------------------------------------------ Idioma
        public void ActualizarIdioma_351FI()
        {
            this.Text = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.Form");
            lblSeccionSocio_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.lblSeccionSocio_351FI");
            lblDni_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.lblDni_351FI");
            btnAgregarSocio_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.btnAgregarSocio_351FI");
            colSocNumero_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.colSocNumero_351FI");
            colSocApellido_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.colSocApellido_351FI");
            colSocNombre_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.colSocNombre_351FI");
            colSocDni_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.colSocDni_351FI");
            lblSeccionEjemplares_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.lblSeccionEjemplares_351FI");
            lblBuscarLibro_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.lblBuscarLibro_351FI");
            btnAgregarEjemplar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.btnAgregarEjemplar_351FI");
            colLibCodigo_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.colLibCodigo_351FI");
            colLibTitulo_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.colLibTitulo_351FI");
            colLibAutores_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.colLibAutores_351FI");
            lblAyudaLibro_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.lblAyudaLibro_351FI");
            lblSeccionDetalle_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.lblSeccionDetalle_351FI");
            colDetLibro_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.colDetLibro_351FI");
            colDetTitulo_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.colDetTitulo_351FI");
            colDetAutor_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.colDetAutor_351FI");
            btnQuitarEjemplar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.btnQuitarEjemplar_351FI");
            lblAyudaDetalle_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.lblAyudaDetalle_351FI");
            lblSeccionDonaciones_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.lblSeccionDonaciones_351FI");
            colDonNumero_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.colDonNumero_351FI");
            colDonFecha_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.colDonFecha_351FI");
            colDonSocio_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.colDonSocio_351FI");
            colDonCantidad_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.colDonCantidad_351FI");
            colDonLibros_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.colDonLibros_351FI");
            btnConfirmar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.btnConfirmar_351FI");
            btnCancelar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormDonacion_351FI.btnCancelar_351FI");
            MostrarSocio_351FI();
            if (bll_Donacion_351FI != null) MostrarDetalle_351FI();
            AyudaFormulario_351FI.Aplicar_351FI(this, bll_idioma_351FI);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma_351FI.Desuscribir_351FI(this);
            base.OnFormClosed(e);
        }
    }
}
