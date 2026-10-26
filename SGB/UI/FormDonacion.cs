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
    public partial class FormDonacion : Form, IObservadorIdioma
    {
        BLL_Idioma bll_idioma = new BLL_Idioma();
        BLL_Socio bll_Socio;
        BLL_Libro bll_Libro;
        BLL_Donacion bll_Donacion;
        BE_Socio? socioSeleccionado;
        List<BE_Libro> librosActivos = new List<BE_Libro>();
        List<BE_Libro> librosMostrados = new List<BE_Libro>();
        // Ejemplares nuevos que se crean al confirmar la donación (uno por copia donada)
        List<BE_Ejemplar> detalle = new List<BE_Ejemplar>();

        public FormDonacion()
        {
            InitializeComponent();
            bll_idioma.Suscribir(this);
        }

        private void FormDonacion_Load(object sender, EventArgs e)
        {
            bll_Socio = new BLL_Socio();
            bll_Libro = new BLL_Libro();
            bll_Donacion = new BLL_Donacion();

            dgvSocios.AutoGenerateColumns = false;
            colSocNumero.DataPropertyName = "NumeroSocio";
            colSocApellido.DataPropertyName = "Apellido";
            colSocNombre.DataPropertyName = "Nombre";
            colSocDni.DataPropertyName = "Dni";

            dgvLibros.AutoGenerateColumns = false;
            colLibCodigo.DataPropertyName = "Codigo";
            colLibTitulo.DataPropertyName = "Titulo";
            colLibAutores.DataPropertyName = "Autores";

            dgvDetalle.AutoGenerateColumns = false;
            colDetLibro.DataPropertyName = "Codigo";
            colDetTitulo.DataPropertyName = "Titulo";
            colDetAutor.DataPropertyName = "Autor";

            dgvDonaciones.AutoGenerateColumns = false;
            colDonNumero.DataPropertyName = "Numero";
            colDonFecha.DataPropertyName = "Fecha";
            colDonSocio.DataPropertyName = "Socio";
            colDonCantidad.DataPropertyName = "Cantidad";
            colDonLibros.DataPropertyName = "Libros";

            Mostrar(dgvSocios, bll_Socio.ObtenerActivos());
            // Los libros activos se cargan una vez y se filtran en memoria con el buscador
            librosActivos = bll_Libro.ObtenerActivos();
            CargarLibros();
            CargarDonaciones();
            ActualizarIdioma();
        }

        // Donaciones ya registradas, para consulta
        private void CargarDonaciones()
        {
            Mostrar(dgvDonaciones, bll_Donacion.ConsultarDonacionesParaGrilla(bll_Donacion.ObtenerDonaciones()));
            dgvDonaciones.ClearSelection();
        }

        private void MostrarSocio()
        {
            lblDatosSocio.Text = socioSeleccionado == null
                ? $"{bll_idioma.Traducir("FormDonacion.lblDatosSocio")} —"
                : $"{bll_idioma.Traducir("FormDonacion.lblDatosSocio")} {socioSeleccionado.Apellido}, {socioSeleccionado.Nombre} - {bll_idioma.Traducir("FormDonacion.colSocDni")} {socioSeleccionado.Dni}";
        }

        private void Mostrar(DataGridView grilla, object datos)
        {
            grilla.DataSource = null;
            grilla.DataSource = datos;
        }

        // ------------------------------------------------------------ Socio donante
        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            Mostrar(dgvSocios, bll_Socio.BuscarActivosPorDni(txtDni.Text));
        }

        private void dgvSocios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnAgregarSocio_Click(sender, e);
        }

        private void btnAgregarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSocios.Rows.Count == 0) throw new Exception("No existe un socio registrado con el DNI ingresado.");
                if (dgvSocios.SelectedRows.Count == 0) throw new Exception("Seleccione un socio.");

                socioSeleccionado = (BE_Socio)dgvSocios.SelectedRows[0].DataBoundItem;
                MostrarSocio();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ------------------------------------------------------------ Libros donados
        private void txtBuscarLibro_TextChanged(object sender, EventArgs e)
        {
            CargarLibros();
        }

        // Con el buscador vacío se listan todos los libros activos del catálogo
        private void CargarLibros()
        {
            librosMostrados = bll_Libro.FiltrarLibros(librosActivos, txtBuscarLibro.Text);
            Mostrar(dgvLibros, bll_Libro.ConsultarParaGrilla(librosMostrados));
        }

        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnAgregarEjemplar_Click(sender, e);
        }

        // Cada clic agrega un ejemplar nuevo del libro elegido; si se donan varias copias, se agrega varias veces
        private void btnAgregarEjemplar_Click(object sender, EventArgs e)
        {
            try
            {
                if (socioSeleccionado == null) throw new Exception("Primero debe seleccionar al socio donante.");
                if (dgvLibros.Rows.Count == 0) throw new Exception("No existe un libro que coincida con la búsqueda. Regístrelo primero en Gestión de libros.");
                if (dgvLibros.SelectedRows.Count == 0) throw new Exception("Seleccione un libro.");

                BE_Libro libro = librosMostrados[dgvLibros.SelectedRows[0].Index];
                detalle.Add(bll_Donacion.CrearEjemplarDonado(libro));
                MostrarDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnQuitarEjemplar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.SelectedRows.Count == 0) return;

            detalle.RemoveAt(dgvDetalle.SelectedRows[0].Index);
            MostrarDetalle();
        }

        private void MostrarDetalle()
        {
            Mostrar(dgvDetalle, bll_Donacion.ConsultarDetalleParaGrilla(detalle));
            lblDetalleCantidad.Text = $"{bll_idioma.Traducir("FormDonacion.lblDetalleCantidad")} {detalle.Count}";
        }

        // ------------------------------------------------------ Confirmar / Cancelar
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (socioSeleccionado == null) throw new Exception("Debe seleccionar al socio donante.");
                if (detalle.Count == 0) throw new Exception("Debe agregar al menos un ejemplar donado.");

                string resumen = $"Socio donante: {socioSeleccionado.Apellido}, {socioSeleccionado.Nombre}\n" +
                                 $"Ejemplares donados: {detalle.Count}\n\n" +
                                 "Se darán de alta los ejemplares en el catálogo.\n¿Confirma la donación?";
                if (MessageBox.Show(resumen, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                BE_Donacion donacion = new BE_Donacion();
                donacion.Socio = socioSeleccionado;
                donacion.Ejemplares = detalle;

                BE_ReciboDonacion recibo = bll_Donacion.Registrar(donacion);

                string codigos = string.Join(", ", donacion.Ejemplares.Select(ej => ej.CodigoEjemplar));
                MessageBox.Show($"Donación N° {donacion.NumeroDonacion} registrada correctamente.\nEjemplares dados de alta: {codigos}",
                                "Donación registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    ComprobantesPDF.ReciboDonacion(recibo);
                }
                catch (Exception exPdf)
                {
                    MessageBox.Show($"La donación quedó registrada, pero no se pudo generar el recibo en PDF.\n{exPdf.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
            this.Text = bll_idioma.Traducir("FormDonacion.Form");
            lblSeccionSocio.Text = bll_idioma.Traducir("FormDonacion.lblSeccionSocio");
            lblDni.Text = bll_idioma.Traducir("FormDonacion.lblDni");
            btnAgregarSocio.Text = bll_idioma.Traducir("FormDonacion.btnAgregarSocio");
            colSocNumero.HeaderText = bll_idioma.Traducir("FormDonacion.colSocNumero");
            colSocApellido.HeaderText = bll_idioma.Traducir("FormDonacion.colSocApellido");
            colSocNombre.HeaderText = bll_idioma.Traducir("FormDonacion.colSocNombre");
            colSocDni.HeaderText = bll_idioma.Traducir("FormDonacion.colSocDni");
            lblSeccionEjemplares.Text = bll_idioma.Traducir("FormDonacion.lblSeccionEjemplares");
            lblBuscarLibro.Text = bll_idioma.Traducir("FormDonacion.lblBuscarLibro");
            btnAgregarEjemplar.Text = bll_idioma.Traducir("FormDonacion.btnAgregarEjemplar");
            colLibCodigo.HeaderText = bll_idioma.Traducir("FormDonacion.colLibCodigo");
            colLibTitulo.HeaderText = bll_idioma.Traducir("FormDonacion.colLibTitulo");
            colLibAutores.HeaderText = bll_idioma.Traducir("FormDonacion.colLibAutores");
            lblAyudaLibro.Text = bll_idioma.Traducir("FormDonacion.lblAyudaLibro");
            lblSeccionDetalle.Text = bll_idioma.Traducir("FormDonacion.lblSeccionDetalle");
            colDetLibro.HeaderText = bll_idioma.Traducir("FormDonacion.colDetLibro");
            colDetTitulo.HeaderText = bll_idioma.Traducir("FormDonacion.colDetTitulo");
            colDetAutor.HeaderText = bll_idioma.Traducir("FormDonacion.colDetAutor");
            btnQuitarEjemplar.Text = bll_idioma.Traducir("FormDonacion.btnQuitarEjemplar");
            lblAyudaDetalle.Text = bll_idioma.Traducir("FormDonacion.lblAyudaDetalle");
            lblSeccionDonaciones.Text = bll_idioma.Traducir("FormDonacion.lblSeccionDonaciones");
            colDonNumero.HeaderText = bll_idioma.Traducir("FormDonacion.colDonNumero");
            colDonFecha.HeaderText = bll_idioma.Traducir("FormDonacion.colDonFecha");
            colDonSocio.HeaderText = bll_idioma.Traducir("FormDonacion.colDonSocio");
            colDonCantidad.HeaderText = bll_idioma.Traducir("FormDonacion.colDonCantidad");
            colDonLibros.HeaderText = bll_idioma.Traducir("FormDonacion.colDonLibros");
            btnConfirmar.Text = bll_idioma.Traducir("FormDonacion.btnConfirmar");
            btnCancelar.Text = bll_idioma.Traducir("FormDonacion.btnCancelar");
            MostrarSocio();
            if (bll_Donacion != null) MostrarDetalle();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma.Desuscribir(this);
            base.OnFormClosed(e);
        }
    }
}
