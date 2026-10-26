using BLL.BLL_SER;
using Servicio;

namespace UI
{
    public partial class FrmMenu : Form, IObservadorIdioma
    {
        BLL_Usuario bll_usuario;
        BLL_Idioma bll_idioma = new BLL_Idioma();
        bool cargandoIdiomas;

        // Navegación: las pantallas se abren dentro del área de contenido
        Form? pantallaActual;
        BotonSGB? botonActivo;
        bool cambiandoPantalla;
        bool cerrandoMenu;

        public FrmMenu()
        {
            InitializeComponent();
            bll_idioma.Suscribir(this);
            CargarIdiomas();
            ActualizarIdioma();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            bll_usuario = new BLL_Usuario();

            SER_Usuario usuario = SER_SesionManager.ObtenerSesion().Usuario;
            lblUsuario.Text = usuario.NombreUsuario;

            btnUsuarios.Visible = TieneAlgun(usuario, "Crear Usuario", "Modificar Usuario", "Desbloquear Usuario", "Activar Usuario");
            btnGestionRoles.Visible = TieneAlgun(usuario, "Crear Rol", "Crear Familia", "Eliminar Rol", "Eliminar Familia");
            btnBitacora.Visible = TieneAlgun(usuario, "Consultar Bitácora");
            btnGestionRespaldo.Visible = TieneAlgun(usuario, "Realizar Backup", "Realizar Restore");
            lblSeccionNav.Visible = btnUsuarios.Visible || btnGestionRoles.Visible || btnBitacora.Visible || btnGestionRespaldo.Visible;

            MostrarInicio();
        }

        private bool TieneAlgun(SER_Usuario usuario, params string[] permisos)
        {
            foreach (string permiso in permisos)
            {
                if (usuario.Rol.TienePermiso(permiso))
                    return true;
            }
            return false;
        }

        // ------------------------------------------------------------ Navegación

        private void Abrir<T>(BotonSGB boton) where T : Form, new()
        {
            // Si la pantalla ya está abierta se deja como está, sin perder lo cargado
            if (pantallaActual is T) return;
            AbrirPantalla(new T(), boton);
        }

        private void AbrirPantalla(Form pantalla, BotonSGB boton)
        {
            CerrarPantallaActual();

            pantalla.TopLevel = false;
            pantalla.FormBorderStyle = FormBorderStyle.None;
            pantalla.Dock = DockStyle.Fill;
            pantalla.FormClosed += Pantalla_FormClosed;
            pantalla.TextChanged += Pantalla_TextChanged;

            pantallaActual = pantalla;
            pnlContenido.Controls.Add(pantalla);
            MarcarBoton(boton);
            lblPantalla.Text = pantalla.Text;
            pantalla.Show();
            pantalla.BringToFront();
        }

        private void CerrarPantallaActual()
        {
            if (pantallaActual == null) return;
            cambiandoPantalla = true;
            pantallaActual.Close();
            cambiandoPantalla = false;
            pantallaActual = null;
        }

        private void MostrarInicio()
        {
            if (IsDisposed || cerrandoMenu) return;
            AbrirPantalla(new FormInicio(), btnInicio);
        }

        private void MarcarBoton(BotonSGB boton)
        {
            if (botonActivo != null) botonActivo.Activo = false;
            botonActivo = boton;
            botonActivo.Activo = true;
        }

        private void Pantalla_TextChanged(object? sender, EventArgs e)
        {
            if (sender == pantallaActual && pantallaActual != null)
                lblPantalla.Text = pantallaActual.Text;
        }

        // Cuando una pantalla se cierra con sus propios botones (Cerrar, Cancelar, Salir) se vuelve al inicio
        private void Pantalla_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (cerrandoMenu || cambiandoPantalla || sender != pantallaActual) return;
            pantallaActual = null;

            // Después de un restore la sesión se cierra, como en el resto del sistema
            if (sender is FrmBackup backup && backup.RestoreRealizado)
            {
                bll_usuario.Logout();
                this.Close();
                return;
            }

            if (!IsDisposed) BeginInvoke(new Action(MostrarInicio));
        }

        // ------------------------------------------------------------ Opciones del menú

        private void btnInicio_Click(object sender, EventArgs e) => Abrir<FormInicio>(btnInicio);
        private void btnRegistrarPrestamo_Click(object sender, EventArgs e) => Abrir<FormPrestamo>(btnRegistrarPrestamo);
        private void btnRegistrarDevolucion_Click(object sender, EventArgs e) => Abrir<FormDevolucion>(btnRegistrarDevolucion);
        private void btnCobrarMultas_Click(object sender, EventArgs e) => Abrir<FormMulta>(btnCobrarMultas);
        private void btnRegistrarDonacion_Click(object sender, EventArgs e) => Abrir<FormDonacion>(btnRegistrarDonacion);
        private void btnGestionSocios_Click(object sender, EventArgs e) => Abrir<FormSocio>(btnGestionSocios);
        private void btnGestionLibros_Click(object sender, EventArgs e) => Abrir<FormLibro>(btnGestionLibros);
        private void btnGestionEjemplares_Click(object sender, EventArgs e) => Abrir<FormEjemplar>(btnGestionEjemplares);
        private void btnUsuarios_Click(object sender, EventArgs e) => Abrir<FrmGestionUsuarios>(btnUsuarios);
        private void btnGestionRoles_Click(object sender, EventArgs e) => Abrir<FrmGestionRoles>(btnGestionRoles);
        private void btnBitacora_Click(object sender, EventArgs e) => Abrir<FrmBitacora>(btnBitacora);
        private void btnGestionRespaldo_Click(object sender, EventArgs e) => Abrir<FrmBackup>(btnGestionRespaldo);
        private void btnCambiarClave_Click(object sender, EventArgs e) => Abrir<frmCambiarClave>(btnCambiarClave);

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                bll_idioma.Traducir("FrmMenu.msgCerrarSesion"),
                bll_idioma.Traducir("FrmMenu.msgConfirmacion"),
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // El logout se hace al cerrar el menú (FrmMenu_FormClosing)
            if (res == DialogResult.Yes)
                this.Close();
        }

        private void btnRelogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrandoMenu = true;
            // Primero se cierra la pantalla abierta para que deje de escuchar el cambio de idioma del logout
            CerrarPantallaActual();
            bll_usuario.Logout();
        }

        // ------------------------------------------------------------ Idioma

        private void CargarIdiomas()
        {
            cargandoIdiomas = true;
            cboIdioma.DisplayMember = "Nombre";
            cboIdioma.ValueMember = "Codigo";
            cboIdioma.DataSource = bll_idioma.ObtenerIdiomasDisponibles();
            cboIdioma.SelectedValue = bll_idioma.IdiomaActual;
            cargandoIdiomas = false;
        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoIdiomas) return;
            try
            {
                bll_idioma.CambiarIdioma(cboIdioma.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ActualizarIdioma()
        {
            this.Text = bll_idioma.Traducir("FrmMenu.Form");
            lblTituloTopbar.Text = bll_idioma.Traducir("FrmMenu.lblTituloTopbar");
            btnInicio.Text = bll_idioma.Traducir("FrmMenu.btnInicio");
            label2.Text = bll_idioma.Traducir("FrmMenu.label2");
            btnRegistrarPrestamo.Text = bll_idioma.Traducir("FrmMenu.btnRegistrarPrestamo");
            btnRegistrarDevolucion.Text = bll_idioma.Traducir("FrmMenu.btnRegistrarDevolucion");
            label3.Text = bll_idioma.Traducir("FrmMenu.label3");
            btnCobrarMultas.Text = bll_idioma.Traducir("FrmMenu.btnCobrarMultas");
            btnRegistrarDonacion.Text = bll_idioma.Traducir("FrmMenu.btnRegistrarDonacion");
            label4.Text = bll_idioma.Traducir("FrmMenu.label4");
            btnGestionSocios.Text = bll_idioma.Traducir("FrmMenu.btnGestionSocios");
            btnGestionLibros.Text = bll_idioma.Traducir("FrmMenu.btnGestionLibros");
            btnGestionEjemplares.Text = bll_idioma.Traducir("FrmMenu.btnGestionEjemplares");
            label5.Text = bll_idioma.Traducir("FrmMenu.label5");
            lblSeccionNav.Text = bll_idioma.Traducir("FrmMenu.lblSeccionNav");
            label1.Text = bll_idioma.Traducir("FrmMenu.label1");
            btnUsuarios.Text = bll_idioma.Traducir("FrmMenu.btnUsuarios");
            btnBitacora.Text = bll_idioma.Traducir("FrmMenu.btnBitacora");
            btnGestionRoles.Text = bll_idioma.Traducir("FrmMenu.btnGestionRoles");
            btnGestionRespaldo.Text = bll_idioma.Traducir("FrmMenu.btnGestionRespaldo");
            btnReportes.Text = bll_idioma.Traducir("FrmMenu.btnReportes");
            btnAyuda.Text = bll_idioma.Traducir("FrmMenu.btnAyuda");
            btnRelogin.Text = bll_idioma.Traducir("FrmMenu.btnRelogin");
            btnCambiarClave.Text = bll_idioma.Traducir("FrmMenu.btnCambiarClave");
            btnLogout.Text = bll_idioma.Traducir("FrmMenu.btnLogout");
            if (pantallaActual != null) lblPantalla.Text = pantallaActual.Text;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma.Desuscribir(this);
            base.OnFormClosed(e);
        }
    }
}
