using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FrmLogin_351FI
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
            pnlTitulo_351FI = new Panel();
            lblLogo_351FI = new Label();
            lblSistema_351FI = new Label();
            lblTitulo_351FI = new Label();
            lblPie_351FI = new Label();
            pnlContenido_351FI = new Panel();
            cboIdioma_351FI = new ComboBox();
            lblBienvenida_351FI = new Label();
            lblIndicacion_351FI = new Label();
            lblUsuario_351FI = new Label();
            txtNombreUsuario_351FI = new TextBox();
            lblPassword_351FI = new Label();
            txtPassword_351FI = new TextBox();
            btnEntrar_351FI = new BotonSGB_351FI();
            pnlTitulo_351FI.SuspendLayout();
            pnlContenido_351FI.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo_351FI.BackColor = Color.FromArgb(123, 30, 46);
            pnlTitulo_351FI.Controls.Add(lblLogo_351FI);
            pnlTitulo_351FI.Controls.Add(lblSistema_351FI);
            pnlTitulo_351FI.Controls.Add(lblTitulo_351FI);
            pnlTitulo_351FI.Controls.Add(lblPie_351FI);
            pnlTitulo_351FI.Dock = DockStyle.Left;
            pnlTitulo_351FI.Name = "pnlTitulo_351FI";
            pnlTitulo_351FI.Size = new Size(380, 520);
            pnlTitulo_351FI.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo_351FI.AutoSize = false;
            lblLogo_351FI.BackColor = Color.FromArgb(255, 255, 255);
            lblLogo_351FI.Font = new Font("Segoe UI Semibold", 14F);
            lblLogo_351FI.ForeColor = Color.FromArgb(123, 30, 46);
            lblLogo_351FI.Location = new Point(40, 48);
            lblLogo_351FI.Name = "lblLogo_351FI";
            lblLogo_351FI.Size = new Size(60, 60);
            lblLogo_351FI.TabIndex = 0;
            lblLogo_351FI.Text = "SGB";
            lblLogo_351FI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSistema
            // 
            lblSistema_351FI.AutoSize = false;
            lblSistema_351FI.BackColor = Color.Transparent;
            lblSistema_351FI.Font = new Font("Segoe UI Semibold", 22F);
            lblSistema_351FI.ForeColor = Color.FromArgb(255, 255, 255);
            lblSistema_351FI.Location = new Point(40, 150);
            lblSistema_351FI.Name = "lblSistema_351FI";
            lblSistema_351FI.Size = new Size(300, 110);
            lblSistema_351FI.TabIndex = 1;
            lblSistema_351FI.Text = "Sistema de Gestión de Biblioteca";
            // 
            // lblTitulo
            // 
            lblTitulo_351FI.AutoSize = false;
            lblTitulo_351FI.BackColor = Color.Transparent;
            lblTitulo_351FI.Font = new Font("Segoe UI", 12F);
            lblTitulo_351FI.ForeColor = Color.FromArgb(242, 222, 226);
            lblTitulo_351FI.Location = new Point(40, 268);
            lblTitulo_351FI.Name = "lblTitulo_351FI";
            lblTitulo_351FI.Size = new Size(300, 28);
            lblTitulo_351FI.TabIndex = 2;
            lblTitulo_351FI.Text = "Biblioteca Popular Rivadavia";
            // 
            // lblPie
            // 
            lblPie_351FI.AutoSize = false;
            lblPie_351FI.BackColor = Color.Transparent;
            lblPie_351FI.Font = new Font("Segoe UI", 9F);
            lblPie_351FI.ForeColor = Color.FromArgb(226, 190, 197);
            lblPie_351FI.Location = new Point(40, 440);
            lblPie_351FI.Name = "lblPie_351FI";
            lblPie_351FI.Size = new Size(300, 44);
            lblPie_351FI.TabIndex = 3;
            lblPie_351FI.Text = "Universidad Abierta Interamericana\nIngeniería de Software · Trabajo de Diploma";
            // 
            // pnlContenido
            // 
            pnlContenido_351FI.BackColor = Color.White;
            pnlContenido_351FI.Controls.Add(cboIdioma_351FI);
            pnlContenido_351FI.Controls.Add(lblBienvenida_351FI);
            pnlContenido_351FI.Controls.Add(lblIndicacion_351FI);
            pnlContenido_351FI.Controls.Add(lblUsuario_351FI);
            pnlContenido_351FI.Controls.Add(txtNombreUsuario_351FI);
            pnlContenido_351FI.Controls.Add(lblPassword_351FI);
            pnlContenido_351FI.Controls.Add(txtPassword_351FI);
            pnlContenido_351FI.Controls.Add(btnEntrar_351FI);
            pnlContenido_351FI.Dock = DockStyle.Fill;
            pnlContenido_351FI.Name = "pnlContenido_351FI";
            pnlContenido_351FI.Size = new Size(500, 520);
            pnlContenido_351FI.TabIndex = 1;
            // 
            // cboIdioma
            // 
            cboIdioma_351FI.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdioma_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            cboIdioma_351FI.FormattingEnabled = true;
            cboIdioma_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboIdioma_351FI.Location = new Point(316, 20);
            cboIdioma_351FI.Name = "cboIdioma_351FI";
            cboIdioma_351FI.Size = new Size(160, 28);
            cboIdioma_351FI.TabIndex = 0;
            cboIdioma_351FI.SelectedIndexChanged += cboIdioma_351FI_SelectedIndexChanged;
            // 
            // lblBienvenida
            // 
            lblBienvenida_351FI.AutoSize = true;
            lblBienvenida_351FI.BackColor = Color.Transparent;
            lblBienvenida_351FI.Font = new Font("Segoe UI Semibold", 20F);
            lblBienvenida_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblBienvenida_351FI.Location = new Point(70, 104);
            lblBienvenida_351FI.Name = "lblBienvenida_351FI";
            lblBienvenida_351FI.Size = new Size(112, 20);
            lblBienvenida_351FI.TabIndex = 1;
            lblBienvenida_351FI.Text = "Iniciar sesión";
            // 
            // lblIndicacion
            // 
            lblIndicacion_351FI.AutoSize = true;
            lblIndicacion_351FI.BackColor = Color.Transparent;
            lblIndicacion_351FI.Font = new Font("Segoe UI", 10F);
            lblIndicacion_351FI.ForeColor = Color.FromArgb(107, 114, 128);
            lblIndicacion_351FI.Location = new Point(72, 152);
            lblIndicacion_351FI.Name = "lblIndicacion_351FI";
            lblIndicacion_351FI.Size = new Size(288, 20);
            lblIndicacion_351FI.TabIndex = 2;
            lblIndicacion_351FI.Text = "Ingresá con tu usuario y contraseña.";
            // 
            // lblUsuario
            // 
            lblUsuario_351FI.AutoSize = true;
            lblUsuario_351FI.BackColor = Color.Transparent;
            lblUsuario_351FI.Font = new Font("Segoe UI", 10F);
            lblUsuario_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblUsuario_351FI.Location = new Point(72, 200);
            lblUsuario_351FI.Name = "lblUsuario_351FI";
            lblUsuario_351FI.Size = new Size(56, 20);
            lblUsuario_351FI.TabIndex = 3;
            lblUsuario_351FI.Text = "Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtNombreUsuario_351FI.Location = new Point(72, 222);
            txtNombreUsuario_351FI.Name = "txtNombreUsuario_351FI";
            txtNombreUsuario_351FI.Size = new Size(356, 27);
            txtNombreUsuario_351FI.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword_351FI.AutoSize = true;
            lblPassword_351FI.BackColor = Color.Transparent;
            lblPassword_351FI.Font = new Font("Segoe UI", 10F);
            lblPassword_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblPassword_351FI.Location = new Point(72, 270);
            lblPassword_351FI.Name = "lblPassword_351FI";
            lblPassword_351FI.Size = new Size(80, 20);
            lblPassword_351FI.TabIndex = 5;
            lblPassword_351FI.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtPassword_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtPassword_351FI.Location = new Point(72, 292);
            txtPassword_351FI.Name = "txtPassword_351FI";
            txtPassword_351FI.PasswordChar = '\u25CF';
            txtPassword_351FI.Size = new Size(356, 27);
            txtPassword_351FI.TabIndex = 6;
            // 
            // btnEntrar
            // 
            btnEntrar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnEntrar_351FI.Location = new Point(72, 352);
            btnEntrar_351FI.Name = "btnEntrar_351FI";
            btnEntrar_351FI.Size = new Size(356, 44);
            btnEntrar_351FI.TabIndex = 7;
            btnEntrar_351FI.Text = "Entrar";
            btnEntrar_351FI.Click += btnEntrar_351FI_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(880, 520);
            Controls.Add(pnlContenido_351FI);
            Controls.Add(pnlTitulo_351FI);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin_351FI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_351FI_Load;
            pnlContenido_351FI.ResumeLayout(false);
            pnlContenido_351FI.PerformLayout();
            pnlTitulo_351FI.ResumeLayout(false);
            pnlTitulo_351FI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo_351FI;
        private Label lblLogo_351FI;
        private Label lblSistema_351FI;
        private Label lblTitulo_351FI;
        private Label lblPie_351FI;
        private Panel pnlContenido_351FI;
        private ComboBox cboIdioma_351FI;
        private Label lblBienvenida_351FI;
        private Label lblIndicacion_351FI;
        private Label lblUsuario_351FI;
        private TextBox txtNombreUsuario_351FI;
        private Label lblPassword_351FI;
        private TextBox txtPassword_351FI;
        private BotonSGB_351FI btnEntrar_351FI;
    }
}
