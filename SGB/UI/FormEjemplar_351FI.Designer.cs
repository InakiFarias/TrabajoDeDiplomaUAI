using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormEjemplar_351FI
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
            crdEjemplares_351FI = new TarjetaSGB_351FI();
            lblSeccionEjemplares_351FI = new Label();
            lblBuscar_351FI = new Label();
            txtBuscar_351FI = new TextBox();
            dgvEjemplares_351FI = new GrillaSGB_351FI();
            colEjeCodigo_351FI = new DataGridViewTextBoxColumn();
            colEjeTitulo_351FI = new DataGridViewTextBoxColumn();
            colEjeAutor_351FI = new DataGridViewTextBoxColumn();
            colEjeEstado_351FI = new DataGridViewTextBoxColumn();
            crdDatos_351FI = new TarjetaSGB_351FI();
            lblSeccionDatos_351FI = new Label();
            lblCodigo_351FI = new Label();
            lblLibro_351FI = new Label();
            txtBuscarLibro_351FI = new TextBox();
            cboLibro_351FI = new ComboBox();
            btnAlta_351FI = new BotonSGB_351FI();
            btnBaja_351FI = new BotonSGB_351FI();
            btnReactivar_351FI = new BotonSGB_351FI();
            btnLimpiar_351FI = new BotonSGB_351FI();
            pnlAcciones_351FI = new FlowLayoutPanel();
            btnCerrar_351FI = new BotonSGB_351FI();
            tlpPrincipal_351FI.SuspendLayout();
            crdEjemplares_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares_351FI).BeginInit();
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
            tlpPrincipal_351FI.Controls.Add(crdEjemplares_351FI, 0, 0);
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
            // crdEjemplares
            // 
            crdEjemplares_351FI.Controls.Add(lblSeccionEjemplares_351FI);
            crdEjemplares_351FI.Controls.Add(lblBuscar_351FI);
            crdEjemplares_351FI.Controls.Add(txtBuscar_351FI);
            crdEjemplares_351FI.Controls.Add(dgvEjemplares_351FI);
            crdEjemplares_351FI.Dock = DockStyle.Fill;
            crdEjemplares_351FI.Margin = new Padding(8);
            crdEjemplares_351FI.Name = "crdEjemplares_351FI";
            crdEjemplares_351FI.Size = new Size(651, 544);
            crdEjemplares_351FI.TabIndex = 0;
            // 
            // lblSeccionEjemplares
            // 
            lblSeccionEjemplares_351FI.AutoSize = true;
            lblSeccionEjemplares_351FI.BackColor = Color.Transparent;
            lblSeccionEjemplares_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionEjemplares_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionEjemplares_351FI.Location = new Point(20, 16);
            lblSeccionEjemplares_351FI.Name = "lblSeccionEjemplares_351FI";
            lblSeccionEjemplares_351FI.Size = new Size(80, 20);
            lblSeccionEjemplares_351FI.TabIndex = 0;
            lblSeccionEjemplares_351FI.Text = "Ejemplares";
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
            lblBuscar_351FI.Text = "Código de ejemplar, título o autor (búsqueda incremental)";
            // 
            // txtBuscar
            // 
            txtBuscar_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtBuscar_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar_351FI.Location = new Point(20, 74);
            txtBuscar_351FI.Name = "txtBuscar_351FI";
            txtBuscar_351FI.Size = new Size(611, 27);
            txtBuscar_351FI.TabIndex = 2;
            txtBuscar_351FI.TextChanged += txtBuscar_351FI_TextChanged;
            // 
            // dgvEjemplares
            // 
            dgvEjemplares_351FI.Columns.AddRange(new DataGridViewColumn[] { colEjeCodigo_351FI, colEjeTitulo_351FI, colEjeAutor_351FI, colEjeEstado_351FI });
            dgvEjemplares_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEjemplares_351FI.Location = new Point(20, 116);
            dgvEjemplares_351FI.Name = "dgvEjemplares_351FI";
            dgvEjemplares_351FI.Size = new Size(611, 408);
            dgvEjemplares_351FI.TabIndex = 3;
            // 
            // colEjeCodigo
            // 
            colEjeCodigo_351FI.FillWeight = 15F;
            colEjeCodigo_351FI.HeaderText = "Código";
            colEjeCodigo_351FI.Name = "colEjeCodigo_351FI";
            colEjeCodigo_351FI.ReadOnly = true;
            // 
            // colEjeTitulo
            // 
            colEjeTitulo_351FI.FillWeight = 40F;
            colEjeTitulo_351FI.HeaderText = "Título";
            colEjeTitulo_351FI.Name = "colEjeTitulo_351FI";
            colEjeTitulo_351FI.ReadOnly = true;
            // 
            // colEjeAutor
            // 
            colEjeAutor_351FI.FillWeight = 30F;
            colEjeAutor_351FI.HeaderText = "Autor";
            colEjeAutor_351FI.Name = "colEjeAutor_351FI";
            colEjeAutor_351FI.ReadOnly = true;
            // 
            // colEjeEstado
            // 
            colEjeEstado_351FI.FillWeight = 15F;
            colEjeEstado_351FI.HeaderText = "Estado";
            colEjeEstado_351FI.Name = "colEjeEstado_351FI";
            colEjeEstado_351FI.ReadOnly = true;
            dgvEjemplares_351FI.SelectionChanged += dgvEjemplares_351FI_SelectionChanged;
            // 
            // crdDatos
            // 
            crdDatos_351FI.Controls.Add(lblSeccionDatos_351FI);
            crdDatos_351FI.Controls.Add(lblCodigo_351FI);
            crdDatos_351FI.Controls.Add(lblLibro_351FI);
            crdDatos_351FI.Controls.Add(txtBuscarLibro_351FI);
            crdDatos_351FI.Controls.Add(cboLibro_351FI);
            crdDatos_351FI.Controls.Add(btnAlta_351FI);
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
            lblSeccionDatos_351FI.Size = new Size(144, 20);
            lblSeccionDatos_351FI.TabIndex = 0;
            lblSeccionDatos_351FI.Text = "Datos del ejemplar";
            // 
            // lblCodigo
            // 
            lblCodigo_351FI.AutoSize = false;
            lblCodigo_351FI.BackColor = Color.Transparent;
            lblCodigo_351FI.Font = new Font("Segoe UI", 11F);
            lblCodigo_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblCodigo_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo_351FI.Location = new Point(20, 50);
            lblCodigo_351FI.Name = "lblCodigo_351FI";
            lblCodigo_351FI.Size = new Size(353, 24);
            lblCodigo_351FI.TabIndex = 1;
            lblCodigo_351FI.Text = "Código: — (se asigna al dar de alta)";
            // 
            // lblLibro
            // 
            lblLibro_351FI.AutoSize = false;
            lblLibro_351FI.BackColor = Color.Transparent;
            lblLibro_351FI.Font = new Font("Segoe UI", 10F);
            lblLibro_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblLibro_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLibro_351FI.Location = new Point(20, 88);
            lblLibro_351FI.Name = "lblLibro_351FI";
            lblLibro_351FI.Size = new Size(353, 40);
            lblLibro_351FI.TabIndex = 2;
            lblLibro_351FI.Text = "Libro al que pertenece";
            // 
            // txtBuscarLibro
            // 
            txtBuscarLibro_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarLibro_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtBuscarLibro_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarLibro_351FI.Location = new Point(20, 130);
            txtBuscarLibro_351FI.Name = "txtBuscarLibro_351FI";
            txtBuscarLibro_351FI.PlaceholderText = "Buscar por código, título o autor";
            txtBuscarLibro_351FI.Size = new Size(353, 27);
            txtBuscarLibro_351FI.TabIndex = 3;
            txtBuscarLibro_351FI.TextChanged += txtBuscarLibro_351FI_TextChanged;
            // 
            // cboLibro
            // 
            cboLibro_351FI.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLibro_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            cboLibro_351FI.FormattingEnabled = true;
            cboLibro_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboLibro_351FI.Location = new Point(20, 168);
            cboLibro_351FI.Name = "cboLibro_351FI";
            cboLibro_351FI.Size = new Size(353, 28);
            cboLibro_351FI.TabIndex = 4;
            // 
            // btnAlta
            // 
            btnAlta_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAlta_351FI.Icono_351FI = "\uE710";
            btnAlta_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAlta_351FI.Location = new Point(20, 228);
            btnAlta_351FI.Name = "btnAlta_351FI";
            btnAlta_351FI.Size = new Size(353, 40);
            btnAlta_351FI.TabIndex = 5;
            btnAlta_351FI.Text = "Dar de alta";
            btnAlta_351FI.Click += btnAlta_351FI_Click;
            // 
            // btnBaja
            // 
            btnBaja_351FI.Estilo_351FI = EstiloBoton_351FI.Peligro;
            btnBaja_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnBaja_351FI.Icono_351FI = "\uE74D";
            btnBaja_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBaja_351FI.Location = new Point(20, 276);
            btnBaja_351FI.Name = "btnBaja_351FI";
            btnBaja_351FI.Size = new Size(353, 40);
            btnBaja_351FI.TabIndex = 6;
            btnBaja_351FI.Text = "Dar de baja";
            btnBaja_351FI.Click += btnBaja_351FI_Click;
            // 
            // btnReactivar
            // 
            btnReactivar_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnReactivar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnReactivar_351FI.Icono_351FI = "\uE8FB";
            btnReactivar_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnReactivar_351FI.Location = new Point(20, 324);
            btnReactivar_351FI.Name = "btnReactivar_351FI";
            btnReactivar_351FI.Size = new Size(353, 40);
            btnReactivar_351FI.TabIndex = 7;
            btnReactivar_351FI.Text = "Reactivar";
            btnReactivar_351FI.Click += btnReactivar_351FI_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnLimpiar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnLimpiar_351FI.Icono_351FI = "\uE894";
            btnLimpiar_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiar_351FI.Location = new Point(20, 372);
            btnLimpiar_351FI.Name = "btnLimpiar_351FI";
            btnLimpiar_351FI.Size = new Size(353, 40);
            btnLimpiar_351FI.TabIndex = 8;
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
            // FormEjemplar
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal_351FI);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEjemplar_351FI";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de ejemplares";
            Load += FormEjemplar_351FI_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares_351FI).EndInit();
            pnlAcciones_351FI.ResumeLayout(false);
            pnlAcciones_351FI.PerformLayout();
            crdDatos_351FI.ResumeLayout(false);
            crdDatos_351FI.PerformLayout();
            crdEjemplares_351FI.ResumeLayout(false);
            crdEjemplares_351FI.PerformLayout();
            tlpPrincipal_351FI.ResumeLayout(false);
            tlpPrincipal_351FI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal_351FI;
        private TarjetaSGB_351FI crdEjemplares_351FI;
        private Label lblSeccionEjemplares_351FI;
        private Label lblBuscar_351FI;
        private TextBox txtBuscar_351FI;
        private GrillaSGB_351FI dgvEjemplares_351FI;
        private DataGridViewTextBoxColumn colEjeCodigo_351FI;
        private DataGridViewTextBoxColumn colEjeTitulo_351FI;
        private DataGridViewTextBoxColumn colEjeAutor_351FI;
        private DataGridViewTextBoxColumn colEjeEstado_351FI;
        private TarjetaSGB_351FI crdDatos_351FI;
        private Label lblSeccionDatos_351FI;
        private Label lblCodigo_351FI;
        private Label lblLibro_351FI;
        private TextBox txtBuscarLibro_351FI;
        private ComboBox cboLibro_351FI;
        private BotonSGB_351FI btnAlta_351FI;
        private BotonSGB_351FI btnBaja_351FI;
        private BotonSGB_351FI btnReactivar_351FI;
        private BotonSGB_351FI btnLimpiar_351FI;
        private FlowLayoutPanel pnlAcciones_351FI;
        private BotonSGB_351FI btnCerrar_351FI;
    }
}
