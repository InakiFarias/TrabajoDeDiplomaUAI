using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FrmBackup
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
            crdRespaldo = new TarjetaSGB();
            lblTituloBackup = new Label();
            lblAyudaBackup = new Label();
            btnBackup = new BotonSGB();
            btnRestore = new BotonSGB();
            btnSalir = new BotonSGB();
            tlpPrincipal.SuspendLayout();
            crdRespaldo.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal.ColumnCount = 2;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 580.0F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0F));
            tlpPrincipal.Controls.Add(crdRespaldo, 0, 0);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(12);
            tlpPrincipal.RowCount = 2;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 330.0F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            tlpPrincipal.Size = new Size(1100, 640);
            tlpPrincipal.TabIndex = 0;
            // 
            // crdRespaldo
            // 
            crdRespaldo.Controls.Add(lblTituloBackup);
            crdRespaldo.Controls.Add(lblAyudaBackup);
            crdRespaldo.Controls.Add(btnBackup);
            crdRespaldo.Controls.Add(btnRestore);
            crdRespaldo.Controls.Add(btnSalir);
            crdRespaldo.Dock = DockStyle.Fill;
            crdRespaldo.Margin = new Padding(8);
            crdRespaldo.Name = "crdRespaldo";
            crdRespaldo.Size = new Size(564, 314);
            crdRespaldo.TabIndex = 0;
            // 
            // lblTituloBackup
            // 
            lblTituloBackup.AutoSize = true;
            lblTituloBackup.BackColor = Color.Transparent;
            lblTituloBackup.Font = new Font("Segoe UI Semibold", 12F);
            lblTituloBackup.ForeColor = Color.FromArgb(31, 41, 55);
            lblTituloBackup.Location = new Point(20, 16);
            lblTituloBackup.Name = "lblTituloBackup";
            lblTituloBackup.Size = new Size(152, 20);
            lblTituloBackup.TabIndex = 0;
            lblTituloBackup.Text = "Copias de seguridad";
            // 
            // lblAyudaBackup
            // 
            lblAyudaBackup.AutoSize = false;
            lblAyudaBackup.BackColor = Color.Transparent;
            lblAyudaBackup.Font = new Font("Segoe UI", 9.5F);
            lblAyudaBackup.ForeColor = Color.FromArgb(107, 114, 128);
            lblAyudaBackup.Location = new Point(20, 50);
            lblAyudaBackup.Name = "lblAyudaBackup";
            lblAyudaBackup.Size = new Size(524, 44);
            lblAyudaBackup.TabIndex = 1;
            lblAyudaBackup.Text = "Generá una copia de la base de datos o restaurá una copia anterior. Al restaurar se cierra la sesión.";
            // 
            // btnBackup
            // 
            btnBackup.Font = new Font("Segoe UI Semibold", 10.5F);
            btnBackup.Icono = "\uE74E";
            btnBackup.Location = new Point(20, 112);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(524, 40);
            btnBackup.TabIndex = 2;
            btnBackup.Text = "Generar copia de seguridad";
            btnBackup.Click += btnBackup_Click;
            // 
            // btnRestore
            // 
            btnRestore.Estilo = EstiloBoton.Secundario;
            btnRestore.Font = new Font("Segoe UI Semibold", 10.5F);
            btnRestore.Icono = "\uE777";
            btnRestore.Location = new Point(20, 162);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(524, 40);
            btnRestore.TabIndex = 3;
            btnRestore.Text = "Restaurar copia de seguridad";
            btnRestore.Click += btnRestore_Click;
            // 
            // btnSalir
            // 
            btnSalir.Estilo = EstiloBoton.Secundario;
            btnSalir.Font = new Font("Segoe UI Semibold", 10.5F);
            btnSalir.Icono = "\uE8BB";
            btnSalir.Location = new Point(20, 238);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 40);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmBackup
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBackup";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de respaldo";
            Load += FrmBackup_Load;
            crdRespaldo.ResumeLayout(false);
            crdRespaldo.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TarjetaSGB crdRespaldo;
        private Label lblTituloBackup;
        private Label lblAyudaBackup;
        private BotonSGB btnBackup;
        private BotonSGB btnRestore;
        private BotonSGB btnSalir;
    }
}
