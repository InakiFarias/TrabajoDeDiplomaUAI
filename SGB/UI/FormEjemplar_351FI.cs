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
    public partial class FormEjemplar_351FI : Form, IObservadorIdioma_351FI
    {
        BLL_Idioma_351FI bll_idioma_351FI = new BLL_Idioma_351FI();
        BLL_Ejemplar_351FI bll_Ejemplar_351FI;
        BLL_Libro_351FI bll_Libro_351FI;
        List<BE_Ejemplar_351FI> ejemplaresMostrados_351FI = new List<BE_Ejemplar_351FI>();
        BE_Ejemplar_351FI? ejemplarSeleccionado_351FI;
        List<BE_Libro_351FI> librosActivos_351FI = new List<BE_Libro_351FI>();
        int librosFiltrados_351FI;

        public FormEjemplar_351FI()
        {
            InitializeComponent();
            bll_idioma_351FI.Suscribir_351FI(this);
        }

        private void FormEjemplar_351FI_Load(object sender_351FI, EventArgs e_351FI)
        {
            bll_Ejemplar_351FI = new BLL_Ejemplar_351FI();
            bll_Libro_351FI = new BLL_Libro_351FI();

            dgvEjemplares_351FI.AutoGenerateColumns = false;
            colEjeCodigo_351FI.DataPropertyName = "Codigo";
            colEjeTitulo_351FI.DataPropertyName = "Titulo";
            colEjeAutor_351FI.DataPropertyName = "Autor";
            colEjeEstado_351FI.DataPropertyName = "Estado";

            // Solo se pueden asignar libros activos
            cboLibro_351FI.DisplayMember = "Texto";
            cboLibro_351FI.ValueMember = "Codigo";
            librosActivos_351FI = bll_Libro_351FI.ObtenerActivos_351FI();
            FiltrarLibros_351FI();

            CargarEjemplares_351FI();
            ActualizarIdioma_351FI();
            this.Shown += FormEjemplar_351FI_Shown;
        }

        // La grilla selecciona la primera fila al mostrarse; se limpia para no precargar los datos de un ejemplar
        private void FormEjemplar_351FI_Shown(object? sender_351FI, EventArgs e_351FI)
        {
            dgvEjemplares_351FI.ClearSelection();
            Limpiar_351FI();
        }

        private void CargarEjemplares_351FI()
        {
            ejemplaresMostrados_351FI = bll_Ejemplar_351FI.BuscarParaGestion_351FI(txtBuscar_351FI.Text);
            dgvEjemplares_351FI.DataSource = null;
            dgvEjemplares_351FI.DataSource = bll_Ejemplar_351FI.ConsultarParaGrilla_351FI(ejemplaresMostrados_351FI);
            dgvEjemplares_351FI.ClearSelection();
            Limpiar_351FI();
        }

        private void txtBuscar_351FI_TextChanged(object sender_351FI, EventArgs e_351FI)
        {
            CargarEjemplares_351FI();
        }

        // ------------------------------------------------------------ Buscador de libros
        private void FiltrarLibros_351FI()
        {
            List<BE_Libro_351FI> filtrados = bll_Libro_351FI.FiltrarLibros_351FI(librosActivos_351FI, txtBuscarLibro_351FI.Text);
            cboLibro_351FI.DataSource = null;
            cboLibro_351FI.DisplayMember = "Texto";
            cboLibro_351FI.ValueMember = "Codigo";
            cboLibro_351FI.DataSource = bll_Libro_351FI.ConsultarParaCombo_351FI(filtrados);

            // Con texto en el buscador se preselecciona la primera coincidencia
            bool hayFiltro = txtBuscarLibro_351FI.Text.Trim() != "";
            cboLibro_351FI.SelectedIndex = hayFiltro && filtrados.Count > 0 ? 0 : -1;

            librosFiltrados_351FI = filtrados.Count;
            MostrarEtiquetaLibro_351FI();
        }

        private void MostrarEtiquetaLibro_351FI()
        {
            bool hayFiltro = txtBuscarLibro_351FI.Text.Trim() != "";
            lblLibro_351FI.Text = hayFiltro && librosFiltrados_351FI == 0
                ? bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.libroNoEncontrado")
                : hayFiltro ? $"{bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.lblLibro_351FI")} - {bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.coincidencias")} {librosFiltrados_351FI}" : bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.lblLibro_351FI");
        }

        private void txtBuscarLibro_351FI_TextChanged(object sender_351FI, EventArgs e_351FI)
        {
            FiltrarLibros_351FI();
        }

        private void dgvEjemplares_351FI_SelectionChanged(object sender_351FI, EventArgs e_351FI)
        {
            if (dgvEjemplares_351FI.SelectedRows.Count == 0) return;

            string codigo = dgvEjemplares_351FI.SelectedRows[0].Cells[colEjeCodigo_351FI.Index].Value?.ToString() ?? "";
            ejemplarSeleccionado_351FI = ejemplaresMostrados_351FI.FirstOrDefault(ej => ej.CodigoEjemplar_351FI == codigo);
            if (ejemplarSeleccionado_351FI == null) return;

            MostrarCodigo_351FI();
            txtBuscarLibro_351FI.Clear();
            cboLibro_351FI.SelectedIndex = -1;
            cboLibro_351FI.SelectedValue = ejemplarSeleccionado_351FI.Libro_351FI.CodigoLibro_351FI;
        }

        private void Limpiar_351FI()
        {
            ejemplarSeleccionado_351FI = null;
            MostrarCodigo_351FI();
            txtBuscarLibro_351FI.Clear();
            cboLibro_351FI.SelectedIndex = -1;
        }

        private void MostrarCodigo_351FI()
        {
            bool dadoDeBaja = ejemplarSeleccionado_351FI != null && ejemplarSeleccionado_351FI.Estado_351FI == "Baja";
            // A un ejemplar existente no se le puede cambiar el libro: con uno seleccionado, el libro es solo de consulta
            txtBuscarLibro_351FI.Enabled = ejemplarSeleccionado_351FI == null;
            cboLibro_351FI.Enabled = ejemplarSeleccionado_351FI == null;
            btnAlta_351FI.Enabled = ejemplarSeleccionado_351FI == null;
            btnBaja_351FI.Enabled = ejemplarSeleccionado_351FI != null && !dadoDeBaja;
            btnReactivar_351FI.Enabled = dadoDeBaja;

            lblCodigo_351FI.Text = ejemplarSeleccionado_351FI == null
                ? bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.codigoNuevo")
                : $"{bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.lblCodigo_351FI")} {ejemplarSeleccionado_351FI.CodigoEjemplar_351FI} ({ejemplarSeleccionado_351FI.Estado_351FI})";
        }

        private void btnLimpiar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            dgvEjemplares_351FI.ClearSelection();
            Limpiar_351FI();
        }

        private BE_Libro_351FI? LibroElegido_351FI()
        {
            if (cboLibro_351FI.SelectedValue == null) return null;
            BE_Libro_351FI libro = new BE_Libro_351FI();
            libro.CodigoLibro_351FI = cboLibro_351FI.SelectedValue.ToString() ?? "";
            return libro;
        }

        // ------------------------------------------------------------ Alta
        private void btnAlta_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                BE_Ejemplar_351FI ejemplar = new BE_Ejemplar_351FI();
                ejemplar.Libro_351FI = LibroElegido_351FI();
                bll_Ejemplar_351FI.Alta_351FI(ejemplar);

                MessageBox.Show($"Ejemplar dado de alta correctamente con el código {ejemplar.CodigoEjemplar_351FI}.", "Alta de ejemplar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEjemplares_351FI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ------------------------------------------------------------ Baja
        private void btnBaja_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (ejemplarSeleccionado_351FI == null) throw new Exception("Seleccione el ejemplar a dar de baja.");

                if (MessageBox.Show($"¿Confirma la baja del ejemplar {ejemplarSeleccionado_351FI.CodigoEjemplar_351FI} ({ejemplarSeleccionado_351FI.Libro_351FI.Titulo_351FI})?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_Ejemplar_351FI.Baja_351FI(ejemplarSeleccionado_351FI);
                MessageBox.Show("Ejemplar dado de baja correctamente.", "Baja de ejemplar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEjemplares_351FI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ------------------------------------------------------------ Reactivación (vuelve a dar de alta un ejemplar dado de baja)
        private void btnReactivar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (ejemplarSeleccionado_351FI == null) throw new Exception("Seleccione el ejemplar a reactivar.");

                if (MessageBox.Show($"¿Confirma la reactivación del ejemplar {ejemplarSeleccionado_351FI.CodigoEjemplar_351FI} ({ejemplarSeleccionado_351FI.Libro_351FI.Titulo_351FI})?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_Ejemplar_351FI.Reactivar_351FI(ejemplarSeleccionado_351FI);
                MessageBox.Show("Ejemplar reactivado correctamente. Vuelve a estar disponible para préstamos.", "Reactivación de ejemplar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEjemplares_351FI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCerrar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            this.Close();
        }

        // ------------------------------------------------------------ Idioma
        public void ActualizarIdioma_351FI()
        {
            this.Text = bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.Form");
            lblSeccionEjemplares_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.lblSeccionEjemplares_351FI");
            lblBuscar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.lblBuscar_351FI");
            colEjeCodigo_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.colEjeCodigo_351FI");
            colEjeTitulo_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.colEjeTitulo_351FI");
            colEjeAutor_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.colEjeAutor_351FI");
            colEjeEstado_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.colEjeEstado_351FI");
            lblSeccionDatos_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.lblSeccionDatos_351FI");
            txtBuscarLibro_351FI.PlaceholderText = bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.txtBuscarLibro_351FI");
            btnAlta_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.btnAlta_351FI");
            btnBaja_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.btnBaja_351FI");
            btnReactivar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.btnReactivar_351FI");
            btnLimpiar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.btnLimpiar_351FI");
            btnCerrar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormEjemplar_351FI.btnCerrar_351FI");
            if (bll_Libro_351FI == null) return;
            MostrarCodigo_351FI();
            MostrarEtiquetaLibro_351FI();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma_351FI.Desuscribir_351FI(this);
            base.OnFormClosed(e);
        }
    }
}
