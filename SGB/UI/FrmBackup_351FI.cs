using BLL.BLL_SER;
using Servicio;
using System.Security.AccessControl;
using System.Security.Principal;

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
                saveDialog.InitialDirectory = CarpetaBackups_351FI();
                saveDialog.FileName = $"bkp_sgb_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
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
                openDialog.InitialDirectory = CarpetaBackups_351FI();

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

            AyudaFormulario_351FI.Aplicar_351FI(this, bll_idioma_351FI);
        }
        private void btnSalir_351FI_Click(object sender_351FI, EventArgs e_351FI) => this.Close();
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma_351FI.Desuscribir_351FI(this);
            base.OnFormClosed(e);
        }

        // El .bak no lo escribe el usuario sino el servicio de SQL Server, que no tiene acceso a Documentos.
        // Por eso la carpeta de backups le da permiso de modificación al grupo SERVICE (S-1-5-6).
        private string CarpetaBackups_351FI()
        {
            string carpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SGB", "Backups");
            DirectoryInfo directorio = Directory.CreateDirectory(carpeta);
            try
            {
                DirectorySecurity seguridad = directorio.GetAccessControl();
                seguridad.AddAccessRule(new FileSystemAccessRule(
                    new SecurityIdentifier(WellKnownSidType.ServiceSid, null),
                    FileSystemRights.Modify,
                    InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                    PropagationFlags.None,
                    AccessControlType.Allow));
                directorio.SetAccessControl(seguridad);
            }
            catch (Exception)
            {
                // Si no se puede dar el permiso, el backup informa el error de SQL Server al intentar escribir
            }
            return carpeta;
        }
    }
}
