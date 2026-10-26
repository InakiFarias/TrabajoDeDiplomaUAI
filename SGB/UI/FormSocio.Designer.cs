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
            tlpPrincipal = new TableLayoutPanel();
            crdSocios = new TarjetaSGB();
            lblSeccionSocios = new Label();
            lblBuscarDni = new Label();
            txtBuscarDni = new TextBox();
            dgvSocios = new GrillaSGB();
            colSocNumero = new DataGridViewTextBoxColumn();
            colSocApellido = new DataGridViewTextBoxColumn();
            colSocNombre = new DataGridViewTextBoxColumn();
            colSocDni = new DataGridViewTextBoxColumn();
            colSocEstado = new DataGridViewTextBoxColumn();
            crdDatos = new TarjetaSGB();
            lblSeccionDatos = new Label();
            lblNumero = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            btnAlta = new BotonSGB();
            btnModificar = new BotonSGB();
            btnBaja = new BotonSGB();
            btnReactivar = new BotonSGB();
            btnLimpiar = new BotonSGB();
            pnlAcciones = new FlowLayoutPanel();
            btnCerrar = new BotonSGB();
            tlpPrincipal.SuspendLayout();
            crdSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            crdDatos.SuspendLayout();
            pnlAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal.ColumnCount = 2;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.0F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.0F));
            tlpPrincipal.Controls.Add(crdSocios, 0, 0);
            tlpPrincipal.Controls.Add(crdDatos, 1, 0);
            tlpPrincipal.Controls.Add(pnlAcciones, 0, 1);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(12);
            tlpPrincipal.RowCount = 2;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 56.0F));
            tlpPrincipal.Size = new Size(1100, 640);
            tlpPrincipal.TabIndex = 0;
            tlpPrincipal.SetColumnSpan(pnlAcciones, 2);
            // 
            // crdSocios
            // 
            crdSocios.Controls.Add(lblSeccionSocios);
            crdSocios.Controls.Add(lblBuscarDni);
            crdSocios.Controls.Add(txtBuscarDni);
            crdSocios.Controls.Add(dgvSocios);
            crdSocios.Dock = DockStyle.Fill;
            crdSocios.Margin = new Padding(8);
            crdSocios.Name = "crdSocios";
            crdSocios.Size = new Size(651, 544);
            crdSocios.TabIndex = 0;
            // 
            // lblSeccionSocios
            // 
            lblSeccionSocios.AutoSize = true;
            lblSeccionSocios.BackColor = Color.Transparent;
            lblSeccionSocios.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionSocios.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionSocios.Location = new Point(20, 16);
            lblSeccionSocios.Name = "lblSeccionSocios";
            lblSeccionSocios.Size = new Size(48, 20);
            lblSeccionSocios.TabIndex = 0;
            lblSeccionSocios.Text = "Socios";
            // 
            // lblBuscarDni
            // 
            lblBuscarDni.AutoSize = true;
            lblBuscarDni.BackColor = Color.Transparent;
            lblBuscarDni.Font = new Font("Segoe UI", 10F);
            lblBuscarDni.ForeColor = Color.FromArgb(75, 85, 99);
            lblBuscarDni.Location = new Point(20, 52);
            lblBuscarDni.Name = "lblBuscarDni";
            lblBuscarDni.Size = new Size(208, 20);
            lblBuscarDni.TabIndex = 1;
            lblBuscarDni.Text = "DNI (búsqueda incremental)";
            // 
            // txtBuscarDni
            // 
            txtBuscarDni.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarDni.ForeColor = Color.FromArgb(31, 41, 55);
            txtBuscarDni.Location = new Point(20, 74);
            txtBuscarDni.Name = "txtBuscarDni";
            txtBuscarDni.Size = new Size(300, 27);
            txtBuscarDni.TabIndex = 2;
            txtBuscarDni.TextChanged += txtBuscarDni_TextChanged;
            // 
            // dgvSocios
            // 
            dgvSocios.Columns.AddRange(new DataGridViewColumn[] { colSocNumero, colSocApellido, colSocNombre, colSocDni, colSocEstado });
            dgvSocios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSocios.Location = new Point(20, 116);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.Size = new Size(611, 408);
            dgvSocios.TabIndex = 3;
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
            // colSocEstado
            // 
            colSocEstado.FillWeight = 15F;
            colSocEstado.HeaderText = "Estado";
            colSocEstado.Name = "colSocEstado";
            colSocEstado.ReadOnly = true;
            dgvSocios.SelectionChanged += dgvSocios_SelectionChanged;
            // 
            // crdDatos
            // 
            crdDatos.Controls.Add(lblSeccionDatos);
            crdDatos.Controls.Add(lblNumero);
            crdDatos.Controls.Add(lblNombre);
            crdDatos.Controls.Add(txtNombre);
            crdDatos.Controls.Add(lblApellido);
            crdDatos.Controls.Add(txtApellido);
            crdDatos.Controls.Add(lblDni);
            crdDatos.Controls.Add(txtDni);
            crdDatos.Controls.Add(btnAlta);
            crdDatos.Controls.Add(btnModificar);
            crdDatos.Controls.Add(btnBaja);
            crdDatos.Controls.Add(btnReactivar);
            crdDatos.Controls.Add(btnLimpiar);
            crdDatos.Dock = DockStyle.Fill;
            crdDatos.Margin = new Padding(8);
            crdDatos.Name = "crdDatos";
            crdDatos.Size = new Size(393, 544);
            crdDatos.TabIndex = 1;
            // 
            // lblSeccionDatos
            // 
            lblSeccionDatos.AutoSize = true;
            lblSeccionDatos.BackColor = Color.Transparent;
            lblSeccionDatos.Font = new Font("Segoe UI Semibold", 12F);
            lblSeccionDatos.ForeColor = Color.FromArgb(31, 41, 55);
            lblSeccionDatos.Location = new Point(20, 16);
            lblSeccionDatos.Name = "lblSeccionDatos";
            lblSeccionDatos.Size = new Size(120, 20);
            lblSeccionDatos.TabIndex = 0;
            lblSeccionDatos.Text = "Datos del socio";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = false;
            lblNumero.BackColor = Color.Transparent;
            lblNumero.Font = new Font("Segoe UI", 11F);
            lblNumero.ForeColor = Color.FromArgb(31, 41, 55);
            lblNumero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNumero.Location = new Point(20, 50);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(353, 24);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Número de socio: — (se asigna al dar de alta)";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.ForeColor = Color.FromArgb(75, 85, 99);
            lblNombre.Location = new Point(20, 90);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(48, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.FromArgb(31, 41, 55);
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(20, 112);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(353, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Segoe UI", 10F);
            lblApellido.ForeColor = Color.FromArgb(75, 85, 99);
            lblApellido.Location = new Point(20, 152);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(64, 20);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.ForeColor = Color.FromArgb(31, 41, 55);
            txtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtApellido.Location = new Point(20, 174);
            txtApellido.MaxLength = 50;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(353, 27);
            txtApellido.TabIndex = 5;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.Transparent;
            lblDni.Font = new Font("Segoe UI", 10F);
            lblDni.ForeColor = Color.FromArgb(75, 85, 99);
            lblDni.Location = new Point(20, 214);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(128, 20);
            lblDni.TabIndex = 6;
            lblDni.Text = "DNI (sin puntos)";
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.ForeColor = Color.FromArgb(31, 41, 55);
            txtDni.Location = new Point(20, 236);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(170, 27);
            txtDni.TabIndex = 7;
            // 
            // btnAlta
            // 
            btnAlta.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAlta.Icono = "\uE710";
            btnAlta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAlta.Location = new Point(20, 290);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(353, 40);
            btnAlta.TabIndex = 8;
            btnAlta.Text = "Dar de alta";
            btnAlta.Click += btnAlta_Click;
            // 
            // btnModificar
            // 
            btnModificar.Estilo = EstiloBoton.Secundario;
            btnModificar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnModificar.Icono = "\uE70F";
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnModificar.Location = new Point(20, 338);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(353, 40);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBaja
            // 
            btnBaja.Estilo = EstiloBoton.Peligro;
            btnBaja.Font = new Font("Segoe UI Semibold", 10.5F);
            btnBaja.Icono = "\uE74D";
            btnBaja.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBaja.Location = new Point(20, 386);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(353, 40);
            btnBaja.TabIndex = 10;
            btnBaja.Text = "Dar de baja";
            btnBaja.Click += btnBaja_Click;
            // 
            // btnReactivar
            // 
            btnReactivar.Estilo = EstiloBoton.Secundario;
            btnReactivar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnReactivar.Icono = "\uE8FB";
            btnReactivar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnReactivar.Location = new Point(20, 434);
            btnReactivar.Name = "btnReactivar";
            btnReactivar.Size = new Size(353, 40);
            btnReactivar.TabIndex = 11;
            btnReactivar.Text = "Reactivar";
            btnReactivar.Click += btnReactivar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Estilo = EstiloBoton.Secundario;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnLimpiar.Icono = "\uE894";
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiar.Location = new Point(20, 482);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(353, 40);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // pnlAcciones
            // 
            pnlAcciones.BackColor = Color.Transparent;
            pnlAcciones.Controls.Add(btnCerrar);
            pnlAcciones.FlowDirection = FlowDirection.RightToLeft;
            pnlAcciones.WrapContents = false;
            pnlAcciones.Dock = DockStyle.Fill;
            pnlAcciones.Margin = new Padding(8);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(400, 40);
            pnlAcciones.TabIndex = 2;
            // 
            // btnCerrar
            // 
            btnCerrar.Estilo = EstiloBoton.Secundario;
            btnCerrar.Font = new Font("Segoe UI Semibold", 10.5F);
            btnCerrar.Icono = "\uE8BB";
            btnCerrar.Margin = new Padding(12, 0, 0, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(140, 40);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormSocio
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSocio";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de socios";
            Load += FormSocio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            pnlAcciones.ResumeLayout(false);
            pnlAcciones.PerformLayout();
            crdDatos.ResumeLayout(false);
            crdDatos.PerformLayout();
            crdSocios.ResumeLayout(false);
            crdSocios.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TarjetaSGB crdSocios;
        private Label lblSeccionSocios;
        private Label lblBuscarDni;
        private TextBox txtBuscarDni;
        private GrillaSGB dgvSocios;
        private DataGridViewTextBoxColumn colSocNumero;
        private DataGridViewTextBoxColumn colSocApellido;
        private DataGridViewTextBoxColumn colSocNombre;
        private DataGridViewTextBoxColumn colSocDni;
        private DataGridViewTextBoxColumn colSocEstado;
        private TarjetaSGB crdDatos;
        private Label lblSeccionDatos;
        private Label lblNumero;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDni;
        private TextBox txtDni;
        private BotonSGB btnAlta;
        private BotonSGB btnModificar;
        private BotonSGB btnBaja;
        private BotonSGB btnReactivar;
        private BotonSGB btnLimpiar;
        private FlowLayoutPanel pnlAcciones;
        private BotonSGB btnCerrar;
    }
}
