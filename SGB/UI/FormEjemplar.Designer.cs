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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSeccionEjemplares = new Label();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            dgvEjemplares = new DataGridView();
            colEjeCodigo = new DataGridViewTextBoxColumn();
            colEjeTitulo = new DataGridViewTextBoxColumn();
            colEjeAutor = new DataGridViewTextBoxColumn();
            colEjeEstado = new DataGridViewTextBoxColumn();
            lblSeccionDatos = new Label();
            lblCodigo = new Label();
            lblLibro = new Label();
            txtBuscarLibro = new TextBox();
            cboLibro = new ComboBox();
            btnAlta = new Button();
            btnModificar = new Button();
            btnBaja = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F);
            lblTitulo.ForeColor = Color.FromArgb(226, 232, 240);
            lblTitulo.Location = new Point(16, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(147, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de ejemplares";
            // 
            // lblSeccionEjemplares
            // 
            lblSeccionEjemplares.AutoSize = true;
            lblSeccionEjemplares.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionEjemplares.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionEjemplares.Location = new Point(16, 52);
            lblSeccionEjemplares.Name = "lblSeccionEjemplares";
            lblSeccionEjemplares.Size = new Size(70, 12);
            lblSeccionEjemplares.TabIndex = 1;
            lblSeccionEjemplares.Text = "EJEMPLARES";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.ForeColor = Color.FromArgb(148, 163, 184);
            lblBuscar.Location = new Point(16, 70);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(399, 17);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "Código de ejemplar, título o autor (búsqueda incremental)";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(21, 32, 48);
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.ForeColor = Color.FromArgb(226, 232, 240);
            txtBuscar.Location = new Point(16, 90);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(300, 24);
            txtBuscar.TabIndex = 3;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvEjemplares
            // 
            dgvEjemplares.AllowUserToAddRows = false;
            dgvEjemplares.AllowUserToDeleteRows = false;
            dgvEjemplares.AllowUserToResizeRows = false;
            dgvEjemplares.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvEjemplares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEjemplares.BackgroundColor = Color.FromArgb(21, 32, 48);
            dgvEjemplares.BorderStyle = BorderStyle.None;
            dgvEjemplares.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEjemplares.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEjemplares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEjemplares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEjemplares.Columns.AddRange(new DataGridViewColumn[] { colEjeCodigo, colEjeTitulo, colEjeAutor, colEjeEstado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(21, 32, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 60, 82);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEjemplares.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEjemplares.EnableHeadersVisualStyles = false;
            dgvEjemplares.GridColor = Color.FromArgb(45, 60, 82);
            dgvEjemplares.Location = new Point(16, 122);
            dgvEjemplares.MultiSelect = false;
            dgvEjemplares.Name = "dgvEjemplares";
            dgvEjemplares.ReadOnly = true;
            dgvEjemplares.RowHeadersVisible = false;
            dgvEjemplares.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEjemplares.Size = new Size(717, 230);
            dgvEjemplares.TabIndex = 4;
            dgvEjemplares.SelectionChanged += dgvEjemplares_SelectionChanged;
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
            // 
            // lblSeccionDatos
            // 
            lblSeccionDatos.AutoSize = true;
            lblSeccionDatos.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionDatos.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionDatos.Location = new Point(16, 366);
            lblSeccionDatos.Name = "lblSeccionDatos";
            lblSeccionDatos.Size = new Size(126, 12);
            lblSeccionDatos.TabIndex = 5;
            lblSeccionDatos.Text = "DATOS DEL EJEMPLAR";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = Color.FromArgb(226, 232, 240);
            lblCodigo.Location = new Point(16, 384);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(252, 17);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "Código: — (se asigna al dar de alta)";
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.ForeColor = Color.FromArgb(148, 163, 184);
            lblLibro.Location = new Point(16, 410);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(154, 17);
            lblLibro.TabIndex = 7;
            lblLibro.Text = "Libro al que pertenece";
            // 
            // txtBuscarLibro
            // 
            txtBuscarLibro.BackColor = Color.FromArgb(21, 32, 48);
            txtBuscarLibro.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarLibro.ForeColor = Color.FromArgb(226, 232, 240);
            txtBuscarLibro.Location = new Point(16, 430);
            txtBuscarLibro.Name = "txtBuscarLibro";
            txtBuscarLibro.PlaceholderText = "Buscar libro por código, título o autor";
            txtBuscarLibro.Size = new Size(260, 24);
            txtBuscarLibro.TabIndex = 8;
            txtBuscarLibro.TextChanged += txtBuscarLibro_TextChanged;
            // 
            // cboLibro
            // 
            cboLibro.BackColor = Color.FromArgb(21, 32, 48);
            cboLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLibro.FlatStyle = FlatStyle.Flat;
            cboLibro.ForeColor = Color.FromArgb(226, 232, 240);
            cboLibro.FormattingEnabled = true;
            cboLibro.Location = new Point(284, 430);
            cboLibro.Name = "cboLibro";
            cboLibro.Size = new Size(449, 25);
            cboLibro.TabIndex = 9;
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.FromArgb(37, 99, 235);
            btnAlta.Cursor = Cursors.Hand;
            btnAlta.FlatAppearance.BorderSize = 0;
            btnAlta.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnAlta.FlatStyle = FlatStyle.Flat;
            btnAlta.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAlta.ForeColor = Color.White;
            btnAlta.Location = new Point(16, 476);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(120, 34);
            btnAlta.TabIndex = 10;
            btnAlta.Text = "➕ Alta";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(45, 60, 82);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 75, 99);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.FromArgb(226, 232, 240);
            btnModificar.Location = new Point(142, 476);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 34);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "✏ Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.FromArgb(127, 29, 29);
            btnBaja.Cursor = Cursors.Hand;
            btnBaja.FlatAppearance.BorderSize = 0;
            btnBaja.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 27, 27);
            btnBaja.FlatStyle = FlatStyle.Flat;
            btnBaja.ForeColor = Color.FromArgb(226, 232, 240);
            btnBaja.Location = new Point(268, 476);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(120, 34);
            btnBaja.TabIndex = 12;
            btnBaja.Text = "✖ Baja";
            btnBaja.UseVisualStyleBackColor = false;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(45, 60, 82);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 75, 99);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.FromArgb(226, 232, 240);
            btnLimpiar.Location = new Point(394, 476);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 34);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.BackColor = Color.FromArgb(45, 60, 82);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 75, 99);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.FromArgb(226, 232, 240);
            btnCerrar.Location = new Point(633, 526);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 34);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormEjemplar
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 42, 58);
            ClientSize = new Size(749, 572);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBaja);
            Controls.Add(btnModificar);
            Controls.Add(btnAlta);
            Controls.Add(cboLibro);
            Controls.Add(txtBuscarLibro);
            Controls.Add(lblLibro);
            Controls.Add(lblCodigo);
            Controls.Add(lblSeccionDatos);
            Controls.Add(dgvEjemplares);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(lblSeccionEjemplares);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEjemplar";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de ejemplares";
            Load += FormEjemplar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSeccionEjemplares;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private DataGridView dgvEjemplares;
        private DataGridViewTextBoxColumn colEjeCodigo;
        private DataGridViewTextBoxColumn colEjeTitulo;
        private DataGridViewTextBoxColumn colEjeAutor;
        private DataGridViewTextBoxColumn colEjeEstado;
        private Label lblSeccionDatos;
        private Label lblCodigo;
        private Label lblLibro;
        private TextBox txtBuscarLibro;
        private ComboBox cboLibro;
        private Button btnAlta;
        private Button btnModificar;
        private Button btnBaja;
        private Button btnLimpiar;
        private Button btnCerrar;
    }
}
