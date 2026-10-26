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
            tlpPrincipal = new TableLayoutPanel();
            crdLibros = new TarjetaSGB();
            lblSeccionLibros = new Label();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            dgvLibros = new GrillaSGB();
            colLibCodigo = new DataGridViewTextBoxColumn();
            colLibTitulo = new DataGridViewTextBoxColumn();
            colLibAutores = new DataGridViewTextBoxColumn();
            colLibTemas = new DataGridViewTextBoxColumn();
            colLibEstado = new DataGridViewTextBoxColumn();
            crdDatos = new TarjetaSGB();
            lblSeccionDatos = new Label();
            lblCodigo = new Label();
            lblTituloLibro = new Label();
            txtTituloLibro = new TextBox();
            lblAutores = new Label();
            txtBuscarAutor = new TextBox();
            clbAutores = new CheckedListBox();
            lblNuevoAutor = new Label();
            txtAutorNombre = new TextBox();
            txtAutorApellido = new TextBox();
            btnAgregarAutor = new BotonSGB();
            lblTemas = new Label();
            clbTemas = new CheckedListBox();
            lblNuevoTema = new Label();
            txtTema = new TextBox();
            btnAgregarTema = new BotonSGB();
            btnAlta = new BotonSGB();
            btnModificar = new BotonSGB();
            btnBaja = new BotonSGB();
            btnReactivar = new BotonSGB();
            btnLimpiar = new BotonSGB();
            pnlAcciones = new FlowLayoutPanel();
            btnCerrar = new BotonSGB();
            tlpPrincipal.SuspendLayout();
            crdLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            crdDatos.SuspendLayout();
            pnlAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal.ColumnCount = 2;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.0F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.0F));
            tlpPrincipal.Controls.Add(crdLibros, 0, 0);
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
            // crdLibros
            // 
            crdLibros.Controls.Add(lblSeccionLibros);
            crdLibros.Controls.Add(lblBuscar);
            crdLibros.Controls.Add(txtBuscar);
            crdLibros.Controls.Add(dgvLibros);
            crdLibros.Dock = DockStyle.Fill;
            crdLibros.Margin = new Padding(8);
            crdLibros.Name = "crdLibros";
            crdLibros.Size = new Size(457, 544);
            crdLibros.TabIndex = 0;
            // 
            // lblSeccionLibros
            // 
            lblSeccionLibros.AutoSize = true;
            lblSeccionLibros.BackColor = Color.Transparent;
            lblSeccionLibros.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionLibros.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionLibros.Location = new Point(20, 16);
            lblSeccionLibros.Name = "lblSeccionLibros";
            lblSeccionLibros.Size = new Size(48, 20);
            lblSeccionLibros.TabIndex = 0;
            lblSeccionLibros.Text = "Libros";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.Transparent;
            lblBuscar.Font = new Font("Segoe UI", 10F);
            lblBuscar.ForeColor = Color.FromArgb(75, 85, 99);
            lblBuscar.Location = new Point(20, 52);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(360, 20);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Código, título o autor (búsqueda incremental)";
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.ForeColor = Color.FromArgb(31, 41, 55);
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Location = new Point(20, 74);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(417, 27);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvLibros
            // 
            dgvLibros.Columns.AddRange(new DataGridViewColumn[] { colLibCodigo, colLibTitulo, colLibAutores, colLibTemas, colLibEstado });
            dgvLibros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLibros.Location = new Point(20, 116);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(417, 408);
            dgvLibros.TabIndex = 3;
            // 
            // colLibCodigo
            // 
            colLibCodigo.FillWeight = 14F;
            colLibCodigo.HeaderText = "Código";
            colLibCodigo.Name = "colLibCodigo";
            colLibCodigo.ReadOnly = true;
            // 
            // colLibTitulo
            // 
            colLibTitulo.FillWeight = 34F;
            colLibTitulo.HeaderText = "Título";
            colLibTitulo.Name = "colLibTitulo";
            colLibTitulo.ReadOnly = true;
            // 
            // colLibAutores
            // 
            colLibAutores.FillWeight = 28F;
            colLibAutores.HeaderText = "Autores";
            colLibAutores.Name = "colLibAutores";
            colLibAutores.ReadOnly = true;
            // 
            // colLibTemas
            // 
            colLibTemas.FillWeight = 14F;
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
            dgvLibros.SelectionChanged += dgvLibros_SelectionChanged;
            // 
            // crdDatos
            // 
            crdDatos.Controls.Add(lblSeccionDatos);
            crdDatos.Controls.Add(lblCodigo);
            crdDatos.Controls.Add(lblTituloLibro);
            crdDatos.Controls.Add(txtTituloLibro);
            crdDatos.Controls.Add(lblAutores);
            crdDatos.Controls.Add(txtBuscarAutor);
            crdDatos.Controls.Add(clbAutores);
            crdDatos.Controls.Add(lblNuevoAutor);
            crdDatos.Controls.Add(txtAutorNombre);
            crdDatos.Controls.Add(txtAutorApellido);
            crdDatos.Controls.Add(btnAgregarAutor);
            crdDatos.Controls.Add(lblTemas);
            crdDatos.Controls.Add(clbTemas);
            crdDatos.Controls.Add(lblNuevoTema);
            crdDatos.Controls.Add(txtTema);
            crdDatos.Controls.Add(btnAgregarTema);
            crdDatos.Controls.Add(btnAlta);
            crdDatos.Controls.Add(btnModificar);
            crdDatos.Controls.Add(btnBaja);
            crdDatos.Controls.Add(btnReactivar);
            crdDatos.Controls.Add(btnLimpiar);
            crdDatos.Dock = DockStyle.Fill;
            crdDatos.Margin = new Padding(8);
            crdDatos.Name = "crdDatos";
            crdDatos.Size = new Size(587, 544);
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
            lblSeccionDatos.Size = new Size(120, 20);
            lblSeccionDatos.TabIndex = 0;
            lblSeccionDatos.Text = "Datos del libro";
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
            lblCodigo.Size = new Size(547, 24);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código: — (se asigna al dar de alta)";
            // 
            // lblTituloLibro
            // 
            lblTituloLibro.AutoSize = true;
            lblTituloLibro.BackColor = Color.Transparent;
            lblTituloLibro.Font = new Font("Segoe UI", 10F);
            lblTituloLibro.ForeColor = Color.FromArgb(75, 85, 99);
            lblTituloLibro.Location = new Point(20, 84);
            lblTituloLibro.Name = "lblTituloLibro";
            lblTituloLibro.Size = new Size(48, 20);
            lblTituloLibro.TabIndex = 2;
            lblTituloLibro.Text = "Título";
            // 
            // txtTituloLibro
            // 
            txtTituloLibro.BorderStyle = BorderStyle.FixedSingle;
            txtTituloLibro.ForeColor = Color.FromArgb(31, 41, 55);
            txtTituloLibro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTituloLibro.Location = new Point(20, 106);
            txtTituloLibro.MaxLength = 150;
            txtTituloLibro.Name = "txtTituloLibro";
            txtTituloLibro.Size = new Size(547, 27);
            txtTituloLibro.TabIndex = 3;
            // 
            // lblAutores
            // 
            lblAutores.AutoSize = false;
            lblAutores.BackColor = Color.Transparent;
            lblAutores.Font = new Font("Segoe UI", 10F);
            lblAutores.ForeColor = Color.FromArgb(75, 85, 99);
            lblAutores.Location = new Point(20, 142);
            lblAutores.Name = "lblAutores";
            lblAutores.Size = new Size(263, 40);
            lblAutores.TabIndex = 4;
            lblAutores.Text = "Autores (al menos uno)";
            // 
            // txtBuscarAutor
            // 
            txtBuscarAutor.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarAutor.ForeColor = Color.FromArgb(31, 41, 55);
            txtBuscarAutor.Location = new Point(20, 184);
            txtBuscarAutor.Name = "txtBuscarAutor";
            txtBuscarAutor.PlaceholderText = "Buscar autor";
            txtBuscarAutor.Size = new Size(263, 27);
            txtBuscarAutor.TabIndex = 5;
            txtBuscarAutor.TextChanged += txtBuscarAutor_TextChanged;
            // 
            // clbAutores
            // 
            clbAutores.BorderStyle = BorderStyle.FixedSingle;
            clbAutores.CheckOnClick = true;
            clbAutores.ForeColor = Color.FromArgb(31, 41, 55);
            clbAutores.FormattingEnabled = true;
            clbAutores.IntegralHeight = false;
            clbAutores.Location = new Point(20, 218);
            clbAutores.Name = "clbAutores";
            clbAutores.Size = new Size(263, 142);
            clbAutores.TabIndex = 6;
            clbAutores.ItemCheck += clbAutores_ItemCheck;
            // 
            // lblNuevoAutor
            // 
            lblNuevoAutor.AutoSize = true;
            lblNuevoAutor.BackColor = Color.Transparent;
            lblNuevoAutor.Font = new Font("Segoe UI", 10F);
            lblNuevoAutor.ForeColor = Color.FromArgb(75, 85, 99);
            lblNuevoAutor.Location = new Point(20, 370);
            lblNuevoAutor.Name = "lblNuevoAutor";
            lblNuevoAutor.Size = new Size(88, 20);
            lblNuevoAutor.TabIndex = 7;
            lblNuevoAutor.Text = "Nuevo autor";
            // 
            // txtAutorNombre
            // 
            txtAutorNombre.BorderStyle = BorderStyle.FixedSingle;
            txtAutorNombre.ForeColor = Color.FromArgb(31, 41, 55);
            txtAutorNombre.Location = new Point(20, 392);
            txtAutorNombre.MaxLength = 50;
            txtAutorNombre.Name = "txtAutorNombre";
            txtAutorNombre.PlaceholderText = "Nombre";
            txtAutorNombre.Size = new Size(128, 27);
            txtAutorNombre.TabIndex = 8;
            // 
            // txtAutorApellido
            // 
            txtAutorApellido.BorderStyle = BorderStyle.FixedSingle;
            txtAutorApellido.ForeColor = Color.FromArgb(31, 41, 55);
            txtAutorApellido.Location = new Point(154, 392);
            txtAutorApellido.MaxLength = 50;
            txtAutorApellido.Name = "txtAutorApellido";
            txtAutorApellido.PlaceholderText = "Apellido";
            txtAutorApellido.Size = new Size(129, 27);
            txtAutorApellido.TabIndex = 9;
            // 
            // btnAgregarAutor
            // 
            btnAgregarAutor.Estilo = EstiloBoton.Secundario;
            btnAgregarAutor.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAgregarAutor.Icono = "\uE710";
            btnAgregarAutor.Location = new Point(20, 428);
            btnAgregarAutor.Name = "btnAgregarAutor";
            btnAgregarAutor.Size = new Size(263, 34);
            btnAgregarAutor.TabIndex = 10;
            btnAgregarAutor.Text = "Agregar autor";
            btnAgregarAutor.Click += btnAgregarAutor_Click;
            // 
            // lblTemas
            // 
            lblTemas.AutoSize = false;
            lblTemas.BackColor = Color.Transparent;
            lblTemas.Font = new Font("Segoe UI", 10F);
            lblTemas.ForeColor = Color.FromArgb(75, 85, 99);
            lblTemas.Location = new Point(303, 142);
            lblTemas.Name = "lblTemas";
            lblTemas.Size = new Size(263, 40);
            lblTemas.TabIndex = 11;
            lblTemas.Text = "Temas";
            // 
            // clbTemas
            // 
            clbTemas.BorderStyle = BorderStyle.FixedSingle;
            clbTemas.CheckOnClick = true;
            clbTemas.ForeColor = Color.FromArgb(31, 41, 55);
            clbTemas.FormattingEnabled = true;
            clbTemas.IntegralHeight = false;
            clbTemas.Location = new Point(303, 184);
            clbTemas.Name = "clbTemas";
            clbTemas.Size = new Size(263, 176);
            clbTemas.TabIndex = 12;
            // 
            // lblNuevoTema
            // 
            lblNuevoTema.AutoSize = true;
            lblNuevoTema.BackColor = Color.Transparent;
            lblNuevoTema.Font = new Font("Segoe UI", 10F);
            lblNuevoTema.ForeColor = Color.FromArgb(75, 85, 99);
            lblNuevoTema.Location = new Point(303, 370);
            lblNuevoTema.Name = "lblNuevoTema";
            lblNuevoTema.Size = new Size(80, 20);
            lblNuevoTema.TabIndex = 13;
            lblNuevoTema.Text = "Nuevo tema";
            // 
            // txtTema
            // 
            txtTema.BorderStyle = BorderStyle.FixedSingle;
            txtTema.ForeColor = Color.FromArgb(31, 41, 55);
            txtTema.Location = new Point(303, 392);
            txtTema.MaxLength = 100;
            txtTema.Name = "txtTema";
            txtTema.PlaceholderText = "Descripción";
            txtTema.Size = new Size(263, 27);
            txtTema.TabIndex = 14;
            // 
            // btnAgregarTema
            // 
            btnAgregarTema.Estilo = EstiloBoton.Secundario;
            btnAgregarTema.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAgregarTema.Icono = "\uE710";
            btnAgregarTema.Location = new Point(303, 428);
            btnAgregarTema.Name = "btnAgregarTema";
            btnAgregarTema.Size = new Size(263, 34);
            btnAgregarTema.TabIndex = 15;
            btnAgregarTema.Text = "Agregar tema";
            btnAgregarTema.Click += btnAgregarTema_Click;
            // 
            // btnAlta
            // 
            btnAlta.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAlta.Icono = "\uE710";
            btnAlta.Location = new Point(20, 484);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(84, 40);
            btnAlta.TabIndex = 16;
            btnAlta.Text = "Alta";
            btnAlta.Click += btnAlta_Click;
            // 
            // btnModificar
            // 
            btnModificar.Estilo = EstiloBoton.Secundario;
            btnModificar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnModificar.Icono = "\uE70F";
            btnModificar.Location = new Point(110, 484);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 40);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBaja
            // 
            btnBaja.Estilo = EstiloBoton.Peligro;
            btnBaja.Font = new Font("Segoe UI Semibold", 10.5F);
            btnBaja.Icono = "\uE74D";
            btnBaja.Location = new Point(228, 484);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(108, 40);
            btnBaja.TabIndex = 18;
            btnBaja.Text = "Baja";
            btnBaja.Click += btnBaja_Click;
            // 
            // btnReactivar
            // 
            btnReactivar.Estilo = EstiloBoton.Secundario;
            btnReactivar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnReactivar.Icono = "\uE8FB";
            btnReactivar.Location = new Point(342, 484);
            btnReactivar.Name = "btnReactivar";
            btnReactivar.Size = new Size(118, 40);
            btnReactivar.TabIndex = 19;
            btnReactivar.Text = "Reactivar";
            btnReactivar.Click += btnReactivar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Estilo = EstiloBoton.Secundario;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnLimpiar.Icono = "\uE894";
            btnLimpiar.Location = new Point(466, 484);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(101, 40);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
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
            // FormLibro
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLibro";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de libros";
            Load += FormLibro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            pnlAcciones.ResumeLayout(false);
            pnlAcciones.PerformLayout();
            crdDatos.ResumeLayout(false);
            crdDatos.PerformLayout();
            crdLibros.ResumeLayout(false);
            crdLibros.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TarjetaSGB crdLibros;
        private Label lblSeccionLibros;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private GrillaSGB dgvLibros;
        private DataGridViewTextBoxColumn colLibCodigo;
        private DataGridViewTextBoxColumn colLibTitulo;
        private DataGridViewTextBoxColumn colLibAutores;
        private DataGridViewTextBoxColumn colLibTemas;
        private DataGridViewTextBoxColumn colLibEstado;
        private TarjetaSGB crdDatos;
        private Label lblSeccionDatos;
        private Label lblCodigo;
        private Label lblTituloLibro;
        private TextBox txtTituloLibro;
        private Label lblAutores;
        private TextBox txtBuscarAutor;
        private CheckedListBox clbAutores;
        private Label lblNuevoAutor;
        private TextBox txtAutorNombre;
        private TextBox txtAutorApellido;
        private BotonSGB btnAgregarAutor;
        private Label lblTemas;
        private CheckedListBox clbTemas;
        private Label lblNuevoTema;
        private TextBox txtTema;
        private BotonSGB btnAgregarTema;
        private BotonSGB btnAlta;
        private BotonSGB btnModificar;
        private BotonSGB btnBaja;
        private BotonSGB btnReactivar;
        private BotonSGB btnLimpiar;
        private FlowLayoutPanel pnlAcciones;
        private BotonSGB btnCerrar;
    }
}
