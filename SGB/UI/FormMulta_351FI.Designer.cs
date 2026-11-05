using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormMulta_351FI
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
            crdSocio_351FI = new TarjetaSGB_351FI();
            lblSeccionSocio_351FI = new Label();
            lblDni_351FI = new Label();
            txtDni_351FI = new TextBox();
            btnSeleccionarSocio_351FI = new BotonSGB_351FI();
            dgvSocios_351FI = new GrillaSGB_351FI();
            colSocNumero_351FI = new DataGridViewTextBoxColumn();
            colSocApellido_351FI = new DataGridViewTextBoxColumn();
            colSocNombre_351FI = new DataGridViewTextBoxColumn();
            colSocDni_351FI = new DataGridViewTextBoxColumn();
            colSocMonto_351FI = new DataGridViewTextBoxColumn();
            lblSocio_351FI = new Label();
            crdMultas_351FI = new TarjetaSGB_351FI();
            lblSeccionMultas_351FI = new Label();
            dgvMultas_351FI = new GrillaSGB_351FI();
            colMulNumero_351FI = new DataGridViewTextBoxColumn();
            colMulPrestamo_351FI = new DataGridViewTextBoxColumn();
            colMulFecha_351FI = new DataGridViewTextBoxColumn();
            colMulDias_351FI = new DataGridViewTextBoxColumn();
            colMulMonto_351FI = new DataGridViewTextBoxColumn();
            lblMetodoPago_351FI = new Label();
            cmbMetodoPago_351FI = new ComboBox();
            lblNumeroTarjeta_351FI = new Label();
            txtNumeroTarjeta_351FI = new TextBox();
            lblTotal_351FI = new Label();
            pnlAcciones_351FI = new FlowLayoutPanel();
            btnConfirmarCobro_351FI = new BotonSGB_351FI();
            btnNoAbona_351FI = new BotonSGB_351FI();
            tlpPrincipal_351FI.SuspendLayout();
            crdSocio_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios_351FI).BeginInit();
            crdMultas_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMultas_351FI).BeginInit();
            pnlAcciones_351FI.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal_351FI.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal_351FI.ColumnCount = 2;
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.0F));
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.0F));
            tlpPrincipal_351FI.Controls.Add(crdSocio_351FI, 0, 0);
            tlpPrincipal_351FI.Controls.Add(crdMultas_351FI, 1, 0);
            tlpPrincipal_351FI.Controls.Add(pnlAcciones_351FI, 0, 1);
            tlpPrincipal_351FI.Dock = DockStyle.Fill;
            tlpPrincipal_351FI.Name = "tlpPrincipal_351FI";
            tlpPrincipal_351FI.Padding = new Padding(12);
            tlpPrincipal_351FI.RowCount = 2;
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Absolute, 56.0F));
            tlpPrincipal_351FI.Size = new Size(1100, 640);
            tlpPrincipal_351FI.TabIndex = 0;
            tlpPrincipal_351FI.SetColumnSpan(pnlAcciones_351FI, 2);
            // 
            // crdSocio
            // 
            crdSocio_351FI.Controls.Add(lblSeccionSocio_351FI);
            crdSocio_351FI.Controls.Add(lblDni_351FI);
            crdSocio_351FI.Controls.Add(txtDni_351FI);
            crdSocio_351FI.Controls.Add(btnSeleccionarSocio_351FI);
            crdSocio_351FI.Controls.Add(dgvSocios_351FI);
            crdSocio_351FI.Controls.Add(lblSocio_351FI);
            crdSocio_351FI.Dock = DockStyle.Fill;
            crdSocio_351FI.Margin = new Padding(8);
            crdSocio_351FI.Name = "crdSocio_351FI";
            crdSocio_351FI.Size = new Size(468, 544);
            crdSocio_351FI.TabIndex = 0;
            // 
            // lblSeccionSocio
            // 
            lblSeccionSocio_351FI.AutoSize = true;
            lblSeccionSocio_351FI.BackColor = Color.Transparent;
            lblSeccionSocio_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionSocio_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionSocio_351FI.Location = new Point(20, 16);
            lblSeccionSocio_351FI.Name = "lblSeccionSocio_351FI";
            lblSeccionSocio_351FI.Size = new Size(40, 20);
            lblSeccionSocio_351FI.TabIndex = 0;
            lblSeccionSocio_351FI.Text = "Socio";
            // 
            // lblDni
            // 
            lblDni_351FI.AutoSize = true;
            lblDni_351FI.BackColor = Color.Transparent;
            lblDni_351FI.Font = new Font("Segoe UI", 10F);
            lblDni_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblDni_351FI.Location = new Point(20, 52);
            lblDni_351FI.Name = "lblDni_351FI";
            lblDni_351FI.Size = new Size(376, 20);
            lblDni_351FI.TabIndex = 1;
            lblDni_351FI.Text = "DNI del socio con multas (búsqueda incremental)";
            // 
            // txtDni
            // 
            txtDni_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtDni_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtDni_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDni_351FI.Location = new Point(20, 74);
            txtDni_351FI.Name = "txtDni_351FI";
            txtDni_351FI.PlaceholderText = "Ej.: 35678901";
            txtDni_351FI.Size = new Size(268, 27);
            txtDni_351FI.TabIndex = 2;
            txtDni_351FI.TextChanged += txtDni_351FI_TextChanged;
            // 
            // btnSeleccionarSocio
            // 
            btnSeleccionarSocio_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnSeleccionarSocio_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnSeleccionarSocio_351FI.Icono_351FI = "\uE73E";
            btnSeleccionarSocio_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSeleccionarSocio_351FI.Location = new Point(298, 71);
            btnSeleccionarSocio_351FI.Name = "btnSeleccionarSocio_351FI";
            btnSeleccionarSocio_351FI.Size = new Size(150, 32);
            btnSeleccionarSocio_351FI.TabIndex = 3;
            btnSeleccionarSocio_351FI.Text = "Seleccionar";
            btnSeleccionarSocio_351FI.Click += btnSeleccionarSocio_351FI_Click;
            // 
            // dgvSocios
            // 
            dgvSocios_351FI.Columns.AddRange(new DataGridViewColumn[] { colSocNumero_351FI, colSocApellido_351FI, colSocNombre_351FI, colSocDni_351FI, colSocMonto_351FI });
            dgvSocios_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSocios_351FI.Location = new Point(20, 116);
            dgvSocios_351FI.Name = "dgvSocios_351FI";
            dgvSocios_351FI.Size = new Size(428, 374);
            dgvSocios_351FI.TabIndex = 4;
            // 
            // colSocNumero
            // 
            colSocNumero_351FI.FillWeight = 12F;
            colSocNumero_351FI.HeaderText = "Número";
            colSocNumero_351FI.Name = "colSocNumero_351FI";
            colSocNumero_351FI.ReadOnly = true;
            // 
            // colSocApellido
            // 
            colSocApellido_351FI.FillWeight = 24F;
            colSocApellido_351FI.HeaderText = "Apellido";
            colSocApellido_351FI.Name = "colSocApellido_351FI";
            colSocApellido_351FI.ReadOnly = true;
            // 
            // colSocNombre
            // 
            colSocNombre_351FI.FillWeight = 24F;
            colSocNombre_351FI.HeaderText = "Nombre";
            colSocNombre_351FI.Name = "colSocNombre_351FI";
            colSocNombre_351FI.ReadOnly = true;
            // 
            // colSocDni
            // 
            colSocDni_351FI.FillWeight = 18F;
            colSocDni_351FI.HeaderText = "DNI";
            colSocDni_351FI.Name = "colSocDni_351FI";
            colSocDni_351FI.ReadOnly = true;
            // 
            // colSocMonto
            // 
            colSocMonto_351FI.FillWeight = 22F;
            colSocMonto_351FI.HeaderText = "Adeudado ($)";
            colSocMonto_351FI.Name = "colSocMonto_351FI";
            colSocMonto_351FI.ReadOnly = true;
            dgvSocios_351FI.CellDoubleClick += dgvSocios_351FI_CellDoubleClick;
            // 
            // lblSocio
            // 
            lblSocio_351FI.AutoSize = true;
            lblSocio_351FI.BackColor = Color.Transparent;
            lblSocio_351FI.Font = new Font("Segoe UI", 11F);
            lblSocio_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSocio_351FI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSocio_351FI.Location = new Point(20, 504);
            lblSocio_351FI.Name = "lblSocio_351FI";
            lblSocio_351FI.Size = new Size(64, 20);
            lblSocio_351FI.TabIndex = 5;
            lblSocio_351FI.Text = "Socio: —";
            // 
            // crdMultas
            // 
            crdMultas_351FI.Controls.Add(lblSeccionMultas_351FI);
            crdMultas_351FI.Controls.Add(dgvMultas_351FI);
            crdMultas_351FI.Controls.Add(lblMetodoPago_351FI);
            crdMultas_351FI.Controls.Add(cmbMetodoPago_351FI);
            crdMultas_351FI.Controls.Add(lblNumeroTarjeta_351FI);
            crdMultas_351FI.Controls.Add(txtNumeroTarjeta_351FI);
            crdMultas_351FI.Controls.Add(lblTotal_351FI);
            crdMultas_351FI.Dock = DockStyle.Fill;
            crdMultas_351FI.Margin = new Padding(8);
            crdMultas_351FI.Name = "crdMultas_351FI";
            crdMultas_351FI.Size = new Size(576, 544);
            crdMultas_351FI.TabIndex = 1;
            // 
            // lblSeccionMultas
            // 
            lblSeccionMultas_351FI.AutoSize = true;
            lblSeccionMultas_351FI.BackColor = Color.Transparent;
            lblSeccionMultas_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionMultas_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionMultas_351FI.Location = new Point(20, 16);
            lblSeccionMultas_351FI.Name = "lblSeccionMultas_351FI";
            lblSeccionMultas_351FI.Size = new Size(200, 20);
            lblSeccionMultas_351FI.TabIndex = 0;
            lblSeccionMultas_351FI.Text = "Multas pendientes de pago";
            // 
            // dgvMultas
            // 
            dgvMultas_351FI.Columns.AddRange(new DataGridViewColumn[] { colMulNumero_351FI, colMulPrestamo_351FI, colMulFecha_351FI, colMulDias_351FI, colMulMonto_351FI });
            dgvMultas_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMultas_351FI.Location = new Point(20, 52);
            dgvMultas_351FI.Name = "dgvMultas_351FI";
            dgvMultas_351FI.Size = new Size(536, 330);
            dgvMultas_351FI.TabIndex = 1;
            // 
            // colMulNumero
            // 
            colMulNumero_351FI.FillWeight = 15F;
            colMulNumero_351FI.HeaderText = "N° multa";
            colMulNumero_351FI.Name = "colMulNumero_351FI";
            colMulNumero_351FI.ReadOnly = true;
            // 
            // colMulPrestamo
            // 
            colMulPrestamo_351FI.FillWeight = 15F;
            colMulPrestamo_351FI.HeaderText = "Préstamo";
            colMulPrestamo_351FI.Name = "colMulPrestamo_351FI";
            colMulPrestamo_351FI.ReadOnly = true;
            // 
            // colMulFecha
            // 
            colMulFecha_351FI.FillWeight = 25F;
            colMulFecha_351FI.HeaderText = "Fecha de generación";
            colMulFecha_351FI.Name = "colMulFecha_351FI";
            colMulFecha_351FI.ReadOnly = true;
            // 
            // colMulDias
            // 
            colMulDias_351FI.FillWeight = 20F;
            colMulDias_351FI.HeaderText = "Días de atraso";
            colMulDias_351FI.Name = "colMulDias_351FI";
            colMulDias_351FI.ReadOnly = true;
            // 
            // colMulMonto
            // 
            colMulMonto_351FI.FillWeight = 25F;
            colMulMonto_351FI.HeaderText = "Monto ($)";
            colMulMonto_351FI.Name = "colMulMonto_351FI";
            colMulMonto_351FI.ReadOnly = true;
            //
            // lblMetodoPago
            //
            lblMetodoPago_351FI.AutoSize = true;
            lblMetodoPago_351FI.BackColor = Color.Transparent;
            lblMetodoPago_351FI.Font = new Font("Segoe UI", 10F);
            lblMetodoPago_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblMetodoPago_351FI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMetodoPago_351FI.Location = new Point(20, 400);
            lblMetodoPago_351FI.Name = "lblMetodoPago_351FI";
            lblMetodoPago_351FI.Size = new Size(100, 20);
            lblMetodoPago_351FI.TabIndex = 3;
            lblMetodoPago_351FI.Text = "Método de pago";
            //
            // cmbMetodoPago
            //
            cmbMetodoPago_351FI.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            cmbMetodoPago_351FI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbMetodoPago_351FI.Location = new Point(170, 396);
            cmbMetodoPago_351FI.Name = "cmbMetodoPago_351FI";
            cmbMetodoPago_351FI.Size = new Size(200, 28);
            cmbMetodoPago_351FI.TabIndex = 4;
            cmbMetodoPago_351FI.SelectedIndexChanged += cmbMetodoPago_351FI_SelectedIndexChanged;
            //
            // lblNumeroTarjeta
            //
            lblNumeroTarjeta_351FI.AutoSize = true;
            lblNumeroTarjeta_351FI.BackColor = Color.Transparent;
            lblNumeroTarjeta_351FI.Font = new Font("Segoe UI", 10F);
            lblNumeroTarjeta_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblNumeroTarjeta_351FI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNumeroTarjeta_351FI.Location = new Point(20, 442);
            lblNumeroTarjeta_351FI.Name = "lblNumeroTarjeta_351FI";
            lblNumeroTarjeta_351FI.Size = new Size(120, 20);
            lblNumeroTarjeta_351FI.TabIndex = 5;
            lblNumeroTarjeta_351FI.Text = "Número de tarjeta";
            lblNumeroTarjeta_351FI.Visible = false;
            //
            // txtNumeroTarjeta
            //
            txtNumeroTarjeta_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroTarjeta_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtNumeroTarjeta_351FI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtNumeroTarjeta_351FI.Location = new Point(170, 438);
            txtNumeroTarjeta_351FI.MaxLength = 23;
            txtNumeroTarjeta_351FI.Name = "txtNumeroTarjeta_351FI";
            txtNumeroTarjeta_351FI.Size = new Size(260, 27);
            txtNumeroTarjeta_351FI.TabIndex = 6;
            txtNumeroTarjeta_351FI.UseSystemPasswordChar = true;
            txtNumeroTarjeta_351FI.Visible = false;
            //
            // lblTotal
            //
            lblTotal_351FI.AutoSize = false;
            lblTotal_351FI.BackColor = Color.Transparent;
            lblTotal_351FI.Font = new Font("Segoe UI Semibold", 15F);
            lblTotal_351FI.ForeColor = Color.FromArgb(123, 30, 46);
            lblTotal_351FI.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal_351FI.Location = new Point(136, 486);
            lblTotal_351FI.Name = "lblTotal_351FI";
            lblTotal_351FI.Size = new Size(420, 36);
            lblTotal_351FI.TabIndex = 2;
            lblTotal_351FI.Text = "Total adeudado: $ 0,00";
            lblTotal_351FI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlAcciones
            // 
            pnlAcciones_351FI.BackColor = Color.Transparent;
            pnlAcciones_351FI.Controls.Add(btnConfirmarCobro_351FI);
            pnlAcciones_351FI.Controls.Add(btnNoAbona_351FI);
            pnlAcciones_351FI.FlowDirection = FlowDirection.RightToLeft;
            pnlAcciones_351FI.WrapContents = false;
            pnlAcciones_351FI.Dock = DockStyle.Fill;
            pnlAcciones_351FI.Margin = new Padding(8);
            pnlAcciones_351FI.Name = "pnlAcciones_351FI";
            pnlAcciones_351FI.Size = new Size(400, 40);
            pnlAcciones_351FI.TabIndex = 2;
            // 
            // btnConfirmarCobro
            // 
            btnConfirmarCobro_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnConfirmarCobro_351FI.Icono_351FI = "\uE73E";
            btnConfirmarCobro_351FI.Margin = new Padding(12, 0, 0, 0);
            btnConfirmarCobro_351FI.Name = "btnConfirmarCobro_351FI";
            btnConfirmarCobro_351FI.Size = new Size(200, 40);
            btnConfirmarCobro_351FI.TabIndex = 0;
            btnConfirmarCobro_351FI.Text = "Confirmar cobro";
            btnConfirmarCobro_351FI.Click += btnConfirmarCobro_351FI_Click;
            // 
            // btnNoAbona
            // 
            btnNoAbona_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnNoAbona_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnNoAbona_351FI.Icono_351FI = "\uE711";
            btnNoAbona_351FI.Margin = new Padding(12, 0, 0, 0);
            btnNoAbona_351FI.Name = "btnNoAbona_351FI";
            btnNoAbona_351FI.Size = new Size(210, 40);
            btnNoAbona_351FI.TabIndex = 1;
            btnNoAbona_351FI.Text = "El socio no abona";
            btnNoAbona_351FI.Click += btnNoAbona_351FI_Click;
            // 
            // FormMulta
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal_351FI);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMulta_351FI";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cobrar multas";
            Load += FormMulta_351FI_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios_351FI).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMultas_351FI).EndInit();
            pnlAcciones_351FI.ResumeLayout(false);
            pnlAcciones_351FI.PerformLayout();
            crdMultas_351FI.ResumeLayout(false);
            crdMultas_351FI.PerformLayout();
            crdSocio_351FI.ResumeLayout(false);
            crdSocio_351FI.PerformLayout();
            tlpPrincipal_351FI.ResumeLayout(false);
            tlpPrincipal_351FI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal_351FI;
        private TarjetaSGB_351FI crdSocio_351FI;
        private Label lblSeccionSocio_351FI;
        private Label lblDni_351FI;
        private TextBox txtDni_351FI;
        private BotonSGB_351FI btnSeleccionarSocio_351FI;
        private GrillaSGB_351FI dgvSocios_351FI;
        private DataGridViewTextBoxColumn colSocNumero_351FI;
        private DataGridViewTextBoxColumn colSocApellido_351FI;
        private DataGridViewTextBoxColumn colSocNombre_351FI;
        private DataGridViewTextBoxColumn colSocDni_351FI;
        private DataGridViewTextBoxColumn colSocMonto_351FI;
        private Label lblSocio_351FI;
        private TarjetaSGB_351FI crdMultas_351FI;
        private Label lblSeccionMultas_351FI;
        private GrillaSGB_351FI dgvMultas_351FI;
        private DataGridViewTextBoxColumn colMulNumero_351FI;
        private DataGridViewTextBoxColumn colMulPrestamo_351FI;
        private DataGridViewTextBoxColumn colMulFecha_351FI;
        private DataGridViewTextBoxColumn colMulDias_351FI;
        private DataGridViewTextBoxColumn colMulMonto_351FI;
        private Label lblMetodoPago_351FI;
        private ComboBox cmbMetodoPago_351FI;
        private Label lblNumeroTarjeta_351FI;
        private TextBox txtNumeroTarjeta_351FI;
        private Label lblTotal_351FI;
        private FlowLayoutPanel pnlAcciones_351FI;
        private BotonSGB_351FI btnConfirmarCobro_351FI;
        private BotonSGB_351FI btnNoAbona_351FI;
    }
}
