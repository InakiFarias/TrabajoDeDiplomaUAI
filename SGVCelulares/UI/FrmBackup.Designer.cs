namespace UI
{
    partial class FrmBackup
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
            btnBackup = new Button();
            btnRestore = new Button();
            SuspendLayout();
            // 
            // btnBackup
            // 
            btnBackup.Location = new Point(50, 63);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(119, 65);
            btnBackup.TabIndex = 0;
            btnBackup.Text = "BACKUP";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(50, 163);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(119, 65);
            btnRestore.TabIndex = 1;
            btnRestore.Text = "RESTORE";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // FrmBackup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 315);
            Controls.Add(btnRestore);
            Controls.Add(btnBackup);
            Name = "FrmBackup";
            Text = "FrmBackup";
            Load += FrmBackup_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBackup;
        private Button btnRestore;
    }
}