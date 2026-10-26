using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormInicio
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
            pnlSaludo = new Panel();
            lblSaludo = new Label();
            lblFecha = new Label();
            crdVigentes = new TarjetaSGB();
            lblVigentesTitulo = new Label();
            lblVigentesValor = new Label();
            lblVigentesDetalle = new Label();
            crdVencidos = new TarjetaSGB();
            lblVencidosTitulo = new Label();
            lblVencidosValor = new Label();
            lblVencidosDetalle = new Label();
            crdMultas = new TarjetaSGB();
            lblMultasTitulo = new Label();
            lblMultasValor = new Label();
            lblMultasDetalle = new Label();
            crdMonto = new TarjetaSGB();
            lblMontoTitulo = new Label();
            lblMontoValor = new Label();
            lblMontoDetalle = new Label();
            pnlAyuda = new Panel();
            lblAyuda = new Label();
            tlpPrincipal.SuspendLayout();
            pnlSaludo.SuspendLayout();
            crdVigentes.SuspendLayout();
            crdVencidos.SuspendLayout();
            crdMultas.SuspendLayout();
            crdMonto.SuspendLayout();
            pnlAyuda.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal.ColumnCount = 4;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0F));
            tlpPrincipal.Controls.Add(pnlSaludo, 0, 0);
            tlpPrincipal.Controls.Add(crdVigentes, 0, 1);
            tlpPrincipal.Controls.Add(crdVencidos, 1, 1);
            tlpPrincipal.Controls.Add(crdMultas, 2, 1);
            tlpPrincipal.Controls.Add(crdMonto, 3, 1);
            tlpPrincipal.Controls.Add(pnlAyuda, 0, 2);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(12);
            tlpPrincipal.RowCount = 3;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 112.0F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 176.0F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            tlpPrincipal.Size = new Size(1100, 640);
            tlpPrincipal.TabIndex = 0;
            tlpPrincipal.SetColumnSpan(pnlSaludo, 4);
            tlpPrincipal.SetColumnSpan(pnlAyuda, 4);
            // 
            // pnlSaludo
            // 
            pnlSaludo.BackColor = Color.Transparent;
            pnlSaludo.Controls.Add(lblSaludo);
            pnlSaludo.Controls.Add(lblFecha);
            pnlSaludo.Dock = DockStyle.Fill;
            pnlSaludo.Margin = new Padding(8);
            pnlSaludo.Name = "pnlSaludo";
            pnlSaludo.Size = new Size(1060, 96);
            pnlSaludo.TabIndex = 0;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.BackColor = Color.Transparent;
            lblSaludo.Font = new Font("Segoe UI Semibold", 22F);
            lblSaludo.ForeColor = Color.FromArgb(31, 41, 55);
            lblSaludo.Location = new Point(4, 6);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(32, 20);
            lblSaludo.TabIndex = 0;
            lblSaludo.Text = "Hola";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Segoe UI", 11F);
            lblFecha.ForeColor = Color.FromArgb(107, 114, 128);
            lblFecha.Location = new Point(6, 56);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(20, 20);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "—";
            // 
            // crdVigentes
            // 
            crdVigentes.Controls.Add(lblVigentesTitulo);
            crdVigentes.Controls.Add(lblVigentesValor);
            crdVigentes.Controls.Add(lblVigentesDetalle);
            crdVigentes.Dock = DockStyle.Fill;
            crdVigentes.Margin = new Padding(8);
            crdVigentes.Name = "crdVigentes";
            crdVigentes.Size = new Size(253, 160);
            crdVigentes.TabIndex = 1;
            // 
            // lblVigentesTitulo
            // 
            lblVigentesTitulo.AutoSize = true;
            lblVigentesTitulo.BackColor = Color.Transparent;
            lblVigentesTitulo.Font = new Font("Segoe UI Semibold", 10F);
            lblVigentesTitulo.ForeColor = Color.FromArgb(107, 114, 128);
            lblVigentesTitulo.Location = new Point(20, 18);
            lblVigentesTitulo.Name = "lblVigentesTitulo";
            lblVigentesTitulo.Size = new Size(144, 20);
            lblVigentesTitulo.TabIndex = 0;
            lblVigentesTitulo.Text = "Préstamos vigentes";
            // 
            // lblVigentesValor
            // 
            lblVigentesValor.AutoSize = true;
            lblVigentesValor.BackColor = Color.Transparent;
            lblVigentesValor.Font = new Font("Segoe UI Semibold", 28F);
            lblVigentesValor.ForeColor = Color.FromArgb(123, 30, 46);
            lblVigentesValor.Location = new Point(16, 44);
            lblVigentesValor.Name = "lblVigentesValor";
            lblVigentesValor.Size = new Size(20, 20);
            lblVigentesValor.TabIndex = 1;
            lblVigentesValor.Text = "—";
            // 
            // lblVigentesDetalle
            // 
            lblVigentesDetalle.AutoSize = false;
            lblVigentesDetalle.BackColor = Color.Transparent;
            lblVigentesDetalle.Font = new Font("Segoe UI", 9.5F);
            lblVigentesDetalle.ForeColor = Color.FromArgb(107, 114, 128);
            lblVigentesDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblVigentesDetalle.Location = new Point(20, 108);
            lblVigentesDetalle.Name = "lblVigentesDetalle";
            lblVigentesDetalle.Size = new Size(213, 40);
            lblVigentesDetalle.TabIndex = 2;
            lblVigentesDetalle.Text = "Préstamos con ejemplares en poder de los socios";
            // 
            // crdVencidos
            // 
            crdVencidos.Controls.Add(lblVencidosTitulo);
            crdVencidos.Controls.Add(lblVencidosValor);
            crdVencidos.Controls.Add(lblVencidosDetalle);
            crdVencidos.Dock = DockStyle.Fill;
            crdVencidos.Margin = new Padding(8);
            crdVencidos.Name = "crdVencidos";
            crdVencidos.Size = new Size(253, 160);
            crdVencidos.TabIndex = 2;
            // 
            // lblVencidosTitulo
            // 
            lblVencidosTitulo.AutoSize = true;
            lblVencidosTitulo.BackColor = Color.Transparent;
            lblVencidosTitulo.Font = new Font("Segoe UI Semibold", 10F);
            lblVencidosTitulo.ForeColor = Color.FromArgb(107, 114, 128);
            lblVencidosTitulo.Location = new Point(20, 18);
            lblVencidosTitulo.Name = "lblVencidosTitulo";
            lblVencidosTitulo.Size = new Size(144, 20);
            lblVencidosTitulo.TabIndex = 0;
            lblVencidosTitulo.Text = "Préstamos vencidos";
            // 
            // lblVencidosValor
            // 
            lblVencidosValor.AutoSize = true;
            lblVencidosValor.BackColor = Color.Transparent;
            lblVencidosValor.Font = new Font("Segoe UI Semibold", 28F);
            lblVencidosValor.ForeColor = Color.FromArgb(180, 83, 9);
            lblVencidosValor.Location = new Point(16, 44);
            lblVencidosValor.Name = "lblVencidosValor";
            lblVencidosValor.Size = new Size(20, 20);
            lblVencidosValor.TabIndex = 1;
            lblVencidosValor.Text = "—";
            // 
            // lblVencidosDetalle
            // 
            lblVencidosDetalle.AutoSize = false;
            lblVencidosDetalle.BackColor = Color.Transparent;
            lblVencidosDetalle.Font = new Font("Segoe UI", 9.5F);
            lblVencidosDetalle.ForeColor = Color.FromArgb(107, 114, 128);
            lblVencidosDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblVencidosDetalle.Location = new Point(20, 108);
            lblVencidosDetalle.Name = "lblVencidosDetalle";
            lblVencidosDetalle.Size = new Size(213, 40);
            lblVencidosDetalle.TabIndex = 2;
            lblVencidosDetalle.Text = "Superaron la fecha de devolución prevista";
            // 
            // crdMultas
            // 
            crdMultas.Controls.Add(lblMultasTitulo);
            crdMultas.Controls.Add(lblMultasValor);
            crdMultas.Controls.Add(lblMultasDetalle);
            crdMultas.Dock = DockStyle.Fill;
            crdMultas.Margin = new Padding(8);
            crdMultas.Name = "crdMultas";
            crdMultas.Size = new Size(253, 160);
            crdMultas.TabIndex = 3;
            // 
            // lblMultasTitulo
            // 
            lblMultasTitulo.AutoSize = true;
            lblMultasTitulo.BackColor = Color.Transparent;
            lblMultasTitulo.Font = new Font("Segoe UI Semibold", 10F);
            lblMultasTitulo.ForeColor = Color.FromArgb(107, 114, 128);
            lblMultasTitulo.Location = new Point(20, 18);
            lblMultasTitulo.Name = "lblMultasTitulo";
            lblMultasTitulo.Size = new Size(136, 20);
            lblMultasTitulo.TabIndex = 0;
            lblMultasTitulo.Text = "Multas pendientes";
            // 
            // lblMultasValor
            // 
            lblMultasValor.AutoSize = true;
            lblMultasValor.BackColor = Color.Transparent;
            lblMultasValor.Font = new Font("Segoe UI Semibold", 28F);
            lblMultasValor.ForeColor = Color.FromArgb(185, 28, 28);
            lblMultasValor.Location = new Point(16, 44);
            lblMultasValor.Name = "lblMultasValor";
            lblMultasValor.Size = new Size(20, 20);
            lblMultasValor.TabIndex = 1;
            lblMultasValor.Text = "—";
            // 
            // lblMultasDetalle
            // 
            lblMultasDetalle.AutoSize = false;
            lblMultasDetalle.BackColor = Color.Transparent;
            lblMultasDetalle.Font = new Font("Segoe UI", 9.5F);
            lblMultasDetalle.ForeColor = Color.FromArgb(107, 114, 128);
            lblMultasDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMultasDetalle.Location = new Point(20, 108);
            lblMultasDetalle.Name = "lblMultasDetalle";
            lblMultasDetalle.Size = new Size(213, 40);
            lblMultasDetalle.TabIndex = 2;
            lblMultasDetalle.Text = "Los socios con multas no pueden pedir préstamos";
            // 
            // crdMonto
            // 
            crdMonto.Controls.Add(lblMontoTitulo);
            crdMonto.Controls.Add(lblMontoValor);
            crdMonto.Controls.Add(lblMontoDetalle);
            crdMonto.Dock = DockStyle.Fill;
            crdMonto.Margin = new Padding(8);
            crdMonto.Name = "crdMonto";
            crdMonto.Size = new Size(253, 160);
            crdMonto.TabIndex = 4;
            // 
            // lblMontoTitulo
            // 
            lblMontoTitulo.AutoSize = true;
            lblMontoTitulo.BackColor = Color.Transparent;
            lblMontoTitulo.Font = new Font("Segoe UI Semibold", 10F);
            lblMontoTitulo.ForeColor = Color.FromArgb(107, 114, 128);
            lblMontoTitulo.Location = new Point(20, 18);
            lblMontoTitulo.Name = "lblMontoTitulo";
            lblMontoTitulo.Size = new Size(112, 20);
            lblMontoTitulo.TabIndex = 0;
            lblMontoTitulo.Text = "Total adeudado";
            // 
            // lblMontoValor
            // 
            lblMontoValor.AutoSize = true;
            lblMontoValor.BackColor = Color.Transparent;
            lblMontoValor.Font = new Font("Segoe UI Semibold", 28F);
            lblMontoValor.ForeColor = Color.FromArgb(31, 41, 55);
            lblMontoValor.Location = new Point(16, 44);
            lblMontoValor.Name = "lblMontoValor";
            lblMontoValor.Size = new Size(20, 20);
            lblMontoValor.TabIndex = 1;
            lblMontoValor.Text = "—";
            // 
            // lblMontoDetalle
            // 
            lblMontoDetalle.AutoSize = false;
            lblMontoDetalle.BackColor = Color.Transparent;
            lblMontoDetalle.Font = new Font("Segoe UI", 9.5F);
            lblMontoDetalle.ForeColor = Color.FromArgb(107, 114, 128);
            lblMontoDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMontoDetalle.Location = new Point(20, 108);
            lblMontoDetalle.Name = "lblMontoDetalle";
            lblMontoDetalle.Size = new Size(213, 40);
            lblMontoDetalle.TabIndex = 2;
            lblMontoDetalle.Text = "Suma de las multas pendientes de pago";
            // 
            // pnlAyuda
            // 
            pnlAyuda.BackColor = Color.Transparent;
            pnlAyuda.Controls.Add(lblAyuda);
            pnlAyuda.Dock = DockStyle.Fill;
            pnlAyuda.Margin = new Padding(8);
            pnlAyuda.Name = "pnlAyuda";
            pnlAyuda.Size = new Size(1060, 300);
            pnlAyuda.TabIndex = 5;
            // 
            // lblAyuda
            // 
            lblAyuda.AutoSize = true;
            lblAyuda.BackColor = Color.Transparent;
            lblAyuda.Font = new Font("Segoe UI", 9.5F);
            lblAyuda.ForeColor = Color.FromArgb(107, 114, 128);
            lblAyuda.Location = new Point(4, 8);
            lblAyuda.Name = "lblAyuda";
            lblAyuda.Size = new Size(384, 20);
            lblAyuda.TabIndex = 0;
            lblAyuda.Text = "Elegí una opción del menú lateral para comenzar.";
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInicio";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += FormInicio_Load;
            pnlAyuda.ResumeLayout(false);
            pnlAyuda.PerformLayout();
            crdMonto.ResumeLayout(false);
            crdMonto.PerformLayout();
            crdMultas.ResumeLayout(false);
            crdMultas.PerformLayout();
            crdVencidos.ResumeLayout(false);
            crdVencidos.PerformLayout();
            crdVigentes.ResumeLayout(false);
            crdVigentes.PerformLayout();
            pnlSaludo.ResumeLayout(false);
            pnlSaludo.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private Panel pnlSaludo;
        private Label lblSaludo;
        private Label lblFecha;
        private TarjetaSGB crdVigentes;
        private Label lblVigentesTitulo;
        private Label lblVigentesValor;
        private Label lblVigentesDetalle;
        private TarjetaSGB crdVencidos;
        private Label lblVencidosTitulo;
        private Label lblVencidosValor;
        private Label lblVencidosDetalle;
        private TarjetaSGB crdMultas;
        private Label lblMultasTitulo;
        private Label lblMultasValor;
        private Label lblMultasDetalle;
        private TarjetaSGB crdMonto;
        private Label lblMontoTitulo;
        private Label lblMontoValor;
        private Label lblMontoDetalle;
        private Panel pnlAyuda;
        private Label lblAyuda;
    }
}
