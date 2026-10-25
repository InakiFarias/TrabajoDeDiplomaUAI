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

namespace UI
{
    public partial class FormEjemplar : Form
    {
        BLL_Ejemplar bll_Ejemplar;
        BLL_Libro bll_Libro;
        List<BE_Ejemplar> ejemplaresMostrados = new List<BE_Ejemplar>();
        BE_Ejemplar? ejemplarSeleccionado;
        List<BE_Libro> librosActivos = new List<BE_Libro>();

        public FormEjemplar()
        {
            InitializeComponent();
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

            lblLibro.Text = hayFiltro && filtrados.Count == 0
                ? "Libro al que pertenece: no se encontró el libro, registralo primero en Gestión de libros"
                : hayFiltro ? $"Libro al que pertenece - coincidencias: {filtrados.Count}" : "Libro al que pertenece";
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

            lblCodigo.Text = $"Código: {ejemplarSeleccionado.CodigoEjemplar} ({ejemplarSeleccionado.Estado})";
            txtBuscarLibro.Clear();
            cboLibro.SelectedIndex = -1;
            cboLibro.SelectedValue = ejemplarSeleccionado.Libro.CodigoLibro;
        }

        private void Limpiar()
        {
            ejemplarSeleccionado = null;
            lblCodigo.Text = "Código: — (se asigna al dar de alta)";
            txtBuscarLibro.Clear();
            cboLibro.SelectedIndex = -1;
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

        // ------------------------------------------------------------ Modificación
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ejemplarSeleccionado == null) throw new Exception("Seleccione el ejemplar a modificar.");

                BE_Ejemplar ejemplar = new BE_Ejemplar(ejemplarSeleccionado.CodigoEjemplar, LibroElegido(), ejemplarSeleccionado.Estado);
                if (MessageBox.Show($"¿Confirma la modificación del ejemplar {ejemplar.CodigoEjemplar}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_Ejemplar.Modificar(ejemplar);
                MessageBox.Show("Ejemplar modificado correctamente.", "Modificación de ejemplar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
