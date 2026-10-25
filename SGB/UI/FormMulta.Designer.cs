using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormMulta
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSeccionSocio = new Label();
            lblDni = new Label();
            txtDni = new TextBox();
            btnSeleccionarSocio = new Button();
            lblSocio = new Label();
            dgvSocios = new DataGridView();
            colSocNumero = new DataGridViewTextBoxColumn();
            colSocApellido = new DataGridViewTextBoxColumn();
            colSocNombre = new DataGridViewTextBoxColumn();
            colSocDni = new DataGridViewTextBoxColumn();
            lblSeccionMultas = new Label();
            dgvMultas = new DataGridView();
            colMulNumero = new DataGridViewTextBoxColumn();
            colMulPrestamo = new DataGridViewTextBoxColumn();
            colMulFecha = new DataGridViewTextBoxColumn();
            colMulDias = new DataGridViewTextBoxColumn();
            colMulMonto = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            btnNoAbona = new Button();
            btnConfirmarCobro = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMultas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F);
            lblTitulo.ForeColor = Color.FromArgb(226, 232, 240);
            lblTitulo.Location = new Point(16, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(91, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cobrar multas";
            // 
            // lblSeccionSocio
            // 
            lblSeccionSocio.AutoSize = true;
            lblSeccionSocio.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionSocio.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionSocio.Location = new Point(16, 52);
            lblSeccionSocio.Name = "lblSeccionSocio";
            lblSeccionSocio.Size = new Size(35, 12);
            lblSeccionSocio.TabIndex = 1;
            lblSeccionSocio.Text = "SOCIO";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.ForeColor = Color.FromArgb(148, 163, 184);
            lblDni.Location = new Point(16, 70);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(252, 17);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI del socio (búsqueda incremental)";
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.FromArgb(21, 32, 48);
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.ForeColor = Color.FromArgb(226, 232, 240);
            txtDni.Location = new Point(16, 90);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(300, 24);
            txtDni.TabIndex = 3;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // btnSeleccionarSocio
            // 
            btnSeleccionarSocio.BackColor = Color.FromArgb(45, 60, 82);
            btnSeleccionarSocio.Cursor = Cursors.Hand;
            btnSeleccionarSocio.FlatAppearance.BorderSize = 0;
            btnSeleccionarSocio.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 75, 99);
            btnSeleccionarSocio.FlatStyle = FlatStyle.Flat;
            btnSeleccionarSocio.ForeColor = Color.FromArgb(226, 232, 240);
            btnSeleccionarSocio.Location = new Point(324, 89);
            btnSeleccionarSocio.Name = "btnSeleccionarSocio";
            btnSeleccionarSocio.Size = new Size(150, 27);
            btnSeleccionarSocio.TabIndex = 4;
            btnSeleccionarSocio.Text = "✔ Seleccionar socio";
            btnSeleccionarSocio.UseVisualStyleBackColor = false;
            btnSeleccionarSocio.Click += btnSeleccionarSocio_Click;
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.ForeColor = Color.FromArgb(226, 232, 240);
            lblSocio.Location = new Point(490, 94);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(56, 17);
            lblSocio.TabIndex = 5;
            lblSocio.Text = "Socio: —";
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
            dgvSocios.Columns.AddRange(new DataGridViewColumn[] { colSocNumero, colSocApellido, colSocNombre, colSocDni });
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
            dgvSocios.Size = new Size(717, 110);
            dgvSocios.TabIndex = 6;
            dgvSocios.CellDoubleClick += dgvSocios_CellDoubleClick;
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
            // lblSeccionMultas
            // 
            lblSeccionMultas.AutoSize = true;
            lblSeccionMultas.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionMultas.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionMultas.Location = new Point(16, 246);
            lblSeccionMultas.Name = "lblSeccionMultas";
            lblSeccionMultas.Size = new Size(175, 12);
            lblSeccionMultas.TabIndex = 7;
            lblSeccionMultas.Text = "MULTAS PENDIENTES DE PAGO";
            // 
            // dgvMultas
            // 
            dgvMultas.AllowUserToAddRows = false;
            dgvMultas.AllowUserToDeleteRows = false;
            dgvMultas.AllowUserToResizeRows = false;
            dgvMultas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvMultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMultas.BackgroundColor = Color.FromArgb(21, 32, 48);
            dgvMultas.BorderStyle = BorderStyle.None;
            dgvMultas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMultas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvMultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvMultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMultas.Columns.AddRange(new DataGridViewColumn[] { colMulNumero, colMulPrestamo, colMulFecha, colMulDias, colMulMonto });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(21, 32, 48);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(45, 60, 82);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvMultas.DefaultCellStyle = dataGridViewCellStyle4;
            dgvMultas.EnableHeadersVisualStyles = false;
            dgvMultas.GridColor = Color.FromArgb(45, 60, 82);
            dgvMultas.Location = new Point(16, 264);
            dgvMultas.MultiSelect = false;
            dgvMultas.Name = "dgvMultas";
            dgvMultas.ReadOnly = true;
            dgvMultas.RowHeadersVisible = false;
            dgvMultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMultas.Size = new Size(717, 150);
            dgvMultas.TabIndex = 8;
            // 
            // colMulNumero
            // 
            colMulNumero.FillWeight = 15F;
            colMulNumero.HeaderText = "N° multa";
            colMulNumero.Name = "colMulNumero";
            colMulNumero.ReadOnly = true;
            // 
            // colMulPrestamo
            // 
            colMulPrestamo.FillWeight = 15F;
            colMulPrestamo.HeaderText = "Préstamo";
            colMulPrestamo.Name = "colMulPrestamo";
            colMulPrestamo.ReadOnly = true;
            // 
            // colMulFecha
            // 
            colMulFecha.FillWeight = 25F;
            colMulFecha.HeaderText = "Fecha de generación";
            colMulFecha.Name = "colMulFecha";
            colMulFecha.ReadOnly = true;
            // 
            // colMulDias
            // 
            colMulDias.FillWeight = 20F;
            colMulDias.HeaderText = "Días de atraso";
            colMulDias.Name = "colMulDias";
            colMulDias.ReadOnly = true;
            // 
            // colMulMonto
            // 
            colMulMonto.FillWeight = 25F;
            colMulMonto.HeaderText = "Monto ($)";
            colMulMonto.Name = "colMulMonto";
            colMulMonto.ReadOnly = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = false;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(226, 232, 240);
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            lblTotal.Location = new Point(333, 422);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(400, 24);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total adeudado: $ 0,00";
            // 
            // btnNoAbona
            // 
            btnNoAbona.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNoAbona.BackColor = Color.FromArgb(45, 60, 82);
            btnNoAbona.Cursor = Cursors.Hand;
            btnNoAbona.FlatAppearance.BorderSize = 0;
            btnNoAbona.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 75, 99);
            btnNoAbona.FlatStyle = FlatStyle.Flat;
            btnNoAbona.ForeColor = Color.FromArgb(226, 232, 240);
            btnNoAbona.Location = new Point(467, 470);
            btnNoAbona.Name = "btnNoAbona";
            btnNoAbona.Size = new Size(130, 34);
            btnNoAbona.TabIndex = 10;
            btnNoAbona.Text = "El socio no abona";
            btnNoAbona.UseVisualStyleBackColor = false;
            btnNoAbona.Click += btnNoAbona_Click;
            // 
            // btnConfirmarCobro
            // 
            btnConfirmarCobro.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmarCobro.BackColor = Color.FromArgb(37, 99, 235);
            btnConfirmarCobro.Cursor = Cursors.Hand;
            btnConfirmarCobro.FlatAppearance.BorderSize = 0;
            btnConfirmarCobro.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnConfirmarCobro.FlatStyle = FlatStyle.Flat;
            btnConfirmarCobro.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnConfirmarCobro.ForeColor = Color.White;
            btnConfirmarCobro.Location = new Point(603, 470);
            btnConfirmarCobro.Name = "btnConfirmarCobro";
            btnConfirmarCobro.Size = new Size(130, 34);
            btnConfirmarCobro.TabIndex = 11;
            btnConfirmarCobro.Text = "Confirmar cobro";
            btnConfirmarCobro.UseVisualStyleBackColor = false;
            btnConfirmarCobro.Click += btnConfirmarCobro_Click;
            // 
            // FormMulta
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 42, 58);
            ClientSize = new Size(749, 520);
            Controls.Add(btnConfirmarCobro);
            Controls.Add(btnNoAbona);
            Controls.Add(lblTotal);
            Controls.Add(dgvMultas);
            Controls.Add(lblSeccionMultas);
            Controls.Add(dgvSocios);
            Controls.Add(lblSocio);
            Controls.Add(btnSeleccionarSocio);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(lblSeccionSocio);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMulta";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cobrar multas";
            Load += FormMulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMultas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSeccionSocio;
        private Label lblDni;
        private TextBox txtDni;
        private Button btnSeleccionarSocio;
        private Label lblSocio;
        private DataGridView dgvSocios;
        private DataGridViewTextBoxColumn colSocNumero;
        private DataGridViewTextBoxColumn colSocApellido;
        private DataGridViewTextBoxColumn colSocNombre;
        private DataGridViewTextBoxColumn colSocDni;
        private Label lblSeccionMultas;
        private DataGridView dgvMultas;
        private DataGridViewTextBoxColumn colMulNumero;
        private DataGridViewTextBoxColumn colMulPrestamo;
        private DataGridViewTextBoxColumn colMulFecha;
        private DataGridViewTextBoxColumn colMulDias;
        private DataGridViewTextBoxColumn colMulMonto;
        private Label lblTotal;
        private Button btnNoAbona;
        private Button btnConfirmarCobro;
    }
}
