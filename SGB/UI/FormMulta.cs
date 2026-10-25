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
    public partial class FormMulta : Form
    {
        BLL_Socio bll_Socio;
        BLL_Multa bll_Multa;
        BE_Socio? socioSeleccionado;
        List<BE_Multa> multasPendientes = new List<BE_Multa>();

        public FormMulta()
        {
            InitializeComponent();
        }

        private void FormMulta_Load(object sender, EventArgs e)
        {
            bll_Socio = new BLL_Socio();
            bll_Multa = new BLL_Multa();

            dgvSocios.AutoGenerateColumns = false;
            colSocNumero.DataPropertyName = "NumeroSocio";
            colSocApellido.DataPropertyName = "Apellido";
            colSocNombre.DataPropertyName = "Nombre";
            colSocDni.DataPropertyName = "Dni";

            dgvMultas.AutoGenerateColumns = false;
            colMulNumero.DataPropertyName = "Numero";
            colMulPrestamo.DataPropertyName = "Prestamo";
            colMulFecha.DataPropertyName = "FechaGeneracion";
            colMulDias.DataPropertyName = "DiasAtraso";
            colMulMonto.DataPropertyName = "Monto";

            Mostrar(dgvSocios, bll_Socio.ObtenerActivos());
            LimpiarMultas();
        }

        private void Mostrar(DataGridView grilla, object datos)
        {
            grilla.DataSource = null;
            grilla.DataSource = datos;
        }

        // ------------------------------------------------------------ Socio
        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            Mostrar(dgvSocios, bll_Socio.BuscarActivosPorDni(txtDni.Text));
        }

        private void dgvSocios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnSeleccionarSocio_Click(sender, e);
        }

        private void btnSeleccionarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarMultas();
                if (dgvSocios.Rows.Count == 0) throw new Exception("No existe un socio registrado con el DNI ingresado.");
                if (dgvSocios.SelectedRows.Count == 0) throw new Exception("Seleccione un socio.");

                BE_Socio socio = (BE_Socio)dgvSocios.SelectedRows[0].DataBoundItem;
                lblSocio.Text = $"Socio: {socio.Apellido}, {socio.Nombre} - DNI {socio.Dni}";

                multasPendientes = bll_Multa.ObtenerPendientes(socio);
                socioSeleccionado = socio;
                Mostrar(dgvMultas, bll_Multa.ConsultarParaGrilla(multasPendientes));
                lblTotal.Text = $"Total adeudado: $ {bll_Multa.CalcularTotalAdeudado(multasPendientes):N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarMultas()
        {
            socioSeleccionado = null;
            multasPendientes = new List<BE_Multa>();
            dgvMultas.DataSource = null;
            lblSocio.Text = "Socio: —";
            lblTotal.Text = "Total adeudado: $ 0,00";
        }

        // ------------------------------------------------------------ Cobro
        private void btnNoAbona_Click(object sender, EventArgs e)
        {
            if (socioSeleccionado == null) return;

            MessageBox.Show("No se registró el pago. Las multas se mantienen pendientes de pago y el socio no podrá realizar nuevos préstamos hasta abonarlas.",
                            "Pago no registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarMultas();
        }

        private void btnConfirmarCobro_Click(object sender, EventArgs e)
        {
            try
            {
                if (socioSeleccionado == null) throw new Exception("Debe seleccionar un socio con multas pendientes de pago.");

                decimal total = bll_Multa.CalcularTotalAdeudado(multasPendientes);
                if (MessageBox.Show($"¿Confirma el cobro del total adeudado de $ {total:N2}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                BE_ComprobantePago comprobante = bll_Multa.RegistrarPago(socioSeleccionado, multasPendientes);

                MessageBox.Show($"Pago registrado correctamente. Comprobante N° {comprobante.NumeroComprobante}.",
                                "Pago registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    ComprobantesPDF.ComprobantePago(comprobante);
                }
                catch (Exception exPdf)
                {
                    MessageBox.Show($"El pago quedó registrado, pero no se pudo generar el comprobante en PDF.\n{exPdf.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
