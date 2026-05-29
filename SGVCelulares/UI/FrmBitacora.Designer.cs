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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();

            pnlTopbar = new Panel();
            lblTitulo = new Label();

            pnlContenido = new Panel();
            pnlFiltros = new Panel();
            pnlBotones = new Panel();

            grillaBitacora = new DataGridView();

            lblNombre = new Label();
            lblApellido = new Label();
            lblLogin = new Label();
            lblModulo = new Label();
            lblFechaInicio = new Label();
            lblEvento = new Label();
            lblFechaFin = new Label();
            lblCriticidad = new Label();

            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNombreUsuario = new TextBox();

            cbxModulo = new ComboBox();
            cbxEvento = new ComboBox();
            cbxCriticidad = new ComboBox();

            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();

            btnAplicar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();

            pnlTopbar.SuspendLayout();
            pnlContenido.SuspendLayout();
            pnlFiltros.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaBitacora).BeginInit();
            SuspendLayout();

            // 
            // pnlTopbar
            // 
            pnlTopbar.BackColor = Color.FromArgb(21, 32, 48);
            pnlTopbar.Controls.Add(lblTitulo);
            pnlTopbar.Dock = DockStyle.Top;
            pnlTopbar.Location = new Point(0, 0);
            pnlTopbar.Name = "pnlTopbar";
            pnlTopbar.Size = new Size(1200, 48);
            pnlTopbar.TabIndex = 0;

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(226, 232, 240);
            lblTitulo.Location = new Point(16, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(184, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BITÁCORA DE EVENTOS";

            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.FromArgb(30, 42, 58);
            pnlContenido.Controls.Add(pnlFiltros);
            pnlContenido.Controls.Add(grillaBitacora);
            pnlContenido.Controls.Add(pnlBotones);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(0, 48);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Padding = new Padding(24);
            pnlContenido.Size = new Size(1200, 652);
            pnlContenido.TabIndex = 1;

            // 
            // pnlFiltros
            // 
            pnlFiltros.BackColor = Color.FromArgb(25, 37, 53);
            pnlFiltros.Controls.Add(lblNombre);
            pnlFiltros.Controls.Add(txtNombre);

            pnlFiltros.Controls.Add(lblApellido);
            pnlFiltros.Controls.Add(txtApellido);

            pnlFiltros.Controls.Add(lblLogin);
            pnlFiltros.Controls.Add(txtNombreUsuario);

            pnlFiltros.Controls.Add(lblModulo);
            pnlFiltros.Controls.Add(cbxModulo);

            pnlFiltros.Controls.Add(lblFechaInicio);
            pnlFiltros.Controls.Add(dtpFechaInicio);

            pnlFiltros.Controls.Add(lblEvento);
            pnlFiltros.Controls.Add(cbxEvento);

            pnlFiltros.Controls.Add(lblFechaFin);
            pnlFiltros.Controls.Add(dtpFechaFin);

            pnlFiltros.Controls.Add(lblCriticidad);
            pnlFiltros.Controls.Add(cbxCriticidad);

            pnlFiltros.Location = new Point(24, 24);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Padding = new Padding(16);
            pnlFiltros.Size = new Size(930, 220);
            pnlFiltros.TabIndex = 0;

            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F);
            lblNombre.ForeColor = Color.FromArgb(148, 163, 184);
            lblNombre.Location = new Point(20, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.Text = "Nombre";

            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(21, 32, 48);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 9.5F);
            txtNombre.ForeColor = Color.FromArgb(226, 232, 240);
            txtNombre.Location = new Point(140, 17);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 24);

            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F);
            lblApellido.ForeColor = Color.FromArgb(148, 163, 184);
            lblApellido.Location = new Point(470, 20);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.Text = "Apellido";

            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(21, 32, 48);
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Segoe UI", 9.5F);
            txtApellido.ForeColor = Color.FromArgb(226, 232, 240);
            txtApellido.Location = new Point(600, 17);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(220, 24);

            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 9F);
            lblLogin.ForeColor = Color.FromArgb(148, 163, 184);
            lblLogin.Location = new Point(20, 70);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(39, 15);
            lblLogin.Text = "Login";

            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.FromArgb(21, 32, 48);
            txtNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario.Font = new Font("Segoe UI", 9.5F);
            txtNombreUsuario.ForeColor = Color.FromArgb(226, 232, 240);
            txtNombreUsuario.Location = new Point(140, 67);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(220, 24);

            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Segoe UI", 9F);
            lblFechaInicio.ForeColor = Color.FromArgb(148, 163, 184);
            lblFechaInicio.Location = new Point(470, 70);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(73, 15);
            lblFechaInicio.Text = "Fecha Inicio";

            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CalendarMonthBackground = Color.FromArgb(21, 32, 48);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(600, 67);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(220, 24);

            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Segoe UI", 9F);
            lblModulo.ForeColor = Color.FromArgb(148, 163, 184);
            lblModulo.Location = new Point(20, 120);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(52, 15);
            lblModulo.Text = "Módulo";

            // 
            // cbxModulo
            // 
            cbxModulo.BackColor = Color.FromArgb(21, 32, 48);
            cbxModulo.FlatStyle = FlatStyle.Flat;
            cbxModulo.ForeColor = Color.FromArgb(226, 232, 240);
            cbxModulo.FormattingEnabled = true;
            cbxModulo.Location = new Point(140, 117);
            cbxModulo.Name = "cbxModulo";
            cbxModulo.Size = new Size(220, 25);

            // 
            // lblEvento
            // 
            lblEvento.AutoSize = true;
            lblEvento.Font = new Font("Segoe UI", 9F);
            lblEvento.ForeColor = Color.FromArgb(148, 163, 184);
            lblEvento.Location = new Point(470, 120);
            lblEvento.Name = "lblEvento";
            lblEvento.Size = new Size(46, 15);
            lblEvento.Text = "Evento";

            // 
            // cbxEvento
            // 
            cbxEvento.BackColor = Color.FromArgb(21, 32, 48);
            cbxEvento.FlatStyle = FlatStyle.Flat;
            cbxEvento.ForeColor = Color.FromArgb(226, 232, 240);
            cbxEvento.FormattingEnabled = true;
            cbxEvento.Location = new Point(600, 117);
            cbxEvento.Name = "cbxEvento";
            cbxEvento.Size = new Size(220, 25);

            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI", 9F);
            lblFechaFin.ForeColor = Color.FromArgb(148, 163, 184);
            lblFechaFin.Location = new Point(20, 170);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(56, 15);
            lblFechaFin.Text = "Fecha Fin";

            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(140, 167);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(220, 24);

            // 
            // lblCriticidad
            // 
            lblCriticidad.AutoSize = true;
            lblCriticidad.Font = new Font("Segoe UI", 9F);
            lblCriticidad.ForeColor = Color.FromArgb(148, 163, 184);
            lblCriticidad.Location = new Point(470, 170);
            lblCriticidad.Name = "lblCriticidad";
            lblCriticidad.Size = new Size(65, 15);
            lblCriticidad.Text = "Criticidad";

            // 
            // cbxCriticidad
            // 
            cbxCriticidad.BackColor = Color.FromArgb(21, 32, 48);
            cbxCriticidad.FlatStyle = FlatStyle.Flat;
            cbxCriticidad.ForeColor = Color.FromArgb(226, 232, 240);
            cbxCriticidad.FormattingEnabled = true;
            cbxCriticidad.Location = new Point(600, 167);
            cbxCriticidad.Name = "cbxCriticidad";
            cbxCriticidad.Size = new Size(220, 25);

            // 
            // grillaBitacora
            // 
            grillaBitacora.AllowUserToAddRows = false;
            grillaBitacora.AllowUserToDeleteRows = false;
            grillaBitacora.BackgroundColor = Color.FromArgb(25, 37, 53);
            grillaBitacora.BorderStyle = BorderStyle.None;

            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(21, 32, 48);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;

            grillaBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grillaBitacora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 60, 82);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(226, 232, 240);

            grillaBitacora.DefaultCellStyle = dataGridViewCellStyle2;
            grillaBitacora.EnableHeadersVisualStyles = false;
            grillaBitacora.GridColor = Color.FromArgb(45, 60, 82);
            grillaBitacora.Location = new Point(24, 264);
            grillaBitacora.Name = "grillaBitacora";
            grillaBitacora.ReadOnly = true;
            grillaBitacora.RowHeadersVisible = false;
            grillaBitacora.Size = new Size(930, 340);
            grillaBitacora.TabIndex = 1;
            grillaBitacora.SelectionChanged += grillaBitacora_SelectionChanged;

            // 
            // pnlBotones
            // 
            pnlBotones.BackColor = Color.FromArgb(25, 37, 53);
            pnlBotones.Controls.Add(btnAplicar);
            pnlBotones.Controls.Add(btnLimpiar);
            pnlBotones.Controls.Add(btnSalir);
            pnlBotones.Location = new Point(972, 24);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Padding = new Padding(8);
            pnlBotones.Size = new Size(180, 580);
            pnlBotones.TabIndex = 2;

            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.FromArgb(45, 60, 82);
            btnAplicar.Cursor = Cursors.Hand;
            btnAplicar.FlatAppearance.BorderSize = 0;
            btnAplicar.FlatAppearance.MouseOverBackColor = Color.FromArgb(71, 85, 105);
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 9.5F);
            btnAplicar.ForeColor = Color.FromArgb(226, 232, 240);
            btnAplicar.Location = new Point(12, 12);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(156, 38);
            btnAplicar.TabIndex = 0;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;

            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(45, 60, 82);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(71, 85, 105);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.5F);
            btnLimpiar.ForeColor = Color.FromArgb(226, 232, 240);
            btnLimpiar.Location = new Point(12, 58);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(156, 38);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;

            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(45, 60, 82);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(71, 85, 105);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.5F);
            btnSalir.ForeColor = Color.FromArgb(226, 232, 240);
            btnSalir.Location = new Point(12, 530);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(156, 38);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            // 
            // FrmBitacora
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 42, 58);
            ClientSize = new Size(1200, 700);
            Controls.Add(pnlContenido);
            Controls.Add(pnlTopbar);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmBitacora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bitácora";
            Load += FrmBitacora_Load;

            pnlTopbar.ResumeLayout(false);
            pnlTopbar.PerformLayout();

            pnlContenido.ResumeLayout(false);

            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();

            pnlBotones.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)grillaBitacora).EndInit();

            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTopbar;
        private Label lblTitulo;

        private Panel pnlContenido;
        private Panel pnlFiltros;
        private Panel pnlBotones;

        private DataGridView grillaBitacora;

        private Label lblNombre;
        private Label lblApellido;
        private Label lblLogin;
        private Label lblModulo;
        private Label lblFechaInicio;
        private Label lblEvento;
        private Label lblFechaFin;
        private Label lblCriticidad;

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNombreUsuario;

        private ComboBox cbxModulo;
        private ComboBox cbxEvento;
        private ComboBox cbxCriticidad;

        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;

        private Button btnAplicar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}