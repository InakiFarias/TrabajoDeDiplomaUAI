using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormPrestamo_351FI
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
            colSocEstado_351FI = new DataGridViewTextBoxColumn();
            lblDatosSocio_351FI = new Label();
            lblEstadoSocio_351FI = new Label();
            crdEjemplares_351FI = new TarjetaSGB_351FI();
            lblSeccionEjemplares_351FI = new Label();
            lblBuscarEjemplar_351FI = new Label();
            txtBuscarEjemplar_351FI = new TextBox();
            btnAgregarEjemplar_351FI = new BotonSGB_351FI();
            dgvResultados_351FI = new GrillaSGB_351FI();
            colResCodigo_351FI = new DataGridViewTextBoxColumn();
            colResTitulo_351FI = new DataGridViewTextBoxColumn();
            colResAutor_351FI = new DataGridViewTextBoxColumn();
            crdDetalle_351FI = new TarjetaSGB_351FI();
            lblSeccionDetalle_351FI = new Label();
            lblDetalleSocio_351FI = new Label();
            dgvDetalle_351FI = new GrillaSGB_351FI();
            colDetCodigo_351FI = new DataGridViewTextBoxColumn();
            colDetTitulo_351FI = new DataGridViewTextBoxColumn();
            colDetAutor_351FI = new DataGridViewTextBoxColumn();
            btnQuitarEjemplar_351FI = new BotonSGB_351FI();
            lblFechaPrestamo_351FI = new Label();
            lblFechaDevolucion_351FI = new Label();
            lblDetalleCantidad_351FI = new Label();
            pnlAcciones_351FI = new FlowLayoutPanel();
            btnConfirmar_351FI = new BotonSGB_351FI();
            btnCancelar_351FI = new BotonSGB_351FI();
            tlpPrincipal_351FI.SuspendLayout();
            crdSocio_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios_351FI).BeginInit();
            crdEjemplares_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados_351FI).BeginInit();
            crdDetalle_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle_351FI).BeginInit();
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
            tlpPrincipal_351FI.SetColumnSpan(crdDetalle_351FI, 2);
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
            crdSocio_351FI.Controls.Add(lblEstadoSocio_351FI);
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
            lblSeccionSocio_351FI.Size = new Size(40, 20);
            lblSeccionSocio_351FI.TabIndex = 0;
            lblSeccionSocio_351FI.Text = "Socio";
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
            txtDni_351FI.PlaceholderText = "Ej.: 28456123";
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
            dgvSocios_351FI.Columns.AddRange(new DataGridViewColumn[] { colSocNumero_351FI, colSocApellido_351FI, colSocNombre_351FI, colSocDni_351FI, colSocEstado_351FI });
            dgvSocios_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSocios_351FI.Location = new Point(20, 116);
            dgvSocios_351FI.Name = "dgvSocios_351FI";
            dgvSocios_351FI.Size = new Size(482, 106);
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
            // 
            // colSocEstado
            // 
            colSocEstado_351FI.FillWeight = 15F;
            colSocEstado_351FI.HeaderText = "Estado";
            colSocEstado_351FI.Name = "colSocEstado_351FI";
            colSocEstado_351FI.ReadOnly = true;
            // 
            // lblDatosSocio
            // 
            lblDatosSocio_351FI.AutoSize = true;
            lblDatosSocio_351FI.BackColor = Color.Transparent;
            lblDatosSocio_351FI.Font = new Font("Segoe UI", 11F);
            lblDatosSocio_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblDatosSocio_351FI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDatosSocio_351FI.Location = new Point(20, 232);
            lblDatosSocio_351FI.Name = "lblDatosSocio_351FI";
            lblDatosSocio_351FI.Size = new Size(64, 20);
            lblDatosSocio_351FI.TabIndex = 5;
            lblDatosSocio_351FI.Text = "Socio: —";
            // 
            // lblEstadoSocio
            // 
            lblEstadoSocio_351FI.AutoSize = true;
            lblEstadoSocio_351FI.BackColor = Color.Transparent;
            lblEstadoSocio_351FI.Font = new Font("Segoe UI", 10F);
            lblEstadoSocio_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblEstadoSocio_351FI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblEstadoSocio_351FI.Location = new Point(20, 258);
            lblEstadoSocio_351FI.Name = "lblEstadoSocio_351FI";
            lblEstadoSocio_351FI.Size = new Size(72, 20);
            lblEstadoSocio_351FI.TabIndex = 6;
            lblEstadoSocio_351FI.Text = "Estado: —";
            // 
            // crdEjemplares
            // 
            crdEjemplares_351FI.Controls.Add(lblSeccionEjemplares_351FI);
            crdEjemplares_351FI.Controls.Add(lblBuscarEjemplar_351FI);
            crdEjemplares_351FI.Controls.Add(txtBuscarEjemplar_351FI);
            crdEjemplares_351FI.Controls.Add(btnAgregarEjemplar_351FI);
            crdEjemplares_351FI.Controls.Add(dgvResultados_351FI);
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
            lblSeccionEjemplares_351FI.Size = new Size(80, 20);
            lblSeccionEjemplares_351FI.TabIndex = 0;
            lblSeccionEjemplares_351FI.Text = "Ejemplares";
            // 
            // lblBuscarEjemplar
            // 
            lblBuscarEjemplar_351FI.AutoSize = true;
            lblBuscarEjemplar_351FI.BackColor = Color.Transparent;
            lblBuscarEjemplar_351FI.Font = new Font("Segoe UI", 10F);
            lblBuscarEjemplar_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblBuscarEjemplar_351FI.Location = new Point(20, 52);
            lblBuscarEjemplar_351FI.Name = "lblBuscarEjemplar_351FI";
            lblBuscarEjemplar_351FI.Size = new Size(368, 20);
            lblBuscarEjemplar_351FI.TabIndex = 1;
            lblBuscarEjemplar_351FI.Text = "Ejemplares disponibles: código, título o autor";
            // 
            // txtBuscarEjemplar
            // 
            txtBuscarEjemplar_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarEjemplar_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtBuscarEjemplar_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarEjemplar_351FI.Location = new Point(20, 74);
            txtBuscarEjemplar_351FI.Name = "txtBuscarEjemplar_351FI";
            txtBuscarEjemplar_351FI.Size = new Size(322, 27);
            txtBuscarEjemplar_351FI.TabIndex = 2;
            txtBuscarEjemplar_351FI.TextChanged += txtBuscarEjemplar_351FI_TextChanged;
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
            // dgvResultados
            // 
            dgvResultados_351FI.Columns.AddRange(new DataGridViewColumn[] { colResCodigo_351FI, colResTitulo_351FI, colResAutor_351FI });
            dgvResultados_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResultados_351FI.Location = new Point(20, 116);
            dgvResultados_351FI.Name = "dgvResultados_351FI";
            dgvResultados_351FI.Size = new Size(482, 156);
            dgvResultados_351FI.TabIndex = 4;
            // 
            // colResCodigo
            // 
            colResCodigo_351FI.FillWeight = 20F;
            colResCodigo_351FI.HeaderText = "Código";
            colResCodigo_351FI.Name = "colResCodigo_351FI";
            colResCodigo_351FI.ReadOnly = true;
            // 
            // colResTitulo
            // 
            colResTitulo_351FI.FillWeight = 48F;
            colResTitulo_351FI.HeaderText = "Título";
            colResTitulo_351FI.Name = "colResTitulo_351FI";
            colResTitulo_351FI.ReadOnly = true;
            // 
            // colResAutor
            // 
            colResAutor_351FI.FillWeight = 32F;
            colResAutor_351FI.HeaderText = "Autor";
            colResAutor_351FI.Name = "colResAutor_351FI";
            colResAutor_351FI.ReadOnly = true;
            dgvResultados_351FI.CellDoubleClick += dgvResultados_351FI_CellDoubleClick;
            // 
            // crdDetalle
            // 
            crdDetalle_351FI.Controls.Add(lblSeccionDetalle_351FI);
            crdDetalle_351FI.Controls.Add(lblDetalleSocio_351FI);
            crdDetalle_351FI.Controls.Add(dgvDetalle_351FI);
            crdDetalle_351FI.Controls.Add(btnQuitarEjemplar_351FI);
            crdDetalle_351FI.Controls.Add(lblFechaPrestamo_351FI);
            crdDetalle_351FI.Controls.Add(lblFechaDevolucion_351FI);
            crdDetalle_351FI.Controls.Add(lblDetalleCantidad_351FI);
            crdDetalle_351FI.Dock = DockStyle.Fill;
            crdDetalle_351FI.Margin = new Padding(8);
            crdDetalle_351FI.Name = "crdDetalle_351FI";
            crdDetalle_351FI.Size = new Size(1060, 236);
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
            lblSeccionDetalle_351FI.Size = new Size(160, 20);
            lblSeccionDetalle_351FI.TabIndex = 0;
            lblSeccionDetalle_351FI.Text = "Detalle del préstamo";
            // 
            // lblDetalleSocio
            // 
            lblDetalleSocio_351FI.AutoSize = true;
            lblDetalleSocio_351FI.BackColor = Color.Transparent;
            lblDetalleSocio_351FI.Font = new Font("Segoe UI", 11F);
            lblDetalleSocio_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblDetalleSocio_351FI.Location = new Point(260, 20);
            lblDetalleSocio_351FI.Name = "lblDetalleSocio_351FI";
            lblDetalleSocio_351FI.Size = new Size(64, 20);
            lblDetalleSocio_351FI.TabIndex = 1;
            lblDetalleSocio_351FI.Text = "Socio: —";
            // 
            // dgvDetalle
            // 
            dgvDetalle_351FI.Columns.AddRange(new DataGridViewColumn[] { colDetCodigo_351FI, colDetTitulo_351FI, colDetAutor_351FI });
            dgvDetalle_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalle_351FI.Location = new Point(20, 52);
            dgvDetalle_351FI.Name = "dgvDetalle_351FI";
            dgvDetalle_351FI.Size = new Size(1020, 120);
            dgvDetalle_351FI.TabIndex = 2;
            // 
            // colDetCodigo
            // 
            colDetCodigo_351FI.FillWeight = 20F;
            colDetCodigo_351FI.HeaderText = "Código";
            colDetCodigo_351FI.Name = "colDetCodigo_351FI";
            colDetCodigo_351FI.ReadOnly = true;
            // 
            // colDetTitulo
            // 
            colDetTitulo_351FI.FillWeight = 50F;
            colDetTitulo_351FI.HeaderText = "Título";
            colDetTitulo_351FI.Name = "colDetTitulo_351FI";
            colDetTitulo_351FI.ReadOnly = true;
            // 
            // colDetAutor
            // 
            colDetAutor_351FI.FillWeight = 30F;
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
            // lblFechaPrestamo
            // 
            lblFechaPrestamo_351FI.AutoSize = true;
            lblFechaPrestamo_351FI.BackColor = Color.Transparent;
            lblFechaPrestamo_351FI.Font = new Font("Segoe UI", 11F);
            lblFechaPrestamo_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblFechaPrestamo_351FI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFechaPrestamo_351FI.Location = new Point(170, 190);
            lblFechaPrestamo_351FI.Name = "lblFechaPrestamo_351FI";
            lblFechaPrestamo_351FI.Size = new Size(168, 20);
            lblFechaPrestamo_351FI.TabIndex = 4;
            lblFechaPrestamo_351FI.Text = "Fecha del préstamo: —";
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion_351FI.AutoSize = true;
            lblFechaDevolucion_351FI.BackColor = Color.Transparent;
            lblFechaDevolucion_351FI.Font = new Font("Segoe UI Semibold", 11F);
            lblFechaDevolucion_351FI.ForeColor = Color.FromArgb(123, 30, 46);
            lblFechaDevolucion_351FI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFechaDevolucion_351FI.Location = new Point(440, 190);
            lblFechaDevolucion_351FI.Name = "lblFechaDevolucion_351FI";
            lblFechaDevolucion_351FI.Size = new Size(248, 20);
            lblFechaDevolucion_351FI.TabIndex = 5;
            lblFechaDevolucion_351FI.Text = "Fecha de devolución prevista: —";
            // 
            // lblDetalleCantidad
            // 
            lblDetalleCantidad_351FI.AutoSize = true;
            lblDetalleCantidad_351FI.BackColor = Color.Transparent;
            lblDetalleCantidad_351FI.Font = new Font("Segoe UI", 11F);
            lblDetalleCantidad_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblDetalleCantidad_351FI.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDetalleCantidad_351FI.Location = new Point(890, 190);
            lblDetalleCantidad_351FI.Name = "lblDetalleCantidad_351FI";
            lblDetalleCantidad_351FI.Size = new Size(136, 20);
            lblDetalleCantidad_351FI.TabIndex = 6;
            lblDetalleCantidad_351FI.Text = "Ejemplares: 0 / 5";
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
            pnlAcciones_351FI.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            btnConfirmar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnConfirmar_351FI.Icono_351FI = "\uE73E";
            btnConfirmar_351FI.Margin = new Padding(12, 0, 0, 0);
            btnConfirmar_351FI.Name = "btnConfirmar_351FI";
            btnConfirmar_351FI.Size = new Size(220, 40);
            btnConfirmar_351FI.TabIndex = 0;
            btnConfirmar_351FI.Text = "Confirmar préstamo";
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
            // FormPrestamo
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal_351FI);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrestamo_351FI";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar préstamo";
            Load += FormPrestamo_351FI_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios_351FI).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultados_351FI).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle_351FI).EndInit();
            pnlAcciones_351FI.ResumeLayout(false);
            pnlAcciones_351FI.PerformLayout();
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
        private DataGridViewTextBoxColumn colSocEstado_351FI;
        private Label lblDatosSocio_351FI;
        private Label lblEstadoSocio_351FI;
        private TarjetaSGB_351FI crdEjemplares_351FI;
        private Label lblSeccionEjemplares_351FI;
        private Label lblBuscarEjemplar_351FI;
        private TextBox txtBuscarEjemplar_351FI;
        private BotonSGB_351FI btnAgregarEjemplar_351FI;
        private GrillaSGB_351FI dgvResultados_351FI;
        private DataGridViewTextBoxColumn colResCodigo_351FI;
        private DataGridViewTextBoxColumn colResTitulo_351FI;
        private DataGridViewTextBoxColumn colResAutor_351FI;
        private TarjetaSGB_351FI crdDetalle_351FI;
        private Label lblSeccionDetalle_351FI;
        private Label lblDetalleSocio_351FI;
        private GrillaSGB_351FI dgvDetalle_351FI;
        private DataGridViewTextBoxColumn colDetCodigo_351FI;
        private DataGridViewTextBoxColumn colDetTitulo_351FI;
        private DataGridViewTextBoxColumn colDetAutor_351FI;
        private BotonSGB_351FI btnQuitarEjemplar_351FI;
        private Label lblFechaPrestamo_351FI;
        private Label lblFechaDevolucion_351FI;
        private Label lblDetalleCantidad_351FI;
        private FlowLayoutPanel pnlAcciones_351FI;
        private BotonSGB_351FI btnConfirmar_351FI;
        private BotonSGB_351FI btnCancelar_351FI;
    }
}
