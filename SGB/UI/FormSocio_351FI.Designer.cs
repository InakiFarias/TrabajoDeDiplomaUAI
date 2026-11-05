using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormSocio_351FI
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
            crdSocios_351FI = new TarjetaSGB_351FI();
            lblSeccionSocios_351FI = new Label();
            lblBuscarDni_351FI = new Label();
            txtBuscarDni_351FI = new TextBox();
            dgvSocios_351FI = new GrillaSGB_351FI();
            colSocNumero_351FI = new DataGridViewTextBoxColumn();
            colSocApellido_351FI = new DataGridViewTextBoxColumn();
            colSocNombre_351FI = new DataGridViewTextBoxColumn();
            colSocDni_351FI = new DataGridViewTextBoxColumn();
            colSocEstado_351FI = new DataGridViewTextBoxColumn();
            crdDatos_351FI = new TarjetaSGB_351FI();
            lblSeccionDatos_351FI = new Label();
            lblNumero_351FI = new Label();
            lblNombre_351FI = new Label();
            txtNombre_351FI = new TextBox();
            lblApellido_351FI = new Label();
            txtApellido_351FI = new TextBox();
            lblDni_351FI = new Label();
            txtDni_351FI = new TextBox();
            btnAlta_351FI = new BotonSGB_351FI();
            btnModificar_351FI = new BotonSGB_351FI();
            btnBaja_351FI = new BotonSGB_351FI();
            btnReactivar_351FI = new BotonSGB_351FI();
            btnLimpiar_351FI = new BotonSGB_351FI();
            pnlAcciones_351FI = new FlowLayoutPanel();
            btnCerrar_351FI = new BotonSGB_351FI();
            tlpPrincipal_351FI.SuspendLayout();
            crdSocios_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios_351FI).BeginInit();
            crdDatos_351FI.SuspendLayout();
            pnlAcciones_351FI.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal_351FI.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal_351FI.ColumnCount = 2;
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.0F));
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.0F));
            tlpPrincipal_351FI.Controls.Add(crdSocios_351FI, 0, 0);
            tlpPrincipal_351FI.Controls.Add(crdDatos_351FI, 1, 0);
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
            // crdSocios
            // 
            crdSocios_351FI.Controls.Add(lblSeccionSocios_351FI);
            crdSocios_351FI.Controls.Add(lblBuscarDni_351FI);
            crdSocios_351FI.Controls.Add(txtBuscarDni_351FI);
            crdSocios_351FI.Controls.Add(dgvSocios_351FI);
            crdSocios_351FI.Dock = DockStyle.Fill;
            crdSocios_351FI.Margin = new Padding(8);
            crdSocios_351FI.Name = "crdSocios_351FI";
            crdSocios_351FI.Size = new Size(651, 544);
            crdSocios_351FI.TabIndex = 0;
            // 
            // lblSeccionSocios
            // 
            lblSeccionSocios_351FI.AutoSize = true;
            lblSeccionSocios_351FI.BackColor = Color.Transparent;
            lblSeccionSocios_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionSocios_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionSocios_351FI.Location = new Point(20, 16);
            lblSeccionSocios_351FI.Name = "lblSeccionSocios_351FI";
            lblSeccionSocios_351FI.Size = new Size(48, 20);
            lblSeccionSocios_351FI.TabIndex = 0;
            lblSeccionSocios_351FI.Text = "Socios";
            // 
            // lblBuscarDni
            // 
            lblBuscarDni_351FI.AutoSize = true;
            lblBuscarDni_351FI.BackColor = Color.Transparent;
            lblBuscarDni_351FI.Font = new Font("Segoe UI", 10F);
            lblBuscarDni_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblBuscarDni_351FI.Location = new Point(20, 52);
            lblBuscarDni_351FI.Name = "lblBuscarDni_351FI";
            lblBuscarDni_351FI.Size = new Size(208, 20);
            lblBuscarDni_351FI.TabIndex = 1;
            lblBuscarDni_351FI.Text = "DNI (búsqueda incremental)";
            // 
            // txtBuscarDni
            // 
            txtBuscarDni_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarDni_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtBuscarDni_351FI.Location = new Point(20, 74);
            txtBuscarDni_351FI.Name = "txtBuscarDni_351FI";
            txtBuscarDni_351FI.Size = new Size(300, 27);
            txtBuscarDni_351FI.TabIndex = 2;
            txtBuscarDni_351FI.TextChanged += txtBuscarDni_351FI_TextChanged;
            // 
            // dgvSocios
            // 
            dgvSocios_351FI.Columns.AddRange(new DataGridViewColumn[] { colSocNumero_351FI, colSocApellido_351FI, colSocNombre_351FI, colSocDni_351FI, colSocEstado_351FI });
            dgvSocios_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSocios_351FI.Location = new Point(20, 116);
            dgvSocios_351FI.Name = "dgvSocios_351FI";
            dgvSocios_351FI.Size = new Size(611, 408);
            dgvSocios_351FI.TabIndex = 3;
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
            colSocApellido_351FI.FillWeight = 30F;
            colSocApellido_351FI.HeaderText = "Apellido";
            colSocApellido_351FI.Name = "colSocApellido_351FI";
            colSocApellido_351FI.ReadOnly = true;
            // 
            // colSocNombre
            // 
            colSocNombre_351FI.FillWeight = 30F;
            colSocNombre_351FI.HeaderText = "Nombre";
            colSocNombre_351FI.Name = "colSocNombre_351FI";
            colSocNombre_351FI.ReadOnly = true;
            // 
            // colSocDni
            // 
            colSocDni_351FI.FillWeight = 25F;
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
            dgvSocios_351FI.SelectionChanged += dgvSocios_351FI_SelectionChanged;
            // 
            // crdDatos
            // 
            crdDatos_351FI.Controls.Add(lblSeccionDatos_351FI);
            crdDatos_351FI.Controls.Add(lblNumero_351FI);
            crdDatos_351FI.Controls.Add(lblNombre_351FI);
            crdDatos_351FI.Controls.Add(txtNombre_351FI);
            crdDatos_351FI.Controls.Add(lblApellido_351FI);
            crdDatos_351FI.Controls.Add(txtApellido_351FI);
            crdDatos_351FI.Controls.Add(lblDni_351FI);
            crdDatos_351FI.Controls.Add(txtDni_351FI);
            crdDatos_351FI.Controls.Add(btnAlta_351FI);
            crdDatos_351FI.Controls.Add(btnModificar_351FI);
            crdDatos_351FI.Controls.Add(btnBaja_351FI);
            crdDatos_351FI.Controls.Add(btnReactivar_351FI);
            crdDatos_351FI.Controls.Add(btnLimpiar_351FI);
            crdDatos_351FI.Dock = DockStyle.Fill;
            crdDatos_351FI.Margin = new Padding(8);
            crdDatos_351FI.Name = "crdDatos_351FI";
            crdDatos_351FI.Size = new Size(393, 544);
            crdDatos_351FI.TabIndex = 1;
            // 
            // lblSeccionDatos
            // 
            lblSeccionDatos_351FI.AutoSize = true;
            lblSeccionDatos_351FI.BackColor = Color.Transparent;
            lblSeccionDatos_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionDatos_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionDatos_351FI.Location = new Point(20, 16);
            lblSeccionDatos_351FI.Name = "lblSeccionDatos_351FI";
            lblSeccionDatos_351FI.Size = new Size(120, 20);
            lblSeccionDatos_351FI.TabIndex = 0;
            lblSeccionDatos_351FI.Text = "Datos del socio";
            // 
            // lblNumero
            // 
            lblNumero_351FI.AutoSize = false;
            lblNumero_351FI.BackColor = Color.Transparent;
            lblNumero_351FI.Font = new Font("Segoe UI", 11F);
            lblNumero_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblNumero_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNumero_351FI.Location = new Point(20, 50);
            lblNumero_351FI.Name = "lblNumero_351FI";
            lblNumero_351FI.Size = new Size(353, 24);
            lblNumero_351FI.TabIndex = 1;
            lblNumero_351FI.Text = "Número de socio: — (se asigna al dar de alta)";
            // 
            // lblNombre
            // 
            lblNombre_351FI.AutoSize = true;
            lblNombre_351FI.BackColor = Color.Transparent;
            lblNombre_351FI.Font = new Font("Segoe UI", 10F);
            lblNombre_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblNombre_351FI.Location = new Point(20, 90);
            lblNombre_351FI.Name = "lblNombre_351FI";
            lblNombre_351FI.Size = new Size(48, 20);
            lblNombre_351FI.TabIndex = 2;
            lblNombre_351FI.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtNombre_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtNombre_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre_351FI.Location = new Point(20, 112);
            txtNombre_351FI.MaxLength = 50;
            txtNombre_351FI.Name = "txtNombre_351FI";
            txtNombre_351FI.Size = new Size(353, 27);
            txtNombre_351FI.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido_351FI.AutoSize = true;
            lblApellido_351FI.BackColor = Color.Transparent;
            lblApellido_351FI.Font = new Font("Segoe UI", 10F);
            lblApellido_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblApellido_351FI.Location = new Point(20, 152);
            lblApellido_351FI.Name = "lblApellido_351FI";
            lblApellido_351FI.Size = new Size(64, 20);
            lblApellido_351FI.TabIndex = 4;
            lblApellido_351FI.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtApellido_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtApellido_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtApellido_351FI.Location = new Point(20, 174);
            txtApellido_351FI.MaxLength = 50;
            txtApellido_351FI.Name = "txtApellido_351FI";
            txtApellido_351FI.Size = new Size(353, 27);
            txtApellido_351FI.TabIndex = 5;
            // 
            // lblDni
            // 
            lblDni_351FI.AutoSize = true;
            lblDni_351FI.BackColor = Color.Transparent;
            lblDni_351FI.Font = new Font("Segoe UI", 10F);
            lblDni_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblDni_351FI.Location = new Point(20, 214);
            lblDni_351FI.Name = "lblDni_351FI";
            lblDni_351FI.Size = new Size(128, 20);
            lblDni_351FI.TabIndex = 6;
            lblDni_351FI.Text = "DNI (sin puntos)";
            // 
            // txtDni
            // 
            txtDni_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtDni_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtDni_351FI.Location = new Point(20, 236);
            txtDni_351FI.MaxLength = 8;
            txtDni_351FI.Name = "txtDni_351FI";
            txtDni_351FI.Size = new Size(170, 27);
            txtDni_351FI.TabIndex = 7;
            // 
            // btnAlta
            // 
            btnAlta_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAlta_351FI.Icono_351FI = "\uE710";
            btnAlta_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAlta_351FI.Location = new Point(20, 290);
            btnAlta_351FI.Name = "btnAlta_351FI";
            btnAlta_351FI.Size = new Size(353, 40);
            btnAlta_351FI.TabIndex = 8;
            btnAlta_351FI.Text = "Dar de alta";
            btnAlta_351FI.Click += btnAlta_351FI_Click;
            // 
            // btnModificar
            // 
            btnModificar_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnModificar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnModificar_351FI.Icono_351FI = "\uE70F";
            btnModificar_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnModificar_351FI.Location = new Point(20, 338);
            btnModificar_351FI.Name = "btnModificar_351FI";
            btnModificar_351FI.Size = new Size(353, 40);
            btnModificar_351FI.TabIndex = 9;
            btnModificar_351FI.Text = "Modificar";
            btnModificar_351FI.Click += btnModificar_351FI_Click;
            // 
            // btnBaja
            // 
            btnBaja_351FI.Estilo_351FI = EstiloBoton_351FI.Peligro;
            btnBaja_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnBaja_351FI.Icono_351FI = "\uE74D";
            btnBaja_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBaja_351FI.Location = new Point(20, 386);
            btnBaja_351FI.Name = "btnBaja_351FI";
            btnBaja_351FI.Size = new Size(353, 40);
            btnBaja_351FI.TabIndex = 10;
            btnBaja_351FI.Text = "Dar de baja";
            btnBaja_351FI.Click += btnBaja_351FI_Click;
            // 
            // btnReactivar
            // 
            btnReactivar_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnReactivar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnReactivar_351FI.Icono_351FI = "\uE8FB";
            btnReactivar_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnReactivar_351FI.Location = new Point(20, 434);
            btnReactivar_351FI.Name = "btnReactivar_351FI";
            btnReactivar_351FI.Size = new Size(353, 40);
            btnReactivar_351FI.TabIndex = 11;
            btnReactivar_351FI.Text = "Reactivar";
            btnReactivar_351FI.Click += btnReactivar_351FI_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnLimpiar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnLimpiar_351FI.Icono_351FI = "\uE894";
            btnLimpiar_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiar_351FI.Location = new Point(20, 482);
            btnLimpiar_351FI.Name = "btnLimpiar_351FI";
            btnLimpiar_351FI.Size = new Size(353, 40);
            btnLimpiar_351FI.TabIndex = 12;
            btnLimpiar_351FI.Text = "Limpiar campos";
            btnLimpiar_351FI.Click += btnLimpiar_351FI_Click;
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
            btnCerrar_351FI.Icono_351FI = "\uE8BB";
            btnCerrar_351FI.Margin = new Padding(12, 0, 0, 0);
            btnCerrar_351FI.Name = "btnCerrar_351FI";
            btnCerrar_351FI.Size = new Size(140, 40);
            btnCerrar_351FI.TabIndex = 0;
            btnCerrar_351FI.Text = "Cerrar";
            btnCerrar_351FI.Click += btnCerrar_351FI_Click;
            // 
            // FormSocio
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal_351FI);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSocio_351FI";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de socios";
            Load += FormSocio_351FI_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios_351FI).EndInit();
            pnlAcciones_351FI.ResumeLayout(false);
            pnlAcciones_351FI.PerformLayout();
            crdDatos_351FI.ResumeLayout(false);
            crdDatos_351FI.PerformLayout();
            crdSocios_351FI.ResumeLayout(false);
            crdSocios_351FI.PerformLayout();
            tlpPrincipal_351FI.ResumeLayout(false);
            tlpPrincipal_351FI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal_351FI;
        private TarjetaSGB_351FI crdSocios_351FI;
        private Label lblSeccionSocios_351FI;
        private Label lblBuscarDni_351FI;
        private TextBox txtBuscarDni_351FI;
        private GrillaSGB_351FI dgvSocios_351FI;
        private DataGridViewTextBoxColumn colSocNumero_351FI;
        private DataGridViewTextBoxColumn colSocApellido_351FI;
        private DataGridViewTextBoxColumn colSocNombre_351FI;
        private DataGridViewTextBoxColumn colSocDni_351FI;
        private DataGridViewTextBoxColumn colSocEstado_351FI;
        private TarjetaSGB_351FI crdDatos_351FI;
        private Label lblSeccionDatos_351FI;
        private Label lblNumero_351FI;
        private Label lblNombre_351FI;
        private TextBox txtNombre_351FI;
        private Label lblApellido_351FI;
        private TextBox txtApellido_351FI;
        private Label lblDni_351FI;
        private TextBox txtDni_351FI;
        private BotonSGB_351FI btnAlta_351FI;
        private BotonSGB_351FI btnModificar_351FI;
        private BotonSGB_351FI btnBaja_351FI;
        private BotonSGB_351FI btnReactivar_351FI;
        private BotonSGB_351FI btnLimpiar_351FI;
        private FlowLayoutPanel pnlAcciones_351FI;
        private BotonSGB_351FI btnCerrar_351FI;
    }
}
