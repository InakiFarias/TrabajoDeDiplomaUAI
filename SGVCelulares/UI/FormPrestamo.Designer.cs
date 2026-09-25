using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormPrestamo
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSeccionSocio = new Label();
            lblNumeroSocio = new Label();
            txtNumeroSocio = new TextBox();
            btnAgregarSocio = new Button();
            dgvSocios = new DataGridView();
            colSocNumero = new DataGridViewTextBoxColumn();
            colSocApellido = new DataGridViewTextBoxColumn();
            colSocNombre = new DataGridViewTextBoxColumn();
            colSocDni = new DataGridViewTextBoxColumn();
            colSocEstado = new DataGridViewTextBoxColumn();
            lblDatosSocio = new Label();
            lblEstadoSocio = new Label();
            lblSeccionEjemplares = new Label();
            lblBuscarEjemplar = new Label();
            txtBuscarEjemplar = new TextBox();
            dgvResultados = new DataGridView();
            colResCodigo = new DataGridViewTextBoxColumn();
            colResTitulo = new DataGridViewTextBoxColumn();
            colResAutor = new DataGridViewTextBoxColumn();
            colResEstado = new DataGridViewTextBoxColumn();
            btnAgregarEjemplar = new Button();
            lblSeccionDetalle = new Label();
            dgvDetalle = new DataGridView();
            colDetCodigo = new DataGridViewTextBoxColumn();
            colDetTitulo = new DataGridViewTextBoxColumn();
            colDetAutor = new DataGridViewTextBoxColumn();
            btnQuitarEjemplar = new Button();
            lblFechaPrestamo = new Label();
            lblFechaDevolucion = new Label();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F);
            lblTitulo.ForeColor = Color.FromArgb(226, 232, 240);
            lblTitulo.Location = new Point(16, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(170, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar préstamo";
            // 
            // lblSeccionSocio
            // 
            lblSeccionSocio.AutoSize = true;
            lblSeccionSocio.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionSocio.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionSocio.Location = new Point(16, 52);
            lblSeccionSocio.Name = "lblSeccionSocio";
            lblSeccionSocio.Size = new Size(36, 12);
            lblSeccionSocio.TabIndex = 1;
            lblSeccionSocio.Text = "SOCIO";
            // 
            // lblNumeroSocio
            // 
            lblNumeroSocio.AutoSize = true;
            lblNumeroSocio.ForeColor = Color.FromArgb(148, 163, 184);
            lblNumeroSocio.Location = new Point(16, 70);
            lblNumeroSocio.Name = "lblNumeroSocio";
            lblNumeroSocio.Size = new Size(251, 17);
            lblNumeroSocio.TabIndex = 2;
            lblNumeroSocio.Text = "Número de socio (búsqueda incremental)";
            // 
            // txtNumeroSocio
            // 
            txtNumeroSocio.BackColor = Color.FromArgb(21, 32, 48);
            txtNumeroSocio.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroSocio.ForeColor = Color.FromArgb(226, 232, 240);
            txtNumeroSocio.Location = new Point(16, 90);
            txtNumeroSocio.Name = "txtNumeroSocio";
            txtNumeroSocio.Size = new Size(300, 24);
            txtNumeroSocio.TabIndex = 3;
            txtNumeroSocio.TextChanged += txtNumeroSocio_TextChanged;
            // 
            // btnAgregarSocio
            // 
            btnAgregarSocio.BackColor = Color.FromArgb(45, 60, 82);
            btnAgregarSocio.Cursor = Cursors.Hand;
            btnAgregarSocio.FlatAppearance.BorderSize = 0;
            btnAgregarSocio.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 75, 99);
            btnAgregarSocio.FlatStyle = FlatStyle.Flat;
            btnAgregarSocio.ForeColor = Color.FromArgb(226, 232, 240);
            btnAgregarSocio.Location = new Point(324, 89);
            btnAgregarSocio.Name = "btnAgregarSocio";
            btnAgregarSocio.Size = new Size(120, 27);
            btnAgregarSocio.TabIndex = 4;
            btnAgregarSocio.Text = "➕ Agregar socio";
            btnAgregarSocio.UseVisualStyleBackColor = false;
            btnAgregarSocio.Click += btnAgregarSocio_Click;
            // 
            // dgvSocios
            // 
            dgvSocios.AllowUserToAddRows = false;
            dgvSocios.AllowUserToDeleteRows = false;
            dgvSocios.AllowUserToResizeRows = false;
            dgvSocios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSocios.BackgroundColor = Color.FromArgb(21, 32, 48);
            dgvSocios.BorderStyle = BorderStyle.None;
            dgvSocios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSocios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvSocios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Columns.AddRange(new DataGridViewColumn[] { colSocNumero, colSocApellido, colSocNombre, colSocDni, colSocEstado });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(21, 32, 48);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(45, 60, 82);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvSocios.DefaultCellStyle = dataGridViewCellStyle8;
            dgvSocios.EnableHeadersVisualStyles = false;
            dgvSocios.GridColor = Color.FromArgb(45, 60, 82);
            dgvSocios.Location = new Point(16, 120);
            dgvSocios.MultiSelect = false;
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.RowHeadersVisible = false;
            dgvSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSocios.Size = new Size(717, 90);
            dgvSocios.TabIndex = 5;
            // 
            // colSocNumero
            // 
            colSocNumero.FillWeight = 15F;
            colSocNumero.HeaderText = "Número";
            colSocNumero.Name = "colSocNumero";
            colSocNumero.ReadOnly = true;
            // 
            // colSocApellido
            // 
            colSocApellido.FillWeight = 25F;
            colSocApellido.HeaderText = "Apellido";
            colSocApellido.Name = "colSocApellido";
            colSocApellido.ReadOnly = true;
            // 
            // colSocNombre
            // 
            colSocNombre.FillWeight = 25F;
            colSocNombre.HeaderText = "Nombre";
            colSocNombre.Name = "colSocNombre";
            colSocNombre.ReadOnly = true;
            // 
            // colSocDni
            // 
            colSocDni.FillWeight = 20F;
            colSocDni.HeaderText = "DNI";
            colSocDni.Name = "colSocDni";
            colSocDni.ReadOnly = true;
            // 
            // colSocEstado
            // 
            colSocEstado.FillWeight = 15F;
            colSocEstado.HeaderText = "Estado";
            colSocEstado.Name = "colSocEstado";
            colSocEstado.ReadOnly = true;
            // 
            // lblDatosSocio
            // 
            lblDatosSocio.AutoSize = true;
            lblDatosSocio.ForeColor = Color.FromArgb(226, 232, 240);
            lblDatosSocio.Location = new Point(460, 76);
            lblDatosSocio.Name = "lblDatosSocio";
            lblDatosSocio.Size = new Size(60, 17);
            lblDatosSocio.TabIndex = 6;
            lblDatosSocio.Text = "Socio: —";
            // 
            // lblEstadoSocio
            // 
            lblEstadoSocio.AutoSize = true;
            lblEstadoSocio.ForeColor = Color.FromArgb(148, 163, 184);
            lblEstadoSocio.Location = new Point(460, 96);
            lblEstadoSocio.Name = "lblEstadoSocio";
            lblEstadoSocio.Size = new Size(68, 17);
            lblEstadoSocio.TabIndex = 7;
            lblEstadoSocio.Text = "Estado: —";
            // 
            // lblSeccionEjemplares
            // 
            lblSeccionEjemplares.AutoSize = true;
            lblSeccionEjemplares.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionEjemplares.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionEjemplares.Location = new Point(16, 222);
            lblSeccionEjemplares.Name = "lblSeccionEjemplares";
            lblSeccionEjemplares.Size = new Size(65, 12);
            lblSeccionEjemplares.TabIndex = 8;
            lblSeccionEjemplares.Text = "EJEMPLARES";
            // 
            // lblBuscarEjemplar
            // 
            lblBuscarEjemplar.AutoSize = true;
            lblBuscarEjemplar.ForeColor = Color.FromArgb(148, 163, 184);
            lblBuscarEjemplar.Location = new Point(16, 240);
            lblBuscarEjemplar.Name = "lblBuscarEjemplar";
            lblBuscarEjemplar.Size = new Size(208, 17);
            lblBuscarEjemplar.TabIndex = 9;
            lblBuscarEjemplar.Text = "Código de ejemplar, título o autor";
            // 
            // txtBuscarEjemplar
            // 
            txtBuscarEjemplar.BackColor = Color.FromArgb(21, 32, 48);
            txtBuscarEjemplar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarEjemplar.ForeColor = Color.FromArgb(226, 232, 240);
            txtBuscarEjemplar.Location = new Point(16, 260);
            txtBuscarEjemplar.Name = "txtBuscarEjemplar";
            txtBuscarEjemplar.Size = new Size(300, 24);
            txtBuscarEjemplar.TabIndex = 10;
            txtBuscarEjemplar.TextChanged += txtBuscarEjemplar_TextChanged;
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.AllowUserToDeleteRows = false;
            dgvResultados.AllowUserToResizeRows = false;
            dgvResultados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.BackgroundColor = Color.FromArgb(21, 32, 48);
            dgvResultados.BorderStyle = BorderStyle.None;
            dgvResultados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvResultados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { colResCodigo, colResTitulo, colResAutor, colResEstado });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(21, 32, 48);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(45, 60, 82);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvResultados.DefaultCellStyle = dataGridViewCellStyle10;
            dgvResultados.EnableHeadersVisualStyles = false;
            dgvResultados.GridColor = Color.FromArgb(45, 60, 82);
            dgvResultados.Location = new Point(16, 292);
            dgvResultados.MultiSelect = false;
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersVisible = false;
            dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultados.Size = new Size(717, 100);
            dgvResultados.TabIndex = 11;
            dgvResultados.CellDoubleClick += dgvResultados_CellDoubleClick;
            // 
            // colResCodigo
            // 
            colResCodigo.FillWeight = 20F;
            colResCodigo.HeaderText = "Código";
            colResCodigo.Name = "colResCodigo";
            colResCodigo.ReadOnly = true;
            // 
            // colResTitulo
            // 
            colResTitulo.FillWeight = 40F;
            colResTitulo.HeaderText = "Título";
            colResTitulo.Name = "colResTitulo";
            colResTitulo.ReadOnly = true;
            // 
            // colResAutor
            // 
            colResAutor.FillWeight = 25F;
            colResAutor.HeaderText = "Autor";
            colResAutor.Name = "colResAutor";
            colResAutor.ReadOnly = true;
            // 
            // colResEstado
            // 
            colResEstado.FillWeight = 15F;
            colResEstado.HeaderText = "Estado";
            colResEstado.Name = "colResEstado";
            colResEstado.ReadOnly = true;
            // 
            // btnAgregarEjemplar
            // 
            btnAgregarEjemplar.BackColor = Color.FromArgb(45, 60, 82);
            btnAgregarEjemplar.Cursor = Cursors.Hand;
            btnAgregarEjemplar.FlatAppearance.BorderSize = 0;
            btnAgregarEjemplar.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 75, 99);
            btnAgregarEjemplar.FlatStyle = FlatStyle.Flat;
            btnAgregarEjemplar.ForeColor = Color.FromArgb(226, 232, 240);
            btnAgregarEjemplar.Location = new Point(16, 398);
            btnAgregarEjemplar.Name = "btnAgregarEjemplar";
            btnAgregarEjemplar.Size = new Size(130, 30);
            btnAgregarEjemplar.TabIndex = 12;
            btnAgregarEjemplar.Text = "➕ Agregar";
            btnAgregarEjemplar.UseVisualStyleBackColor = false;
            btnAgregarEjemplar.Click += btnAgregarEjemplar_Click;
            // 
            // lblSeccionDetalle
            // 
            lblSeccionDetalle.AutoSize = true;
            lblSeccionDetalle.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionDetalle.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionDetalle.Location = new Point(16, 438);
            lblSeccionDetalle.Name = "lblSeccionDetalle";
            lblSeccionDetalle.Size = new Size(121, 12);
            lblSeccionDetalle.TabIndex = 13;
            lblSeccionDetalle.Text = "DETALLE DEL PRÉSTAMO";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.AllowUserToResizeRows = false;
            dgvDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.BackgroundColor = Color.FromArgb(21, 32, 48);
            dgvDetalle.BorderStyle = BorderStyle.None;
            dgvDetalle.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDetalle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { colDetCodigo, colDetTitulo, colDetAutor });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(21, 32, 48);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(45, 60, 82);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvDetalle.DefaultCellStyle = dataGridViewCellStyle12;
            dgvDetalle.EnableHeadersVisualStyles = false;
            dgvDetalle.GridColor = Color.FromArgb(45, 60, 82);
            dgvDetalle.Location = new Point(16, 456);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(717, 100);
            dgvDetalle.TabIndex = 14;
            // 
            // colDetCodigo
            // 
            colDetCodigo.FillWeight = 20F;
            colDetCodigo.HeaderText = "Código";
            colDetCodigo.Name = "colDetCodigo";
            colDetCodigo.ReadOnly = true;
            // 
            // colDetTitulo
            // 
            colDetTitulo.FillWeight = 50F;
            colDetTitulo.HeaderText = "Título";
            colDetTitulo.Name = "colDetTitulo";
            colDetTitulo.ReadOnly = true;
            // 
            // colDetAutor
            // 
            colDetAutor.FillWeight = 30F;
            colDetAutor.HeaderText = "Autor";
            colDetAutor.Name = "colDetAutor";
            colDetAutor.ReadOnly = true;
            // 
            // btnQuitarEjemplar
            // 
            btnQuitarEjemplar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnQuitarEjemplar.BackColor = Color.FromArgb(45, 60, 82);
            btnQuitarEjemplar.Cursor = Cursors.Hand;
            btnQuitarEjemplar.FlatAppearance.BorderSize = 0;
            btnQuitarEjemplar.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 75, 99);
            btnQuitarEjemplar.FlatStyle = FlatStyle.Flat;
            btnQuitarEjemplar.ForeColor = Color.FromArgb(226, 232, 240);
            btnQuitarEjemplar.Location = new Point(16, 562);
            btnQuitarEjemplar.Name = "btnQuitarEjemplar";
            btnQuitarEjemplar.Size = new Size(130, 30);
            btnQuitarEjemplar.TabIndex = 15;
            btnQuitarEjemplar.Text = "✖ Quitar";
            btnQuitarEjemplar.UseVisualStyleBackColor = false;
            btnQuitarEjemplar.Click += btnQuitarEjemplar_Click;
            // 
            // lblFechaPrestamo
            // 
            lblFechaPrestamo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFechaPrestamo.AutoSize = true;
            lblFechaPrestamo.ForeColor = Color.FromArgb(148, 163, 184);
            lblFechaPrestamo.Location = new Point(16, 602);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(143, 17);
            lblFechaPrestamo.TabIndex = 16;
            lblFechaPrestamo.Text = "Fecha del préstamo: —";
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.ForeColor = Color.FromArgb(226, 232, 240);
            lblFechaDevolucion.Location = new Point(16, 622);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(197, 17);
            lblFechaDevolucion.TabIndex = 17;
            lblFechaDevolucion.Text = "Fecha de devolución prevista: —";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(45, 60, 82);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 75, 99);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(226, 232, 240);
            btnCancelar.Location = new Point(527, 608);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 34);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmar.BackColor = Color.FromArgb(37, 99, 235);
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(633, 608);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(100, 34);
            btnConfirmar.TabIndex = 19;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FormPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 42, 58);
            ClientSize = new Size(749, 652);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(lblFechaDevolucion);
            Controls.Add(lblFechaPrestamo);
            Controls.Add(btnQuitarEjemplar);
            Controls.Add(dgvDetalle);
            Controls.Add(lblSeccionDetalle);
            Controls.Add(btnAgregarEjemplar);
            Controls.Add(dgvResultados);
            Controls.Add(txtBuscarEjemplar);
            Controls.Add(lblBuscarEjemplar);
            Controls.Add(lblSeccionEjemplares);
            Controls.Add(lblEstadoSocio);
            Controls.Add(lblDatosSocio);
            Controls.Add(dgvSocios);
            Controls.Add(btnAgregarSocio);
            Controls.Add(txtNumeroSocio);
            Controls.Add(lblNumeroSocio);
            Controls.Add(lblSeccionSocio);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrestamo";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrar préstamo";
            Load += FormPrestamo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSeccionSocio;
        private Label lblNumeroSocio;
        private TextBox txtNumeroSocio;
        private Button btnAgregarSocio;
        private DataGridView dgvSocios;
        private DataGridViewTextBoxColumn colSocNumero;
        private DataGridViewTextBoxColumn colSocApellido;
        private DataGridViewTextBoxColumn colSocNombre;
        private DataGridViewTextBoxColumn colSocDni;
        private DataGridViewTextBoxColumn colSocEstado;
        private Label lblDatosSocio;
        private Label lblEstadoSocio;
        private Label lblSeccionEjemplares;
        private Label lblBuscarEjemplar;
        private TextBox txtBuscarEjemplar;
        private DataGridView dgvResultados;
        private DataGridViewTextBoxColumn colResCodigo;
        private DataGridViewTextBoxColumn colResTitulo;
        private DataGridViewTextBoxColumn colResAutor;
        private DataGridViewTextBoxColumn colResEstado;
        private Button btnAgregarEjemplar;
        private Label lblSeccionDetalle;
        private DataGridView dgvDetalle;
        private DataGridViewTextBoxColumn colDetCodigo;
        private DataGridViewTextBoxColumn colDetTitulo;
        private DataGridViewTextBoxColumn colDetAutor;
        private Button btnQuitarEjemplar;
        private Label lblFechaPrestamo;
        private Label lblFechaDevolucion;
        private Button btnCancelar;
        private Button btnConfirmar;
    }
}