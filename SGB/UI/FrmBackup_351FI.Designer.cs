using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FrmBackup_351FI
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
            crdRespaldo_351FI = new TarjetaSGB_351FI();
            lblTituloBackup_351FI = new Label();
            lblAyudaBackup_351FI = new Label();
            btnBackup_351FI = new BotonSGB_351FI();
            btnRestore_351FI = new BotonSGB_351FI();
            btnSalir_351FI = new BotonSGB_351FI();
            tlpPrincipal_351FI.SuspendLayout();
            crdRespaldo_351FI.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal_351FI.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal_351FI.ColumnCount = 2;
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 580.0F));
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0F));
            tlpPrincipal_351FI.Controls.Add(crdRespaldo_351FI, 0, 0);
            tlpPrincipal_351FI.Dock = DockStyle.Fill;
            tlpPrincipal_351FI.Name = "tlpPrincipal_351FI";
            tlpPrincipal_351FI.Padding = new Padding(12);
            tlpPrincipal_351FI.RowCount = 2;
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Absolute, 330.0F));
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            tlpPrincipal_351FI.Size = new Size(1100, 640);
            tlpPrincipal_351FI.TabIndex = 0;
            // 
            // crdRespaldo
            // 
            crdRespaldo_351FI.Controls.Add(lblTituloBackup_351FI);
            crdRespaldo_351FI.Controls.Add(lblAyudaBackup_351FI);
            crdRespaldo_351FI.Controls.Add(btnBackup_351FI);
            crdRespaldo_351FI.Controls.Add(btnRestore_351FI);
            crdRespaldo_351FI.Controls.Add(btnSalir_351FI);
            crdRespaldo_351FI.Dock = DockStyle.Fill;
            crdRespaldo_351FI.Margin = new Padding(8);
            crdRespaldo_351FI.Name = "crdRespaldo_351FI";
            crdRespaldo_351FI.Size = new Size(564, 314);
            crdRespaldo_351FI.TabIndex = 0;
            // 
            // lblTituloBackup
            // 
            lblTituloBackup_351FI.AutoSize = true;
            lblTituloBackup_351FI.BackColor = Color.Transparent;
            lblTituloBackup_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblTituloBackup_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblTituloBackup_351FI.Location = new Point(20, 16);
            lblTituloBackup_351FI.Name = "lblTituloBackup_351FI";
            lblTituloBackup_351FI.Size = new Size(152, 20);
            lblTituloBackup_351FI.TabIndex = 0;
            lblTituloBackup_351FI.Text = "Copias de seguridad";
            // 
            // lblAyudaBackup
            // 
            lblAyudaBackup_351FI.AutoSize = false;
            lblAyudaBackup_351FI.BackColor = Color.Transparent;
            lblAyudaBackup_351FI.Font = new Font("Segoe UI", 9.5F);
            lblAyudaBackup_351FI.ForeColor = Color.FromArgb(107, 114, 128);
            lblAyudaBackup_351FI.Location = new Point(20, 50);
            lblAyudaBackup_351FI.Name = "lblAyudaBackup_351FI";
            lblAyudaBackup_351FI.Size = new Size(524, 44);
            lblAyudaBackup_351FI.TabIndex = 1;
            lblAyudaBackup_351FI.Text = "Generá una copia de la base de datos o restaurá una copia anterior. Al restaurar se cierra la sesión.";
            // 
            // btnBackup
            // 
            btnBackup_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnBackup_351FI.Icono_351FI = "\uE74E";
            btnBackup_351FI.Location = new Point(20, 112);
            btnBackup_351FI.Name = "btnBackup_351FI";
            btnBackup_351FI.Size = new Size(524, 40);
            btnBackup_351FI.TabIndex = 2;
            btnBackup_351FI.Text = "Generar copia de seguridad";
            btnBackup_351FI.Click += btnBackup_351FI_Click;
            // 
            // btnRestore
            // 
            btnRestore_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnRestore_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnRestore_351FI.Icono_351FI = "\uE777";
            btnRestore_351FI.Location = new Point(20, 162);
            btnRestore_351FI.Name = "btnRestore_351FI";
            btnRestore_351FI.Size = new Size(524, 40);
            btnRestore_351FI.TabIndex = 3;
            btnRestore_351FI.Text = "Restaurar copia de seguridad";
            btnRestore_351FI.Click += btnRestore_351FI_Click;
            // 
            // btnSalir
            // 
            btnSalir_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnSalir_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnSalir_351FI.Icono_351FI = "\uE8BB";
            btnSalir_351FI.Location = new Point(20, 238);
            btnSalir_351FI.Name = "btnSalir_351FI";
            btnSalir_351FI.Size = new Size(140, 40);
            btnSalir_351FI.TabIndex = 4;
            btnSalir_351FI.Text = "Salir";
            btnSalir_351FI.Click += btnSalir_351FI_Click;
            // 
            // FrmBackup
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal_351FI);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBackup_351FI";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de respaldo";
            Load += FrmBackup_351FI_Load;
            crdRespaldo_351FI.ResumeLayout(false);
            crdRespaldo_351FI.PerformLayout();
            tlpPrincipal_351FI.ResumeLayout(false);
            tlpPrincipal_351FI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal_351FI;
        private TarjetaSGB_351FI crdRespaldo_351FI;
        private Label lblTituloBackup_351FI;
        private Label lblAyudaBackup_351FI;
        private BotonSGB_351FI btnBackup_351FI;
        private BotonSGB_351FI btnRestore_351FI;
        private BotonSGB_351FI btnSalir_351FI;
    }
}
