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
    public partial class FormLibro_351FI : Form, IObservadorIdioma_351FI
    {
        BLL_Idioma_351FI bll_idioma_351FI = new BLL_Idioma_351FI();
        BLL_Libro_351FI bll_Libro_351FI;
        List<BE_Libro_351FI> librosMostrados_351FI = new List<BE_Libro_351FI>();
        BE_Libro_351FI? libroSeleccionado_351FI;

        // Autores: la lista visible se filtra con el buscador, por eso las marcas se guardan aparte
        List<BE_Autor_351FI> todosLosAutores_351FI = new List<BE_Autor_351FI>();
        HashSet<int> autoresMarcados_351FI = new HashSet<int>();
        bool cargandoAutores_351FI;
        int autoresFiltrados_351FI = -1;

        public FormLibro_351FI()
        {
            InitializeComponent();
            bll_idioma_351FI.Suscribir_351FI(this);
        }

        private void FormLibro_351FI_Load(object sender_351FI, EventArgs e_351FI)
        {
            bll_Libro_351FI = new BLL_Libro_351FI();

            dgvLibros_351FI.AutoGenerateColumns = false;
            colLibCodigo_351FI.DataPropertyName = "Codigo";
            colLibTitulo_351FI.DataPropertyName = "Titulo";
            colLibAutores_351FI.DataPropertyName = "Autores";
            colLibTemas_351FI.DataPropertyName = "Temas";
            colLibEstado_351FI.DataPropertyName = "Estado";

            SER_Usuario_351FI usuario = SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI;
            btnAlta_351FI.Enabled = usuario.Rol_351FI.TienePermiso_351FI("Alta Libro");

            CargarAutores_351FI(new List<int>());
            CargarTemas_351FI(new List<int>());
            CargarLibros_351FI();
            ActualizarIdioma_351FI();
            this.Shown += FormLibro_351FI_Shown;
        }

        // La grilla selecciona la primera fila al mostrarse; se limpia para no precargar los datos de un libro
        private void FormLibro_351FI_Shown(object? sender_351FI, EventArgs e_351FI)
        {
            dgvLibros_351FI.ClearSelection();
            Limpiar_351FI();
        }

        private void CargarLibros_351FI()
        {
            librosMostrados_351FI = bll_Libro_351FI.BuscarPorTexto_351FI(txtBuscar_351FI.Text);
            dgvLibros_351FI.DataSource = null;
            dgvLibros_351FI.DataSource = bll_Libro_351FI.ConsultarParaGrilla_351FI(librosMostrados_351FI);
            dgvLibros_351FI.ClearSelection();
            Limpiar_351FI();
        }

        private void CargarAutores_351FI(List<int> codigosMarcados_351FI)
        {
            todosLosAutores_351FI = bll_Libro_351FI.ObtenerAutores_351FI();
            MarcarAutores_351FI(codigosMarcados_351FI);
        }

        // Muestra solo los autores que coinciden con el buscador, conservando los que ya estaban marcados
        private void FiltrarAutores_351FI()
        {
            List<BE_Autor_351FI> filtrados = bll_Libro_351FI.FiltrarAutores_351FI(todosLosAutores_351FI, txtBuscarAutor_351FI.Text);

            cargandoAutores_351FI = true;
            clbAutores_351FI.Items.Clear();
            foreach (BE_Autor_351FI autor in filtrados)
                clbAutores_351FI.Items.Add(autor, autoresMarcados_351FI.Contains(autor.CodigoAutor_351FI));
            cargandoAutores_351FI = false;

            autoresFiltrados_351FI = filtrados.Count;
            MostrarEtiquetaAutores_351FI();
        }

        private void MostrarEtiquetaAutores_351FI()
        {
            bool sinResultados = autoresFiltrados_351FI == 0 && txtBuscarAutor_351FI.Text.Trim() != "";
            lblAutores_351FI.Text = sinResultados
                ? bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.autorNoRegistrado")
                : $"{bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.lblAutores_351FI")} - {bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.marcados")} {autoresMarcados_351FI.Count}";
        }

        private void txtBuscarAutor_351FI_TextChanged(object sender_351FI, EventArgs e_351FI)
        {
            FiltrarAutores_351FI();
        }

        private void clbAutores_351FI_ItemCheck(object sender_351FI, ItemCheckEventArgs e_351FI)
        {
            if (cargandoAutores_351FI) return;

            int codigo = ((BE_Autor_351FI)clbAutores_351FI.Items[e_351FI.Index]).CodigoAutor_351FI;
            if (e_351FI.NewValue == CheckState.Checked) autoresMarcados_351FI.Add(codigo);
            else autoresMarcados_351FI.Remove(codigo);
            MostrarEtiquetaAutores_351FI();
        }

        private void CargarTemas_351FI(List<int> codigosMarcados_351FI)
        {
            clbTemas_351FI.Items.Clear();
            foreach (BE_Tema_351FI tema in bll_Libro_351FI.ObtenerTemas_351FI())
                clbTemas_351FI.Items.Add(tema, codigosMarcados_351FI.Contains(tema.CodigoTema_351FI));
        }

        private List<BE_Autor_351FI> AutoresMarcados_351FI() => todosLosAutores_351FI.Where(a => autoresMarcados_351FI.Contains(a.CodigoAutor_351FI)).ToList();

        private List<BE_Tema_351FI> TemasMarcados_351FI() => clbTemas_351FI.CheckedItems.Cast<BE_Tema_351FI>().ToList();

        private void MarcarAutores_351FI(List<int> codigos_351FI)
        {
            autoresMarcados_351FI = new HashSet<int>(codigos_351FI);
            FiltrarAutores_351FI();
        }

        private void MarcarTemas_351FI(List<int> codigos_351FI)
        {
            for (int i = 0; i < clbTemas_351FI.Items.Count; i++)
                clbTemas_351FI.SetItemChecked(i, codigos_351FI.Contains(((BE_Tema_351FI)clbTemas_351FI.Items[i]).CodigoTema_351FI));
        }

        private void txtBuscar_351FI_TextChanged(object sender_351FI, EventArgs e_351FI)
        {
            CargarLibros_351FI();
        }

        private void dgvLibros_351FI_SelectionChanged(object sender_351FI, EventArgs e_351FI)
        {
            if (dgvLibros_351FI.SelectedRows.Count == 0) return;

            string codigo = dgvLibros_351FI.SelectedRows[0].Cells[colLibCodigo_351FI.Index].Value?.ToString() ?? "";
            libroSeleccionado_351FI = librosMostrados_351FI.FirstOrDefault(l => l.CodigoLibro_351FI == codigo);
            if (libroSeleccionado_351FI == null) return;

            MostrarCodigo_351FI();
            txtTituloLibro_351FI.Text = libroSeleccionado_351FI.Titulo_351FI;
            txtBuscarAutor_351FI.Clear();
            MarcarAutores_351FI(libroSeleccionado_351FI.Autores_351FI.Select(a => a.CodigoAutor_351FI).ToList());
            MarcarTemas_351FI(libroSeleccionado_351FI.Temas_351FI.Select(t => t.CodigoTema_351FI).ToList());
        }

        private void Limpiar_351FI()
        {
            libroSeleccionado_351FI = null;
            MostrarCodigo_351FI();
            txtTituloLibro_351FI.Clear();
            txtBuscarAutor_351FI.Clear();
            MarcarAutores_351FI(new List<int>());
            MarcarTemas_351FI(new List<int>());
        }

        private void MostrarCodigo_351FI()
        {
            // El botón se habilita si el estado del libro lo permite y el usuario tiene el permiso
            SER_Usuario_351FI usuario = SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI;
            bool dadoDeBaja = libroSeleccionado_351FI != null && libroSeleccionado_351FI.Estado_351FI == "Baja";
            btnModificar_351FI.Enabled = libroSeleccionado_351FI != null && !dadoDeBaja && usuario.Rol_351FI.TienePermiso_351FI("Modificar Libro");
            btnBaja_351FI.Enabled = libroSeleccionado_351FI != null && !dadoDeBaja && usuario.Rol_351FI.TienePermiso_351FI("Baja Libro");
            btnReactivar_351FI.Enabled = dadoDeBaja && usuario.Rol_351FI.TienePermiso_351FI("Reactivar Libro");

            lblCodigo_351FI.Text = libroSeleccionado_351FI == null
                ? bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.codigoNuevo")
                : $"{bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.lblCodigo_351FI")} {libroSeleccionado_351FI.CodigoLibro_351FI} ({libroSeleccionado_351FI.Estado_351FI})";
        }

        private void btnLimpiar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            dgvLibros_351FI.ClearSelection();
            Limpiar_351FI();
            txtTituloLibro_351FI.Focus();
        }

        // ------------------------------------------------------------ Autores y temas nuevos
        private void btnAgregarAutor_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                List<int> marcados = AutoresMarcados_351FI().Select(a => a.CodigoAutor_351FI).ToList();
                BE_Autor_351FI autor = bll_Libro_351FI.AgregarAutor_351FI(txtAutorNombre_351FI.Text, txtAutorApellido_351FI.Text);
                marcados.Add(autor.CodigoAutor_351FI);
                txtBuscarAutor_351FI.Clear();
                CargarAutores_351FI(marcados);
                txtAutorNombre_351FI.Clear();
                txtAutorApellido_351FI.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregarTema_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                List<int> marcados = TemasMarcados_351FI().Select(t => t.CodigoTema_351FI).ToList();
                BE_Tema_351FI tema = bll_Libro_351FI.AgregarTema_351FI(txtTema_351FI.Text);
                marcados.Add(tema.CodigoTema_351FI);
                CargarTemas_351FI(marcados);
                txtTema_351FI.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ------------------------------------------------------------ Alta
        private void btnAlta_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                BE_Libro_351FI libro = new BE_Libro_351FI("", txtTituloLibro_351FI.Text, AutoresMarcados_351FI(), TemasMarcados_351FI());
                bll_Libro_351FI.Alta_351FI(libro);

                MessageBox.Show($"Libro dado de alta correctamente con el código {libro.CodigoLibro_351FI}.", "Alta de libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLibros_351FI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ------------------------------------------------------------ Modificación
        private void btnModificar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (libroSeleccionado_351FI == null) throw new Exception("Seleccione el libro a modificar.");

                BE_Libro_351FI libro = new BE_Libro_351FI(libroSeleccionado_351FI.CodigoLibro_351FI, txtTituloLibro_351FI.Text, AutoresMarcados_351FI(), TemasMarcados_351FI());
                libro.Estado_351FI = libroSeleccionado_351FI.Estado_351FI;
                if (MessageBox.Show($"¿Confirma la modificación del libro {libro.CodigoLibro_351FI}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_Libro_351FI.Modificar_351FI(libro);
                MessageBox.Show("Libro modificado correctamente.", "Modificación de libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLibros_351FI();
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
                if (libroSeleccionado_351FI == null) throw new Exception("Seleccione el libro a dar de baja.");

                if (MessageBox.Show($"¿Confirma la baja del libro \"{libroSeleccionado_351FI.Titulo_351FI}\"?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_Libro_351FI.Baja_351FI(libroSeleccionado_351FI);
                MessageBox.Show("Libro dado de baja correctamente.", "Baja de libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLibros_351FI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ------------------------------------------------------------ Reactivación (vuelve a dar de alta un libro dado de baja)
        private void btnReactivar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (libroSeleccionado_351FI == null) throw new Exception("Seleccione el libro a reactivar.");

                if (MessageBox.Show($"¿Confirma la reactivación del libro \"{libroSeleccionado_351FI.Titulo_351FI}\"?\nSus ejemplares dados de baja se reactivan aparte, desde Gestión de ejemplares.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_Libro_351FI.Reactivar_351FI(libroSeleccionado_351FI);
                MessageBox.Show("Libro reactivado correctamente.", "Reactivación de libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLibros_351FI();
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
            this.Text = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.Form");
            lblSeccionLibros_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.lblSeccionLibros_351FI");
            lblBuscar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.lblBuscar_351FI");
            colLibCodigo_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.colLibCodigo_351FI");
            colLibTitulo_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.colLibTitulo_351FI");
            colLibAutores_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.colLibAutores_351FI");
            colLibTemas_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.colLibTemas_351FI");
            colLibEstado_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.colLibEstado_351FI");
            lblSeccionDatos_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.lblSeccionDatos_351FI");
            lblTituloLibro_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.lblTituloLibro_351FI");
            txtBuscarAutor_351FI.PlaceholderText = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.txtBuscarAutor_351FI");
            lblNuevoAutor_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.lblNuevoAutor_351FI");
            txtAutorNombre_351FI.PlaceholderText = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.txtAutorNombre_351FI");
            txtAutorApellido_351FI.PlaceholderText = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.txtAutorApellido_351FI");
            btnAgregarAutor_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.btnAgregarAutor_351FI");
            lblTemas_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.lblTemas_351FI");
            lblNuevoTema_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.lblNuevoTema_351FI");
            txtTema_351FI.PlaceholderText = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.txtTema_351FI");
            btnAgregarTema_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.btnAgregarTema_351FI");
            btnAlta_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.btnAlta_351FI");
            btnModificar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.btnModificar_351FI");
            btnBaja_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.btnBaja_351FI");
            btnReactivar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.btnReactivar_351FI");
            btnLimpiar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.btnLimpiar_351FI");
            btnCerrar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormLibro_351FI.btnCerrar_351FI");
            MostrarCodigo_351FI();
            MostrarEtiquetaAutores_351FI();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma_351FI.Desuscribir_351FI(this);
            base.OnFormClosed(e);
        }
    }
}
