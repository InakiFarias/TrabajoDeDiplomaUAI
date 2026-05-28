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
            lblUsuario = new Label();
            lblTituloTopbar = new Label();
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnCambiarClave = new Button();
            button2 = new Button();
            label1 = new Label();
            btnAyuda = new Button();
            btnClientes = new Button();
            btnInventario = new Button();
            btnReportes = new Button();
            btnVentas = new Button();
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
            pnlTopbar.Controls.Add(lblUsuario);
            pnlTopbar.Controls.Add(lblTituloTopbar);
            pnlTopbar.Dock = DockStyle.Top;
            pnlTopbar.Location = new Point(0, 0);
            pnlTopbar.Name = "pnlTopbar";
            pnlTopbar.Size = new Size(960, 48);
            pnlTopbar.TabIndex = 0;
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
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnCambiarClave);
            pnlSidebar.Controls.Add(button2);
            pnlSidebar.Controls.Add(label1);
            pnlSidebar.Controls.Add(btnAyuda);
            pnlSidebar.Controls.Add(btnClientes);
            pnlSidebar.Controls.Add(btnInventario);
            pnlSidebar.Controls.Add(btnReportes);
            pnlSidebar.Controls.Add(btnVentas);
            pnlSidebar.Controls.Add(btnUsuarios);
            pnlSidebar.Controls.Add(lblSeccionNav);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 48);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(190, 572);
            pnlSidebar.TabIndex = 1;
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
            btnLogout.Location = new Point(10, 224);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.Size = new Size(174, 38);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "⇠  Cerrar sesión";
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
            btnCambiarClave.Location = new Point(4, 180);
            btnCambiarClave.Name = "btnCambiarClave";
            btnCambiarClave.Padding = new Padding(10, 0, 0, 0);
            btnCambiarClave.Size = new Size(174, 38);
            btnCambiarClave.TabIndex = 10;
            btnCambiarClave.Text = "📝  Cambiar clave";
            btnCambiarClave.TextAlign = ContentAlignment.MiddleLeft;
            btnCambiarClave.UseVisualStyleBackColor = false;
            btnCambiarClave.Click += btnCambiarClave_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(25, 37, 53);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.5F);
            button2.ForeColor = Color.FromArgb(148, 163, 184);
            button2.Location = new Point(10, 136);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(174, 38);
            button2.TabIndex = 9;
            button2.Text = "👤  Re-Login";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(71, 85, 105);
            label1.Location = new Point(12, 121);
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
            btnAyuda.Location = new Point(10, 456);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Padding = new Padding(10, 0, 0, 0);
            btnAyuda.Size = new Size(174, 38);
            btnAyuda.TabIndex = 6;
            btnAyuda.Text = "❓  Ayuda";
            btnAyuda.TextAlign = ContentAlignment.MiddleLeft;
            btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(25, 37, 53);
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 9.5F);
            btnClientes.ForeColor = Color.FromArgb(148, 163, 184);
            btnClientes.Location = new Point(10, 414);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(10, 0, 0, 0);
            btnClientes.Size = new Size(174, 38);
            btnClientes.TabIndex = 5;
            btnClientes.Text = "🙍  Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.FromArgb(25, 37, 53);
            btnInventario.Cursor = Cursors.Hand;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Segoe UI", 9.5F);
            btnInventario.ForeColor = Color.FromArgb(148, 163, 184);
            btnInventario.Location = new Point(10, 372);
            btnInventario.Name = "btnInventario";
            btnInventario.Padding = new Padding(10, 0, 0, 0);
            btnInventario.Size = new Size(174, 38);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "📦  Inventario";
            btnInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnInventario.UseVisualStyleBackColor = false;
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
            btnReportes.Location = new Point(10, 330);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(10, 0, 0, 0);
            btnReportes.Size = new Size(174, 38);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "📊  Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(25, 37, 53);
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 60, 82);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 9.5F);
            btnVentas.ForeColor = Color.FromArgb(148, 163, 184);
            btnVentas.Location = new Point(4, 72);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(10, 0, 0, 0);
            btnVentas.Size = new Size(174, 38);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "📝  Bitácora";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.UseVisualStyleBackColor = false;
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
            btnUsuarios.Location = new Point(4, 30);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(10, 0, 0, 0);
            btnUsuarios.Size = new Size(174, 38);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "👤  Gestión Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // lblSeccionNav
            // 
            lblSeccionNav.AutoSize = true;
            lblSeccionNav.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionNav.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionNav.Location = new Point(12, 8);
            lblSeccionNav.Name = "lblSeccionNav";
            lblSeccionNav.Size = new Size(40, 12);
            lblSeccionNav.TabIndex = 0;
            lblSeccionNav.Text = "ADMIN";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.FromArgb(30, 42, 58);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(190, 48);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Padding = new Padding(24);
            pnlContenido.Size = new Size(770, 572);
            pnlContenido.TabIndex = 2;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 42, 58);
            ClientSize = new Size(960, 620);
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
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Panel pnlContenido;
        private Button btnLogout;
        private Button btnCambiarClave;
        private Button button2;
        private Label label1;
    }
}