using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FrmBitacora
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
            crdFiltros = new TarjetaSGB();
            lblTitulo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblLogin = new Label();
            txtNombreUsuario = new TextBox();
            lblModulo = new Label();
            cbxModulo = new ComboBox();
            lblEvento = new Label();
            cbxEvento = new ComboBox();
            lblCriticidad = new Label();
            cbxCriticidad = new ComboBox();
            lblFechaInicio = new Label();
            dtpFechaInicio = new DateTimePicker();
            lblFechaFin = new Label();
            dtpFechaFin = new DateTimePicker();
            btnAplicar = new BotonSGB();
            btnLimpiar = new BotonSGB();
            crdEventos = new TarjetaSGB();
            grillaBitacora = new GrillaSGB();
            pnlAcciones = new FlowLayoutPanel();
            btnSalir = new BotonSGB();
            btnImprimirBitacora = new BotonSGB();
            tlpPrincipal.SuspendLayout();
            crdFiltros.SuspendLayout();
            crdEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaBitacora).BeginInit();
            pnlAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0F));
            tlpPrincipal.Controls.Add(crdFiltros, 0, 0);
            tlpPrincipal.Controls.Add(crdEventos, 0, 1);
            tlpPrincipal.Controls.Add(pnlAcciones, 0, 2);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(12);
            tlpPrincipal.RowCount = 3;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 196.0F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 56.0F));
            tlpPrincipal.Size = new Size(1100, 640);
            tlpPrincipal.TabIndex = 0;
            // 
            // crdFiltros
            // 
            crdFiltros.Controls.Add(lblTitulo);
            crdFiltros.Controls.Add(lblNombre);
            crdFiltros.Controls.Add(txtNombre);
            crdFiltros.Controls.Add(lblApellido);
            crdFiltros.Controls.Add(txtApellido);
            crdFiltros.Controls.Add(lblLogin);
            crdFiltros.Controls.Add(txtNombreUsuario);
            crdFiltros.Controls.Add(lblModulo);
            crdFiltros.Controls.Add(cbxModulo);
            crdFiltros.Controls.Add(lblEvento);
            crdFiltros.Controls.Add(cbxEvento);
            crdFiltros.Controls.Add(lblCriticidad);
            crdFiltros.Controls.Add(cbxCriticidad);
            crdFiltros.Controls.Add(lblFechaInicio);
            crdFiltros.Controls.Add(dtpFechaInicio);
            crdFiltros.Controls.Add(lblFechaFin);
            crdFiltros.Controls.Add(dtpFechaFin);
            crdFiltros.Controls.Add(btnAplicar);
            crdFiltros.Controls.Add(btnLimpiar);
            crdFiltros.Dock = DockStyle.Fill;
            crdFiltros.Margin = new Padding(8);
            crdFiltros.Name = "crdFiltros";
            crdFiltros.Size = new Size(1060, 180);
            crdFiltros.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI Semibold", 12F);
            lblTitulo.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitulo.Location = new Point(20, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(56, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Filtros";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.ForeColor = Color.FromArgb(75, 85, 99);
            lblNombre.Location = new Point(20, 52);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(48, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.FromArgb(31, 41, 55);
            txtNombre.Location = new Point(20, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 27);
            txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Segoe UI", 10F);
            lblApellido.ForeColor = Color.FromArgb(75, 85, 99);
            lblApellido.Location = new Point(236, 52);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(64, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.ForeColor = Color.FromArgb(31, 41, 55);
            txtApellido.Location = new Point(236, 74);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(200, 27);
            txtApellido.TabIndex = 4;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Segoe UI", 10F);
            lblLogin.ForeColor = Color.FromArgb(75, 85, 99);
            lblLogin.Location = new Point(452, 52);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(56, 20);
            lblLogin.TabIndex = 5;
            lblLogin.Text = "Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario.ForeColor = Color.FromArgb(31, 41, 55);
            txtNombreUsuario.Location = new Point(452, 74);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(200, 27);
            txtNombreUsuario.TabIndex = 6;
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.BackColor = Color.Transparent;
            lblModulo.Font = new Font("Segoe UI", 10F);
            lblModulo.ForeColor = Color.FromArgb(75, 85, 99);
            lblModulo.Location = new Point(668, 52);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(48, 20);
            lblModulo.TabIndex = 7;
            lblModulo.Text = "Módulo";
            // 
            // cbxModulo
            // 
            cbxModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxModulo.ForeColor = Color.FromArgb(31, 41, 55);
            cbxModulo.FormattingEnabled = true;
            cbxModulo.Location = new Point(668, 74);
            cbxModulo.Name = "cbxModulo";
            cbxModulo.Size = new Size(200, 28);
            cbxModulo.TabIndex = 8;
            cbxModulo.SelectedIndexChanged += cbxModulo_SelectedIndexChanged;
            // 
            // lblEvento
            // 
            lblEvento.AutoSize = true;
            lblEvento.BackColor = Color.Transparent;
            lblEvento.Font = new Font("Segoe UI", 10F);
            lblEvento.ForeColor = Color.FromArgb(75, 85, 99);
            lblEvento.Location = new Point(20, 112);
            lblEvento.Name = "lblEvento";
            lblEvento.Size = new Size(48, 20);
            lblEvento.TabIndex = 9;
            lblEvento.Text = "Evento";
            // 
            // cbxEvento
            // 
            cbxEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEvento.ForeColor = Color.FromArgb(31, 41, 55);
            cbxEvento.FormattingEnabled = true;
            cbxEvento.Location = new Point(20, 134);
            cbxEvento.Name = "cbxEvento";
            cbxEvento.Size = new Size(200, 28);
            cbxEvento.TabIndex = 10;
            // 
            // lblCriticidad
            // 
            lblCriticidad.AutoSize = true;
            lblCriticidad.BackColor = Color.Transparent;
            lblCriticidad.Font = new Font("Segoe UI", 10F);
            lblCriticidad.ForeColor = Color.FromArgb(75, 85, 99);
            lblCriticidad.Location = new Point(236, 112);
            lblCriticidad.Name = "lblCriticidad";
            lblCriticidad.Size = new Size(80, 20);
            lblCriticidad.TabIndex = 11;
            lblCriticidad.Text = "Criticidad";
            // 
            // cbxCriticidad
            // 
            cbxCriticidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCriticidad.ForeColor = Color.FromArgb(31, 41, 55);
            cbxCriticidad.FormattingEnabled = true;
            cbxCriticidad.Location = new Point(236, 134);
            cbxCriticidad.Name = "cbxCriticidad";
            cbxCriticidad.Size = new Size(200, 28);
            cbxCriticidad.TabIndex = 12;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.BackColor = Color.Transparent;
            lblFechaInicio.Font = new Font("Segoe UI", 10F);
            lblFechaInicio.ForeColor = Color.FromArgb(75, 85, 99);
            lblFechaInicio.Location = new Point(452, 112);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(96, 20);
            lblFechaInicio.TabIndex = 13;
            lblFechaInicio.Text = "Fecha inicio";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(452, 134);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(200, 27);
            dtpFechaInicio.TabIndex = 14;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.BackColor = Color.Transparent;
            lblFechaFin.Font = new Font("Segoe UI", 10F);
            lblFechaFin.ForeColor = Color.FromArgb(75, 85, 99);
            lblFechaFin.Location = new Point(668, 112);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(72, 20);
            lblFechaFin.TabIndex = 15;
            lblFechaFin.Text = "Fecha fin";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(668, 134);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(200, 27);
            dtpFechaFin.TabIndex = 16;
            // 
            // btnAplicar
            // 
            btnAplicar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAplicar.Icono = "\uE71C";
            btnAplicar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAplicar.Location = new Point(880, 70);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(160, 36);
            btnAplicar.TabIndex = 17;
            btnAplicar.Text = "Aplicar";
            btnAplicar.Click += btnAplicar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Estilo = EstiloBoton.Secundario;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnLimpiar.Icono = "\uE894";
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.Location = new Point(880, 130);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(160, 36);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // crdEventos
            // 
            crdEventos.Controls.Add(grillaBitacora);
            crdEventos.Dock = DockStyle.Fill;
            crdEventos.Margin = new Padding(8);
            crdEventos.Name = "crdEventos";
            crdEventos.Size = new Size(1060, 348);
            crdEventos.TabIndex = 1;
            // 
            // grillaBitacora
            // 
            grillaBitacora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grillaBitacora.Location = new Point(20, 20);
            grillaBitacora.Name = "grillaBitacora";
            grillaBitacora.Size = new Size(1020, 308);
            grillaBitacora.TabIndex = 0;
            grillaBitacora.SelectionChanged += grillaBitacora_SelectionChanged;
            // 
            // pnlAcciones
            // 
            pnlAcciones.BackColor = Color.Transparent;
            pnlAcciones.Controls.Add(btnSalir);
            pnlAcciones.Controls.Add(btnImprimirBitacora);
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
            // btnImprimirBitacora
            // 
            btnImprimirBitacora.Estilo = EstiloBoton.Secundario;
            btnImprimirBitacora.Font = new Font("Segoe UI Semibold", 10.5F);
            btnImprimirBitacora.Icono = "\uE749";
            btnImprimirBitacora.Margin = new Padding(12, 0, 0, 0);
            btnImprimirBitacora.Name = "btnImprimirBitacora";
            btnImprimirBitacora.Size = new Size(190, 40);
            btnImprimirBitacora.TabIndex = 1;
            btnImprimirBitacora.Text = "Imprimir en PDF";
            btnImprimirBitacora.Click += btnImprimirBitacora_Click;
            // 
            // FrmBitacora
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBitacora";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bitácora";
            Load += FrmBitacora_Load;
            ((System.ComponentModel.ISupportInitialize)grillaBitacora).EndInit();
            pnlAcciones.ResumeLayout(false);
            pnlAcciones.PerformLayout();
            crdEventos.ResumeLayout(false);
            crdEventos.PerformLayout();
            crdFiltros.ResumeLayout(false);
            crdFiltros.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TarjetaSGB crdFiltros;
        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblLogin;
        private TextBox txtNombreUsuario;
        private Label lblModulo;
        private ComboBox cbxModulo;
        private Label lblEvento;
        private ComboBox cbxEvento;
        private Label lblCriticidad;
        private ComboBox cbxCriticidad;
        private Label lblFechaInicio;
        private DateTimePicker dtpFechaInicio;
        private Label lblFechaFin;
        private DateTimePicker dtpFechaFin;
        private BotonSGB btnAplicar;
        private BotonSGB btnLimpiar;
        private TarjetaSGB crdEventos;
        private GrillaSGB grillaBitacora;
        private FlowLayoutPanel pnlAcciones;
        private BotonSGB btnSalir;
        private BotonSGB btnImprimirBitacora;
    }
}
