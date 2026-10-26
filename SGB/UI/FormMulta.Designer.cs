using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormMulta
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
            crdSocio = new TarjetaSGB();
            lblSeccionSocio = new Label();
            lblDni = new Label();
            txtDni = new TextBox();
            btnSeleccionarSocio = new BotonSGB();
            dgvSocios = new GrillaSGB();
            colSocNumero = new DataGridViewTextBoxColumn();
            colSocApellido = new DataGridViewTextBoxColumn();
            colSocNombre = new DataGridViewTextBoxColumn();
            colSocDni = new DataGridViewTextBoxColumn();
            colSocMonto = new DataGridViewTextBoxColumn();
            lblSocio = new Label();
            crdMultas = new TarjetaSGB();
            lblSeccionMultas = new Label();
            dgvMultas = new GrillaSGB();
            colMulNumero = new DataGridViewTextBoxColumn();
            colMulPrestamo = new DataGridViewTextBoxColumn();
            colMulFecha = new DataGridViewTextBoxColumn();
            colMulDias = new DataGridViewTextBoxColumn();
            colMulMonto = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            pnlAcciones = new FlowLayoutPanel();
            btnConfirmarCobro = new BotonSGB();
            btnNoAbona = new BotonSGB();
            tlpPrincipal.SuspendLayout();
            crdSocio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            crdMultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMultas).BeginInit();
            pnlAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal.ColumnCount = 2;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.0F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.0F));
            tlpPrincipal.Controls.Add(crdSocio, 0, 0);
            tlpPrincipal.Controls.Add(crdMultas, 1, 0);
            tlpPrincipal.Controls.Add(pnlAcciones, 0, 1);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(12);
            tlpPrincipal.RowCount = 2;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 56.0F));
            tlpPrincipal.Size = new Size(1100, 640);
            tlpPrincipal.TabIndex = 0;
            tlpPrincipal.SetColumnSpan(pnlAcciones, 2);
            // 
            // crdSocio
            // 
            crdSocio.Controls.Add(lblSeccionSocio);
            crdSocio.Controls.Add(lblDni);
            crdSocio.Controls.Add(txtDni);
            crdSocio.Controls.Add(btnSeleccionarSocio);
            crdSocio.Controls.Add(dgvSocios);
            crdSocio.Controls.Add(lblSocio);
            crdSocio.Dock = DockStyle.Fill;
            crdSocio.Margin = new Padding(8);
            crdSocio.Name = "crdSocio";
            crdSocio.Size = new Size(468, 544);
            crdSocio.TabIndex = 0;
            // 
            // lblSeccionSocio
            // 
            lblSeccionSocio.AutoSize = true;
            lblSeccionSocio.BackColor = Color.Transparent;
            lblSeccionSocio.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionSocio.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionSocio.Location = new Point(20, 16);
            lblSeccionSocio.Name = "lblSeccionSocio";
            lblSeccionSocio.Size = new Size(40, 20);
            lblSeccionSocio.TabIndex = 0;
            lblSeccionSocio.Text = "Socio";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.Transparent;
            lblDni.Font = new Font("Segoe UI", 10F);
            lblDni.ForeColor = Color.FromArgb(75, 85, 99);
            lblDni.Location = new Point(20, 52);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(376, 20);
            lblDni.TabIndex = 1;
            lblDni.Text = "DNI del socio con multas (búsqueda incremental)";
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.ForeColor = Color.FromArgb(31, 41, 55);
            txtDni.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDni.Location = new Point(20, 74);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ej.: 35678901";
            txtDni.Size = new Size(268, 27);
            txtDni.TabIndex = 2;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // btnSeleccionarSocio
            // 
            btnSeleccionarSocio.Estilo = EstiloBoton.Secundario;
            btnSeleccionarSocio.Font = new Font("Segoe UI Semibold", 10.5F);
            btnSeleccionarSocio.Icono = "\uE73E";
            btnSeleccionarSocio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSeleccionarSocio.Location = new Point(298, 71);
            btnSeleccionarSocio.Name = "btnSeleccionarSocio";
            btnSeleccionarSocio.Size = new Size(150, 32);
            btnSeleccionarSocio.TabIndex = 3;
            btnSeleccionarSocio.Text = "Seleccionar";
            btnSeleccionarSocio.Click += btnSeleccionarSocio_Click;
            // 
            // dgvSocios
            // 
            dgvSocios.Columns.AddRange(new DataGridViewColumn[] { colSocNumero, colSocApellido, colSocNombre, colSocDni, colSocMonto });
            dgvSocios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSocios.Location = new Point(20, 116);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.Size = new Size(428, 374);
            dgvSocios.TabIndex = 4;
            // 
            // colSocNumero
            // 
            colSocNumero.FillWeight = 12F;
            colSocNumero.HeaderText = "Número";
            colSocNumero.Name = "colSocNumero";
            colSocNumero.ReadOnly = true;
            // 
            // colSocApellido
            // 
            colSocApellido.FillWeight = 24F;
            colSocApellido.HeaderText = "Apellido";
            colSocApellido.Name = "colSocApellido";
            colSocApellido.ReadOnly = true;
            // 
            // colSocNombre
            // 
            colSocNombre.FillWeight = 24F;
            colSocNombre.HeaderText = "Nombre";
            colSocNombre.Name = "colSocNombre";
            colSocNombre.ReadOnly = true;
            // 
            // colSocDni
            // 
            colSocDni.FillWeight = 18F;
            colSocDni.HeaderText = "DNI";
            colSocDni.Name = "colSocDni";
            colSocDni.ReadOnly = true;
            // 
            // colSocMonto
            // 
            colSocMonto.FillWeight = 22F;
            colSocMonto.HeaderText = "Adeudado ($)";
            colSocMonto.Name = "colSocMonto";
            colSocMonto.ReadOnly = true;
            dgvSocios.CellDoubleClick += dgvSocios_CellDoubleClick;
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.BackColor = Color.Transparent;
            lblSocio.Font = new Font("Segoe UI", 11F);
            lblSocio.ForeColor = Color.FromArgb(31, 41, 55);
            lblSocio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSocio.Location = new Point(20, 504);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(64, 20);
            lblSocio.TabIndex = 5;
            lblSocio.Text = "Socio: —";
            // 
            // crdMultas
            // 
            crdMultas.Controls.Add(lblSeccionMultas);
            crdMultas.Controls.Add(dgvMultas);
            crdMultas.Controls.Add(lblTotal);
            crdMultas.Dock = DockStyle.Fill;
            crdMultas.Margin = new Padding(8);
            crdMultas.Name = "crdMultas";
            crdMultas.Size = new Size(576, 544);
            crdMultas.TabIndex = 1;
            // 
            // lblSeccionMultas
            // 
            lblSeccionMultas.AutoSize = true;
            lblSeccionMultas.BackColor = Color.Transparent;
            lblSeccionMultas.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionMultas.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionMultas.Location = new Point(20, 16);
            lblSeccionMultas.Name = "lblSeccionMultas";
            lblSeccionMultas.Size = new Size(200, 20);
            lblSeccionMultas.TabIndex = 0;
            lblSeccionMultas.Text = "Multas pendientes de pago";
            // 
            // dgvMultas
            // 
            dgvMultas.Columns.AddRange(new DataGridViewColumn[] { colMulNumero, colMulPrestamo, colMulFecha, colMulDias, colMulMonto });
            dgvMultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMultas.Location = new Point(20, 52);
            dgvMultas.Name = "dgvMultas";
            dgvMultas.Size = new Size(536, 420);
            dgvMultas.TabIndex = 1;
            // 
            // colMulNumero
            // 
            colMulNumero.FillWeight = 15F;
            colMulNumero.HeaderText = "N° multa";
            colMulNumero.Name = "colMulNumero";
            colMulNumero.ReadOnly = true;
            // 
            // colMulPrestamo
            // 
            colMulPrestamo.FillWeight = 15F;
            colMulPrestamo.HeaderText = "Préstamo";
            colMulPrestamo.Name = "colMulPrestamo";
            colMulPrestamo.ReadOnly = true;
            // 
            // colMulFecha
            // 
            colMulFecha.FillWeight = 25F;
            colMulFecha.HeaderText = "Fecha de generación";
            colMulFecha.Name = "colMulFecha";
            colMulFecha.ReadOnly = true;
            // 
            // colMulDias
            // 
            colMulDias.FillWeight = 20F;
            colMulDias.HeaderText = "Días de atraso";
            colMulDias.Name = "colMulDias";
            colMulDias.ReadOnly = true;
            // 
            // colMulMonto
            // 
            colMulMonto.FillWeight = 25F;
            colMulMonto.HeaderText = "Monto ($)";
            colMulMonto.Name = "colMulMonto";
            colMulMonto.ReadOnly = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = false;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI Semibold", 15F);
            lblTotal.ForeColor = Color.FromArgb(123, 30, 46);
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.Location = new Point(136, 486);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(420, 36);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total adeudado: $ 0,00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlAcciones
            // 
            pnlAcciones.BackColor = Color.Transparent;
            pnlAcciones.Controls.Add(btnConfirmarCobro);
            pnlAcciones.Controls.Add(btnNoAbona);
            pnlAcciones.FlowDirection = FlowDirection.RightToLeft;
            pnlAcciones.WrapContents = false;
            pnlAcciones.Dock = DockStyle.Fill;
            pnlAcciones.Margin = new Padding(8);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(400, 40);
            pnlAcciones.TabIndex = 2;
            // 
            // btnConfirmarCobro
            // 
            btnConfirmarCobro.Font = new Font("Segoe UI Semibold", 10.5F);
            btnConfirmarCobro.Icono = "\uE73E";
            btnConfirmarCobro.Margin = new Padding(12, 0, 0, 0);
            btnConfirmarCobro.Name = "btnConfirmarCobro";
            btnConfirmarCobro.Size = new Size(200, 40);
            btnConfirmarCobro.TabIndex = 0;
            btnConfirmarCobro.Text = "Confirmar cobro";
            btnConfirmarCobro.Click += btnConfirmarCobro_Click;
            // 
            // btnNoAbona
            // 
            btnNoAbona.Estilo = EstiloBoton.Secundario;
            btnNoAbona.Font = new Font("Segoe UI Semibold", 10.5F);
            btnNoAbona.Icono = "\uE711";
            btnNoAbona.Margin = new Padding(12, 0, 0, 0);
            btnNoAbona.Name = "btnNoAbona";
            btnNoAbona.Size = new Size(210, 40);
            btnNoAbona.TabIndex = 1;
            btnNoAbona.Text = "El socio no abona";
            btnNoAbona.Click += btnNoAbona_Click;
            // 
            // FormMulta
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMulta";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cobrar multas";
            Load += FormMulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMultas).EndInit();
            pnlAcciones.ResumeLayout(false);
            pnlAcciones.PerformLayout();
            crdMultas.ResumeLayout(false);
            crdMultas.PerformLayout();
            crdSocio.ResumeLayout(false);
            crdSocio.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TarjetaSGB crdSocio;
        private Label lblSeccionSocio;
        private Label lblDni;
        private TextBox txtDni;
        private BotonSGB btnSeleccionarSocio;
        private GrillaSGB dgvSocios;
        private DataGridViewTextBoxColumn colSocNumero;
        private DataGridViewTextBoxColumn colSocApellido;
        private DataGridViewTextBoxColumn colSocNombre;
        private DataGridViewTextBoxColumn colSocDni;
        private DataGridViewTextBoxColumn colSocMonto;
        private Label lblSocio;
        private TarjetaSGB crdMultas;
        private Label lblSeccionMultas;
        private GrillaSGB dgvMultas;
        private DataGridViewTextBoxColumn colMulNumero;
        private DataGridViewTextBoxColumn colMulPrestamo;
        private DataGridViewTextBoxColumn colMulFecha;
        private DataGridViewTextBoxColumn colMulDias;
        private DataGridViewTextBoxColumn colMulMonto;
        private Label lblTotal;
        private FlowLayoutPanel pnlAcciones;
        private BotonSGB btnConfirmarCobro;
        private BotonSGB btnNoAbona;
    }
}
