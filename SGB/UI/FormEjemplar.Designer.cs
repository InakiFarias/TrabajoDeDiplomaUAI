using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormEjemplar
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
            crdEjemplares = new TarjetaSGB();
            lblSeccionEjemplares = new Label();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            dgvEjemplares = new GrillaSGB();
            colEjeCodigo = new DataGridViewTextBoxColumn();
            colEjeTitulo = new DataGridViewTextBoxColumn();
            colEjeAutor = new DataGridViewTextBoxColumn();
            colEjeEstado = new DataGridViewTextBoxColumn();
            crdDatos = new TarjetaSGB();
            lblSeccionDatos = new Label();
            lblCodigo = new Label();
            lblLibro = new Label();
            txtBuscarLibro = new TextBox();
            cboLibro = new ComboBox();
            btnAlta = new BotonSGB();
            btnBaja = new BotonSGB();
            btnReactivar = new BotonSGB();
            btnLimpiar = new BotonSGB();
            pnlAcciones = new FlowLayoutPanel();
            btnCerrar = new BotonSGB();
            tlpPrincipal.SuspendLayout();
            crdEjemplares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares).BeginInit();
            crdDatos.SuspendLayout();
            pnlAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal.ColumnCount = 2;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.0F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.0F));
            tlpPrincipal.Controls.Add(crdEjemplares, 0, 0);
            tlpPrincipal.Controls.Add(crdDatos, 1, 0);
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
            // crdEjemplares
            // 
            crdEjemplares.Controls.Add(lblSeccionEjemplares);
            crdEjemplares.Controls.Add(lblBuscar);
            crdEjemplares.Controls.Add(txtBuscar);
            crdEjemplares.Controls.Add(dgvEjemplares);
            crdEjemplares.Dock = DockStyle.Fill;
            crdEjemplares.Margin = new Padding(8);
            crdEjemplares.Name = "crdEjemplares";
            crdEjemplares.Size = new Size(651, 544);
            crdEjemplares.TabIndex = 0;
            // 
            // lblSeccionEjemplares
            // 
            lblSeccionEjemplares.AutoSize = true;
            lblSeccionEjemplares.BackColor = Color.Transparent;
            lblSeccionEjemplares.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionEjemplares.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionEjemplares.Location = new Point(20, 16);
            lblSeccionEjemplares.Name = "lblSeccionEjemplares";
            lblSeccionEjemplares.Size = new Size(80, 20);
            lblSeccionEjemplares.TabIndex = 0;
            lblSeccionEjemplares.Text = "Ejemplares";
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
            lblBuscar.Text = "Código de ejemplar, título o autor (búsqueda incremental)";
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.ForeColor = Color.FromArgb(31, 41, 55);
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Location = new Point(20, 74);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(611, 27);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvEjemplares
            // 
            dgvEjemplares.Columns.AddRange(new DataGridViewColumn[] { colEjeCodigo, colEjeTitulo, colEjeAutor, colEjeEstado });
            dgvEjemplares.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEjemplares.Location = new Point(20, 116);
            dgvEjemplares.Name = "dgvEjemplares";
            dgvEjemplares.Size = new Size(611, 408);
            dgvEjemplares.TabIndex = 3;
            // 
            // colEjeCodigo
            // 
            colEjeCodigo.FillWeight = 15F;
            colEjeCodigo.HeaderText = "Código";
            colEjeCodigo.Name = "colEjeCodigo";
            colEjeCodigo.ReadOnly = true;
            // 
            // colEjeTitulo
            // 
            colEjeTitulo.FillWeight = 40F;
            colEjeTitulo.HeaderText = "Título";
            colEjeTitulo.Name = "colEjeTitulo";
            colEjeTitulo.ReadOnly = true;
            // 
            // colEjeAutor
            // 
            colEjeAutor.FillWeight = 30F;
            colEjeAutor.HeaderText = "Autor";
            colEjeAutor.Name = "colEjeAutor";
            colEjeAutor.ReadOnly = true;
            // 
            // colEjeEstado
            // 
            colEjeEstado.FillWeight = 15F;
            colEjeEstado.HeaderText = "Estado";
            colEjeEstado.Name = "colEjeEstado";
            colEjeEstado.ReadOnly = true;
            dgvEjemplares.SelectionChanged += dgvEjemplares_SelectionChanged;
            // 
            // crdDatos
            // 
            crdDatos.Controls.Add(lblSeccionDatos);
            crdDatos.Controls.Add(lblCodigo);
            crdDatos.Controls.Add(lblLibro);
            crdDatos.Controls.Add(txtBuscarLibro);
            crdDatos.Controls.Add(cboLibro);
            crdDatos.Controls.Add(btnAlta);
            crdDatos.Controls.Add(btnBaja);
            crdDatos.Controls.Add(btnReactivar);
            crdDatos.Controls.Add(btnLimpiar);
            crdDatos.Dock = DockStyle.Fill;
            crdDatos.Margin = new Padding(8);
            crdDatos.Name = "crdDatos";
            crdDatos.Size = new Size(393, 544);
            crdDatos.TabIndex = 1;
            // 
            // lblSeccionDatos
            // 
            lblSeccionDatos.AutoSize = true;
            lblSeccionDatos.BackColor = Color.Transparent;
            lblSeccionDatos.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionDatos.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionDatos.Location = new Point(20, 16);
            lblSeccionDatos.Name = "lblSeccionDatos";
            lblSeccionDatos.Size = new Size(144, 20);
            lblSeccionDatos.TabIndex = 0;
            lblSeccionDatos.Text = "Datos del ejemplar";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = false;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.Font = new Font("Segoe UI", 11F);
            lblCodigo.ForeColor = Color.FromArgb(31, 41, 55);
            lblCodigo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo.Location = new Point(20, 50);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(353, 24);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código: — (se asigna al dar de alta)";
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = false;
            lblLibro.BackColor = Color.Transparent;
            lblLibro.Font = new Font("Segoe UI", 10F);
            lblLibro.ForeColor = Color.FromArgb(75, 85, 99);
            lblLibro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLibro.Location = new Point(20, 88);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(353, 40);
            lblLibro.TabIndex = 2;
            lblLibro.Text = "Libro al que pertenece";
            // 
            // txtBuscarLibro
            // 
            txtBuscarLibro.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarLibro.ForeColor = Color.FromArgb(31, 41, 55);
            txtBuscarLibro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarLibro.Location = new Point(20, 130);
            txtBuscarLibro.Name = "txtBuscarLibro";
            txtBuscarLibro.PlaceholderText = "Buscar por código, título o autor";
            txtBuscarLibro.Size = new Size(353, 27);
            txtBuscarLibro.TabIndex = 3;
            txtBuscarLibro.TextChanged += txtBuscarLibro_TextChanged;
            // 
            // cboLibro
            // 
            cboLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLibro.ForeColor = Color.FromArgb(31, 41, 55);
            cboLibro.FormattingEnabled = true;
            cboLibro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboLibro.Location = new Point(20, 168);
            cboLibro.Name = "cboLibro";
            cboLibro.Size = new Size(353, 28);
            cboLibro.TabIndex = 4;
            // 
            // btnAlta
            // 
            btnAlta.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAlta.Icono = "\uE710";
            btnAlta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAlta.Location = new Point(20, 228);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(353, 40);
            btnAlta.TabIndex = 5;
            btnAlta.Text = "Dar de alta";
            btnAlta.Click += btnAlta_Click;
            // 
            // btnBaja
            // 
            btnBaja.Estilo = EstiloBoton.Peligro;
            btnBaja.Font = new Font("Segoe UI Semibold", 10.5F);
            btnBaja.Icono = "\uE74D";
            btnBaja.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBaja.Location = new Point(20, 276);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(353, 40);
            btnBaja.TabIndex = 6;
            btnBaja.Text = "Dar de baja";
            btnBaja.Click += btnBaja_Click;
            // 
            // btnReactivar
            // 
            btnReactivar.Estilo = EstiloBoton.Secundario;
            btnReactivar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnReactivar.Icono = "\uE8FB";
            btnReactivar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnReactivar.Location = new Point(20, 324);
            btnReactivar.Name = "btnReactivar";
            btnReactivar.Size = new Size(353, 40);
            btnReactivar.TabIndex = 7;
            btnReactivar.Text = "Reactivar";
            btnReactivar.Click += btnReactivar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Estilo = EstiloBoton.Secundario;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnLimpiar.Icono = "\uE894";
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiar.Location = new Point(20, 372);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(353, 40);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // pnlAcciones
            // 
            pnlAcciones.BackColor = Color.Transparent;
            pnlAcciones.Controls.Add(btnCerrar);
            pnlAcciones.FlowDirection = FlowDirection.RightToLeft;
            pnlAcciones.WrapContents = false;
            pnlAcciones.Dock = DockStyle.Fill;
            pnlAcciones.Margin = new Padding(8);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(400, 40);
            pnlAcciones.TabIndex = 2;
            // 
            // btnCerrar
            // 
            btnCerrar.Estilo = EstiloBoton.Secundario;
            btnCerrar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnCerrar.Icono = "\uE8BB";
            btnCerrar.Margin = new Padding(12, 0, 0, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(140, 40);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormEjemplar
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEjemplar";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de ejemplares";
            Load += FormEjemplar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares).EndInit();
            pnlAcciones.ResumeLayout(false);
            pnlAcciones.PerformLayout();
            crdDatos.ResumeLayout(false);
            crdDatos.PerformLayout();
            crdEjemplares.ResumeLayout(false);
            crdEjemplares.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TarjetaSGB crdEjemplares;
        private Label lblSeccionEjemplares;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private GrillaSGB dgvEjemplares;
        private DataGridViewTextBoxColumn colEjeCodigo;
        private DataGridViewTextBoxColumn colEjeTitulo;
        private DataGridViewTextBoxColumn colEjeAutor;
        private DataGridViewTextBoxColumn colEjeEstado;
        private TarjetaSGB crdDatos;
        private Label lblSeccionDatos;
        private Label lblCodigo;
        private Label lblLibro;
        private TextBox txtBuscarLibro;
        private ComboBox cboLibro;
        private BotonSGB btnAlta;
        private BotonSGB btnBaja;
        private BotonSGB btnReactivar;
        private BotonSGB btnLimpiar;
        private FlowLayoutPanel pnlAcciones;
        private BotonSGB btnCerrar;
    }
}
