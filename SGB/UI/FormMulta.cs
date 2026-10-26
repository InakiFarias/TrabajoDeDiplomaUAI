using BE;
using BLL.BLL_NEG;
using BLL.BLL_SER;
using Servicio;

namespace UI
{
    public partial class FormMulta : Form, IObservadorIdioma
    {
        BLL_Idioma bll_idioma = new BLL_Idioma();
        BLL_Multa bll_Multa;
        BE_Socio? socioSeleccionado;
        List<BE_Multa> multasPendientes = new List<BE_Multa>();

        public FormMulta()
        {
            InitializeComponent();
            bll_idioma.Suscribir(this);
        }

        private void FormMulta_Load(object sender, EventArgs e)
        {
            bll_Multa = new BLL_Multa();

            // Solo se listan los socios que tienen multas pendientes, con el total que adeudan
            dgvSocios.AutoGenerateColumns = false;
            colSocNumero.DataPropertyName = "NumeroSocio";
            colSocApellido.DataPropertyName = "Apellido";
            colSocNombre.DataPropertyName = "Nombre";
            colSocDni.DataPropertyName = "Dni";
            colSocMonto.DataPropertyName = "MontoAdeudado";
            colSocMonto.DefaultCellStyle.Format = "N2";
            colSocMonto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvMultas.AutoGenerateColumns = false;
            colMulNumero.DataPropertyName = "Numero";
            colMulPrestamo.DataPropertyName = "Prestamo";
            colMulFecha.DataPropertyName = "FechaGeneracion";
            colMulDias.DataPropertyName = "DiasAtraso";
            colMulMonto.DataPropertyName = "Monto";

            CargarSocios();
            ActualizarIdioma();
        }

        private void Mostrar(DataGridView grilla, object datos)
        {
            grilla.DataSource = null;
            grilla.DataSource = datos;
        }

        private void CargarSocios()
        {
            Mostrar(dgvSocios, bll_Multa.BuscarSociosConMultas(txtDni.Text));
        }

        // ------------------------------------------------------------ Socio
        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            CargarSocios();
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
                if (dgvSocios.Rows.Count == 0) throw new Exception("No hay socios con multas pendientes que coincidan con el DNI ingresado.");
                if (dgvSocios.SelectedRows.Count == 0) throw new Exception("Seleccione un socio.");

                BE_Socio socio = (BE_Socio)dgvSocios.SelectedRows[0].DataBoundItem;
                multasPendientes = bll_Multa.ObtenerPendientes(socio);
                socioSeleccionado = socio;
                MostrarMultas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarMultas()
        {
            if (socioSeleccionado == null)
            {
                dgvMultas.DataSource = null;
                lblSocio.Text = $"{bll_idioma.Traducir("FormMulta.lblSocio")} —";
                lblTotal.Text = $"{bll_idioma.Traducir("FormMulta.lblTotal")} $ {0m:N2}";
                return;
            }
            lblSocio.Text = $"{bll_idioma.Traducir("FormMulta.lblSocio")} {socioSeleccionado.Apellido}, {socioSeleccionado.Nombre} - {bll_idioma.Traducir("FormMulta.colSocDni")} {socioSeleccionado.Dni}";
            Mostrar(dgvMultas, bll_Multa.ConsultarParaGrilla(multasPendientes));
            lblTotal.Text = $"{bll_idioma.Traducir("FormMulta.lblTotal")} $ {bll_Multa.CalcularTotalAdeudado(multasPendientes):N2}";
        }

        private void LimpiarMultas()
        {
            socioSeleccionado = null;
            multasPendientes = new List<BE_Multa>();
            MostrarMultas();
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

        // ------------------------------------------------------------ Idioma
        public void ActualizarIdioma()
        {
            this.Text = bll_idioma.Traducir("FormMulta.Form");
            lblSeccionSocio.Text = bll_idioma.Traducir("FormMulta.lblSeccionSocio");
            lblDni.Text = bll_idioma.Traducir("FormMulta.lblDni");
            txtDni.PlaceholderText = bll_idioma.Traducir("FormMulta.txtDni");
            btnSeleccionarSocio.Text = bll_idioma.Traducir("FormMulta.btnSeleccionarSocio");
            colSocNumero.HeaderText = bll_idioma.Traducir("FormMulta.colSocNumero");
            colSocApellido.HeaderText = bll_idioma.Traducir("FormMulta.colSocApellido");
            colSocNombre.HeaderText = bll_idioma.Traducir("FormMulta.colSocNombre");
            colSocDni.HeaderText = bll_idioma.Traducir("FormMulta.colSocDni");
            colSocMonto.HeaderText = bll_idioma.Traducir("FormMulta.colSocMonto");
            lblSeccionMultas.Text = bll_idioma.Traducir("FormMulta.lblSeccionMultas");
            colMulNumero.HeaderText = bll_idioma.Traducir("FormMulta.colMulNumero");
            colMulPrestamo.HeaderText = bll_idioma.Traducir("FormMulta.colMulPrestamo");
            colMulFecha.HeaderText = bll_idioma.Traducir("FormMulta.colMulFecha");
            colMulDias.HeaderText = bll_idioma.Traducir("FormMulta.colMulDias");
            colMulMonto.HeaderText = bll_idioma.Traducir("FormMulta.colMulMonto");
            btnConfirmarCobro.Text = bll_idioma.Traducir("FormMulta.btnConfirmarCobro");
            btnNoAbona.Text = bll_idioma.Traducir("FormMulta.btnNoAbona");
            if (bll_Multa != null) MostrarMultas();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma.Desuscribir(this);
            base.OnFormClosed(e);
        }
    }
}
