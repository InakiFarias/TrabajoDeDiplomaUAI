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
    public partial class FormDevolucion : Form
    {
        BLL_Prestamo bll_Prestamo;
        BLL_Devolucion bll_Devolucion;
        BLL_Ejemplar bll_Ejemplar;
        BE_Prestamo? prestamoSeleccionado;

        public FormDevolucion()
        {
            InitializeComponent();
        }

        private void FormDevolucion_Load(object sender, EventArgs e)
        {
            bll_Prestamo = new BLL_Prestamo();
            bll_Devolucion = new BLL_Devolucion();
            bll_Ejemplar = new BLL_Ejemplar();

            dgvEjemplares.AutoGenerateColumns = false;
            colCodigo.DataPropertyName = "Codigo";
            colTitulo.DataPropertyName = "Titulo";
            colAutor.DataPropertyName = "Autor";

            LimpiarPrestamo();
        }

        private void txtNumeroPrestamo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            btnBuscarPrestamo_Click(sender, e);
        }

        private void btnBuscarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarPrestamo();
                prestamoSeleccionado = bll_Prestamo.BuscarVigente(txtNumeroPrestamo.Text);
                MostrarPrestamo(prestamoSeleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarPrestamo(BE_Prestamo prestamo)
        {
            lblSocio.Text = $"Socio: {prestamo.Socio.Apellido}, {prestamo.Socio.Nombre} - DNI {prestamo.Socio.Dni}";
            lblFechaPrestamo.Text = $"Fecha del préstamo: {prestamo.FechaPrestamo:dd/MM/yyyy}";
            lblFechaDevolucionPrevista.Text = $"Fecha de devolución prevista: {prestamo.FechaDevolucionPrevista:dd/MM/yyyy}";
            dgvEjemplares.DataSource = bll_Ejemplar.ConsultarParaGrilla(prestamo.Ejemplares);

            // Resumen: fecha real de devolución, atraso y multa
            DateTime hoy = DateTime.Today;
            BE_Multa? multa = bll_Devolucion.CalcularMulta(prestamo, hoy);
            lblFechaDevolucion.Text = $"Fecha real de devolución: {hoy:dd/MM/yyyy}";
            lblDiasAtraso.Text = $"Días de atraso: {bll_Devolucion.CalcularDiasAtraso(prestamo, hoy)}";
            lblMulta.Text = multa == null
                ? "Multa: sin multa (devolución en término)"
                : $"Multa: $ {multa.Monto:N2} ({multa.DiasAtraso} días x $ {multa.MontoPorDia:N2})";
        }

        private void LimpiarPrestamo()
        {
            prestamoSeleccionado = null;
            dgvEjemplares.DataSource = null;
            chkRecepcionCompleta.Checked = false;
            lblSocio.Text = "Socio: —";
            lblFechaPrestamo.Text = "Fecha del préstamo: —";
            lblFechaDevolucionPrevista.Text = "Fecha de devolución prevista: —";
            lblFechaDevolucion.Text = "Fecha real de devolución: —";
            lblDiasAtraso.Text = "Días de atraso: —";
            lblMulta.Text = "Multa: —";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (prestamoSeleccionado == null) throw new Exception("Debe buscar un préstamo vigente.");
                if (!chkRecepcionCompleta.Checked)
                    throw new Exception("Debe confirmar que recibió todos los ejemplares del préstamo. Si el socio no los devuelve todos, la devolución no se registra.");

                if (MessageBox.Show($"¿Confirma la devolución del préstamo N° {prestamoSeleccionado.NumeroPrestamo}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                BE_Devolucion devolucion = bll_Devolucion.Registrar(prestamoSeleccionado, chkRecepcionCompleta.Checked);

                string mensaje = $"Devolución N° {devolucion.NumeroDevolucion} registrada correctamente.";
                if (devolucion.Multa != null)
                {
                    mensaje += $"\n\nSe registró una multa de $ {devolucion.Multa.Monto:N2} por {devolucion.Multa.DiasAtraso} días de atraso." +
                               "\nEl socio no podrá realizar nuevos préstamos hasta abonarla.";
                }
                MessageBox.Show(mensaje, "Devolución registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
