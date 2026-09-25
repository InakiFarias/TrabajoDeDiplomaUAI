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
    public partial class FormPrestamo : Form
    {
        BLL_Socio bll_Socio;
        BLL_Ejemplar bll_Ejemplar;
        BLL_Prestamo bll_Prestamo;
        BE_Socio? socioSeleccionado;
        List<BE_Ejemplar> detalle = new List<BE_Ejemplar>();

        public FormPrestamo()
        {
            InitializeComponent();
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
            
            Mostrar(dgvSocios, bll_Socio.ObtenerSocios());
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
            colResEstado.DataPropertyName = "Estado";

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
        private void txtNumeroSocio_TextChanged(object sender, EventArgs e)
        {
            Mostrar(dgvSocios, bll_Socio.BuscarPorNumero(txtNumeroSocio.Text));
        }

        private void btnAgregarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSocios.SelectedRows.Count == 0) throw new Exception("Seleccione un socio.");

                BE_Socio socio = (BE_Socio)dgvSocios.SelectedRows[0].DataBoundItem;
                string habilitacion = bll_Socio.ValidarHabilitacion(socio);

                lblDatosSocio.Text = $"Socio: {socio.Apellido}, {socio.Nombre} - DNI {socio.Dni}";
                lblEstadoSocio.Text = $"Estado: {habilitacion}";

                if (habilitacion != "Habilitado")
                {
                    socioSeleccionado = null;
                    throw new Exception($"El socio no puede realizar préstamos. Motivo: {habilitacion}.");
                }

                socioSeleccionado = socio;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // ------------------------------------------------------------ Ejemplares
        private void txtBuscarEjemplar_TextChanged(object sender, EventArgs e)
        {
            List<BE_Ejemplar> resultados = bll_Ejemplar.BuscarPorTexto(txtBuscarEjemplar.Text);
            Mostrar(dgvResultados, bll_Ejemplar.ConsultarParaGrilla(resultados));
        }
        private void btnAgregarEjemplar_Click(object sender, EventArgs e)
        {
            try
            {
                if (socioSeleccionado == null) throw new Exception("Primero debe agregar un socio.");
                if (dgvResultados.SelectedRows.Count == 0) throw new Exception("Seleccione un ejemplar.");

                string codigo = dgvResultados.SelectedRows[0].Cells[colResCodigo.Index].Value.ToString();
                if (detalle.Any(ej => ej.CodigoEjemplar == codigo)) throw new Exception("El ejemplar ya está en el detalle.");

                detalle.Add(bll_Ejemplar.BuscarPorCodigo(codigo));
                Mostrar(dgvDetalle, bll_Ejemplar.ConsultarParaGrilla(detalle));
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
            Mostrar(dgvDetalle, bll_Ejemplar.ConsultarParaGrilla(detalle));
        }

        // ------------------------------------------------------ Confirmar / Cancelar

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (socioSeleccionado == null) throw new Exception("Debe agregar un socio.");
                if (detalle.Count == 0) throw new Exception("Debe agregar al menos un ejemplar.");

                bll_Prestamo.ValidarLimite(socioSeleccionado);

                DateTime fechaDevolucion = bll_Prestamo.CalcularFechaDevolucionPrevista(DateTime.Today);
                lblFechaPrestamo.Text = $"Fecha del préstamo: {DateTime.Today:dd/MM/yyyy}";
                lblFechaDevolucion.Text = $"Fecha de devolución prevista: {fechaDevolucion:dd/MM/yyyy}";

                if (MessageBox.Show("¿Confirma el préstamo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                BE_Prestamo prestamo = new BE_Prestamo();
                prestamo.Socio = socioSeleccionado;
                prestamo.Ejemplares = detalle;

                BE_Comprobante comprobante = bll_Prestamo.Registrar(prestamo);

                MessageBox.Show($"Préstamo registrado correctamente.\n\n" +
                                $"Comprobante N° {comprobante.NumeroComprobante}\n" +
                                $"Préstamo N° {prestamo.NumeroPrestamo}\n" +
                                $"Socio: {prestamo.Socio.Apellido}, {prestamo.Socio.Nombre}\n" +
                                $"Ejemplares: {prestamo.Ejemplares.Count}\n" +
                                $"Devolver antes del: {prestamo.FechaDevolucionPrevista:dd/MM/yyyy}",
                                "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
