using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FrmMenu_351FI
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
            pnlSidebar_351FI = new Panel();
            flwNavegacion_351FI = new FlowLayoutPanel();
            btnInicio_351FI = new BotonSGB_351FI();
            label2_351FI = new Label();
            btnRegistrarPrestamo_351FI = new BotonSGB_351FI();
            btnRegistrarDevolucion_351FI = new BotonSGB_351FI();
            label3_351FI = new Label();
            btnCobrarMultas_351FI = new BotonSGB_351FI();
            btnRegistrarDonacion_351FI = new BotonSGB_351FI();
            label4_351FI = new Label();
            btnGestionSocios_351FI = new BotonSGB_351FI();
            btnGestionLibros_351FI = new BotonSGB_351FI();
            btnGestionEjemplares_351FI = new BotonSGB_351FI();
            lblSeccionNav_351FI = new Label();
            btnUsuarios_351FI = new BotonSGB_351FI();
            btnGestionRoles_351FI = new BotonSGB_351FI();
            btnBitacora_351FI = new BotonSGB_351FI();
            btnGestionRespaldo_351FI = new BotonSGB_351FI();
            label1_351FI = new Label();
            btnCambiarClave_351FI = new BotonSGB_351FI();
            btnRelogin_351FI = new BotonSGB_351FI();
            btnLogout_351FI = new BotonSGB_351FI();
            label5_351FI = new Label();
            btnReportes_351FI = new BotonSGB_351FI();
            btnAyuda_351FI = new BotonSGB_351FI();
            pnlMarca_351FI = new Panel();
            lblLogo_351FI = new Label();
            lblTituloTopbar_351FI = new Label();
            pnlTopbar_351FI = new Panel();
            pnlLineaTopbar_351FI = new Panel();
            lblPantalla_351FI = new Label();
            lblUsuario_351FI = new Label();
            cboIdioma_351FI = new ComboBox();
            pnlContenido_351FI = new Panel();
            pnlSidebar_351FI.SuspendLayout();
            flwNavegacion_351FI.SuspendLayout();
            pnlMarca_351FI.SuspendLayout();
            pnlTopbar_351FI.SuspendLayout();
            pnlLineaTopbar_351FI.SuspendLayout();
            pnlContenido_351FI.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar_351FI.BackColor = Color.FromArgb(33, 37, 41);
            pnlSidebar_351FI.Controls.Add(flwNavegacion_351FI);
            pnlSidebar_351FI.Controls.Add(pnlMarca_351FI);
            pnlSidebar_351FI.Dock = DockStyle.Left;
            pnlSidebar_351FI.Name = "pnlSidebar_351FI";
            pnlSidebar_351FI.Size = new Size(248, 728);
            pnlSidebar_351FI.TabIndex = 0;
            // 
            // flwNavegacion
            // 
            flwNavegacion_351FI.BackColor = Color.FromArgb(33, 37, 41);
            flwNavegacion_351FI.Controls.Add(btnInicio_351FI);
            flwNavegacion_351FI.Controls.Add(label2_351FI);
            flwNavegacion_351FI.Controls.Add(btnRegistrarPrestamo_351FI);
            flwNavegacion_351FI.Controls.Add(btnRegistrarDevolucion_351FI);
            flwNavegacion_351FI.Controls.Add(label3_351FI);
            flwNavegacion_351FI.Controls.Add(btnCobrarMultas_351FI);
            flwNavegacion_351FI.Controls.Add(btnRegistrarDonacion_351FI);
            flwNavegacion_351FI.Controls.Add(label4_351FI);
            flwNavegacion_351FI.Controls.Add(btnGestionSocios_351FI);
            flwNavegacion_351FI.Controls.Add(btnGestionLibros_351FI);
            flwNavegacion_351FI.Controls.Add(btnGestionEjemplares_351FI);
            flwNavegacion_351FI.Controls.Add(lblSeccionNav_351FI);
            flwNavegacion_351FI.Controls.Add(btnUsuarios_351FI);
            flwNavegacion_351FI.Controls.Add(btnGestionRoles_351FI);
            flwNavegacion_351FI.Controls.Add(btnBitacora_351FI);
            flwNavegacion_351FI.Controls.Add(btnGestionRespaldo_351FI);
            flwNavegacion_351FI.Controls.Add(label1_351FI);
            flwNavegacion_351FI.Controls.Add(btnCambiarClave_351FI);
            flwNavegacion_351FI.Controls.Add(btnRelogin_351FI);
            flwNavegacion_351FI.Controls.Add(btnLogout_351FI);
            flwNavegacion_351FI.Controls.Add(label5_351FI);
            flwNavegacion_351FI.Controls.Add(btnReportes_351FI);
            flwNavegacion_351FI.Controls.Add(btnAyuda_351FI);
            flwNavegacion_351FI.FlowDirection = FlowDirection.TopDown;
            flwNavegacion_351FI.AutoScroll = true;
            flwNavegacion_351FI.WrapContents = false;
            flwNavegacion_351FI.Dock = DockStyle.Fill;
            flwNavegacion_351FI.Name = "flwNavegacion_351FI";
            flwNavegacion_351FI.Padding = new Padding(0, 6, 0, 16);
            flwNavegacion_351FI.Size = new Size(248, 644);
            flwNavegacion_351FI.TabIndex = 0;
            // 
            // btnInicio
            // 
            btnInicio_351FI.Estilo_351FI = EstiloBoton_351FI.Menu;
            btnInicio_351FI.Font = new Font("Segoe UI", 10.5F);
            btnInicio_351FI.Icono_351FI = "\uE80F";
            btnInicio_351FI.Margin = new Padding(12, 2, 0, 2);
            btnInicio_351FI.Name = "btnInicio_351FI";
            btnInicio_351FI.Size = new Size(216, 42);
            btnInicio_351FI.TabIndex = 0;
            btnInicio_351FI.Text = "Inicio";
            btnInicio_351FI.Click += btnInicio_351FI_Click;
            // 
            // label2
            // 
            label2_351FI.AutoSize = true;
            label2_351FI.BackColor = Color.Transparent;
            label2_351FI.Font = new Font("Segoe UI Semibold", 8.5F);
            label2_351FI.ForeColor = Color.FromArgb(134, 142, 150);
            label2_351FI.Margin = new Padding(24, 18, 0, 6);
            label2_351FI.Name = "label2_351FI";
            label2_351FI.Size = new Size(72, 20);
            label2_351FI.TabIndex = 1;
            label2_351FI.Text = "PRÉSTAMOS";
            // 
            // btnRegistrarPrestamo
            // 
            btnRegistrarPrestamo_351FI.Estilo_351FI = EstiloBoton_351FI.Menu;
            btnRegistrarPrestamo_351FI.Font = new Font("Segoe UI", 10.5F);
            btnRegistrarPrestamo_351FI.Icono_351FI = "\uE8F1";
            btnRegistrarPrestamo_351FI.Margin = new Padding(12, 2, 0, 2);
            btnRegistrarPrestamo_351FI.Name = "btnRegistrarPrestamo_351FI";
            btnRegistrarPrestamo_351FI.Size = new Size(216, 42);
            btnRegistrarPrestamo_351FI.TabIndex = 2;
            btnRegistrarPrestamo_351FI.Text = "Registrar préstamo";
            btnRegistrarPrestamo_351FI.Click += btnRegistrarPrestamo_351FI_Click;
            // 
            // btnRegistrarDevolucion
            // 
            btnRegistrarDevolucion_351FI.Estilo_351FI = EstiloBoton_351FI.Menu;
            btnRegistrarDevolucion_351FI.Font = new Font("Segoe UI", 10.5F);
            btnRegistrarDevolucion_351FI.Icono_351FI = "\uE7A7";
            btnRegistrarDevolucion_351FI.Margin = new Padding(12, 2, 0, 2);
            btnRegistrarDevolucion_351FI.Name = "btnRegistrarDevolucion_351FI";
            btnRegistrarDevolucion_351FI.Size = new Size(216, 42);
            btnRegistrarDevolucion_351FI.TabIndex = 3;
            btnRegistrarDevolucion_351FI.Text = "Registrar devolución";
            btnRegistrarDevolucion_351FI.Click += btnRegistrarDevolucion_351FI_Click;
            // 
            // label3
            // 
            label3_351FI.AutoSize = true;
            label3_351FI.BackColor = Color.Transparent;
            label3_351FI.Font = new Font("Segoe UI Semibold", 8.5F);
            label3_351FI.ForeColor = Color.FromArgb(134, 142, 150);
            label3_351FI.Margin = new Padding(24, 18, 0, 6);
            label3_351FI.Name = "label3_351FI";
            label3_351FI.Size = new Size(152, 20);
            label3_351FI.TabIndex = 4;
            label3_351FI.Text = "MULTAS Y DONACIONES";
            // 
            // btnCobrarMultas
            // 
            btnCobrarMultas_351FI.Estilo_351FI = EstiloBoton_351FI.Menu;
            btnCobrarMultas_351FI.Font = new Font("Segoe UI", 10.5F);
            btnCobrarMultas_351FI.Icono_351FI = "\uE8C7";
            btnCobrarMultas_351FI.Margin = new Padding(12, 2, 0, 2);
            btnCobrarMultas_351FI.Name = "btnCobrarMultas_351FI";
            btnCobrarMultas_351FI.Size = new Size(216, 42);
            btnCobrarMultas_351FI.TabIndex = 5;
            btnCobrarMultas_351FI.Text = "Cobrar multas";
            btnCobrarMultas_351FI.Click += btnCobrarMultas_351FI_Click;
            // 
            // btnRegistrarDonacion
            // 
            btnRegistrarDonacion_351FI.Estilo_351FI = EstiloBoton_351FI.Menu;
            btnRegistrarDonacion_351FI.Font = new Font("Segoe UI", 10.5F);
            btnRegistrarDonacion_351FI.Icono_351FI = "\uEB51";
            btnRegistrarDonacion_351FI.Margin = new Padding(12, 2, 0, 2);
            btnRegistrarDonacion_351FI.Name = "btnRegistrarDonacion_351FI";
            btnRegistrarDonacion_351FI.Size = new Size(216, 42);
            btnRegistrarDonacion_351FI.TabIndex = 6;
            btnRegistrarDonacion_351FI.Text = "Registrar donación";
            btnRegistrarDonacion_351FI.Click += btnRegistrarDonacion_351FI_Click;
            // 
            // label4
            // 
            label4_351FI.AutoSize = true;
            label4_351FI.BackColor = Color.Transparent;
            label4_351FI.Font = new Font("Segoe UI Semibold", 8.5F);
            label4_351FI.ForeColor = Color.FromArgb(134, 142, 150);
            label4_351FI.Margin = new Padding(24, 18, 0, 6);
            label4_351FI.Name = "label4_351FI";
            label4_351FI.Size = new Size(136, 20);
            label4_351FI.TabIndex = 7;
            label4_351FI.Text = "SOCIOS Y CATÁLOGO";
            // 
            // btnGestionSocios
            // 
            btnGestionSocios_351FI.Estilo_351FI = EstiloBoton_351FI.Menu;
            btnGestionSocios_351FI.Font = new Font("Segoe UI", 10.5F);
            btnGestionSocios_351FI.Icono_351FI = "\uE716";
            btnGestionSocios_351FI.Margin = new Padding(12, 2, 0, 2);
            btnGestionSocios_351FI.Name = "btnGestionSocios_351FI";
            btnGestionSocios_351FI.Size = new Size(216, 42);
            btnGestionSocios_351FI.TabIndex = 8;
            btnGestionSocios_351FI.Text = "Gestionar socios";
            btnGestionSocios_351FI.Click += btnGestionSocios_351FI_Click;
            // 
            // btnGestionLibros
            // 
            btnGestionLibros_351FI.Estilo_351FI = EstiloBoton_351FI.Menu;
            btnGestionLibros_351FI.Font = new Font("Segoe UI", 10.5F);
            btnGestionLibros_351FI.Icono_351FI = "\uE82D";
            btnGestionLibros_351FI.Margin = new Padding(12, 2, 0, 2);
            btnGestionLibros_351FI.Name = "btnGestionLibros_351FI";
            btnGestionLibros_351FI.Size = new Size(216, 42);
            btnGestionLibros_351FI.TabIndex = 9;
            btnGestionLibros_351FI.Text = "Gestionar libros";
            btnGestionLibros_351FI.Click += btnGestionLibros_351FI_Click;
            // 
            // btnGestionEjemplares
            // 
            btnGestionEjemplares_351FI.Estilo_351FI = EstiloBoton_351FI.Menu;
            btnGestionEjemplares_351FI.Font = new Font("Segoe UI", 10.5F);
            btnGestionEjemplares_351FI.Icono_351FI = "\uE8A5";
            btnGestionEjemplares_351FI.Margin = new Padding(12, 2, 0, 2);
            btnGestionEjemplares_351FI.Name = "btnGestionEjemplares_351FI";
            btnGestionEjemplares_351FI.Size = new Size(216, 42);
            btnGestionEjemplares_351FI.TabIndex = 10;
            btnGestionEjemplares_351FI.Text = "Gestionar ejemplares";
            btnGestionEjemplares_351FI.Click += btnGestionEjemplares_351FI_Click;
            // 
            // lblSeccionNav
            // 
            lblSeccionNav_351FI.AutoSize = true;
            lblSeccionNav_351FI.BackColor = Color.Transparent;
            lblSeccionNav_351FI.Font = new Font("Segoe UI Semibold", 8.5F);
            lblSeccionNav_351FI.ForeColor = Color.FromArgb(134, 142, 150);
            lblSeccionNav_351FI.Margin = new Padding(24, 18, 0, 6);
            lblSeccionNav_351FI.Name = "lblSeccionNav_351FI";
            lblSeccionNav_351FI.Size = new Size(112, 20);
            lblSeccionNav_351FI.TabIndex = 11;
            lblSeccionNav_351FI.Text = "ADMINISTRACIÓN";
            // 
            // btnUsuarios
            // 
            btnUsuarios_351FI.Estilo_351FI = EstiloBoton_351FI.Menu;
            btnUsuarios_351FI.Font = new Font("Segoe UI", 10.5F);
            btnUsuarios_351FI.Icono_351FI = "\uE77B";
            btnUsuarios_351FI.Margin = new Padding(12, 2, 0, 2);
            btnUsuarios_351FI.Name = "btnUsuarios_351FI";
            btnUsuarios_351FI.Size = new Size(216, 42);
            btnUsuarios_351FI.TabIndex = 12;
            btnUsuarios_351FI.Text = "Gestión de usuarios";
            btnUsuarios_351FI.Click += btnUsuarios_351FI_Click;
            // 
            // btnGestionRoles
            // 
            btnGestionRoles_351FI.Estilo_351FI = EstiloBoton_351FI.Menu;
            btnGestionRoles_351FI.Font = new Font("Segoe UI", 10.5F);
            btnGestionRoles_351FI.Icono_351FI = "\uE8D7";
            btnGestionRoles_351FI.Margin = new Padding(12, 2, 0, 2);
            btnGestionRoles_351FI.Name = "btnGestionRoles_351FI";
            btnGestionRoles_351FI.Size = new Size(216, 42);
            btnGestionRoles_351FI.TabIndex = 13;
            btnGestionRoles_351FI.Text = "Gestión de roles";
            btnGestionRoles_351FI.Click += btnGestionRoles_351FI_Click;
            // 
            // btnBitacora
            // 
            btnBitacora_351FI.Estilo_351FI = EstiloBoton_351FI.Menu;
            btnBitacora_351FI.Font = new Font("Segoe UI", 10.5F);
            btnBitacora_351FI.Icono_351FI = "\uE81C";
            btnBitacora_351FI.Margin = new Padding(12, 2, 0, 2);
            btnBitacora_351FI.Name = "btnBitacora_351FI";
            btnBitacora_351FI.Size = new Size(216, 42);
            btnBitacora_351FI.TabIndex = 14;
            btnBitacora_351FI.Text = "Bitácora";
            btnBitacora_351FI.Click += btnBitacora_351FI_Click;
            // 
            // btnGestionRespaldo
            // 
            btnGestionRespaldo_351FI.Estilo_351FI = EstiloBoton_351FI.Menu;
            btnGestionRespaldo_351FI.Font = new Font("Segoe UI", 10.5F);
            btnGestionRespaldo_351FI.Icono_351FI = "\uE74E";
            btnGestionRespaldo_351FI.Margin = new Padding(12, 2, 0, 2);
            btnGestionRespaldo_351FI.Name = "btnGestionRespaldo_351FI";
            btnGestionRespaldo_351FI.Size = new Size(216, 42);
            btnGestionRespaldo_351FI.TabIndex = 15;
            btnGestionRespaldo_351FI.Text = "Gestión de respaldo";
            btnGestionRespaldo_351FI.Click += btnGestionRespaldo_351FI_Click;
            // 
            // label1
            // 
            label1_351FI.AutoSize = true;
            label1_351FI.BackColor = Color.Transparent;
            label1_351FI.Font = new Font("Segoe UI Semibold", 8.5F);
            label1_351FI.ForeColor = Color.FromArgb(134, 142, 150);
            label1_351FI.Margin = new Padding(24, 18, 0, 6);
            label1_351FI.Name = "label1_351FI";
            label1_351FI.Size = new Size(72, 20);
            label1_351FI.TabIndex = 16;
            label1_351FI.Text = "MI CUENTA";
            // 
            // btnCambiarClave
            // 
            btnCambiarClave_351FI.Estilo_351FI = EstiloBoton_351FI.Menu;
            btnCambiarClave_351FI.Font = new Font("Segoe UI", 10.5F);
            btnCambiarClave_351FI.Icono_351FI = "\uE72E";
            btnCambiarClave_351FI.Margin = new Padding(12, 2, 0, 2);
            btnCambiarClave_351FI.Name = "btnCambiarClave_351FI";
            btnCambiarClave_351FI.Size = new Size(216, 42);
            btnCambiarClave_351FI.TabIndex = 17;
            btnCambiarClave_351FI.Text = "Cambiar clave";
            btnCambiarClave_351FI.Click += btnCambiarClave_351FI_Click;
            // 
            // btnRelogin
            // 
            btnRelogin_351FI.Estilo_351FI = EstiloBoton_351FI.Menu;
            btnRelogin_351FI.Font = new Font("Segoe UI", 10.5F);
            btnRelogin_351FI.Icono_351FI = "\uE748";
            btnRelogin_351FI.Margin = new Padding(12, 2, 0, 2);
            btnRelogin_351FI.Name = "btnRelogin_351FI";
            btnRelogin_351FI.Size = new Size(216, 42);
            btnRelogin_351FI.TabIndex = 18;
            btnRelogin_351FI.Text = "Volver a iniciar sesión";
            btnRelogin_351FI.Click += btnRelogin_351FI_Click;
            // 
            // btnLogout
            // 
            btnLogout_351FI.Estilo_351FI = EstiloBoton_351FI.Menu;
            btnLogout_351FI.Font = new Font("Segoe UI", 10.5F);
            btnLogout_351FI.Icono_351FI = "\uE7E8";
            btnLogout_351FI.Margin = new Padding(12, 2, 0, 2);
            btnLogout_351FI.Name = "btnLogout_351FI";
            btnLogout_351FI.Size = new Size(216, 42);
            btnLogout_351FI.TabIndex = 19;
            btnLogout_351FI.Text = "Cerrar sesión";
            btnLogout_351FI.Click += btnLogout_351FI_Click;
            // 
            // label5
            // 
            label5_351FI.AutoSize = true;
            label5_351FI.BackColor = Color.Transparent;
            label5_351FI.Font = new Font("Segoe UI Semibold", 8.5F);
            label5_351FI.ForeColor = Color.FromArgb(134, 142, 150);
            label5_351FI.Margin = new Padding(24, 18, 0, 6);
            label5_351FI.Name = "label5_351FI";
            label5_351FI.Size = new Size(40, 20);
            label5_351FI.TabIndex = 20;
            label5_351FI.Text = "OTROS";
            // 
            // btnReportes
            // 
            btnReportes_351FI.Estilo_351FI = EstiloBoton_351FI.Menu;
            btnReportes_351FI.Font = new Font("Segoe UI", 10.5F);
            btnReportes_351FI.Icono_351FI = "\uE9D2";
            btnReportes_351FI.Margin = new Padding(12, 2, 0, 2);
            btnReportes_351FI.Name = "btnReportes_351FI";
            btnReportes_351FI.Size = new Size(216, 42);
            btnReportes_351FI.TabIndex = 21;
            btnReportes_351FI.Text = "Reportes";
            // 
            // btnAyuda
            // 
            btnAyuda_351FI.Estilo_351FI = EstiloBoton_351FI.Menu;
            btnAyuda_351FI.Font = new Font("Segoe UI", 10.5F);
            btnAyuda_351FI.Icono_351FI = "\uE897";
            btnAyuda_351FI.Margin = new Padding(12, 2, 0, 2);
            btnAyuda_351FI.Name = "btnAyuda_351FI";
            btnAyuda_351FI.Size = new Size(216, 42);
            btnAyuda_351FI.TabIndex = 22;
            btnAyuda_351FI.Text = "Ayuda";
            // 
            // pnlMarca
            // 
            pnlMarca_351FI.BackColor = Color.FromArgb(33, 37, 41);
            pnlMarca_351FI.Controls.Add(lblLogo_351FI);
            pnlMarca_351FI.Controls.Add(lblTituloTopbar_351FI);
            pnlMarca_351FI.Dock = DockStyle.Top;
            pnlMarca_351FI.Name = "pnlMarca_351FI";
            pnlMarca_351FI.Size = new Size(248, 84);
            pnlMarca_351FI.TabIndex = 1;
            // 
            // lblLogo
            // 
            lblLogo_351FI.AutoSize = false;
            lblLogo_351FI.BackColor = Color.FromArgb(123, 30, 46);
            lblLogo_351FI.Font = new Font("Segoe UI Semibold", 11F);
            lblLogo_351FI.ForeColor = Color.FromArgb(255, 255, 255);
            lblLogo_351FI.Location = new Point(20, 20);
            lblLogo_351FI.Name = "lblLogo_351FI";
            lblLogo_351FI.Size = new Size(44, 44);
            lblLogo_351FI.TabIndex = 0;
            lblLogo_351FI.Text = "SGB";
            lblLogo_351FI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloTopbar
            // 
            lblTituloTopbar_351FI.AutoSize = false;
            lblTituloTopbar_351FI.BackColor = Color.Transparent;
            lblTituloTopbar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            lblTituloTopbar_351FI.ForeColor = Color.FromArgb(255, 255, 255);
            lblTituloTopbar_351FI.Location = new Point(74, 20);
            lblTituloTopbar_351FI.Name = "lblTituloTopbar_351FI";
            lblTituloTopbar_351FI.Size = new Size(160, 44);
            lblTituloTopbar_351FI.TabIndex = 1;
            lblTituloTopbar_351FI.Text = "Sistema de Gestión de Biblioteca";
            lblTituloTopbar_351FI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTopbar
            // 
            pnlTopbar_351FI.BackColor = Color.White;
            pnlTopbar_351FI.Controls.Add(pnlLineaTopbar_351FI);
            pnlTopbar_351FI.Controls.Add(lblPantalla_351FI);
            pnlTopbar_351FI.Controls.Add(lblUsuario_351FI);
            pnlTopbar_351FI.Controls.Add(cboIdioma_351FI);
            pnlTopbar_351FI.Dock = DockStyle.Top;
            pnlTopbar_351FI.Name = "pnlTopbar_351FI";
            pnlTopbar_351FI.Size = new Size(1118, 64);
            pnlTopbar_351FI.TabIndex = 1;
            // 
            // pnlLineaTopbar
            // 
            pnlLineaTopbar_351FI.BackColor = Color.FromArgb(226, 228, 233);
            pnlLineaTopbar_351FI.Dock = DockStyle.Bottom;
            pnlLineaTopbar_351FI.Name = "pnlLineaTopbar_351FI";
            pnlLineaTopbar_351FI.Size = new Size(1118, 1);
            pnlLineaTopbar_351FI.TabIndex = 0;
            // 
            // lblPantalla
            // 
            lblPantalla_351FI.AutoSize = true;
            lblPantalla_351FI.BackColor = Color.Transparent;
            lblPantalla_351FI.Font = new Font("Segoe UI Semibold", 15F);
            lblPantalla_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblPantalla_351FI.Location = new Point(28, 17);
            lblPantalla_351FI.Name = "lblPantalla_351FI";
            lblPantalla_351FI.Size = new Size(48, 20);
            lblPantalla_351FI.TabIndex = 1;
            lblPantalla_351FI.Text = "Inicio";
            // 
            // lblUsuario
            // 
            lblUsuario_351FI.AutoSize = false;
            lblUsuario_351FI.BackColor = Color.Transparent;
            lblUsuario_351FI.Font = new Font("Segoe UI", 10F);
            lblUsuario_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblUsuario_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario_351FI.Location = new Point(574, 18);
            lblUsuario_351FI.Name = "lblUsuario_351FI";
            lblUsuario_351FI.Size = new Size(320, 28);
            lblUsuario_351FI.TabIndex = 2;
            lblUsuario_351FI.Text = "—";
            lblUsuario_351FI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboIdioma
            // 
            cboIdioma_351FI.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdioma_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            cboIdioma_351FI.FormattingEnabled = true;
            cboIdioma_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboIdioma_351FI.Location = new Point(910, 18);
            cboIdioma_351FI.Name = "cboIdioma_351FI";
            cboIdioma_351FI.Size = new Size(180, 28);
            cboIdioma_351FI.TabIndex = 3;
            cboIdioma_351FI.SelectedIndexChanged += cboIdioma_351FI_SelectedIndexChanged;
            // 
            // pnlContenido
            // 
            pnlContenido_351FI.BackColor = Color.FromArgb(244, 245, 247);
            pnlContenido_351FI.Dock = DockStyle.Fill;
            pnlContenido_351FI.Name = "pnlContenido_351FI";
            pnlContenido_351FI.Size = new Size(1118, 664);
            pnlContenido_351FI.TabIndex = 2;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1366, 728);
            Controls.Add(pnlContenido_351FI);
            Controls.Add(pnlTopbar_351FI);
            Controls.Add(pnlSidebar_351FI);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            MinimumSize = new Size(1024, 640);
            Name = "FrmMenu_351FI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmMenu_351FI_FormClosing;
            Load += FrmMenu_351FI_Load;
            pnlContenido_351FI.ResumeLayout(false);
            pnlContenido_351FI.PerformLayout();
            pnlLineaTopbar_351FI.ResumeLayout(false);
            pnlLineaTopbar_351FI.PerformLayout();
            pnlTopbar_351FI.ResumeLayout(false);
            pnlTopbar_351FI.PerformLayout();
            pnlMarca_351FI.ResumeLayout(false);
            pnlMarca_351FI.PerformLayout();
            flwNavegacion_351FI.ResumeLayout(false);
            flwNavegacion_351FI.PerformLayout();
            pnlSidebar_351FI.ResumeLayout(false);
            pnlSidebar_351FI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar_351FI;
        private FlowLayoutPanel flwNavegacion_351FI;
        private BotonSGB_351FI btnInicio_351FI;
        private Label label2_351FI;
        private BotonSGB_351FI btnRegistrarPrestamo_351FI;
        private BotonSGB_351FI btnRegistrarDevolucion_351FI;
        private Label label3_351FI;
        private BotonSGB_351FI btnCobrarMultas_351FI;
        private BotonSGB_351FI btnRegistrarDonacion_351FI;
        private Label label4_351FI;
        private BotonSGB_351FI btnGestionSocios_351FI;
        private BotonSGB_351FI btnGestionLibros_351FI;
        private BotonSGB_351FI btnGestionEjemplares_351FI;
        private Label lblSeccionNav_351FI;
        private BotonSGB_351FI btnUsuarios_351FI;
        private BotonSGB_351FI btnGestionRoles_351FI;
        private BotonSGB_351FI btnBitacora_351FI;
        private BotonSGB_351FI btnGestionRespaldo_351FI;
        private Label label1_351FI;
        private BotonSGB_351FI btnCambiarClave_351FI;
        private BotonSGB_351FI btnRelogin_351FI;
        private BotonSGB_351FI btnLogout_351FI;
        private Label label5_351FI;
        private BotonSGB_351FI btnReportes_351FI;
        private BotonSGB_351FI btnAyuda_351FI;
        private Panel pnlMarca_351FI;
        private Label lblLogo_351FI;
        private Label lblTituloTopbar_351FI;
        private Panel pnlTopbar_351FI;
        private Panel pnlLineaTopbar_351FI;
        private Label lblPantalla_351FI;
        private Label lblUsuario_351FI;
        private ComboBox cboIdioma_351FI;
        private Panel pnlContenido_351FI;
    }
}
