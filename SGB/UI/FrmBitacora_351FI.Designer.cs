using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FrmBitacora_351FI
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
            crdFiltros_351FI = new TarjetaSGB_351FI();
            lblTitulo_351FI = new Label();
            lblNombre_351FI = new Label();
            txtNombre_351FI = new TextBox();
            lblApellido_351FI = new Label();
            txtApellido_351FI = new TextBox();
            lblLogin_351FI = new Label();
            txtNombreUsuario_351FI = new TextBox();
            lblModulo_351FI = new Label();
            cbxModulo_351FI = new ComboBox();
            lblEvento_351FI = new Label();
            cbxEvento_351FI = new ComboBox();
            lblCriticidad_351FI = new Label();
            cbxCriticidad_351FI = new ComboBox();
            lblFechaInicio_351FI = new Label();
            dtpFechaInicio_351FI = new DateTimePicker();
            lblFechaFin_351FI = new Label();
            dtpFechaFin_351FI = new DateTimePicker();
            btnAplicar_351FI = new BotonSGB_351FI();
            btnLimpiar_351FI = new BotonSGB_351FI();
            crdEventos_351FI = new TarjetaSGB_351FI();
            grillaBitacora_351FI = new GrillaSGB_351FI();
            pnlAcciones_351FI = new FlowLayoutPanel();
            btnSalir_351FI = new BotonSGB_351FI();
            btnImprimirBitacora_351FI = new BotonSGB_351FI();
            tlpPrincipal_351FI.SuspendLayout();
            crdFiltros_351FI.SuspendLayout();
            crdEventos_351FI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaBitacora_351FI).BeginInit();
            pnlAcciones_351FI.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal_351FI.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal_351FI.ColumnCount = 1;
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0F));
            tlpPrincipal_351FI.Controls.Add(crdFiltros_351FI, 0, 0);
            tlpPrincipal_351FI.Controls.Add(crdEventos_351FI, 0, 1);
            tlpPrincipal_351FI.Controls.Add(pnlAcciones_351FI, 0, 2);
            tlpPrincipal_351FI.Dock = DockStyle.Fill;
            tlpPrincipal_351FI.Name = "tlpPrincipal_351FI";
            tlpPrincipal_351FI.Padding = new Padding(12);
            tlpPrincipal_351FI.RowCount = 3;
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Absolute, 196.0F));
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Absolute, 56.0F));
            tlpPrincipal_351FI.Size = new Size(1100, 640);
            tlpPrincipal_351FI.TabIndex = 0;
            // 
            // crdFiltros
            // 
            crdFiltros_351FI.Controls.Add(lblTitulo_351FI);
            crdFiltros_351FI.Controls.Add(lblNombre_351FI);
            crdFiltros_351FI.Controls.Add(txtNombre_351FI);
            crdFiltros_351FI.Controls.Add(lblApellido_351FI);
            crdFiltros_351FI.Controls.Add(txtApellido_351FI);
            crdFiltros_351FI.Controls.Add(lblLogin_351FI);
            crdFiltros_351FI.Controls.Add(txtNombreUsuario_351FI);
            crdFiltros_351FI.Controls.Add(lblModulo_351FI);
            crdFiltros_351FI.Controls.Add(cbxModulo_351FI);
            crdFiltros_351FI.Controls.Add(lblEvento_351FI);
            crdFiltros_351FI.Controls.Add(cbxEvento_351FI);
            crdFiltros_351FI.Controls.Add(lblCriticidad_351FI);
            crdFiltros_351FI.Controls.Add(cbxCriticidad_351FI);
            crdFiltros_351FI.Controls.Add(lblFechaInicio_351FI);
            crdFiltros_351FI.Controls.Add(dtpFechaInicio_351FI);
            crdFiltros_351FI.Controls.Add(lblFechaFin_351FI);
            crdFiltros_351FI.Controls.Add(dtpFechaFin_351FI);
            crdFiltros_351FI.Controls.Add(btnAplicar_351FI);
            crdFiltros_351FI.Controls.Add(btnLimpiar_351FI);
            crdFiltros_351FI.Dock = DockStyle.Fill;
            crdFiltros_351FI.Margin = new Padding(8);
            crdFiltros_351FI.Name = "crdFiltros_351FI";
            crdFiltros_351FI.Size = new Size(1060, 180);
            crdFiltros_351FI.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo_351FI.AutoSize = true;
            lblTitulo_351FI.BackColor = Color.Transparent;
            lblTitulo_351FI.Font = new Font("Segoe UI Semibold", 12F);
            lblTitulo_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitulo_351FI.Location = new Point(20, 16);
            lblTitulo_351FI.Name = "lblTitulo_351FI";
            lblTitulo_351FI.Size = new Size(56, 20);
            lblTitulo_351FI.TabIndex = 0;
            lblTitulo_351FI.Text = "Filtros";
            // 
            // lblNombre
            // 
            lblNombre_351FI.AutoSize = true;
            lblNombre_351FI.BackColor = Color.Transparent;
            lblNombre_351FI.Font = new Font("Segoe UI", 10F);
            lblNombre_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblNombre_351FI.Location = new Point(20, 52);
            lblNombre_351FI.Name = "lblNombre_351FI";
            lblNombre_351FI.Size = new Size(48, 20);
            lblNombre_351FI.TabIndex = 1;
            lblNombre_351FI.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtNombre_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtNombre_351FI.Location = new Point(20, 74);
            txtNombre_351FI.Name = "txtNombre_351FI";
            txtNombre_351FI.Size = new Size(200, 27);
            txtNombre_351FI.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido_351FI.AutoSize = true;
            lblApellido_351FI.BackColor = Color.Transparent;
            lblApellido_351FI.Font = new Font("Segoe UI", 10F);
            lblApellido_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblApellido_351FI.Location = new Point(236, 52);
            lblApellido_351FI.Name = "lblApellido_351FI";
            lblApellido_351FI.Size = new Size(64, 20);
            lblApellido_351FI.TabIndex = 3;
            lblApellido_351FI.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtApellido_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtApellido_351FI.Location = new Point(236, 74);
            txtApellido_351FI.Name = "txtApellido_351FI";
            txtApellido_351FI.Size = new Size(200, 27);
            txtApellido_351FI.TabIndex = 4;
            // 
            // lblLogin
            // 
            lblLogin_351FI.AutoSize = true;
            lblLogin_351FI.BackColor = Color.Transparent;
            lblLogin_351FI.Font = new Font("Segoe UI", 10F);
            lblLogin_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblLogin_351FI.Location = new Point(452, 52);
            lblLogin_351FI.Name = "lblLogin_351FI";
            lblLogin_351FI.Size = new Size(56, 20);
            lblLogin_351FI.TabIndex = 5;
            lblLogin_351FI.Text = "Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtNombreUsuario_351FI.Location = new Point(452, 74);
            txtNombreUsuario_351FI.Name = "txtNombreUsuario_351FI";
            txtNombreUsuario_351FI.Size = new Size(200, 27);
            txtNombreUsuario_351FI.TabIndex = 6;
            // 
            // lblModulo
            // 
            lblModulo_351FI.AutoSize = true;
            lblModulo_351FI.BackColor = Color.Transparent;
            lblModulo_351FI.Font = new Font("Segoe UI", 10F);
            lblModulo_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblModulo_351FI.Location = new Point(668, 52);
            lblModulo_351FI.Name = "lblModulo_351FI";
            lblModulo_351FI.Size = new Size(48, 20);
            lblModulo_351FI.TabIndex = 7;
            lblModulo_351FI.Text = "Módulo";
            // 
            // cbxModulo
            // 
            cbxModulo_351FI.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxModulo_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            cbxModulo_351FI.FormattingEnabled = true;
            cbxModulo_351FI.Location = new Point(668, 74);
            cbxModulo_351FI.Name = "cbxModulo_351FI";
            cbxModulo_351FI.Size = new Size(200, 28);
            cbxModulo_351FI.TabIndex = 8;
            cbxModulo_351FI.SelectedIndexChanged += cbxModulo_351FI_SelectedIndexChanged;
            // 
            // lblEvento
            // 
            lblEvento_351FI.AutoSize = true;
            lblEvento_351FI.BackColor = Color.Transparent;
            lblEvento_351FI.Font = new Font("Segoe UI", 10F);
            lblEvento_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblEvento_351FI.Location = new Point(20, 112);
            lblEvento_351FI.Name = "lblEvento_351FI";
            lblEvento_351FI.Size = new Size(48, 20);
            lblEvento_351FI.TabIndex = 9;
            lblEvento_351FI.Text = "Evento";
            // 
            // cbxEvento
            // 
            cbxEvento_351FI.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEvento_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            cbxEvento_351FI.FormattingEnabled = true;
            cbxEvento_351FI.Location = new Point(20, 134);
            cbxEvento_351FI.Name = "cbxEvento_351FI";
            cbxEvento_351FI.Size = new Size(200, 28);
            cbxEvento_351FI.TabIndex = 10;
            // 
            // lblCriticidad
            // 
            lblCriticidad_351FI.AutoSize = true;
            lblCriticidad_351FI.BackColor = Color.Transparent;
            lblCriticidad_351FI.Font = new Font("Segoe UI", 10F);
            lblCriticidad_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblCriticidad_351FI.Location = new Point(236, 112);
            lblCriticidad_351FI.Name = "lblCriticidad_351FI";
            lblCriticidad_351FI.Size = new Size(80, 20);
            lblCriticidad_351FI.TabIndex = 11;
            lblCriticidad_351FI.Text = "Criticidad";
            // 
            // cbxCriticidad
            // 
            cbxCriticidad_351FI.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCriticidad_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            cbxCriticidad_351FI.FormattingEnabled = true;
            cbxCriticidad_351FI.Location = new Point(236, 134);
            cbxCriticidad_351FI.Name = "cbxCriticidad_351FI";
            cbxCriticidad_351FI.Size = new Size(200, 28);
            cbxCriticidad_351FI.TabIndex = 12;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio_351FI.AutoSize = true;
            lblFechaInicio_351FI.BackColor = Color.Transparent;
            lblFechaInicio_351FI.Font = new Font("Segoe UI", 10F);
            lblFechaInicio_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblFechaInicio_351FI.Location = new Point(452, 112);
            lblFechaInicio_351FI.Name = "lblFechaInicio_351FI";
            lblFechaInicio_351FI.Size = new Size(96, 20);
            lblFechaInicio_351FI.TabIndex = 13;
            lblFechaInicio_351FI.Text = "Fecha inicio";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio_351FI.Format = DateTimePickerFormat.Short;
            dtpFechaInicio_351FI.Location = new Point(452, 134);
            dtpFechaInicio_351FI.Name = "dtpFechaInicio_351FI";
            dtpFechaInicio_351FI.Size = new Size(200, 27);
            dtpFechaInicio_351FI.TabIndex = 14;
            // 
            // lblFechaFin
            // 
            lblFechaFin_351FI.AutoSize = true;
            lblFechaFin_351FI.BackColor = Color.Transparent;
            lblFechaFin_351FI.Font = new Font("Segoe UI", 10F);
            lblFechaFin_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            lblFechaFin_351FI.Location = new Point(668, 112);
            lblFechaFin_351FI.Name = "lblFechaFin_351FI";
            lblFechaFin_351FI.Size = new Size(72, 20);
            lblFechaFin_351FI.TabIndex = 15;
            lblFechaFin_351FI.Text = "Fecha fin";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin_351FI.Format = DateTimePickerFormat.Short;
            dtpFechaFin_351FI.Location = new Point(668, 134);
            dtpFechaFin_351FI.Name = "dtpFechaFin_351FI";
            dtpFechaFin_351FI.Size = new Size(200, 27);
            dtpFechaFin_351FI.TabIndex = 16;
            // 
            // btnAplicar
            // 
            btnAplicar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAplicar_351FI.Icono_351FI = "\uE71C";
            btnAplicar_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAplicar_351FI.Location = new Point(880, 70);
            btnAplicar_351FI.Name = "btnAplicar_351FI";
            btnAplicar_351FI.Size = new Size(160, 36);
            btnAplicar_351FI.TabIndex = 17;
            btnAplicar_351FI.Text = "Aplicar";
            btnAplicar_351FI.Click += btnAplicar_351FI_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnLimpiar_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnLimpiar_351FI.Icono_351FI = "\uE894";
            btnLimpiar_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar_351FI.Location = new Point(880, 130);
            btnLimpiar_351FI.Name = "btnLimpiar_351FI";
            btnLimpiar_351FI.Size = new Size(160, 36);
            btnLimpiar_351FI.TabIndex = 18;
            btnLimpiar_351FI.Text = "Limpiar";
            btnLimpiar_351FI.Click += btnLimpiar_351FI_Click;
            // 
            // crdEventos
            // 
            crdEventos_351FI.Controls.Add(grillaBitacora_351FI);
            crdEventos_351FI.Dock = DockStyle.Fill;
            crdEventos_351FI.Margin = new Padding(8);
            crdEventos_351FI.Name = "crdEventos_351FI";
            crdEventos_351FI.Size = new Size(1060, 348);
            crdEventos_351FI.TabIndex = 1;
            // 
            // grillaBitacora
            // 
            grillaBitacora_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grillaBitacora_351FI.Location = new Point(20, 20);
            grillaBitacora_351FI.Name = "grillaBitacora_351FI";
            grillaBitacora_351FI.Size = new Size(1020, 308);
            grillaBitacora_351FI.TabIndex = 0;
            grillaBitacora_351FI.SelectionChanged += grillaBitacora_351FI_SelectionChanged;
            // 
            // pnlAcciones
            // 
            pnlAcciones_351FI.BackColor = Color.Transparent;
            pnlAcciones_351FI.Controls.Add(btnSalir_351FI);
            pnlAcciones_351FI.Controls.Add(btnImprimirBitacora_351FI);
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
            // btnImprimirBitacora
            // 
            btnImprimirBitacora_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnImprimirBitacora_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnImprimirBitacora_351FI.Icono_351FI = "\uE749";
            btnImprimirBitacora_351FI.Margin = new Padding(12, 0, 0, 0);
            btnImprimirBitacora_351FI.Name = "btnImprimirBitacora_351FI";
            btnImprimirBitacora_351FI.Size = new Size(190, 40);
            btnImprimirBitacora_351FI.TabIndex = 1;
            btnImprimirBitacora_351FI.Text = "Imprimir en PDF";
            btnImprimirBitacora_351FI.Click += btnImprimirBitacora_351FI_Click;
            // 
            // FrmBitacora
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal_351FI);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBitacora_351FI";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bitácora";
            Load += FrmBitacora_351FI_Load;
            ((System.ComponentModel.ISupportInitialize)grillaBitacora_351FI).EndInit();
            pnlAcciones_351FI.ResumeLayout(false);
            pnlAcciones_351FI.PerformLayout();
            crdEventos_351FI.ResumeLayout(false);
            crdEventos_351FI.PerformLayout();
            crdFiltros_351FI.ResumeLayout(false);
            crdFiltros_351FI.PerformLayout();
            tlpPrincipal_351FI.ResumeLayout(false);
            tlpPrincipal_351FI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal_351FI;
        private TarjetaSGB_351FI crdFiltros_351FI;
        private Label lblTitulo_351FI;
        private Label lblNombre_351FI;
        private TextBox txtNombre_351FI;
        private Label lblApellido_351FI;
        private TextBox txtApellido_351FI;
        private Label lblLogin_351FI;
        private TextBox txtNombreUsuario_351FI;
        private Label lblModulo_351FI;
        private ComboBox cbxModulo_351FI;
        private Label lblEvento_351FI;
        private ComboBox cbxEvento_351FI;
        private Label lblCriticidad_351FI;
        private ComboBox cbxCriticidad_351FI;
        private Label lblFechaInicio_351FI;
        private DateTimePicker dtpFechaInicio_351FI;
        private Label lblFechaFin_351FI;
        private DateTimePicker dtpFechaFin_351FI;
        private BotonSGB_351FI btnAplicar_351FI;
        private BotonSGB_351FI btnLimpiar_351FI;
        private TarjetaSGB_351FI crdEventos_351FI;
        private GrillaSGB_351FI grillaBitacora_351FI;
        private FlowLayoutPanel pnlAcciones_351FI;
        private BotonSGB_351FI btnSalir_351FI;
        private BotonSGB_351FI btnImprimirBitacora_351FI;
    }
}
