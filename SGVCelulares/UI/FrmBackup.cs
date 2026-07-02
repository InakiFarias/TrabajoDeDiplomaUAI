using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmBackup : Form
    {
        BLL_Backup bll_backup;
        public FrmBackup()
        {
            InitializeComponent();
        }
        private void FrmBackup_Load(object sender, EventArgs e)
        {
            bll_backup = new();
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Backup SQL Server (*.bak)|*.bak";
            saveDialog.DefaultExt = "bak";
            saveDialog.AddExtension = true;
            saveDialog.FileName = $"bkp_sgvcelulares_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = saveDialog.FileName;
                bll_backup.Backup(ruta);
                MessageBox.Show("Backup realizado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Backup SQL Server (*.bak)|*.bak";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                bll_backup.Restore(openDialog.FileName);
                MessageBox.Show("Restore realizado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
