using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormReporte_351FI
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
            crdFiltros_351FI = new TarjetaSGB_351FI();
            lblSeccionFiltros_351FI = new Label();
            lblFechaDesde_351FI = new Label();
            dtpFechaDesde_351FI = new DateTimePicker();
            lblFechaHasta_351FI = new Label();
            dtpFechaHasta_351FI = new DateTimePicker();
            btnReportePrestamos_351FI = new BotonSGB_351FI();
            btnReporteMultas_351FI = new BotonSGB_351FI();
            crdVista_351FI = new TarjetaSGB_351FI();
            lblSeccionVista_351FI = new Label();
            tlpVista_351FI = new TableLayoutPanel();
            lblTitulo1_351FI = new Label();
            lblResumen1_351FI = new Label();
            dgvTabla1_351FI = new GrillaSGB_351FI();
            lblTitulo2_351FI = new Label();
            lblResumen2_351FI = new Label();
            dgvTabla2_351FI = new GrillaSGB_351FI();
            pnlAcciones_351FI = new FlowLayoutPanel();
            btnCerrar_351FI = new BotonSGB_351FI();
            btnExportar_351FI = new BotonSGB_351FI();
            tlpPrincipal_351FI.SuspendLayout();
            crdFiltros_351FI.SuspendLayout();
            crdVista_351FI.SuspendLayout();
            tlpVista_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabla1_351FI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTabla2_351FI).BeginInit();
            pnlAcciones_351FI.SuspendLayout();
            SuspendLayout();
            //
            // tlpPrincipal
            //
            tlpPrincipal_351FI.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal_351FI.ColumnCount = 1;
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0F));
            tlpPrincipal_351FI.Controls.Add(crdFiltros_351FI, 0, 0);
            tlpPrincipal_351FI.Controls.Add(crdVista_351FI, 0, 1);
            tlpPrincipal_351FI.Controls.Add(pnlAcciones_351FI, 0, 2);
            tlpPrincipal_351FI.Dock = DockStyle.Fill;
            tlpPrincipal_351FI.Name = "tlpPrincipal_351FI";
            tlpPrincipal_351FI.Padding = new Padding(12);
            tlpPrincipal_351FI.RowCount = 3;
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Absolute, 130.0F));
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Absolute, 56.0F));
            tlpPrincipal_351FI.Size = new Size(1100, 640);
            tlpPrincipal_351FI.TabIndex = 0;
            //
            // crdFiltros
            //
            crdFiltros_351FI.Controls.Add(lblSeccionFiltros_351FI);
            crdFiltros_351FI.Controls.Add(lblFechaDesde_351FI);
            crdFiltros_351FI.Controls.Add(dtpFechaDesde_351FI);
            crdFiltros_351FI.Controls.Add(lblFechaHasta_351FI);
            crdFiltros_351FI.Controls.Add(dtpFechaHasta_351FI);
            crdFiltros_351FI.Controls.Add(btnReportePrestamos_351FI);
            crdFiltros_351FI.Controls.Add(btnReporteMultas_351FI);
            crdFiltros_351FI.Dock = DockStyle.Fill;
            crdFiltros_351FI.Margin = new Padding(8);
            crdFiltros_351FI.Name = "crdFiltros_351FI";
            crdFiltros_351FI.Size = new Size(1060, 114);
            crdFiltros_351FI.TabIndex = 0;
            //
            // lblSeccionFiltros
            //
            lblSeccionFiltros_351FI.AutoSize = true;
            lblSeccionFiltros_351FI.BackColor = Color.Transparent;
            lblSeccionFiltros_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionFiltros_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionFiltros_351FI.Location = new Point(20, 12);
            lblSeccionFiltros_351FI.Name = "lblSeccionFiltros_351FI";
            lblSeccionFiltros_351FI.Size = new Size(170, 20);
            lblSeccionFiltros_351FI.TabIndex = 0;
            lblSeccionFiltros_351FI.Text = "Período del reporte";
            //
            // lblFechaDesde
            //
            lblFechaDesde_351FI.AutoSize = true;
            lblFechaDesde_351FI.BackColor = Color.Transparent;
            lblFechaDesde_351FI.Font = new Font("Segoe UI", 10F);
            lblFechaDesde_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblFechaDesde_351FI.Location = new Point(20, 44);
            lblFechaDesde_351FI.Name = "lblFechaDesde_351FI";
            lblFechaDesde_351FI.Size = new Size(90, 20);
            lblFechaDesde_351FI.TabIndex = 1;
            lblFechaDesde_351FI.Text = "Fecha desde";
            //
            // dtpFechaDesde
            //
            dtpFechaDesde_351FI.Format = DateTimePickerFormat.Short;
            dtpFechaDesde_351FI.Location = new Point(20, 68);
            dtpFechaDesde_351FI.Name = "dtpFechaDesde_351FI";
            dtpFechaDesde_351FI.Size = new Size(140, 27);
            dtpFechaDesde_351FI.TabIndex = 2;
            //
            // lblFechaHasta
            //
            lblFechaHasta_351FI.AutoSize = true;
            lblFechaHasta_351FI.BackColor = Color.Transparent;
            lblFechaHasta_351FI.Font = new Font("Segoe UI", 10F);
            lblFechaHasta_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblFechaHasta_351FI.Location = new Point(176, 44);
            lblFechaHasta_351FI.Name = "lblFechaHasta_351FI";
            lblFechaHasta_351FI.Size = new Size(86, 20);
            lblFechaHasta_351FI.TabIndex = 3;
            lblFechaHasta_351FI.Text = "Fecha hasta";
            //
            // dtpFechaHasta
            //
            dtpFechaHasta_351FI.Format = DateTimePickerFormat.Short;
            dtpFechaHasta_351FI.Location = new Point(176, 68);
            dtpFechaHasta_351FI.Name = "dtpFechaHasta_351FI";
            dtpFechaHasta_351FI.Size = new Size(140, 27);
            dtpFechaHasta_351FI.TabIndex = 4;
            //
            // btnReportePrestamos
            //
            btnReportePrestamos_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnReportePrestamos_351FI.Icono_351FI = "";
            btnReportePrestamos_351FI.Location = new Point(348, 62);
            btnReportePrestamos_351FI.Name = "btnReportePrestamos_351FI";
            btnReportePrestamos_351FI.Size = new Size(300, 40);
            btnReportePrestamos_351FI.TabIndex = 5;
            btnReportePrestamos_351FI.Text = "Préstamos y devoluciones";
            btnReportePrestamos_351FI.Click += btnReportePrestamos_351FI_Click;
            //
            // btnReporteMultas
            //
            btnReporteMultas_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnReporteMultas_351FI.Icono_351FI = "";
            btnReporteMultas_351FI.Location = new Point(664, 62);
            btnReporteMultas_351FI.Name = "btnReporteMultas_351FI";
            btnReporteMultas_351FI.Size = new Size(300, 40);
            btnReporteMultas_351FI.TabIndex = 6;
            btnReporteMultas_351FI.Text = "Multas y donaciones";
            btnReporteMultas_351FI.Click += btnReporteMultas_351FI_Click;
            //
            // crdVista
            //
            crdVista_351FI.Controls.Add(lblSeccionVista_351FI);
            crdVista_351FI.Controls.Add(tlpVista_351FI);
            crdVista_351FI.Dock = DockStyle.Fill;
            crdVista_351FI.Margin = new Padding(8);
            crdVista_351FI.Name = "crdVista_351FI";
            crdVista_351FI.Size = new Size(1060, 382);
            crdVista_351FI.TabIndex = 1;
            //
            // lblSeccionVista
            //
            lblSeccionVista_351FI.AutoSize = true;
            lblSeccionVista_351FI.BackColor = Color.Transparent;
            lblSeccionVista_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionVista_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionVista_351FI.Location = new Point(20, 12);
            lblSeccionVista_351FI.Name = "lblSeccionVista_351FI";
            lblSeccionVista_351FI.Size = new Size(170, 20);
            lblSeccionVista_351FI.TabIndex = 0;
            lblSeccionVista_351FI.Text = "Vista previa";
            //
            // tlpVista
            //
            tlpVista_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpVista_351FI.BackColor = Color.Transparent;
            tlpVista_351FI.ColumnCount = 1;
            tlpVista_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0F));
            tlpVista_351FI.Controls.Add(lblTitulo1_351FI, 0, 0);
            tlpVista_351FI.Controls.Add(lblResumen1_351FI, 0, 1);
            tlpVista_351FI.Controls.Add(dgvTabla1_351FI, 0, 2);
            tlpVista_351FI.Controls.Add(lblTitulo2_351FI, 0, 3);
            tlpVista_351FI.Controls.Add(lblResumen2_351FI, 0, 4);
            tlpVista_351FI.Controls.Add(dgvTabla2_351FI, 0, 5);
            tlpVista_351FI.Location = new Point(20, 44);
            tlpVista_351FI.Name = "tlpVista_351FI";
            tlpVista_351FI.RowCount = 6;
            tlpVista_351FI.RowStyles.Add(new RowStyle(SizeType.Absolute, 28.0F));
            tlpVista_351FI.RowStyles.Add(new RowStyle(SizeType.Absolute, 26.0F));
            tlpVista_351FI.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0F));
            tlpVista_351FI.RowStyles.Add(new RowStyle(SizeType.Absolute, 28.0F));
            tlpVista_351FI.RowStyles.Add(new RowStyle(SizeType.Absolute, 26.0F));
            tlpVista_351FI.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0F));
            tlpVista_351FI.Size = new Size(1020, 322);
            tlpVista_351FI.TabIndex = 1;
            //
            // lblTitulo1
            //
            lblTitulo1_351FI.BackColor = Color.Transparent;
            lblTitulo1_351FI.Dock = DockStyle.Fill;
            lblTitulo1_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            lblTitulo1_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitulo1_351FI.Margin = new Padding(0);
            lblTitulo1_351FI.Name = "lblTitulo1_351FI";
            lblTitulo1_351FI.TabIndex = 0;
            lblTitulo1_351FI.TextAlign = ContentAlignment.MiddleLeft;
            //
            // lblResumen1
            //
            lblResumen1_351FI.BackColor = Color.Transparent;
            lblResumen1_351FI.Dock = DockStyle.Fill;
            lblResumen1_351FI.Font = new Font("Segoe UI", 9.5F);
            lblResumen1_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblResumen1_351FI.Margin = new Padding(0);
            lblResumen1_351FI.Name = "lblResumen1_351FI";
            lblResumen1_351FI.TabIndex = 1;
            lblResumen1_351FI.TextAlign = ContentAlignment.MiddleLeft;
            //
            // dgvTabla1
            //
            dgvTabla1_351FI.Dock = DockStyle.Fill;
            dgvTabla1_351FI.Margin = new Padding(0);
            dgvTabla1_351FI.Name = "dgvTabla1_351FI";
            dgvTabla1_351FI.TabIndex = 2;
            //
            // lblTitulo2
            //
            lblTitulo2_351FI.BackColor = Color.Transparent;
            lblTitulo2_351FI.Dock = DockStyle.Fill;
            lblTitulo2_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            lblTitulo2_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitulo2_351FI.Margin = new Padding(0);
            lblTitulo2_351FI.Name = "lblTitulo2_351FI";
            lblTitulo2_351FI.TabIndex = 3;
            lblTitulo2_351FI.TextAlign = ContentAlignment.MiddleLeft;
            //
            // lblResumen2
            //
            lblResumen2_351FI.BackColor = Color.Transparent;
            lblResumen2_351FI.Dock = DockStyle.Fill;
            lblResumen2_351FI.Font = new Font("Segoe UI", 9.5F);
            lblResumen2_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblResumen2_351FI.Margin = new Padding(0);
            lblResumen2_351FI.Name = "lblResumen2_351FI";
            lblResumen2_351FI.TabIndex = 4;
            lblResumen2_351FI.TextAlign = ContentAlignment.MiddleLeft;
            //
            // dgvTabla2
            //
            dgvTabla2_351FI.Dock = DockStyle.Fill;
            dgvTabla2_351FI.Margin = new Padding(0);
            dgvTabla2_351FI.Name = "dgvTabla2_351FI";
            dgvTabla2_351FI.TabIndex = 5;
            //
            // pnlAcciones
            //
            pnlAcciones_351FI.BackColor = Color.Transparent;
            pnlAcciones_351FI.Controls.Add(btnCerrar_351FI);
            pnlAcciones_351FI.Controls.Add(btnExportar_351FI);
            pnlAcciones_351FI.Dock = DockStyle.Fill;
            pnlAcciones_351FI.FlowDirection = FlowDirection.RightToLeft;
            pnlAcciones_351FI.Margin = new Padding(8);
            pnlAcciones_351FI.Name = "pnlAcciones_351FI";
            pnlAcciones_351FI.Size = new Size(1060, 40);
            pnlAcciones_351FI.TabIndex = 2;
            pnlAcciones_351FI.WrapContents = false;
            //
            // btnCerrar
            //
            btnCerrar_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnCerrar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnCerrar_351FI.Icono_351FI = "";
            btnCerrar_351FI.Margin = new Padding(12, 0, 0, 0);
            btnCerrar_351FI.Name = "btnCerrar_351FI";
            btnCerrar_351FI.Size = new Size(140, 40);
            btnCerrar_351FI.TabIndex = 0;
            btnCerrar_351FI.Text = "Cerrar";
            btnCerrar_351FI.Click += btnCerrar_351FI_Click;
            //
            // btnExportar
            //
            btnExportar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnExportar_351FI.Icono_351FI = "";
            btnExportar_351FI.Margin = new Padding(12, 0, 0, 0);
            btnExportar_351FI.Name = "btnExportar_351FI";
            btnExportar_351FI.Size = new Size(180, 40);
            btnExportar_351FI.TabIndex = 1;
            btnExportar_351FI.Text = "Exportar a PDF";
            btnExportar_351FI.Click += btnExportar_351FI_Click;
            //
            // FormReporte
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal_351FI);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReporte_351FI";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes";
            Load += FormReporte_351FI_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTabla1_351FI).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTabla2_351FI).EndInit();
            pnlAcciones_351FI.ResumeLayout(false);
            tlpVista_351FI.ResumeLayout(false);
            crdVista_351FI.ResumeLayout(false);
            crdVista_351FI.PerformLayout();
            crdFiltros_351FI.ResumeLayout(false);
            crdFiltros_351FI.PerformLayout();
            tlpPrincipal_351FI.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal_351FI;
        private TarjetaSGB_351FI crdFiltros_351FI;
        private Label lblSeccionFiltros_351FI;
        private Label lblFechaDesde_351FI;
        private DateTimePicker dtpFechaDesde_351FI;
        private Label lblFechaHasta_351FI;
        private DateTimePicker dtpFechaHasta_351FI;
        private BotonSGB_351FI btnReportePrestamos_351FI;
        private BotonSGB_351FI btnReporteMultas_351FI;
        private TarjetaSGB_351FI crdVista_351FI;
        private Label lblSeccionVista_351FI;
        private TableLayoutPanel tlpVista_351FI;
        private Label lblTitulo1_351FI;
        private Label lblResumen1_351FI;
        private GrillaSGB_351FI dgvTabla1_351FI;
        private Label lblTitulo2_351FI;
        private Label lblResumen2_351FI;
        private GrillaSGB_351FI dgvTabla2_351FI;
        private FlowLayoutPanel pnlAcciones_351FI;
        private BotonSGB_351FI btnCerrar_351FI;
        private BotonSGB_351FI btnExportar_351FI;
    }
}
