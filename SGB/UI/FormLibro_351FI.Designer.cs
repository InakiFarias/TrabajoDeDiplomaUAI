using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormLibro_351FI
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
            crdLibros_351FI = new TarjetaSGB_351FI();
            lblSeccionLibros_351FI = new Label();
            lblBuscar_351FI = new Label();
            txtBuscar_351FI = new TextBox();
            dgvLibros_351FI = new GrillaSGB_351FI();
            colLibCodigo_351FI = new DataGridViewTextBoxColumn();
            colLibTitulo_351FI = new DataGridViewTextBoxColumn();
            colLibAutores_351FI = new DataGridViewTextBoxColumn();
            colLibTemas_351FI = new DataGridViewTextBoxColumn();
            colLibEstado_351FI = new DataGridViewTextBoxColumn();
            crdDatos_351FI = new TarjetaSGB_351FI();
            lblSeccionDatos_351FI = new Label();
            lblCodigo_351FI = new Label();
            lblTituloLibro_351FI = new Label();
            txtTituloLibro_351FI = new TextBox();
            lblAutores_351FI = new Label();
            txtBuscarAutor_351FI = new TextBox();
            clbAutores_351FI = new CheckedListBox();
            lblNuevoAutor_351FI = new Label();
            txtAutorNombre_351FI = new TextBox();
            txtAutorApellido_351FI = new TextBox();
            btnAgregarAutor_351FI = new BotonSGB_351FI();
            lblTemas_351FI = new Label();
            clbTemas_351FI = new CheckedListBox();
            lblNuevoTema_351FI = new Label();
            txtTema_351FI = new TextBox();
            btnAgregarTema_351FI = new BotonSGB_351FI();
            btnAlta_351FI = new BotonSGB_351FI();
            btnModificar_351FI = new BotonSGB_351FI();
            btnBaja_351FI = new BotonSGB_351FI();
            btnReactivar_351FI = new BotonSGB_351FI();
            btnLimpiar_351FI = new BotonSGB_351FI();
            pnlAcciones_351FI = new FlowLayoutPanel();
            btnCerrar_351FI = new BotonSGB_351FI();
            tlpPrincipal_351FI.SuspendLayout();
            crdLibros_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros_351FI).BeginInit();
            crdDatos_351FI.SuspendLayout();
            pnlAcciones_351FI.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal_351FI.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal_351FI.ColumnCount = 2;
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.0F));
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.0F));
            tlpPrincipal_351FI.Controls.Add(crdLibros_351FI, 0, 0);
            tlpPrincipal_351FI.Controls.Add(crdDatos_351FI, 1, 0);
            tlpPrincipal_351FI.Controls.Add(pnlAcciones_351FI, 0, 1);
            tlpPrincipal_351FI.Dock = DockStyle.Fill;
            tlpPrincipal_351FI.Name = "tlpPrincipal_351FI";
            tlpPrincipal_351FI.Padding = new Padding(12);
            tlpPrincipal_351FI.RowCount = 2;
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Absolute, 56.0F));
            tlpPrincipal_351FI.Size = new Size(1100, 640);
            tlpPrincipal_351FI.TabIndex = 0;
            tlpPrincipal_351FI.SetColumnSpan(pnlAcciones_351FI, 2);
            // 
            // crdLibros
            // 
            crdLibros_351FI.Controls.Add(lblSeccionLibros_351FI);
            crdLibros_351FI.Controls.Add(lblBuscar_351FI);
            crdLibros_351FI.Controls.Add(txtBuscar_351FI);
            crdLibros_351FI.Controls.Add(dgvLibros_351FI);
            crdLibros_351FI.Dock = DockStyle.Fill;
            crdLibros_351FI.Margin = new Padding(8);
            crdLibros_351FI.Name = "crdLibros_351FI";
            crdLibros_351FI.Size = new Size(457, 544);
            crdLibros_351FI.TabIndex = 0;
            // 
            // lblSeccionLibros
            // 
            lblSeccionLibros_351FI.AutoSize = true;
            lblSeccionLibros_351FI.BackColor = Color.Transparent;
            lblSeccionLibros_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionLibros_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionLibros_351FI.Location = new Point(20, 16);
            lblSeccionLibros_351FI.Name = "lblSeccionLibros_351FI";
            lblSeccionLibros_351FI.Size = new Size(48, 20);
            lblSeccionLibros_351FI.TabIndex = 0;
            lblSeccionLibros_351FI.Text = "Libros";
            // 
            // lblBuscar
            // 
            lblBuscar_351FI.AutoSize = true;
            lblBuscar_351FI.BackColor = Color.Transparent;
            lblBuscar_351FI.Font = new Font("Segoe UI", 10F);
            lblBuscar_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblBuscar_351FI.Location = new Point(20, 52);
            lblBuscar_351FI.Name = "lblBuscar_351FI";
            lblBuscar_351FI.Size = new Size(360, 20);
            lblBuscar_351FI.TabIndex = 1;
            lblBuscar_351FI.Text = "Código, título o autor (búsqueda incremental)";
            // 
            // txtBuscar
            // 
            txtBuscar_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtBuscar_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar_351FI.Location = new Point(20, 74);
            txtBuscar_351FI.Name = "txtBuscar_351FI";
            txtBuscar_351FI.Size = new Size(417, 27);
            txtBuscar_351FI.TabIndex = 2;
            txtBuscar_351FI.TextChanged += txtBuscar_351FI_TextChanged;
            // 
            // dgvLibros
            // 
            dgvLibros_351FI.Columns.AddRange(new DataGridViewColumn[] { colLibCodigo_351FI, colLibTitulo_351FI, colLibAutores_351FI, colLibTemas_351FI, colLibEstado_351FI });
            dgvLibros_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLibros_351FI.Location = new Point(20, 116);
            dgvLibros_351FI.Name = "dgvLibros_351FI";
            dgvLibros_351FI.Size = new Size(417, 408);
            dgvLibros_351FI.TabIndex = 3;
            // 
            // colLibCodigo
            // 
            colLibCodigo_351FI.FillWeight = 14F;
            colLibCodigo_351FI.HeaderText = "Código";
            colLibCodigo_351FI.Name = "colLibCodigo_351FI";
            colLibCodigo_351FI.ReadOnly = true;
            // 
            // colLibTitulo
            // 
            colLibTitulo_351FI.FillWeight = 34F;
            colLibTitulo_351FI.HeaderText = "Título";
            colLibTitulo_351FI.Name = "colLibTitulo_351FI";
            colLibTitulo_351FI.ReadOnly = true;
            // 
            // colLibAutores
            // 
            colLibAutores_351FI.FillWeight = 28F;
            colLibAutores_351FI.HeaderText = "Autores";
            colLibAutores_351FI.Name = "colLibAutores_351FI";
            colLibAutores_351FI.ReadOnly = true;
            // 
            // colLibTemas
            // 
            colLibTemas_351FI.FillWeight = 14F;
            colLibTemas_351FI.HeaderText = "Temas";
            colLibTemas_351FI.Name = "colLibTemas_351FI";
            colLibTemas_351FI.ReadOnly = true;
            // 
            // colLibEstado
            // 
            colLibEstado_351FI.FillWeight = 10F;
            colLibEstado_351FI.HeaderText = "Estado";
            colLibEstado_351FI.Name = "colLibEstado_351FI";
            colLibEstado_351FI.ReadOnly = true;
            dgvLibros_351FI.SelectionChanged += dgvLibros_351FI_SelectionChanged;
            // 
            // crdDatos
            // 
            crdDatos_351FI.Controls.Add(lblSeccionDatos_351FI);
            crdDatos_351FI.Controls.Add(lblCodigo_351FI);
            crdDatos_351FI.Controls.Add(lblTituloLibro_351FI);
            crdDatos_351FI.Controls.Add(txtTituloLibro_351FI);
            crdDatos_351FI.Controls.Add(lblAutores_351FI);
            crdDatos_351FI.Controls.Add(txtBuscarAutor_351FI);
            crdDatos_351FI.Controls.Add(clbAutores_351FI);
            crdDatos_351FI.Controls.Add(lblNuevoAutor_351FI);
            crdDatos_351FI.Controls.Add(txtAutorNombre_351FI);
            crdDatos_351FI.Controls.Add(txtAutorApellido_351FI);
            crdDatos_351FI.Controls.Add(btnAgregarAutor_351FI);
            crdDatos_351FI.Controls.Add(lblTemas_351FI);
            crdDatos_351FI.Controls.Add(clbTemas_351FI);
            crdDatos_351FI.Controls.Add(lblNuevoTema_351FI);
            crdDatos_351FI.Controls.Add(txtTema_351FI);
            crdDatos_351FI.Controls.Add(btnAgregarTema_351FI);
            crdDatos_351FI.Controls.Add(btnAlta_351FI);
            crdDatos_351FI.Controls.Add(btnModificar_351FI);
            crdDatos_351FI.Controls.Add(btnBaja_351FI);
            crdDatos_351FI.Controls.Add(btnReactivar_351FI);
            crdDatos_351FI.Controls.Add(btnLimpiar_351FI);
            crdDatos_351FI.Dock = DockStyle.Fill;
            crdDatos_351FI.Margin = new Padding(8);
            crdDatos_351FI.Name = "crdDatos_351FI";
            crdDatos_351FI.Size = new Size(587, 544);
            crdDatos_351FI.TabIndex = 1;
            // 
            // lblSeccionDatos
            // 
            lblSeccionDatos_351FI.AutoSize = true;
            lblSeccionDatos_351FI.BackColor = Color.Transparent;
            lblSeccionDatos_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionDatos_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionDatos_351FI.Location = new Point(20, 16);
            lblSeccionDatos_351FI.Name = "lblSeccionDatos_351FI";
            lblSeccionDatos_351FI.Size = new Size(120, 20);
            lblSeccionDatos_351FI.TabIndex = 0;
            lblSeccionDatos_351FI.Text = "Datos del libro";
            // 
            // lblCodigo
            // 
            lblCodigo_351FI.AutoSize = false;
            lblCodigo_351FI.BackColor = Color.Transparent;
            lblCodigo_351FI.Font = new Font("Segoe UI", 11F);
            lblCodigo_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblCodigo_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo_351FI.Location = new Point(20, 50);
            lblCodigo_351FI.Name = "lblCodigo_351FI";
            lblCodigo_351FI.Size = new Size(547, 24);
            lblCodigo_351FI.TabIndex = 1;
            lblCodigo_351FI.Text = "Código: — (se asigna al dar de alta)";
            // 
            // lblTituloLibro
            // 
            lblTituloLibro_351FI.AutoSize = true;
            lblTituloLibro_351FI.BackColor = Color.Transparent;
            lblTituloLibro_351FI.Font = new Font("Segoe UI", 10F);
            lblTituloLibro_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblTituloLibro_351FI.Location = new Point(20, 84);
            lblTituloLibro_351FI.Name = "lblTituloLibro_351FI";
            lblTituloLibro_351FI.Size = new Size(48, 20);
            lblTituloLibro_351FI.TabIndex = 2;
            lblTituloLibro_351FI.Text = "Título";
            // 
            // txtTituloLibro
            // 
            txtTituloLibro_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtTituloLibro_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtTituloLibro_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTituloLibro_351FI.Location = new Point(20, 106);
            txtTituloLibro_351FI.MaxLength = 150;
            txtTituloLibro_351FI.Name = "txtTituloLibro_351FI";
            txtTituloLibro_351FI.Size = new Size(547, 27);
            txtTituloLibro_351FI.TabIndex = 3;
            // 
            // lblAutores
            // 
            lblAutores_351FI.AutoSize = false;
            lblAutores_351FI.BackColor = Color.Transparent;
            lblAutores_351FI.Font = new Font("Segoe UI", 10F);
            lblAutores_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblAutores_351FI.Location = new Point(20, 142);
            lblAutores_351FI.Name = "lblAutores_351FI";
            lblAutores_351FI.Size = new Size(263, 40);
            lblAutores_351FI.TabIndex = 4;
            lblAutores_351FI.Text = "Autores (al menos uno)";
            // 
            // txtBuscarAutor
            // 
            txtBuscarAutor_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarAutor_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtBuscarAutor_351FI.Location = new Point(20, 184);
            txtBuscarAutor_351FI.Name = "txtBuscarAutor_351FI";
            txtBuscarAutor_351FI.PlaceholderText = "Buscar autor";
            txtBuscarAutor_351FI.Size = new Size(263, 27);
            txtBuscarAutor_351FI.TabIndex = 5;
            txtBuscarAutor_351FI.TextChanged += txtBuscarAutor_351FI_TextChanged;
            // 
            // clbAutores
            // 
            clbAutores_351FI.BorderStyle = BorderStyle.FixedSingle;
            clbAutores_351FI.CheckOnClick = true;
            clbAutores_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            clbAutores_351FI.FormattingEnabled = true;
            clbAutores_351FI.IntegralHeight = false;
            clbAutores_351FI.Location = new Point(20, 218);
            clbAutores_351FI.Name = "clbAutores_351FI";
            clbAutores_351FI.Size = new Size(263, 142);
            clbAutores_351FI.TabIndex = 6;
            clbAutores_351FI.ItemCheck += clbAutores_351FI_ItemCheck;
            // 
            // lblNuevoAutor
            // 
            lblNuevoAutor_351FI.AutoSize = true;
            lblNuevoAutor_351FI.BackColor = Color.Transparent;
            lblNuevoAutor_351FI.Font = new Font("Segoe UI", 10F);
            lblNuevoAutor_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblNuevoAutor_351FI.Location = new Point(20, 370);
            lblNuevoAutor_351FI.Name = "lblNuevoAutor_351FI";
            lblNuevoAutor_351FI.Size = new Size(88, 20);
            lblNuevoAutor_351FI.TabIndex = 7;
            lblNuevoAutor_351FI.Text = "Nuevo autor";
            // 
            // txtAutorNombre
            // 
            txtAutorNombre_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtAutorNombre_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtAutorNombre_351FI.Location = new Point(20, 392);
            txtAutorNombre_351FI.MaxLength = 50;
            txtAutorNombre_351FI.Name = "txtAutorNombre_351FI";
            txtAutorNombre_351FI.PlaceholderText = "Nombre";
            txtAutorNombre_351FI.Size = new Size(128, 27);
            txtAutorNombre_351FI.TabIndex = 8;
            // 
            // txtAutorApellido
            // 
            txtAutorApellido_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtAutorApellido_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtAutorApellido_351FI.Location = new Point(154, 392);
            txtAutorApellido_351FI.MaxLength = 50;
            txtAutorApellido_351FI.Name = "txtAutorApellido_351FI";
            txtAutorApellido_351FI.PlaceholderText = "Apellido";
            txtAutorApellido_351FI.Size = new Size(129, 27);
            txtAutorApellido_351FI.TabIndex = 9;
            // 
            // btnAgregarAutor
            // 
            btnAgregarAutor_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnAgregarAutor_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAgregarAutor_351FI.Icono_351FI = "\uE710";
            btnAgregarAutor_351FI.Location = new Point(20, 428);
            btnAgregarAutor_351FI.Name = "btnAgregarAutor_351FI";
            btnAgregarAutor_351FI.Size = new Size(263, 34);
            btnAgregarAutor_351FI.TabIndex = 10;
            btnAgregarAutor_351FI.Text = "Agregar autor";
            btnAgregarAutor_351FI.Click += btnAgregarAutor_351FI_Click;
            // 
            // lblTemas
            // 
            lblTemas_351FI.AutoSize = false;
            lblTemas_351FI.BackColor = Color.Transparent;
            lblTemas_351FI.Font = new Font("Segoe UI", 10F);
            lblTemas_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblTemas_351FI.Location = new Point(303, 142);
            lblTemas_351FI.Name = "lblTemas_351FI";
            lblTemas_351FI.Size = new Size(263, 40);
            lblTemas_351FI.TabIndex = 11;
            lblTemas_351FI.Text = "Temas";
            // 
            // clbTemas
            // 
            clbTemas_351FI.BorderStyle = BorderStyle.FixedSingle;
            clbTemas_351FI.CheckOnClick = true;
            clbTemas_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            clbTemas_351FI.FormattingEnabled = true;
            clbTemas_351FI.IntegralHeight = false;
            clbTemas_351FI.Location = new Point(303, 184);
            clbTemas_351FI.Name = "clbTemas_351FI";
            clbTemas_351FI.Size = new Size(263, 176);
            clbTemas_351FI.TabIndex = 12;
            // 
            // lblNuevoTema
            // 
            lblNuevoTema_351FI.AutoSize = true;
            lblNuevoTema_351FI.BackColor = Color.Transparent;
            lblNuevoTema_351FI.Font = new Font("Segoe UI", 10F);
            lblNuevoTema_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblNuevoTema_351FI.Location = new Point(303, 370);
            lblNuevoTema_351FI.Name = "lblNuevoTema_351FI";
            lblNuevoTema_351FI.Size = new Size(80, 20);
            lblNuevoTema_351FI.TabIndex = 13;
            lblNuevoTema_351FI.Text = "Nuevo tema";
            // 
            // txtTema
            // 
            txtTema_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtTema_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtTema_351FI.Location = new Point(303, 392);
            txtTema_351FI.MaxLength = 100;
            txtTema_351FI.Name = "txtTema_351FI";
            txtTema_351FI.PlaceholderText = "Descripción";
            txtTema_351FI.Size = new Size(263, 27);
            txtTema_351FI.TabIndex = 14;
            // 
            // btnAgregarTema
            // 
            btnAgregarTema_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnAgregarTema_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAgregarTema_351FI.Icono_351FI = "\uE710";
            btnAgregarTema_351FI.Location = new Point(303, 428);
            btnAgregarTema_351FI.Name = "btnAgregarTema_351FI";
            btnAgregarTema_351FI.Size = new Size(263, 34);
            btnAgregarTema_351FI.TabIndex = 15;
            btnAgregarTema_351FI.Text = "Agregar tema";
            btnAgregarTema_351FI.Click += btnAgregarTema_351FI_Click;
            // 
            // btnAlta
            // 
            btnAlta_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAlta_351FI.Icono_351FI = "\uE710";
            btnAlta_351FI.Location = new Point(20, 484);
            btnAlta_351FI.Name = "btnAlta_351FI";
            btnAlta_351FI.Size = new Size(84, 40);
            btnAlta_351FI.TabIndex = 16;
            btnAlta_351FI.Text = "Alta";
            btnAlta_351FI.Click += btnAlta_351FI_Click;
            // 
            // btnModificar
            // 
            btnModificar_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnModificar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnModificar_351FI.Icono_351FI = "\uE70F";
            btnModificar_351FI.Location = new Point(110, 484);
            btnModificar_351FI.Name = "btnModificar_351FI";
            btnModificar_351FI.Size = new Size(112, 40);
            btnModificar_351FI.TabIndex = 17;
            btnModificar_351FI.Text = "Modificar";
            btnModificar_351FI.Click += btnModificar_351FI_Click;
            // 
            // btnBaja
            // 
            btnBaja_351FI.Estilo_351FI = EstiloBoton_351FI.Peligro;
            btnBaja_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnBaja_351FI.Icono_351FI = "\uE74D";
            btnBaja_351FI.Location = new Point(228, 484);
            btnBaja_351FI.Name = "btnBaja_351FI";
            btnBaja_351FI.Size = new Size(108, 40);
            btnBaja_351FI.TabIndex = 18;
            btnBaja_351FI.Text = "Baja";
            btnBaja_351FI.Click += btnBaja_351FI_Click;
            // 
            // btnReactivar
            // 
            btnReactivar_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnReactivar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnReactivar_351FI.Icono_351FI = "\uE8FB";
            btnReactivar_351FI.Location = new Point(342, 484);
            btnReactivar_351FI.Name = "btnReactivar_351FI";
            btnReactivar_351FI.Size = new Size(118, 40);
            btnReactivar_351FI.TabIndex = 19;
            btnReactivar_351FI.Text = "Reactivar";
            btnReactivar_351FI.Click += btnReactivar_351FI_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnLimpiar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnLimpiar_351FI.Icono_351FI = "\uE894";
            btnLimpiar_351FI.Location = new Point(466, 484);
            btnLimpiar_351FI.Name = "btnLimpiar_351FI";
            btnLimpiar_351FI.Size = new Size(101, 40);
            btnLimpiar_351FI.TabIndex = 20;
            btnLimpiar_351FI.Text = "Limpiar";
            btnLimpiar_351FI.Click += btnLimpiar_351FI_Click;
            // 
            // pnlAcciones
            // 
            pnlAcciones_351FI.BackColor = Color.Transparent;
            pnlAcciones_351FI.Controls.Add(btnCerrar_351FI);
            pnlAcciones_351FI.FlowDirection = FlowDirection.RightToLeft;
            pnlAcciones_351FI.WrapContents = false;
            pnlAcciones_351FI.Dock = DockStyle.Fill;
            pnlAcciones_351FI.Margin = new Padding(8);
            pnlAcciones_351FI.Name = "pnlAcciones_351FI";
            pnlAcciones_351FI.Size = new Size(400, 40);
            pnlAcciones_351FI.TabIndex = 2;
            // 
            // btnCerrar
            // 
            btnCerrar_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnCerrar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnCerrar_351FI.Icono_351FI = "\uE8BB";
            btnCerrar_351FI.Margin = new Padding(12, 0, 0, 0);
            btnCerrar_351FI.Name = "btnCerrar_351FI";
            btnCerrar_351FI.Size = new Size(140, 40);
            btnCerrar_351FI.TabIndex = 0;
            btnCerrar_351FI.Text = "Cerrar";
            btnCerrar_351FI.Click += btnCerrar_351FI_Click;
            // 
            // FormLibro
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal_351FI);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLibro_351FI";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de libros";
            Load += FormLibro_351FI_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLibros_351FI).EndInit();
            pnlAcciones_351FI.ResumeLayout(false);
            pnlAcciones_351FI.PerformLayout();
            crdDatos_351FI.ResumeLayout(false);
            crdDatos_351FI.PerformLayout();
            crdLibros_351FI.ResumeLayout(false);
            crdLibros_351FI.PerformLayout();
            tlpPrincipal_351FI.ResumeLayout(false);
            tlpPrincipal_351FI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal_351FI;
        private TarjetaSGB_351FI crdLibros_351FI;
        private Label lblSeccionLibros_351FI;
        private Label lblBuscar_351FI;
        private TextBox txtBuscar_351FI;
        private GrillaSGB_351FI dgvLibros_351FI;
        private DataGridViewTextBoxColumn colLibCodigo_351FI;
        private DataGridViewTextBoxColumn colLibTitulo_351FI;
        private DataGridViewTextBoxColumn colLibAutores_351FI;
        private DataGridViewTextBoxColumn colLibTemas_351FI;
        private DataGridViewTextBoxColumn colLibEstado_351FI;
        private TarjetaSGB_351FI crdDatos_351FI;
        private Label lblSeccionDatos_351FI;
        private Label lblCodigo_351FI;
        private Label lblTituloLibro_351FI;
        private TextBox txtTituloLibro_351FI;
        private Label lblAutores_351FI;
        private TextBox txtBuscarAutor_351FI;
        private CheckedListBox clbAutores_351FI;
        private Label lblNuevoAutor_351FI;
        private TextBox txtAutorNombre_351FI;
        private TextBox txtAutorApellido_351FI;
        private BotonSGB_351FI btnAgregarAutor_351FI;
        private Label lblTemas_351FI;
        private CheckedListBox clbTemas_351FI;
        private Label lblNuevoTema_351FI;
        private TextBox txtTema_351FI;
        private BotonSGB_351FI btnAgregarTema_351FI;
        private BotonSGB_351FI btnAlta_351FI;
        private BotonSGB_351FI btnModificar_351FI;
        private BotonSGB_351FI btnBaja_351FI;
        private BotonSGB_351FI btnReactivar_351FI;
        private BotonSGB_351FI btnLimpiar_351FI;
        private FlowLayoutPanel pnlAcciones_351FI;
        private BotonSGB_351FI btnCerrar_351FI;
    }
}
