using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FrmGestionRoles_351FI
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
            crdCrear_351FI = new TarjetaSGB_351FI();
            label1_351FI = new Label();
            label2_351FI = new Label();
            txtNombreFamilia_351FI = new TextBox();
            radRol_351FI = new RadioButton();
            radFamilia_351FI = new RadioButton();
            label3_351FI = new Label();
            clbComponentes_351FI = new CheckedListBox();
            btnCrear_351FI = new BotonSGB_351FI();
            crdVista_351FI = new TarjetaSGB_351FI();
            label4_351FI = new Label();
            tvNodosComposite_351FI = new TreeView();
            btnEliminarSeleccionados_351FI = new BotonSGB_351FI();
            crdExistentes_351FI = new TarjetaSGB_351FI();
            label5_351FI = new Label();
            cbxRoles_351FI = new ComboBox();
            btnBorrarRol_351FI = new BotonSGB_351FI();
            label6_351FI = new Label();
            cbxFamilias_351FI = new ComboBox();
            btnBorrarFamilia_351FI = new BotonSGB_351FI();
            pnlAcciones_351FI = new FlowLayoutPanel();
            btnSalir_351FI = new BotonSGB_351FI();
            tlpPrincipal_351FI.SuspendLayout();
            crdCrear_351FI.SuspendLayout();
            crdVista_351FI.SuspendLayout();
            crdExistentes_351FI.SuspendLayout();
            pnlAcciones_351FI.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal_351FI.BackColor = Color.FromArgb(244, 245, 247);
            tlpPrincipal_351FI.ColumnCount = 3;
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpPrincipal_351FI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpPrincipal_351FI.Controls.Add(crdCrear_351FI, 0, 0);
            tlpPrincipal_351FI.Controls.Add(crdVista_351FI, 1, 0);
            tlpPrincipal_351FI.Controls.Add(crdExistentes_351FI, 2, 0);
            tlpPrincipal_351FI.Controls.Add(pnlAcciones_351FI, 0, 1);
            tlpPrincipal_351FI.Dock = DockStyle.Fill;
            tlpPrincipal_351FI.Name = "tlpPrincipal_351FI";
            tlpPrincipal_351FI.Padding = new Padding(12);
            tlpPrincipal_351FI.RowCount = 2;
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            tlpPrincipal_351FI.RowStyles.Add(new RowStyle(SizeType.Absolute, 56.0F));
            tlpPrincipal_351FI.Size = new Size(1100, 640);
            tlpPrincipal_351FI.TabIndex = 0;
            tlpPrincipal_351FI.SetColumnSpan(pnlAcciones_351FI, 3);
            // 
            // crdCrear
            // 
            crdCrear_351FI.Controls.Add(label1_351FI);
            crdCrear_351FI.Controls.Add(label2_351FI);
            crdCrear_351FI.Controls.Add(txtNombreFamilia_351FI);
            crdCrear_351FI.Controls.Add(radRol_351FI);
            crdCrear_351FI.Controls.Add(radFamilia_351FI);
            crdCrear_351FI.Controls.Add(label3_351FI);
            crdCrear_351FI.Controls.Add(clbComponentes_351FI);
            crdCrear_351FI.Controls.Add(btnCrear_351FI);
            crdCrear_351FI.Dock = DockStyle.Fill;
            crdCrear_351FI.Margin = new Padding(8);
            crdCrear_351FI.Name = "crdCrear_351FI";
            crdCrear_351FI.Size = new Size(343, 544);
            crdCrear_351FI.TabIndex = 0;
            // 
            // label1
            // 
            label1_351FI.AutoSize = true;
            label1_351FI.BackColor = Color.Transparent;
            label1_351FI.Font = new Font("Segoe UI Semibold", 12F);
            label1_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            label1_351FI.Location = new Point(20, 16);
            label1_351FI.Name = "label1_351FI";
            label1_351FI.Size = new Size(152, 20);
            label1_351FI.TabIndex = 0;
            label1_351FI.Text = "Crear rol o familia";
            // 
            // label2
            // 
            label2_351FI.AutoSize = true;
            label2_351FI.BackColor = Color.Transparent;
            label2_351FI.Font = new Font("Segoe UI", 10F);
            label2_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            label2_351FI.Location = new Point(20, 52);
            label2_351FI.Name = "label2_351FI";
            label2_351FI.Size = new Size(48, 20);
            label2_351FI.TabIndex = 1;
            label2_351FI.Text = "Nombre";
            // 
            // txtNombreFamilia
            // 
            txtNombreFamilia_351FI.BorderStyle = BorderStyle.FixedSingle;
            txtNombreFamilia_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            txtNombreFamilia_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreFamilia_351FI.Location = new Point(20, 74);
            txtNombreFamilia_351FI.Name = "txtNombreFamilia_351FI";
            txtNombreFamilia_351FI.Size = new Size(303, 27);
            txtNombreFamilia_351FI.TabIndex = 2;
            txtNombreFamilia_351FI.TextChanged += txtNombreFamilia_351FI_TextChanged;
            // 
            // radRol
            // 
            radRol_351FI.AutoSize = true;
            radRol_351FI.BackColor = Color.Transparent;
            radRol_351FI.Checked = true;
            radRol_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            radRol_351FI.Location = new Point(20, 112);
            radRol_351FI.Name = "radRol_351FI";
            radRol_351FI.Size = new Size(48, 24);
            radRol_351FI.TabIndex = 3;
            radRol_351FI.TabStop = true;
            radRol_351FI.Text = "Rol";
            radRol_351FI.UseVisualStyleBackColor = false;
            // 
            // radFamilia
            // 
            radFamilia_351FI.AutoSize = true;
            radFamilia_351FI.BackColor = Color.Transparent;
            radFamilia_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            radFamilia_351FI.Location = new Point(100, 112);
            radFamilia_351FI.Name = "radFamilia_351FI";
            radFamilia_351FI.Size = new Size(80, 24);
            radFamilia_351FI.TabIndex = 4;
            radFamilia_351FI.Text = "Familia";
            radFamilia_351FI.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3_351FI.AutoSize = true;
            label3_351FI.BackColor = Color.Transparent;
            label3_351FI.Font = new Font("Segoe UI", 10F);
            label3_351FI.ForeColor = Color.FromArgb(75, 85, 99);
            label3_351FI.Location = new Point(20, 148);
            label3_351FI.Name = "label3_351FI";
            label3_351FI.Size = new Size(88, 20);
            label3_351FI.TabIndex = 5;
            label3_351FI.Text = "Componentes";
            // 
            // clbComponentes
            // 
            clbComponentes_351FI.BorderStyle = BorderStyle.FixedSingle;
            clbComponentes_351FI.CheckOnClick = true;
            clbComponentes_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            clbComponentes_351FI.FormattingEnabled = true;
            clbComponentes_351FI.IntegralHeight = false;
            clbComponentes_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clbComponentes_351FI.Location = new Point(20, 170);
            clbComponentes_351FI.Name = "clbComponentes_351FI";
            clbComponentes_351FI.Size = new Size(303, 304);
            clbComponentes_351FI.TabIndex = 6;
            clbComponentes_351FI.ItemCheck += clbComponentes_351FI_ItemCheck;
            // 
            // btnCrear
            // 
            btnCrear_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnCrear_351FI.Icono_351FI = "\uE710";
            btnCrear_351FI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCrear_351FI.Location = new Point(20, 486);
            btnCrear_351FI.Name = "btnCrear_351FI";
            btnCrear_351FI.Size = new Size(303, 40);
            btnCrear_351FI.TabIndex = 7;
            btnCrear_351FI.Text = "Crear";
            btnCrear_351FI.Click += btnCrear_351FI_Click;
            // 
            // crdVista
            // 
            crdVista_351FI.Controls.Add(label4_351FI);
            crdVista_351FI.Controls.Add(tvNodosComposite_351FI);
            crdVista_351FI.Controls.Add(btnEliminarSeleccionados_351FI);
            crdVista_351FI.Dock = DockStyle.Fill;
            crdVista_351FI.Margin = new Padding(8);
            crdVista_351FI.Name = "crdVista_351FI";
            crdVista_351FI.Size = new Size(342, 544);
            crdVista_351FI.TabIndex = 1;
            // 
            // label4
            // 
            label4_351FI.AutoSize = true;
            label4_351FI.BackColor = Color.Transparent;
            label4_351FI.Font = new Font("Segoe UI Semibold", 12F);
            label4_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            label4_351FI.Location = new Point(20, 16);
            label4_351FI.Name = "label4_351FI";
            label4_351FI.Size = new Size(160, 20);
            label4_351FI.TabIndex = 0;
            label4_351FI.Text = "Vista previa del rol";
            // 
            // tvNodosComposite
            // 
            tvNodosComposite_351FI.BorderStyle = BorderStyle.FixedSingle;
            tvNodosComposite_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            tvNodosComposite_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tvNodosComposite_351FI.Location = new Point(20, 52);
            tvNodosComposite_351FI.Name = "tvNodosComposite_351FI";
            tvNodosComposite_351FI.Size = new Size(302, 422);
            tvNodosComposite_351FI.TabIndex = 1;
            // 
            // btnEliminarSeleccionados
            // 
            btnEliminarSeleccionados_351FI.Estilo_351FI = EstiloBoton_351FI.Peligro;
            btnEliminarSeleccionados_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnEliminarSeleccionados_351FI.Icono_351FI = "\uE74D";
            btnEliminarSeleccionados_351FI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEliminarSeleccionados_351FI.Location = new Point(20, 486);
            btnEliminarSeleccionados_351FI.Name = "btnEliminarSeleccionados_351FI";
            btnEliminarSeleccionados_351FI.Size = new Size(302, 40);
            btnEliminarSeleccionados_351FI.TabIndex = 2;
            btnEliminarSeleccionados_351FI.Text = "Eliminar seleccionados";
            btnEliminarSeleccionados_351FI.Click += btnEliminarSeleccionados_351FI_Click;
            // 
            // crdExistentes
            // 
            crdExistentes_351FI.Controls.Add(label5_351FI);
            crdExistentes_351FI.Controls.Add(cbxRoles_351FI);
            crdExistentes_351FI.Controls.Add(btnBorrarRol_351FI);
            crdExistentes_351FI.Controls.Add(label6_351FI);
            crdExistentes_351FI.Controls.Add(cbxFamilias_351FI);
            crdExistentes_351FI.Controls.Add(btnBorrarFamilia_351FI);
            crdExistentes_351FI.Dock = DockStyle.Fill;
            crdExistentes_351FI.Margin = new Padding(8);
            crdExistentes_351FI.Name = "crdExistentes_351FI";
            crdExistentes_351FI.Size = new Size(343, 544);
            crdExistentes_351FI.TabIndex = 2;
            // 
            // label5
            // 
            label5_351FI.AutoSize = true;
            label5_351FI.BackColor = Color.Transparent;
            label5_351FI.Font = new Font("Segoe UI Semibold", 12F);
            label5_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            label5_351FI.Location = new Point(20, 16);
            label5_351FI.Name = "label5_351FI";
            label5_351FI.Size = new Size(40, 20);
            label5_351FI.TabIndex = 0;
            label5_351FI.Text = "Roles";
            // 
            // cbxRoles
            // 
            cbxRoles_351FI.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRoles_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            cbxRoles_351FI.FormattingEnabled = true;
            cbxRoles_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxRoles_351FI.Location = new Point(20, 54);
            cbxRoles_351FI.Name = "cbxRoles_351FI";
            cbxRoles_351FI.Size = new Size(303, 28);
            cbxRoles_351FI.TabIndex = 1;
            cbxRoles_351FI.SelectedIndexChanged += cbxRoles_351FI_SelectedIndexChanged;
            // 
            // btnBorrarRol
            // 
            btnBorrarRol_351FI.Estilo_351FI = EstiloBoton_351FI.Peligro;
            btnBorrarRol_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnBorrarRol_351FI.Icono_351FI = "\uE74D";
            btnBorrarRol_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBorrarRol_351FI.Location = new Point(20, 94);
            btnBorrarRol_351FI.Name = "btnBorrarRol_351FI";
            btnBorrarRol_351FI.Size = new Size(303, 40);
            btnBorrarRol_351FI.TabIndex = 2;
            btnBorrarRol_351FI.Text = "Borrar";
            btnBorrarRol_351FI.Click += btnBorrarRol_351FI_Click;
            // 
            // label6
            // 
            label6_351FI.AutoSize = true;
            label6_351FI.BackColor = Color.Transparent;
            label6_351FI.Font = new Font("Segoe UI Semibold", 12F);
            label6_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            label6_351FI.Location = new Point(20, 168);
            label6_351FI.Name = "label6_351FI";
            label6_351FI.Size = new Size(64, 20);
            label6_351FI.TabIndex = 3;
            label6_351FI.Text = "Familias";
            // 
            // cbxFamilias
            // 
            cbxFamilias_351FI.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFamilias_351FI.ForeColor = Color.FromArgb(31, 41, 55);
            cbxFamilias_351FI.FormattingEnabled = true;
            cbxFamilias_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxFamilias_351FI.Location = new Point(20, 206);
            cbxFamilias_351FI.Name = "cbxFamilias_351FI";
            cbxFamilias_351FI.Size = new Size(303, 28);
            cbxFamilias_351FI.TabIndex = 4;
            cbxFamilias_351FI.SelectedIndexChanged += cbxFamilias_351FI_SelectedIndexChanged;
            // 
            // btnBorrarFamilia
            // 
            btnBorrarFamilia_351FI.Estilo_351FI = EstiloBoton_351FI.Peligro;
            btnBorrarFamilia_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnBorrarFamilia_351FI.Icono_351FI = "\uE74D";
            btnBorrarFamilia_351FI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBorrarFamilia_351FI.Location = new Point(20, 246);
            btnBorrarFamilia_351FI.Name = "btnBorrarFamilia_351FI";
            btnBorrarFamilia_351FI.Size = new Size(303, 40);
            btnBorrarFamilia_351FI.TabIndex = 5;
            btnBorrarFamilia_351FI.Text = "Borrar";
            btnBorrarFamilia_351FI.Click += btnBorrarFamilia_351FI_Click;
            // 
            // pnlAcciones
            // 
            pnlAcciones_351FI.BackColor = Color.Transparent;
            pnlAcciones_351FI.Controls.Add(btnSalir_351FI);
            pnlAcciones_351FI.FlowDirection = FlowDirection.RightToLeft;
            pnlAcciones_351FI.WrapContents = false;
            pnlAcciones_351FI.Dock = DockStyle.Fill;
            pnlAcciones_351FI.Margin = new Padding(8);
            pnlAcciones_351FI.Name = "pnlAcciones_351FI";
            pnlAcciones_351FI.Size = new Size(400, 40);
            pnlAcciones_351FI.TabIndex = 3;
            // 
            // btnSalir
            // 
            btnSalir_351FI.Estilo_351FI = EstiloBoton_351FI.Secundario;
            btnSalir_351FI.Font = new Font("Segoe UI Semibold", 10.5F);
            btnSalir_351FI.Icono_351FI = "\uE8BB";
            btnSalir_351FI.Margin = new Padding(12, 0, 0, 0);
            btnSalir_351FI.Name = "btnSalir_351FI";
            btnSalir_351FI.Size = new Size(140, 40);
            btnSalir_351FI.TabIndex = 0;
            btnSalir_351FI.Text = "Salir";
            btnSalir_351FI.Click += btnSalir_351FI_Click;
            // 
            // FrmGestionRoles
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1100, 640);
            Controls.Add(tlpPrincipal_351FI);
            Font = new Font("Segoe UI", 11F);
            ForeColor = Color.FromArgb(31, 41, 55);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionRoles_351FI";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de roles";
            Load += FrmGestionRoles_351FI_Load;
            pnlAcciones_351FI.ResumeLayout(false);
            pnlAcciones_351FI.PerformLayout();
            crdExistentes_351FI.ResumeLayout(false);
            crdExistentes_351FI.PerformLayout();
            crdVista_351FI.ResumeLayout(false);
            crdVista_351FI.PerformLayout();
            crdCrear_351FI.ResumeLayout(false);
            crdCrear_351FI.PerformLayout();
            tlpPrincipal_351FI.ResumeLayout(false);
            tlpPrincipal_351FI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal_351FI;
        private TarjetaSGB_351FI crdCrear_351FI;
        private Label label1_351FI;
        private Label label2_351FI;
        private TextBox txtNombreFamilia_351FI;
        private RadioButton radRol_351FI;
        private RadioButton radFamilia_351FI;
        private Label label3_351FI;
        private CheckedListBox clbComponentes_351FI;
        private BotonSGB_351FI btnCrear_351FI;
        private TarjetaSGB_351FI crdVista_351FI;
        private Label label4_351FI;
        private TreeView tvNodosComposite_351FI;
        private BotonSGB_351FI btnEliminarSeleccionados_351FI;
        private TarjetaSGB_351FI crdExistentes_351FI;
        private Label label5_351FI;
        private ComboBox cbxRoles_351FI;
        private BotonSGB_351FI btnBorrarRol_351FI;
        private Label label6_351FI;
        private ComboBox cbxFamilias_351FI;
        private BotonSGB_351FI btnBorrarFamilia_351FI;
        private FlowLayoutPanel pnlAcciones_351FI;
        private BotonSGB_351FI btnSalir_351FI;
    }
}
