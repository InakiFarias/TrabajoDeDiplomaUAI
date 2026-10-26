using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FrmRepararInconsistencia
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
            crdRegistros = new TarjetaSGB();
            lblTitulo = new Label();
            grillaInconsistencias = new GrillaSGB();
            crdDetalle = new TarjetaSGB();
            lblDetalle = new Label();
            richTextBox1 = new RichTextBox();
            pnlAcciones = new FlowLayoutPanel();
            btnRestaurarDV = new BotonSGB();
            btnRealizarRespaldo = new BotonSGB();
            btnSalir = new BotonSGB();
            tlpPrincipal.SuspendLayout();
            crdRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaInconsistencias).BeginInit();
            crdDetalle.SuspendLayout();
            pnlAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal.ColumnCount = 2;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));
            tlpPrincipal.Controls.Add(crdRegistros, 0, 0);
            tlpPrincipal.Controls.Add(crdDetalle, 1, 0);
            tlpPrincipal.Controls.Add(pnlAcciones, 0, 1);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(12);
            tlpPrincipal.RowCount = 2;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 56.0F));
            tlpPrincipal.Size = new Size(1000, 620);
            tlpPrincipal.TabIndex = 0;
            tlpPrincipal.SetColumnSpan(pnlAcciones, 2);
            // 
            // crdRegistros
            // 
            crdRegistros.Controls.Add(lblTitulo);
            crdRegistros.Controls.Add(grillaInconsistencias);
            crdRegistros.Dock = DockStyle.Fill;
            crdRegistros.Margin = new Padding(8);
            crdRegistros.Name = "crdRegistros";
            crdRegistros.Size = new Size(472, 524);
            crdRegistros.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI Semibold", 12F);
            lblTitulo.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitulo.Location = new Point(20, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(232, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registros con inconsistencias";
            // 
            // grillaInconsistencias
            // 
            grillaInconsistencias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grillaInconsistencias.Location = new Point(20, 52);
            grillaInconsistencias.Name = "grillaInconsistencias";
            grillaInconsistencias.Size = new Size(432, 452);
            grillaInconsistencias.TabIndex = 1;
            grillaInconsistencias.SelectionChanged += grillaInconsistencias_SelectionChanged;
            // 
            // crdDetalle
            // 
            crdDetalle.Controls.Add(lblDetalle);
            crdDetalle.Controls.Add(richTextBox1);
            crdDetalle.Dock = DockStyle.Fill;
            crdDetalle.Margin = new Padding(8);
            crdDetalle.Name = "crdDetalle";
            crdDetalle.Size = new Size(472, 524);
            crdDetalle.TabIndex = 1;
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.BackColor = Color.Transparent;
            lblDetalle.Font = new Font("Segoe UI Semibold", 12F);
            lblDetalle.ForeColor = Color.FromArgb(31, 41, 55);
            lblDetalle.Location = new Point(20, 16);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(56, 20);
            lblDetalle.TabIndex = 0;
            lblDetalle.Text = "Detalle";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = Color.FromArgb(31, 41, 55);
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(20, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(432, 452);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // pnlAcciones
            // 
            pnlAcciones.BackColor = Color.Transparent;
            pnlAcciones.Controls.Add(btnRestaurarDV);
            pnlAcciones.Controls.Add(btnRealizarRespaldo);
            pnlAcciones.Controls.Add(btnSalir);
            pnlAcciones.FlowDirection = FlowDirection.RightToLeft;
            pnlAcciones.WrapContents = false;
            pnlAcciones.Dock = DockStyle.Fill;
            pnlAcciones.Margin = new Padding(8);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(400, 40);
            pnlAcciones.TabIndex = 2;
            // 
            // btnRestaurarDV
            // 
            btnRestaurarDV.Font = new Font("Segoe UI Semibold", 10.5F);
            btnRestaurarDV.Icono = "\uE73E";
            btnRestaurarDV.Margin = new Padding(12, 0, 0, 0);
            btnRestaurarDV.Name = "btnRestaurarDV";
            btnRestaurarDV.Size = new Size(300, 40);
            btnRestaurarDV.TabIndex = 0;
            btnRestaurarDV.Text = "Recalcular dígitos verificadores";
            btnRestaurarDV.Click += btnRestaurarDV_Click;
            // 
            // btnRealizarRespaldo
            // 
            btnRealizarRespaldo.Estilo = EstiloBoton.Secundario;
            btnRealizarRespaldo.Font = new Font("Segoe UI Semibold", 10.5F);
            btnRealizarRespaldo.Icono = "\uE777";
            btnRealizarRespaldo.Margin = new Padding(12, 0, 0, 0);
            btnRealizarRespaldo.Name = "btnRealizarRespaldo";
            btnRealizarRespaldo.Size = new Size(280, 40);
            btnRealizarRespaldo.TabIndex = 1;
            btnRealizarRespaldo.Text = "Restaurar copia de seguridad";
            btnRealizarRespaldo.Click += btnRealizarRespaldo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Estilo = EstiloBoton.Secundario;
            btnSalir.Font = new Font("Segoe UI Semibold", 10.5F);
            btnSalir.Icono = "\uE8BB";
            btnSalir.Margin = new Padding(12, 0, 0, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 40);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmRepararInconsistencia
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1000, 620);
            Controls.Add(tlpPrincipal);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            MinimumSize = new Size(900, 560);
            Name = "FrmRepararInconsistencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reparación de inconsistencias";
            Load += FrmRepararInconsistencia_Load;
            ((System.ComponentModel.ISupportInitialize)grillaInconsistencias).EndInit();
            pnlAcciones.ResumeLayout(false);
            pnlAcciones.PerformLayout();
            crdDetalle.ResumeLayout(false);
            crdDetalle.PerformLayout();
            crdRegistros.ResumeLayout(false);
            crdRegistros.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TarjetaSGB crdRegistros;
        private Label lblTitulo;
        private GrillaSGB grillaInconsistencias;
        private TarjetaSGB crdDetalle;
        private Label lblDetalle;
        private RichTextBox richTextBox1;
        private FlowLayoutPanel pnlAcciones;
        private BotonSGB btnRestaurarDV;
        private BotonSGB btnRealizarRespaldo;
        private BotonSGB btnSalir;
    }
}
