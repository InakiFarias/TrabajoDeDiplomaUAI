using BLL.BLL_SER;
using Servicio;

namespace UI
{
    public partial class FrmBackup_351FI : Form, IObservadorIdioma_351FI
    {
        BLL_Backup_351FI bll_backup_351FI;
        BLL_Idioma_351FI bll_idioma_351FI = new BLL_Idioma_351FI();
        public bool RestoreRealizado_351FI { get; private set; } = false;
        public FrmBackup_351FI()
        {
            InitializeComponent();
            bll_idioma_351FI.Suscribir_351FI(this);
            ActualizarIdioma_351FI();
        }
        private void FrmBackup_351FI_Load(object sender_351FI, EventArgs e_351FI)
        {
            bll_backup_351FI = new();
            SER_Usuario_351FI usuario = SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI;
            btnBackup_351FI.Enabled = usuario.Rol_351FI.TienePermiso_351FI("Realizar Backup");
            btnRestore_351FI.Enabled = usuario.Rol_351FI.TienePermiso_351FI("Realizar Restore");
        }
        private void btnBackup_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Backup SQL Server (*.bak)|*.bak";
                saveDialog.DefaultExt = "bak";
                saveDialog.AddExtension = true;
                saveDialog.FileName = $"bkp_sgvcelulares_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string ruta = saveDialog.FileName;
                    bll_backup_351FI.Backup_351FI(ruta);
                    MessageBox.Show(bll_idioma_351FI.Traducir_351FI("FrmBackup_351FI.msgOperacionExitosaBackup"), bll_idioma_351FI.Traducir_351FI("FrmBackup_351FI.msgInformacion"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestore_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = "Backup SQL Server (*.bak)|*.bak";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    string ruta = openDialog.FileName;
                    string nombreArchivo = Path.GetFileName(ruta);
                    DialogResult rdo = MessageBox.Show(bll_idioma_351FI.Traducir_351FI("FrmBackup_351FI.msgConfirmarRestore"), bll_idioma_351FI.Traducir_351FI("FrmBackup_351FI.msgConfirmarOperacion"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (rdo == DialogResult.Yes)
                    {
                        Cursor = Cursors.WaitCursor;
                        bll_backup_351FI.Restore_351FI(ruta);
                        Cursor = Cursors.Default;
                        MessageBox.Show(bll_idioma_351FI.Traducir_351FI("FrmBackup_351FI.msgOperacionExitosaRestore"), bll_idioma_351FI.Traducir_351FI("FrmBackup_351FI.msgInformacion"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RestoreRealizado_351FI = true;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(bll_idioma_351FI.Traducir_351FI("FrmBackup_351FI.msgError"), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarIdioma_351FI()
        {
            this.Text = bll_idioma_351FI.Traducir_351FI("FrmBackup_351FI.Form");
            btnBackup_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmBackup_351FI.btnBackup_351FI");
            btnRestore_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmBackup_351FI.btnRestore_351FI");
            btnSalir_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmBackup_351FI.btnSalir_351FI");
            lblTituloBackup_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmBackup_351FI.lblTituloBackup_351FI");
            lblAyudaBackup_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmBackup_351FI.lblAyudaBackup_351FI");

        }
        private void btnSalir_351FI_Click(object sender_351FI, EventArgs e_351FI) => this.Close();
    }
}
