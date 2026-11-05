using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FrmRepararInconsistencia_351FI
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
            crdRegistros_351FI = new TarjetaSGB_351FI();
            lblTitulo_351FI = new Label();
            grillaInconsistencias_351FI = new GrillaSGB_351FI();
            crdDetalle_351FI = new TarjetaSGB_351FI();
            lblDetalle_351FI = new Label();
            richTextBox1_351FI = new RichTextBox();
            pnlAcciones_351FI = new FlowLayoutPanel();
            btnRestaurarDV_351FI = new BotonSGB_351FI();
            btnRealizarRespaldo_351FI = new BotonSGB_351FI();
            btnSalir_351FI = new BotonSGB_351FI();
            tlpPrincipal_351FI.SuspendLayout();
            crdRegistros_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaInconsistencias_351FI).BeginInit();
            crdDetalle_351FI.SuspendLayout();
            pnlAcciones_351FI.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal_351FI.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal_351FI.ColumnCount = 2;
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));
            tlpPrincipal_351FI.Controls.Add(crdRegistros_351FI, 0, 0);
            tlpPrincipal_351FI.Controls.Add(crdDetalle_351FI, 1, 0);
            tlpPrincipal_351FI.Controls.Add(pnlAcciones_351FI, 0, 1);
            tlpPrincipal_351FI.Dock = DockStyle.Fill;
            tlpPrincipal_351FI.Name = "tlpPrincipal_351FI";
            tlpPrincipal_351FI.Padding = new Padding(12);
            tlpPrincipal_351FI.RowCount = 2;
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Absolute, 56.0F));
            tlpPrincipal_351FI.Size = new Size(1000, 620);
            tlpPrincipal_351FI.TabIndex = 0;
            tlpPrincipal_351FI.SetColumnSpan(pnlAcciones_351FI, 2);
            // 
            // crdRegistros
            // 
            crdRegistros_351FI.Controls.Add(lblTitulo_351FI);
            crdRegistros_351FI.Controls.Add(grillaInconsistencias_351FI);
            crdRegistros_351FI.Dock = DockStyle.Fill;
            crdRegistros_351FI.Margin = new Padding(8);
            crdRegistros_351FI.Name = "crdRegistros_351FI";
            crdRegistros_351FI.Size = new Size(472, 524);
            crdRegistros_351FI.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo_351FI.AutoSize = true;
            lblTitulo_351FI.BackColor = Color.Transparent;
            lblTitulo_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblTitulo_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitulo_351FI.Location = new Point(20, 16);
            lblTitulo_351FI.Name = "lblTitulo_351FI";
            lblTitulo_351FI.Size = new Size(232, 20);
            lblTitulo_351FI.TabIndex = 0;
            lblTitulo_351FI.Text = "Registros con inconsistencias";
            // 
            // grillaInconsistencias
            // 
            grillaInconsistencias_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grillaInconsistencias_351FI.Location = new Point(20, 52);
            grillaInconsistencias_351FI.Name = "grillaInconsistencias_351FI";
            grillaInconsistencias_351FI.Size = new Size(432, 452);
            grillaInconsistencias_351FI.TabIndex = 1;
            grillaInconsistencias_351FI.SelectionChanged += grillaInconsistencias_351FI_SelectionChanged;
            // 
            // crdDetalle
            // 
            crdDetalle_351FI.Controls.Add(lblDetalle_351FI);
            crdDetalle_351FI.Controls.Add(richTextBox1_351FI);
            crdDetalle_351FI.Dock = DockStyle.Fill;
            crdDetalle_351FI.Margin = new Padding(8);
            crdDetalle_351FI.Name = "crdDetalle_351FI";
            crdDetalle_351FI.Size = new Size(472, 524);
            crdDetalle_351FI.TabIndex = 1;
            // 
            // lblDetalle
            // 
            lblDetalle_351FI.AutoSize = true;
            lblDetalle_351FI.BackColor = Color.Transparent;
            lblDetalle_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblDetalle_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblDetalle_351FI.Location = new Point(20, 16);
            lblDetalle_351FI.Name = "lblDetalle_351FI";
            lblDetalle_351FI.Size = new Size(56, 20);
            lblDetalle_351FI.TabIndex = 0;
            lblDetalle_351FI.Text = "Detalle";
            // 
            // richTextBox1
            // 
            richTextBox1_351FI.BackColor = Color.White;
            richTextBox1_351FI.BorderStyle = BorderStyle.None;
            richTextBox1_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            richTextBox1_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1_351FI.Location = new Point(20, 52);
            richTextBox1_351FI.Name = "richTextBox1_351FI";
            richTextBox1_351FI.ReadOnly = true;
            richTextBox1_351FI.Size = new Size(432, 452);
            richTextBox1_351FI.TabIndex = 1;
            richTextBox1_351FI.Text = "";
            // 
            // pnlAcciones
            // 
            pnlAcciones_351FI.BackColor = Color.Transparent;
            pnlAcciones_351FI.Controls.Add(btnRestaurarDV_351FI);
            pnlAcciones_351FI.Controls.Add(btnRealizarRespaldo_351FI);
            pnlAcciones_351FI.Controls.Add(btnSalir_351FI);
            pnlAcciones_351FI.FlowDirection = FlowDirection.RightToLeft;
            pnlAcciones_351FI.WrapContents = false;
            pnlAcciones_351FI.Dock = DockStyle.Fill;
            pnlAcciones_351FI.Margin = new Padding(8);
            pnlAcciones_351FI.Name = "pnlAcciones_351FI";
            pnlAcciones_351FI.Size = new Size(400, 40);
            pnlAcciones_351FI.TabIndex = 2;
            // 
            // btnRestaurarDV
            // 
            btnRestaurarDV_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnRestaurarDV_351FI.Icono_351FI = "\uE73E";
            btnRestaurarDV_351FI.Margin = new Padding(12, 0, 0, 0);
            btnRestaurarDV_351FI.Name = "btnRestaurarDV_351FI";
            btnRestaurarDV_351FI.Size = new Size(300, 40);
            btnRestaurarDV_351FI.TabIndex = 0;
            btnRestaurarDV_351FI.Text = "Recalcular dígitos verificadores";
            btnRestaurarDV_351FI.Click += btnRestaurarDV_351FI_Click;
            // 
            // btnRealizarRespaldo
            // 
            btnRealizarRespaldo_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnRealizarRespaldo_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnRealizarRespaldo_351FI.Icono_351FI = "\uE777";
            btnRealizarRespaldo_351FI.Margin = new Padding(12, 0, 0, 0);
            btnRealizarRespaldo_351FI.Name = "btnRealizarRespaldo_351FI";
            btnRealizarRespaldo_351FI.Size = new Size(280, 40);
            btnRealizarRespaldo_351FI.TabIndex = 1;
            btnRealizarRespaldo_351FI.Text = "Restaurar copia de seguridad";
            btnRealizarRespaldo_351FI.Click += btnRealizarRespaldo_351FI_Click;
            // 
            // btnSalir
            // 
            btnSalir_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnSalir_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnSalir_351FI.Icono_351FI = "\uE8BB";
            btnSalir_351FI.Margin = new Padding(12, 0, 0, 0);
            btnSalir_351FI.Name = "btnSalir_351FI";
            btnSalir_351FI.Size = new Size(130, 40);
            btnSalir_351FI.TabIndex = 2;
            btnSalir_351FI.Text = "Salir";
            btnSalir_351FI.Click += btnSalir_351FI_Click;
            // 
            // FrmRepararInconsistencia
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1000, 620);
            Controls.Add(tlpPrincipal_351FI);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            MinimumSize = new Size(900, 560);
            Name = "FrmRepararInconsistencia_351FI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reparación de inconsistencias";
            Load += FrmRepararInconsistencia_351FI_Load;
            ((System.ComponentModel.ISupportInitialize)grillaInconsistencias_351FI).EndInit();
            pnlAcciones_351FI.ResumeLayout(false);
            pnlAcciones_351FI.PerformLayout();
            crdDetalle_351FI.ResumeLayout(false);
            crdDetalle_351FI.PerformLayout();
            crdRegistros_351FI.ResumeLayout(false);
            crdRegistros_351FI.PerformLayout();
            tlpPrincipal_351FI.ResumeLayout(false);
            tlpPrincipal_351FI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal_351FI;
        private TarjetaSGB_351FI crdRegistros_351FI;
        private Label lblTitulo_351FI;
        private GrillaSGB_351FI grillaInconsistencias_351FI;
        private TarjetaSGB_351FI crdDetalle_351FI;
        private Label lblDetalle_351FI;
        private RichTextBox richTextBox1_351FI;
        private FlowLayoutPanel pnlAcciones_351FI;
        private BotonSGB_351FI btnRestaurarDV_351FI;
        private BotonSGB_351FI btnRealizarRespaldo_351FI;
        private BotonSGB_351FI btnSalir_351FI;
    }
}
