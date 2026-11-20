using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormControlCambios_351FI
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
            DataGridViewCellStyle estiloFecha = new DataGridViewCellStyle();
            tlpPrincipal_351FI = new TableLayoutPanel();
            crdVersiones_351FI = new TarjetaSGB_351FI();
            lblSeccionVersiones_351FI = new Label();
            lblNumeroSocio_351FI = new Label();
            txtNumeroSocio_351FI = new TextBox();
            lblApellido_351FI = new Label();
            txtApellido_351FI = new TextBox();
            lblFechaDesde_351FI = new Label();
            dtpFechaDesde_351FI = new DateTimePicker();
            lblFechaHasta_351FI = new Label();
            dtpFechaHasta_351FI = new DateTimePicker();
            btnFiltrar_351FI = new BotonSGB_351FI();
            dgvVersiones_351FI = new GrillaSGB_351FI();
            colVerVersion_351FI = new DataGridViewTextBoxColumn();
            colVerSocio_351FI = new DataGridViewTextBoxColumn();
            colVerApellido_351FI = new DataGridViewTextBoxColumn();
            colVerNombre_351FI = new DataGridViewTextBoxColumn();
            colVerDni_351FI = new DataGridViewTextBoxColumn();
            colVerEstado_351FI = new DataGridViewTextBoxColumn();
            colVerFecha_351FI = new DataGridViewTextBoxColumn();
            colVerHora_351FI = new DataGridViewTextBoxColumn();
            colVerActiva_351FI = new DataGridViewCheckBoxColumn();
            btnActivar_351FI = new BotonSGB_351FI();
            crdSocios_351FI = new TarjetaSGB_351FI();
            lblSeccionSocios_351FI = new Label();
            dgvSocios_351FI = new GrillaSGB_351FI();
            colSocNumero_351FI = new DataGridViewTextBoxColumn();
            colSocApellido_351FI = new DataGridViewTextBoxColumn();
            colSocNombre_351FI = new DataGridViewTextBoxColumn();
            colSocDni_351FI = new DataGridViewTextBoxColumn();
            colSocEstado_351FI = new DataGridViewTextBoxColumn();
            pnlAcciones_351FI = new FlowLayoutPanel();
            btnCerrar_351FI = new BotonSGB_351FI();
            tlpPrincipal_351FI.SuspendLayout();
            crdVersiones_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVersiones_351FI).BeginInit();
            crdSocios_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios_351FI).BeginInit();
            pnlAcciones_351FI.SuspendLayout();
            SuspendLayout();
            //
            // tlpPrincipal
            //
            tlpPrincipal_351FI.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal_351FI.ColumnCount = 2;
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.0F));
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.0F));
            tlpPrincipal_351FI.Controls.Add(crdVersiones_351FI, 0, 0);
            tlpPrincipal_351FI.Controls.Add(crdSocios_351FI, 1, 0);
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
            // crdVersiones
            //
            crdVersiones_351FI.Controls.Add(lblSeccionVersiones_351FI);
            crdVersiones_351FI.Controls.Add(lblNumeroSocio_351FI);
            crdVersiones_351FI.Controls.Add(txtNumeroSocio_351FI);
            crdVersiones_351FI.Controls.Add(lblApellido_351FI);
            crdVersiones_351FI.Controls.Add(txtApellido_351FI);
            crdVersiones_351FI.Controls.Add(lblFechaDesde_351FI);
            crdVersiones_351FI.Controls.Add(dtpFechaDesde_351FI);
            crdVersiones_351FI.Controls.Add(lblFechaHasta_351FI);
            crdVersiones_351FI.Controls.Add(dtpFechaHasta_351FI);
            crdVersiones_351FI.Controls.Add(btnFiltrar_351FI);
            crdVersiones_351FI.Controls.Add(dgvVersiones_351FI);
            crdVersiones_351FI.Controls.Add(btnActivar_351FI);
            crdVersiones_351FI.Dock = DockStyle.Fill;
            crdVersiones_351FI.Margin = new Padding(8);
            crdVersiones_351FI.Name = "crdVersiones_351FI";
            crdVersiones_351FI.Size = new Size(673, 544);
            crdVersiones_351FI.TabIndex = 0;
            //
            // lblSeccionVersiones
            //
            lblSeccionVersiones_351FI.AutoSize = true;
            lblSeccionVersiones_351FI.BackColor = Color.Transparent;
            lblSeccionVersiones_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionVersiones_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionVersiones_351FI.Location = new Point(20, 16);
            lblSeccionVersiones_351FI.Name = "lblSeccionVersiones_351FI";
            lblSeccionVersiones_351FI.Size = new Size(170, 20);
            lblSeccionVersiones_351FI.TabIndex = 0;
            lblSeccionVersiones_351FI.Text = "Versiones de los socios";
            //
            // lblNumeroSocio
            //
            lblNumeroSocio_351FI.AutoSize = true;
            lblNumeroSocio_351FI.BackColor = Color.Transparent;
            lblNumeroSocio_351FI.Font = new Font("Segoe UI", 10F);
            lblNumeroSocio_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblNumeroSocio_351FI.Location = new Point(20, 52);
            lblNumeroSocio_351FI.Name = "lblNumeroSocio_351FI";
            lblNumeroSocio_351FI.Size = new Size(120, 20);
            lblNumeroSocio_351FI.TabIndex = 1;
            lblNumeroSocio_351FI.Text = "Número de socio";
            //
            // txtNumeroSocio
            //
            txtNumeroSocio_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroSocio_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtNumeroSocio_351FI.Location = new Point(20, 74);
            txtNumeroSocio_351FI.MaxLength = 9;
            txtNumeroSocio_351FI.Name = "txtNumeroSocio_351FI";
            txtNumeroSocio_351FI.Size = new Size(140, 27);
            txtNumeroSocio_351FI.TabIndex = 2;
            //
            // lblApellido
            //
            lblApellido_351FI.AutoSize = true;
            lblApellido_351FI.BackColor = Color.Transparent;
            lblApellido_351FI.Font = new Font("Segoe UI", 10F);
            lblApellido_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblApellido_351FI.Location = new Point(176, 52);
            lblApellido_351FI.Name = "lblApellido_351FI";
            lblApellido_351FI.Size = new Size(64, 20);
            lblApellido_351FI.TabIndex = 3;
            lblApellido_351FI.Text = "Apellido";
            //
            // txtApellido
            //
            txtApellido_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtApellido_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtApellido_351FI.Location = new Point(176, 74);
            txtApellido_351FI.MaxLength = 50;
            txtApellido_351FI.Name = "txtApellido_351FI";
            txtApellido_351FI.Size = new Size(220, 27);
            txtApellido_351FI.TabIndex = 4;
            //
            // lblFechaDesde
            //
            lblFechaDesde_351FI.AutoSize = true;
            lblFechaDesde_351FI.BackColor = Color.Transparent;
            lblFechaDesde_351FI.Font = new Font("Segoe UI", 10F);
            lblFechaDesde_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblFechaDesde_351FI.Location = new Point(20, 112);
            lblFechaDesde_351FI.Name = "lblFechaDesde_351FI";
            lblFechaDesde_351FI.Size = new Size(90, 20);
            lblFechaDesde_351FI.TabIndex = 5;
            lblFechaDesde_351FI.Text = "Fecha desde";
            //
            // dtpFechaDesde
            //
            dtpFechaDesde_351FI.Format = DateTimePickerFormat.Short;
            dtpFechaDesde_351FI.Location = new Point(20, 134);
            dtpFechaDesde_351FI.Name = "dtpFechaDesde_351FI";
            dtpFechaDesde_351FI.Size = new Size(140, 27);
            dtpFechaDesde_351FI.TabIndex = 6;
            //
            // lblFechaHasta
            //
            lblFechaHasta_351FI.AutoSize = true;
            lblFechaHasta_351FI.BackColor = Color.Transparent;
            lblFechaHasta_351FI.Font = new Font("Segoe UI", 10F);
            lblFechaHasta_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblFechaHasta_351FI.Location = new Point(176, 112);
            lblFechaHasta_351FI.Name = "lblFechaHasta_351FI";
            lblFechaHasta_351FI.Size = new Size(86, 20);
            lblFechaHasta_351FI.TabIndex = 7;
            lblFechaHasta_351FI.Text = "Fecha hasta";
            //
            // dtpFechaHasta
            //
            dtpFechaHasta_351FI.Format = DateTimePickerFormat.Short;
            dtpFechaHasta_351FI.Location = new Point(176, 134);
            dtpFechaHasta_351FI.Name = "dtpFechaHasta_351FI";
            dtpFechaHasta_351FI.Size = new Size(140, 27);
            dtpFechaHasta_351FI.TabIndex = 8;
            //
            // btnFiltrar
            //
            btnFiltrar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnFiltrar_351FI.Icono_351FI = "";
            btnFiltrar_351FI.Location = new Point(332, 128);
            btnFiltrar_351FI.Name = "btnFiltrar_351FI";
            btnFiltrar_351FI.Size = new Size(140, 38);
            btnFiltrar_351FI.TabIndex = 9;
            btnFiltrar_351FI.Text = "Filtrar";
            btnFiltrar_351FI.Click += btnFiltrar_351FI_Click;
            //
            // dgvVersiones
            //
            dgvVersiones_351FI.Columns.AddRange(new DataGridViewColumn[] { colVerVersion_351FI, colVerSocio_351FI, colVerApellido_351FI, colVerNombre_351FI, colVerDni_351FI, colVerEstado_351FI, colVerFecha_351FI, colVerHora_351FI, colVerActiva_351FI });
            dgvVersiones_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVersiones_351FI.Location = new Point(20, 180);
            dgvVersiones_351FI.Name = "dgvVersiones_351FI";
            dgvVersiones_351FI.Size = new Size(633, 296);
            dgvVersiones_351FI.TabIndex = 10;
            //
            // colVerVersion
            //
            colVerVersion_351FI.FillWeight = 10F;
            colVerVersion_351FI.HeaderText = "Versión";
            colVerVersion_351FI.Name = "colVerVersion_351FI";
            colVerVersion_351FI.ReadOnly = true;
            //
            // colVerSocio
            //
            colVerSocio_351FI.FillWeight = 10F;
            colVerSocio_351FI.HeaderText = "Socio";
            colVerSocio_351FI.Name = "colVerSocio_351FI";
            colVerSocio_351FI.ReadOnly = true;
            //
            // colVerApellido
            //
            colVerApellido_351FI.FillWeight = 20F;
            colVerApellido_351FI.HeaderText = "Apellido";
            colVerApellido_351FI.Name = "colVerApellido_351FI";
            colVerApellido_351FI.ReadOnly = true;
            //
            // colVerNombre
            //
            colVerNombre_351FI.FillWeight = 20F;
            colVerNombre_351FI.HeaderText = "Nombre";
            colVerNombre_351FI.Name = "colVerNombre_351FI";
            colVerNombre_351FI.ReadOnly = true;
            //
            // colVerDni
            //
            colVerDni_351FI.FillWeight = 14F;
            colVerDni_351FI.HeaderText = "DNI";
            colVerDni_351FI.Name = "colVerDni_351FI";
            colVerDni_351FI.ReadOnly = true;
            //
            // colVerEstado
            //
            colVerEstado_351FI.FillWeight = 12F;
            colVerEstado_351FI.HeaderText = "Estado";
            colVerEstado_351FI.Name = "colVerEstado_351FI";
            colVerEstado_351FI.ReadOnly = true;
            //
            // colVerFecha
            //
            estiloFecha.Format = "dd/MM/yyyy";
            colVerFecha_351FI.DefaultCellStyle = estiloFecha;
            colVerFecha_351FI.FillWeight = 14F;
            colVerFecha_351FI.HeaderText = "Fecha";
            colVerFecha_351FI.Name = "colVerFecha_351FI";
            colVerFecha_351FI.ReadOnly = true;
            //
            // colVerHora
            //
            colVerHora_351FI.FillWeight = 12F;
            colVerHora_351FI.HeaderText = "Hora";
            colVerHora_351FI.Name = "colVerHora_351FI";
            colVerHora_351FI.ReadOnly = true;
            //
            // colVerActiva
            //
            colVerActiva_351FI.FillWeight = 10F;
            colVerActiva_351FI.HeaderText = "Vigente";
            colVerActiva_351FI.Name = "colVerActiva_351FI";
            colVerActiva_351FI.ReadOnly = true;
            //
            // btnActivar
            //
            btnActivar_351FI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnActivar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnActivar_351FI.Icono_351FI = "";
            btnActivar_351FI.Location = new Point(20, 488);
            btnActivar_351FI.Name = "btnActivar_351FI";
            btnActivar_351FI.Size = new Size(260, 40);
            btnActivar_351FI.TabIndex = 11;
            btnActivar_351FI.Text = "Activar versión seleccionada";
            btnActivar_351FI.Click += btnActivar_351FI_Click;
            //
            // crdSocios
            //
            crdSocios_351FI.Controls.Add(lblSeccionSocios_351FI);
            crdSocios_351FI.Controls.Add(dgvSocios_351FI);
            crdSocios_351FI.Dock = DockStyle.Fill;
            crdSocios_351FI.Margin = new Padding(8);
            crdSocios_351FI.Name = "crdSocios_351FI";
            crdSocios_351FI.Size = new Size(371, 544);
            crdSocios_351FI.TabIndex = 1;
            //
            // lblSeccionSocios
            //
            lblSeccionSocios_351FI.AutoSize = true;
            lblSeccionSocios_351FI.BackColor = Color.Transparent;
            lblSeccionSocios_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionSocios_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionSocios_351FI.Location = new Point(20, 16);
            lblSeccionSocios_351FI.Name = "lblSeccionSocios_351FI";
            lblSeccionSocios_351FI.Size = new Size(170, 20);
            lblSeccionSocios_351FI.TabIndex = 0;
            lblSeccionSocios_351FI.Text = "Datos vigentes de los socios";
            //
            // dgvSocios
            //
            dgvSocios_351FI.Columns.AddRange(new DataGridViewColumn[] { colSocNumero_351FI, colSocApellido_351FI, colSocNombre_351FI, colSocDni_351FI, colSocEstado_351FI });
            dgvSocios_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSocios_351FI.Location = new Point(20, 52);
            dgvSocios_351FI.Name = "dgvSocios_351FI";
            dgvSocios_351FI.Size = new Size(331, 472);
            dgvSocios_351FI.TabIndex = 1;
            //
            // colSocNumero
            //
            colSocNumero_351FI.FillWeight = 15F;
            colSocNumero_351FI.HeaderText = "Número";
            colSocNumero_351FI.Name = "colSocNumero_351FI";
            colSocNumero_351FI.ReadOnly = true;
            //
            // colSocApellido
            //
            colSocApellido_351FI.FillWeight = 25F;
            colSocApellido_351FI.HeaderText = "Apellido";
            colSocApellido_351FI.Name = "colSocApellido_351FI";
            colSocApellido_351FI.ReadOnly = true;
            //
            // colSocNombre
            //
            colSocNombre_351FI.FillWeight = 25F;
            colSocNombre_351FI.HeaderText = "Nombre";
            colSocNombre_351FI.Name = "colSocNombre_351FI";
            colSocNombre_351FI.ReadOnly = true;
            //
            // colSocDni
            //
            colSocDni_351FI.FillWeight = 20F;
            colSocDni_351FI.HeaderText = "DNI";
            colSocDni_351FI.Name = "colSocDni_351FI";
            colSocDni_351FI.ReadOnly = true;
            //
            // colSocEstado
            //
            colSocEstado_351FI.FillWeight = 15F;
            colSocEstado_351FI.HeaderText = "Estado";
            colSocEstado_351FI.Name = "colSocEstado_351FI";
            colSocEstado_351FI.ReadOnly = true;
            //
            // pnlAcciones
            //
            pnlAcciones_351FI.BackColor = Color.Transparent;
            pnlAcciones_351FI.Controls.Add(btnCerrar_351FI);
            pnlAcciones_351FI.FlowDirection = FlowDirection.RightToLeft;
            pnlAcciones_351FI.WrapContents = false;
            pnlAcciones_351FI.Dock = DockStyle.Fill;
            pnlAcciones_351FI.Margin = new Padding(8);
            pnlAcciones_351FI.Name = "pnlAcciones_351FI";
            pnlAcciones_351FI.Size = new Size(400, 40);
            pnlAcciones_351FI.TabIndex = 2;
            //
            // btnCerrar
            //
            btnCerrar_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnCerrar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnCerrar_351FI.Icono_351FI = "";
            btnCerrar_351FI.Margin = new Padding(12, 0, 0, 0);
            btnCerrar_351FI.Name = "btnCerrar_351FI";
            btnCerrar_351FI.Size = new Size(140, 40);
            btnCerrar_351FI.TabIndex = 0;
            btnCerrar_351FI.Text = "Cerrar";
            btnCerrar_351FI.Click += btnCerrar_351FI_Click;
            //
            // FormControlCambios
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal_351FI);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormControlCambios_351FI";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de cambios";
            Load += FormControlCambios_351FI_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVersiones_351FI).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSocios_351FI).EndInit();
            pnlAcciones_351FI.ResumeLayout(false);
            crdSocios_351FI.ResumeLayout(false);
            crdSocios_351FI.PerformLayout();
            crdVersiones_351FI.ResumeLayout(false);
            crdVersiones_351FI.PerformLayout();
            tlpPrincipal_351FI.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal_351FI;
        private TarjetaSGB_351FI crdVersiones_351FI;
        private Label lblSeccionVersiones_351FI;
        private Label lblNumeroSocio_351FI;
        private TextBox txtNumeroSocio_351FI;
        private Label lblApellido_351FI;
        private TextBox txtApellido_351FI;
        private Label lblFechaDesde_351FI;
        private DateTimePicker dtpFechaDesde_351FI;
        private Label lblFechaHasta_351FI;
        private DateTimePicker dtpFechaHasta_351FI;
        private BotonSGB_351FI btnFiltrar_351FI;
        private GrillaSGB_351FI dgvVersiones_351FI;
        private DataGridViewTextBoxColumn colVerVersion_351FI;
        private DataGridViewTextBoxColumn colVerSocio_351FI;
        private DataGridViewTextBoxColumn colVerApellido_351FI;
        private DataGridViewTextBoxColumn colVerNombre_351FI;
        private DataGridViewTextBoxColumn colVerDni_351FI;
        private DataGridViewTextBoxColumn colVerEstado_351FI;
        private DataGridViewTextBoxColumn colVerFecha_351FI;
        private DataGridViewTextBoxColumn colVerHora_351FI;
        private DataGridViewCheckBoxColumn colVerActiva_351FI;
        private BotonSGB_351FI btnActivar_351FI;
        private TarjetaSGB_351FI crdSocios_351FI;
        private Label lblSeccionSocios_351FI;
        private GrillaSGB_351FI dgvSocios_351FI;
        private DataGridViewTextBoxColumn colSocNumero_351FI;
        private DataGridViewTextBoxColumn colSocApellido_351FI;
        private DataGridViewTextBoxColumn colSocNombre_351FI;
        private DataGridViewTextBoxColumn colSocDni_351FI;
        private DataGridViewTextBoxColumn colSocEstado_351FI;
        private FlowLayoutPanel pnlAcciones_351FI;
        private BotonSGB_351FI btnCerrar_351FI;
    }
}
