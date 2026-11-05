using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class frmCambiarClave_351FI
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
            tlpPrincipal_351FI = new TableLayoutPanel();
            crdClave_351FI = new TarjetaSGB_351FI();
            lblTitulo_351FI = new Label();
            lblClaveActual_351FI = new Label();
            txtClaveActual_351FI = new TextBox();
            lblClaveNueva_351FI = new Label();
            txtClaveNueva_351FI = new TextBox();
            lblRequisitos_351FI = new Label();
            lblAviso_351FI = new Label();
            btnConfirmar_351FI = new BotonSGB_351FI();
            tlpPrincipal_351FI.SuspendLayout();
            crdClave_351FI.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal_351FI.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal_351FI.ColumnCount = 2;
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 540.0F));
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0F));
            tlpPrincipal_351FI.Controls.Add(crdClave_351FI, 0, 0);
            tlpPrincipal_351FI.Dock = DockStyle.Fill;
            tlpPrincipal_351FI.Name = "tlpPrincipal_351FI";
            tlpPrincipal_351FI.Padding = new Padding(12);
            tlpPrincipal_351FI.RowCount = 2;
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Absolute, 380.0F));
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            tlpPrincipal_351FI.Size = new Size(1100, 640);
            tlpPrincipal_351FI.TabIndex = 0;
            // 
            // crdClave
            // 
            crdClave_351FI.Controls.Add(lblTitulo_351FI);
            crdClave_351FI.Controls.Add(lblClaveActual_351FI);
            crdClave_351FI.Controls.Add(txtClaveActual_351FI);
            crdClave_351FI.Controls.Add(lblClaveNueva_351FI);
            crdClave_351FI.Controls.Add(txtClaveNueva_351FI);
            crdClave_351FI.Controls.Add(lblRequisitos_351FI);
            crdClave_351FI.Controls.Add(lblAviso_351FI);
            crdClave_351FI.Controls.Add(btnConfirmar_351FI);
            crdClave_351FI.Dock = DockStyle.Fill;
            crdClave_351FI.Margin = new Padding(8);
            crdClave_351FI.Name = "crdClave_351FI";
            crdClave_351FI.Size = new Size(524, 364);
            crdClave_351FI.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo_351FI.AutoSize = true;
            lblTitulo_351FI.BackColor = Color.Transparent;
            lblTitulo_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblTitulo_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitulo_351FI.Location = new Point(20, 16);
            lblTitulo_351FI.Name = "lblTitulo_351FI";
            lblTitulo_351FI.Size = new Size(104, 20);
            lblTitulo_351FI.TabIndex = 0;
            lblTitulo_351FI.Text = "Cambiar clave";
            // 
            // lblClaveActual
            // 
            lblClaveActual_351FI.AutoSize = true;
            lblClaveActual_351FI.BackColor = Color.Transparent;
            lblClaveActual_351FI.Font = new Font("Segoe UI", 10F);
            lblClaveActual_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblClaveActual_351FI.Location = new Point(20, 56);
            lblClaveActual_351FI.Name = "lblClaveActual_351FI";
            lblClaveActual_351FI.Size = new Size(96, 20);
            lblClaveActual_351FI.TabIndex = 1;
            lblClaveActual_351FI.Text = "Clave actual";
            // 
            // txtClaveActual
            // 
            txtClaveActual_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtClaveActual_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtClaveActual_351FI.Location = new Point(20, 78);
            txtClaveActual_351FI.Name = "txtClaveActual_351FI";
            txtClaveActual_351FI.PasswordChar = '\u25CF';
            txtClaveActual_351FI.Size = new Size(484, 27);
            txtClaveActual_351FI.TabIndex = 2;
            // 
            // lblClaveNueva
            // 
            lblClaveNueva_351FI.AutoSize = true;
            lblClaveNueva_351FI.BackColor = Color.Transparent;
            lblClaveNueva_351FI.Font = new Font("Segoe UI", 10F);
            lblClaveNueva_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblClaveNueva_351FI.Location = new Point(20, 122);
            lblClaveNueva_351FI.Name = "lblClaveNueva_351FI";
            lblClaveNueva_351FI.Size = new Size(88, 20);
            lblClaveNueva_351FI.TabIndex = 3;
            lblClaveNueva_351FI.Text = "Clave nueva";
            // 
            // txtClaveNueva
            // 
            txtClaveNueva_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtClaveNueva_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtClaveNueva_351FI.Location = new Point(20, 144);
            txtClaveNueva_351FI.Name = "txtClaveNueva_351FI";
            txtClaveNueva_351FI.PasswordChar = '\u25CF';
            txtClaveNueva_351FI.Size = new Size(484, 27);
            txtClaveNueva_351FI.TabIndex = 4;
            // 
            // lblRequisitos
            // 
            lblRequisitos_351FI.AutoSize = false;
            lblRequisitos_351FI.BackColor = Color.Transparent;
            lblRequisitos_351FI.Font = new Font("Segoe UI", 9.5F);
            lblRequisitos_351FI.ForeColor = Color.FromArgb(107, 114, 128);
            lblRequisitos_351FI.Location = new Point(20, 184);
            lblRequisitos_351FI.Name = "lblRequisitos_351FI";
            lblRequisitos_351FI.Size = new Size(484, 44);
            lblRequisitos_351FI.TabIndex = 5;
            lblRequisitos_351FI.Text = "La clave nueva debe tener al menos 8 caracteres, una mayúscula, una minúscula, un número y un carácter especial.";
            // 
            // lblAviso
            // 
            lblAviso_351FI.AutoSize = false;
            lblAviso_351FI.BackColor = Color.Transparent;
            lblAviso_351FI.Font = new Font("Segoe UI", 9.5F);
            lblAviso_351FI.ForeColor = Color.FromArgb(107, 114, 128);
            lblAviso_351FI.Location = new Point(20, 232);
            lblAviso_351FI.Name = "lblAviso_351FI";
            lblAviso_351FI.Size = new Size(484, 24);
            lblAviso_351FI.TabIndex = 6;
            lblAviso_351FI.Text = "Al confirmar se cierra la sesión y tenés que volver a ingresar.";
            // 
            // btnConfirmar
            // 
            btnConfirmar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnConfirmar_351FI.Icono_351FI = "\uE73E";
            btnConfirmar_351FI.Location = new Point(20, 292);
            btnConfirmar_351FI.Name = "btnConfirmar_351FI";
            btnConfirmar_351FI.Size = new Size(484, 40);
            btnConfirmar_351FI.TabIndex = 7;
            btnConfirmar_351FI.Text = "Confirmar";
            btnConfirmar_351FI.Click += btnConfirmar_351FI_Click;
            // 
            // frmCambiarClave
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal_351FI);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCambiarClave_351FI";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambiar clave";
            Load += frmCambiarClave_351FI_Load;
            crdClave_351FI.ResumeLayout(false);
            crdClave_351FI.PerformLayout();
            tlpPrincipal_351FI.ResumeLayout(false);
            tlpPrincipal_351FI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal_351FI;
        private TarjetaSGB_351FI crdClave_351FI;
        private Label lblTitulo_351FI;
        private Label lblClaveActual_351FI;
        private TextBox txtClaveActual_351FI;
        private Label lblClaveNueva_351FI;
        private TextBox txtClaveNueva_351FI;
        private Label lblRequisitos_351FI;
        private Label lblAviso_351FI;
        private BotonSGB_351FI btnConfirmar_351FI;
    }
}
