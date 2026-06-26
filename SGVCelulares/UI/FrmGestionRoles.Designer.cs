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
            label1 = new Label();
            tvNodosComposite = new TreeView();
            clbComponentes = new CheckedListBox();
            btnCrear = new Button();
            label2 = new Label();
            txtNombreFamilia = new TextBox();
            radRol = new RadioButton();
            radFamilia = new RadioButton();
            btnSalir = new Button();
            btnEliminarSeleccionados = new Button();
            label3 = new Label();
            label4 = new Label();
            cbxRoles = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 1;
            label1.Text = "Gestión de roles";
            // 
            // tvNodosComposite
            // 
            tvNodosComposite.Location = new Point(299, 81);
            tvNodosComposite.Name = "tvNodosComposite";
            tvNodosComposite.Size = new Size(257, 238);
            tvNodosComposite.TabIndex = 20;
            // 
            // clbComponentes
            // 
            clbComponentes.FormattingEnabled = true;
            clbComponentes.Location = new Point(25, 81);
            clbComponentes.Name = "clbComponentes";
            clbComponentes.Size = new Size(257, 238);
            clbComponentes.TabIndex = 21;
            clbComponentes.ItemCheck += clbComponentes_ItemCheck;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(572, 140);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(149, 33);
            btnCrear.TabIndex = 22;
            btnCrear.Tag = "Crear Familia";
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(572, 93);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 24;
            label2.Text = "Nombre";
            // 
            // txtNombreFamilia
            // 
            txtNombreFamilia.Location = new Point(572, 111);
            txtNombreFamilia.Name = "txtNombreFamilia";
            txtNombreFamilia.Size = new Size(149, 23);
            txtNombreFamilia.TabIndex = 25;
            txtNombreFamilia.TextChanged += txtNombreFamilia_TextChanged;
            // 
            // radRol
            // 
            radRol.AutoSize = true;
            radRol.Checked = true;
            radRol.Location = new Point(581, 179);
            radRol.Name = "radRol";
            radRol.Size = new Size(42, 19);
            radRol.TabIndex = 26;
            radRol.TabStop = true;
            radRol.Text = "Rol";
            radRol.UseVisualStyleBackColor = true;
            // 
            // radFamilia
            // 
            radFamilia.AutoSize = true;
            radFamilia.Location = new Point(658, 179);
            radFamilia.Name = "radFamilia";
            radFamilia.Size = new Size(63, 19);
            radFamilia.TabIndex = 27;
            radFamilia.Text = "Familia";
            radFamilia.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(572, 286);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(149, 33);
            btnSalir.TabIndex = 29;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminarSeleccionados
            // 
            btnEliminarSeleccionados.Location = new Point(572, 236);
            btnEliminarSeleccionados.Name = "btnEliminarSeleccionados";
            btnEliminarSeleccionados.Size = new Size(149, 44);
            btnEliminarSeleccionados.TabIndex = 30;
            btnEliminarSeleccionados.Text = "Eliminar seleccionados";
            btnEliminarSeleccionados.UseVisualStyleBackColor = true;
            btnEliminarSeleccionados.Click += btnEliminarSeleccionados_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 57);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 31;
            label3.Text = "Componentes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(299, 57);
            label4.Name = "label4";
            label4.Size = new Size(153, 21);
            label4.TabIndex = 32;
            label4.Text = "Vista previa del rol";
            // 
            // cbxRoles
            // 
            cbxRoles.FormattingEnabled = true;
            cbxRoles.Location = new Point(299, 351);
            cbxRoles.Name = "cbxRoles";
            cbxRoles.Size = new Size(257, 23);
            cbxRoles.TabIndex = 33;
            cbxRoles.SelectedIndexChanged += cbxRoles_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(299, 333);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 34;
            label5.Text = "Roles";
            // 
            // FrmGestionRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 386);
            Controls.Add(label5);
            Controls.Add(cbxRoles);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnEliminarSeleccionados);
            Controls.Add(btnSalir);
            Controls.Add(radFamilia);
            Controls.Add(radRol);
            Controls.Add(txtNombreFamilia);
            Controls.Add(label2);
            Controls.Add(btnCrear);
            Controls.Add(clbComponentes);
            Controls.Add(tvNodosComposite);
            Controls.Add(label1);
            Name = "FrmGestionRoles";
            Text = "Gestión de roles";
            Load += FrmGestionRoles_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TreeView tvNodosComposite;
        private CheckedListBox clbComponentes;
        private Button btnCrear;
        private Label label2;
        private TextBox txtNombreFamilia;
        private RadioButton radRol;
        private RadioButton radFamilia;
        private Button btnSalir;
        private Button btnEliminarSeleccionados;
        private Label label3;
        private Label label4;
        private ComboBox cbxRoles;
        private Label label5;
    }
}