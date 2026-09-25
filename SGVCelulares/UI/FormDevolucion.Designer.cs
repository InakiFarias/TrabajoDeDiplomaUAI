using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormDevolucion
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
            lblSeccionPrestamo = new Label();
            lblNumeroPrestamo = new Label();
            txtNumeroPrestamo = new TextBox();
            btnBuscarPrestamo = new Button();
            lblSocio = new Label();
            lblFechaPrestamo = new Label();
            lblFechaDevolucionPrevista = new Label();
            lblSeccionEjemplares = new Label();
            dgvEjemplares = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colTitulo = new DataGridViewTextBoxColumn();
            colAutor = new DataGridViewTextBoxColumn();
            chkRecepcionCompleta = new CheckBox();
            lblSeccionResumen = new Label();
            lblFechaDevolucion = new Label();
            lblDiasAtraso = new Label();
            lblMulta = new Label();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F);
            lblTitulo.ForeColor = Color.FromArgb(226, 232, 240);
            lblTitulo.Location = new Point(16, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(182, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar devolución";
            // 
            // lblSeccionPrestamo
            // 
            lblSeccionPrestamo.AutoSize = true;
            lblSeccionPrestamo.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionPrestamo.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionPrestamo.Location = new Point(16, 52);
            lblSeccionPrestamo.Name = "lblSeccionPrestamo";
            lblSeccionPrestamo.Size = new Size(59, 12);
            lblSeccionPrestamo.TabIndex = 1;
            lblSeccionPrestamo.Text = "PRÉSTAMO";
            // 
            // lblNumeroPrestamo
            // 
            lblNumeroPrestamo.AutoSize = true;
            lblNumeroPrestamo.ForeColor = Color.FromArgb(148, 163, 184);
            lblNumeroPrestamo.Location = new Point(16, 70);
            lblNumeroPrestamo.Name = "lblNumeroPrestamo";
            lblNumeroPrestamo.Size = new Size(129, 17);
            lblNumeroPrestamo.TabIndex = 2;
            lblNumeroPrestamo.Text = "Número de préstamo";
            // 
            // txtNumeroPrestamo
            // 
            txtNumeroPrestamo.BackColor = Color.FromArgb(21, 32, 48);
            txtNumeroPrestamo.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroPrestamo.ForeColor = Color.FromArgb(226, 232, 240);
            txtNumeroPrestamo.Location = new Point(16, 90);
            txtNumeroPrestamo.Name = "txtNumeroPrestamo";
            txtNumeroPrestamo.Size = new Size(150, 24);
            txtNumeroPrestamo.TabIndex = 3;
            // 
            // btnBuscarPrestamo
            // 
            btnBuscarPrestamo.BackColor = Color.FromArgb(45, 60, 82);
            btnBuscarPrestamo.Cursor = Cursors.Hand;
            btnBuscarPrestamo.FlatAppearance.BorderSize = 0;
            btnBuscarPrestamo.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 75, 99);
            btnBuscarPrestamo.FlatStyle = FlatStyle.Flat;
            btnBuscarPrestamo.ForeColor = Color.FromArgb(226, 232, 240);
            btnBuscarPrestamo.Location = new Point(174, 89);
            btnBuscarPrestamo.Name = "btnBuscarPrestamo";
            btnBuscarPrestamo.Size = new Size(90, 27);
            btnBuscarPrestamo.TabIndex = 4;
            btnBuscarPrestamo.Text = "🔍 Buscar";
            btnBuscarPrestamo.UseVisualStyleBackColor = false;
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.ForeColor = Color.FromArgb(226, 232, 240);
            lblSocio.Location = new Point(284, 72);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(58, 17);
            lblSocio.TabIndex = 5;
            lblSocio.Text = "Socio: —";
            // 
            // lblFechaPrestamo
            // 
            lblFechaPrestamo.AutoSize = true;
            lblFechaPrestamo.ForeColor = Color.FromArgb(148, 163, 184);
            lblFechaPrestamo.Location = new Point(284, 92);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(139, 17);
            lblFechaPrestamo.TabIndex = 6;
            lblFechaPrestamo.Text = "Fecha del préstamo: —";
            // 
            // lblFechaDevolucionPrevista
            // 
            lblFechaDevolucionPrevista.AutoSize = true;
            lblFechaDevolucionPrevista.ForeColor = Color.FromArgb(148, 163, 184);
            lblFechaDevolucionPrevista.Location = new Point(284, 112);
            lblFechaDevolucionPrevista.Name = "lblFechaDevolucionPrevista";
            lblFechaDevolucionPrevista.Size = new Size(189, 17);
            lblFechaDevolucionPrevista.TabIndex = 7;
            lblFechaDevolucionPrevista.Text = "Fecha de devolución prevista: —";
            // 
            // lblSeccionEjemplares
            // 
            lblSeccionEjemplares.AutoSize = true;
            lblSeccionEjemplares.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionEjemplares.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionEjemplares.Location = new Point(16, 148);
            lblSeccionEjemplares.Name = "lblSeccionEjemplares";
            lblSeccionEjemplares.Size = new Size(129, 12);
            lblSeccionEjemplares.TabIndex = 8;
            lblSeccionEjemplares.Text = "EJEMPLARES PRESTADOS";
            // 
            // dgvEjemplares
            // 
            dgvEjemplares.AllowUserToAddRows = false;
            dgvEjemplares.AllowUserToDeleteRows = false;
            dgvEjemplares.AllowUserToResizeRows = false;
            dgvEjemplares.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvEjemplares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEjemplares.BackgroundColor = Color.FromArgb(21, 32, 48);
            dgvEjemplares.BorderStyle = BorderStyle.None;
            dgvEjemplares.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEjemplares.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEjemplares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEjemplares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEjemplares.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colTitulo, colAutor });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(21, 32, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 60, 82);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEjemplares.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEjemplares.EnableHeadersVisualStyles = false;
            dgvEjemplares.GridColor = Color.FromArgb(45, 60, 82);
            dgvEjemplares.Location = new Point(16, 166);
            dgvEjemplares.MultiSelect = false;
            dgvEjemplares.Name = "dgvEjemplares";
            dgvEjemplares.ReadOnly = true;
            dgvEjemplares.RowHeadersVisible = false;
            dgvEjemplares.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEjemplares.Size = new Size(717, 180);
            dgvEjemplares.TabIndex = 9;
            // 
            // colCodigo
            // 
            colCodigo.FillWeight = 20F;
            colCodigo.HeaderText = "Código";
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colTitulo
            // 
            colTitulo.FillWeight = 50F;
            colTitulo.HeaderText = "Título";
            colTitulo.Name = "colTitulo";
            colTitulo.ReadOnly = true;
            // 
            // colAutor
            // 
            colAutor.FillWeight = 30F;
            colAutor.HeaderText = "Autor";
            colAutor.Name = "colAutor";
            colAutor.ReadOnly = true;
            // 
            // chkRecepcionCompleta
            // 
            chkRecepcionCompleta.AutoSize = true;
            chkRecepcionCompleta.ForeColor = Color.FromArgb(226, 232, 240);
            chkRecepcionCompleta.Location = new Point(16, 356);
            chkRecepcionCompleta.Name = "chkRecepcionCompleta";
            chkRecepcionCompleta.Size = new Size(279, 21);
            chkRecepcionCompleta.TabIndex = 10;
            chkRecepcionCompleta.Text = "Recibí todos los ejemplares del préstamo";
            chkRecepcionCompleta.UseVisualStyleBackColor = true;
            // 
            // lblSeccionResumen
            // 
            lblSeccionResumen.AutoSize = true;
            lblSeccionResumen.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionResumen.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionResumen.Location = new Point(16, 396);
            lblSeccionResumen.Name = "lblSeccionResumen";
            lblSeccionResumen.Size = new Size(53, 12);
            lblSeccionResumen.TabIndex = 11;
            lblSeccionResumen.Text = "RESUMEN";
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.ForeColor = Color.FromArgb(148, 163, 184);
            lblFechaDevolucion.Location = new Point(16, 414);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(172, 17);
            lblFechaDevolucion.TabIndex = 12;
            lblFechaDevolucion.Text = "Fecha real de devolución: —";
            // 
            // lblDiasAtraso
            // 
            lblDiasAtraso.AutoSize = true;
            lblDiasAtraso.ForeColor = Color.FromArgb(148, 163, 184);
            lblDiasAtraso.Location = new Point(16, 434);
            lblDiasAtraso.Name = "lblDiasAtraso";
            lblDiasAtraso.Size = new Size(111, 17);
            lblDiasAtraso.TabIndex = 13;
            lblDiasAtraso.Text = "Días de atraso: —";
            // 
            // lblMulta
            // 
            lblMulta.AutoSize = true;
            lblMulta.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblMulta.ForeColor = Color.FromArgb(226, 232, 240);
            lblMulta.Location = new Point(16, 454);
            lblMulta.Name = "lblMulta";
            lblMulta.Size = new Size(61, 17);
            lblMulta.TabIndex = 14;
            lblMulta.Text = "Multa: —";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(45, 60, 82);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 75, 99);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(226, 232, 240);
            btnCancelar.Location = new Point(527, 528);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 34);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmar.BackColor = Color.FromArgb(37, 99, 235);
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(633, 528);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(100, 34);
            btnConfirmar.TabIndex = 16;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // FormDevolucion
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 42, 58);
            ClientSize = new Size(749, 572);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(lblMulta);
            Controls.Add(lblDiasAtraso);
            Controls.Add(lblFechaDevolucion);
            Controls.Add(lblSeccionResumen);
            Controls.Add(chkRecepcionCompleta);
            Controls.Add(dgvEjemplares);
            Controls.Add(lblSeccionEjemplares);
            Controls.Add(lblFechaDevolucionPrevista);
            Controls.Add(lblFechaPrestamo);
            Controls.Add(lblSocio);
            Controls.Add(btnBuscarPrestamo);
            Controls.Add(txtNumeroPrestamo);
            Controls.Add(lblNumeroPrestamo);
            Controls.Add(lblSeccionPrestamo);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDevolucion";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrar devolución";
            ((System.ComponentModel.ISupportInitialize)dgvEjemplares).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSeccionPrestamo;
        private Label lblNumeroPrestamo;
        private TextBox txtNumeroPrestamo;
        private Button btnBuscarPrestamo;
        private Label lblSocio;
        private Label lblFechaPrestamo;
        private Label lblFechaDevolucionPrevista;
        private Label lblSeccionEjemplares;
        private DataGridView dgvEjemplares;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colTitulo;
        private DataGridViewTextBoxColumn colAutor;
        private CheckBox chkRecepcionCompleta;
        private Label lblSeccionResumen;
        private Label lblFechaDevolucion;
        private Label lblDiasAtraso;
        private Label lblMulta;
        private Button btnCancelar;
        private Button btnConfirmar;
    }
}