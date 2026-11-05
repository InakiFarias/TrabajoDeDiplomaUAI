using BLL.BLL_SER;
using Servicio;

namespace UI
{
    public partial class FrmRepararInconsistencia_351FI : Form, IObservadorIdioma_351FI
    {
        BLL_DV_351FI bll_dv_351FI;
        BLL_Backup_351FI bll_backup_351FI;
        BLL_Idioma_351FI bll_idioma_351FI = new BLL_Idioma_351FI();
        BLL_Usuario_351FI bLL_Usuario_351FI;
        private List<SER_Inconsistencia_351FI> inconsistencias_351FI;

        public FrmRepararInconsistencia_351FI()
        {
            InitializeComponent();
            bll_idioma_351FI.Suscribir_351FI(this);
            ActualizarIdioma_351FI();
        }

        private void FrmRepararInconsistencia_351FI_Load(object sender_351FI, EventArgs e_351FI)
        {
            bll_dv_351FI = new BLL_DV_351FI();
            bll_backup_351FI = new BLL_Backup_351FI();
            bLL_Usuario_351FI = new BLL_Usuario_351FI();
            try
            {
                inconsistencias_351FI = bll_dv_351FI.ObtenerInconsistencias_351FI();
                grillaInconsistencias_351FI.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grillaInconsistencias_351FI.MultiSelect = false;
                grillaInconsistencias_351FI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                MostrarGrilla_351FI();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarGrilla_351FI()
        {
            grillaInconsistencias_351FI.AutoGenerateColumns = false;
            grillaInconsistencias_351FI.Columns.Clear();

            grillaInconsistencias_351FI.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreTabla",
                HeaderText = "Tabla",
                DataPropertyName = "NombreTabla_351FI",
            });

            grillaInconsistencias_351FI.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdRegistro",
                HeaderText = "Id Registro",
                DataPropertyName = "IdRegistro_351FI",
            });

            grillaInconsistencias_351FI.DataSource = null; ; 
            grillaInconsistencias_351FI.DataSource = inconsistencias_351FI;
            TraducirColumnas_351FI(grillaInconsistencias_351FI);
        }
        private void TraducirColumnas_351FI(DataGridView grilla_351FI)
        {
            if (grilla_351FI.Columns.Count == 0) return;

            grilla_351FI.Columns["NombreTabla"].HeaderText = bll_idioma_351FI.Traducir_351FI("FrmRepararInconsistencia_351FI.colNombreTabla");
            grilla_351FI.Columns["IdRegistro"].HeaderText = bll_idioma_351FI.Traducir_351FI("FrmRepararInconsistencia_351FI.colIdRegistro");
        }
        private void btnRealizarRespaldo_351FI_Click(object sender_351FI, EventArgs e_351FI)
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

        private void btnRestaurarDV_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            bll_dv_351FI.RecalcularDV_351FI();
            MessageBox.Show("Los valores del DV fueron recalculados correctamente.", "Recalcular DV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void grillaInconsistencias_351FI_SelectionChanged(object sender_351FI, EventArgs e_351FI)
        {
            if (grillaInconsistencias_351FI.SelectedRows.Count == 0)
            {
                richTextBox1_351FI.Clear();
                return;
            }

            SER_Inconsistencia_351FI seleccionada = (SER_Inconsistencia_351FI)grillaInconsistencias_351FI.SelectedRows[0].DataBoundItem;
            richTextBox1_351FI.Text = seleccionada.Mensaje_351FI;
        }
        public void ActualizarIdioma_351FI()
        {
            this.Text = bll_idioma_351FI.Traducir_351FI("FrmRepararInconsistencia_351FI.Form");
            btnRealizarRespaldo_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmRepararInconsistencia_351FI.btnRealizarRespaldo_351FI");
            btnRestaurarDV_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmRepararInconsistencia_351FI.btnRestaurarDV_351FI");
            lblTitulo_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmRepararInconsistencia_351FI.lblTitulo_351FI");
            lblDetalle_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmRepararInconsistencia_351FI.lblDetalle_351FI");
            btnSalir_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmRepararInconsistencia_351FI.btnSalir_351FI");
            TraducirColumnas_351FI(grillaInconsistencias_351FI);
        }

        private void btnSalir_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            this.Close();
            bll_idioma_351FI.Desuscribir_351FI(this);
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma_351FI.Desuscribir_351FI(this);
            bLL_Usuario_351FI.Logout_351FI();
            base.OnFormClosed(e);
        }
    }
}
