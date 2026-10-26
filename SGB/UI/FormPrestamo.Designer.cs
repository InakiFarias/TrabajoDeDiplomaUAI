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
            colSocEstado = new DataGridViewTextBoxColumn();
            lblDatosSocio = new Label();
            lblEstadoSocio = new Label();
            crdEjemplares = new TarjetaSGB();
            lblSeccionEjemplares = new Label();
            lblBuscarEjemplar = new Label();
            txtBuscarEjemplar = new TextBox();
            btnAgregarEjemplar = new BotonSGB();
            dgvResultados = new GrillaSGB();
            colResCodigo = new DataGridViewTextBoxColumn();
            colResTitulo = new DataGridViewTextBoxColumn();
            colResAutor = new DataGridViewTextBoxColumn();
            colResEstado = new DataGridViewTextBoxColumn();
            crdDetalle = new TarjetaSGB();
            lblSeccionDetalle = new Label();
            lblDetalleSocio = new Label();
            dgvDetalle = new GrillaSGB();
            colDetCodigo = new DataGridViewTextBoxColumn();
            colDetTitulo = new DataGridViewTextBoxColumn();
            colDetAutor = new DataGridViewTextBoxColumn();
            btnQuitarEjemplar = new BotonSGB();
            lblFechaPrestamo = new Label();
            lblFechaDevolucion = new Label();
            lblDetalleCantidad = new Label();
            pnlAcciones = new FlowLayoutPanel();
            btnConfirmar = new BotonSGB();
            btnCancelar = new BotonSGB();
            tlpPrincipal.SuspendLayout();
            crdSocio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            crdEjemplares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            crdDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
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
            tlpPrincipal.SetColumnSpan(crdDetalle, 2);
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
            crdSocio.Controls.Add(lblEstadoSocio);
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
            lblSeccionSocio.Size = new Size(40, 20);
            lblSeccionSocio.TabIndex = 0;
            lblSeccionSocio.Text = "Socio";
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
            txtDni.PlaceholderText = "Ej.: 28456123";
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
            dgvSocios.Columns.AddRange(new DataGridViewColumn[] { colSocNumero, colSocApellido, colSocNombre, colSocDni, colSocEstado });
            dgvSocios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSocios.Location = new Point(20, 116);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.Size = new Size(482, 106);
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
            lblDatosSocio.BackColor = Color.Transparent;
            lblDatosSocio.Font = new Font("Segoe UI", 11F);
            lblDatosSocio.ForeColor = Color.FromArgb(31, 41, 55);
            lblDatosSocio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDatosSocio.Location = new Point(20, 232);
            lblDatosSocio.Name = "lblDatosSocio";
            lblDatosSocio.Size = new Size(64, 20);
            lblDatosSocio.TabIndex = 5;
            lblDatosSocio.Text = "Socio: —";
            // 
            // lblEstadoSocio
            // 
            lblEstadoSocio.AutoSize = true;
            lblEstadoSocio.BackColor = Color.Transparent;
            lblEstadoSocio.Font = new Font("Segoe UI", 10F);
            lblEstadoSocio.ForeColor = Color.FromArgb(75, 85, 99);
            lblEstadoSocio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblEstadoSocio.Location = new Point(20, 258);
            lblEstadoSocio.Name = "lblEstadoSocio";
            lblEstadoSocio.Size = new Size(72, 20);
            lblEstadoSocio.TabIndex = 6;
            lblEstadoSocio.Text = "Estado: —";
            // 
            // crdEjemplares
            // 
            crdEjemplares.Controls.Add(lblSeccionEjemplares);
            crdEjemplares.Controls.Add(lblBuscarEjemplar);
            crdEjemplares.Controls.Add(txtBuscarEjemplar);
            crdEjemplares.Controls.Add(btnAgregarEjemplar);
            crdEjemplares.Controls.Add(dgvResultados);
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
            lblSeccionEjemplares.Size = new Size(80, 20);
            lblSeccionEjemplares.TabIndex = 0;
            lblSeccionEjemplares.Text = "Ejemplares";
            // 
            // lblBuscarEjemplar
            // 
            lblBuscarEjemplar.AutoSize = true;
            lblBuscarEjemplar.BackColor = Color.Transparent;
            lblBuscarEjemplar.Font = new Font("Segoe UI", 10F);
            lblBuscarEjemplar.ForeColor = Color.FromArgb(75, 85, 99);
            lblBuscarEjemplar.Location = new Point(20, 52);
            lblBuscarEjemplar.Name = "lblBuscarEjemplar";
            lblBuscarEjemplar.Size = new Size(272, 20);
            lblBuscarEjemplar.TabIndex = 1;
            lblBuscarEjemplar.Text = "Código de ejemplar, título o autor";
            // 
            // txtBuscarEjemplar
            // 
            txtBuscarEjemplar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarEjemplar.ForeColor = Color.FromArgb(31, 41, 55);
            txtBuscarEjemplar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarEjemplar.Location = new Point(20, 74);
            txtBuscarEjemplar.Name = "txtBuscarEjemplar";
            txtBuscarEjemplar.Size = new Size(322, 27);
            txtBuscarEjemplar.TabIndex = 2;
            txtBuscarEjemplar.TextChanged += txtBuscarEjemplar_TextChanged;
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
            // dgvResultados
            // 
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { colResCodigo, colResTitulo, colResAutor, colResEstado });
            dgvResultados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResultados.Location = new Point(20, 116);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(482, 156);
            dgvResultados.TabIndex = 4;
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
            dgvResultados.CellDoubleClick += dgvResultados_CellDoubleClick;
            // 
            // crdDetalle
            // 
            crdDetalle.Controls.Add(lblSeccionDetalle);
            crdDetalle.Controls.Add(lblDetalleSocio);
            crdDetalle.Controls.Add(dgvDetalle);
            crdDetalle.Controls.Add(btnQuitarEjemplar);
            crdDetalle.Controls.Add(lblFechaPrestamo);
            crdDetalle.Controls.Add(lblFechaDevolucion);
            crdDetalle.Controls.Add(lblDetalleCantidad);
            crdDetalle.Dock = DockStyle.Fill;
            crdDetalle.Margin = new Padding(8);
            crdDetalle.Name = "crdDetalle";
            crdDetalle.Size = new Size(1060, 236);
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
            lblSeccionDetalle.Size = new Size(160, 20);
            lblSeccionDetalle.TabIndex = 0;
            lblSeccionDetalle.Text = "Detalle del préstamo";
            // 
            // lblDetalleSocio
            // 
            lblDetalleSocio.AutoSize = true;
            lblDetalleSocio.BackColor = Color.Transparent;
            lblDetalleSocio.Font = new Font("Segoe UI", 11F);
            lblDetalleSocio.ForeColor = Color.FromArgb(31, 41, 55);
            lblDetalleSocio.Location = new Point(260, 20);
            lblDetalleSocio.Name = "lblDetalleSocio";
            lblDetalleSocio.Size = new Size(64, 20);
            lblDetalleSocio.TabIndex = 1;
            lblDetalleSocio.Text = "Socio: —";
            // 
            // dgvDetalle
            // 
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { colDetCodigo, colDetTitulo, colDetAutor });
            dgvDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalle.Location = new Point(20, 52);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.Size = new Size(1020, 120);
            dgvDetalle.TabIndex = 2;
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
            // lblFechaPrestamo
            // 
            lblFechaPrestamo.AutoSize = true;
            lblFechaPrestamo.BackColor = Color.Transparent;
            lblFechaPrestamo.Font = new Font("Segoe UI", 11F);
            lblFechaPrestamo.ForeColor = Color.FromArgb(31, 41, 55);
            lblFechaPrestamo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFechaPrestamo.Location = new Point(170, 190);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(168, 20);
            lblFechaPrestamo.TabIndex = 4;
            lblFechaPrestamo.Text = "Fecha del préstamo: —";
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.BackColor = Color.Transparent;
            lblFechaDevolucion.Font = new Font("Segoe UI Semibold", 11F);
            lblFechaDevolucion.ForeColor = Color.FromArgb(123, 30, 46);
            lblFechaDevolucion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFechaDevolucion.Location = new Point(440, 190);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(248, 20);
            lblFechaDevolucion.TabIndex = 5;
            lblFechaDevolucion.Text = "Fecha de devolución prevista: —";
            // 
            // lblDetalleCantidad
            // 
            lblDetalleCantidad.AutoSize = true;
            lblDetalleCantidad.BackColor = Color.Transparent;
            lblDetalleCantidad.Font = new Font("Segoe UI", 11F);
            lblDetalleCantidad.ForeColor = Color.FromArgb(31, 41, 55);
            lblDetalleCantidad.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDetalleCantidad.Location = new Point(890, 190);
            lblDetalleCantidad.Name = "lblDetalleCantidad";
            lblDetalleCantidad.Size = new Size(104, 20);
            lblDetalleCantidad.TabIndex = 6;
            lblDetalleCantidad.Text = "Ejemplares: 0";
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
            pnlAcciones.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnConfirmar.Icono = "\uE73E";
            btnConfirmar.Margin = new Padding(12, 0, 0, 0);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(220, 40);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar préstamo";
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
            // FormPrestamo
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrestamo";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar préstamo";
            Load += FormPrestamo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            pnlAcciones.ResumeLayout(false);
            pnlAcciones.PerformLayout();
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
        private DataGridViewTextBoxColumn colSocEstado;
        private Label lblDatosSocio;
        private Label lblEstadoSocio;
        private TarjetaSGB crdEjemplares;
        private Label lblSeccionEjemplares;
        private Label lblBuscarEjemplar;
        private TextBox txtBuscarEjemplar;
        private BotonSGB btnAgregarEjemplar;
        private GrillaSGB dgvResultados;
        private DataGridViewTextBoxColumn colResCodigo;
        private DataGridViewTextBoxColumn colResTitulo;
        private DataGridViewTextBoxColumn colResAutor;
        private DataGridViewTextBoxColumn colResEstado;
        private TarjetaSGB crdDetalle;
        private Label lblSeccionDetalle;
        private Label lblDetalleSocio;
        private GrillaSGB dgvDetalle;
        private DataGridViewTextBoxColumn colDetCodigo;
        private DataGridViewTextBoxColumn colDetTitulo;
        private DataGridViewTextBoxColumn colDetAutor;
        private BotonSGB btnQuitarEjemplar;
        private Label lblFechaPrestamo;
        private Label lblFechaDevolucion;
        private Label lblDetalleCantidad;
        private FlowLayoutPanel pnlAcciones;
        private BotonSGB btnConfirmar;
        private BotonSGB btnCancelar;
    }
}
