using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FrmGestionUsuarios
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
            crdUsuarios = new TarjetaSGB();
            lblTitulo = new Label();
            lblFiltro = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            lblNumeroUsuarios = new Label();
            lblNumero = new Label();
            grillaUsuarios = new GrillaSGB();
            crdDatos = new TarjetaSGB();
            lblSeccionDatos = new Label();
            label1 = new Label();
            txtNombreUsuario = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            lblRol = new Label();
            cbxRoles = new ComboBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            btnCrearUsuario = new BotonSGB();
            btnModificarUsuario = new BotonSGB();
            btnDesbloquearUsuario = new BotonSGB();
            btnCambiarEstadoUsuario = new BotonSGB();
            btnAplicarCambios = new BotonSGB();
            pnlAcciones = new FlowLayoutPanel();
            btnSalir = new BotonSGB();
            tlpPrincipal.SuspendLayout();
            crdUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaUsuarios).BeginInit();
            crdDatos.SuspendLayout();
            pnlAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal.ColumnCount = 2;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.0F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.0F));
            tlpPrincipal.Controls.Add(crdUsuarios, 0, 0);
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
            // crdUsuarios
            // 
            crdUsuarios.Controls.Add(lblTitulo);
            crdUsuarios.Controls.Add(lblFiltro);
            crdUsuarios.Controls.Add(radioButton1);
            crdUsuarios.Controls.Add(radioButton2);
            crdUsuarios.Controls.Add(lblNumeroUsuarios);
            crdUsuarios.Controls.Add(lblNumero);
            crdUsuarios.Controls.Add(grillaUsuarios);
            crdUsuarios.Dock = DockStyle.Fill;
            crdUsuarios.Margin = new Padding(8);
            crdUsuarios.Name = "crdUsuarios";
            crdUsuarios.Size = new Size(651, 544);
            crdUsuarios.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI Semibold", 12F);
            lblTitulo.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitulo.Location = new Point(20, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(64, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Usuarios";
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.BackColor = Color.Transparent;
            lblFiltro.Font = new Font("Segoe UI", 10F);
            lblFiltro.ForeColor = Color.FromArgb(75, 85, 99);
            lblFiltro.Location = new Point(20, 56);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(56, 20);
            lblFiltro.TabIndex = 1;
            lblFiltro.Text = "Mostrar";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Checked = true;
            radioButton1.ForeColor = Color.FromArgb(31, 41, 55);
            radioButton1.Location = new Point(92, 53);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 24);
            radioButton1.TabIndex = 2;
            radioButton1.Text = "Activos";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.ForeColor = Color.FromArgb(31, 41, 55);
            radioButton2.Location = new Point(196, 53);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(64, 24);
            radioButton2.TabIndex = 3;
            radioButton2.Text = "Todos";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // lblNumeroUsuarios
            // 
            lblNumeroUsuarios.AutoSize = false;
            lblNumeroUsuarios.BackColor = Color.Transparent;
            lblNumeroUsuarios.Font = new Font("Segoe UI", 10F);
            lblNumeroUsuarios.ForeColor = Color.FromArgb(75, 85, 99);
            lblNumeroUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNumeroUsuarios.Location = new Point(351, 54);
            lblNumeroUsuarios.Name = "lblNumeroUsuarios";
            lblNumeroUsuarios.Size = new Size(220, 24);
            lblNumeroUsuarios.TabIndex = 4;
            lblNumeroUsuarios.Text = "Número de usuarios:";
            lblNumeroUsuarios.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = false;
            lblNumero.BackColor = Color.Transparent;
            lblNumero.Font = new Font("Segoe UI Semibold", 11F);
            lblNumero.ForeColor = Color.FromArgb(123, 30, 46);
            lblNumero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNumero.Location = new Point(575, 54);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(56, 24);
            lblNumero.TabIndex = 5;
            lblNumero.Text = "0";
            lblNumero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grillaUsuarios
            // 
            grillaUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grillaUsuarios.Location = new Point(20, 92);
            grillaUsuarios.Name = "grillaUsuarios";
            grillaUsuarios.Size = new Size(611, 432);
            grillaUsuarios.TabIndex = 6;
            // 
            // crdDatos
            // 
            crdDatos.Controls.Add(lblSeccionDatos);
            crdDatos.Controls.Add(label1);
            crdDatos.Controls.Add(txtNombreUsuario);
            crdDatos.Controls.Add(lblDni);
            crdDatos.Controls.Add(txtDni);
            crdDatos.Controls.Add(lblRol);
            crdDatos.Controls.Add(cbxRoles);
            crdDatos.Controls.Add(lblNombre);
            crdDatos.Controls.Add(txtNombre);
            crdDatos.Controls.Add(lblApellido);
            crdDatos.Controls.Add(txtApellido);
            crdDatos.Controls.Add(lblCorreo);
            crdDatos.Controls.Add(txtCorreo);
            crdDatos.Controls.Add(btnCrearUsuario);
            crdDatos.Controls.Add(btnModificarUsuario);
            crdDatos.Controls.Add(btnDesbloquearUsuario);
            crdDatos.Controls.Add(btnCambiarEstadoUsuario);
            crdDatos.Controls.Add(btnAplicarCambios);
            crdDatos.Dock = DockStyle.Fill;
            crdDatos.Margin = new Padding(8);
            crdDatos.Name = "crdDatos";
            crdDatos.Size = new Size(393, 544);
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
            lblSeccionDatos.Size = new Size(136, 20);
            lblSeccionDatos.TabIndex = 0;
            lblSeccionDatos.Text = "Datos del usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(75, 85, 99);
            label1.Location = new Point(20, 52);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario.ForeColor = Color.FromArgb(31, 41, 55);
            txtNombreUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreUsuario.Location = new Point(20, 74);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(353, 27);
            txtNombreUsuario.TabIndex = 2;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.Transparent;
            lblDni.Font = new Font("Segoe UI", 10F);
            lblDni.ForeColor = Color.FromArgb(75, 85, 99);
            lblDni.Location = new Point(20, 110);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(24, 20);
            lblDni.TabIndex = 3;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.ForeColor = Color.FromArgb(31, 41, 55);
            txtDni.Location = new Point(20, 132);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(160, 27);
            txtDni.TabIndex = 4;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.Transparent;
            lblRol.Font = new Font("Segoe UI", 10F);
            lblRol.ForeColor = Color.FromArgb(75, 85, 99);
            lblRol.Location = new Point(196, 110);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(24, 20);
            lblRol.TabIndex = 5;
            lblRol.Text = "Rol";
            // 
            // cbxRoles
            // 
            cbxRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRoles.ForeColor = Color.FromArgb(31, 41, 55);
            cbxRoles.FormattingEnabled = true;
            cbxRoles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxRoles.Location = new Point(196, 132);
            cbxRoles.Name = "cbxRoles";
            cbxRoles.Size = new Size(177, 28);
            cbxRoles.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.ForeColor = Color.FromArgb(75, 85, 99);
            lblNombre.Location = new Point(20, 168);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(48, 20);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.FromArgb(31, 41, 55);
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(20, 190);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(353, 27);
            txtNombre.TabIndex = 8;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Segoe UI", 10F);
            lblApellido.ForeColor = Color.FromArgb(75, 85, 99);
            lblApellido.Location = new Point(20, 226);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(64, 20);
            lblApellido.TabIndex = 9;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.ForeColor = Color.FromArgb(31, 41, 55);
            txtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtApellido.Location = new Point(20, 248);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(353, 27);
            txtApellido.TabIndex = 10;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.Transparent;
            lblCorreo.Font = new Font("Segoe UI", 10F);
            lblCorreo.ForeColor = Color.FromArgb(75, 85, 99);
            lblCorreo.Location = new Point(20, 284);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(48, 20);
            lblCorreo.TabIndex = 11;
            lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.ForeColor = Color.FromArgb(31, 41, 55);
            txtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCorreo.Location = new Point(20, 306);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(353, 27);
            txtCorreo.TabIndex = 12;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Estilo = EstiloBoton.Secundario;
            btnCrearUsuario.Font = new Font("Segoe UI Semibold", 10.5F);
            btnCrearUsuario.Icono = "\uE710";
            btnCrearUsuario.Location = new Point(20, 352);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(172, 40);
            btnCrearUsuario.TabIndex = 13;
            btnCrearUsuario.Text = "Crear";
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Estilo = EstiloBoton.Secundario;
            btnModificarUsuario.Font = new Font("Segoe UI Semibold", 10.5F);
            btnModificarUsuario.Icono = "\uE70F";
            btnModificarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnModificarUsuario.Location = new Point(200, 352);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(173, 40);
            btnModificarUsuario.TabIndex = 14;
            btnModificarUsuario.Text = "Modificar";
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // btnDesbloquearUsuario
            // 
            btnDesbloquearUsuario.Estilo = EstiloBoton.Secundario;
            btnDesbloquearUsuario.Font = new Font("Segoe UI Semibold", 10.5F);
            btnDesbloquearUsuario.Icono = "\uE785";
            btnDesbloquearUsuario.Location = new Point(20, 398);
            btnDesbloquearUsuario.Name = "btnDesbloquearUsuario";
            btnDesbloquearUsuario.Size = new Size(172, 40);
            btnDesbloquearUsuario.TabIndex = 15;
            btnDesbloquearUsuario.Text = "Desbloquear";
            btnDesbloquearUsuario.Click += btnDesbloquearUsuario_Click;
            // 
            // btnCambiarEstadoUsuario
            // 
            btnCambiarEstadoUsuario.Estilo = EstiloBoton.Secundario;
            btnCambiarEstadoUsuario.Font = new Font("Segoe UI Semibold", 10.5F);
            btnCambiarEstadoUsuario.Icono = "\uE8FB";
            btnCambiarEstadoUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCambiarEstadoUsuario.Location = new Point(200, 398);
            btnCambiarEstadoUsuario.Name = "btnCambiarEstadoUsuario";
            btnCambiarEstadoUsuario.Size = new Size(173, 40);
            btnCambiarEstadoUsuario.TabIndex = 16;
            btnCambiarEstadoUsuario.Text = "Activar / Desactivar";
            btnCambiarEstadoUsuario.Click += btnCambiarEstadoUsuario_Click;
            // 
            // btnAplicarCambios
            // 
            btnAplicarCambios.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAplicarCambios.Icono = "\uE73E";
            btnAplicarCambios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAplicarCambios.Location = new Point(20, 452);
            btnAplicarCambios.Name = "btnAplicarCambios";
            btnAplicarCambios.Size = new Size(353, 40);
            btnAplicarCambios.TabIndex = 17;
            btnAplicarCambios.Text = "Aplicar";
            btnAplicarCambios.Click += btnAplicarCambios_Click;
            // 
            // pnlAcciones
            // 
            pnlAcciones.BackColor = Color.Transparent;
            pnlAcciones.Controls.Add(btnSalir);
            pnlAcciones.FlowDirection = FlowDirection.RightToLeft;
            pnlAcciones.WrapContents = false;
            pnlAcciones.Dock = DockStyle.Fill;
            pnlAcciones.Margin = new Padding(8);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(400, 40);
            pnlAcciones.TabIndex = 2;
            // 
            // btnSalir
            // 
            btnSalir.Estilo = EstiloBoton.Secundario;
            btnSalir.Font = new Font("Segoe UI Semibold", 10.5F);
            btnSalir.Icono = "\uE8BB";
            btnSalir.Margin = new Padding(12, 0, 0, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 40);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionUsuarios";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Usuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)grillaUsuarios).EndInit();
            pnlAcciones.ResumeLayout(false);
            pnlAcciones.PerformLayout();
            crdDatos.ResumeLayout(false);
            crdDatos.PerformLayout();
            crdUsuarios.ResumeLayout(false);
            crdUsuarios.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TarjetaSGB crdUsuarios;
        private Label lblTitulo;
        private Label lblFiltro;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label lblNumeroUsuarios;
        private Label lblNumero;
        private GrillaSGB grillaUsuarios;
        private TarjetaSGB crdDatos;
        private Label lblSeccionDatos;
        private Label label1;
        private TextBox txtNombreUsuario;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblRol;
        private ComboBox cbxRoles;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private BotonSGB btnCrearUsuario;
        private BotonSGB btnModificarUsuario;
        private BotonSGB btnDesbloquearUsuario;
        private BotonSGB btnCambiarEstadoUsuario;
        private BotonSGB btnAplicarCambios;
        private FlowLayoutPanel pnlAcciones;
        private BotonSGB btnSalir;
    }
}
