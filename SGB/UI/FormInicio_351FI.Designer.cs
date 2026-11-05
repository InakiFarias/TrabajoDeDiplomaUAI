using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormInicio_351FI
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
            pnlSaludo_351FI = new Panel();
            lblSaludo_351FI = new Label();
            lblFecha_351FI = new Label();
            crdVigentes_351FI = new TarjetaSGB_351FI();
            lblVigentesTitulo_351FI = new Label();
            lblVigentesValor_351FI = new Label();
            lblVigentesDetalle_351FI = new Label();
            crdVencidos_351FI = new TarjetaSGB_351FI();
            lblVencidosTitulo_351FI = new Label();
            lblVencidosValor_351FI = new Label();
            lblVencidosDetalle_351FI = new Label();
            crdMultas_351FI = new TarjetaSGB_351FI();
            lblMultasTitulo_351FI = new Label();
            lblMultasValor_351FI = new Label();
            lblMultasDetalle_351FI = new Label();
            crdMonto_351FI = new TarjetaSGB_351FI();
            lblMontoTitulo_351FI = new Label();
            lblMontoValor_351FI = new Label();
            lblMontoDetalle_351FI = new Label();
            pnlAyuda_351FI = new Panel();
            lblAyuda_351FI = new Label();
            tlpPrincipal_351FI.SuspendLayout();
            pnlSaludo_351FI.SuspendLayout();
            crdVigentes_351FI.SuspendLayout();
            crdVencidos_351FI.SuspendLayout();
            crdMultas_351FI.SuspendLayout();
            crdMonto_351FI.SuspendLayout();
            pnlAyuda_351FI.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal_351FI.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal_351FI.ColumnCount = 4;
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0F));
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0F));
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0F));
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0F));
            tlpPrincipal_351FI.Controls.Add(pnlSaludo_351FI, 0, 0);
            tlpPrincipal_351FI.Controls.Add(crdVigentes_351FI, 0, 1);
            tlpPrincipal_351FI.Controls.Add(crdVencidos_351FI, 1, 1);
            tlpPrincipal_351FI.Controls.Add(crdMultas_351FI, 2, 1);
            tlpPrincipal_351FI.Controls.Add(crdMonto_351FI, 3, 1);
            tlpPrincipal_351FI.Controls.Add(pnlAyuda_351FI, 0, 2);
            tlpPrincipal_351FI.Dock = DockStyle.Fill;
            tlpPrincipal_351FI.Name = "tlpPrincipal_351FI";
            tlpPrincipal_351FI.Padding = new Padding(12);
            tlpPrincipal_351FI.RowCount = 3;
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Absolute, 112.0F));
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Absolute, 176.0F));
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            tlpPrincipal_351FI.Size = new Size(1100, 640);
            tlpPrincipal_351FI.TabIndex = 0;
            tlpPrincipal_351FI.SetColumnSpan(pnlSaludo_351FI, 4);
            tlpPrincipal_351FI.SetColumnSpan(pnlAyuda_351FI, 4);
            // 
            // pnlSaludo
            // 
            pnlSaludo_351FI.BackColor = Color.Transparent;
            pnlSaludo_351FI.Controls.Add(lblSaludo_351FI);
            pnlSaludo_351FI.Controls.Add(lblFecha_351FI);
            pnlSaludo_351FI.Dock = DockStyle.Fill;
            pnlSaludo_351FI.Margin = new Padding(8);
            pnlSaludo_351FI.Name = "pnlSaludo_351FI";
            pnlSaludo_351FI.Size = new Size(1060, 96);
            pnlSaludo_351FI.TabIndex = 0;
            // 
            // lblSaludo
            // 
            lblSaludo_351FI.AutoSize = true;
            lblSaludo_351FI.BackColor = Color.Transparent;
            lblSaludo_351FI.Font = new Font("Segoe UI Semibold", 22F);
            lblSaludo_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblSaludo_351FI.Location = new Point(4, 6);
            lblSaludo_351FI.Name = "lblSaludo_351FI";
            lblSaludo_351FI.Size = new Size(32, 20);
            lblSaludo_351FI.TabIndex = 0;
            lblSaludo_351FI.Text = "Hola";
            // 
            // lblFecha
            // 
            lblFecha_351FI.AutoSize = true;
            lblFecha_351FI.BackColor = Color.Transparent;
            lblFecha_351FI.Font = new Font("Segoe UI", 11F);
            lblFecha_351FI.ForeColor = Color.FromArgb(107, 114, 128);
            lblFecha_351FI.Location = new Point(6, 56);
            lblFecha_351FI.Name = "lblFecha_351FI";
            lblFecha_351FI.Size = new Size(20, 20);
            lblFecha_351FI.TabIndex = 1;
            lblFecha_351FI.Text = "—";
            // 
            // crdVigentes
            // 
            crdVigentes_351FI.Controls.Add(lblVigentesTitulo_351FI);
            crdVigentes_351FI.Controls.Add(lblVigentesValor_351FI);
            crdVigentes_351FI.Controls.Add(lblVigentesDetalle_351FI);
            crdVigentes_351FI.Dock = DockStyle.Fill;
            crdVigentes_351FI.Margin = new Padding(8);
            crdVigentes_351FI.Name = "crdVigentes_351FI";
            crdVigentes_351FI.Size = new Size(253, 160);
            crdVigentes_351FI.TabIndex = 1;
            // 
            // lblVigentesTitulo
            // 
            lblVigentesTitulo_351FI.AutoSize = true;
            lblVigentesTitulo_351FI.BackColor = Color.Transparent;
            lblVigentesTitulo_351FI.Font = new Font("Segoe UI Semibold", 10F);
            lblVigentesTitulo_351FI.ForeColor = Color.FromArgb(107, 114, 128);
            lblVigentesTitulo_351FI.Location = new Point(20, 18);
            lblVigentesTitulo_351FI.Name = "lblVigentesTitulo_351FI";
            lblVigentesTitulo_351FI.Size = new Size(144, 20);
            lblVigentesTitulo_351FI.TabIndex = 0;
            lblVigentesTitulo_351FI.Text = "Préstamos vigentes";
            // 
            // lblVigentesValor
            // 
            lblVigentesValor_351FI.AutoSize = true;
            lblVigentesValor_351FI.BackColor = Color.Transparent;
            lblVigentesValor_351FI.Font = new Font("Segoe UI Semibold", 28F);
            lblVigentesValor_351FI.ForeColor = Color.FromArgb(123, 30, 46);
            lblVigentesValor_351FI.Location = new Point(16, 44);
            lblVigentesValor_351FI.Name = "lblVigentesValor_351FI";
            lblVigentesValor_351FI.Size = new Size(20, 20);
            lblVigentesValor_351FI.TabIndex = 1;
            lblVigentesValor_351FI.Text = "—";
            // 
            // lblVigentesDetalle
            // 
            lblVigentesDetalle_351FI.AutoSize = false;
            lblVigentesDetalle_351FI.BackColor = Color.Transparent;
            lblVigentesDetalle_351FI.Font = new Font("Segoe UI", 9.5F);
            lblVigentesDetalle_351FI.ForeColor = Color.FromArgb(107, 114, 128);
            lblVigentesDetalle_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblVigentesDetalle_351FI.Location = new Point(20, 108);
            lblVigentesDetalle_351FI.Name = "lblVigentesDetalle_351FI";
            lblVigentesDetalle_351FI.Size = new Size(213, 40);
            lblVigentesDetalle_351FI.TabIndex = 2;
            lblVigentesDetalle_351FI.Text = "Préstamos con ejemplares en poder de los socios";
            // 
            // crdVencidos
            // 
            crdVencidos_351FI.Controls.Add(lblVencidosTitulo_351FI);
            crdVencidos_351FI.Controls.Add(lblVencidosValor_351FI);
            crdVencidos_351FI.Controls.Add(lblVencidosDetalle_351FI);
            crdVencidos_351FI.Dock = DockStyle.Fill;
            crdVencidos_351FI.Margin = new Padding(8);
            crdVencidos_351FI.Name = "crdVencidos_351FI";
            crdVencidos_351FI.Size = new Size(253, 160);
            crdVencidos_351FI.TabIndex = 2;
            // 
            // lblVencidosTitulo
            // 
            lblVencidosTitulo_351FI.AutoSize = true;
            lblVencidosTitulo_351FI.BackColor = Color.Transparent;
            lblVencidosTitulo_351FI.Font = new Font("Segoe UI Semibold", 10F);
            lblVencidosTitulo_351FI.ForeColor = Color.FromArgb(107, 114, 128);
            lblVencidosTitulo_351FI.Location = new Point(20, 18);
            lblVencidosTitulo_351FI.Name = "lblVencidosTitulo_351FI";
            lblVencidosTitulo_351FI.Size = new Size(144, 20);
            lblVencidosTitulo_351FI.TabIndex = 0;
            lblVencidosTitulo_351FI.Text = "Préstamos vencidos";
            // 
            // lblVencidosValor
            // 
            lblVencidosValor_351FI.AutoSize = true;
            lblVencidosValor_351FI.BackColor = Color.Transparent;
            lblVencidosValor_351FI.Font = new Font("Segoe UI Semibold", 28F);
            lblVencidosValor_351FI.ForeColor = Color.FromArgb(180, 83, 9);
            lblVencidosValor_351FI.Location = new Point(16, 44);
            lblVencidosValor_351FI.Name = "lblVencidosValor_351FI";
            lblVencidosValor_351FI.Size = new Size(20, 20);
            lblVencidosValor_351FI.TabIndex = 1;
            lblVencidosValor_351FI.Text = "—";
            // 
            // lblVencidosDetalle
            // 
            lblVencidosDetalle_351FI.AutoSize = false;
            lblVencidosDetalle_351FI.BackColor = Color.Transparent;
            lblVencidosDetalle_351FI.Font = new Font("Segoe UI", 9.5F);
            lblVencidosDetalle_351FI.ForeColor = Color.FromArgb(107, 114, 128);
            lblVencidosDetalle_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblVencidosDetalle_351FI.Location = new Point(20, 108);
            lblVencidosDetalle_351FI.Name = "lblVencidosDetalle_351FI";
            lblVencidosDetalle_351FI.Size = new Size(213, 40);
            lblVencidosDetalle_351FI.TabIndex = 2;
            lblVencidosDetalle_351FI.Text = "Superaron la fecha de devolución prevista";
            // 
            // crdMultas
            // 
            crdMultas_351FI.Controls.Add(lblMultasTitulo_351FI);
            crdMultas_351FI.Controls.Add(lblMultasValor_351FI);
            crdMultas_351FI.Controls.Add(lblMultasDetalle_351FI);
            crdMultas_351FI.Dock = DockStyle.Fill;
            crdMultas_351FI.Margin = new Padding(8);
            crdMultas_351FI.Name = "crdMultas_351FI";
            crdMultas_351FI.Size = new Size(253, 160);
            crdMultas_351FI.TabIndex = 3;
            // 
            // lblMultasTitulo
            // 
            lblMultasTitulo_351FI.AutoSize = true;
            lblMultasTitulo_351FI.BackColor = Color.Transparent;
            lblMultasTitulo_351FI.Font = new Font("Segoe UI Semibold", 10F);
            lblMultasTitulo_351FI.ForeColor = Color.FromArgb(107, 114, 128);
            lblMultasTitulo_351FI.Location = new Point(20, 18);
            lblMultasTitulo_351FI.Name = "lblMultasTitulo_351FI";
            lblMultasTitulo_351FI.Size = new Size(136, 20);
            lblMultasTitulo_351FI.TabIndex = 0;
            lblMultasTitulo_351FI.Text = "Multas pendientes";
            // 
            // lblMultasValor
            // 
            lblMultasValor_351FI.AutoSize = true;
            lblMultasValor_351FI.BackColor = Color.Transparent;
            lblMultasValor_351FI.Font = new Font("Segoe UI Semibold", 28F);
            lblMultasValor_351FI.ForeColor = Color.FromArgb(185, 28, 28);
            lblMultasValor_351FI.Location = new Point(16, 44);
            lblMultasValor_351FI.Name = "lblMultasValor_351FI";
            lblMultasValor_351FI.Size = new Size(20, 20);
            lblMultasValor_351FI.TabIndex = 1;
            lblMultasValor_351FI.Text = "—";
            // 
            // lblMultasDetalle
            // 
            lblMultasDetalle_351FI.AutoSize = false;
            lblMultasDetalle_351FI.BackColor = Color.Transparent;
            lblMultasDetalle_351FI.Font = new Font("Segoe UI", 9.5F);
            lblMultasDetalle_351FI.ForeColor = Color.FromArgb(107, 114, 128);
            lblMultasDetalle_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMultasDetalle_351FI.Location = new Point(20, 108);
            lblMultasDetalle_351FI.Name = "lblMultasDetalle_351FI";
            lblMultasDetalle_351FI.Size = new Size(213, 40);
            lblMultasDetalle_351FI.TabIndex = 2;
            lblMultasDetalle_351FI.Text = "Los socios con multas no pueden pedir préstamos";
            // 
            // crdMonto
            // 
            crdMonto_351FI.Controls.Add(lblMontoTitulo_351FI);
            crdMonto_351FI.Controls.Add(lblMontoValor_351FI);
            crdMonto_351FI.Controls.Add(lblMontoDetalle_351FI);
            crdMonto_351FI.Dock = DockStyle.Fill;
            crdMonto_351FI.Margin = new Padding(8);
            crdMonto_351FI.Name = "crdMonto_351FI";
            crdMonto_351FI.Size = new Size(253, 160);
            crdMonto_351FI.TabIndex = 4;
            // 
            // lblMontoTitulo
            // 
            lblMontoTitulo_351FI.AutoSize = true;
            lblMontoTitulo_351FI.BackColor = Color.Transparent;
            lblMontoTitulo_351FI.Font = new Font("Segoe UI Semibold", 10F);
            lblMontoTitulo_351FI.ForeColor = Color.FromArgb(107, 114, 128);
            lblMontoTitulo_351FI.Location = new Point(20, 18);
            lblMontoTitulo_351FI.Name = "lblMontoTitulo_351FI";
            lblMontoTitulo_351FI.Size = new Size(112, 20);
            lblMontoTitulo_351FI.TabIndex = 0;
            lblMontoTitulo_351FI.Text = "Total adeudado";
            // 
            // lblMontoValor
            // 
            lblMontoValor_351FI.AutoSize = true;
            lblMontoValor_351FI.BackColor = Color.Transparent;
            lblMontoValor_351FI.Font = new Font("Segoe UI Semibold", 28F);
            lblMontoValor_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            lblMontoValor_351FI.Location = new Point(16, 44);
            lblMontoValor_351FI.Name = "lblMontoValor_351FI";
            lblMontoValor_351FI.Size = new Size(20, 20);
            lblMontoValor_351FI.TabIndex = 1;
            lblMontoValor_351FI.Text = "—";
            // 
            // lblMontoDetalle
            // 
            lblMontoDetalle_351FI.AutoSize = false;
            lblMontoDetalle_351FI.BackColor = Color.Transparent;
            lblMontoDetalle_351FI.Font = new Font("Segoe UI", 9.5F);
            lblMontoDetalle_351FI.ForeColor = Color.FromArgb(107, 114, 128);
            lblMontoDetalle_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMontoDetalle_351FI.Location = new Point(20, 108);
            lblMontoDetalle_351FI.Name = "lblMontoDetalle_351FI";
            lblMontoDetalle_351FI.Size = new Size(213, 40);
            lblMontoDetalle_351FI.TabIndex = 2;
            lblMontoDetalle_351FI.Text = "Suma de las multas pendientes de pago";
            // 
            // pnlAyuda
            // 
            pnlAyuda_351FI.BackColor = Color.Transparent;
            pnlAyuda_351FI.Controls.Add(lblAyuda_351FI);
            pnlAyuda_351FI.Dock = DockStyle.Fill;
            pnlAyuda_351FI.Margin = new Padding(8);
            pnlAyuda_351FI.Name = "pnlAyuda_351FI";
            pnlAyuda_351FI.Size = new Size(1060, 300);
            pnlAyuda_351FI.TabIndex = 5;
            // 
            // lblAyuda
            // 
            lblAyuda_351FI.AutoSize = true;
            lblAyuda_351FI.BackColor = Color.Transparent;
            lblAyuda_351FI.Font = new Font("Segoe UI", 9.5F);
            lblAyuda_351FI.ForeColor = Color.FromArgb(107, 114, 128);
            lblAyuda_351FI.Location = new Point(4, 8);
            lblAyuda_351FI.Name = "lblAyuda_351FI";
            lblAyuda_351FI.Size = new Size(384, 20);
            lblAyuda_351FI.TabIndex = 0;
            lblAyuda_351FI.Text = "Elegí una opción del menú lateral para comenzar.";
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal_351FI);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInicio_351FI";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += FormInicio_351FI_Load;
            pnlAyuda_351FI.ResumeLayout(false);
            pnlAyuda_351FI.PerformLayout();
            crdMonto_351FI.ResumeLayout(false);
            crdMonto_351FI.PerformLayout();
            crdMultas_351FI.ResumeLayout(false);
            crdMultas_351FI.PerformLayout();
            crdVencidos_351FI.ResumeLayout(false);
            crdVencidos_351FI.PerformLayout();
            crdVigentes_351FI.ResumeLayout(false);
            crdVigentes_351FI.PerformLayout();
            pnlSaludo_351FI.ResumeLayout(false);
            pnlSaludo_351FI.PerformLayout();
            tlpPrincipal_351FI.ResumeLayout(false);
            tlpPrincipal_351FI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal_351FI;
        private Panel pnlSaludo_351FI;
        private Label lblSaludo_351FI;
        private Label lblFecha_351FI;
        private TarjetaSGB_351FI crdVigentes_351FI;
        private Label lblVigentesTitulo_351FI;
        private Label lblVigentesValor_351FI;
        private Label lblVigentesDetalle_351FI;
        private TarjetaSGB_351FI crdVencidos_351FI;
        private Label lblVencidosTitulo_351FI;
        private Label lblVencidosValor_351FI;
        private Label lblVencidosDetalle_351FI;
        private TarjetaSGB_351FI crdMultas_351FI;
        private Label lblMultasTitulo_351FI;
        private Label lblMultasValor_351FI;
        private Label lblMultasDetalle_351FI;
        private TarjetaSGB_351FI crdMonto_351FI;
        private Label lblMontoTitulo_351FI;
        private Label lblMontoValor_351FI;
        private Label lblMontoDetalle_351FI;
        private Panel pnlAyuda_351FI;
        private Label lblAyuda_351FI;
    }
}
