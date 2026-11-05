using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FrmGestionUsuarios_351FI
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
            crdUsuarios_351FI = new TarjetaSGB_351FI();
            lblTitulo_351FI = new Label();
            lblFiltro_351FI = new Label();
            radioButton1_351FI = new RadioButton();
            radioButton2_351FI = new RadioButton();
            lblNumeroUsuarios_351FI = new Label();
            lblNumero_351FI = new Label();
            grillaUsuarios_351FI = new GrillaSGB_351FI();
            crdDatos_351FI = new TarjetaSGB_351FI();
            lblSeccionDatos_351FI = new Label();
            label1_351FI = new Label();
            txtNombreUsuario_351FI = new TextBox();
            lblDni_351FI = new Label();
            txtDni_351FI = new TextBox();
            lblRol_351FI = new Label();
            cbxRoles_351FI = new ComboBox();
            lblNombre_351FI = new Label();
            txtNombre_351FI = new TextBox();
            lblApellido_351FI = new Label();
            txtApellido_351FI = new TextBox();
            lblCorreo_351FI = new Label();
            txtCorreo_351FI = new TextBox();
            btnCrearUsuario_351FI = new BotonSGB_351FI();
            btnModificarUsuario_351FI = new BotonSGB_351FI();
            btnDesbloquearUsuario_351FI = new BotonSGB_351FI();
            btnCambiarEstadoUsuario_351FI = new BotonSGB_351FI();
            btnAplicarCambios_351FI = new BotonSGB_351FI();
            pnlAcciones_351FI = new FlowLayoutPanel();
            btnSalir_351FI = new BotonSGB_351FI();
            tlpPrincipal_351FI.SuspendLayout();
            crdUsuarios_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaUsuarios_351FI).BeginInit();
            crdDatos_351FI.SuspendLayout();
            pnlAcciones_351FI.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal_351FI.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal_351FI.ColumnCount = 2;
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.0F));
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.0F));
            tlpPrincipal_351FI.Controls.Add(crdUsuarios_351FI, 0, 0);
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
            // crdUsuarios
            // 
            crdUsuarios_351FI.Controls.Add(lblTitulo_351FI);
            crdUsuarios_351FI.Controls.Add(lblFiltro_351FI);
            crdUsuarios_351FI.Controls.Add(radioButton1_351FI);
            crdUsuarios_351FI.Controls.Add(radioButton2_351FI);
            crdUsuarios_351FI.Controls.Add(lblNumeroUsuarios_351FI);
            crdUsuarios_351FI.Controls.Add(lblNumero_351FI);
            crdUsuarios_351FI.Controls.Add(grillaUsuarios_351FI);
            crdUsuarios_351FI.Dock = DockStyle.Fill;
            crdUsuarios_351FI.Margin = new Padding(8);
            crdUsuarios_351FI.Name = "crdUsuarios_351FI";
            crdUsuarios_351FI.Size = new Size(651, 544);
            crdUsuarios_351FI.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo_351FI.AutoSize = true;
            lblTitulo_351FI.BackColor = Color.Transparent;
            lblTitulo_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblTitulo_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitulo_351FI.Location = new Point(20, 16);
            lblTitulo_351FI.Name = "lblTitulo_351FI";
            lblTitulo_351FI.Size = new Size(64, 20);
            lblTitulo_351FI.TabIndex = 0;
            lblTitulo_351FI.Text = "Usuarios";
            // 
            // lblFiltro
            // 
            lblFiltro_351FI.AutoSize = true;
            lblFiltro_351FI.BackColor = Color.Transparent;
            lblFiltro_351FI.Font = new Font("Segoe UI", 10F);
            lblFiltro_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblFiltro_351FI.Location = new Point(20, 56);
            lblFiltro_351FI.Name = "lblFiltro_351FI";
            lblFiltro_351FI.Size = new Size(56, 20);
            lblFiltro_351FI.TabIndex = 1;
            lblFiltro_351FI.Text = "Mostrar";
            // 
            // radioButton1
            // 
            radioButton1_351FI.AutoSize = true;
            radioButton1_351FI.BackColor = Color.Transparent;
            radioButton1_351FI.Checked = true;
            radioButton1_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            radioButton1_351FI.Location = new Point(92, 53);
            radioButton1_351FI.Name = "radioButton1_351FI";
            radioButton1_351FI.Size = new Size(80, 24);
            radioButton1_351FI.TabIndex = 2;
            radioButton1_351FI.Text = "Activos";
            radioButton1_351FI.UseVisualStyleBackColor = false;
            radioButton1_351FI.CheckedChanged += radioButton1_351FI_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2_351FI.AutoSize = true;
            radioButton2_351FI.BackColor = Color.Transparent;
            radioButton2_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            radioButton2_351FI.Location = new Point(196, 53);
            radioButton2_351FI.Name = "radioButton2_351FI";
            radioButton2_351FI.Size = new Size(64, 24);
            radioButton2_351FI.TabIndex = 3;
            radioButton2_351FI.Text = "Todos";
            radioButton2_351FI.UseVisualStyleBackColor = false;
            radioButton2_351FI.CheckedChanged += radioButton2_351FI_CheckedChanged;
            // 
            // lblNumeroUsuarios
            // 
            lblNumeroUsuarios_351FI.AutoSize = false;
            lblNumeroUsuarios_351FI.BackColor = Color.Transparent;
            lblNumeroUsuarios_351FI.Font = new Font("Segoe UI", 10F);
            lblNumeroUsuarios_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblNumeroUsuarios_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNumeroUsuarios_351FI.Location = new Point(351, 54);
            lblNumeroUsuarios_351FI.Name = "lblNumeroUsuarios_351FI";
            lblNumeroUsuarios_351FI.Size = new Size(220, 24);
            lblNumeroUsuarios_351FI.TabIndex = 4;
            lblNumeroUsuarios_351FI.Text = "Número de usuarios:";
            lblNumeroUsuarios_351FI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumero
            // 
            lblNumero_351FI.AutoSize = false;
            lblNumero_351FI.BackColor = Color.Transparent;
            lblNumero_351FI.Font = new Font("Segoe UI Semibold", 11F);
            lblNumero_351FI.ForeColor = Color.FromArgb(123, 30, 46);
            lblNumero_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNumero_351FI.Location = new Point(575, 54);
            lblNumero_351FI.Name = "lblNumero_351FI";
            lblNumero_351FI.Size = new Size(56, 24);
            lblNumero_351FI.TabIndex = 5;
            lblNumero_351FI.Text = "0";
            lblNumero_351FI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grillaUsuarios
            // 
            grillaUsuarios_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grillaUsuarios_351FI.Location = new Point(20, 92);
            grillaUsuarios_351FI.Name = "grillaUsuarios_351FI";
            grillaUsuarios_351FI.Size = new Size(611, 432);
            grillaUsuarios_351FI.TabIndex = 6;
            // 
            // crdDatos
            // 
            crdDatos_351FI.Controls.Add(lblSeccionDatos_351FI);
            crdDatos_351FI.Controls.Add(label1_351FI);
            crdDatos_351FI.Controls.Add(txtNombreUsuario_351FI);
            crdDatos_351FI.Controls.Add(lblDni_351FI);
            crdDatos_351FI.Controls.Add(txtDni_351FI);
            crdDatos_351FI.Controls.Add(lblRol_351FI);
            crdDatos_351FI.Controls.Add(cbxRoles_351FI);
            crdDatos_351FI.Controls.Add(lblNombre_351FI);
            crdDatos_351FI.Controls.Add(txtNombre_351FI);
            crdDatos_351FI.Controls.Add(lblApellido_351FI);
            crdDatos_351FI.Controls.Add(txtApellido_351FI);
            crdDatos_351FI.Controls.Add(lblCorreo_351FI);
            crdDatos_351FI.Controls.Add(txtCorreo_351FI);
            crdDatos_351FI.Controls.Add(btnCrearUsuario_351FI);
            crdDatos_351FI.Controls.Add(btnModificarUsuario_351FI);
            crdDatos_351FI.Controls.Add(btnDesbloquearUsuario_351FI);
            crdDatos_351FI.Controls.Add(btnCambiarEstadoUsuario_351FI);
            crdDatos_351FI.Controls.Add(btnAplicarCambios_351FI);
            crdDatos_351FI.Dock = DockStyle.Fill;
            crdDatos_351FI.Margin = new Padding(8);
            crdDatos_351FI.Name = "crdDatos_351FI";
            crdDatos_351FI.Size = new Size(393, 544);
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
            lblSeccionDatos_351FI.Size = new Size(136, 20);
            lblSeccionDatos_351FI.TabIndex = 0;
            lblSeccionDatos_351FI.Text = "Datos del usuario";
            // 
            // label1
            // 
            label1_351FI.AutoSize = true;
            label1_351FI.BackColor = Color.Transparent;
            label1_351FI.Font = new Font("Segoe UI", 10F);
            label1_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            label1_351FI.Location = new Point(20, 52);
            label1_351FI.Name = "label1_351FI";
            label1_351FI.Size = new Size(56, 20);
            label1_351FI.TabIndex = 1;
            label1_351FI.Text = "Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtNombreUsuario_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreUsuario_351FI.Location = new Point(20, 74);
            txtNombreUsuario_351FI.Name = "txtNombreUsuario_351FI";
            txtNombreUsuario_351FI.Size = new Size(353, 27);
            txtNombreUsuario_351FI.TabIndex = 2;
            // 
            // lblDni
            // 
            lblDni_351FI.AutoSize = true;
            lblDni_351FI.BackColor = Color.Transparent;
            lblDni_351FI.Font = new Font("Segoe UI", 10F);
            lblDni_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblDni_351FI.Location = new Point(20, 110);
            lblDni_351FI.Name = "lblDni_351FI";
            lblDni_351FI.Size = new Size(24, 20);
            lblDni_351FI.TabIndex = 3;
            lblDni_351FI.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtDni_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtDni_351FI.Location = new Point(20, 132);
            txtDni_351FI.Name = "txtDni_351FI";
            txtDni_351FI.Size = new Size(160, 27);
            txtDni_351FI.TabIndex = 4;
            // 
            // lblRol
            // 
            lblRol_351FI.AutoSize = true;
            lblRol_351FI.BackColor = Color.Transparent;
            lblRol_351FI.Font = new Font("Segoe UI", 10F);
            lblRol_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblRol_351FI.Location = new Point(196, 110);
            lblRol_351FI.Name = "lblRol_351FI";
            lblRol_351FI.Size = new Size(24, 20);
            lblRol_351FI.TabIndex = 5;
            lblRol_351FI.Text = "Rol";
            // 
            // cbxRoles
            // 
            cbxRoles_351FI.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRoles_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            cbxRoles_351FI.FormattingEnabled = true;
            cbxRoles_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxRoles_351FI.Location = new Point(196, 132);
            cbxRoles_351FI.Name = "cbxRoles_351FI";
            cbxRoles_351FI.Size = new Size(177, 28);
            cbxRoles_351FI.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre_351FI.AutoSize = true;
            lblNombre_351FI.BackColor = Color.Transparent;
            lblNombre_351FI.Font = new Font("Segoe UI", 10F);
            lblNombre_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblNombre_351FI.Location = new Point(20, 168);
            lblNombre_351FI.Name = "lblNombre_351FI";
            lblNombre_351FI.Size = new Size(48, 20);
            lblNombre_351FI.TabIndex = 7;
            lblNombre_351FI.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtNombre_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtNombre_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre_351FI.Location = new Point(20, 190);
            txtNombre_351FI.Name = "txtNombre_351FI";
            txtNombre_351FI.Size = new Size(353, 27);
            txtNombre_351FI.TabIndex = 8;
            // 
            // lblApellido
            // 
            lblApellido_351FI.AutoSize = true;
            lblApellido_351FI.BackColor = Color.Transparent;
            lblApellido_351FI.Font = new Font("Segoe UI", 10F);
            lblApellido_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblApellido_351FI.Location = new Point(20, 226);
            lblApellido_351FI.Name = "lblApellido_351FI";
            lblApellido_351FI.Size = new Size(64, 20);
            lblApellido_351FI.TabIndex = 9;
            lblApellido_351FI.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtApellido_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtApellido_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtApellido_351FI.Location = new Point(20, 248);
            txtApellido_351FI.Name = "txtApellido_351FI";
            txtApellido_351FI.Size = new Size(353, 27);
            txtApellido_351FI.TabIndex = 10;
            // 
            // lblCorreo
            // 
            lblCorreo_351FI.AutoSize = true;
            lblCorreo_351FI.BackColor = Color.Transparent;
            lblCorreo_351FI.Font = new Font("Segoe UI", 10F);
            lblCorreo_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblCorreo_351FI.Location = new Point(20, 284);
            lblCorreo_351FI.Name = "lblCorreo_351FI";
            lblCorreo_351FI.Size = new Size(48, 20);
            lblCorreo_351FI.TabIndex = 11;
            lblCorreo_351FI.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtCorreo_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCorreo_351FI.Location = new Point(20, 306);
            txtCorreo_351FI.Name = "txtCorreo_351FI";
            txtCorreo_351FI.Size = new Size(353, 27);
            txtCorreo_351FI.TabIndex = 12;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnCrearUsuario_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnCrearUsuario_351FI.Icono_351FI = "\uE710";
            btnCrearUsuario_351FI.Location = new Point(20, 352);
            btnCrearUsuario_351FI.Name = "btnCrearUsuario_351FI";
            btnCrearUsuario_351FI.Size = new Size(172, 40);
            btnCrearUsuario_351FI.TabIndex = 13;
            btnCrearUsuario_351FI.Text = "Crear";
            btnCrearUsuario_351FI.Click += btnCrearUsuario_351FI_Click;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnModificarUsuario_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnModificarUsuario_351FI.Icono_351FI = "\uE70F";
            btnModificarUsuario_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnModificarUsuario_351FI.Location = new Point(200, 352);
            btnModificarUsuario_351FI.Name = "btnModificarUsuario_351FI";
            btnModificarUsuario_351FI.Size = new Size(173, 40);
            btnModificarUsuario_351FI.TabIndex = 14;
            btnModificarUsuario_351FI.Text = "Modificar";
            btnModificarUsuario_351FI.Click += btnModificarUsuario_351FI_Click;
            // 
            // btnDesbloquearUsuario
            // 
            btnDesbloquearUsuario_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnDesbloquearUsuario_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnDesbloquearUsuario_351FI.Icono_351FI = "\uE785";
            btnDesbloquearUsuario_351FI.Location = new Point(20, 398);
            btnDesbloquearUsuario_351FI.Name = "btnDesbloquearUsuario_351FI";
            btnDesbloquearUsuario_351FI.Size = new Size(172, 40);
            btnDesbloquearUsuario_351FI.TabIndex = 15;
            btnDesbloquearUsuario_351FI.Text = "Desbloquear";
            btnDesbloquearUsuario_351FI.Click += btnDesbloquearUsuario_351FI_Click;
            // 
            // btnCambiarEstadoUsuario
            // 
            btnCambiarEstadoUsuario_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnCambiarEstadoUsuario_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnCambiarEstadoUsuario_351FI.Icono_351FI = "\uE8FB";
            btnCambiarEstadoUsuario_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCambiarEstadoUsuario_351FI.Location = new Point(200, 398);
            btnCambiarEstadoUsuario_351FI.Name = "btnCambiarEstadoUsuario_351FI";
            btnCambiarEstadoUsuario_351FI.Size = new Size(173, 40);
            btnCambiarEstadoUsuario_351FI.TabIndex = 16;
            btnCambiarEstadoUsuario_351FI.Text = "Activar / Desactivar";
            btnCambiarEstadoUsuario_351FI.Click += btnCambiarEstadoUsuario_351FI_Click;
            // 
            // btnAplicarCambios
            // 
            btnAplicarCambios_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAplicarCambios_351FI.Icono_351FI = "\uE73E";
            btnAplicarCambios_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAplicarCambios_351FI.Location = new Point(20, 452);
            btnAplicarCambios_351FI.Name = "btnAplicarCambios_351FI";
            btnAplicarCambios_351FI.Size = new Size(353, 40);
            btnAplicarCambios_351FI.TabIndex = 17;
            btnAplicarCambios_351FI.Text = "Aplicar";
            btnAplicarCambios_351FI.Click += btnAplicarCambios_351FI_Click;
            // 
            // pnlAcciones
            // 
            pnlAcciones_351FI.BackColor = Color.Transparent;
            pnlAcciones_351FI.Controls.Add(btnSalir_351FI);
            pnlAcciones_351FI.FlowDirection = FlowDirection.RightToLeft;
            pnlAcciones_351FI.WrapContents = false;
            pnlAcciones_351FI.Dock = DockStyle.Fill;
            pnlAcciones_351FI.Margin = new Padding(8);
            pnlAcciones_351FI.Name = "pnlAcciones_351FI";
            pnlAcciones_351FI.Size = new Size(400, 40);
            pnlAcciones_351FI.TabIndex = 2;
            // 
            // btnSalir
            // 
            btnSalir_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnSalir_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnSalir_351FI.Icono_351FI = "\uE8BB";
            btnSalir_351FI.Margin = new Padding(12, 0, 0, 0);
            btnSalir_351FI.Name = "btnSalir_351FI";
            btnSalir_351FI.Size = new Size(140, 40);
            btnSalir_351FI.TabIndex = 0;
            btnSalir_351FI.Text = "Salir";
            btnSalir_351FI.Click += btnSalir_351FI_Click;
            // 
            // FrmGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal_351FI);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionUsuarios_351FI";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Usuarios";
            Load += FrmUsuarios_Load_351FI;
            ((System.ComponentModel.ISupportInitialize)grillaUsuarios_351FI).EndInit();
            pnlAcciones_351FI.ResumeLayout(false);
            pnlAcciones_351FI.PerformLayout();
            crdDatos_351FI.ResumeLayout(false);
            crdDatos_351FI.PerformLayout();
            crdUsuarios_351FI.ResumeLayout(false);
            crdUsuarios_351FI.PerformLayout();
            tlpPrincipal_351FI.ResumeLayout(false);
            tlpPrincipal_351FI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal_351FI;
        private TarjetaSGB_351FI crdUsuarios_351FI;
        private Label lblTitulo_351FI;
        private Label lblFiltro_351FI;
        private RadioButton radioButton1_351FI;
        private RadioButton radioButton2_351FI;
        private Label lblNumeroUsuarios_351FI;
        private Label lblNumero_351FI;
        private GrillaSGB_351FI grillaUsuarios_351FI;
        private TarjetaSGB_351FI crdDatos_351FI;
        private Label lblSeccionDatos_351FI;
        private Label label1_351FI;
        private TextBox txtNombreUsuario_351FI;
        private Label lblDni_351FI;
        private TextBox txtDni_351FI;
        private Label lblRol_351FI;
        private ComboBox cbxRoles_351FI;
        private Label lblNombre_351FI;
        private TextBox txtNombre_351FI;
        private Label lblApellido_351FI;
        private TextBox txtApellido_351FI;
        private Label lblCorreo_351FI;
        private TextBox txtCorreo_351FI;
        private BotonSGB_351FI btnCrearUsuario_351FI;
        private BotonSGB_351FI btnModificarUsuario_351FI;
        private BotonSGB_351FI btnDesbloquearUsuario_351FI;
        private BotonSGB_351FI btnCambiarEstadoUsuario_351FI;
        private BotonSGB_351FI btnAplicarCambios_351FI;
        private FlowLayoutPanel pnlAcciones_351FI;
        private BotonSGB_351FI btnSalir_351FI;
    }
}
