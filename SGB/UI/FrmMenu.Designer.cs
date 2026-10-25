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
            pnlTopbar = new Panel();
            cboIdioma = new ComboBox();
            lblUsuario = new Label();
            lblTituloTopbar = new Label();
            pnlSidebar = new Panel();
            btnGestionEjemplares = new Button();
            btnGestionLibros = new Button();
            btnGestionSocios = new Button();
            label4 = new Label();
            btnRegistrarDonacion = new Button();
            btnCobrarMultas = new Button();
            label3 = new Label();
            btnRegistrarDevolucion = new Button();
            label2 = new Label();
            btnRegistrarPrestamo = new Button();
            btnGestionRespaldo = new Button();
            btnGestionRoles = new Button();
            btnLogout = new Button();
            btnCambiarClave = new Button();
            btnRelogin = new Button();
            label1 = new Label();
            btnAyuda = new Button();
            btnReportes = new Button();
            btnBitacora = new Button();
            btnUsuarios = new Button();
            lblSeccionNav = new Label();
            pnlContenido = new Panel();
            pnlTopbar.SuspendLayout();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopbar
            // 
            pnlTopbar.BackColor = Color.FromArgb(21, 32, 48);
            pnlTopbar.Controls.Add(cboIdioma);
            pnlTopbar.Controls.Add(lblUsuario);
            pnlTopbar.Controls.Add(lblTituloTopbar);
            pnlTopbar.Dock = DockStyle.Top;
            pnlTopbar.Location = new Point(0, 0);
            pnlTopbar.Name = "pnlTopbar";
            pnlTopbar.Size = new Size(960, 48);
            pnlTopbar.TabIndex = 0;
            // 
            // cboIdioma
            // 
            cboIdioma.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Location = new Point(735, 14);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(213, 25);
            cboIdioma.TabIndex = 2;
            cboIdioma.SelectedIndexChanged += cboIdioma_SelectedIndexChanged;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F);
            lblUsuario.ForeColor = Color.FromArgb(148, 163, 184);
            lblUsuario.Location = new Point(1600, 16);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(53, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "● Admin";
            // 
            // lblTituloTopbar
            // 
            lblTituloTopbar.AutoSize = true;
            lblTituloTopbar.Font = new Font("Segoe UI", 11F);
            lblTituloTopbar.ForeColor = Color.FromArgb(226, 232, 240);
            lblTituloTopbar.Location = new Point(16, 14);
            lblTituloTopbar.Name = "lblTituloTopbar";
            lblTituloTopbar.Size = new Size(136, 20);
            lblTituloTopbar.TabIndex = 0;
            lblTituloTopbar.Text = "Sistema de Gestión";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(25, 37, 53);
            pnlSidebar.Controls.Add(btnGestionEjemplares);
            pnlSidebar.Controls.Add(btnGestionLibros);
            pnlSidebar.Controls.Add(btnGestionSocios);
            pnlSidebar.Controls.Add(label4);
            pnlSidebar.Controls.Add(btnRegistrarDonacion);
            pnlSidebar.Controls.Add(btnCobrarMultas);
            pnlSidebar.Controls.Add(label3);
            pnlSidebar.Controls.Add(btnRegistrarDevolucion);
            pnlSidebar.Controls.Add(label2);
            pnlSidebar.Controls.Add(btnRegistrarPrestamo);
            pnlSidebar.Controls.Add(btnGestionRespaldo);
            pnlSidebar.Controls.Add(btnGestionRoles);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnCambiarClave);
            pnlSidebar.Controls.Add(btnRelogin);
            pnlSidebar.Controls.Add(label1);
            pnlSidebar.Controls.Add(btnAyuda);
            pnlSidebar.Controls.Add(btnReportes);
            pnlSidebar.Controls.Add(btnBitacora);
            pnlSidebar.Controls.Add(btnUsuarios);
            pnlSidebar.Controls.Add(lblSeccionNav);
            pnlSidebar.AutoScroll = true;
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 48);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(211, 632);
            pnlSidebar.TabIndex = 1;
            // 
            // btnRegistrarDevolucion
            // 
            btnRegistrarDevolucion.BackColor = Color.FromArgb(25, 37, 53);
            btnRegistrarDevolucion.Cursor = Cursors.Hand;
            btnRegistrarDevolucion.FlatAppearance.BorderSize = 0;
            btnRegistrarDevolucion.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnRegistrarDevolucion.FlatStyle = FlatStyle.Flat;
            btnRegistrarDevolucion.Font = new Font("Segoe UI", 9.5F);
            btnRegistrarDevolucion.ForeColor = Color.FromArgb(148, 163, 184);
            btnRegistrarDevolucion.Location = new Point(16, 61);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Padding = new Padding(10, 0, 0, 0);
            btnRegistrarDevolucion.Size = new Size(174, 34);
            btnRegistrarDevolucion.TabIndex = 16;
            btnRegistrarDevolucion.Tag = "Gestion bitacora";
            btnRegistrarDevolucion.Text = "Registrar devolución";
            btnRegistrarDevolucion.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarDevolucion.UseVisualStyleBackColor = false;
            btnRegistrarDevolucion.Click += btnRegistrarDevolucion_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(71, 85, 105);
            label2.Location = new Point(12, 8);
            label2.Name = "label2";
            label2.Size = new Size(65, 12);
            label2.TabIndex = 15;
            label2.Text = "PRESTAMOS";
            // 
            // btnRegistrarPrestamo
            // 
            btnRegistrarPrestamo.BackColor = Color.FromArgb(25, 37, 53);
            btnRegistrarPrestamo.Cursor = Cursors.Hand;
            btnRegistrarPrestamo.FlatAppearance.BorderSize = 0;
            btnRegistrarPrestamo.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnRegistrarPrestamo.FlatStyle = FlatStyle.Flat;
            btnRegistrarPrestamo.Font = new Font("Segoe UI", 9.5F);
            btnRegistrarPrestamo.ForeColor = Color.FromArgb(148, 163, 184);
            btnRegistrarPrestamo.Location = new Point(16, 23);
            btnRegistrarPrestamo.Name = "btnRegistrarPrestamo";
            btnRegistrarPrestamo.Padding = new Padding(10, 0, 0, 0);
            btnRegistrarPrestamo.Size = new Size(174, 34);
            btnRegistrarPrestamo.TabIndex = 14;
            btnRegistrarPrestamo.Tag = "Gestion bitacora";
            btnRegistrarPrestamo.Text = "Registrar préstamo";
            btnRegistrarPrestamo.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarPrestamo.UseVisualStyleBackColor = false;
            btnRegistrarPrestamo.Click += btnRegistrarPrestamo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(71, 85, 105);
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(118, 12);
            label3.TabIndex = 17;
            label3.Text = "MULTAS Y DONACIONES";
            // 
            // btnCobrarMultas
            // 
            btnCobrarMultas.BackColor = Color.FromArgb(25, 37, 53);
            btnCobrarMultas.Cursor = Cursors.Hand;
            btnCobrarMultas.FlatAppearance.BorderSize = 0;
            btnCobrarMultas.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnCobrarMultas.FlatStyle = FlatStyle.Flat;
            btnCobrarMultas.Font = new Font("Segoe UI", 9.5F);
            btnCobrarMultas.ForeColor = Color.FromArgb(148, 163, 184);
            btnCobrarMultas.Location = new Point(16, 118);
            btnCobrarMultas.Name = "btnCobrarMultas";
            btnCobrarMultas.Padding = new Padding(10, 0, 0, 0);
            btnCobrarMultas.Size = new Size(174, 34);
            btnCobrarMultas.TabIndex = 18;
            btnCobrarMultas.Text = "Cobrar multas";
            btnCobrarMultas.TextAlign = ContentAlignment.MiddleLeft;
            btnCobrarMultas.UseVisualStyleBackColor = false;
            btnCobrarMultas.Click += btnCobrarMultas_Click;
            // 
            // btnRegistrarDonacion
            // 
            btnRegistrarDonacion.BackColor = Color.FromArgb(25, 37, 53);
            btnRegistrarDonacion.Cursor = Cursors.Hand;
            btnRegistrarDonacion.FlatAppearance.BorderSize = 0;
            btnRegistrarDonacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnRegistrarDonacion.FlatStyle = FlatStyle.Flat;
            btnRegistrarDonacion.Font = new Font("Segoe UI", 9.5F);
            btnRegistrarDonacion.ForeColor = Color.FromArgb(148, 163, 184);
            btnRegistrarDonacion.Location = new Point(16, 156);
            btnRegistrarDonacion.Name = "btnRegistrarDonacion";
            btnRegistrarDonacion.Padding = new Padding(10, 0, 0, 0);
            btnRegistrarDonacion.Size = new Size(174, 34);
            btnRegistrarDonacion.TabIndex = 19;
            btnRegistrarDonacion.Text = "Registrar donación";
            btnRegistrarDonacion.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarDonacion.UseVisualStyleBackColor = false;
            btnRegistrarDonacion.Click += btnRegistrarDonacion_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(71, 85, 105);
            label4.Location = new Point(12, 198);
            label4.Name = "label4";
            label4.Size = new Size(100, 12);
            label4.TabIndex = 20;
            label4.Text = "SOCIOS Y CATÁLOGO";
            // 
            // btnGestionSocios
            // 
            btnGestionSocios.BackColor = Color.FromArgb(25, 37, 53);
            btnGestionSocios.Cursor = Cursors.Hand;
            btnGestionSocios.FlatAppearance.BorderSize = 0;
            btnGestionSocios.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnGestionSocios.FlatStyle = FlatStyle.Flat;
            btnGestionSocios.Font = new Font("Segoe UI", 9.5F);
            btnGestionSocios.ForeColor = Color.FromArgb(148, 163, 184);
            btnGestionSocios.Location = new Point(16, 213);
            btnGestionSocios.Name = "btnGestionSocios";
            btnGestionSocios.Padding = new Padding(10, 0, 0, 0);
            btnGestionSocios.Size = new Size(174, 34);
            btnGestionSocios.TabIndex = 21;
            btnGestionSocios.Text = "Gestionar socios";
            btnGestionSocios.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionSocios.UseVisualStyleBackColor = false;
            btnGestionSocios.Click += btnGestionSocios_Click;
            // 
            // btnGestionLibros
            // 
            btnGestionLibros.BackColor = Color.FromArgb(25, 37, 53);
            btnGestionLibros.Cursor = Cursors.Hand;
            btnGestionLibros.FlatAppearance.BorderSize = 0;
            btnGestionLibros.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnGestionLibros.FlatStyle = FlatStyle.Flat;
            btnGestionLibros.Font = new Font("Segoe UI", 9.5F);
            btnGestionLibros.ForeColor = Color.FromArgb(148, 163, 184);
            btnGestionLibros.Location = new Point(16, 251);
            btnGestionLibros.Name = "btnGestionLibros";
            btnGestionLibros.Padding = new Padding(10, 0, 0, 0);
            btnGestionLibros.Size = new Size(174, 34);
            btnGestionLibros.TabIndex = 22;
            btnGestionLibros.Text = "Gestionar libros";
            btnGestionLibros.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionLibros.UseVisualStyleBackColor = false;
            btnGestionLibros.Click += btnGestionLibros_Click;
            // 
            // btnGestionEjemplares
            // 
            btnGestionEjemplares.BackColor = Color.FromArgb(25, 37, 53);
            btnGestionEjemplares.Cursor = Cursors.Hand;
            btnGestionEjemplares.FlatAppearance.BorderSize = 0;
            btnGestionEjemplares.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnGestionEjemplares.FlatStyle = FlatStyle.Flat;
            btnGestionEjemplares.Font = new Font("Segoe UI", 9.5F);
            btnGestionEjemplares.ForeColor = Color.FromArgb(148, 163, 184);
            btnGestionEjemplares.Location = new Point(16, 289);
            btnGestionEjemplares.Name = "btnGestionEjemplares";
            btnGestionEjemplares.Padding = new Padding(10, 0, 0, 0);
            btnGestionEjemplares.Size = new Size(174, 34);
            btnGestionEjemplares.TabIndex = 23;
            btnGestionEjemplares.Text = "Gestionar ejemplares";
            btnGestionEjemplares.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionEjemplares.UseVisualStyleBackColor = false;
            btnGestionEjemplares.Click += btnGestionEjemplares_Click;
            // 
            // btnGestionRespaldo
            // 
            btnGestionRespaldo.BackColor = Color.FromArgb(25, 37, 53);
            btnGestionRespaldo.Cursor = Cursors.Hand;
            btnGestionRespaldo.FlatAppearance.BorderSize = 0;
            btnGestionRespaldo.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnGestionRespaldo.FlatStyle = FlatStyle.Flat;
            btnGestionRespaldo.Font = new Font("Segoe UI", 9.5F);
            btnGestionRespaldo.ForeColor = Color.FromArgb(148, 163, 184);
            btnGestionRespaldo.Location = new Point(12, 460);
            btnGestionRespaldo.Name = "btnGestionRespaldo";
            btnGestionRespaldo.Padding = new Padding(10, 0, 0, 0);
            btnGestionRespaldo.Size = new Size(174, 34);
            btnGestionRespaldo.TabIndex = 13;
            btnGestionRespaldo.Text = "💾 Gestión respaldo";
            btnGestionRespaldo.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionRespaldo.UseVisualStyleBackColor = false;
            btnGestionRespaldo.Click += btnGestionRespaldo_Click;
            // 
            // btnGestionRoles
            // 
            btnGestionRoles.BackColor = Color.FromArgb(25, 37, 53);
            btnGestionRoles.Cursor = Cursors.Hand;
            btnGestionRoles.FlatAppearance.BorderSize = 0;
            btnGestionRoles.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnGestionRoles.FlatStyle = FlatStyle.Flat;
            btnGestionRoles.Font = new Font("Segoe UI", 9.5F);
            btnGestionRoles.ForeColor = Color.FromArgb(148, 163, 184);
            btnGestionRoles.Location = new Point(12, 422);
            btnGestionRoles.Name = "btnGestionRoles";
            btnGestionRoles.Padding = new Padding(10, 0, 0, 0);
            btnGestionRoles.Size = new Size(174, 34);
            btnGestionRoles.TabIndex = 12;
            btnGestionRoles.Tag = "Gestion roles";
            btnGestionRoles.Text = "👥 Gestión Roles";
            btnGestionRoles.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionRoles.UseVisualStyleBackColor = false;
            btnGestionRoles.Click += btnGestionRoles_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(25, 37, 53);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9.5F);
            btnLogout.ForeColor = Color.FromArgb(148, 163, 184);
            btnLogout.Location = new Point(12, 593);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.Size = new Size(174, 34);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "🎚️ Cerrar sesión";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnCambiarClave
            // 
            btnCambiarClave.BackColor = Color.FromArgb(25, 37, 53);
            btnCambiarClave.Cursor = Cursors.Hand;
            btnCambiarClave.FlatAppearance.BorderSize = 0;
            btnCambiarClave.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnCambiarClave.FlatStyle = FlatStyle.Flat;
            btnCambiarClave.Font = new Font("Segoe UI", 9.5F);
            btnCambiarClave.ForeColor = Color.FromArgb(148, 163, 184);
            btnCambiarClave.Location = new Point(12, 555);
            btnCambiarClave.Name = "btnCambiarClave";
            btnCambiarClave.Padding = new Padding(10, 0, 0, 0);
            btnCambiarClave.Size = new Size(174, 34);
            btnCambiarClave.TabIndex = 10;
            btnCambiarClave.Text = "🔑 Cambiar clave";
            btnCambiarClave.TextAlign = ContentAlignment.MiddleLeft;
            btnCambiarClave.UseVisualStyleBackColor = false;
            btnCambiarClave.Click += btnCambiarClave_Click;
            // 
            // btnRelogin
            // 
            btnRelogin.BackColor = Color.FromArgb(25, 37, 53);
            btnRelogin.Cursor = Cursors.Hand;
            btnRelogin.FlatAppearance.BorderSize = 0;
            btnRelogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnRelogin.FlatStyle = FlatStyle.Flat;
            btnRelogin.Font = new Font("Segoe UI", 9.5F);
            btnRelogin.ForeColor = Color.FromArgb(148, 163, 184);
            btnRelogin.Location = new Point(12, 517);
            btnRelogin.Name = "btnRelogin";
            btnRelogin.Padding = new Padding(10, 0, 0, 0);
            btnRelogin.Size = new Size(174, 34);
            btnRelogin.TabIndex = 9;
            btnRelogin.Text = "🔄 Re-Login";
            btnRelogin.TextAlign = ContentAlignment.MiddleLeft;
            btnRelogin.UseVisualStyleBackColor = false;
            btnRelogin.Click += btnRelogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(71, 85, 105);
            label1.Location = new Point(8, 502);
            label1.Name = "label1";
            label1.Size = new Size(50, 12);
            label1.TabIndex = 8;
            label1.Text = "USUARIO";
            // 
            // btnAyuda
            // 
            btnAyuda.BackColor = Color.FromArgb(25, 37, 53);
            btnAyuda.Cursor = Cursors.Hand;
            btnAyuda.FlatAppearance.BorderSize = 0;
            btnAyuda.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnAyuda.FlatStyle = FlatStyle.Flat;
            btnAyuda.Font = new Font("Segoe UI", 9.5F);
            btnAyuda.ForeColor = Color.FromArgb(148, 163, 184);
            btnAyuda.Location = new Point(16, 673);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Padding = new Padding(10, 0, 0, 0);
            btnAyuda.Size = new Size(174, 34);
            btnAyuda.TabIndex = 6;
            btnAyuda.Text = "❓ Ayuda";
            btnAyuda.TextAlign = ContentAlignment.MiddleLeft;
            btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(25, 37, 53);
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 9.5F);
            btnReportes.ForeColor = Color.FromArgb(148, 163, 184);
            btnReportes.Location = new Point(16, 635);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(10, 0, 0, 0);
            btnReportes.Size = new Size(174, 34);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "📊 Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnBitacora
            // 
            btnBitacora.BackColor = Color.FromArgb(25, 37, 53);
            btnBitacora.Cursor = Cursors.Hand;
            btnBitacora.FlatAppearance.BorderSize = 0;
            btnBitacora.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnBitacora.FlatStyle = FlatStyle.Flat;
            btnBitacora.Font = new Font("Segoe UI", 9.5F);
            btnBitacora.ForeColor = Color.FromArgb(148, 163, 184);
            btnBitacora.Location = new Point(12, 384);
            btnBitacora.Name = "btnBitacora";
            btnBitacora.Padding = new Padding(10, 0, 0, 0);
            btnBitacora.Size = new Size(174, 34);
            btnBitacora.TabIndex = 2;
            btnBitacora.Tag = "Gestion bitacora";
            btnBitacora.Text = "📜 Bitácora";
            btnBitacora.TextAlign = ContentAlignment.MiddleLeft;
            btnBitacora.UseVisualStyleBackColor = false;
            btnBitacora.Click += btnBitacora_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(25, 37, 53);
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 9.5F);
            btnUsuarios.ForeColor = Color.FromArgb(148, 163, 184);
            btnUsuarios.Location = new Point(12, 346);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(10, 0, 0, 0);
            btnUsuarios.Size = new Size(174, 34);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Tag = "Gestion usuario";
            btnUsuarios.Text = "\U0001f9d1‍💻 Gestión Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // lblSeccionNav
            // 
            lblSeccionNav.AutoSize = true;
            lblSeccionNav.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionNav.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionNav.Location = new Point(8, 331);
            lblSeccionNav.Name = "lblSeccionNav";
            lblSeccionNav.Size = new Size(40, 12);
            lblSeccionNav.TabIndex = 0;
            lblSeccionNav.Text = "ADMIN";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.FromArgb(30, 42, 58);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(211, 48);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Padding = new Padding(24);
            pnlContenido.Size = new Size(749, 632);
            pnlContenido.TabIndex = 2;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 42, 58);
            ClientSize = new Size(960, 680);
            Controls.Add(pnlContenido);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlTopbar);
            Font = new Font("Segoe UI", 9.5F);
            MinimumSize = new Size(800, 500);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión";
            FormClosing += FrmMenu_FormClosing;
            Load += FrmMenu_Load;
            pnlTopbar.ResumeLayout(false);
            pnlTopbar.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopbar;
        private System.Windows.Forms.Label lblTituloTopbar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSeccionNav;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnBitacora;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Panel pnlContenido;
        private Button btnLogout;
        private Button btnCambiarClave;
        private Button btnRelogin;
        private Label label1;
        private Button btnGestionRoles;
        private ComboBox cboIdioma;
        private Button btnGestionRespaldo;
        private Button btnRegistrarPrestamo;
        private Button btnRegistrarDevolucion;
        private Label label2;
        private Label label3;
        private Button btnCobrarMultas;
        private Button btnRegistrarDonacion;
        private Label label4;
        private Button btnGestionSocios;
        private Button btnGestionLibros;
        private Button btnGestionEjemplares;
    }
}