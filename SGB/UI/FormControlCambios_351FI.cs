using BE;
using BLL.BLL_NEG;
using BLL.BLL_SER;
using Servicio;

namespace UI
{
    // CU-SER-10 Auditar control de cambios: historial de versiones de los socios y activación de una versión anterior
    public partial class FormControlCambios_351FI : Form, IObservadorIdioma_351FI
    {
        BLL_Idioma_351FI bll_idioma_351FI = new BLL_Idioma_351FI();
        BLL_SocioC_351FI bll_socioC_351FI;
        BLL_Socio_351FI bll_socio_351FI;

        public FormControlCambios_351FI()
        {
            InitializeComponent();
            bll_idioma_351FI.Suscribir_351FI(this);
        }

        private void FormControlCambios_351FI_Load(object sender_351FI, EventArgs e_351FI)
        {
            bll_socioC_351FI = new BLL_SocioC_351FI();
            bll_socio_351FI = new BLL_Socio_351FI();

            dgvVersiones_351FI.AutoGenerateColumns = false;
            colVerVersion_351FI.DataPropertyName = "IdVersion_351FI";
            colVerSocio_351FI.DataPropertyName = "NumeroSocio_351FI";
            colVerApellido_351FI.DataPropertyName = "Apellido_351FI";
            colVerNombre_351FI.DataPropertyName = "Nombre_351FI";
            colVerDni_351FI.DataPropertyName = "Dni_351FI";
            colVerEstado_351FI.DataPropertyName = "Estado_351FI";
            colVerFecha_351FI.DataPropertyName = "Fecha_351FI";
            colVerHora_351FI.DataPropertyName = "Hora_351FI";
            colVerActiva_351FI.DataPropertyName = "Activo_351FI";

            dgvSocios_351FI.AutoGenerateColumns = false;
            colSocNumero_351FI.DataPropertyName = "NumeroSocio_351FI";
            colSocApellido_351FI.DataPropertyName = "Apellido_351FI";
            colSocNombre_351FI.DataPropertyName = "Nombre_351FI";
            colSocDni_351FI.DataPropertyName = "Dni_351FI";
            colSocEstado_351FI.DataPropertyName = "Estado_351FI";

            // Al abrir se muestran las versiones del último mes
            dtpFechaHasta_351FI.Value = DateTime.Today;
            dtpFechaDesde_351FI.Value = DateTime.Today.AddMonths(-1);

            CargarVersiones_351FI();
            CargarSocios_351FI();
            ActualizarIdioma_351FI();
        }

        // ------------------------------------------------------------ Versiones

        private void CargarVersiones_351FI()
        {
            int? numeroSocio = null;
            if (txtNumeroSocio_351FI.Text.Trim() != "")
            {
                if (!int.TryParse(txtNumeroSocio_351FI.Text.Trim(), out int numero)) throw new Exception("El número de socio debe ser numérico.");
                numeroSocio = numero;
            }

            List<BE_SocioC_351FI> versiones = bll_socioC_351FI.ConsultarVersiones_351FI(numeroSocio, txtApellido_351FI.Text, dtpFechaDesde_351FI.Value, dtpFechaHasta_351FI.Value);
            MostrarVersiones_351FI(versiones);
        }

        private void MostrarVersiones_351FI(List<BE_SocioC_351FI> versiones_351FI)
        {
            dgvVersiones_351FI.DataSource = null;
            dgvVersiones_351FI.DataSource = versiones_351FI;
            dgvVersiones_351FI.ClearSelection();
        }

        private void btnFiltrar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                CargarVersiones_351FI();
                if (dgvVersiones_351FI.Rows.Count == 0)
                    MessageBox.Show("No se encontraron versiones que cumplan con los criterios ingresados.", "Control de cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ------------------------------------------------------------ Socios vigentes

        private void CargarSocios_351FI()
        {
            MostrarSocios_351FI(bll_socio_351FI.ObtenerTodos_351FI());
        }

        private void MostrarSocios_351FI(List<BE_Socio_351FI> socios_351FI)
        {
            dgvSocios_351FI.DataSource = null;
            dgvSocios_351FI.DataSource = socios_351FI;
            dgvSocios_351FI.ClearSelection();
        }

        // ------------------------------------------------------------ Activación

        private void btnActivar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (dgvVersiones_351FI.SelectedRows.Count == 0 || dgvVersiones_351FI.SelectedRows[0].DataBoundItem == null)
                    throw new Exception("Seleccione la versión que desea dejar vigente.");

                BE_SocioC_351FI version = (BE_SocioC_351FI)dgvVersiones_351FI.SelectedRows[0].DataBoundItem;
                if (!SolicitarConfirmacion_351FI(version)) return;

                bll_socioC_351FI.Activar_351FI(version);
                MessageBox.Show($"La versión {version.IdVersion_351FI} quedó vigente para el socio N° {version.NumeroSocio_351FI}.", "Control de cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarVersiones_351FI();
                CargarSocios_351FI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool SolicitarConfirmacion_351FI(BE_SocioC_351FI version_351FI)
        {
            return MessageBox.Show(
                $"¿Confirma que desea dejar vigente la versión del socio N° {version_351FI.NumeroSocio_351FI} registrada el {version_351FI.Fecha_351FI:dd/MM/yyyy} a las {version_351FI.Hora_351FI:hh\\:mm\\:ss}?\n" +
                $"{version_351FI.Apellido_351FI}, {version_351FI.Nombre_351FI} - DNI {version_351FI.Dni_351FI} - {version_351FI.Estado_351FI}",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void btnCerrar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            this.Close();
        }

        // ------------------------------------------------------------ Idioma
        public void ActualizarIdioma_351FI()
        {
            this.Text = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.Form");
            lblSeccionVersiones_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.lblSeccionVersiones_351FI");
            lblNumeroSocio_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.lblNumeroSocio_351FI");
            lblApellido_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.lblApellido_351FI");
            lblFechaDesde_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.lblFechaDesde_351FI");
            lblFechaHasta_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.lblFechaHasta_351FI");
            btnFiltrar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.btnFiltrar_351FI");
            colVerVersion_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.colVerVersion_351FI");
            colVerSocio_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.colVerSocio_351FI");
            colVerApellido_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.colVerApellido_351FI");
            colVerNombre_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.colVerNombre_351FI");
            colVerDni_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.colVerDni_351FI");
            colVerEstado_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.colVerEstado_351FI");
            colVerFecha_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.colVerFecha_351FI");
            colVerHora_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.colVerHora_351FI");
            colVerActiva_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.colVerActiva_351FI");
            btnActivar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.btnActivar_351FI");
            lblSeccionSocios_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.lblSeccionSocios_351FI");
            colSocNumero_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.colSocNumero_351FI");
            colSocApellido_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.colSocApellido_351FI");
            colSocNombre_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.colSocNombre_351FI");
            colSocDni_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.colSocDni_351FI");
            colSocEstado_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.colSocEstado_351FI");
            btnCerrar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormControlCambios_351FI.btnCerrar_351FI");
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma_351FI.Desuscribir_351FI(this);
            base.OnFormClosed(e);
        }
    }
}
