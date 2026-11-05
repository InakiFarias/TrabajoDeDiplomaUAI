using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormDonacion_351FI
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
            crdSocio_351FI = new TarjetaSGB_351FI();
            lblSeccionSocio_351FI = new Label();
            lblDni_351FI = new Label();
            txtDni_351FI = new TextBox();
            btnAgregarSocio_351FI = new BotonSGB_351FI();
            dgvSocios_351FI = new GrillaSGB_351FI();
            colSocNumero_351FI = new DataGridViewTextBoxColumn();
            colSocApellido_351FI = new DataGridViewTextBoxColumn();
            colSocNombre_351FI = new DataGridViewTextBoxColumn();
            colSocDni_351FI = new DataGridViewTextBoxColumn();
            lblDatosSocio_351FI = new Label();
            crdEjemplares_351FI = new TarjetaSGB_351FI();
            lblSeccionEjemplares_351FI = new Label();
            lblBuscarLibro_351FI = new Label();
            txtBuscarLibro_351FI = new TextBox();
            btnAgregarEjemplar_351FI = new BotonSGB_351FI();
            dgvLibros_351FI = new GrillaSGB_351FI();
            colLibCodigo_351FI = new DataGridViewTextBoxColumn();
            colLibTitulo_351FI = new DataGridViewTextBoxColumn();
            colLibAutores_351FI = new DataGridViewTextBoxColumn();
            lblAyudaLibro_351FI = new Label();
            crdDetalle_351FI = new TarjetaSGB_351FI();
            lblSeccionDetalle_351FI = new Label();
            lblDetalleCantidad_351FI = new Label();
            dgvDetalle_351FI = new GrillaSGB_351FI();
            colDetLibro_351FI = new DataGridViewTextBoxColumn();
            colDetTitulo_351FI = new DataGridViewTextBoxColumn();
            colDetAutor_351FI = new DataGridViewTextBoxColumn();
            btnQuitarEjemplar_351FI = new BotonSGB_351FI();
            lblAyudaDetalle_351FI = new Label();
            crdDonaciones_351FI = new TarjetaSGB_351FI();
            lblSeccionDonaciones_351FI = new Label();
            dgvDonaciones_351FI = new GrillaSGB_351FI();
            colDonNumero_351FI = new DataGridViewTextBoxColumn();
            colDonFecha_351FI = new DataGridViewTextBoxColumn();
            colDonSocio_351FI = new DataGridViewTextBoxColumn();
            colDonCantidad_351FI = new DataGridViewTextBoxColumn();
            colDonLibros_351FI = new DataGridViewTextBoxColumn();
            pnlAcciones_351FI = new FlowLayoutPanel();
            btnConfirmar_351FI = new BotonSGB_351FI();
            btnCancelar_351FI = new BotonSGB_351FI();
            tlpPrincipal_351FI.SuspendLayout();
            crdSocio_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios_351FI).BeginInit();
            crdEjemplares_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros_351FI).BeginInit();
            crdDetalle_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle_351FI).BeginInit();
            crdDonaciones_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonaciones_351FI).BeginInit();
            pnlAcciones_351FI.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal_351FI.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal_351FI.ColumnCount = 2;
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));
            tlpPrincipal_351FI.Controls.Add(crdSocio_351FI, 0, 0);
            tlpPrincipal_351FI.Controls.Add(crdEjemplares_351FI, 1, 0);
            tlpPrincipal_351FI.Controls.Add(crdDetalle_351FI, 0, 1);
            tlpPrincipal_351FI.Controls.Add(crdDonaciones_351FI, 1, 1);
            tlpPrincipal_351FI.Controls.Add(pnlAcciones_351FI, 0, 2);
            tlpPrincipal_351FI.Dock = DockStyle.Fill;
            tlpPrincipal_351FI.Name = "tlpPrincipal_351FI";
            tlpPrincipal_351FI.Padding = new Padding(12);
            tlpPrincipal_351FI.RowCount = 3;
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Percent, 55.0F));
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Percent, 45.0F));
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Absolute, 56.0F));
            tlpPrincipal_351FI.Size = new Size(1100, 640);
            tlpPrincipal_351FI.TabIndex = 0;
            tlpPrincipal_351FI.SetColumnSpan(pnlAcciones_351FI, 2);
            // 
            // crdSocio
            // 
            crdSocio_351FI.Controls.Add(lblSeccionSocio_351FI);
            crdSocio_351FI.Controls.Add(lblDni_351FI);
            crdSocio_351FI.Controls.Add(txtDni_351FI);
            crdSocio_351FI.Controls.Add(btnAgregarSocio_351FI);
            crdSocio_351FI.Controls.Add(dgvSocios_351FI);
            crdSocio_351FI.Controls.Add(lblDatosSocio_351FI);
            crdSocio_351FI.Dock = DockStyle.Fill;
            crdSocio_351FI.Margin = new Padding(8);
            crdSocio_351FI.Name = "crdSocio_351FI";
            crdSocio_351FI.Size = new Size(522, 292);
            crdSocio_351FI.TabIndex = 0;
            // 
            // lblSeccionSocio
            // 
            lblSeccionSocio_351FI.AutoSize = true;
            lblSeccionSocio_351FI.BackColor = Color.Transparent;
            lblSeccionSocio_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionSocio_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionSocio_351FI.Location = new Point(20, 16);
            lblSeccionSocio_351FI.Name = "lblSeccionSocio_351FI";
            lblSeccionSocio_351FI.Size = new Size(104, 20);
            lblSeccionSocio_351FI.TabIndex = 0;
            lblSeccionSocio_351FI.Text = "Socio donante";
            // 
            // lblDni
            // 
            lblDni_351FI.AutoSize = true;
            lblDni_351FI.BackColor = Color.Transparent;
            lblDni_351FI.Font = new Font("Segoe UI", 10F);
            lblDni_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblDni_351FI.Location = new Point(20, 52);
            lblDni_351FI.Name = "lblDni_351FI";
            lblDni_351FI.Size = new Size(288, 20);
            lblDni_351FI.TabIndex = 1;
            lblDni_351FI.Text = "DNI del socio (búsqueda incremental)";
            // 
            // txtDni
            // 
            txtDni_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtDni_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtDni_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDni_351FI.Location = new Point(20, 74);
            txtDni_351FI.Name = "txtDni_351FI";
            txtDni_351FI.Size = new Size(322, 27);
            txtDni_351FI.TabIndex = 2;
            txtDni_351FI.TextChanged += txtDni_351FI_TextChanged;
            // 
            // btnAgregarSocio
            // 
            btnAgregarSocio_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnAgregarSocio_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAgregarSocio_351FI.Icono_351FI = "\uE73E";
            btnAgregarSocio_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarSocio_351FI.Location = new Point(352, 71);
            btnAgregarSocio_351FI.Name = "btnAgregarSocio_351FI";
            btnAgregarSocio_351FI.Size = new Size(150, 32);
            btnAgregarSocio_351FI.TabIndex = 3;
            btnAgregarSocio_351FI.Text = "Seleccionar";
            btnAgregarSocio_351FI.Click += btnAgregarSocio_351FI_Click;
            // 
            // dgvSocios
            // 
            dgvSocios_351FI.Columns.AddRange(new DataGridViewColumn[] { colSocNumero_351FI, colSocApellido_351FI, colSocNombre_351FI, colSocDni_351FI });
            dgvSocios_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSocios_351FI.Location = new Point(20, 116);
            dgvSocios_351FI.Name = "dgvSocios_351FI";
            dgvSocios_351FI.Size = new Size(482, 128);
            dgvSocios_351FI.TabIndex = 4;
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
            dgvSocios_351FI.CellDoubleClick += dgvSocios_351FI_CellDoubleClick;
            // 
            // lblDatosSocio
            // 
            lblDatosSocio_351FI.AutoSize = true;
            lblDatosSocio_351FI.BackColor = Color.Transparent;
            lblDatosSocio_351FI.Font = new Font("Segoe UI", 11F);
            lblDatosSocio_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblDatosSocio_351FI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDatosSocio_351FI.Location = new Point(20, 256);
            lblDatosSocio_351FI.Name = "lblDatosSocio_351FI";
            lblDatosSocio_351FI.Size = new Size(64, 20);
            lblDatosSocio_351FI.TabIndex = 5;
            lblDatosSocio_351FI.Text = "Socio: —";
            // 
            // crdEjemplares
            // 
            crdEjemplares_351FI.Controls.Add(lblSeccionEjemplares_351FI);
            crdEjemplares_351FI.Controls.Add(lblBuscarLibro_351FI);
            crdEjemplares_351FI.Controls.Add(txtBuscarLibro_351FI);
            crdEjemplares_351FI.Controls.Add(btnAgregarEjemplar_351FI);
            crdEjemplares_351FI.Controls.Add(dgvLibros_351FI);
            crdEjemplares_351FI.Controls.Add(lblAyudaLibro_351FI);
            crdEjemplares_351FI.Dock = DockStyle.Fill;
            crdEjemplares_351FI.Margin = new Padding(8);
            crdEjemplares_351FI.Name = "crdEjemplares_351FI";
            crdEjemplares_351FI.Size = new Size(522, 292);
            crdEjemplares_351FI.TabIndex = 1;
            // 
            // lblSeccionEjemplares
            // 
            lblSeccionEjemplares_351FI.AutoSize = true;
            lblSeccionEjemplares_351FI.BackColor = Color.Transparent;
            lblSeccionEjemplares_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionEjemplares_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionEjemplares_351FI.Location = new Point(20, 16);
            lblSeccionEjemplares_351FI.Name = "lblSeccionEjemplares_351FI";
            lblSeccionEjemplares_351FI.Size = new Size(112, 20);
            lblSeccionEjemplares_351FI.TabIndex = 0;
            lblSeccionEjemplares_351FI.Text = "Libros donados";
            // 
            // lblBuscarLibro
            // 
            lblBuscarLibro_351FI.AutoSize = true;
            lblBuscarLibro_351FI.BackColor = Color.Transparent;
            lblBuscarLibro_351FI.Font = new Font("Segoe UI", 10F);
            lblBuscarLibro_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblBuscarLibro_351FI.Location = new Point(20, 52);
            lblBuscarLibro_351FI.Name = "lblBuscarLibro_351FI";
            lblBuscarLibro_351FI.Size = new Size(440, 20);
            lblBuscarLibro_351FI.TabIndex = 1;
            lblBuscarLibro_351FI.Text = "Código, título o autor del libro (búsqueda incremental)";
            // 
            // txtBuscarLibro
            // 
            txtBuscarLibro_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarLibro_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtBuscarLibro_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarLibro_351FI.Location = new Point(20, 74);
            txtBuscarLibro_351FI.Name = "txtBuscarLibro_351FI";
            txtBuscarLibro_351FI.Size = new Size(322, 27);
            txtBuscarLibro_351FI.TabIndex = 2;
            txtBuscarLibro_351FI.TextChanged += txtBuscarLibro_351FI_TextChanged;
            // 
            // btnAgregarEjemplar
            // 
            btnAgregarEjemplar_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnAgregarEjemplar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAgregarEjemplar_351FI.Icono_351FI = "\uE710";
            btnAgregarEjemplar_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarEjemplar_351FI.Location = new Point(352, 71);
            btnAgregarEjemplar_351FI.Name = "btnAgregarEjemplar_351FI";
            btnAgregarEjemplar_351FI.Size = new Size(150, 32);
            btnAgregarEjemplar_351FI.TabIndex = 3;
            btnAgregarEjemplar_351FI.Text = "Agregar";
            btnAgregarEjemplar_351FI.Click += btnAgregarEjemplar_351FI_Click;
            // 
            // dgvLibros
            // 
            dgvLibros_351FI.Columns.AddRange(new DataGridViewColumn[] { colLibCodigo_351FI, colLibTitulo_351FI, colLibAutores_351FI });
            dgvLibros_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLibros_351FI.Location = new Point(20, 116);
            dgvLibros_351FI.Name = "dgvLibros_351FI";
            dgvLibros_351FI.Size = new Size(482, 128);
            dgvLibros_351FI.TabIndex = 4;
            // 
            // colLibCodigo
            // 
            colLibCodigo_351FI.FillWeight = 18F;
            colLibCodigo_351FI.HeaderText = "Código";
            colLibCodigo_351FI.Name = "colLibCodigo_351FI";
            colLibCodigo_351FI.ReadOnly = true;
            // 
            // colLibTitulo
            // 
            colLibTitulo_351FI.FillWeight = 47F;
            colLibTitulo_351FI.HeaderText = "Título";
            colLibTitulo_351FI.Name = "colLibTitulo_351FI";
            colLibTitulo_351FI.ReadOnly = true;
            // 
            // colLibAutores
            // 
            colLibAutores_351FI.FillWeight = 35F;
            colLibAutores_351FI.HeaderText = "Autores";
            colLibAutores_351FI.Name = "colLibAutores_351FI";
            colLibAutores_351FI.ReadOnly = true;
            dgvLibros_351FI.CellDoubleClick += dgvLibros_351FI_CellDoubleClick;
            // 
            // lblAyudaLibro
            // 
            lblAyudaLibro_351FI.AutoSize = true;
            lblAyudaLibro_351FI.BackColor = Color.Transparent;
            lblAyudaLibro_351FI.Font = new Font("Segoe UI", 9.5F);
            lblAyudaLibro_351FI.ForeColor = Color.FromArgb(107, 114, 128);
            lblAyudaLibro_351FI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAyudaLibro_351FI.Location = new Point(20, 256);
            lblAyudaLibro_351FI.Name = "lblAyudaLibro_351FI";
            lblAyudaLibro_351FI.Size = new Size(608, 20);
            lblAyudaLibro_351FI.TabIndex = 5;
            lblAyudaLibro_351FI.Text = "Si el libro no está en el catálogo, regístrelo primero en Gestión de libros.";
            // 
            // crdDetalle
            // 
            crdDetalle_351FI.Controls.Add(lblSeccionDetalle_351FI);
            crdDetalle_351FI.Controls.Add(lblDetalleCantidad_351FI);
            crdDetalle_351FI.Controls.Add(dgvDetalle_351FI);
            crdDetalle_351FI.Controls.Add(btnQuitarEjemplar_351FI);
            crdDetalle_351FI.Controls.Add(lblAyudaDetalle_351FI);
            crdDetalle_351FI.Dock = DockStyle.Fill;
            crdDetalle_351FI.Margin = new Padding(8);
            crdDetalle_351FI.Name = "crdDetalle_351FI";
            crdDetalle_351FI.Size = new Size(522, 236);
            crdDetalle_351FI.TabIndex = 2;
            // 
            // lblSeccionDetalle
            // 
            lblSeccionDetalle_351FI.AutoSize = true;
            lblSeccionDetalle_351FI.BackColor = Color.Transparent;
            lblSeccionDetalle_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionDetalle_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionDetalle_351FI.Location = new Point(20, 16);
            lblSeccionDetalle_351FI.Name = "lblSeccionDetalle_351FI";
            lblSeccionDetalle_351FI.Size = new Size(176, 20);
            lblSeccionDetalle_351FI.TabIndex = 0;
            lblSeccionDetalle_351FI.Text = "Detalle de la donación";
            // 
            // lblDetalleCantidad
            // 
            lblDetalleCantidad_351FI.AutoSize = true;
            lblDetalleCantidad_351FI.BackColor = Color.Transparent;
            lblDetalleCantidad_351FI.Font = new Font("Segoe UI", 11F);
            lblDetalleCantidad_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblDetalleCantidad_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDetalleCantidad_351FI.Location = new Point(372, 20);
            lblDetalleCantidad_351FI.Name = "lblDetalleCantidad_351FI";
            lblDetalleCantidad_351FI.Size = new Size(104, 20);
            lblDetalleCantidad_351FI.TabIndex = 1;
            lblDetalleCantidad_351FI.Text = "Ejemplares: 0";
            // 
            // dgvDetalle
            // 
            dgvDetalle_351FI.Columns.AddRange(new DataGridViewColumn[] { colDetLibro_351FI, colDetTitulo_351FI, colDetAutor_351FI });
            dgvDetalle_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalle_351FI.Location = new Point(20, 52);
            dgvDetalle_351FI.Name = "dgvDetalle_351FI";
            dgvDetalle_351FI.Size = new Size(482, 120);
            dgvDetalle_351FI.TabIndex = 2;
            // 
            // colDetLibro
            // 
            colDetLibro_351FI.FillWeight = 20F;
            colDetLibro_351FI.HeaderText = "Libro";
            colDetLibro_351FI.Name = "colDetLibro_351FI";
            colDetLibro_351FI.ReadOnly = true;
            // 
            // colDetTitulo
            // 
            colDetTitulo_351FI.FillWeight = 48F;
            colDetTitulo_351FI.HeaderText = "Título";
            colDetTitulo_351FI.Name = "colDetTitulo_351FI";
            colDetTitulo_351FI.ReadOnly = true;
            // 
            // colDetAutor
            // 
            colDetAutor_351FI.FillWeight = 32F;
            colDetAutor_351FI.HeaderText = "Autor";
            colDetAutor_351FI.Name = "colDetAutor_351FI";
            colDetAutor_351FI.ReadOnly = true;
            // 
            // btnQuitarEjemplar
            // 
            btnQuitarEjemplar_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnQuitarEjemplar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnQuitarEjemplar_351FI.Icono_351FI = "\uE74D";
            btnQuitarEjemplar_351FI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnQuitarEjemplar_351FI.Location = new Point(20, 182);
            btnQuitarEjemplar_351FI.Name = "btnQuitarEjemplar_351FI";
            btnQuitarEjemplar_351FI.Size = new Size(120, 36);
            btnQuitarEjemplar_351FI.TabIndex = 3;
            btnQuitarEjemplar_351FI.Text = "Quitar";
            btnQuitarEjemplar_351FI.Click += btnQuitarEjemplar_351FI_Click;
            // 
            // lblAyudaDetalle
            // 
            lblAyudaDetalle_351FI.AutoSize = true;
            lblAyudaDetalle_351FI.BackColor = Color.Transparent;
            lblAyudaDetalle_351FI.Font = new Font("Segoe UI", 9.5F);
            lblAyudaDetalle_351FI.ForeColor = Color.FromArgb(107, 114, 128);
            lblAyudaDetalle_351FI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAyudaDetalle_351FI.Location = new Point(152, 192);
            lblAyudaDetalle_351FI.Name = "lblAyudaDetalle_351FI";
            lblAyudaDetalle_351FI.Size = new Size(288, 20);
            lblAyudaDetalle_351FI.TabIndex = 4;
            lblAyudaDetalle_351FI.Text = "Los códigos se asignan al confirmar.";
            // 
            // crdDonaciones
            // 
            crdDonaciones_351FI.Controls.Add(lblSeccionDonaciones_351FI);
            crdDonaciones_351FI.Controls.Add(dgvDonaciones_351FI);
            crdDonaciones_351FI.Dock = DockStyle.Fill;
            crdDonaciones_351FI.Margin = new Padding(8);
            crdDonaciones_351FI.Name = "crdDonaciones_351FI";
            crdDonaciones_351FI.Size = new Size(522, 236);
            crdDonaciones_351FI.TabIndex = 3;
            // 
            // lblSeccionDonaciones
            // 
            lblSeccionDonaciones_351FI.AutoSize = true;
            lblSeccionDonaciones_351FI.BackColor = Color.Transparent;
            lblSeccionDonaciones_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionDonaciones_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionDonaciones_351FI.Location = new Point(20, 16);
            lblSeccionDonaciones_351FI.Name = "lblSeccionDonaciones_351FI";
            lblSeccionDonaciones_351FI.Size = new Size(176, 20);
            lblSeccionDonaciones_351FI.TabIndex = 0;
            lblSeccionDonaciones_351FI.Text = "Donaciones registradas";
            // 
            // dgvDonaciones
            // 
            dgvDonaciones_351FI.Columns.AddRange(new DataGridViewColumn[] { colDonNumero_351FI, colDonFecha_351FI, colDonSocio_351FI, colDonCantidad_351FI, colDonLibros_351FI });
            dgvDonaciones_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDonaciones_351FI.Location = new Point(20, 52);
            dgvDonaciones_351FI.Name = "dgvDonaciones_351FI";
            dgvDonaciones_351FI.Size = new Size(482, 164);
            dgvDonaciones_351FI.TabIndex = 1;
            // 
            // colDonNumero
            // 
            colDonNumero_351FI.FillWeight = 10F;
            colDonNumero_351FI.HeaderText = "N°";
            colDonNumero_351FI.Name = "colDonNumero_351FI";
            colDonNumero_351FI.ReadOnly = true;
            // 
            // colDonFecha
            // 
            colDonFecha_351FI.FillWeight = 18F;
            colDonFecha_351FI.HeaderText = "Fecha";
            colDonFecha_351FI.Name = "colDonFecha_351FI";
            colDonFecha_351FI.ReadOnly = true;
            // 
            // colDonSocio
            // 
            colDonSocio_351FI.FillWeight = 30F;
            colDonSocio_351FI.HeaderText = "Socio";
            colDonSocio_351FI.Name = "colDonSocio_351FI";
            colDonSocio_351FI.ReadOnly = true;
            // 
            // colDonCantidad
            // 
            colDonCantidad_351FI.FillWeight = 14F;
            colDonCantidad_351FI.HeaderText = "Ejemplares";
            colDonCantidad_351FI.Name = "colDonCantidad_351FI";
            colDonCantidad_351FI.ReadOnly = true;
            // 
            // colDonLibros
            // 
            colDonLibros_351FI.FillWeight = 28F;
            colDonLibros_351FI.HeaderText = "Libros";
            colDonLibros_351FI.Name = "colDonLibros_351FI";
            colDonLibros_351FI.ReadOnly = true;
            // 
            // pnlAcciones
            // 
            pnlAcciones_351FI.BackColor = Color.Transparent;
            pnlAcciones_351FI.Controls.Add(btnConfirmar_351FI);
            pnlAcciones_351FI.Controls.Add(btnCancelar_351FI);
            pnlAcciones_351FI.FlowDirection = FlowDirection.RightToLeft;
            pnlAcciones_351FI.WrapContents = false;
            pnlAcciones_351FI.Dock = DockStyle.Fill;
            pnlAcciones_351FI.Margin = new Padding(8);
            pnlAcciones_351FI.Name = "pnlAcciones_351FI";
            pnlAcciones_351FI.Size = new Size(400, 40);
            pnlAcciones_351FI.TabIndex = 4;
            // 
            // btnConfirmar
            // 
            btnConfirmar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnConfirmar_351FI.Icono_351FI = "\uE73E";
            btnConfirmar_351FI.Margin = new Padding(12, 0, 0, 0);
            btnConfirmar_351FI.Name = "btnConfirmar_351FI";
            btnConfirmar_351FI.Size = new Size(220, 40);
            btnConfirmar_351FI.TabIndex = 0;
            btnConfirmar_351FI.Text = "Confirmar donación";
            btnConfirmar_351FI.Click += btnConfirmar_351FI_Click;
            // 
            // btnCancelar
            // 
            btnCancelar_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnCancelar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnCancelar_351FI.Icono_351FI = "\uE711";
            btnCancelar_351FI.Margin = new Padding(12, 0, 0, 0);
            btnCancelar_351FI.Name = "btnCancelar_351FI";
            btnCancelar_351FI.Size = new Size(140, 40);
            btnCancelar_351FI.TabIndex = 1;
            btnCancelar_351FI.Text = "Cancelar";
            btnCancelar_351FI.Click += btnCancelar_351FI_Click;
            // 
            // FormDonacion
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal_351FI);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDonacion_351FI";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar donación";
            Load += FormDonacion_351FI_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios_351FI).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros_351FI).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle_351FI).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDonaciones_351FI).EndInit();
            pnlAcciones_351FI.ResumeLayout(false);
            pnlAcciones_351FI.PerformLayout();
            crdDonaciones_351FI.ResumeLayout(false);
            crdDonaciones_351FI.PerformLayout();
            crdDetalle_351FI.ResumeLayout(false);
            crdDetalle_351FI.PerformLayout();
            crdEjemplares_351FI.ResumeLayout(false);
            crdEjemplares_351FI.PerformLayout();
            crdSocio_351FI.ResumeLayout(false);
            crdSocio_351FI.PerformLayout();
            tlpPrincipal_351FI.ResumeLayout(false);
            tlpPrincipal_351FI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal_351FI;
        private TarjetaSGB_351FI crdSocio_351FI;
        private Label lblSeccionSocio_351FI;
        private Label lblDni_351FI;
        private TextBox txtDni_351FI;
        private BotonSGB_351FI btnAgregarSocio_351FI;
        private GrillaSGB_351FI dgvSocios_351FI;
        private DataGridViewTextBoxColumn colSocNumero_351FI;
        private DataGridViewTextBoxColumn colSocApellido_351FI;
        private DataGridViewTextBoxColumn colSocNombre_351FI;
        private DataGridViewTextBoxColumn colSocDni_351FI;
        private Label lblDatosSocio_351FI;
        private TarjetaSGB_351FI crdEjemplares_351FI;
        private Label lblSeccionEjemplares_351FI;
        private Label lblBuscarLibro_351FI;
        private TextBox txtBuscarLibro_351FI;
        private BotonSGB_351FI btnAgregarEjemplar_351FI;
        private GrillaSGB_351FI dgvLibros_351FI;
        private DataGridViewTextBoxColumn colLibCodigo_351FI;
        private DataGridViewTextBoxColumn colLibTitulo_351FI;
        private DataGridViewTextBoxColumn colLibAutores_351FI;
        private Label lblAyudaLibro_351FI;
        private TarjetaSGB_351FI crdDetalle_351FI;
        private Label lblSeccionDetalle_351FI;
        private Label lblDetalleCantidad_351FI;
        private GrillaSGB_351FI dgvDetalle_351FI;
        private DataGridViewTextBoxColumn colDetLibro_351FI;
        private DataGridViewTextBoxColumn colDetTitulo_351FI;
        private DataGridViewTextBoxColumn colDetAutor_351FI;
        private BotonSGB_351FI btnQuitarEjemplar_351FI;
        private Label lblAyudaDetalle_351FI;
        private TarjetaSGB_351FI crdDonaciones_351FI;
        private Label lblSeccionDonaciones_351FI;
        private GrillaSGB_351FI dgvDonaciones_351FI;
        private DataGridViewTextBoxColumn colDonNumero_351FI;
        private DataGridViewTextBoxColumn colDonFecha_351FI;
        private DataGridViewTextBoxColumn colDonSocio_351FI;
        private DataGridViewTextBoxColumn colDonCantidad_351FI;
        private DataGridViewTextBoxColumn colDonLibros_351FI;
        private FlowLayoutPanel pnlAcciones_351FI;
        private BotonSGB_351FI btnConfirmar_351FI;
        private BotonSGB_351FI btnCancelar_351FI;
    }
}
