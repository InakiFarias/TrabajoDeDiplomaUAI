using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormSocio
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
            lblTitulo = new Label();
            lblSeccionSocios = new Label();
            lblBuscarDni = new Label();
            txtBuscarDni = new TextBox();
            dgvSocios = new DataGridView();
            colSocNumero = new DataGridViewTextBoxColumn();
            colSocApellido = new DataGridViewTextBoxColumn();
            colSocNombre = new DataGridViewTextBoxColumn();
            colSocDni = new DataGridViewTextBoxColumn();
            colSocEstado = new DataGridViewTextBoxColumn();
            lblSeccionDatos = new Label();
            lblNumero = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            btnAlta = new Button();
            btnModificar = new Button();
            btnBaja = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F);
            lblTitulo.ForeColor = Color.FromArgb(226, 232, 240);
            lblTitulo.Location = new Point(16, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(119, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de socios";
            // 
            // lblSeccionSocios
            // 
            lblSeccionSocios.AutoSize = true;
            lblSeccionSocios.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionSocios.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionSocios.Location = new Point(16, 52);
            lblSeccionSocios.Name = "lblSeccionSocios";
            lblSeccionSocios.Size = new Size(42, 12);
            lblSeccionSocios.TabIndex = 1;
            lblSeccionSocios.Text = "SOCIOS";
            // 
            // lblBuscarDni
            // 
            lblBuscarDni.AutoSize = true;
            lblBuscarDni.ForeColor = Color.FromArgb(148, 163, 184);
            lblBuscarDni.Location = new Point(16, 70);
            lblBuscarDni.Name = "lblBuscarDni";
            lblBuscarDni.Size = new Size(182, 17);
            lblBuscarDni.TabIndex = 2;
            lblBuscarDni.Text = "DNI (búsqueda incremental)";
            // 
            // txtBuscarDni
            // 
            txtBuscarDni.BackColor = Color.FromArgb(21, 32, 48);
            txtBuscarDni.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarDni.ForeColor = Color.FromArgb(226, 232, 240);
            txtBuscarDni.Location = new Point(16, 90);
            txtBuscarDni.Name = "txtBuscarDni";
            txtBuscarDni.Size = new Size(300, 24);
            txtBuscarDni.TabIndex = 3;
            txtBuscarDni.TextChanged += txtBuscarDni_TextChanged;
            // 
            // dgvSocios
            // 
            dgvSocios.AllowUserToAddRows = false;
            dgvSocios.AllowUserToDeleteRows = false;
            dgvSocios.AllowUserToResizeRows = false;
            dgvSocios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSocios.BackgroundColor = Color.FromArgb(21, 32, 48);
            dgvSocios.BorderStyle = BorderStyle.None;
            dgvSocios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSocios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSocios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Columns.AddRange(new DataGridViewColumn[] { colSocNumero, colSocApellido, colSocNombre, colSocDni, colSocEstado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(21, 32, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 60, 82);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSocios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSocios.EnableHeadersVisualStyles = false;
            dgvSocios.GridColor = Color.FromArgb(45, 60, 82);
            dgvSocios.Location = new Point(16, 122);
            dgvSocios.MultiSelect = false;
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.RowHeadersVisible = false;
            dgvSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSocios.Size = new Size(717, 230);
            dgvSocios.TabIndex = 4;
            dgvSocios.SelectionChanged += dgvSocios_SelectionChanged;
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
            colSocApellido.FillWeight = 28F;
            colSocApellido.HeaderText = "Apellido";
            colSocApellido.Name = "colSocApellido";
            colSocApellido.ReadOnly = true;
            // 
            // colSocNombre
            // 
            colSocNombre.FillWeight = 28F;
            colSocNombre.HeaderText = "Nombre";
            colSocNombre.Name = "colSocNombre";
            colSocNombre.ReadOnly = true;
            // 
            // colSocDni
            // 
            colSocDni.FillWeight = 17F;
            colSocDni.HeaderText = "DNI";
            colSocDni.Name = "colSocDni";
            colSocDni.ReadOnly = true;
            // 
            // colSocEstado
            // 
            colSocEstado.FillWeight = 12F;
            colSocEstado.HeaderText = "Estado";
            colSocEstado.Name = "colSocEstado";
            colSocEstado.ReadOnly = true;
            // 
            // lblSeccionDatos
            // 
            lblSeccionDatos.AutoSize = true;
            lblSeccionDatos.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionDatos.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionDatos.Location = new Point(16, 366);
            lblSeccionDatos.Name = "lblSeccionDatos";
            lblSeccionDatos.Size = new Size(105, 12);
            lblSeccionDatos.TabIndex = 5;
            lblSeccionDatos.Text = "DATOS DEL SOCIO";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.ForeColor = Color.FromArgb(226, 232, 240);
            lblNumero.Location = new Point(16, 384);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(315, 17);
            lblNumero.TabIndex = 6;
            lblNumero.Text = "Número de socio: — (se asigna al dar de alta)";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.FromArgb(148, 163, 184);
            lblNombre.Location = new Point(16, 410);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(42, 17);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(21, 32, 48);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.FromArgb(226, 232, 240);
            txtNombre.Location = new Point(16, 430);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 24);
            txtNombre.TabIndex = 8;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = Color.FromArgb(148, 163, 184);
            lblApellido.Location = new Point(252, 410);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(56, 17);
            lblApellido.TabIndex = 9;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(21, 32, 48);
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.ForeColor = Color.FromArgb(226, 232, 240);
            txtApellido.Location = new Point(252, 430);
            txtApellido.MaxLength = 50;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(220, 24);
            txtApellido.TabIndex = 10;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.ForeColor = Color.FromArgb(148, 163, 184);
            lblDni.Location = new Point(488, 410);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(112, 17);
            lblDni.TabIndex = 11;
            lblDni.Text = "DNI (sin puntos)";
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.FromArgb(21, 32, 48);
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.ForeColor = Color.FromArgb(226, 232, 240);
            txtDni.Location = new Point(488, 430);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(150, 24);
            txtDni.TabIndex = 12;
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.FromArgb(37, 99, 235);
            btnAlta.Cursor = Cursors.Hand;
            btnAlta.FlatAppearance.BorderSize = 0;
            btnAlta.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnAlta.FlatStyle = FlatStyle.Flat;
            btnAlta.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAlta.ForeColor = Color.White;
            btnAlta.Location = new Point(16, 476);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(120, 34);
            btnAlta.TabIndex = 13;
            btnAlta.Text = "➕ Alta";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(45, 60, 82);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 75, 99);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.FromArgb(226, 232, 240);
            btnModificar.Location = new Point(142, 476);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 34);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "✏ Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.FromArgb(127, 29, 29);
            btnBaja.Cursor = Cursors.Hand;
            btnBaja.FlatAppearance.BorderSize = 0;
            btnBaja.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 27, 27);
            btnBaja.FlatStyle = FlatStyle.Flat;
            btnBaja.ForeColor = Color.FromArgb(226, 232, 240);
            btnBaja.Location = new Point(268, 476);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(120, 34);
            btnBaja.TabIndex = 15;
            btnBaja.Text = "✖ Baja";
            btnBaja.UseVisualStyleBackColor = false;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(45, 60, 82);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 75, 99);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.FromArgb(226, 232, 240);
            btnLimpiar.Location = new Point(394, 476);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 34);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.BackColor = Color.FromArgb(45, 60, 82);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 75, 99);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.FromArgb(226, 232, 240);
            btnCerrar.Location = new Point(633, 546);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 34);
            btnCerrar.TabIndex = 17;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 42, 58);
            ClientSize = new Size(749, 592);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBaja);
            Controls.Add(btnModificar);
            Controls.Add(btnAlta);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblNumero);
            Controls.Add(lblSeccionDatos);
            Controls.Add(dgvSocios);
            Controls.Add(txtBuscarDni);
            Controls.Add(lblBuscarDni);
            Controls.Add(lblSeccionSocios);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSocio";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de socios";
            Load += FormSocio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSeccionSocios;
        private Label lblBuscarDni;
        private TextBox txtBuscarDni;
        private DataGridView dgvSocios;
        private DataGridViewTextBoxColumn colSocNumero;
        private DataGridViewTextBoxColumn colSocApellido;
        private DataGridViewTextBoxColumn colSocNombre;
        private DataGridViewTextBoxColumn colSocDni;
        private DataGridViewTextBoxColumn colSocEstado;
        private Label lblSeccionDatos;
        private Label lblNumero;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDni;
        private TextBox txtDni;
        private Button btnAlta;
        private Button btnModificar;
        private Button btnBaja;
        private Button btnLimpiar;
        private Button btnCerrar;
    }
}
