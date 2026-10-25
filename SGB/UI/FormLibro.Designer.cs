using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormLibro
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
            lblSeccionLibros = new Label();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            dgvLibros = new DataGridView();
            colLibCodigo = new DataGridViewTextBoxColumn();
            colLibTitulo = new DataGridViewTextBoxColumn();
            colLibAutores = new DataGridViewTextBoxColumn();
            colLibTemas = new DataGridViewTextBoxColumn();
            colLibEstado = new DataGridViewTextBoxColumn();
            lblSeccionDatos = new Label();
            lblCodigo = new Label();
            lblTituloLibro = new Label();
            txtTituloLibro = new TextBox();
            lblAutores = new Label();
            txtBuscarAutor = new TextBox();
            clbAutores = new CheckedListBox();
            lblTemas = new Label();
            clbTemas = new CheckedListBox();
            lblNuevoAutor = new Label();
            txtAutorNombre = new TextBox();
            txtAutorApellido = new TextBox();
            btnAgregarAutor = new Button();
            lblNuevoTema = new Label();
            txtTema = new TextBox();
            btnAgregarTema = new Button();
            btnAlta = new Button();
            btnModificar = new Button();
            btnBaja = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F);
            lblTitulo.ForeColor = Color.FromArgb(226, 232, 240);
            lblTitulo.Location = new Point(16, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(119, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de libros";
            // 
            // lblSeccionLibros
            // 
            lblSeccionLibros.AutoSize = true;
            lblSeccionLibros.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionLibros.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionLibros.Location = new Point(16, 52);
            lblSeccionLibros.Name = "lblSeccionLibros";
            lblSeccionLibros.Size = new Size(42, 12);
            lblSeccionLibros.TabIndex = 1;
            lblSeccionLibros.Text = "LIBROS";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.ForeColor = Color.FromArgb(148, 163, 184);
            lblBuscar.Location = new Point(16, 70);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(315, 17);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "Código, título o autor (búsqueda incremental)";
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
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dgvLibros.AllowUserToResizeRows = false;
            dgvLibros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.BackgroundColor = Color.FromArgb(21, 32, 48);
            dgvLibros.BorderStyle = BorderStyle.None;
            dgvLibros.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLibros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Columns.AddRange(new DataGridViewColumn[] { colLibCodigo, colLibTitulo, colLibAutores, colLibTemas, colLibEstado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(21, 32, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 60, 82);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLibros.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLibros.EnableHeadersVisualStyles = false;
            dgvLibros.GridColor = Color.FromArgb(45, 60, 82);
            dgvLibros.Location = new Point(16, 122);
            dgvLibros.MultiSelect = false;
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.RowHeadersVisible = false;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(717, 180);
            dgvLibros.TabIndex = 4;
            dgvLibros.SelectionChanged += dgvLibros_SelectionChanged;
            // 
            // colLibCodigo
            // 
            colLibCodigo.FillWeight = 13F;
            colLibCodigo.HeaderText = "Código";
            colLibCodigo.Name = "colLibCodigo";
            colLibCodigo.ReadOnly = true;
            // 
            // colLibTitulo
            // 
            colLibTitulo.FillWeight = 35F;
            colLibTitulo.HeaderText = "Título";
            colLibTitulo.Name = "colLibTitulo";
            colLibTitulo.ReadOnly = true;
            // 
            // colLibAutores
            // 
            colLibAutores.FillWeight = 27F;
            colLibAutores.HeaderText = "Autores";
            colLibAutores.Name = "colLibAutores";
            colLibAutores.ReadOnly = true;
            // 
            // colLibTemas
            // 
            colLibTemas.FillWeight = 15F;
            colLibTemas.HeaderText = "Temas";
            colLibTemas.Name = "colLibTemas";
            colLibTemas.ReadOnly = true;
            // 
            // colLibEstado
            // 
            colLibEstado.FillWeight = 10F;
            colLibEstado.HeaderText = "Estado";
            colLibEstado.Name = "colLibEstado";
            colLibEstado.ReadOnly = true;
            // 
            // lblSeccionDatos
            // 
            lblSeccionDatos.AutoSize = true;
            lblSeccionDatos.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionDatos.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionDatos.Location = new Point(16, 316);
            lblSeccionDatos.Name = "lblSeccionDatos";
            lblSeccionDatos.Size = new Size(105, 12);
            lblSeccionDatos.TabIndex = 5;
            lblSeccionDatos.Text = "DATOS DEL LIBRO";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = Color.FromArgb(226, 232, 240);
            lblCodigo.Location = new Point(16, 334);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(252, 17);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "Código: — (se asigna al dar de alta)";
            // 
            // lblTituloLibro
            // 
            lblTituloLibro.AutoSize = true;
            lblTituloLibro.ForeColor = Color.FromArgb(148, 163, 184);
            lblTituloLibro.Location = new Point(16, 360);
            lblTituloLibro.Name = "lblTituloLibro";
            lblTituloLibro.Size = new Size(42, 17);
            lblTituloLibro.TabIndex = 7;
            lblTituloLibro.Text = "Título";
            // 
            // txtTituloLibro
            // 
            txtTituloLibro.BackColor = Color.FromArgb(21, 32, 48);
            txtTituloLibro.BorderStyle = BorderStyle.FixedSingle;
            txtTituloLibro.ForeColor = Color.FromArgb(226, 232, 240);
            txtTituloLibro.Location = new Point(16, 380);
            txtTituloLibro.MaxLength = 150;
            txtTituloLibro.Name = "txtTituloLibro";
            txtTituloLibro.Size = new Size(717, 24);
            txtTituloLibro.TabIndex = 8;
            // 
            // lblAutores
            // 
            lblAutores.AutoSize = true;
            lblAutores.ForeColor = Color.FromArgb(148, 163, 184);
            lblAutores.Location = new Point(16, 414);
            lblAutores.Name = "lblAutores";
            lblAutores.Size = new Size(154, 17);
            lblAutores.TabIndex = 9;
            lblAutores.Text = "Autores (al menos uno)";
            // 
            // txtBuscarAutor
            // 
            txtBuscarAutor.BackColor = Color.FromArgb(21, 32, 48);
            txtBuscarAutor.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarAutor.ForeColor = Color.FromArgb(226, 232, 240);
            txtBuscarAutor.Location = new Point(16, 434);
            txtBuscarAutor.Name = "txtBuscarAutor";
            txtBuscarAutor.PlaceholderText = "Buscar autor por nombre o apellido";
            txtBuscarAutor.Size = new Size(350, 24);
            txtBuscarAutor.TabIndex = 10;
            txtBuscarAutor.TextChanged += txtBuscarAutor_TextChanged;
            // 
            // clbAutores
            // 
            clbAutores.BackColor = Color.FromArgb(21, 32, 48);
            clbAutores.BorderStyle = BorderStyle.FixedSingle;
            clbAutores.CheckOnClick = true;
            clbAutores.ForeColor = Color.FromArgb(226, 232, 240);
            clbAutores.FormattingEnabled = true;
            clbAutores.Location = new Point(16, 462);
            clbAutores.Name = "clbAutores";
            clbAutores.Size = new Size(350, 92);
            clbAutores.TabIndex = 11;
            clbAutores.ItemCheck += clbAutores_ItemCheck;
            // 
            // lblTemas
            // 
            lblTemas.AutoSize = true;
            lblTemas.ForeColor = Color.FromArgb(148, 163, 184);
            lblTemas.Location = new Point(383, 414);
            lblTemas.Name = "lblTemas";
            lblTemas.Size = new Size(35, 17);
            lblTemas.TabIndex = 12;
            lblTemas.Text = "Temas";
            // 
            // clbTemas
            // 
            clbTemas.BackColor = Color.FromArgb(21, 32, 48);
            clbTemas.BorderStyle = BorderStyle.FixedSingle;
            clbTemas.CheckOnClick = true;
            clbTemas.ForeColor = Color.FromArgb(226, 232, 240);
            clbTemas.FormattingEnabled = true;
            clbTemas.Location = new Point(383, 434);
            clbTemas.Name = "clbTemas";
            clbTemas.Size = new Size(350, 120);
            clbTemas.TabIndex = 13;
            // 
            // lblNuevoAutor
            // 
            lblNuevoAutor.AutoSize = true;
            lblNuevoAutor.ForeColor = Color.FromArgb(148, 163, 184);
            lblNuevoAutor.Location = new Point(16, 562);
            lblNuevoAutor.Name = "lblNuevoAutor";
            lblNuevoAutor.Size = new Size(217, 17);
            lblNuevoAutor.TabIndex = 14;
            lblNuevoAutor.Text = "Nuevo autor (nombre y apellido)";
            // 
            // txtAutorNombre
            // 
            txtAutorNombre.BackColor = Color.FromArgb(21, 32, 48);
            txtAutorNombre.BorderStyle = BorderStyle.FixedSingle;
            txtAutorNombre.ForeColor = Color.FromArgb(226, 232, 240);
            txtAutorNombre.Location = new Point(16, 582);
            txtAutorNombre.MaxLength = 50;
            txtAutorNombre.Name = "txtAutorNombre";
            txtAutorNombre.Size = new Size(120, 24);
            txtAutorNombre.TabIndex = 15;
            // 
            // txtAutorApellido
            // 
            txtAutorApellido.BackColor = Color.FromArgb(21, 32, 48);
            txtAutorApellido.BorderStyle = BorderStyle.FixedSingle;
            txtAutorApellido.ForeColor = Color.FromArgb(226, 232, 240);
            txtAutorApellido.Location = new Point(142, 582);
            txtAutorApellido.MaxLength = 50;
            txtAutorApellido.Name = "txtAutorApellido";
            txtAutorApellido.Size = new Size(130, 24);
            txtAutorApellido.TabIndex = 16;
            // 
            // btnAgregarAutor
            // 
            btnAgregarAutor.BackColor = Color.FromArgb(45, 60, 82);
            btnAgregarAutor.Cursor = Cursors.Hand;
            btnAgregarAutor.FlatAppearance.BorderSize = 0;
            btnAgregarAutor.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 75, 99);
            btnAgregarAutor.FlatStyle = FlatStyle.Flat;
            btnAgregarAutor.ForeColor = Color.FromArgb(226, 232, 240);
            btnAgregarAutor.Location = new Point(278, 581);
            btnAgregarAutor.Name = "btnAgregarAutor";
            btnAgregarAutor.Size = new Size(88, 27);
            btnAgregarAutor.TabIndex = 17;
            btnAgregarAutor.Text = "➕ Agregar";
            btnAgregarAutor.UseVisualStyleBackColor = false;
            btnAgregarAutor.Click += btnAgregarAutor_Click;
            // 
            // lblNuevoTema
            // 
            lblNuevoTema.AutoSize = true;
            lblNuevoTema.ForeColor = Color.FromArgb(148, 163, 184);
            lblNuevoTema.Location = new Point(383, 562);
            lblNuevoTema.Name = "lblNuevoTema";
            lblNuevoTema.Size = new Size(70, 17);
            lblNuevoTema.TabIndex = 18;
            lblNuevoTema.Text = "Nuevo tema";
            // 
            // txtTema
            // 
            txtTema.BackColor = Color.FromArgb(21, 32, 48);
            txtTema.BorderStyle = BorderStyle.FixedSingle;
            txtTema.ForeColor = Color.FromArgb(226, 232, 240);
            txtTema.Location = new Point(383, 582);
            txtTema.MaxLength = 100;
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(256, 24);
            txtTema.TabIndex = 19;
            // 
            // btnAgregarTema
            // 
            btnAgregarTema.BackColor = Color.FromArgb(45, 60, 82);
            btnAgregarTema.Cursor = Cursors.Hand;
            btnAgregarTema.FlatAppearance.BorderSize = 0;
            btnAgregarTema.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 75, 99);
            btnAgregarTema.FlatStyle = FlatStyle.Flat;
            btnAgregarTema.ForeColor = Color.FromArgb(226, 232, 240);
            btnAgregarTema.Location = new Point(645, 581);
            btnAgregarTema.Name = "btnAgregarTema";
            btnAgregarTema.Size = new Size(88, 27);
            btnAgregarTema.TabIndex = 20;
            btnAgregarTema.Text = "➕ Agregar";
            btnAgregarTema.UseVisualStyleBackColor = false;
            btnAgregarTema.Click += btnAgregarTema_Click;
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
            btnAlta.Location = new Point(16, 626);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(120, 34);
            btnAlta.TabIndex = 21;
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
            btnModificar.Location = new Point(142, 626);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 34);
            btnModificar.TabIndex = 22;
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
            btnBaja.Location = new Point(268, 626);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(120, 34);
            btnBaja.TabIndex = 23;
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
            btnLimpiar.Location = new Point(394, 626);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 34);
            btnLimpiar.TabIndex = 24;
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
            btnCerrar.Location = new Point(633, 626);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 34);
            btnCerrar.TabIndex = 25;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 42, 58);
            ClientSize = new Size(749, 676);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBaja);
            Controls.Add(btnModificar);
            Controls.Add(btnAlta);
            Controls.Add(btnAgregarTema);
            Controls.Add(txtTema);
            Controls.Add(lblNuevoTema);
            Controls.Add(btnAgregarAutor);
            Controls.Add(txtAutorApellido);
            Controls.Add(txtAutorNombre);
            Controls.Add(lblNuevoAutor);
            Controls.Add(clbTemas);
            Controls.Add(lblTemas);
            Controls.Add(clbAutores);
            Controls.Add(txtBuscarAutor);
            Controls.Add(lblAutores);
            Controls.Add(txtTituloLibro);
            Controls.Add(lblTituloLibro);
            Controls.Add(lblCodigo);
            Controls.Add(lblSeccionDatos);
            Controls.Add(dgvLibros);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(lblSeccionLibros);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLibro";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de libros";
            Load += FormLibro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSeccionLibros;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private DataGridView dgvLibros;
        private DataGridViewTextBoxColumn colLibCodigo;
        private DataGridViewTextBoxColumn colLibTitulo;
        private DataGridViewTextBoxColumn colLibAutores;
        private DataGridViewTextBoxColumn colLibTemas;
        private DataGridViewTextBoxColumn colLibEstado;
        private Label lblSeccionDatos;
        private Label lblCodigo;
        private Label lblTituloLibro;
        private TextBox txtTituloLibro;
        private Label lblAutores;
        private TextBox txtBuscarAutor;
        private CheckedListBox clbAutores;
        private Label lblTemas;
        private CheckedListBox clbTemas;
        private Label lblNuevoAutor;
        private TextBox txtAutorNombre;
        private TextBox txtAutorApellido;
        private Button btnAgregarAutor;
        private Label lblNuevoTema;
        private TextBox txtTema;
        private Button btnAgregarTema;
        private Button btnAlta;
        private Button btnModificar;
        private Button btnBaja;
        private Button btnLimpiar;
        private Button btnCerrar;
    }
}
