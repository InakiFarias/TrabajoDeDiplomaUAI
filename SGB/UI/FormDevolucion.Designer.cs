using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormDevolucion
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
            crdPrestamo = new TarjetaSGB();
            lblSeccionPrestamo = new Label();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            dgvPrestamos = new GrillaSGB();
            colPreNumero = new DataGridViewTextBoxColumn();
            colPreSocio = new DataGridViewTextBoxColumn();
            colPreDni = new DataGridViewTextBoxColumn();
            colPreFecha = new DataGridViewTextBoxColumn();
            colPrePrevista = new DataGridViewTextBoxColumn();
            crdResumen = new TarjetaSGB();
            lblSeccionResumen = new Label();
            lblSocio = new Label();
            lblFechaPrestamo = new Label();
            lblFechaDevolucionPrevista = new Label();
            lblFechaDevolucion = new Label();
            lblDiasAtraso = new Label();
            lblMulta = new Label();
            chkRecepcionCompleta = new CheckBox();
            crdEjemplares = new TarjetaSGB();
            lblSeccionEjemplares = new Label();
            dgvEjemplares = new GrillaSGB();
            colCodigo = new DataGridViewTextBoxColumn();
            colTitulo = new DataGridViewTextBoxColumn();
            colAutor = new DataGridViewTextBoxColumn();
            pnlAcciones = new FlowLayoutPanel();
            btnConfirmar = new BotonSGB();
            btnCancelar = new BotonSGB();
            tlpPrincipal.SuspendLayout();
            crdPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            crdResumen.SuspendLayout();
            crdEjemplares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares).BeginInit();
            pnlAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal.ColumnCount = 2;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));
            tlpPrincipal.Controls.Add(crdPrestamo, 0, 0);
            tlpPrincipal.Controls.Add(crdResumen, 1, 0);
            tlpPrincipal.Controls.Add(crdEjemplares, 0, 1);
            tlpPrincipal.Controls.Add(pnlAcciones, 0, 2);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(12);
            tlpPrincipal.RowCount = 3;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 58.0F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 42.0F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 56.0F));
            tlpPrincipal.Size = new Size(1100, 640);
            tlpPrincipal.TabIndex = 0;
            tlpPrincipal.SetColumnSpan(crdEjemplares, 2);
            tlpPrincipal.SetColumnSpan(pnlAcciones, 2);
            // 
            // crdPrestamo
            // 
            crdPrestamo.Controls.Add(lblSeccionPrestamo);
            crdPrestamo.Controls.Add(lblBuscar);
            crdPrestamo.Controls.Add(txtBuscar);
            crdPrestamo.Controls.Add(dgvPrestamos);
            crdPrestamo.Dock = DockStyle.Fill;
            crdPrestamo.Margin = new Padding(8);
            crdPrestamo.Name = "crdPrestamo";
            crdPrestamo.Size = new Size(522, 309);
            crdPrestamo.TabIndex = 0;
            // 
            // lblSeccionPrestamo
            // 
            lblSeccionPrestamo.AutoSize = true;
            lblSeccionPrestamo.BackColor = Color.Transparent;
            lblSeccionPrestamo.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionPrestamo.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionPrestamo.Location = new Point(20, 16);
            lblSeccionPrestamo.Name = "lblSeccionPrestamo";
            lblSeccionPrestamo.Size = new Size(144, 20);
            lblSeccionPrestamo.TabIndex = 0;
            lblSeccionPrestamo.Text = "Préstamos vigentes";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.Transparent;
            lblBuscar.Font = new Font("Segoe UI", 10F);
            lblBuscar.ForeColor = Color.FromArgb(75, 85, 99);
            lblBuscar.Location = new Point(20, 52);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(456, 20);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Número de préstamo o DNI del socio (búsqueda incremental)";
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.ForeColor = Color.FromArgb(31, 41, 55);
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Location = new Point(20, 74);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ej.: 15 o 28456123";
            txtBuscar.Size = new Size(482, 27);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.Columns.AddRange(new DataGridViewColumn[] { colPreNumero, colPreSocio, colPreDni, colPreFecha, colPrePrevista });
            dgvPrestamos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPrestamos.Location = new Point(20, 116);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.Size = new Size(482, 173);
            dgvPrestamos.TabIndex = 3;
            // 
            // colPreNumero
            // 
            colPreNumero.FillWeight = 11F;
            colPreNumero.HeaderText = "N°";
            colPreNumero.Name = "colPreNumero";
            colPreNumero.ReadOnly = true;
            // 
            // colPreSocio
            // 
            colPreSocio.FillWeight = 35F;
            colPreSocio.HeaderText = "Socio";
            colPreSocio.Name = "colPreSocio";
            colPreSocio.ReadOnly = true;
            // 
            // colPreDni
            // 
            colPreDni.FillWeight = 18F;
            colPreDni.HeaderText = "DNI";
            colPreDni.Name = "colPreDni";
            colPreDni.ReadOnly = true;
            // 
            // colPreFecha
            // 
            colPreFecha.FillWeight = 18F;
            colPreFecha.HeaderText = "Préstamo";
            colPreFecha.Name = "colPreFecha";
            colPreFecha.ReadOnly = true;
            // 
            // colPrePrevista
            // 
            colPrePrevista.FillWeight = 18F;
            colPrePrevista.HeaderText = "Vence";
            colPrePrevista.Name = "colPrePrevista";
            colPrePrevista.ReadOnly = true;
            dgvPrestamos.SelectionChanged += dgvPrestamos_SelectionChanged;
            // 
            // crdResumen
            // 
            crdResumen.Controls.Add(lblSeccionResumen);
            crdResumen.Controls.Add(lblSocio);
            crdResumen.Controls.Add(lblFechaPrestamo);
            crdResumen.Controls.Add(lblFechaDevolucionPrevista);
            crdResumen.Controls.Add(lblFechaDevolucion);
            crdResumen.Controls.Add(lblDiasAtraso);
            crdResumen.Controls.Add(lblMulta);
            crdResumen.Controls.Add(chkRecepcionCompleta);
            crdResumen.Dock = DockStyle.Fill;
            crdResumen.Margin = new Padding(8);
            crdResumen.Name = "crdResumen";
            crdResumen.Size = new Size(522, 309);
            crdResumen.TabIndex = 1;
            // 
            // lblSeccionResumen
            // 
            lblSeccionResumen.AutoSize = true;
            lblSeccionResumen.BackColor = Color.Transparent;
            lblSeccionResumen.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionResumen.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionResumen.Location = new Point(20, 16);
            lblSeccionResumen.Name = "lblSeccionResumen";
            lblSeccionResumen.Size = new Size(192, 20);
            lblSeccionResumen.TabIndex = 0;
            lblSeccionResumen.Text = "Resumen de la devolución";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.BackColor = Color.Transparent;
            lblSocio.Font = new Font("Segoe UI", 11F);
            lblSocio.ForeColor = Color.FromArgb(31, 41, 55);
            lblSocio.Location = new Point(20, 56);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(64, 20);
            lblSocio.TabIndex = 1;
            lblSocio.Text = "Socio: —";
            // 
            // lblFechaPrestamo
            // 
            lblFechaPrestamo.AutoSize = true;
            lblFechaPrestamo.BackColor = Color.Transparent;
            lblFechaPrestamo.Font = new Font("Segoe UI", 11F);
            lblFechaPrestamo.ForeColor = Color.FromArgb(31, 41, 55);
            lblFechaPrestamo.Location = new Point(20, 84);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(168, 20);
            lblFechaPrestamo.TabIndex = 2;
            lblFechaPrestamo.Text = "Fecha del préstamo: —";
            // 
            // lblFechaDevolucionPrevista
            // 
            lblFechaDevolucionPrevista.AutoSize = true;
            lblFechaDevolucionPrevista.BackColor = Color.Transparent;
            lblFechaDevolucionPrevista.Font = new Font("Segoe UI", 11F);
            lblFechaDevolucionPrevista.ForeColor = Color.FromArgb(31, 41, 55);
            lblFechaDevolucionPrevista.Location = new Point(20, 112);
            lblFechaDevolucionPrevista.Name = "lblFechaDevolucionPrevista";
            lblFechaDevolucionPrevista.Size = new Size(248, 20);
            lblFechaDevolucionPrevista.TabIndex = 3;
            lblFechaDevolucionPrevista.Text = "Fecha de devolución prevista: —";
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.BackColor = Color.Transparent;
            lblFechaDevolucion.Font = new Font("Segoe UI", 11F);
            lblFechaDevolucion.ForeColor = Color.FromArgb(31, 41, 55);
            lblFechaDevolucion.Location = new Point(20, 140);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(216, 20);
            lblFechaDevolucion.TabIndex = 4;
            lblFechaDevolucion.Text = "Fecha real de devolución: —";
            // 
            // lblDiasAtraso
            // 
            lblDiasAtraso.AutoSize = true;
            lblDiasAtraso.BackColor = Color.Transparent;
            lblDiasAtraso.Font = new Font("Segoe UI", 11F);
            lblDiasAtraso.ForeColor = Color.FromArgb(31, 41, 55);
            lblDiasAtraso.Location = new Point(20, 168);
            lblDiasAtraso.Name = "lblDiasAtraso";
            lblDiasAtraso.Size = new Size(136, 20);
            lblDiasAtraso.TabIndex = 5;
            lblDiasAtraso.Text = "Días de atraso: —";
            // 
            // lblMulta
            // 
            lblMulta.AutoSize = true;
            lblMulta.BackColor = Color.Transparent;
            lblMulta.Font = new Font("Segoe UI Semibold", 11F);
            lblMulta.ForeColor = Color.FromArgb(123, 30, 46);
            lblMulta.Location = new Point(20, 196);
            lblMulta.Name = "lblMulta";
            lblMulta.Size = new Size(64, 20);
            lblMulta.TabIndex = 6;
            lblMulta.Text = "Multa: —";
            // 
            // chkRecepcionCompleta
            // 
            chkRecepcionCompleta.AutoSize = true;
            chkRecepcionCompleta.BackColor = Color.Transparent;
            chkRecepcionCompleta.ForeColor = Color.FromArgb(31, 41, 55);
            chkRecepcionCompleta.Location = new Point(20, 240);
            chkRecepcionCompleta.Name = "chkRecepcionCompleta";
            chkRecepcionCompleta.Size = new Size(344, 24);
            chkRecepcionCompleta.TabIndex = 7;
            chkRecepcionCompleta.Text = "Recibí todos los ejemplares del préstamo";
            chkRecepcionCompleta.UseVisualStyleBackColor = false;
            // 
            // crdEjemplares
            // 
            crdEjemplares.Controls.Add(lblSeccionEjemplares);
            crdEjemplares.Controls.Add(dgvEjemplares);
            crdEjemplares.Dock = DockStyle.Fill;
            crdEjemplares.Margin = new Padding(8);
            crdEjemplares.Name = "crdEjemplares";
            crdEjemplares.Size = new Size(1060, 219);
            crdEjemplares.TabIndex = 2;
            // 
            // lblSeccionEjemplares
            // 
            lblSeccionEjemplares.AutoSize = true;
            lblSeccionEjemplares.BackColor = Color.Transparent;
            lblSeccionEjemplares.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionEjemplares.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionEjemplares.Location = new Point(20, 16);
            lblSeccionEjemplares.Name = "lblSeccionEjemplares";
            lblSeccionEjemplares.Size = new Size(160, 20);
            lblSeccionEjemplares.TabIndex = 0;
            lblSeccionEjemplares.Text = "Ejemplares prestados";
            // 
            // dgvEjemplares
            // 
            dgvEjemplares.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colTitulo, colAutor });
            dgvEjemplares.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEjemplares.Location = new Point(20, 52);
            dgvEjemplares.Name = "dgvEjemplares";
            dgvEjemplares.Size = new Size(1020, 147);
            dgvEjemplares.TabIndex = 1;
            // 
            // colCodigo
            // 
            colCodigo.FillWeight = 20F;
            colCodigo.HeaderText = "Código";
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colTitulo
            // 
            colTitulo.FillWeight = 50F;
            colTitulo.HeaderText = "Título";
            colTitulo.Name = "colTitulo";
            colTitulo.ReadOnly = true;
            // 
            // colAutor
            // 
            colAutor.FillWeight = 30F;
            colAutor.HeaderText = "Autor";
            colAutor.Name = "colAutor";
            colAutor.ReadOnly = true;
            // 
            // pnlAcciones
            // 
            pnlAcciones.BackColor = Color.Transparent;
            pnlAcciones.Controls.Add(btnConfirmar);
            pnlAcciones.Controls.Add(btnCancelar);
            pnlAcciones.FlowDirection = FlowDirection.RightToLeft;
            pnlAcciones.WrapContents = false;
            pnlAcciones.Dock = DockStyle.Fill;
            pnlAcciones.Margin = new Padding(8);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(400, 40);
            pnlAcciones.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnConfirmar.Icono = "\uE73E";
            btnConfirmar.Margin = new Padding(12, 0, 0, 0);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(220, 40);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Registrar devolución";
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Estilo = EstiloBoton.Secundario;
            btnCancelar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnCancelar.Icono = "\uE711";
            btnCancelar.Margin = new Padding(12, 0, 0, 0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 40);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormDevolucion
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDevolucion";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar devolución";
            Load += FormDevolucion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares).EndInit();
            pnlAcciones.ResumeLayout(false);
            pnlAcciones.PerformLayout();
            crdEjemplares.ResumeLayout(false);
            crdEjemplares.PerformLayout();
            crdResumen.ResumeLayout(false);
            crdResumen.PerformLayout();
            crdPrestamo.ResumeLayout(false);
            crdPrestamo.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TarjetaSGB crdPrestamo;
        private Label lblSeccionPrestamo;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private GrillaSGB dgvPrestamos;
        private DataGridViewTextBoxColumn colPreNumero;
        private DataGridViewTextBoxColumn colPreSocio;
        private DataGridViewTextBoxColumn colPreDni;
        private DataGridViewTextBoxColumn colPreFecha;
        private DataGridViewTextBoxColumn colPrePrevista;
        private TarjetaSGB crdResumen;
        private Label lblSeccionResumen;
        private Label lblSocio;
        private Label lblFechaPrestamo;
        private Label lblFechaDevolucionPrevista;
        private Label lblFechaDevolucion;
        private Label lblDiasAtraso;
        private Label lblMulta;
        private CheckBox chkRecepcionCompleta;
        private TarjetaSGB crdEjemplares;
        private Label lblSeccionEjemplares;
        private GrillaSGB dgvEjemplares;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colTitulo;
        private DataGridViewTextBoxColumn colAutor;
        private FlowLayoutPanel pnlAcciones;
        private BotonSGB btnConfirmar;
        private BotonSGB btnCancelar;
    }
}
