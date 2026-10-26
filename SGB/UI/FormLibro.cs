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
    public partial class FormLibro : Form, IObservadorIdioma
    {
        BLL_Idioma bll_idioma = new BLL_Idioma();
        BLL_Libro bll_Libro;
        List<BE_Libro> librosMostrados = new List<BE_Libro>();
        BE_Libro? libroSeleccionado;

        // Autores: la lista visible se filtra con el buscador, por eso las marcas se guardan aparte
        List<BE_Autor> todosLosAutores = new List<BE_Autor>();
        HashSet<int> autoresMarcados = new HashSet<int>();
        bool cargandoAutores;
        int autoresFiltrados = -1;

        public FormLibro()
        {
            InitializeComponent();
            bll_idioma.Suscribir(this);
        }

        private void FormLibro_Load(object sender, EventArgs e)
        {
            bll_Libro = new BLL_Libro();

            dgvLibros.AutoGenerateColumns = false;
            colLibCodigo.DataPropertyName = "Codigo";
            colLibTitulo.DataPropertyName = "Titulo";
            colLibAutores.DataPropertyName = "Autores";
            colLibTemas.DataPropertyName = "Temas";
            colLibEstado.DataPropertyName = "Estado";

            CargarAutores(new List<int>());
            CargarTemas(new List<int>());
            CargarLibros();
            ActualizarIdioma();
            this.Shown += FormLibro_Shown;
        }

        // La grilla selecciona la primera fila al mostrarse; se limpia para no precargar los datos de un libro
        private void FormLibro_Shown(object? sender, EventArgs e)
        {
            dgvLibros.ClearSelection();
            Limpiar();
        }

        private void CargarLibros()
        {
            librosMostrados = bll_Libro.BuscarPorTexto(txtBuscar.Text);
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = bll_Libro.ConsultarParaGrilla(librosMostrados);
            dgvLibros.ClearSelection();
            Limpiar();
        }

        private void CargarAutores(List<int> codigosMarcados)
        {
            todosLosAutores = bll_Libro.ObtenerAutores();
            MarcarAutores(codigosMarcados);
        }

        // Muestra solo los autores que coinciden con el buscador, conservando los que ya estaban marcados
        private void FiltrarAutores()
        {
            List<BE_Autor> filtrados = bll_Libro.FiltrarAutores(todosLosAutores, txtBuscarAutor.Text);

            cargandoAutores = true;
            clbAutores.Items.Clear();
            foreach (BE_Autor autor in filtrados)
                clbAutores.Items.Add(autor, autoresMarcados.Contains(autor.CodigoAutor));
            cargandoAutores = false;

            autoresFiltrados = filtrados.Count;
            MostrarEtiquetaAutores();
        }

        private void MostrarEtiquetaAutores()
        {
            bool sinResultados = autoresFiltrados == 0 && txtBuscarAutor.Text.Trim() != "";
            lblAutores.Text = sinResultados
                ? bll_idioma.Traducir("FormLibro.autorNoRegistrado")
                : $"{bll_idioma.Traducir("FormLibro.lblAutores")} - {bll_idioma.Traducir("FormLibro.marcados")} {autoresMarcados.Count}";
        }

        private void txtBuscarAutor_TextChanged(object sender, EventArgs e)
        {
            FiltrarAutores();
        }

        private void clbAutores_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (cargandoAutores) return;

            int codigo = ((BE_Autor)clbAutores.Items[e.Index]).CodigoAutor;
            if (e.NewValue == CheckState.Checked) autoresMarcados.Add(codigo);
            else autoresMarcados.Remove(codigo);
            MostrarEtiquetaAutores();
        }

        private void CargarTemas(List<int> codigosMarcados)
        {
            clbTemas.Items.Clear();
            foreach (BE_Tema tema in bll_Libro.ObtenerTemas())
                clbTemas.Items.Add(tema, codigosMarcados.Contains(tema.CodigoTema));
        }

        private List<BE_Autor> AutoresMarcados() => todosLosAutores.Where(a => autoresMarcados.Contains(a.CodigoAutor)).ToList();

        private List<BE_Tema> TemasMarcados() => clbTemas.CheckedItems.Cast<BE_Tema>().ToList();

        private void MarcarAutores(List<int> codigos)
        {
            autoresMarcados = new HashSet<int>(codigos);
            FiltrarAutores();
        }

        private void MarcarTemas(List<int> codigos)
        {
            for (int i = 0; i < clbTemas.Items.Count; i++)
                clbTemas.SetItemChecked(i, codigos.Contains(((BE_Tema)clbTemas.Items[i]).CodigoTema));
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarLibros();
        }

        private void dgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count == 0) return;

            string codigo = dgvLibros.SelectedRows[0].Cells[colLibCodigo.Index].Value?.ToString() ?? "";
            libroSeleccionado = librosMostrados.FirstOrDefault(l => l.CodigoLibro == codigo);
            if (libroSeleccionado == null) return;

            MostrarCodigo();
            txtTituloLibro.Text = libroSeleccionado.Titulo;
            txtBuscarAutor.Clear();
            MarcarAutores(libroSeleccionado.Autores.Select(a => a.CodigoAutor).ToList());
            MarcarTemas(libroSeleccionado.Temas.Select(t => t.CodigoTema).ToList());
        }

        private void Limpiar()
        {
            libroSeleccionado = null;
            MostrarCodigo();
            txtTituloLibro.Clear();
            txtBuscarAutor.Clear();
            MarcarAutores(new List<int>());
            MarcarTemas(new List<int>());
        }

        private void MostrarCodigo()
        {
            bool dadoDeBaja = libroSeleccionado != null && libroSeleccionado.Estado == "Baja";
            btnModificar.Enabled = libroSeleccionado != null && !dadoDeBaja;
            btnBaja.Enabled = libroSeleccionado != null && !dadoDeBaja;
            btnReactivar.Enabled = dadoDeBaja;

            lblCodigo.Text = libroSeleccionado == null
                ? bll_idioma.Traducir("FormLibro.codigoNuevo")
                : $"{bll_idioma.Traducir("FormLibro.lblCodigo")} {libroSeleccionado.CodigoLibro} ({libroSeleccionado.Estado})";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvLibros.ClearSelection();
            Limpiar();
            txtTituloLibro.Focus();
        }

        // ------------------------------------------------------------ Autores y temas nuevos
        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> marcados = AutoresMarcados().Select(a => a.CodigoAutor).ToList();
                BE_Autor autor = bll_Libro.AgregarAutor(txtAutorNombre.Text, txtAutorApellido.Text);
                marcados.Add(autor.CodigoAutor);
                txtBuscarAutor.Clear();
                CargarAutores(marcados);
                txtAutorNombre.Clear();
                txtAutorApellido.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregarTema_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> marcados = TemasMarcados().Select(t => t.CodigoTema).ToList();
                BE_Tema tema = bll_Libro.AgregarTema(txtTema.Text);
                marcados.Add(tema.CodigoTema);
                CargarTemas(marcados);
                txtTema.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ------------------------------------------------------------ Alta
        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Libro libro = new BE_Libro("", txtTituloLibro.Text, AutoresMarcados(), TemasMarcados());
                bll_Libro.Alta(libro);

                MessageBox.Show($"Libro dado de alta correctamente con el código {libro.CodigoLibro}.", "Alta de libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLibros();
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
                if (libroSeleccionado == null) throw new Exception("Seleccione el libro a modificar.");

                BE_Libro libro = new BE_Libro(libroSeleccionado.CodigoLibro, txtTituloLibro.Text, AutoresMarcados(), TemasMarcados());
                libro.Estado = libroSeleccionado.Estado;
                if (MessageBox.Show($"¿Confirma la modificación del libro {libro.CodigoLibro}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_Libro.Modificar(libro);
                MessageBox.Show("Libro modificado correctamente.", "Modificación de libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLibros();
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
                if (libroSeleccionado == null) throw new Exception("Seleccione el libro a dar de baja.");

                if (MessageBox.Show($"¿Confirma la baja del libro \"{libroSeleccionado.Titulo}\"?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_Libro.Baja(libroSeleccionado);
                MessageBox.Show("Libro dado de baja correctamente.", "Baja de libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLibros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ------------------------------------------------------------ Reactivación (vuelve a dar de alta un libro dado de baja)
        private void btnReactivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (libroSeleccionado == null) throw new Exception("Seleccione el libro a reactivar.");

                if (MessageBox.Show($"¿Confirma la reactivación del libro \"{libroSeleccionado.Titulo}\"?\nSus ejemplares dados de baja se reactivan aparte, desde Gestión de ejemplares.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_Libro.Reactivar(libroSeleccionado);
                MessageBox.Show("Libro reactivado correctamente.", "Reactivación de libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLibros();
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
            this.Text = bll_idioma.Traducir("FormLibro.Form");
            lblSeccionLibros.Text = bll_idioma.Traducir("FormLibro.lblSeccionLibros");
            lblBuscar.Text = bll_idioma.Traducir("FormLibro.lblBuscar");
            colLibCodigo.HeaderText = bll_idioma.Traducir("FormLibro.colLibCodigo");
            colLibTitulo.HeaderText = bll_idioma.Traducir("FormLibro.colLibTitulo");
            colLibAutores.HeaderText = bll_idioma.Traducir("FormLibro.colLibAutores");
            colLibTemas.HeaderText = bll_idioma.Traducir("FormLibro.colLibTemas");
            colLibEstado.HeaderText = bll_idioma.Traducir("FormLibro.colLibEstado");
            lblSeccionDatos.Text = bll_idioma.Traducir("FormLibro.lblSeccionDatos");
            lblTituloLibro.Text = bll_idioma.Traducir("FormLibro.lblTituloLibro");
            txtBuscarAutor.PlaceholderText = bll_idioma.Traducir("FormLibro.txtBuscarAutor");
            lblNuevoAutor.Text = bll_idioma.Traducir("FormLibro.lblNuevoAutor");
            txtAutorNombre.PlaceholderText = bll_idioma.Traducir("FormLibro.txtAutorNombre");
            txtAutorApellido.PlaceholderText = bll_idioma.Traducir("FormLibro.txtAutorApellido");
            btnAgregarAutor.Text = bll_idioma.Traducir("FormLibro.btnAgregarAutor");
            lblTemas.Text = bll_idioma.Traducir("FormLibro.lblTemas");
            lblNuevoTema.Text = bll_idioma.Traducir("FormLibro.lblNuevoTema");
            txtTema.PlaceholderText = bll_idioma.Traducir("FormLibro.txtTema");
            btnAgregarTema.Text = bll_idioma.Traducir("FormLibro.btnAgregarTema");
            btnAlta.Text = bll_idioma.Traducir("FormLibro.btnAlta");
            btnModificar.Text = bll_idioma.Traducir("FormLibro.btnModificar");
            btnBaja.Text = bll_idioma.Traducir("FormLibro.btnBaja");
            btnReactivar.Text = bll_idioma.Traducir("FormLibro.btnReactivar");
            btnLimpiar.Text = bll_idioma.Traducir("FormLibro.btnLimpiar");
            btnCerrar.Text = bll_idioma.Traducir("FormLibro.btnCerrar");
            MostrarCodigo();
            MostrarEtiquetaAutores();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma.Desuscribir(this);
            base.OnFormClosed(e);
        }
    }
}
