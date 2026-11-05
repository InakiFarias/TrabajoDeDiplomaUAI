using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormDevolucion_351FI
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
            crdPrestamo_351FI = new TarjetaSGB_351FI();
            lblSeccionPrestamo_351FI = new Label();
            lblBuscar_351FI = new Label();
            txtBuscar_351FI = new TextBox();
            dgvPrestamos_351FI = new GrillaSGB_351FI();
            colPreNumero_351FI = new DataGridViewTextBoxColumn();
            colPreSocio_351FI = new DataGridViewTextBoxColumn();
            colPreDni_351FI = new DataGridViewTextBoxColumn();
            colPreFecha_351FI = new DataGridViewTextBoxColumn();
            colPrePrevista_351FI = new DataGridViewTextBoxColumn();
            crdResumen_351FI = new TarjetaSGB_351FI();
            lblSeccionResumen_351FI = new Label();
            lblSocio_351FI = new Label();
            lblFechaPrestamo_351FI = new Label();
            lblFechaDevolucionPrevista_351FI = new Label();
            lblFechaDevolucion_351FI = new Label();
            lblDiasAtraso_351FI = new Label();
            lblMulta_351FI = new Label();
            chkRecepcionCompleta_351FI = new CheckBox();
            crdEjemplares_351FI = new TarjetaSGB_351FI();
            lblSeccionEjemplares_351FI = new Label();
            dgvEjemplares_351FI = new GrillaSGB_351FI();
            colCodigo_351FI = new DataGridViewTextBoxColumn();
            colTitulo_351FI = new DataGridViewTextBoxColumn();
            colAutor_351FI = new DataGridViewTextBoxColumn();
            pnlAcciones_351FI = new FlowLayoutPanel();
            btnConfirmar_351FI = new BotonSGB_351FI();
            btnCancelar_351FI = new BotonSGB_351FI();
            tlpPrincipal_351FI.SuspendLayout();
            crdPrestamo_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos_351FI).BeginInit();
            crdResumen_351FI.SuspendLayout();
            crdEjemplares_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares_351FI).BeginInit();
            pnlAcciones_351FI.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal_351FI.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal_351FI.ColumnCount = 2;
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));
            tlpPrincipal_351FI.Controls.Add(crdPrestamo_351FI, 0, 0);
            tlpPrincipal_351FI.Controls.Add(crdResumen_351FI, 1, 0);
            tlpPrincipal_351FI.Controls.Add(crdEjemplares_351FI, 0, 1);
            tlpPrincipal_351FI.Controls.Add(pnlAcciones_351FI, 0, 2);
            tlpPrincipal_351FI.Dock = DockStyle.Fill;
            tlpPrincipal_351FI.Name = "tlpPrincipal_351FI";
            tlpPrincipal_351FI.Padding = new Padding(12);
            tlpPrincipal_351FI.RowCount = 3;
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Percent, 58.0F));
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Percent, 42.0F));
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Absolute, 56.0F));
            tlpPrincipal_351FI.Size = new Size(1100, 640);
            tlpPrincipal_351FI.TabIndex = 0;
            tlpPrincipal_351FI.SetColumnSpan(crdEjemplares_351FI, 2);
            tlpPrincipal_351FI.SetColumnSpan(pnlAcciones_351FI, 2);
            // 
            // crdPrestamo
            // 
            crdPrestamo_351FI.Controls.Add(lblSeccionPrestamo_351FI);
            crdPrestamo_351FI.Controls.Add(lblBuscar_351FI);
            crdPrestamo_351FI.Controls.Add(txtBuscar_351FI);
            crdPrestamo_351FI.Controls.Add(dgvPrestamos_351FI);
            crdPrestamo_351FI.Dock = DockStyle.Fill;
            crdPrestamo_351FI.Margin = new Padding(8);
            crdPrestamo_351FI.Name = "crdPrestamo_351FI";
            crdPrestamo_351FI.Size = new Size(522, 309);
            crdPrestamo_351FI.TabIndex = 0;
            // 
            // lblSeccionPrestamo
            // 
            lblSeccionPrestamo_351FI.AutoSize = true;
            lblSeccionPrestamo_351FI.BackColor = Color.Transparent;
            lblSeccionPrestamo_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionPrestamo_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionPrestamo_351FI.Location = new Point(20, 16);
            lblSeccionPrestamo_351FI.Name = "lblSeccionPrestamo_351FI";
            lblSeccionPrestamo_351FI.Size = new Size(144, 20);
            lblSeccionPrestamo_351FI.TabIndex = 0;
            lblSeccionPrestamo_351FI.Text = "Préstamos vigentes";
            // 
            // lblBuscar
            // 
            lblBuscar_351FI.AutoSize = true;
            lblBuscar_351FI.BackColor = Color.Transparent;
            lblBuscar_351FI.Font = new Font("Segoe UI", 10F);
            lblBuscar_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblBuscar_351FI.Location = new Point(20, 52);
            lblBuscar_351FI.Name = "lblBuscar_351FI";
            lblBuscar_351FI.Size = new Size(456, 20);
            lblBuscar_351FI.TabIndex = 1;
            lblBuscar_351FI.Text = "Número de préstamo o DNI del socio (búsqueda incremental)";
            // 
            // txtBuscar
            // 
            txtBuscar_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtBuscar_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar_351FI.Location = new Point(20, 74);
            txtBuscar_351FI.Name = "txtBuscar_351FI";
            txtBuscar_351FI.PlaceholderText = "Ej.: 15 o 28456123";
            txtBuscar_351FI.Size = new Size(482, 27);
            txtBuscar_351FI.TabIndex = 2;
            txtBuscar_351FI.TextChanged += txtBuscar_351FI_TextChanged;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos_351FI.Columns.AddRange(new DataGridViewColumn[] { colPreNumero_351FI, colPreSocio_351FI, colPreDni_351FI, colPreFecha_351FI, colPrePrevista_351FI });
            dgvPrestamos_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPrestamos_351FI.Location = new Point(20, 116);
            dgvPrestamos_351FI.Name = "dgvPrestamos_351FI";
            dgvPrestamos_351FI.Size = new Size(482, 173);
            dgvPrestamos_351FI.TabIndex = 3;
            // 
            // colPreNumero
            // 
            colPreNumero_351FI.FillWeight = 11F;
            colPreNumero_351FI.HeaderText = "N°";
            colPreNumero_351FI.Name = "colPreNumero_351FI";
            colPreNumero_351FI.ReadOnly = true;
            // 
            // colPreSocio
            // 
            colPreSocio_351FI.FillWeight = 35F;
            colPreSocio_351FI.HeaderText = "Socio";
            colPreSocio_351FI.Name = "colPreSocio_351FI";
            colPreSocio_351FI.ReadOnly = true;
            // 
            // colPreDni
            // 
            colPreDni_351FI.FillWeight = 18F;
            colPreDni_351FI.HeaderText = "DNI";
            colPreDni_351FI.Name = "colPreDni_351FI";
            colPreDni_351FI.ReadOnly = true;
            // 
            // colPreFecha
            // 
            colPreFecha_351FI.FillWeight = 18F;
            colPreFecha_351FI.HeaderText = "Préstamo";
            colPreFecha_351FI.Name = "colPreFecha_351FI";
            colPreFecha_351FI.ReadOnly = true;
            // 
            // colPrePrevista
            // 
            colPrePrevista_351FI.FillWeight = 18F;
            colPrePrevista_351FI.HeaderText = "Vence";
            colPrePrevista_351FI.Name = "colPrePrevista_351FI";
            colPrePrevista_351FI.ReadOnly = true;
            dgvPrestamos_351FI.SelectionChanged += dgvPrestamos_351FI_SelectionChanged;
            // 
            // crdResumen
            // 
            crdResumen_351FI.Controls.Add(lblSeccionResumen_351FI);
            crdResumen_351FI.Controls.Add(lblSocio_351FI);
            crdResumen_351FI.Controls.Add(lblFechaPrestamo_351FI);
            crdResumen_351FI.Controls.Add(lblFechaDevolucionPrevista_351FI);
            crdResumen_351FI.Controls.Add(lblFechaDevolucion_351FI);
            crdResumen_351FI.Controls.Add(lblDiasAtraso_351FI);
            crdResumen_351FI.Controls.Add(lblMulta_351FI);
            crdResumen_351FI.Controls.Add(chkRecepcionCompleta_351FI);
            crdResumen_351FI.Dock = DockStyle.Fill;
            crdResumen_351FI.Margin = new Padding(8);
            crdResumen_351FI.Name = "crdResumen_351FI";
            crdResumen_351FI.Size = new Size(522, 309);
            crdResumen_351FI.TabIndex = 1;
            // 
            // lblSeccionResumen
            // 
            lblSeccionResumen_351FI.AutoSize = true;
            lblSeccionResumen_351FI.BackColor = Color.Transparent;
            lblSeccionResumen_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionResumen_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionResumen_351FI.Location = new Point(20, 16);
            lblSeccionResumen_351FI.Name = "lblSeccionResumen_351FI";
            lblSeccionResumen_351FI.Size = new Size(192, 20);
            lblSeccionResumen_351FI.TabIndex = 0;
            lblSeccionResumen_351FI.Text = "Resumen de la devolución";
            // 
            // lblSocio
            // 
            lblSocio_351FI.AutoSize = true;
            lblSocio_351FI.BackColor = Color.Transparent;
            lblSocio_351FI.Font = new Font("Segoe UI", 11F);
            lblSocio_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSocio_351FI.Location = new Point(20, 56);
            lblSocio_351FI.Name = "lblSocio_351FI";
            lblSocio_351FI.Size = new Size(64, 20);
            lblSocio_351FI.TabIndex = 1;
            lblSocio_351FI.Text = "Socio: —";
            // 
            // lblFechaPrestamo
            // 
            lblFechaPrestamo_351FI.AutoSize = true;
            lblFechaPrestamo_351FI.BackColor = Color.Transparent;
            lblFechaPrestamo_351FI.Font = new Font("Segoe UI", 11F);
            lblFechaPrestamo_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblFechaPrestamo_351FI.Location = new Point(20, 84);
            lblFechaPrestamo_351FI.Name = "lblFechaPrestamo_351FI";
            lblFechaPrestamo_351FI.Size = new Size(168, 20);
            lblFechaPrestamo_351FI.TabIndex = 2;
            lblFechaPrestamo_351FI.Text = "Fecha del préstamo: —";
            // 
            // lblFechaDevolucionPrevista
            // 
            lblFechaDevolucionPrevista_351FI.AutoSize = true;
            lblFechaDevolucionPrevista_351FI.BackColor = Color.Transparent;
            lblFechaDevolucionPrevista_351FI.Font = new Font("Segoe UI", 11F);
            lblFechaDevolucionPrevista_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblFechaDevolucionPrevista_351FI.Location = new Point(20, 112);
            lblFechaDevolucionPrevista_351FI.Name = "lblFechaDevolucionPrevista_351FI";
            lblFechaDevolucionPrevista_351FI.Size = new Size(248, 20);
            lblFechaDevolucionPrevista_351FI.TabIndex = 3;
            lblFechaDevolucionPrevista_351FI.Text = "Fecha de devolución prevista: —";
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion_351FI.AutoSize = true;
            lblFechaDevolucion_351FI.BackColor = Color.Transparent;
            lblFechaDevolucion_351FI.Font = new Font("Segoe UI", 11F);
            lblFechaDevolucion_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblFechaDevolucion_351FI.Location = new Point(20, 140);
            lblFechaDevolucion_351FI.Name = "lblFechaDevolucion_351FI";
            lblFechaDevolucion_351FI.Size = new Size(216, 20);
            lblFechaDevolucion_351FI.TabIndex = 4;
            lblFechaDevolucion_351FI.Text = "Fecha real de devolución: —";
            // 
            // lblDiasAtraso
            // 
            lblDiasAtraso_351FI.AutoSize = true;
            lblDiasAtraso_351FI.BackColor = Color.Transparent;
            lblDiasAtraso_351FI.Font = new Font("Segoe UI", 11F);
            lblDiasAtraso_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblDiasAtraso_351FI.Location = new Point(20, 168);
            lblDiasAtraso_351FI.Name = "lblDiasAtraso_351FI";
            lblDiasAtraso_351FI.Size = new Size(136, 20);
            lblDiasAtraso_351FI.TabIndex = 5;
            lblDiasAtraso_351FI.Text = "Días de atraso: —";
            // 
            // lblMulta
            // 
            lblMulta_351FI.AutoSize = true;
            lblMulta_351FI.BackColor = Color.Transparent;
            lblMulta_351FI.Font = new Font("Segoe UI Semibold", 11F);
            lblMulta_351FI.ForeColor = Color.FromArgb(123, 30, 46);
            lblMulta_351FI.Location = new Point(20, 196);
            lblMulta_351FI.Name = "lblMulta_351FI";
            lblMulta_351FI.Size = new Size(64, 20);
            lblMulta_351FI.TabIndex = 6;
            lblMulta_351FI.Text = "Multa: —";
            // 
            // chkRecepcionCompleta
            // 
            chkRecepcionCompleta_351FI.AutoSize = true;
            chkRecepcionCompleta_351FI.BackColor = Color.Transparent;
            chkRecepcionCompleta_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            chkRecepcionCompleta_351FI.Location = new Point(20, 240);
            chkRecepcionCompleta_351FI.Name = "chkRecepcionCompleta_351FI";
            chkRecepcionCompleta_351FI.Size = new Size(344, 24);
            chkRecepcionCompleta_351FI.TabIndex = 7;
            chkRecepcionCompleta_351FI.Text = "Recibí todos los ejemplares del préstamo";
            chkRecepcionCompleta_351FI.UseVisualStyleBackColor = false;
            // 
            // crdEjemplares
            // 
            crdEjemplares_351FI.Controls.Add(lblSeccionEjemplares_351FI);
            crdEjemplares_351FI.Controls.Add(dgvEjemplares_351FI);
            crdEjemplares_351FI.Dock = DockStyle.Fill;
            crdEjemplares_351FI.Margin = new Padding(8);
            crdEjemplares_351FI.Name = "crdEjemplares_351FI";
            crdEjemplares_351FI.Size = new Size(1060, 219);
            crdEjemplares_351FI.TabIndex = 2;
            // 
            // lblSeccionEjemplares
            // 
            lblSeccionEjemplares_351FI.AutoSize = true;
            lblSeccionEjemplares_351FI.BackColor = Color.Transparent;
            lblSeccionEjemplares_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionEjemplares_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionEjemplares_351FI.Location = new Point(20, 16);
            lblSeccionEjemplares_351FI.Name = "lblSeccionEjemplares_351FI";
            lblSeccionEjemplares_351FI.Size = new Size(160, 20);
            lblSeccionEjemplares_351FI.TabIndex = 0;
            lblSeccionEjemplares_351FI.Text = "Ejemplares prestados";
            // 
            // dgvEjemplares
            // 
            dgvEjemplares_351FI.Columns.AddRange(new DataGridViewColumn[] { colCodigo_351FI, colTitulo_351FI, colAutor_351FI });
            dgvEjemplares_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEjemplares_351FI.Location = new Point(20, 52);
            dgvEjemplares_351FI.Name = "dgvEjemplares_351FI";
            dgvEjemplares_351FI.Size = new Size(1020, 147);
            dgvEjemplares_351FI.TabIndex = 1;
            // 
            // colCodigo
            // 
            colCodigo_351FI.FillWeight = 20F;
            colCodigo_351FI.HeaderText = "Código";
            colCodigo_351FI.Name = "colCodigo_351FI";
            colCodigo_351FI.ReadOnly = true;
            // 
            // colTitulo
            // 
            colTitulo_351FI.FillWeight = 50F;
            colTitulo_351FI.HeaderText = "Título";
            colTitulo_351FI.Name = "colTitulo_351FI";
            colTitulo_351FI.ReadOnly = true;
            // 
            // colAutor
            // 
            colAutor_351FI.FillWeight = 30F;
            colAutor_351FI.HeaderText = "Autor";
            colAutor_351FI.Name = "colAutor_351FI";
            colAutor_351FI.ReadOnly = true;
            // 
            // pnlAcciones
            // 
            pnlAcciones_351FI.BackColor = Color.Transparent;
            pnlAcciones_351FI.Controls.Add(btnConfirmar_351FI);
            pnlAcciones_351FI.Controls.Add(btnCancelar_351FI);
            pnlAcciones_351FI.FlowDirection = FlowDirection.RightToLeft;
            pnlAcciones_351FI.WrapContents = false;
            pnlAcciones_351FI.Dock = DockStyle.Fill;
            pnlAcciones_351FI.Margin = new Padding(8);
            pnlAcciones_351FI.Name = "pnlAcciones_351FI";
            pnlAcciones_351FI.Size = new Size(400, 40);
            pnlAcciones_351FI.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            btnConfirmar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnConfirmar_351FI.Icono_351FI = "\uE73E";
            btnConfirmar_351FI.Margin = new Padding(12, 0, 0, 0);
            btnConfirmar_351FI.Name = "btnConfirmar_351FI";
            btnConfirmar_351FI.Size = new Size(220, 40);
            btnConfirmar_351FI.TabIndex = 0;
            btnConfirmar_351FI.Text = "Registrar devolución";
            btnConfirmar_351FI.Click += btnConfirmar_351FI_Click;
            // 
            // btnCancelar
            // 
            btnCancelar_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnCancelar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnCancelar_351FI.Icono_351FI = "\uE711";
            btnCancelar_351FI.Margin = new Padding(12, 0, 0, 0);
            btnCancelar_351FI.Name = "btnCancelar_351FI";
            btnCancelar_351FI.Size = new Size(140, 40);
            btnCancelar_351FI.TabIndex = 1;
            btnCancelar_351FI.Text = "Cancelar";
            btnCancelar_351FI.Click += btnCancelar_351FI_Click;
            // 
            // FormDevolucion
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal_351FI);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDevolucion_351FI";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar devolución";
            Load += FormDevolucion_351FI_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos_351FI).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares_351FI).EndInit();
            pnlAcciones_351FI.ResumeLayout(false);
            pnlAcciones_351FI.PerformLayout();
            crdEjemplares_351FI.ResumeLayout(false);
            crdEjemplares_351FI.PerformLayout();
            crdResumen_351FI.ResumeLayout(false);
            crdResumen_351FI.PerformLayout();
            crdPrestamo_351FI.ResumeLayout(false);
            crdPrestamo_351FI.PerformLayout();
            tlpPrincipal_351FI.ResumeLayout(false);
            tlpPrincipal_351FI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal_351FI;
        private TarjetaSGB_351FI crdPrestamo_351FI;
        private Label lblSeccionPrestamo_351FI;
        private Label lblBuscar_351FI;
        private TextBox txtBuscar_351FI;
        private GrillaSGB_351FI dgvPrestamos_351FI;
        private DataGridViewTextBoxColumn colPreNumero_351FI;
        private DataGridViewTextBoxColumn colPreSocio_351FI;
        private DataGridViewTextBoxColumn colPreDni_351FI;
        private DataGridViewTextBoxColumn colPreFecha_351FI;
        private DataGridViewTextBoxColumn colPrePrevista_351FI;
        private TarjetaSGB_351FI crdResumen_351FI;
        private Label lblSeccionResumen_351FI;
        private Label lblSocio_351FI;
        private Label lblFechaPrestamo_351FI;
        private Label lblFechaDevolucionPrevista_351FI;
        private Label lblFechaDevolucion_351FI;
        private Label lblDiasAtraso_351FI;
        private Label lblMulta_351FI;
        private CheckBox chkRecepcionCompleta_351FI;
        private TarjetaSGB_351FI crdEjemplares_351FI;
        private Label lblSeccionEjemplares_351FI;
        private GrillaSGB_351FI dgvEjemplares_351FI;
        private DataGridViewTextBoxColumn colCodigo_351FI;
        private DataGridViewTextBoxColumn colTitulo_351FI;
        private DataGridViewTextBoxColumn colAutor_351FI;
        private FlowLayoutPanel pnlAcciones_351FI;
        private BotonSGB_351FI btnConfirmar_351FI;
        private BotonSGB_351FI btnCancelar_351FI;
    }
}
