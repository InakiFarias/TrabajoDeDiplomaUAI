using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FrmGestionRoles
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
            crdCrear = new TarjetaSGB();
            label1 = new Label();
            label2 = new Label();
            txtNombreFamilia = new TextBox();
            radRol = new RadioButton();
            radFamilia = new RadioButton();
            label3 = new Label();
            clbComponentes = new CheckedListBox();
            btnCrear = new BotonSGB();
            crdVista = new TarjetaSGB();
            label4 = new Label();
            tvNodosComposite = new TreeView();
            btnEliminarSeleccionados = new BotonSGB();
            crdExistentes = new TarjetaSGB();
            label5 = new Label();
            cbxRoles = new ComboBox();
            btnBorrarRol = new BotonSGB();
            label6 = new Label();
            cbxFamilias = new ComboBox();
            btnBorrarFamilia = new BotonSGB();
            pnlAcciones = new FlowLayoutPanel();
            btnSalir = new BotonSGB();
            tlpPrincipal.SuspendLayout();
            crdCrear.SuspendLayout();
            crdVista.SuspendLayout();
            crdExistentes.SuspendLayout();
            pnlAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal.ColumnCount = 3;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpPrincipal.Controls.Add(crdCrear, 0, 0);
            tlpPrincipal.Controls.Add(crdVista, 1, 0);
            tlpPrincipal.Controls.Add(crdExistentes, 2, 0);
            tlpPrincipal.Controls.Add(pnlAcciones, 0, 1);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(12);
            tlpPrincipal.RowCount = 2;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 56.0F));
            tlpPrincipal.Size = new Size(1100, 640);
            tlpPrincipal.TabIndex = 0;
            tlpPrincipal.SetColumnSpan(pnlAcciones, 3);
            // 
            // crdCrear
            // 
            crdCrear.Controls.Add(label1);
            crdCrear.Controls.Add(label2);
            crdCrear.Controls.Add(txtNombreFamilia);
            crdCrear.Controls.Add(radRol);
            crdCrear.Controls.Add(radFamilia);
            crdCrear.Controls.Add(label3);
            crdCrear.Controls.Add(clbComponentes);
            crdCrear.Controls.Add(btnCrear);
            crdCrear.Dock = DockStyle.Fill;
            crdCrear.Margin = new Padding(8);
            crdCrear.Name = "crdCrear";
            crdCrear.Size = new Size(343, 544);
            crdCrear.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F);
            label1.ForeColor = Color.FromArgb(31, 41, 55);
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 0;
            label1.Text = "Crear rol o familia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(75, 85, 99);
            label2.Location = new Point(20, 52);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // txtNombreFamilia
            // 
            txtNombreFamilia.BorderStyle = BorderStyle.FixedSingle;
            txtNombreFamilia.ForeColor = Color.FromArgb(31, 41, 55);
            txtNombreFamilia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreFamilia.Location = new Point(20, 74);
            txtNombreFamilia.Name = "txtNombreFamilia";
            txtNombreFamilia.Size = new Size(303, 27);
            txtNombreFamilia.TabIndex = 2;
            txtNombreFamilia.TextChanged += txtNombreFamilia_TextChanged;
            // 
            // radRol
            // 
            radRol.AutoSize = true;
            radRol.BackColor = Color.Transparent;
            radRol.Checked = true;
            radRol.ForeColor = Color.FromArgb(31, 41, 55);
            radRol.Location = new Point(20, 112);
            radRol.Name = "radRol";
            radRol.Size = new Size(48, 24);
            radRol.TabIndex = 3;
            radRol.TabStop = true;
            radRol.Text = "Rol";
            radRol.UseVisualStyleBackColor = false;
            // 
            // radFamilia
            // 
            radFamilia.AutoSize = true;
            radFamilia.BackColor = Color.Transparent;
            radFamilia.ForeColor = Color.FromArgb(31, 41, 55);
            radFamilia.Location = new Point(100, 112);
            radFamilia.Name = "radFamilia";
            radFamilia.Size = new Size(80, 24);
            radFamilia.TabIndex = 4;
            radFamilia.Text = "Familia";
            radFamilia.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(75, 85, 99);
            label3.Location = new Point(20, 148);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 5;
            label3.Text = "Componentes";
            // 
            // clbComponentes
            // 
            clbComponentes.BorderStyle = BorderStyle.FixedSingle;
            clbComponentes.CheckOnClick = true;
            clbComponentes.ForeColor = Color.FromArgb(31, 41, 55);
            clbComponentes.FormattingEnabled = true;
            clbComponentes.IntegralHeight = false;
            clbComponentes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clbComponentes.Location = new Point(20, 170);
            clbComponentes.Name = "clbComponentes";
            clbComponentes.Size = new Size(303, 304);
            clbComponentes.TabIndex = 6;
            clbComponentes.ItemCheck += clbComponentes_ItemCheck;
            // 
            // btnCrear
            // 
            btnCrear.Font = new Font("Segoe UI Semibold", 10.5F);
            btnCrear.Icono = "\uE710";
            btnCrear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCrear.Location = new Point(20, 486);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(303, 40);
            btnCrear.TabIndex = 7;
            btnCrear.Text = "Crear";
            btnCrear.Click += btnCrear_Click;
            // 
            // crdVista
            // 
            crdVista.Controls.Add(label4);
            crdVista.Controls.Add(tvNodosComposite);
            crdVista.Controls.Add(btnEliminarSeleccionados);
            crdVista.Dock = DockStyle.Fill;
            crdVista.Margin = new Padding(8);
            crdVista.Name = "crdVista";
            crdVista.Size = new Size(342, 544);
            crdVista.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F);
            label4.ForeColor = Color.FromArgb(31, 41, 55);
            label4.Location = new Point(20, 16);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 0;
            label4.Text = "Vista previa del rol";
            // 
            // tvNodosComposite
            // 
            tvNodosComposite.BorderStyle = BorderStyle.FixedSingle;
            tvNodosComposite.ForeColor = Color.FromArgb(31, 41, 55);
            tvNodosComposite.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tvNodosComposite.Location = new Point(20, 52);
            tvNodosComposite.Name = "tvNodosComposite";
            tvNodosComposite.Size = new Size(302, 422);
            tvNodosComposite.TabIndex = 1;
            // 
            // btnEliminarSeleccionados
            // 
            btnEliminarSeleccionados.Estilo = EstiloBoton.Peligro;
            btnEliminarSeleccionados.Font = new Font("Segoe UI Semibold", 10.5F);
            btnEliminarSeleccionados.Icono = "\uE74D";
            btnEliminarSeleccionados.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEliminarSeleccionados.Location = new Point(20, 486);
            btnEliminarSeleccionados.Name = "btnEliminarSeleccionados";
            btnEliminarSeleccionados.Size = new Size(302, 40);
            btnEliminarSeleccionados.TabIndex = 2;
            btnEliminarSeleccionados.Text = "Eliminar seleccionados";
            btnEliminarSeleccionados.Click += btnEliminarSeleccionados_Click;
            // 
            // crdExistentes
            // 
            crdExistentes.Controls.Add(label5);
            crdExistentes.Controls.Add(cbxRoles);
            crdExistentes.Controls.Add(btnBorrarRol);
            crdExistentes.Controls.Add(label6);
            crdExistentes.Controls.Add(cbxFamilias);
            crdExistentes.Controls.Add(btnBorrarFamilia);
            crdExistentes.Dock = DockStyle.Fill;
            crdExistentes.Margin = new Padding(8);
            crdExistentes.Name = "crdExistentes";
            crdExistentes.Size = new Size(343, 544);
            crdExistentes.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F);
            label5.ForeColor = Color.FromArgb(31, 41, 55);
            label5.Location = new Point(20, 16);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 0;
            label5.Text = "Roles";
            // 
            // cbxRoles
            // 
            cbxRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRoles.ForeColor = Color.FromArgb(31, 41, 55);
            cbxRoles.FormattingEnabled = true;
            cbxRoles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxRoles.Location = new Point(20, 54);
            cbxRoles.Name = "cbxRoles";
            cbxRoles.Size = new Size(303, 28);
            cbxRoles.TabIndex = 1;
            cbxRoles.SelectedIndexChanged += cbxRoles_SelectedIndexChanged;
            // 
            // btnBorrarRol
            // 
            btnBorrarRol.Estilo = EstiloBoton.Peligro;
            btnBorrarRol.Font = new Font("Segoe UI Semibold", 10.5F);
            btnBorrarRol.Icono = "\uE74D";
            btnBorrarRol.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBorrarRol.Location = new Point(20, 94);
            btnBorrarRol.Name = "btnBorrarRol";
            btnBorrarRol.Size = new Size(303, 40);
            btnBorrarRol.TabIndex = 2;
            btnBorrarRol.Text = "Borrar";
            btnBorrarRol.Click += btnBorrarRol_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 12F);
            label6.ForeColor = Color.FromArgb(31, 41, 55);
            label6.Location = new Point(20, 168);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 3;
            label6.Text = "Familias";
            // 
            // cbxFamilias
            // 
            cbxFamilias.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFamilias.ForeColor = Color.FromArgb(31, 41, 55);
            cbxFamilias.FormattingEnabled = true;
            cbxFamilias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxFamilias.Location = new Point(20, 206);
            cbxFamilias.Name = "cbxFamilias";
            cbxFamilias.Size = new Size(303, 28);
            cbxFamilias.TabIndex = 4;
            cbxFamilias.SelectedIndexChanged += cbxFamilias_SelectedIndexChanged;
            // 
            // btnBorrarFamilia
            // 
            btnBorrarFamilia.Estilo = EstiloBoton.Peligro;
            btnBorrarFamilia.Font = new Font("Segoe UI Semibold", 10.5F);
            btnBorrarFamilia.Icono = "\uE74D";
            btnBorrarFamilia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBorrarFamilia.Location = new Point(20, 246);
            btnBorrarFamilia.Name = "btnBorrarFamilia";
            btnBorrarFamilia.Size = new Size(303, 40);
            btnBorrarFamilia.TabIndex = 5;
            btnBorrarFamilia.Text = "Borrar";
            btnBorrarFamilia.Click += btnBorrarFamilia_Click;
            // 
            // pnlAcciones
            // 
            pnlAcciones.BackColor = Color.Transparent;
            pnlAcciones.Controls.Add(btnSalir);
            pnlAcciones.FlowDirection = FlowDirection.RightToLeft;
            pnlAcciones.WrapContents = false;
            pnlAcciones.Dock = DockStyle.Fill;
            pnlAcciones.Margin = new Padding(8);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(400, 40);
            pnlAcciones.TabIndex = 3;
            // 
            // btnSalir
            // 
            btnSalir.Estilo = EstiloBoton.Secundario;
            btnSalir.Font = new Font("Segoe UI Semibold", 10.5F);
            btnSalir.Icono = "\uE8BB";
            btnSalir.Margin = new Padding(12, 0, 0, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 40);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmGestionRoles
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionRoles";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de roles";
            Load += FrmGestionRoles_Load;
            pnlAcciones.ResumeLayout(false);
            pnlAcciones.PerformLayout();
            crdExistentes.ResumeLayout(false);
            crdExistentes.PerformLayout();
            crdVista.ResumeLayout(false);
            crdVista.PerformLayout();
            crdCrear.ResumeLayout(false);
            crdCrear.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TarjetaSGB crdCrear;
        private Label label1;
        private Label label2;
        private TextBox txtNombreFamilia;
        private RadioButton radRol;
        private RadioButton radFamilia;
        private Label label3;
        private CheckedListBox clbComponentes;
        private BotonSGB btnCrear;
        private TarjetaSGB crdVista;
        private Label label4;
        private TreeView tvNodosComposite;
        private BotonSGB btnEliminarSeleccionados;
        private TarjetaSGB crdExistentes;
        private Label label5;
        private ComboBox cbxRoles;
        private BotonSGB btnBorrarRol;
        private Label label6;
        private ComboBox cbxFamilias;
        private BotonSGB btnBorrarFamilia;
        private FlowLayoutPanel pnlAcciones;
        private BotonSGB btnSalir;
    }
}
