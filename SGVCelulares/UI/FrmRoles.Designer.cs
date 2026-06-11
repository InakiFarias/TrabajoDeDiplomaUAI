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
            ((System.ComponentModel.ISupportInitialize)grillaPermisos).BeginInit();
            SuspendLayout();
            // 
            // grillaPermisos
            // 
            grillaPermisos.AllowUserToAddRows = false;
            grillaPermisos.AllowUserToDeleteRows = false;
            grillaPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaPermisos.Location = new Point(45, 37);
            grillaPermisos.Name = "grillaPermisos";
            grillaPermisos.ReadOnly = true;
            grillaPermisos.Size = new Size(309, 193);
            grillaPermisos.TabIndex = 0;
            // 
            // FrmRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 456);
            Controls.Add(grillaPermisos);
            Name = "FrmRoles";
            Text = "Gestión de roles";
            Load += FrmRoles_Load;
            ((System.ComponentModel.ISupportInitialize)grillaPermisos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grillaPermisos;
    }
}