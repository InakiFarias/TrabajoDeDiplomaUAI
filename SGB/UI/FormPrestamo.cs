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
    public partial class FormPrestamo : Form, IObservadorIdioma
    {
        BLL_Idioma bll_idioma = new BLL_Idioma();
        BLL_Socio bll_Socio;
        BLL_Ejemplar bll_Ejemplar;
        BLL_Prestamo bll_Prestamo;
        BE_Socio? socioSeleccionado;
        BE_Socio? socioConsultado;
        string habilitacionConsultada = "";
        List<BE_Ejemplar> detalle = new List<BE_Ejemplar>();

        public FormPrestamo()
        {
            InitializeComponent();
            bll_idioma.Suscribir(this);
        }

        private void FormPrestamo_Load(object sender, EventArgs e)
        {
            bll_Socio = new BLL_Socio();
            bll_Ejemplar = new BLL_Ejemplar();
            bll_Prestamo = new BLL_Prestamo();
            foreach (Control control in this.Controls)
            {
                if (control is DataGridView)
                {
                    ((DataGridView)control).MultiSelect = false;
                    ((DataGridView)control).SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            ConfigurarGrillas();

            Mostrar(dgvSocios, bll_Socio.ObtenerActivos());
            CargarEjemplares();
            ActualizarIdioma();
        }

        private void ConfigurarGrillas()
        {
            dgvSocios.AutoGenerateColumns = false;
            colSocNumero.DataPropertyName = "NumeroSocio";
            colSocApellido.DataPropertyName = "Apellido";
            colSocNombre.DataPropertyName = "Nombre";
            colSocDni.DataPropertyName = "Dni";
            colSocEstado.DataPropertyName = "Estado";

            dgvResultados.AutoGenerateColumns = false;
            colResCodigo.DataPropertyName = "Codigo";
            colResTitulo.DataPropertyName = "Titulo";
            colResAutor.DataPropertyName = "Autor";

            dgvDetalle.AutoGenerateColumns = false;
            colDetCodigo.DataPropertyName = "Codigo";
            colDetTitulo.DataPropertyName = "Titulo";
            colDetAutor.DataPropertyName = "Autor";
        }
        private void Mostrar(DataGridView grilla, object datos)
        {
            grilla.DataSource = null;
            grilla.DataSource = datos;
        }
        private void MostrarFechas()
        {
            lblFechaPrestamo.Text = $"{bll_idioma.Traducir("FormPrestamo.lblFechaPrestamo")} {DateTime.Today:dd/MM/yyyy}";
            lblFechaDevolucion.Text = $"{bll_idioma.Traducir("FormPrestamo.lblFechaDevolucion")} {bll_Prestamo.CalcularFechaDevolucionPrevista(DateTime.Today):dd/MM/yyyy}";
        }

        // Datos del último socio consultado y su habilitación para préstamos
        private void MostrarSocio()
        {
            if (socioConsultado == null)
            {
                lblDatosSocio.Text = $"{bll_idioma.Traducir("FormPrestamo.lblDatosSocio")} —";
                lblEstadoSocio.Text = $"{bll_idioma.Traducir("FormPrestamo.lblEstadoSocio")} —";
                return;
            }
            lblDatosSocio.Text = $"{bll_idioma.Traducir("FormPrestamo.lblDatosSocio")} {socioConsultado.Apellido}, {socioConsultado.Nombre} - {bll_idioma.Traducir("FormPrestamo.colSocDni")} {socioConsultado.Dni}";
            lblEstadoSocio.Text = $"{bll_idioma.Traducir("FormPrestamo.lblEstadoSocio")} {habilitacionConsultada}";
        }

        // ------------------------------------------------------------ Socio
        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            Mostrar(dgvSocios, bll_Socio.BuscarActivosPorDni(txtDni.Text));
        }

        private void btnAgregarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSocios.Rows.Count == 0) throw new Exception("No existe un socio registrado con el DNI ingresado.");
                if (dgvSocios.SelectedRows.Count == 0) throw new Exception("Seleccione un socio.");

                BE_Socio socio = (BE_Socio)dgvSocios.SelectedRows[0].DataBoundItem;
                string habilitacion = bll_Socio.ValidarHabilitacion(socio);

                socioConsultado = socio;
                habilitacionConsultada = habilitacion;
                MostrarSocio();

                if (habilitacion != BLL_Socio.HABILITADO)
                {
                    socioSeleccionado = null;
                    MostrarDetalle();
                    throw new Exception($"El socio no puede realizar préstamos. Motivo: {habilitacion}.");
                }

                socioSeleccionado = socio;
                MostrarDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // ------------------------------------------------------------ Ejemplares
        private void txtBuscarEjemplar_TextChanged(object sender, EventArgs e)
        {
            CargarEjemplares();
        }

        // Solo se listan los ejemplares disponibles que todavía no están en el detalle
        // (con el buscador vacío se listan todos, como en la búsqueda de socios)
        private void CargarEjemplares()
        {
            List<BE_Ejemplar> resultados = bll_Ejemplar.BuscarDisponibles(txtBuscarEjemplar.Text)
                .Where(ej => !detalle.Any(d => d.CodigoEjemplar == ej.CodigoEjemplar))
                .ToList();
            Mostrar(dgvResultados, bll_Ejemplar.ConsultarParaGrilla(resultados));
        }

        // Detalle del préstamo: socio elegido y ejemplares agregados
        private void MostrarDetalle()
        {
            Mostrar(dgvDetalle, bll_Ejemplar.ConsultarParaGrilla(detalle));
            lblDetalleSocio.Text = socioSeleccionado == null
                ? $"{bll_idioma.Traducir("FormPrestamo.lblDetalleSocio")} —"
                : $"{bll_idioma.Traducir("FormPrestamo.lblDetalleSocio")} {socioSeleccionado.Apellido}, {socioSeleccionado.Nombre} - {bll_idioma.Traducir("FormPrestamo.colSocDni")} {socioSeleccionado.Dni}";
            lblDetalleCantidad.Text = $"{bll_idioma.Traducir("FormPrestamo.lblDetalleCantidad")} {detalle.Count} / {BLL_Prestamo.MAXIMO_EJEMPLARES_POR_PRESTAMO}";
        }
        private void btnAgregarEjemplar_Click(object sender, EventArgs e)
        {
            try
            {
                if (socioSeleccionado == null) throw new Exception("Primero debe agregar un socio habilitado.");
                if (detalle.Count >= BLL_Prestamo.MAXIMO_EJEMPLARES_POR_PRESTAMO)
                    throw new Exception($"Un préstamo puede incluir como máximo {BLL_Prestamo.MAXIMO_EJEMPLARES_POR_PRESTAMO} ejemplares.");
                if (dgvResultados.Rows.Count == 0) throw new Exception("No hay ejemplares disponibles que coincidan con la búsqueda.");
                if (dgvResultados.SelectedRows.Count == 0) throw new Exception("Seleccione un ejemplar.");

                string codigo = dgvResultados.SelectedRows[0].Cells[colResCodigo.Index].Value.ToString();
                if (detalle.Any(ej => ej.CodigoEjemplar == codigo)) throw new Exception("El ejemplar ya está en el detalle.");

                detalle.Add(bll_Ejemplar.BuscarPorCodigo(codigo));
                MostrarDetalle();
                CargarEjemplares();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAgregarEjemplar_Click(sender, e);
        }
        private void btnQuitarEjemplar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.SelectedRows.Count == 0) return;

            string codigo = dgvDetalle.SelectedRows[0].Cells[colDetCodigo.Index].Value.ToString();
            detalle.RemoveAll(ej => ej.CodigoEjemplar == codigo);
            MostrarDetalle();
            CargarEjemplares();
        }

        // ------------------------------------------------------ Confirmar / Cancelar

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (socioSeleccionado == null) throw new Exception("Debe agregar un socio habilitado.");
                if (detalle.Count == 0) throw new Exception("Debe agregar al menos un ejemplar.");

                DateTime fechaDevolucion = bll_Prestamo.CalcularFechaDevolucionPrevista(DateTime.Today);
                string resumen = $"Socio: {socioSeleccionado.Apellido}, {socioSeleccionado.Nombre}\n" +
                                 $"Ejemplares: {detalle.Count}\n" +
                                 $"Fecha de devolución prevista: {fechaDevolucion:dd/MM/yyyy}\n\n" +
                                 "¿Confirma el préstamo?";

                if (MessageBox.Show(resumen, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                BE_Prestamo prestamo = new BE_Prestamo();
                prestamo.Socio = socioSeleccionado;
                prestamo.Ejemplares = detalle;

                BE_Comprobante comprobante = bll_Prestamo.Registrar(prestamo);

                MessageBox.Show($"Préstamo N° {prestamo.NumeroPrestamo} registrado correctamente.\n" +
                                $"Devolver antes del: {prestamo.FechaDevolucionPrevista:dd/MM/yyyy}",
                                "Préstamo registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    ComprobantesPDF.ComprobantePrestamo(comprobante);
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ------------------------------------------------------------ Idioma
        public void ActualizarIdioma()
        {
            this.Text = bll_idioma.Traducir("FormPrestamo.Form");
            lblSeccionSocio.Text = bll_idioma.Traducir("FormPrestamo.lblSeccionSocio");
            lblDni.Text = bll_idioma.Traducir("FormPrestamo.lblDni");
            txtDni.PlaceholderText = bll_idioma.Traducir("FormPrestamo.txtDni");
            btnAgregarSocio.Text = bll_idioma.Traducir("FormPrestamo.btnAgregarSocio");
            colSocNumero.HeaderText = bll_idioma.Traducir("FormPrestamo.colSocNumero");
            colSocApellido.HeaderText = bll_idioma.Traducir("FormPrestamo.colSocApellido");
            colSocNombre.HeaderText = bll_idioma.Traducir("FormPrestamo.colSocNombre");
            colSocDni.HeaderText = bll_idioma.Traducir("FormPrestamo.colSocDni");
            colSocEstado.HeaderText = bll_idioma.Traducir("FormPrestamo.colSocEstado");
            lblSeccionEjemplares.Text = bll_idioma.Traducir("FormPrestamo.lblSeccionEjemplares");
            lblBuscarEjemplar.Text = bll_idioma.Traducir("FormPrestamo.lblBuscarEjemplar");
            btnAgregarEjemplar.Text = bll_idioma.Traducir("FormPrestamo.btnAgregarEjemplar");
            colResCodigo.HeaderText = bll_idioma.Traducir("FormPrestamo.colResCodigo");
            colResTitulo.HeaderText = bll_idioma.Traducir("FormPrestamo.colResTitulo");
            colResAutor.HeaderText = bll_idioma.Traducir("FormPrestamo.colResAutor");
            lblSeccionDetalle.Text = bll_idioma.Traducir("FormPrestamo.lblSeccionDetalle");
            colDetCodigo.HeaderText = bll_idioma.Traducir("FormPrestamo.colDetCodigo");
            colDetTitulo.HeaderText = bll_idioma.Traducir("FormPrestamo.colDetTitulo");
            colDetAutor.HeaderText = bll_idioma.Traducir("FormPrestamo.colDetAutor");
            btnQuitarEjemplar.Text = bll_idioma.Traducir("FormPrestamo.btnQuitarEjemplar");
            btnConfirmar.Text = bll_idioma.Traducir("FormPrestamo.btnConfirmar");
            btnCancelar.Text = bll_idioma.Traducir("FormPrestamo.btnCancelar");
            MostrarSocio();
            if (bll_Prestamo == null) return;
            MostrarFechas();
            MostrarDetalle();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma.Desuscribir(this);
            base.OnFormClosed(e);
        }
    }
}
