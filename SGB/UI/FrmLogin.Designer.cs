using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FrmLogin
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
            pnlTitulo = new Panel();
            lblLogo = new Label();
            lblSistema = new Label();
            lblTitulo = new Label();
            lblPie = new Label();
            pnlContenido = new Panel();
            cboIdioma = new ComboBox();
            lblBienvenida = new Label();
            lblIndicacion = new Label();
            lblUsuario = new Label();
            txtNombreUsuario = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnEntrar = new BotonSGB();
            pnlTitulo.SuspendLayout();
            pnlContenido.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(123, 30, 46);
            pnlTitulo.Controls.Add(lblLogo);
            pnlTitulo.Controls.Add(lblSistema);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Controls.Add(lblPie);
            pnlTitulo.Dock = DockStyle.Left;
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(380, 520);
            pnlTitulo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = false;
            lblLogo.BackColor = Color.FromArgb(255, 255, 255);
            lblLogo.Font = new Font("Segoe UI Semibold", 14F);
            lblLogo.ForeColor = Color.FromArgb(123, 30, 46);
            lblLogo.Location = new Point(40, 48);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(60, 60);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "SGB";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSistema
            // 
            lblSistema.AutoSize = false;
            lblSistema.BackColor = Color.Transparent;
            lblSistema.Font = new Font("Segoe UI Semibold", 22F);
            lblSistema.ForeColor = Color.FromArgb(255, 255, 255);
            lblSistema.Location = new Point(40, 150);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(300, 110);
            lblSistema.TabIndex = 1;
            lblSistema.Text = "Sistema de Gestión de Biblioteca";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = false;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 12F);
            lblTitulo.ForeColor = Color.FromArgb(242, 222, 226);
            lblTitulo.Location = new Point(40, 268);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 28);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Biblioteca Popular Rivadavia";
            // 
            // lblPie
            // 
            lblPie.AutoSize = false;
            lblPie.BackColor = Color.Transparent;
            lblPie.Font = new Font("Segoe UI", 9F);
            lblPie.ForeColor = Color.FromArgb(226, 190, 197);
            lblPie.Location = new Point(40, 440);
            lblPie.Name = "lblPie";
            lblPie.Size = new Size(300, 44);
            lblPie.TabIndex = 3;
            lblPie.Text = "Universidad Abierta Interamericana\nIngeniería de Software · Trabajo de Diploma";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.White;
            pnlContenido.Controls.Add(cboIdioma);
            pnlContenido.Controls.Add(lblBienvenida);
            pnlContenido.Controls.Add(lblIndicacion);
            pnlContenido.Controls.Add(lblUsuario);
            pnlContenido.Controls.Add(txtNombreUsuario);
            pnlContenido.Controls.Add(lblPassword);
            pnlContenido.Controls.Add(txtPassword);
            pnlContenido.Controls.Add(btnEntrar);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(500, 520);
            pnlContenido.TabIndex = 1;
            // 
            // cboIdioma
            // 
            cboIdioma.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdioma.ForeColor = Color.FromArgb(31, 41, 55);
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboIdioma.Location = new Point(316, 20);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(160, 28);
            cboIdioma.TabIndex = 0;
            cboIdioma.SelectedIndexChanged += cboIdioma_SelectedIndexChanged;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = Color.Transparent;
            lblBienvenida.Font = new Font("Segoe UI Semibold", 20F);
            lblBienvenida.ForeColor = Color.FromArgb(31, 41, 55);
            lblBienvenida.Location = new Point(70, 104);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(112, 20);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Iniciar sesión";
            // 
            // lblIndicacion
            // 
            lblIndicacion.AutoSize = true;
            lblIndicacion.BackColor = Color.Transparent;
            lblIndicacion.Font = new Font("Segoe UI", 10F);
            lblIndicacion.ForeColor = Color.FromArgb(107, 114, 128);
            lblIndicacion.Location = new Point(72, 152);
            lblIndicacion.Name = "lblIndicacion";
            lblIndicacion.Size = new Size(288, 20);
            lblIndicacion.TabIndex = 2;
            lblIndicacion.Text = "Ingresá con tu usuario y contraseña.";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.ForeColor = Color.FromArgb(75, 85, 99);
            lblUsuario.Location = new Point(72, 200);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 20);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario.ForeColor = Color.FromArgb(31, 41, 55);
            txtNombreUsuario.Location = new Point(72, 222);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(356, 27);
            txtNombreUsuario.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.ForeColor = Color.FromArgb(75, 85, 99);
            lblPassword.Location = new Point(72, 270);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 20);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.ForeColor = Color.FromArgb(31, 41, 55);
            txtPassword.Location = new Point(72, 292);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\u25CF';
            txtPassword.Size = new Size(356, 27);
            txtPassword.TabIndex = 6;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnEntrar.Location = new Point(72, 352);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(356, 44);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Entrar";
            btnEntrar.Click += btnEntrar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(880, 520);
            Controls.Add(pnlContenido);
            Controls.Add(pnlTitulo);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblLogo;
        private Label lblSistema;
        private Label lblTitulo;
        private Label lblPie;
        private Panel pnlContenido;
        private ComboBox cboIdioma;
        private Label lblBienvenida;
        private Label lblIndicacion;
        private Label lblUsuario;
        private TextBox txtNombreUsuario;
        private Label lblPassword;
        private TextBox txtPassword;
        private BotonSGB btnEntrar;
    }
}
