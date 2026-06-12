namespace UI
{
    partial class FrmRoles
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
            grillaPermisos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            grillaFamilias = new DataGridView();
            label3 = new Label();
            grillaRoles = new DataGridView();
            btnAgregarFamilia = new Button();
            btnBorrarFamilia = new Button();
            btnBorrarRol = new Button();
            btnAgregarRol = new Button();
            radPermisoAFamilia = new RadioButton();
            radPermisoARol = new RadioButton();
            radFamiliaARol = new RadioButton();
            groupBox1 = new GroupBox();
            radFamiliaAFamilia = new RadioButton();
            label4 = new Label();
            grillaOrigen = new DataGridView();
            label5 = new Label();
            grillaDestino = new DataGridView();
            btnQuitar = new Button();
            btnAsignar = new Button();
            tvNodosComposite = new TreeView();
            ((System.ComponentModel.ISupportInitialize)grillaPermisos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaFamilias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaRoles).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaOrigen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaDestino).BeginInit();
            SuspendLayout();
            // 
            // grillaPermisos
            // 
            grillaPermisos.AllowUserToAddRows = false;
            grillaPermisos.AllowUserToDeleteRows = false;
            grillaPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaPermisos.Location = new Point(25, 62);
            grillaPermisos.Name = "grillaPermisos";
            grillaPermisos.ReadOnly = true;
            grillaPermisos.Size = new Size(309, 193);
            grillaPermisos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 1;
            label1.Text = "PERMISOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(366, 34);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 3;
            label2.Text = "FAMILIAS";
            // 
            // grillaFamilias
            // 
            grillaFamilias.AllowUserToAddRows = false;
            grillaFamilias.AllowUserToDeleteRows = false;
            grillaFamilias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaFamilias.Location = new Point(366, 62);
            grillaFamilias.Name = "grillaFamilias";
            grillaFamilias.ReadOnly = true;
            grillaFamilias.Size = new Size(309, 193);
            grillaFamilias.TabIndex = 2;
            grillaFamilias.SelectionChanged += grillaFamilias_SelectionChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(702, 34);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 5;
            label3.Text = "ROLES";
            // 
            // grillaRoles
            // 
            grillaRoles.AllowUserToAddRows = false;
            grillaRoles.AllowUserToDeleteRows = false;
            grillaRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaRoles.Location = new Point(702, 62);
            grillaRoles.Name = "grillaRoles";
            grillaRoles.ReadOnly = true;
            grillaRoles.Size = new Size(309, 193);
            grillaRoles.TabIndex = 4;
            // 
            // btnAgregarFamilia
            // 
            btnAgregarFamilia.Location = new Point(366, 261);
            btnAgregarFamilia.Name = "btnAgregarFamilia";
            btnAgregarFamilia.Size = new Size(75, 23);
            btnAgregarFamilia.TabIndex = 6;
            btnAgregarFamilia.Text = "Agregar";
            btnAgregarFamilia.UseVisualStyleBackColor = true;
            btnAgregarFamilia.Click += btnAgregarFamilia_Click;
            // 
            // btnBorrarFamilia
            // 
            btnBorrarFamilia.Location = new Point(447, 261);
            btnBorrarFamilia.Name = "btnBorrarFamilia";
            btnBorrarFamilia.Size = new Size(75, 23);
            btnBorrarFamilia.TabIndex = 7;
            btnBorrarFamilia.Text = "Borrar";
            btnBorrarFamilia.UseVisualStyleBackColor = true;
            btnBorrarFamilia.Click += btnBorrarFamilia_Click;
            // 
            // btnBorrarRol
            // 
            btnBorrarRol.Location = new Point(783, 261);
            btnBorrarRol.Name = "btnBorrarRol";
            btnBorrarRol.Size = new Size(75, 23);
            btnBorrarRol.TabIndex = 9;
            btnBorrarRol.Text = "Borrar";
            btnBorrarRol.UseVisualStyleBackColor = true;
            btnBorrarRol.Click += btnBorrarRol_Click;
            // 
            // btnAgregarRol
            // 
            btnAgregarRol.Location = new Point(702, 261);
            btnAgregarRol.Name = "btnAgregarRol";
            btnAgregarRol.Size = new Size(75, 23);
            btnAgregarRol.TabIndex = 8;
            btnAgregarRol.Text = "Agregar";
            btnAgregarRol.UseVisualStyleBackColor = true;
            btnAgregarRol.Click += btnAgregarRol_Click;
            // 
            // radPermisoAFamilia
            // 
            radPermisoAFamilia.AutoSize = true;
            radPermisoAFamilia.Location = new Point(30, 22);
            radPermisoAFamilia.Name = "radPermisoAFamilia";
            radPermisoAFamilia.Size = new Size(118, 19);
            radPermisoAFamilia.TabIndex = 10;
            radPermisoAFamilia.TabStop = true;
            radPermisoAFamilia.Text = "Permiso a Familia";
            radPermisoAFamilia.UseVisualStyleBackColor = true;
            radPermisoAFamilia.CheckedChanged += radPermisoAFamilia_CheckedChanged;
            // 
            // radPermisoARol
            // 
            radPermisoARol.AutoSize = true;
            radPermisoARol.Location = new Point(30, 47);
            radPermisoARol.Name = "radPermisoARol";
            radPermisoARol.Size = new Size(97, 19);
            radPermisoARol.TabIndex = 11;
            radPermisoARol.TabStop = true;
            radPermisoARol.Text = "Permiso a Rol";
            radPermisoARol.UseVisualStyleBackColor = true;
            radPermisoARol.CheckedChanged += radPermisoARol_CheckedChanged;
            // 
            // radFamiliaARol
            // 
            radFamiliaARol.AutoSize = true;
            radFamiliaARol.Location = new Point(30, 72);
            radFamiliaARol.Name = "radFamiliaARol";
            radFamiliaARol.Size = new Size(92, 19);
            radFamiliaARol.TabIndex = 12;
            radFamiliaARol.TabStop = true;
            radFamiliaARol.Text = "Familia a Rol";
            radFamiliaARol.UseVisualStyleBackColor = true;
            radFamiliaARol.CheckedChanged += radFamiliaARol_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radFamiliaAFamilia);
            groupBox1.Controls.Add(radPermisoARol);
            groupBox1.Controls.Add(radFamiliaARol);
            groupBox1.Controls.Add(radPermisoAFamilia);
            groupBox1.Location = new Point(48, 348);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 128);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de asignación";
            // 
            // radFamiliaAFamilia
            // 
            radFamiliaAFamilia.AutoSize = true;
            radFamiliaAFamilia.Location = new Point(30, 97);
            radFamiliaAFamilia.Name = "radFamiliaAFamilia";
            radFamiliaAFamilia.Size = new Size(113, 19);
            radFamiliaAFamilia.TabIndex = 13;
            radFamiliaAFamilia.TabStop = true;
            radFamiliaAFamilia.Text = "Familia a Familia";
            radFamiliaAFamilia.UseVisualStyleBackColor = true;
            radFamiliaAFamilia.CheckedChanged += radFamiliaAFamilia_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(274, 320);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 15;
            label4.Text = "ORIGEN";
            // 
            // grillaOrigen
            // 
            grillaOrigen.AllowUserToAddRows = false;
            grillaOrigen.AllowUserToDeleteRows = false;
            grillaOrigen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaOrigen.Location = new Point(274, 348);
            grillaOrigen.Name = "grillaOrigen";
            grillaOrigen.ReadOnly = true;
            grillaOrigen.Size = new Size(309, 193);
            grillaOrigen.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(702, 320);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 17;
            label5.Text = "DESTINO";
            // 
            // grillaDestino
            // 
            grillaDestino.AllowUserToAddRows = false;
            grillaDestino.AllowUserToDeleteRows = false;
            grillaDestino.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaDestino.Location = new Point(702, 348);
            grillaDestino.Name = "grillaDestino";
            grillaDestino.ReadOnly = true;
            grillaDestino.Size = new Size(309, 193);
            grillaDestino.TabIndex = 16;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(600, 424);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(75, 23);
            btnQuitar.TabIndex = 19;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(600, 395);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(75, 23);
            btnAsignar.TabIndex = 18;
            btnAsignar.Text = "Asignar";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // tvNodosComposite
            // 
            tvNodosComposite.Location = new Point(1043, 62);
            tvNodosComposite.Name = "tvNodosComposite";
            tvNodosComposite.Size = new Size(212, 479);
            tvNodosComposite.TabIndex = 20;
            // 
            // FrmRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 571);
            Controls.Add(tvNodosComposite);
            Controls.Add(btnQuitar);
            Controls.Add(btnAsignar);
            Controls.Add(label5);
            Controls.Add(grillaDestino);
            Controls.Add(label4);
            Controls.Add(grillaOrigen);
            Controls.Add(groupBox1);
            Controls.Add(btnBorrarRol);
            Controls.Add(btnAgregarRol);
            Controls.Add(btnBorrarFamilia);
            Controls.Add(btnAgregarFamilia);
            Controls.Add(label3);
            Controls.Add(grillaRoles);
            Controls.Add(label2);
            Controls.Add(grillaFamilias);
            Controls.Add(label1);
            Controls.Add(grillaPermisos);
            Name = "FrmRoles";
            Text = "Gestión de roles";
            Load += FrmRoles_Load;
            ((System.ComponentModel.ISupportInitialize)grillaPermisos).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaFamilias).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaRoles).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaOrigen).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaDestino).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaPermisos;
        private Label label1;
        private Label label2;
        private DataGridView grillaFamilias;
        private Label label3;
        private DataGridView grillaRoles;
        private Button btnAgregarFamilia;
        private Button btnBorrarFamilia;
        private Button btnBorrarRol;
        private Button btnAgregarRol;
        private RadioButton radPermisoAFamilia;
        private RadioButton radPermisoARol;
        private RadioButton radFamiliaARol;
        private GroupBox groupBox1;
        private Label label4;
        private DataGridView grillaOrigen;
        private Label label5;
        private DataGridView grillaDestino;
        private Button btnQuitar;
        private Button btnAsignar;
        private TreeView tvNodosComposite;
        private RadioButton radFamiliaAFamilia;
    }
}