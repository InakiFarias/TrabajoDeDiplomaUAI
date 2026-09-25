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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSocio = new Label();
            lblSeccionMultas = new Label();
            dgvMultas = new DataGridView();
            colNumero = new DataGridViewTextBoxColumn();
            colFechaGeneracion = new DataGridViewTextBoxColumn();
            colDiasAtraso = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            btnNoAbona = new Button();
            btnConfirmarCobro = new Button();
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
            lblTitulo.Size = new Size(212, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar pago de multa";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.ForeColor = Color.FromArgb(148, 163, 184);
            lblSocio.Location = new Point(16, 48);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(58, 17);
            lblSocio.TabIndex = 1;
            lblSocio.Text = "Socio: —";
            // 
            // lblSeccionMultas
            // 
            lblSeccionMultas.AutoSize = true;
            lblSeccionMultas.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSeccionMultas.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionMultas.Location = new Point(16, 80);
            lblSeccionMultas.Name = "lblSeccionMultas";
            lblSeccionMultas.Size = new Size(145, 12);
            lblSeccionMultas.TabIndex = 2;
            lblSeccionMultas.Text = "MULTAS PENDIENTES DE PAGO";
            // 
            // dgvMultas
            // 
            dgvMultas.AllowUserToAddRows = false;
            dgvMultas.AllowUserToDeleteRows = false;
            dgvMultas.AllowUserToResizeRows = false;
            dgvMultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMultas.BackgroundColor = Color.FromArgb(21, 32, 48);
            dgvMultas.BorderStyle = BorderStyle.None;
            dgvMultas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMultas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(25, 37, 53);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(148, 163, 184);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMultas.Columns.AddRange(new DataGridViewColumn[] { colNumero, colFechaGeneracion, colDiasAtraso, colMonto });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(21, 32, 48);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(45, 60, 82);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvMultas.DefaultCellStyle = dataGridViewCellStyle5;
            dgvMultas.EnableHeadersVisualStyles = false;
            dgvMultas.GridColor = Color.FromArgb(45, 60, 82);
            dgvMultas.Location = new Point(16, 98);
            dgvMultas.MultiSelect = false;
            dgvMultas.Name = "dgvMultas";
            dgvMultas.ReadOnly = true;
            dgvMultas.RowHeadersVisible = false;
            dgvMultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMultas.Size = new Size(528, 180);
            dgvMultas.TabIndex = 3;
            // 
            // colNumero
            // 
            colNumero.FillWeight = 20F;
            colNumero.HeaderText = "Número";
            colNumero.Name = "colNumero";
            colNumero.ReadOnly = true;
            // 
            // colFechaGeneracion
            // 
            dataGridViewCellStyle2.Format = "d";
            colFechaGeneracion.DefaultCellStyle = dataGridViewCellStyle2;
            colFechaGeneracion.FillWeight = 30F;
            colFechaGeneracion.HeaderText = "Fecha de generación";
            colFechaGeneracion.Name = "colFechaGeneracion";
            colFechaGeneracion.ReadOnly = true;
            // 
            // colDiasAtraso
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colDiasAtraso.DefaultCellStyle = dataGridViewCellStyle3;
            colDiasAtraso.FillWeight = 20F;
            colDiasAtraso.HeaderText = "Días de atraso";
            colDiasAtraso.Name = "colDiasAtraso";
            colDiasAtraso.ReadOnly = true;
            // 
            // colMonto
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            colMonto.DefaultCellStyle = dataGridViewCellStyle4;
            colMonto.FillWeight = 30F;
            colMonto.HeaderText = "Monto";
            colMonto.Name = "colMonto";
            colMonto.ReadOnly = true;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(226, 232, 240);
            lblTotal.Location = new Point(244, 290);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(300, 24);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total adeudado: $ 0,00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnNoAbona
            // 
            btnNoAbona.BackColor = Color.FromArgb(45, 60, 82);
            btnNoAbona.Cursor = Cursors.Hand;
            btnNoAbona.FlatAppearance.BorderSize = 0;
            btnNoAbona.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 75, 99);
            btnNoAbona.FlatStyle = FlatStyle.Flat;
            btnNoAbona.ForeColor = Color.FromArgb(226, 232, 240);
            btnNoAbona.Location = new Point(278, 342);
            btnNoAbona.Name = "btnNoAbona";
            btnNoAbona.Size = new Size(130, 34);
            btnNoAbona.TabIndex = 5;
            btnNoAbona.Text = "El socio no abona";
            btnNoAbona.UseVisualStyleBackColor = false;
            // 
            // btnConfirmarCobro
            // 
            btnConfirmarCobro.BackColor = Color.FromArgb(37, 99, 235);
            btnConfirmarCobro.Cursor = Cursors.Hand;
            btnConfirmarCobro.FlatAppearance.BorderSize = 0;
            btnConfirmarCobro.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnConfirmarCobro.FlatStyle = FlatStyle.Flat;
            btnConfirmarCobro.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnConfirmarCobro.ForeColor = Color.White;
            btnConfirmarCobro.Location = new Point(414, 342);
            btnConfirmarCobro.Name = "btnConfirmarCobro";
            btnConfirmarCobro.Size = new Size(130, 34);
            btnConfirmarCobro.TabIndex = 6;
            btnConfirmarCobro.Text = "Confirmar cobro";
            btnConfirmarCobro.UseVisualStyleBackColor = false;
            // 
            // FormMulta
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 42, 58);
            ClientSize = new Size(560, 392);
            Controls.Add(btnConfirmarCobro);
            Controls.Add(btnNoAbona);
            Controls.Add(lblTotal);
            Controls.Add(dgvMultas);
            Controls.Add(lblSeccionMultas);
            Controls.Add(lblSocio);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMulta";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrar pago de multa";
            ((System.ComponentModel.ISupportInitialize)dgvMultas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSocio;
        private Label lblSeccionMultas;
        private DataGridView dgvMultas;
        private DataGridViewTextBoxColumn colNumero;
        private DataGridViewTextBoxColumn colFechaGeneracion;
        private DataGridViewTextBoxColumn colDiasAtraso;
        private DataGridViewTextBoxColumn colMonto;
        private Label lblTotal;
        private Button btnNoAbona;
        private Button btnConfirmarCobro;
    }
}