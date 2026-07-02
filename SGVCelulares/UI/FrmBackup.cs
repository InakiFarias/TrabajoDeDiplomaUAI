using BLL;
using Servicio;

namespace UI
{
    public partial class FrmBackup : Form, IObservadorIdioma
    {
        BLL_Backup bll_backup;
        BLL_Idioma bll_idioma = new BLL_Idioma();
        public bool RestoreRealizado { get; private set; } = false;
        public FrmBackup()
        {
            InitializeComponent();
            bll_idioma.Suscribir(this);
            ActualizarIdioma();
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
                MessageBox.Show("Cerrando la sesión!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RestoreRealizado = true;
                this.Close();
            }
        }

        public void ActualizarIdioma()
        {
            this.Text = bll_idioma.Traducir("FrmBackup.Form");
            btnBackup.Text = bll_idioma.Traducir("FrmBackup.btnBackup");
            btnRestore.Text = bll_idioma.Traducir("FrmBackup.btnRestore");
            btnSalir.Text = bll_idioma.Traducir("FrmBackup.btnSalir");

        }
        private void btnSalir_Click(object sender, EventArgs e) => this.Close();
    }
}
