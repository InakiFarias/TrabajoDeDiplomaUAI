using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class frmCambiarClave
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
            tlpPrincipal = new TableLayoutPanel();
            crdClave = new TarjetaSGB();
            lblTitulo = new Label();
            lblClaveActual = new Label();
            txtClaveActual = new TextBox();
            lblClaveNueva = new Label();
            txtClaveNueva = new TextBox();
            lblRequisitos = new Label();
            lblAviso = new Label();
            btnConfirmar = new BotonSGB();
            tlpPrincipal.SuspendLayout();
            crdClave.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal.ColumnCount = 2;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 540.0F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0F));
            tlpPrincipal.Controls.Add(crdClave, 0, 0);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(12);
            tlpPrincipal.RowCount = 2;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 380.0F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            tlpPrincipal.Size = new Size(1100, 640);
            tlpPrincipal.TabIndex = 0;
            // 
            // crdClave
            // 
            crdClave.Controls.Add(lblTitulo);
            crdClave.Controls.Add(lblClaveActual);
            crdClave.Controls.Add(txtClaveActual);
            crdClave.Controls.Add(lblClaveNueva);
            crdClave.Controls.Add(txtClaveNueva);
            crdClave.Controls.Add(lblRequisitos);
            crdClave.Controls.Add(lblAviso);
            crdClave.Controls.Add(btnConfirmar);
            crdClave.Dock = DockStyle.Fill;
            crdClave.Margin = new Padding(8);
            crdClave.Name = "crdClave";
            crdClave.Size = new Size(524, 364);
            crdClave.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI Semibold", 12F);
            lblTitulo.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitulo.Location = new Point(20, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(104, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cambiar clave";
            // 
            // lblClaveActual
            // 
            lblClaveActual.AutoSize = true;
            lblClaveActual.BackColor = Color.Transparent;
            lblClaveActual.Font = new Font("Segoe UI", 10F);
            lblClaveActual.ForeColor = Color.FromArgb(75, 85, 99);
            lblClaveActual.Location = new Point(20, 56);
            lblClaveActual.Name = "lblClaveActual";
            lblClaveActual.Size = new Size(96, 20);
            lblClaveActual.TabIndex = 1;
            lblClaveActual.Text = "Clave actual";
            // 
            // txtClaveActual
            // 
            txtClaveActual.BorderStyle = BorderStyle.FixedSingle;
            txtClaveActual.ForeColor = Color.FromArgb(31, 41, 55);
            txtClaveActual.Location = new Point(20, 78);
            txtClaveActual.Name = "txtClaveActual";
            txtClaveActual.PasswordChar = '\u25CF';
            txtClaveActual.Size = new Size(484, 27);
            txtClaveActual.TabIndex = 2;
            // 
            // lblClaveNueva
            // 
            lblClaveNueva.AutoSize = true;
            lblClaveNueva.BackColor = Color.Transparent;
            lblClaveNueva.Font = new Font("Segoe UI", 10F);
            lblClaveNueva.ForeColor = Color.FromArgb(75, 85, 99);
            lblClaveNueva.Location = new Point(20, 122);
            lblClaveNueva.Name = "lblClaveNueva";
            lblClaveNueva.Size = new Size(88, 20);
            lblClaveNueva.TabIndex = 3;
            lblClaveNueva.Text = "Clave nueva";
            // 
            // txtClaveNueva
            // 
            txtClaveNueva.BorderStyle = BorderStyle.FixedSingle;
            txtClaveNueva.ForeColor = Color.FromArgb(31, 41, 55);
            txtClaveNueva.Location = new Point(20, 144);
            txtClaveNueva.Name = "txtClaveNueva";
            txtClaveNueva.PasswordChar = '\u25CF';
            txtClaveNueva.Size = new Size(484, 27);
            txtClaveNueva.TabIndex = 4;
            // 
            // lblRequisitos
            // 
            lblRequisitos.AutoSize = false;
            lblRequisitos.BackColor = Color.Transparent;
            lblRequisitos.Font = new Font("Segoe UI", 9.5F);
            lblRequisitos.ForeColor = Color.FromArgb(107, 114, 128);
            lblRequisitos.Location = new Point(20, 184);
            lblRequisitos.Name = "lblRequisitos";
            lblRequisitos.Size = new Size(484, 44);
            lblRequisitos.TabIndex = 5;
            lblRequisitos.Text = "La clave nueva debe tener al menos 8 caracteres, una mayúscula, una minúscula, un número y un carácter especial.";
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = false;
            lblAviso.BackColor = Color.Transparent;
            lblAviso.Font = new Font("Segoe UI", 9.5F);
            lblAviso.ForeColor = Color.FromArgb(107, 114, 128);
            lblAviso.Location = new Point(20, 232);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(484, 24);
            lblAviso.TabIndex = 6;
            lblAviso.Text = "Al confirmar se cierra la sesión y tenés que volver a ingresar.";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnConfirmar.Icono = "\uE73E";
            btnConfirmar.Location = new Point(20, 292);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(484, 40);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // frmCambiarClave
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCambiarClave";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambiar clave";
            Load += frmCambiarClave_Load;
            crdClave.ResumeLayout(false);
            crdClave.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TarjetaSGB crdClave;
        private Label lblTitulo;
        private Label lblClaveActual;
        private TextBox txtClaveActual;
        private Label lblClaveNueva;
        private TextBox txtClaveNueva;
        private Label lblRequisitos;
        private Label lblAviso;
        private BotonSGB btnConfirmar;
    }
}
