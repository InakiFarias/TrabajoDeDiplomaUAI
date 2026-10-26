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
        BLL_Ejemplar bll_Ejemplar;
        BLL_Donacion bll_Donacion;
        BE_Socio? socioSeleccionado;
        List<BE_Ejemplar> detalle = new List<BE_Ejemplar>();

        public FormDonacion()
        {
            InitializeComponent();
            bll_idioma.Suscribir(this);
        }

        private void FormDonacion_Load(object sender, EventArgs e)
        {
            bll_Socio = new BLL_Socio();
            bll_Ejemplar = new BLL_Ejemplar();
            bll_Donacion = new BLL_Donacion();

            dgvSocios.AutoGenerateColumns = false;
            colSocNumero.DataPropertyName = "NumeroSocio";
            colSocApellido.DataPropertyName = "Apellido";
            colSocNombre.DataPropertyName = "Nombre";
            colSocDni.DataPropertyName = "Dni";

            dgvResultados.AutoGenerateColumns = false;
            colResCodigo.DataPropertyName = "Codigo";
            colResTitulo.DataPropertyName = "Titulo";
            colResAutor.DataPropertyName = "Autor";
            colResEstado.DataPropertyName = "Estado";

            dgvDetalle.AutoGenerateColumns = false;
            colDetCodigo.DataPropertyName = "Codigo";
            colDetTitulo.DataPropertyName = "Titulo";
            colDetAutor.DataPropertyName = "Autor";

            Mostrar(dgvSocios, bll_Socio.ObtenerActivos());
            CargarEjemplares();
            ActualizarIdioma();
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

        // ------------------------------------------------------------ Ejemplares donados
        private void txtBuscarEjemplar_TextChanged(object sender, EventArgs e)
        {
            CargarEjemplares();
        }

        // Con el buscador vacío se listan todos los ejemplares
        private void CargarEjemplares()
        {
            List<BE_Ejemplar> resultados = bll_Ejemplar.BuscarPorTexto(txtBuscarEjemplar.Text);
            Mostrar(dgvResultados, bll_Ejemplar.ConsultarParaGrilla(resultados));
        }

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnAgregarEjemplar_Click(sender, e);
        }

        private void btnAgregarEjemplar_Click(object sender, EventArgs e)
        {
            try
            {
                if (socioSeleccionado == null) throw new Exception("Primero debe agregar al socio donante.");
                if (dgvResultados.Rows.Count == 0) throw new Exception("No existe un ejemplar que coincida con la búsqueda.");
                if (dgvResultados.SelectedRows.Count == 0) throw new Exception("Seleccione un ejemplar.");

                string codigo = dgvResultados.SelectedRows[0].Cells[colResCodigo.Index].Value.ToString();
                if (detalle.Any(ej => ej.CodigoEjemplar == codigo)) throw new Exception("El ejemplar ya está en el detalle.");

                detalle.Add(bll_Donacion.ValidarEjemplar(codigo));
                Mostrar(dgvDetalle, bll_Ejemplar.ConsultarParaGrilla(detalle));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnQuitarEjemplar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.SelectedRows.Count == 0) return;

            string codigo = dgvDetalle.SelectedRows[0].Cells[colDetCodigo.Index].Value.ToString();
            detalle.RemoveAll(ej => ej.CodigoEjemplar == codigo);
            Mostrar(dgvDetalle, bll_Ejemplar.ConsultarParaGrilla(detalle));
        }

        // ------------------------------------------------------ Confirmar / Cancelar
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (socioSeleccionado == null) throw new Exception("Debe agregar al socio donante.");
                if (detalle.Count == 0) throw new Exception("Debe agregar al menos un ejemplar donado.");

                string resumen = $"Socio donante: {socioSeleccionado.Apellido}, {socioSeleccionado.Nombre}\n" +
                                 $"Ejemplares donados: {detalle.Count}\n\n" +
                                 "¿Confirma la donación?";
                if (MessageBox.Show(resumen, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                BE_Donacion donacion = new BE_Donacion();
                donacion.Socio = socioSeleccionado;
                donacion.Ejemplares = detalle;

                BE_ReciboDonacion recibo = bll_Donacion.Registrar(donacion);

                MessageBox.Show($"Donación N° {donacion.NumeroDonacion} registrada correctamente.",
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
            lblBuscarEjemplar.Text = bll_idioma.Traducir("FormDonacion.lblBuscarEjemplar");
            btnAgregarEjemplar.Text = bll_idioma.Traducir("FormDonacion.btnAgregarEjemplar");
            colResCodigo.HeaderText = bll_idioma.Traducir("FormDonacion.colResCodigo");
            colResTitulo.HeaderText = bll_idioma.Traducir("FormDonacion.colResTitulo");
            colResAutor.HeaderText = bll_idioma.Traducir("FormDonacion.colResAutor");
            colResEstado.HeaderText = bll_idioma.Traducir("FormDonacion.colResEstado");
            lblSeccionDetalle.Text = bll_idioma.Traducir("FormDonacion.lblSeccionDetalle");
            colDetCodigo.HeaderText = bll_idioma.Traducir("FormDonacion.colDetCodigo");
            colDetTitulo.HeaderText = bll_idioma.Traducir("FormDonacion.colDetTitulo");
            colDetAutor.HeaderText = bll_idioma.Traducir("FormDonacion.colDetAutor");
            btnQuitarEjemplar.Text = bll_idioma.Traducir("FormDonacion.btnQuitarEjemplar");
            btnConfirmar.Text = bll_idioma.Traducir("FormDonacion.btnConfirmar");
            btnCancelar.Text = bll_idioma.Traducir("FormDonacion.btnCancelar");
            MostrarSocio();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma.Desuscribir(this);
            base.OnFormClosed(e);
        }
    }
}
