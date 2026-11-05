using BE;
using BLL.BLL_NEG;
using BLL.BLL_SER;
using Servicio;

namespace UI
{
    public partial class FormMulta_351FI : Form, IObservadorIdioma_351FI
    {
        BLL_Idioma_351FI bll_idioma_351FI = new BLL_Idioma_351FI();
        BLL_Multa_351FI bll_Multa_351FI;
        BE_Socio_351FI? socioSeleccionado_351FI;
        List<BE_Multa_351FI> multasPendientes_351FI = new List<BE_Multa_351FI>();

        public FormMulta_351FI()
        {
            InitializeComponent();
            bll_idioma_351FI.Suscribir_351FI(this);
        }

        private void FormMulta_351FI_Load(object sender_351FI, EventArgs e_351FI)
        {
            bll_Multa_351FI = new BLL_Multa_351FI();

            CargarMetodosPago_351FI();

            // Solo se listan los socios que tienen multas pendientes, con el total que adeudan
            dgvSocios_351FI.AutoGenerateColumns = false;
            colSocNumero_351FI.DataPropertyName = "NumeroSocio_351FI";
            colSocApellido_351FI.DataPropertyName = "Apellido_351FI";
            colSocNombre_351FI.DataPropertyName = "Nombre_351FI";
            colSocDni_351FI.DataPropertyName = "Dni_351FI";
            colSocMonto_351FI.DataPropertyName = "MontoAdeudado_351FI";
            colSocMonto_351FI.DefaultCellStyle.Format = "N2";
            colSocMonto_351FI.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvMultas_351FI.AutoGenerateColumns = false;
            colMulNumero_351FI.DataPropertyName = "Numero";
            colMulPrestamo_351FI.DataPropertyName = "Prestamo";
            colMulFecha_351FI.DataPropertyName = "FechaGeneracion";
            colMulDias_351FI.DataPropertyName = "DiasAtraso";
            colMulMonto_351FI.DataPropertyName = "Monto";

            CargarSocios_351FI();
            ActualizarIdioma_351FI();
        }

        private void Mostrar_351FI(DataGridView grilla_351FI, object datos_351FI)
        {
            grilla_351FI.DataSource = null;
            grilla_351FI.DataSource = datos_351FI;
        }

        private void CargarSocios_351FI()
        {
            Mostrar_351FI(dgvSocios_351FI, bll_Multa_351FI.BuscarSociosConMultas_351FI(txtDni_351FI.Text));
        }

        // ------------------------------------------------------------ Socio
        private void txtDni_351FI_TextChanged(object sender_351FI, EventArgs e_351FI)
        {
            CargarSocios_351FI();
        }

        private void dgvSocios_351FI_CellDoubleClick(object sender_351FI, DataGridViewCellEventArgs e_351FI)
        {
            if (e_351FI.RowIndex < 0) return;
            btnSeleccionarSocio_351FI_Click(sender_351FI, e_351FI);
        }

        private void btnSeleccionarSocio_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                LimpiarMultas_351FI();
                if (dgvSocios_351FI.Rows.Count == 0) throw new Exception("No hay socios con multas pendientes que coincidan con el DNI ingresado.");
                if (dgvSocios_351FI.SelectedRows.Count == 0) throw new Exception("Seleccione un socio.");

                BE_Socio_351FI socio = (BE_Socio_351FI)dgvSocios_351FI.SelectedRows[0].DataBoundItem;
                multasPendientes_351FI = bll_Multa_351FI.ObtenerPendientes_351FI(socio);
                socioSeleccionado_351FI = socio;
                MostrarMultas_351FI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarMultas_351FI()
        {
            if (socioSeleccionado_351FI == null)
            {
                dgvMultas_351FI.DataSource = null;
                lblSocio_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.lblSocio_351FI")} —";
                lblTotal_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.lblTotal_351FI")} $ {0m:N2}";
                return;
            }
            lblSocio_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.lblSocio_351FI")} {socioSeleccionado_351FI.Apellido_351FI}, {socioSeleccionado_351FI.Nombre_351FI} - {bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.colSocDni_351FI")} {socioSeleccionado_351FI.Dni_351FI}";
            Mostrar_351FI(dgvMultas_351FI, bll_Multa_351FI.ConsultarParaGrilla_351FI(multasPendientes_351FI));
            lblTotal_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.lblTotal_351FI")} $ {bll_Multa_351FI.CalcularTotalAdeudado_351FI(multasPendientes_351FI):N2}";
        }

        private void LimpiarMultas_351FI()
        {
            socioSeleccionado_351FI = null;
            multasPendientes_351FI = new List<BE_Multa_351FI>();
            cmbMetodoPago_351FI.SelectedIndex = 0;
            txtNumeroTarjeta_351FI.Clear();
            MostrarMultas_351FI();
        }

        // ------------------------------------------------------------ Método de pago
        // El combo muestra el texto traducido; el valor del método se obtiene por posición (0 = Efectivo, 1 = Tarjeta)
        private bool cargandoMetodos_351FI = false;

        private void CargarMetodosPago_351FI()
        {
            int indice = cmbMetodoPago_351FI.SelectedIndex < 0 ? 0 : cmbMetodoPago_351FI.SelectedIndex;
            cargandoMetodos_351FI = true;
            cmbMetodoPago_351FI.Items.Clear();
            cmbMetodoPago_351FI.Items.Add(bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.cmbMetodoPago.Efectivo"));
            cmbMetodoPago_351FI.Items.Add(bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.cmbMetodoPago.Tarjeta"));
            cmbMetodoPago_351FI.SelectedIndex = indice;
            cargandoMetodos_351FI = false;
        }

        private string ObtenerMetodoPago_351FI() => cmbMetodoPago_351FI.SelectedIndex == 1 ? BLL_Multa_351FI.METODO_TARJETA : BLL_Multa_351FI.METODO_EFECTIVO;

        private void cmbMetodoPago_351FI_SelectedIndexChanged(object sender_351FI, EventArgs e_351FI)
        {
            if (cargandoMetodos_351FI) return;
            bool tarjeta = ObtenerMetodoPago_351FI() == BLL_Multa_351FI.METODO_TARJETA;
            lblNumeroTarjeta_351FI.Visible = tarjeta;
            txtNumeroTarjeta_351FI.Visible = tarjeta;
            if (!tarjeta) txtNumeroTarjeta_351FI.Clear();
        }

        // ------------------------------------------------------------ Cobro
        private void btnNoAbona_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            if (socioSeleccionado_351FI == null) return;

            MessageBox.Show("No se registró el pago. Las multas se mantienen pendientes de pago y el socio no podrá realizar nuevos préstamos hasta abonarlas.",
                            "Pago no registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarMultas_351FI();
        }

        private void btnConfirmarCobro_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (socioSeleccionado_351FI == null) throw new Exception("Debe seleccionar un socio con multas pendientes de pago.");

                decimal total = bll_Multa_351FI.CalcularTotalAdeudado_351FI(multasPendientes_351FI);
                string metodoPago = ObtenerMetodoPago_351FI();

                // Con tarjeta, primero se procesa el pago con tarjeta; si se rechaza no se registra el pago
                if (metodoPago == BLL_Multa_351FI.METODO_TARJETA)
                {
                    bool aprobado = bll_Multa_351FI.ProcesarPagoConTarjeta_351FI(txtNumeroTarjeta_351FI.Text, total);
                    txtNumeroTarjeta_351FI.Clear();
                    if (!aprobado)
                    {
                        MessageBox.Show("El pago con tarjeta fue rechazado. No se registró el pago y las multas se mantienen pendientes de pago.",
                                        "Pago rechazado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (MessageBox.Show($"¿Confirma el cobro del total adeudado de $ {total:N2} con método de pago: {cmbMetodoPago_351FI.Text}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                BE_ComprobantePago_351FI comprobante = bll_Multa_351FI.RegistrarPago_351FI(socioSeleccionado_351FI, multasPendientes_351FI, metodoPago);

                MessageBox.Show($"Pago registrado correctamente. Comprobante N° {comprobante.NumeroComprobante_351FI}.",
                                "Pago registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    ComprobantesPDF_351FI.ComprobantePago_351FI(comprobante);
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

        // ------------------------------------------------------------ Idioma
        public void ActualizarIdioma_351FI()
        {
            this.Text = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.Form");
            lblSeccionSocio_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.lblSeccionSocio_351FI");
            lblDni_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.lblDni_351FI");
            txtDni_351FI.PlaceholderText = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.txtDni_351FI");
            btnSeleccionarSocio_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.btnSeleccionarSocio_351FI");
            colSocNumero_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.colSocNumero_351FI");
            colSocApellido_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.colSocApellido_351FI");
            colSocNombre_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.colSocNombre_351FI");
            colSocDni_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.colSocDni_351FI");
            colSocMonto_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.colSocMonto_351FI");
            lblSeccionMultas_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.lblSeccionMultas_351FI");
            colMulNumero_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.colMulNumero_351FI");
            colMulPrestamo_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.colMulPrestamo_351FI");
            colMulFecha_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.colMulFecha_351FI");
            colMulDias_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.colMulDias_351FI");
            colMulMonto_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.colMulMonto_351FI");
            lblMetodoPago_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.lblMetodoPago_351FI");
            lblNumeroTarjeta_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.lblNumeroTarjeta_351FI");
            CargarMetodosPago_351FI();
            btnConfirmarCobro_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.btnConfirmarCobro_351FI");
            btnNoAbona_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormMulta_351FI.btnNoAbona_351FI");
            if (bll_Multa_351FI != null) MostrarMultas_351FI();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma_351FI.Desuscribir_351FI(this);
            base.OnFormClosed(e);
        }
    }
}
