using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            flwNavegacion = new FlowLayoutPanel();
            btnInicio = new BotonSGB();
            label2 = new Label();
            btnRegistrarPrestamo = new BotonSGB();
            btnRegistrarDevolucion = new BotonSGB();
            label3 = new Label();
            btnCobrarMultas = new BotonSGB();
            btnRegistrarDonacion = new BotonSGB();
            label4 = new Label();
            btnGestionSocios = new BotonSGB();
            btnGestionLibros = new BotonSGB();
            btnGestionEjemplares = new BotonSGB();
            lblSeccionNav = new Label();
            btnUsuarios = new BotonSGB();
            btnGestionRoles = new BotonSGB();
            btnBitacora = new BotonSGB();
            btnGestionRespaldo = new BotonSGB();
            label1 = new Label();
            btnCambiarClave = new BotonSGB();
            btnRelogin = new BotonSGB();
            btnLogout = new BotonSGB();
            label5 = new Label();
            btnReportes = new BotonSGB();
            btnAyuda = new BotonSGB();
            pnlMarca = new Panel();
            lblLogo = new Label();
            lblTituloTopbar = new Label();
            pnlTopbar = new Panel();
            pnlLineaTopbar = new Panel();
            lblPantalla = new Label();
            lblUsuario = new Label();
            cboIdioma = new ComboBox();
            pnlContenido = new Panel();
            pnlSidebar.SuspendLayout();
            flwNavegacion.SuspendLayout();
            pnlMarca.SuspendLayout();
            pnlTopbar.SuspendLayout();
            pnlLineaTopbar.SuspendLayout();
            pnlContenido.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(33, 37, 41);
            pnlSidebar.Controls.Add(flwNavegacion);
            pnlSidebar.Controls.Add(pnlMarca);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(248, 728);
            pnlSidebar.TabIndex = 0;
            // 
            // flwNavegacion
            // 
            flwNavegacion.BackColor = Color.FromArgb(33, 37, 41);
            flwNavegacion.Controls.Add(btnInicio);
            flwNavegacion.Controls.Add(label2);
            flwNavegacion.Controls.Add(btnRegistrarPrestamo);
            flwNavegacion.Controls.Add(btnRegistrarDevolucion);
            flwNavegacion.Controls.Add(label3);
            flwNavegacion.Controls.Add(btnCobrarMultas);
            flwNavegacion.Controls.Add(btnRegistrarDonacion);
            flwNavegacion.Controls.Add(label4);
            flwNavegacion.Controls.Add(btnGestionSocios);
            flwNavegacion.Controls.Add(btnGestionLibros);
            flwNavegacion.Controls.Add(btnGestionEjemplares);
            flwNavegacion.Controls.Add(lblSeccionNav);
            flwNavegacion.Controls.Add(btnUsuarios);
            flwNavegacion.Controls.Add(btnGestionRoles);
            flwNavegacion.Controls.Add(btnBitacora);
            flwNavegacion.Controls.Add(btnGestionRespaldo);
            flwNavegacion.Controls.Add(label1);
            flwNavegacion.Controls.Add(btnCambiarClave);
            flwNavegacion.Controls.Add(btnRelogin);
            flwNavegacion.Controls.Add(btnLogout);
            flwNavegacion.Controls.Add(label5);
            flwNavegacion.Controls.Add(btnReportes);
            flwNavegacion.Controls.Add(btnAyuda);
            flwNavegacion.FlowDirection = FlowDirection.TopDown;
            flwNavegacion.AutoScroll = true;
            flwNavegacion.WrapContents = false;
            flwNavegacion.Dock = DockStyle.Fill;
            flwNavegacion.Name = "flwNavegacion";
            flwNavegacion.Padding = new Padding(0, 6, 0, 16);
            flwNavegacion.Size = new Size(248, 644);
            flwNavegacion.TabIndex = 0;
            // 
            // btnInicio
            // 
            btnInicio.Estilo = EstiloBoton.Menu;
            btnInicio.Font = new Font("Segoe UI", 10.5F);
            btnInicio.Icono = "\uE80F";
            btnInicio.Margin = new Padding(12, 2, 0, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(216, 42);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.Click += btnInicio_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 8.5F);
            label2.ForeColor = Color.FromArgb(134, 142, 150);
            label2.Margin = new Padding(24, 18, 0, 6);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "PRÉSTAMOS";
            // 
            // btnRegistrarPrestamo
            // 
            btnRegistrarPrestamo.Estilo = EstiloBoton.Menu;
            btnRegistrarPrestamo.Font = new Font("Segoe UI", 10.5F);
            btnRegistrarPrestamo.Icono = "\uE8F1";
            btnRegistrarPrestamo.Margin = new Padding(12, 2, 0, 2);
            btnRegistrarPrestamo.Name = "btnRegistrarPrestamo";
            btnRegistrarPrestamo.Size = new Size(216, 42);
            btnRegistrarPrestamo.TabIndex = 2;
            btnRegistrarPrestamo.Text = "Registrar préstamo";
            btnRegistrarPrestamo.Click += btnRegistrarPrestamo_Click;
            // 
            // btnRegistrarDevolucion
            // 
            btnRegistrarDevolucion.Estilo = EstiloBoton.Menu;
            btnRegistrarDevolucion.Font = new Font("Segoe UI", 10.5F);
            btnRegistrarDevolucion.Icono = "\uE7A7";
            btnRegistrarDevolucion.Margin = new Padding(12, 2, 0, 2);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Size = new Size(216, 42);
            btnRegistrarDevolucion.TabIndex = 3;
            btnRegistrarDevolucion.Text = "Registrar devolución";
            btnRegistrarDevolucion.Click += btnRegistrarDevolucion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 8.5F);
            label3.ForeColor = Color.FromArgb(134, 142, 150);
            label3.Margin = new Padding(24, 18, 0, 6);
            label3.Name = "label3";
            label3.Size = new Size(152, 20);
            label3.TabIndex = 4;
            label3.Text = "MULTAS Y DONACIONES";
            // 
            // btnCobrarMultas
            // 
            btnCobrarMultas.Estilo = EstiloBoton.Menu;
            btnCobrarMultas.Font = new Font("Segoe UI", 10.5F);
            btnCobrarMultas.Icono = "\uE8C7";
            btnCobrarMultas.Margin = new Padding(12, 2, 0, 2);
            btnCobrarMultas.Name = "btnCobrarMultas";
            btnCobrarMultas.Size = new Size(216, 42);
            btnCobrarMultas.TabIndex = 5;
            btnCobrarMultas.Text = "Cobrar multas";
            btnCobrarMultas.Click += btnCobrarMultas_Click;
            // 
            // btnRegistrarDonacion
            // 
            btnRegistrarDonacion.Estilo = EstiloBoton.Menu;
            btnRegistrarDonacion.Font = new Font("Segoe UI", 10.5F);
            btnRegistrarDonacion.Icono = "\uEB51";
            btnRegistrarDonacion.Margin = new Padding(12, 2, 0, 2);
            btnRegistrarDonacion.Name = "btnRegistrarDonacion";
            btnRegistrarDonacion.Size = new Size(216, 42);
            btnRegistrarDonacion.TabIndex = 6;
            btnRegistrarDonacion.Text = "Registrar donación";
            btnRegistrarDonacion.Click += btnRegistrarDonacion_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 8.5F);
            label4.ForeColor = Color.FromArgb(134, 142, 150);
            label4.Margin = new Padding(24, 18, 0, 6);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 7;
            label4.Text = "SOCIOS Y CATÁLOGO";
            // 
            // btnGestionSocios
            // 
            btnGestionSocios.Estilo = EstiloBoton.Menu;
            btnGestionSocios.Font = new Font("Segoe UI", 10.5F);
            btnGestionSocios.Icono = "\uE716";
            btnGestionSocios.Margin = new Padding(12, 2, 0, 2);
            btnGestionSocios.Name = "btnGestionSocios";
            btnGestionSocios.Size = new Size(216, 42);
            btnGestionSocios.TabIndex = 8;
            btnGestionSocios.Text = "Gestionar socios";
            btnGestionSocios.Click += btnGestionSocios_Click;
            // 
            // btnGestionLibros
            // 
            btnGestionLibros.Estilo = EstiloBoton.Menu;
            btnGestionLibros.Font = new Font("Segoe UI", 10.5F);
            btnGestionLibros.Icono = "\uE82D";
            btnGestionLibros.Margin = new Padding(12, 2, 0, 2);
            btnGestionLibros.Name = "btnGestionLibros";
            btnGestionLibros.Size = new Size(216, 42);
            btnGestionLibros.TabIndex = 9;
            btnGestionLibros.Text = "Gestionar libros";
            btnGestionLibros.Click += btnGestionLibros_Click;
            // 
            // btnGestionEjemplares
            // 
            btnGestionEjemplares.Estilo = EstiloBoton.Menu;
            btnGestionEjemplares.Font = new Font("Segoe UI", 10.5F);
            btnGestionEjemplares.Icono = "\uE8A5";
            btnGestionEjemplares.Margin = new Padding(12, 2, 0, 2);
            btnGestionEjemplares.Name = "btnGestionEjemplares";
            btnGestionEjemplares.Size = new Size(216, 42);
            btnGestionEjemplares.TabIndex = 10;
            btnGestionEjemplares.Text = "Gestionar ejemplares";
            btnGestionEjemplares.Click += btnGestionEjemplares_Click;
            // 
            // lblSeccionNav
            // 
            lblSeccionNav.AutoSize = true;
            lblSeccionNav.BackColor = Color.Transparent;
            lblSeccionNav.Font = new Font("Segoe UI Semibold", 8.5F);
            lblSeccionNav.ForeColor = Color.FromArgb(134, 142, 150);
            lblSeccionNav.Margin = new Padding(24, 18, 0, 6);
            lblSeccionNav.Name = "lblSeccionNav";
            lblSeccionNav.Size = new Size(112, 20);
            lblSeccionNav.TabIndex = 11;
            lblSeccionNav.Text = "ADMINISTRACIÓN";
            // 
            // btnUsuarios
            // 
            btnUsuarios.Estilo = EstiloBoton.Menu;
            btnUsuarios.Font = new Font("Segoe UI", 10.5F);
            btnUsuarios.Icono = "\uE77B";
            btnUsuarios.Margin = new Padding(12, 2, 0, 2);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(216, 42);
            btnUsuarios.TabIndex = 12;
            btnUsuarios.Text = "Gestión de usuarios";
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnGestionRoles
            // 
            btnGestionRoles.Estilo = EstiloBoton.Menu;
            btnGestionRoles.Font = new Font("Segoe UI", 10.5F);
            btnGestionRoles.Icono = "\uE8D7";
            btnGestionRoles.Margin = new Padding(12, 2, 0, 2);
            btnGestionRoles.Name = "btnGestionRoles";
            btnGestionRoles.Size = new Size(216, 42);
            btnGestionRoles.TabIndex = 13;
            btnGestionRoles.Text = "Gestión de roles";
            btnGestionRoles.Click += btnGestionRoles_Click;
            // 
            // btnBitacora
            // 
            btnBitacora.Estilo = EstiloBoton.Menu;
            btnBitacora.Font = new Font("Segoe UI", 10.5F);
            btnBitacora.Icono = "\uE81C";
            btnBitacora.Margin = new Padding(12, 2, 0, 2);
            btnBitacora.Name = "btnBitacora";
            btnBitacora.Size = new Size(216, 42);
            btnBitacora.TabIndex = 14;
            btnBitacora.Text = "Bitácora";
            btnBitacora.Click += btnBitacora_Click;
            // 
            // btnGestionRespaldo
            // 
            btnGestionRespaldo.Estilo = EstiloBoton.Menu;
            btnGestionRespaldo.Font = new Font("Segoe UI", 10.5F);
            btnGestionRespaldo.Icono = "\uE74E";
            btnGestionRespaldo.Margin = new Padding(12, 2, 0, 2);
            btnGestionRespaldo.Name = "btnGestionRespaldo";
            btnGestionRespaldo.Size = new Size(216, 42);
            btnGestionRespaldo.TabIndex = 15;
            btnGestionRespaldo.Text = "Gestión de respaldo";
            btnGestionRespaldo.Click += btnGestionRespaldo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 8.5F);
            label1.ForeColor = Color.FromArgb(134, 142, 150);
            label1.Margin = new Padding(24, 18, 0, 6);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 16;
            label1.Text = "MI CUENTA";
            // 
            // btnCambiarClave
            // 
            btnCambiarClave.Estilo = EstiloBoton.Menu;
            btnCambiarClave.Font = new Font("Segoe UI", 10.5F);
            btnCambiarClave.Icono = "\uE72E";
            btnCambiarClave.Margin = new Padding(12, 2, 0, 2);
            btnCambiarClave.Name = "btnCambiarClave";
            btnCambiarClave.Size = new Size(216, 42);
            btnCambiarClave.TabIndex = 17;
            btnCambiarClave.Text = "Cambiar clave";
            btnCambiarClave.Click += btnCambiarClave_Click;
            // 
            // btnRelogin
            // 
            btnRelogin.Estilo = EstiloBoton.Menu;
            btnRelogin.Font = new Font("Segoe UI", 10.5F);
            btnRelogin.Icono = "\uE748";
            btnRelogin.Margin = new Padding(12, 2, 0, 2);
            btnRelogin.Name = "btnRelogin";
            btnRelogin.Size = new Size(216, 42);
            btnRelogin.TabIndex = 18;
            btnRelogin.Text = "Volver a iniciar sesión";
            btnRelogin.Click += btnRelogin_Click;
            // 
            // btnLogout
            // 
            btnLogout.Estilo = EstiloBoton.Menu;
            btnLogout.Font = new Font("Segoe UI", 10.5F);
            btnLogout.Icono = "\uE7E8";
            btnLogout.Margin = new Padding(12, 2, 0, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(216, 42);
            btnLogout.TabIndex = 19;
            btnLogout.Text = "Cerrar sesión";
            btnLogout.Click += btnLogout_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 8.5F);
            label5.ForeColor = Color.FromArgb(134, 142, 150);
            label5.Margin = new Padding(24, 18, 0, 6);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 20;
            label5.Text = "OTROS";
            // 
            // btnReportes
            // 
            btnReportes.Estilo = EstiloBoton.Menu;
            btnReportes.Font = new Font("Segoe UI", 10.5F);
            btnReportes.Icono = "\uE9D2";
            btnReportes.Margin = new Padding(12, 2, 0, 2);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(216, 42);
            btnReportes.TabIndex = 21;
            btnReportes.Text = "Reportes";
            // 
            // btnAyuda
            // 
            btnAyuda.Estilo = EstiloBoton.Menu;
            btnAyuda.Font = new Font("Segoe UI", 10.5F);
            btnAyuda.Icono = "\uE897";
            btnAyuda.Margin = new Padding(12, 2, 0, 2);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(216, 42);
            btnAyuda.TabIndex = 22;
            btnAyuda.Text = "Ayuda";
            // 
            // pnlMarca
            // 
            pnlMarca.BackColor = Color.FromArgb(33, 37, 41);
            pnlMarca.Controls.Add(lblLogo);
            pnlMarca.Controls.Add(lblTituloTopbar);
            pnlMarca.Dock = DockStyle.Top;
            pnlMarca.Name = "pnlMarca";
            pnlMarca.Size = new Size(248, 84);
            pnlMarca.TabIndex = 1;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = false;
            lblLogo.BackColor = Color.FromArgb(123, 30, 46);
            lblLogo.Font = new Font("Segoe UI Semibold", 11F);
            lblLogo.ForeColor = Color.FromArgb(255, 255, 255);
            lblLogo.Location = new Point(20, 20);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(44, 44);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "SGB";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloTopbar
            // 
            lblTituloTopbar.AutoSize = false;
            lblTituloTopbar.BackColor = Color.Transparent;
            lblTituloTopbar.Font = new Font("Segoe UI Semibold", 10.5F);
            lblTituloTopbar.ForeColor = Color.FromArgb(255, 255, 255);
            lblTituloTopbar.Location = new Point(74, 20);
            lblTituloTopbar.Name = "lblTituloTopbar";
            lblTituloTopbar.Size = new Size(160, 44);
            lblTituloTopbar.TabIndex = 1;
            lblTituloTopbar.Text = "Sistema de Gestión de Biblioteca";
            lblTituloTopbar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTopbar
            // 
            pnlTopbar.BackColor = Color.White;
            pnlTopbar.Controls.Add(pnlLineaTopbar);
            pnlTopbar.Controls.Add(lblPantalla);
            pnlTopbar.Controls.Add(lblUsuario);
            pnlTopbar.Controls.Add(cboIdioma);
            pnlTopbar.Dock = DockStyle.Top;
            pnlTopbar.Name = "pnlTopbar";
            pnlTopbar.Size = new Size(1118, 64);
            pnlTopbar.TabIndex = 1;
            // 
            // pnlLineaTopbar
            // 
            pnlLineaTopbar.BackColor = Color.FromArgb(226, 228, 233);
            pnlLineaTopbar.Dock = DockStyle.Bottom;
            pnlLineaTopbar.Name = "pnlLineaTopbar";
            pnlLineaTopbar.Size = new Size(1118, 1);
            pnlLineaTopbar.TabIndex = 0;
            // 
            // lblPantalla
            // 
            lblPantalla.AutoSize = true;
            lblPantalla.BackColor = Color.Transparent;
            lblPantalla.Font = new Font("Segoe UI Semibold", 15F);
            lblPantalla.ForeColor = Color.FromArgb(31, 41, 55);
            lblPantalla.Location = new Point(28, 17);
            lblPantalla.Name = "lblPantalla";
            lblPantalla.Size = new Size(48, 20);
            lblPantalla.TabIndex = 1;
            lblPantalla.Text = "Inicio";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = false;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.ForeColor = Color.FromArgb(75, 85, 99);
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.Location = new Point(574, 18);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(320, 28);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "—";
            lblUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboIdioma
            // 
            cboIdioma.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdioma.ForeColor = Color.FromArgb(31, 41, 55);
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboIdioma.Location = new Point(910, 18);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(180, 28);
            cboIdioma.TabIndex = 3;
            cboIdioma.SelectedIndexChanged += cboIdioma_SelectedIndexChanged;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.FromArgb(244, 245, 247);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1118, 664);
            pnlContenido.TabIndex = 2;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1366, 728);
            Controls.Add(pnlContenido);
            Controls.Add(pnlTopbar);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            MinimumSize = new Size(1024, 640);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmMenu_FormClosing;
            Load += FrmMenu_Load;
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            pnlLineaTopbar.ResumeLayout(false);
            pnlLineaTopbar.PerformLayout();
            pnlTopbar.ResumeLayout(false);
            pnlTopbar.PerformLayout();
            pnlMarca.ResumeLayout(false);
            pnlMarca.PerformLayout();
            flwNavegacion.ResumeLayout(false);
            flwNavegacion.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private FlowLayoutPanel flwNavegacion;
        private BotonSGB btnInicio;
        private Label label2;
        private BotonSGB btnRegistrarPrestamo;
        private BotonSGB btnRegistrarDevolucion;
        private Label label3;
        private BotonSGB btnCobrarMultas;
        private BotonSGB btnRegistrarDonacion;
        private Label label4;
        private BotonSGB btnGestionSocios;
        private BotonSGB btnGestionLibros;
        private BotonSGB btnGestionEjemplares;
        private Label lblSeccionNav;
        private BotonSGB btnUsuarios;
        private BotonSGB btnGestionRoles;
        private BotonSGB btnBitacora;
        private BotonSGB btnGestionRespaldo;
        private Label label1;
        private BotonSGB btnCambiarClave;
        private BotonSGB btnRelogin;
        private BotonSGB btnLogout;
        private Label label5;
        private BotonSGB btnReportes;
        private BotonSGB btnAyuda;
        private Panel pnlMarca;
        private Label lblLogo;
        private Label lblTituloTopbar;
        private Panel pnlTopbar;
        private Panel pnlLineaTopbar;
        private Label lblPantalla;
        private Label lblUsuario;
        private ComboBox cboIdioma;
        private Panel pnlContenido;
    }
}
