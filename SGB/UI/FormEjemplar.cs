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
    public partial class FormEjemplar : Form, IObservadorIdioma
    {
        BLL_Idioma bll_idioma = new BLL_Idioma();
        BLL_Ejemplar bll_Ejemplar;
        BLL_Libro bll_Libro;
        List<BE_Ejemplar> ejemplaresMostrados = new List<BE_Ejemplar>();
        BE_Ejemplar? ejemplarSeleccionado;
        List<BE_Libro> librosActivos = new List<BE_Libro>();
        int librosFiltrados;

        public FormEjemplar()
        {
            InitializeComponent();
            bll_idioma.Suscribir(this);
        }

        private void FormEjemplar_Load(object sender, EventArgs e)
        {
            bll_Ejemplar = new BLL_Ejemplar();
            bll_Libro = new BLL_Libro();

            dgvEjemplares.AutoGenerateColumns = false;
            colEjeCodigo.DataPropertyName = "Codigo";
            colEjeTitulo.DataPropertyName = "Titulo";
            colEjeAutor.DataPropertyName = "Autor";
            colEjeEstado.DataPropertyName = "Estado";

            // Solo se pueden asignar libros activos
            cboLibro.DisplayMember = "Texto";
            cboLibro.ValueMember = "Codigo";
            librosActivos = bll_Libro.ObtenerActivos();
            FiltrarLibros();

            CargarEjemplares();
            ActualizarIdioma();
            this.Shown += FormEjemplar_Shown;
        }

        // La grilla selecciona la primera fila al mostrarse; se limpia para no precargar los datos de un ejemplar
        private void FormEjemplar_Shown(object? sender, EventArgs e)
        {
            dgvEjemplares.ClearSelection();
            Limpiar();
        }

        private void CargarEjemplares()
        {
            ejemplaresMostrados = bll_Ejemplar.BuscarParaGestion(txtBuscar.Text);
            dgvEjemplares.DataSource = null;
            dgvEjemplares.DataSource = bll_Ejemplar.ConsultarParaGrilla(ejemplaresMostrados);
            dgvEjemplares.ClearSelection();
            Limpiar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarEjemplares();
        }

        // ------------------------------------------------------------ Buscador de libros
        private void FiltrarLibros()
        {
            List<BE_Libro> filtrados = bll_Libro.FiltrarLibros(librosActivos, txtBuscarLibro.Text);
            cboLibro.DataSource = null;
            cboLibro.DisplayMember = "Texto";
            cboLibro.ValueMember = "Codigo";
            cboLibro.DataSource = bll_Libro.ConsultarParaCombo(filtrados);

            // Con texto en el buscador se preselecciona la primera coincidencia
            bool hayFiltro = txtBuscarLibro.Text.Trim() != "";
            cboLibro.SelectedIndex = hayFiltro && filtrados.Count > 0 ? 0 : -1;

            librosFiltrados = filtrados.Count;
            MostrarEtiquetaLibro();
        }

        private void MostrarEtiquetaLibro()
        {
            bool hayFiltro = txtBuscarLibro.Text.Trim() != "";
            lblLibro.Text = hayFiltro && librosFiltrados == 0
                ? bll_idioma.Traducir("FormEjemplar.libroNoEncontrado")
                : hayFiltro ? $"{bll_idioma.Traducir("FormEjemplar.lblLibro")} - {bll_idioma.Traducir("FormEjemplar.coincidencias")} {librosFiltrados}" : bll_idioma.Traducir("FormEjemplar.lblLibro");
        }

        private void txtBuscarLibro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLibros();
        }

        private void dgvEjemplares_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEjemplares.SelectedRows.Count == 0) return;

            string codigo = dgvEjemplares.SelectedRows[0].Cells[colEjeCodigo.Index].Value?.ToString() ?? "";
            ejemplarSeleccionado = ejemplaresMostrados.FirstOrDefault(ej => ej.CodigoEjemplar == codigo);
            if (ejemplarSeleccionado == null) return;

            MostrarCodigo();
            txtBuscarLibro.Clear();
            cboLibro.SelectedIndex = -1;
            cboLibro.SelectedValue = ejemplarSeleccionado.Libro.CodigoLibro;
        }

        private void Limpiar()
        {
            ejemplarSeleccionado = null;
            MostrarCodigo();
            txtBuscarLibro.Clear();
            cboLibro.SelectedIndex = -1;
        }

        private void MostrarCodigo()
        {
            bool dadoDeBaja = ejemplarSeleccionado != null && ejemplarSeleccionado.Estado == "Baja";
            // A un ejemplar existente no se le puede cambiar el libro: con uno seleccionado, el libro es solo de consulta
            txtBuscarLibro.Enabled = ejemplarSeleccionado == null;
            cboLibro.Enabled = ejemplarSeleccionado == null;
            btnAlta.Enabled = ejemplarSeleccionado == null;
            btnBaja.Enabled = ejemplarSeleccionado != null && !dadoDeBaja;
            btnReactivar.Enabled = dadoDeBaja;

            lblCodigo.Text = ejemplarSeleccionado == null
                ? bll_idioma.Traducir("FormEjemplar.codigoNuevo")
                : $"{bll_idioma.Traducir("FormEjemplar.lblCodigo")} {ejemplarSeleccionado.CodigoEjemplar} ({ejemplarSeleccionado.Estado})";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvEjemplares.ClearSelection();
            Limpiar();
        }

        private BE_Libro? LibroElegido()
        {
            if (cboLibro.SelectedValue == null) return null;
            BE_Libro libro = new BE_Libro();
            libro.CodigoLibro = cboLibro.SelectedValue.ToString() ?? "";
            return libro;
        }

        // ------------------------------------------------------------ Alta
        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Ejemplar ejemplar = new BE_Ejemplar();
                ejemplar.Libro = LibroElegido();
                bll_Ejemplar.Alta(ejemplar);

                MessageBox.Show($"Ejemplar dado de alta correctamente con el código {ejemplar.CodigoEjemplar}.", "Alta de ejemplar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEjemplares();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ------------------------------------------------------------ Baja
        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (ejemplarSeleccionado == null) throw new Exception("Seleccione el ejemplar a dar de baja.");

                if (MessageBox.Show($"¿Confirma la baja del ejemplar {ejemplarSeleccionado.CodigoEjemplar} ({ejemplarSeleccionado.Libro.Titulo})?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_Ejemplar.Baja(ejemplarSeleccionado);
                MessageBox.Show("Ejemplar dado de baja correctamente.", "Baja de ejemplar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEjemplares();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ------------------------------------------------------------ Reactivación (vuelve a dar de alta un ejemplar dado de baja)
        private void btnReactivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ejemplarSeleccionado == null) throw new Exception("Seleccione el ejemplar a reactivar.");

                if (MessageBox.Show($"¿Confirma la reactivación del ejemplar {ejemplarSeleccionado.CodigoEjemplar} ({ejemplarSeleccionado.Libro.Titulo})?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_Ejemplar.Reactivar(ejemplarSeleccionado);
                MessageBox.Show("Ejemplar reactivado correctamente. Vuelve a estar disponible para préstamos.", "Reactivación de ejemplar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEjemplares();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ------------------------------------------------------------ Idioma
        public void ActualizarIdioma()
        {
            this.Text = bll_idioma.Traducir("FormEjemplar.Form");
            lblSeccionEjemplares.Text = bll_idioma.Traducir("FormEjemplar.lblSeccionEjemplares");
            lblBuscar.Text = bll_idioma.Traducir("FormEjemplar.lblBuscar");
            colEjeCodigo.HeaderText = bll_idioma.Traducir("FormEjemplar.colEjeCodigo");
            colEjeTitulo.HeaderText = bll_idioma.Traducir("FormEjemplar.colEjeTitulo");
            colEjeAutor.HeaderText = bll_idioma.Traducir("FormEjemplar.colEjeAutor");
            colEjeEstado.HeaderText = bll_idioma.Traducir("FormEjemplar.colEjeEstado");
            lblSeccionDatos.Text = bll_idioma.Traducir("FormEjemplar.lblSeccionDatos");
            txtBuscarLibro.PlaceholderText = bll_idioma.Traducir("FormEjemplar.txtBuscarLibro");
            btnAlta.Text = bll_idioma.Traducir("FormEjemplar.btnAlta");
            btnBaja.Text = bll_idioma.Traducir("FormEjemplar.btnBaja");
            btnReactivar.Text = bll_idioma.Traducir("FormEjemplar.btnReactivar");
            btnLimpiar.Text = bll_idioma.Traducir("FormEjemplar.btnLimpiar");
            btnCerrar.Text = bll_idioma.Traducir("FormEjemplar.btnCerrar");
            if (bll_Libro == null) return;
            MostrarCodigo();
            MostrarEtiquetaLibro();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma.Desuscribir(this);
            base.OnFormClosed(e);
        }
    }
}
