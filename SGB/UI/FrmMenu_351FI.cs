using BLL.BLL_SER;
using Servicio;

namespace UI
{
    public partial class FrmMenu_351FI : Form, IObservadorIdioma_351FI
    {
        BLL_Usuario_351FI bll_usuario_351FI;
        BLL_Idioma_351FI bll_idioma_351FI = new BLL_Idioma_351FI();
        bool cargandoIdiomas_351FI;

        // Navegación: las pantallas se abren dentro del área de contenido
        Form? pantallaActual_351FI;
        BotonSGB_351FI? botonActivo_351FI;
        bool cambiandoPantalla_351FI;
        bool cerrandoMenu_351FI;

        public FrmMenu_351FI()
        {
            InitializeComponent();
            bll_idioma_351FI.Suscribir_351FI(this);
            CargarIdiomas_351FI();
            ActualizarIdioma_351FI();
        }

        private void FrmMenu_351FI_Load(object sender_351FI, EventArgs e_351FI)
        {
            bll_usuario_351FI = new BLL_Usuario_351FI();

            SER_Usuario_351FI usuario = SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI;
            lblUsuario_351FI.Text = usuario.NombreUsuario_351FI;

            btnUsuarios_351FI.Visible = TieneAlgun_351FI(usuario, "Crear Usuario", "Modificar Usuario", "Desbloquear Usuario", "Activar Usuario");
            btnGestionRoles_351FI.Visible = TieneAlgun_351FI(usuario, "Crear Rol", "Crear Familia", "Eliminar Rol", "Eliminar Familia");
            btnBitacora_351FI.Visible = TieneAlgun_351FI(usuario, "Consultar Bitácora");
            btnGestionRespaldo_351FI.Visible = TieneAlgun_351FI(usuario, "Realizar Backup", "Realizar Restore");
            lblSeccionNav_351FI.Visible = btnUsuarios_351FI.Visible || btnGestionRoles_351FI.Visible || btnBitacora_351FI.Visible || btnGestionRespaldo_351FI.Visible;

            MostrarInicio_351FI();
        }

        private bool TieneAlgun_351FI(SER_Usuario_351FI usuario_351FI, params string[] permisos_351FI)
        {
            foreach (string permiso in permisos_351FI)
            {
                if (usuario_351FI.Rol_351FI.TienePermiso_351FI(permiso))
                    return true;
            }
            return false;
        }

        // ------------------------------------------------------------ Navegación

        private void Abrir_351FI<T>(BotonSGB_351FI boton_351FI) where T : Form, new()
        {
            // Si la pantalla ya está abierta se deja como está, sin perder lo cargado
            if (pantallaActual_351FI is T) return;
            AbrirPantalla_351FI(new T(), boton_351FI);
        }

        private void AbrirPantalla_351FI(Form pantalla_351FI, BotonSGB_351FI boton_351FI)
        {
            CerrarPantallaActual_351FI();

            pantalla_351FI.TopLevel = false;
            pantalla_351FI.FormBorderStyle = FormBorderStyle.None;
            pantalla_351FI.Dock = DockStyle.Fill;
            pantalla_351FI.FormClosed += Pantalla_FormClosed_351FI;
            pantalla_351FI.TextChanged += Pantalla_TextChanged_351FI;

            pantallaActual_351FI = pantalla_351FI;
            pnlContenido_351FI.Controls.Add(pantalla_351FI);
            MarcarBoton_351FI(boton_351FI);
            lblPantalla_351FI.Text = pantalla_351FI.Text;
            pantalla_351FI.Show();
            pantalla_351FI.BringToFront();
        }

        private void CerrarPantallaActual_351FI()
        {
            if (pantallaActual_351FI == null) return;
            cambiandoPantalla_351FI = true;
            pantallaActual_351FI.Close();
            cambiandoPantalla_351FI = false;
            pantallaActual_351FI = null;
        }

        private void MostrarInicio_351FI()
        {
            if (IsDisposed || cerrandoMenu_351FI) return;
            AbrirPantalla_351FI(new FormInicio_351FI(), btnInicio_351FI);
        }

        private void MarcarBoton_351FI(BotonSGB_351FI boton_351FI)
        {
            if (botonActivo_351FI != null) botonActivo_351FI.Activo_351FI = false;
            botonActivo_351FI = boton_351FI;
            botonActivo_351FI.Activo_351FI = true;
        }

        private void Pantalla_TextChanged_351FI(object? sender_351FI, EventArgs e_351FI)
        {
            if (sender_351FI == pantallaActual_351FI && pantallaActual_351FI != null)
                lblPantalla_351FI.Text = pantallaActual_351FI.Text;
        }

        // Cuando una pantalla se cierra con sus propios botones (Cerrar, Cancelar, Salir) se vuelve al inicio
        private void Pantalla_FormClosed_351FI(object? sender_351FI, FormClosedEventArgs e_351FI)
        {
            if (cerrandoMenu_351FI || cambiandoPantalla_351FI || sender_351FI != pantallaActual_351FI) return;
            pantallaActual_351FI = null;

            // Después de un restore la sesión se cierra, como en el resto del sistema
            if (sender_351FI is FrmBackup_351FI backup && backup.RestoreRealizado_351FI)
            {
                bll_usuario_351FI.Logout_351FI();
                this.Close();
                return;
            }

            if (!IsDisposed) BeginInvoke(new Action(MostrarInicio_351FI));
        }

        // ------------------------------------------------------------ Opciones del menú

        private void btnInicio_351FI_Click(object sender_351FI, EventArgs e_351FI) => Abrir_351FI<FormInicio_351FI>(btnInicio_351FI);
        private void btnRegistrarPrestamo_351FI_Click(object sender_351FI, EventArgs e_351FI) => Abrir_351FI<FormPrestamo_351FI>(btnRegistrarPrestamo_351FI);
        private void btnRegistrarDevolucion_351FI_Click(object sender_351FI, EventArgs e_351FI) => Abrir_351FI<FormDevolucion_351FI>(btnRegistrarDevolucion_351FI);
        private void btnCobrarMultas_351FI_Click(object sender_351FI, EventArgs e_351FI) => Abrir_351FI<FormMulta_351FI>(btnCobrarMultas_351FI);
        private void btnRegistrarDonacion_351FI_Click(object sender_351FI, EventArgs e_351FI) => Abrir_351FI<FormDonacion_351FI>(btnRegistrarDonacion_351FI);
        private void btnGestionSocios_351FI_Click(object sender_351FI, EventArgs e_351FI) => Abrir_351FI<FormSocio_351FI>(btnGestionSocios_351FI);
        private void btnGestionLibros_351FI_Click(object sender_351FI, EventArgs e_351FI) => Abrir_351FI<FormLibro_351FI>(btnGestionLibros_351FI);
        private void btnGestionEjemplares_351FI_Click(object sender_351FI, EventArgs e_351FI) => Abrir_351FI<FormEjemplar_351FI>(btnGestionEjemplares_351FI);
        private void btnUsuarios_351FI_Click(object sender_351FI, EventArgs e_351FI) => Abrir_351FI<FrmGestionUsuarios_351FI>(btnUsuarios_351FI);
        private void btnGestionRoles_351FI_Click(object sender_351FI, EventArgs e_351FI) => Abrir_351FI<FrmGestionRoles_351FI>(btnGestionRoles_351FI);
        private void btnBitacora_351FI_Click(object sender_351FI, EventArgs e_351FI) => Abrir_351FI<FrmBitacora_351FI>(btnBitacora_351FI);
        private void btnGestionRespaldo_351FI_Click(object sender_351FI, EventArgs e_351FI) => Abrir_351FI<FrmBackup_351FI>(btnGestionRespaldo_351FI);
        private void btnCambiarClave_351FI_Click(object sender_351FI, EventArgs e_351FI) => Abrir_351FI<frmCambiarClave_351FI>(btnCambiarClave_351FI);

        private void btnLogout_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            DialogResult res = MessageBox.Show(
                bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.msgCerrarSesion"),
                bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.msgConfirmacion"),
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // El logout se hace al cerrar el menú (FrmMenu_FormClosing)
            if (res == DialogResult.Yes)
                this.Close();
        }

        private void btnRelogin_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            FrmLogin_351FI frmLogin = new FrmLogin_351FI();
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void FrmMenu_351FI_FormClosing(object sender_351FI, FormClosingEventArgs e_351FI)
        {
            cerrandoMenu_351FI = true;
            // Primero se cierra la pantalla abierta para que deje de escuchar el cambio de idioma del logout
            CerrarPantallaActual_351FI();
            bll_usuario_351FI.Logout_351FI();
        }

        // ------------------------------------------------------------ Idioma

        private void CargarIdiomas_351FI()
        {
            cargandoIdiomas_351FI = true;
            cboIdioma_351FI.DisplayMember = "Nombre_351FI";
            cboIdioma_351FI.ValueMember = "Codigo_351FI";
            cboIdioma_351FI.DataSource = bll_idioma_351FI.ObtenerIdiomasDisponibles_351FI();
            cboIdioma_351FI.SelectedValue = bll_idioma_351FI.IdiomaActual_351FI;
            cargandoIdiomas_351FI = false;
        }

        private void cboIdioma_351FI_SelectedIndexChanged(object sender_351FI, EventArgs e_351FI)
        {
            if (cargandoIdiomas_351FI) return;
            try
            {
                bll_idioma_351FI.CambiarIdioma_351FI(cboIdioma_351FI.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ActualizarIdioma_351FI()
        {
            this.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.Form");
            lblTituloTopbar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.lblTituloTopbar_351FI");
            btnInicio_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.btnInicio_351FI");
            label2_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.label2_351FI");
            btnRegistrarPrestamo_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.btnRegistrarPrestamo_351FI");
            btnRegistrarDevolucion_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.btnRegistrarDevolucion_351FI");
            label3_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.label3_351FI");
            btnCobrarMultas_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.btnCobrarMultas_351FI");
            btnRegistrarDonacion_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.btnRegistrarDonacion_351FI");
            label4_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.label4_351FI");
            btnGestionSocios_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.btnGestionSocios_351FI");
            btnGestionLibros_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.btnGestionLibros_351FI");
            btnGestionEjemplares_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.btnGestionEjemplares_351FI");
            label5_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.label5_351FI");
            lblSeccionNav_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.lblSeccionNav_351FI");
            label1_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.label1_351FI");
            btnUsuarios_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.btnUsuarios_351FI");
            btnBitacora_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.btnBitacora_351FI");
            btnGestionRoles_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.btnGestionRoles_351FI");
            btnGestionRespaldo_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.btnGestionRespaldo_351FI");
            btnReportes_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.btnReportes_351FI");
            btnAyuda_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.btnAyuda_351FI");
            btnRelogin_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.btnRelogin_351FI");
            btnCambiarClave_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.btnCambiarClave_351FI");
            btnLogout_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmMenu_351FI.btnLogout_351FI");
            if (pantallaActual_351FI != null) lblPantalla_351FI.Text = pantallaActual_351FI.Text;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma_351FI.Desuscribir_351FI(this);
            base.OnFormClosed(e);
        }
    }
}
