using BE;
using BLL.BLL_NEG;
using BLL.BLL_SER;
using Servicio;

namespace UI
{
    public partial class FormSocio_351FI : Form, IObservadorIdioma_351FI
    {
        BLL_Idioma_351FI bll_idioma_351FI = new BLL_Idioma_351FI();
        BLL_Socio_351FI bll_Socio_351FI;
        BE_Socio_351FI? socioSeleccionado_351FI;

        public FormSocio_351FI()
        {
            InitializeComponent();
            bll_idioma_351FI.Suscribir_351FI(this);
        }

        private void FormSocio_351FI_Load(object sender_351FI, EventArgs e_351FI)
        {
            bll_Socio_351FI = new BLL_Socio_351FI();

            dgvSocios_351FI.AutoGenerateColumns = false;
            colSocNumero_351FI.DataPropertyName = "NumeroSocio_351FI";
            colSocApellido_351FI.DataPropertyName = "Apellido_351FI";
            colSocNombre_351FI.DataPropertyName = "Nombre_351FI";
            colSocDni_351FI.DataPropertyName = "Dni_351FI";
            colSocEstado_351FI.DataPropertyName = "Estado_351FI";

            SER_Usuario_351FI usuario = SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI;
            btnAlta_351FI.Enabled = usuario.Rol_351FI.TienePermiso_351FI("Alta Socio");

            CargarSocios_351FI();
            ActualizarIdioma_351FI();
            this.Shown += FormSocio_351FI_Shown;
        }

        // La grilla selecciona la primera fila al mostrarse; se limpia para no precargar los datos de un socio
        private void FormSocio_351FI_Shown(object? sender_351FI, EventArgs e_351FI)
        {
            dgvSocios_351FI.ClearSelection();
            Limpiar_351FI();
        }

        private void CargarSocios_351FI()
        {
            dgvSocios_351FI.DataSource = null;
            dgvSocios_351FI.DataSource = bll_Socio_351FI.BuscarPorDni_351FI(txtBuscarDni_351FI.Text);
            dgvSocios_351FI.ClearSelection();
            Limpiar_351FI();
        }

        private void txtBuscarDni_351FI_TextChanged(object sender_351FI, EventArgs e_351FI)
        {
            CargarSocios_351FI();
        }

        private void dgvSocios_351FI_SelectionChanged(object sender_351FI, EventArgs e_351FI)
        {
            if (dgvSocios_351FI.SelectedRows.Count == 0 || dgvSocios_351FI.SelectedRows[0].DataBoundItem == null) return;

            socioSeleccionado_351FI = (BE_Socio_351FI)dgvSocios_351FI.SelectedRows[0].DataBoundItem;
            txtNombre_351FI.Text = socioSeleccionado_351FI.Nombre_351FI;
            txtApellido_351FI.Text = socioSeleccionado_351FI.Apellido_351FI;
            txtDni_351FI.Text = socioSeleccionado_351FI.Dni_351FI;
            MostrarEstado_351FI();
        }

        // Número del socio y botones disponibles según su estado
        private void MostrarEstado_351FI()
        {
            if (socioSeleccionado_351FI == null)
            {
                lblNumero_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.numeroNuevo");
                btnModificar_351FI.Enabled = false;
                btnBaja_351FI.Enabled = false;
                btnReactivar_351FI.Enabled = false;
                return;
            }

            // El botón se habilita si el estado del socio lo permite y el usuario tiene el permiso
            SER_Usuario_351FI usuario = SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI;
            bool dadoDeBaja = socioSeleccionado_351FI.Estado_351FI == "Baja";
            lblNumero_351FI.Text = $"{bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.lblNumero_351FI")} {socioSeleccionado_351FI.NumeroSocio_351FI} ({socioSeleccionado_351FI.Estado_351FI})";
            btnModificar_351FI.Enabled = usuario.Rol_351FI.TienePermiso_351FI("Modificar Socio");
            btnBaja_351FI.Enabled = !dadoDeBaja && usuario.Rol_351FI.TienePermiso_351FI("Baja Socio");
            btnReactivar_351FI.Enabled = dadoDeBaja && usuario.Rol_351FI.TienePermiso_351FI("Reactivar Socio");
        }

        private void Limpiar_351FI()
        {
            socioSeleccionado_351FI = null;
            txtNombre_351FI.Clear();
            txtApellido_351FI.Clear();
            txtDni_351FI.Clear();
            MostrarEstado_351FI();
        }

        private void btnLimpiar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            dgvSocios_351FI.ClearSelection();
            Limpiar_351FI();
            txtNombre_351FI.Focus();
        }

        // ------------------------------------------------------------ Alta
        private void btnAlta_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                BE_Socio_351FI socio = new BE_Socio_351FI(0, txtNombre_351FI.Text, txtApellido_351FI.Text, txtDni_351FI.Text, "Activo");
                bll_Socio_351FI.Alta_351FI(socio);

                MessageBox.Show($"Socio dado de alta correctamente con el número {socio.NumeroSocio_351FI}.", "Alta de socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSocios_351FI();
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
                if (socioSeleccionado_351FI == null) throw new Exception("Seleccione el socio a modificar.");

                BE_Socio_351FI socio = new BE_Socio_351FI(socioSeleccionado_351FI.NumeroSocio_351FI, txtNombre_351FI.Text, txtApellido_351FI.Text, txtDni_351FI.Text, socioSeleccionado_351FI.Estado_351FI);
                if (MessageBox.Show($"¿Confirma la modificación del socio N° {socio.NumeroSocio_351FI}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_Socio_351FI.Modificar_351FI(socio);
                MessageBox.Show("Socio modificado correctamente.", "Modificación de socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSocios_351FI();
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
                if (socioSeleccionado_351FI == null) throw new Exception("Seleccione el socio a dar de baja.");

                if (MessageBox.Show($"¿Confirma la baja del socio {socioSeleccionado_351FI.Apellido_351FI}, {socioSeleccionado_351FI.Nombre_351FI}?\nUn socio dado de baja no puede realizar préstamos, pagos ni donaciones.",
                                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_Socio_351FI.Baja_351FI(socioSeleccionado_351FI);
                MessageBox.Show("Socio dado de baja correctamente.", "Baja de socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSocios_351FI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ------------------------------------------------------------ Reactivación (vuelve a dar de alta a un socio dado de baja)
        private void btnReactivar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (socioSeleccionado_351FI == null) throw new Exception("Seleccione el socio a reactivar.");

                if (MessageBox.Show($"¿Confirma la reactivación del socio {socioSeleccionado_351FI.Apellido_351FI}, {socioSeleccionado_351FI.Nombre_351FI}?",
                                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_Socio_351FI.Reactivar_351FI(socioSeleccionado_351FI);
                MessageBox.Show("Socio reactivado correctamente. Ya puede volver a realizar préstamos.", "Reactivación de socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSocios_351FI();
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
            this.Text = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.Form");
            lblSeccionSocios_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.lblSeccionSocios_351FI");
            lblBuscarDni_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.lblBuscarDni_351FI");
            colSocNumero_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.colSocNumero_351FI");
            colSocApellido_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.colSocApellido_351FI");
            colSocNombre_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.colSocNombre_351FI");
            colSocDni_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.colSocDni_351FI");
            colSocEstado_351FI.HeaderText = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.colSocEstado_351FI");
            lblSeccionDatos_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.lblSeccionDatos_351FI");
            lblNombre_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.lblNombre_351FI");
            lblApellido_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.lblApellido_351FI");
            lblDni_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.lblDni_351FI");
            btnAlta_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.btnAlta_351FI");
            btnModificar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.btnModificar_351FI");
            btnBaja_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.btnBaja_351FI");
            btnReactivar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.btnReactivar_351FI");
            btnLimpiar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.btnLimpiar_351FI");
            btnCerrar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormSocio_351FI.btnCerrar_351FI");
            if (bll_Socio_351FI != null) MostrarEstado_351FI();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma_351FI.Desuscribir_351FI(this);
            base.OnFormClosed(e);
        }
    }
}
