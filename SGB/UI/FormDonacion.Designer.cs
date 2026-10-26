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
            tlpPrincipal = new TableLayoutPanel();
            crdSocio = new TarjetaSGB();
            lblSeccionSocio = new Label();
            lblDni = new Label();
            txtDni = new TextBox();
            btnAgregarSocio = new BotonSGB();
            dgvSocios = new GrillaSGB();
            colSocNumero = new DataGridViewTextBoxColumn();
            colSocApellido = new DataGridViewTextBoxColumn();
            colSocNombre = new DataGridViewTextBoxColumn();
            colSocDni = new DataGridViewTextBoxColumn();
            lblDatosSocio = new Label();
            crdEjemplares = new TarjetaSGB();
            lblSeccionEjemplares = new Label();
            lblBuscarLibro = new Label();
            txtBuscarLibro = new TextBox();
            btnAgregarEjemplar = new BotonSGB();
            dgvLibros = new GrillaSGB();
            colLibCodigo = new DataGridViewTextBoxColumn();
            colLibTitulo = new DataGridViewTextBoxColumn();
            colLibAutores = new DataGridViewTextBoxColumn();
            lblAyudaLibro = new Label();
            crdDetalle = new TarjetaSGB();
            lblSeccionDetalle = new Label();
            lblDetalleCantidad = new Label();
            dgvDetalle = new GrillaSGB();
            colDetLibro = new DataGridViewTextBoxColumn();
            colDetTitulo = new DataGridViewTextBoxColumn();
            colDetAutor = new DataGridViewTextBoxColumn();
            btnQuitarEjemplar = new BotonSGB();
            lblAyudaDetalle = new Label();
            crdDonaciones = new TarjetaSGB();
            lblSeccionDonaciones = new Label();
            dgvDonaciones = new GrillaSGB();
            colDonNumero = new DataGridViewTextBoxColumn();
            colDonFecha = new DataGridViewTextBoxColumn();
            colDonSocio = new DataGridViewTextBoxColumn();
            colDonCantidad = new DataGridViewTextBoxColumn();
            colDonLibros = new DataGridViewTextBoxColumn();
            pnlAcciones = new FlowLayoutPanel();
            btnConfirmar = new BotonSGB();
            btnCancelar = new BotonSGB();
            tlpPrincipal.SuspendLayout();
            crdSocio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            crdEjemplares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            crdDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            crdDonaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonaciones).BeginInit();
            pnlAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal.ColumnCount = 2;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));
            tlpPrincipal.Controls.Add(crdSocio, 0, 0);
            tlpPrincipal.Controls.Add(crdEjemplares, 1, 0);
            tlpPrincipal.Controls.Add(crdDetalle, 0, 1);
            tlpPrincipal.Controls.Add(crdDonaciones, 1, 1);
            tlpPrincipal.Controls.Add(pnlAcciones, 0, 2);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(12);
            tlpPrincipal.RowCount = 3;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 55.0F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 45.0F));
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
            crdSocio.Controls.Add(btnAgregarSocio);
            crdSocio.Controls.Add(dgvSocios);
            crdSocio.Controls.Add(lblDatosSocio);
            crdSocio.Dock = DockStyle.Fill;
            crdSocio.Margin = new Padding(8);
            crdSocio.Name = "crdSocio";
            crdSocio.Size = new Size(522, 292);
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
            lblSeccionSocio.Size = new Size(104, 20);
            lblSeccionSocio.TabIndex = 0;
            lblSeccionSocio.Text = "Socio donante";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.Transparent;
            lblDni.Font = new Font("Segoe UI", 10F);
            lblDni.ForeColor = Color.FromArgb(75, 85, 99);
            lblDni.Location = new Point(20, 52);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(288, 20);
            lblDni.TabIndex = 1;
            lblDni.Text = "DNI del socio (búsqueda incremental)";
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.ForeColor = Color.FromArgb(31, 41, 55);
            txtDni.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDni.Location = new Point(20, 74);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(322, 27);
            txtDni.TabIndex = 2;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // btnAgregarSocio
            // 
            btnAgregarSocio.Estilo = EstiloBoton.Secundario;
            btnAgregarSocio.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAgregarSocio.Icono = "\uE73E";
            btnAgregarSocio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarSocio.Location = new Point(352, 71);
            btnAgregarSocio.Name = "btnAgregarSocio";
            btnAgregarSocio.Size = new Size(150, 32);
            btnAgregarSocio.TabIndex = 3;
            btnAgregarSocio.Text = "Seleccionar";
            btnAgregarSocio.Click += btnAgregarSocio_Click;
            // 
            // dgvSocios
            // 
            dgvSocios.Columns.AddRange(new DataGridViewColumn[] { colSocNumero, colSocApellido, colSocNombre, colSocDni });
            dgvSocios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSocios.Location = new Point(20, 116);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.Size = new Size(482, 128);
            dgvSocios.TabIndex = 4;
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
            dgvSocios.CellDoubleClick += dgvSocios_CellDoubleClick;
            // 
            // lblDatosSocio
            // 
            lblDatosSocio.AutoSize = true;
            lblDatosSocio.BackColor = Color.Transparent;
            lblDatosSocio.Font = new Font("Segoe UI", 11F);
            lblDatosSocio.ForeColor = Color.FromArgb(31, 41, 55);
            lblDatosSocio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDatosSocio.Location = new Point(20, 256);
            lblDatosSocio.Name = "lblDatosSocio";
            lblDatosSocio.Size = new Size(64, 20);
            lblDatosSocio.TabIndex = 5;
            lblDatosSocio.Text = "Socio: —";
            // 
            // crdEjemplares
            // 
            crdEjemplares.Controls.Add(lblSeccionEjemplares);
            crdEjemplares.Controls.Add(lblBuscarLibro);
            crdEjemplares.Controls.Add(txtBuscarLibro);
            crdEjemplares.Controls.Add(btnAgregarEjemplar);
            crdEjemplares.Controls.Add(dgvLibros);
            crdEjemplares.Controls.Add(lblAyudaLibro);
            crdEjemplares.Dock = DockStyle.Fill;
            crdEjemplares.Margin = new Padding(8);
            crdEjemplares.Name = "crdEjemplares";
            crdEjemplares.Size = new Size(522, 292);
            crdEjemplares.TabIndex = 1;
            // 
            // lblSeccionEjemplares
            // 
            lblSeccionEjemplares.AutoSize = true;
            lblSeccionEjemplares.BackColor = Color.Transparent;
            lblSeccionEjemplares.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionEjemplares.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionEjemplares.Location = new Point(20, 16);
            lblSeccionEjemplares.Name = "lblSeccionEjemplares";
            lblSeccionEjemplares.Size = new Size(112, 20);
            lblSeccionEjemplares.TabIndex = 0;
            lblSeccionEjemplares.Text = "Libros donados";
            // 
            // lblBuscarLibro
            // 
            lblBuscarLibro.AutoSize = true;
            lblBuscarLibro.BackColor = Color.Transparent;
            lblBuscarLibro.Font = new Font("Segoe UI", 10F);
            lblBuscarLibro.ForeColor = Color.FromArgb(75, 85, 99);
            lblBuscarLibro.Location = new Point(20, 52);
            lblBuscarLibro.Name = "lblBuscarLibro";
            lblBuscarLibro.Size = new Size(440, 20);
            lblBuscarLibro.TabIndex = 1;
            lblBuscarLibro.Text = "Código, título o autor del libro (búsqueda incremental)";
            // 
            // txtBuscarLibro
            // 
            txtBuscarLibro.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarLibro.ForeColor = Color.FromArgb(31, 41, 55);
            txtBuscarLibro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarLibro.Location = new Point(20, 74);
            txtBuscarLibro.Name = "txtBuscarLibro";
            txtBuscarLibro.Size = new Size(322, 27);
            txtBuscarLibro.TabIndex = 2;
            txtBuscarLibro.TextChanged += txtBuscarLibro_TextChanged;
            // 
            // btnAgregarEjemplar
            // 
            btnAgregarEjemplar.Estilo = EstiloBoton.Secundario;
            btnAgregarEjemplar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAgregarEjemplar.Icono = "\uE710";
            btnAgregarEjemplar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarEjemplar.Location = new Point(352, 71);
            btnAgregarEjemplar.Name = "btnAgregarEjemplar";
            btnAgregarEjemplar.Size = new Size(150, 32);
            btnAgregarEjemplar.TabIndex = 3;
            btnAgregarEjemplar.Text = "Agregar";
            btnAgregarEjemplar.Click += btnAgregarEjemplar_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.Columns.AddRange(new DataGridViewColumn[] { colLibCodigo, colLibTitulo, colLibAutores });
            dgvLibros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLibros.Location = new Point(20, 116);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(482, 128);
            dgvLibros.TabIndex = 4;
            // 
            // colLibCodigo
            // 
            colLibCodigo.FillWeight = 18F;
            colLibCodigo.HeaderText = "Código";
            colLibCodigo.Name = "colLibCodigo";
            colLibCodigo.ReadOnly = true;
            // 
            // colLibTitulo
            // 
            colLibTitulo.FillWeight = 47F;
            colLibTitulo.HeaderText = "Título";
            colLibTitulo.Name = "colLibTitulo";
            colLibTitulo.ReadOnly = true;
            // 
            // colLibAutores
            // 
            colLibAutores.FillWeight = 35F;
            colLibAutores.HeaderText = "Autores";
            colLibAutores.Name = "colLibAutores";
            colLibAutores.ReadOnly = true;
            dgvLibros.CellDoubleClick += dgvLibros_CellDoubleClick;
            // 
            // lblAyudaLibro
            // 
            lblAyudaLibro.AutoSize = true;
            lblAyudaLibro.BackColor = Color.Transparent;
            lblAyudaLibro.Font = new Font("Segoe UI", 9.5F);
            lblAyudaLibro.ForeColor = Color.FromArgb(107, 114, 128);
            lblAyudaLibro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAyudaLibro.Location = new Point(20, 256);
            lblAyudaLibro.Name = "lblAyudaLibro";
            lblAyudaLibro.Size = new Size(608, 20);
            lblAyudaLibro.TabIndex = 5;
            lblAyudaLibro.Text = "Si el libro no está en el catálogo, regístrelo primero en Gestión de libros.";
            // 
            // crdDetalle
            // 
            crdDetalle.Controls.Add(lblSeccionDetalle);
            crdDetalle.Controls.Add(lblDetalleCantidad);
            crdDetalle.Controls.Add(dgvDetalle);
            crdDetalle.Controls.Add(btnQuitarEjemplar);
            crdDetalle.Controls.Add(lblAyudaDetalle);
            crdDetalle.Dock = DockStyle.Fill;
            crdDetalle.Margin = new Padding(8);
            crdDetalle.Name = "crdDetalle";
            crdDetalle.Size = new Size(522, 236);
            crdDetalle.TabIndex = 2;
            // 
            // lblSeccionDetalle
            // 
            lblSeccionDetalle.AutoSize = true;
            lblSeccionDetalle.BackColor = Color.Transparent;
            lblSeccionDetalle.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionDetalle.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionDetalle.Location = new Point(20, 16);
            lblSeccionDetalle.Name = "lblSeccionDetalle";
            lblSeccionDetalle.Size = new Size(176, 20);
            lblSeccionDetalle.TabIndex = 0;
            lblSeccionDetalle.Text = "Detalle de la donación";
            // 
            // lblDetalleCantidad
            // 
            lblDetalleCantidad.AutoSize = true;
            lblDetalleCantidad.BackColor = Color.Transparent;
            lblDetalleCantidad.Font = new Font("Segoe UI", 11F);
            lblDetalleCantidad.ForeColor = Color.FromArgb(31, 41, 55);
            lblDetalleCantidad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDetalleCantidad.Location = new Point(372, 20);
            lblDetalleCantidad.Name = "lblDetalleCantidad";
            lblDetalleCantidad.Size = new Size(104, 20);
            lblDetalleCantidad.TabIndex = 1;
            lblDetalleCantidad.Text = "Ejemplares: 0";
            // 
            // dgvDetalle
            // 
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { colDetLibro, colDetTitulo, colDetAutor });
            dgvDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalle.Location = new Point(20, 52);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.Size = new Size(482, 120);
            dgvDetalle.TabIndex = 2;
            // 
            // colDetLibro
            // 
            colDetLibro.FillWeight = 20F;
            colDetLibro.HeaderText = "Libro";
            colDetLibro.Name = "colDetLibro";
            colDetLibro.ReadOnly = true;
            // 
            // colDetTitulo
            // 
            colDetTitulo.FillWeight = 48F;
            colDetTitulo.HeaderText = "Título";
            colDetTitulo.Name = "colDetTitulo";
            colDetTitulo.ReadOnly = true;
            // 
            // colDetAutor
            // 
            colDetAutor.FillWeight = 32F;
            colDetAutor.HeaderText = "Autor";
            colDetAutor.Name = "colDetAutor";
            colDetAutor.ReadOnly = true;
            // 
            // btnQuitarEjemplar
            // 
            btnQuitarEjemplar.Estilo = EstiloBoton.Secundario;
            btnQuitarEjemplar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnQuitarEjemplar.Icono = "\uE74D";
            btnQuitarEjemplar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnQuitarEjemplar.Location = new Point(20, 182);
            btnQuitarEjemplar.Name = "btnQuitarEjemplar";
            btnQuitarEjemplar.Size = new Size(120, 36);
            btnQuitarEjemplar.TabIndex = 3;
            btnQuitarEjemplar.Text = "Quitar";
            btnQuitarEjemplar.Click += btnQuitarEjemplar_Click;
            // 
            // lblAyudaDetalle
            // 
            lblAyudaDetalle.AutoSize = true;
            lblAyudaDetalle.BackColor = Color.Transparent;
            lblAyudaDetalle.Font = new Font("Segoe UI", 9.5F);
            lblAyudaDetalle.ForeColor = Color.FromArgb(107, 114, 128);
            lblAyudaDetalle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAyudaDetalle.Location = new Point(152, 192);
            lblAyudaDetalle.Name = "lblAyudaDetalle";
            lblAyudaDetalle.Size = new Size(288, 20);
            lblAyudaDetalle.TabIndex = 4;
            lblAyudaDetalle.Text = "Los códigos se asignan al confirmar.";
            // 
            // crdDonaciones
            // 
            crdDonaciones.Controls.Add(lblSeccionDonaciones);
            crdDonaciones.Controls.Add(dgvDonaciones);
            crdDonaciones.Dock = DockStyle.Fill;
            crdDonaciones.Margin = new Padding(8);
            crdDonaciones.Name = "crdDonaciones";
            crdDonaciones.Size = new Size(522, 236);
            crdDonaciones.TabIndex = 3;
            // 
            // lblSeccionDonaciones
            // 
            lblSeccionDonaciones.AutoSize = true;
            lblSeccionDonaciones.BackColor = Color.Transparent;
            lblSeccionDonaciones.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionDonaciones.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionDonaciones.Location = new Point(20, 16);
            lblSeccionDonaciones.Name = "lblSeccionDonaciones";
            lblSeccionDonaciones.Size = new Size(176, 20);
            lblSeccionDonaciones.TabIndex = 0;
            lblSeccionDonaciones.Text = "Donaciones registradas";
            // 
            // dgvDonaciones
            // 
            dgvDonaciones.Columns.AddRange(new DataGridViewColumn[] { colDonNumero, colDonFecha, colDonSocio, colDonCantidad, colDonLibros });
            dgvDonaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDonaciones.Location = new Point(20, 52);
            dgvDonaciones.Name = "dgvDonaciones";
            dgvDonaciones.Size = new Size(482, 164);
            dgvDonaciones.TabIndex = 1;
            // 
            // colDonNumero
            // 
            colDonNumero.FillWeight = 10F;
            colDonNumero.HeaderText = "N°";
            colDonNumero.Name = "colDonNumero";
            colDonNumero.ReadOnly = true;
            // 
            // colDonFecha
            // 
            colDonFecha.FillWeight = 18F;
            colDonFecha.HeaderText = "Fecha";
            colDonFecha.Name = "colDonFecha";
            colDonFecha.ReadOnly = true;
            // 
            // colDonSocio
            // 
            colDonSocio.FillWeight = 30F;
            colDonSocio.HeaderText = "Socio";
            colDonSocio.Name = "colDonSocio";
            colDonSocio.ReadOnly = true;
            // 
            // colDonCantidad
            // 
            colDonCantidad.FillWeight = 14F;
            colDonCantidad.HeaderText = "Ejemplares";
            colDonCantidad.Name = "colDonCantidad";
            colDonCantidad.ReadOnly = true;
            // 
            // colDonLibros
            // 
            colDonLibros.FillWeight = 28F;
            colDonLibros.HeaderText = "Libros";
            colDonLibros.Name = "colDonLibros";
            colDonLibros.ReadOnly = true;
            // 
            // pnlAcciones
            // 
            pnlAcciones.BackColor = Color.Transparent;
            pnlAcciones.Controls.Add(btnConfirmar);
            pnlAcciones.Controls.Add(btnCancelar);
            pnlAcciones.FlowDirection = FlowDirection.RightToLeft;
            pnlAcciones.WrapContents = false;
            pnlAcciones.Dock = DockStyle.Fill;
            pnlAcciones.Margin = new Padding(8);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(400, 40);
            pnlAcciones.TabIndex = 4;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnConfirmar.Icono = "\uE73E";
            btnConfirmar.Margin = new Padding(12, 0, 0, 0);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(220, 40);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar donación";
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Estilo = EstiloBoton.Secundario;
            btnCancelar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnCancelar.Icono = "\uE711";
            btnCancelar.Margin = new Padding(12, 0, 0, 0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 40);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormDonacion
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDonacion";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar donación";
            Load += FormDonacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDonaciones).EndInit();
            pnlAcciones.ResumeLayout(false);
            pnlAcciones.PerformLayout();
            crdDonaciones.ResumeLayout(false);
            crdDonaciones.PerformLayout();
            crdDetalle.ResumeLayout(false);
            crdDetalle.PerformLayout();
            crdEjemplares.ResumeLayout(false);
            crdEjemplares.PerformLayout();
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
        private BotonSGB btnAgregarSocio;
        private GrillaSGB dgvSocios;
        private DataGridViewTextBoxColumn colSocNumero;
        private DataGridViewTextBoxColumn colSocApellido;
        private DataGridViewTextBoxColumn colSocNombre;
        private DataGridViewTextBoxColumn colSocDni;
        private Label lblDatosSocio;
        private TarjetaSGB crdEjemplares;
        private Label lblSeccionEjemplares;
        private Label lblBuscarLibro;
        private TextBox txtBuscarLibro;
        private BotonSGB btnAgregarEjemplar;
        private GrillaSGB dgvLibros;
        private DataGridViewTextBoxColumn colLibCodigo;
        private DataGridViewTextBoxColumn colLibTitulo;
        private DataGridViewTextBoxColumn colLibAutores;
        private Label lblAyudaLibro;
        private TarjetaSGB crdDetalle;
        private Label lblSeccionDetalle;
        private Label lblDetalleCantidad;
        private GrillaSGB dgvDetalle;
        private DataGridViewTextBoxColumn colDetLibro;
        private DataGridViewTextBoxColumn colDetTitulo;
        private DataGridViewTextBoxColumn colDetAutor;
        private BotonSGB btnQuitarEjemplar;
        private Label lblAyudaDetalle;
        private TarjetaSGB crdDonaciones;
        private Label lblSeccionDonaciones;
        private GrillaSGB dgvDonaciones;
        private DataGridViewTextBoxColumn colDonNumero;
        private DataGridViewTextBoxColumn colDonFecha;
        private DataGridViewTextBoxColumn colDonSocio;
        private DataGridViewTextBoxColumn colDonCantidad;
        private DataGridViewTextBoxColumn colDonLibros;
        private FlowLayoutPanel pnlAcciones;
        private BotonSGB btnConfirmar;
        private BotonSGB btnCancelar;
    }
}
