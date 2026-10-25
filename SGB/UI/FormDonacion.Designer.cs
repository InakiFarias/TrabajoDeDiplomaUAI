using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormDonacion
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSeccionSocio = new Label();
            lblDni = new Label();
            txtDni = new TextBox();
            btnAgregarSocio = new Button();
            lblDatosSocio = new Label();
            dgvSocios = new DataGridView();
            colSocNumero = new DataGridViewTextBoxColumn();
            colSocApellido = new DataGridViewTextBoxColumn();
            colSocNombre = new DataGridViewTextBoxColumn();
            colSocDni = new DataGridViewTextBoxColumn();
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
            lblTitulo.Size = new Size(126, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar donación";
            // 
            // lblSeccionSocio
            // 
            lblSeccionSocio.AutoSize = true;
            lblSeccionSocio.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionSocio.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionSocio.Location = new Point(16, 52);
            lblSeccionSocio.Name = "lblSeccionSocio";
            lblSeccionSocio.Size = new Size(91, 12);
            lblSeccionSocio.TabIndex = 1;
            lblSeccionSocio.Text = "SOCIO DONANTE";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.ForeColor = Color.FromArgb(148, 163, 184);
            lblDni.Location = new Point(16, 70);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(252, 17);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI del socio (búsqueda incremental)";
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.FromArgb(21, 32, 48);
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.ForeColor = Color.FromArgb(226, 232, 240);
            txtDni.Location = new Point(16, 90);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(300, 24);
            txtDni.TabIndex = 3;
            txtDni.TextChanged += txtDni_TextChanged;
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
            // lblDatosSocio
            // 
            lblDatosSocio.AutoSize = true;
            lblDatosSocio.ForeColor = Color.FromArgb(226, 232, 240);
            lblDatosSocio.Location = new Point(460, 94);
            lblDatosSocio.Name = "lblDatosSocio";
            lblDatosSocio.Size = new Size(56, 17);
            lblDatosSocio.TabIndex = 5;
            lblDatosSocio.Text = "Socio: —";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSocios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Columns.AddRange(new DataGridViewColumn[] { colSocNumero, colSocApellido, colSocNombre, colSocDni });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(21, 32, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 60, 82);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSocios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSocios.EnableHeadersVisualStyles = false;
            dgvSocios.GridColor = Color.FromArgb(45, 60, 82);
            dgvSocios.Location = new Point(16, 120);
            dgvSocios.MultiSelect = false;
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.RowHeadersVisible = false;
            dgvSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSocios.Size = new Size(717, 90);
            dgvSocios.TabIndex = 6;
            dgvSocios.CellDoubleClick += dgvSocios_CellDoubleClick;
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
            colSocApellido.FillWeight = 30F;
            colSocApellido.HeaderText = "Apellido";
            colSocApellido.Name = "colSocApellido";
            colSocApellido.ReadOnly = true;
            // 
            // colSocNombre
            // 
            colSocNombre.FillWeight = 30F;
            colSocNombre.HeaderText = "Nombre";
            colSocNombre.Name = "colSocNombre";
            colSocNombre.ReadOnly = true;
            // 
            // colSocDni
            // 
            colSocDni.FillWeight = 25F;
            colSocDni.HeaderText = "DNI";
            colSocDni.Name = "colSocDni";
            colSocDni.ReadOnly = true;
            // 
            // lblSeccionEjemplares
            // 
            lblSeccionEjemplares.AutoSize = true;
            lblSeccionEjemplares.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionEjemplares.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionEjemplares.Location = new Point(16, 222);
            lblSeccionEjemplares.Name = "lblSeccionEjemplares";
            lblSeccionEjemplares.Size = new Size(126, 12);
            lblSeccionEjemplares.TabIndex = 7;
            lblSeccionEjemplares.Text = "EJEMPLARES DONADOS";
            // 
            // lblBuscarEjemplar
            // 
            lblBuscarEjemplar.AutoSize = true;
            lblBuscarEjemplar.ForeColor = Color.FromArgb(148, 163, 184);
            lblBuscarEjemplar.Location = new Point(16, 240);
            lblBuscarEjemplar.Name = "lblBuscarEjemplar";
            lblBuscarEjemplar.Size = new Size(238, 17);
            lblBuscarEjemplar.TabIndex = 8;
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
            txtBuscarEjemplar.TabIndex = 9;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { colResCodigo, colResTitulo, colResAutor, colResEstado });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(21, 32, 48);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(45, 60, 82);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvResultados.DefaultCellStyle = dataGridViewCellStyle4;
            dgvResultados.EnableHeadersVisualStyles = false;
            dgvResultados.GridColor = Color.FromArgb(45, 60, 82);
            dgvResultados.Location = new Point(16, 292);
            dgvResultados.MultiSelect = false;
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersVisible = false;
            dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultados.Size = new Size(717, 100);
            dgvResultados.TabIndex = 10;
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
            btnAgregarEjemplar.TabIndex = 11;
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
            lblSeccionDetalle.Size = new Size(154, 12);
            lblSeccionDetalle.TabIndex = 12;
            lblSeccionDetalle.Text = "DETALLE DE LA DONACIÓN";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.AllowUserToResizeRows = false;
            dgvDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.BackgroundColor = Color.FromArgb(21, 32, 48);
            dgvDetalle.BorderStyle = BorderStyle.None;
            dgvDetalle.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDetalle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { colDetCodigo, colDetTitulo, colDetAutor });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(21, 32, 48);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(45, 60, 82);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDetalle.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDetalle.EnableHeadersVisualStyles = false;
            dgvDetalle.GridColor = Color.FromArgb(45, 60, 82);
            dgvDetalle.Location = new Point(16, 456);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(717, 100);
            dgvDetalle.TabIndex = 13;
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
            btnQuitarEjemplar.BackColor = Color.FromArgb(45, 60, 82);
            btnQuitarEjemplar.Cursor = Cursors.Hand;
            btnQuitarEjemplar.FlatAppearance.BorderSize = 0;
            btnQuitarEjemplar.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 75, 99);
            btnQuitarEjemplar.FlatStyle = FlatStyle.Flat;
            btnQuitarEjemplar.ForeColor = Color.FromArgb(226, 232, 240);
            btnQuitarEjemplar.Location = new Point(16, 562);
            btnQuitarEjemplar.Name = "btnQuitarEjemplar";
            btnQuitarEjemplar.Size = new Size(130, 30);
            btnQuitarEjemplar.TabIndex = 14;
            btnQuitarEjemplar.Text = "✖ Quitar";
            btnQuitarEjemplar.UseVisualStyleBackColor = false;
            btnQuitarEjemplar.Click += btnQuitarEjemplar_Click;
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
            btnCancelar.Location = new Point(527, 576);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 34);
            btnCancelar.TabIndex = 15;
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
            btnConfirmar.Location = new Point(633, 576);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(100, 34);
            btnConfirmar.TabIndex = 16;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FormDonacion
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 42, 58);
            ClientSize = new Size(749, 622);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(btnQuitarEjemplar);
            Controls.Add(dgvDetalle);
            Controls.Add(lblSeccionDetalle);
            Controls.Add(btnAgregarEjemplar);
            Controls.Add(dgvResultados);
            Controls.Add(txtBuscarEjemplar);
            Controls.Add(lblBuscarEjemplar);
            Controls.Add(lblSeccionEjemplares);
            Controls.Add(dgvSocios);
            Controls.Add(lblDatosSocio);
            Controls.Add(btnAgregarSocio);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(lblSeccionSocio);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDonacion";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrar donación";
            Load += FormDonacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSeccionSocio;
        private Label lblDni;
        private TextBox txtDni;
        private Button btnAgregarSocio;
        private Label lblDatosSocio;
        private DataGridView dgvSocios;
        private DataGridViewTextBoxColumn colSocNumero;
        private DataGridViewTextBoxColumn colSocApellido;
        private DataGridViewTextBoxColumn colSocNombre;
        private DataGridViewTextBoxColumn colSocDni;
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
        private Button btnCancelar;
        private Button btnConfirmar;
    }
}
