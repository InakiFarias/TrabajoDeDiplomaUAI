using BLL;
using Servicio;
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
    public partial class FrmRepararInconsistencia : Form
    {
        BLL_DV bll_dv;
        BLL_Backup bll_backup;
        BLL_Idioma bll_idioma;
        private List<SER_Inconsistencia> inconsistencias;

        public FrmRepararInconsistencia()
        {
            InitializeComponent();
        }

        private void FrmRepararInconsistencia_Load(object sender, EventArgs e)
        {
            bll_dv = new BLL_DV();
            bll_backup = new BLL_Backup();
            bll_idioma = new BLL_Idioma();
            try
            {
                inconsistencias = bll_dv.ObtenerInconsistencias();
                grillaInconsistencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grillaInconsistencias.MultiSelect = false;
                grillaInconsistencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                MostrarGrilla();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarGrilla()
        {
            grillaInconsistencias.AutoGenerateColumns = false;
            grillaInconsistencias.Columns.Clear();

            grillaInconsistencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreTabla",
                HeaderText = "Tabla",
                DataPropertyName = "NombreTabla",
            });

            grillaInconsistencias.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdRegistro",
                HeaderText = "Id Registro",
                DataPropertyName = "IdRegistro",
            });

            grillaInconsistencias.DataSource = null; ; grillaInconsistencias.DataSource = inconsistencias;
        }


        private void btnRealizarRespaldo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = "Backup SQL Server (*.bak)|*.bak";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    string ruta = openDialog.FileName;
                    string nombreArchivo = Path.GetFileName(ruta);
                    DialogResult rdo = MessageBox.Show(bll_idioma.Traducir("FrmBackup.msgConfirmarRestore"), bll_idioma.Traducir("FrmBackup.msgConfirmarOperacion"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (rdo == DialogResult.Yes)
                    {
                        Cursor = Cursors.WaitCursor;
                        bll_backup.Restore(ruta);
                        Cursor = Cursors.Default;
                        MessageBox.Show(bll_idioma.Traducir("FrmBackup.msgOperacionExitosaRestore"), bll_idioma.Traducir("FrmBackup.msgInformacion"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(bll_idioma.Traducir("FrmBackup.msgError"), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestaurarDV_Click(object sender, EventArgs e)
        {
            bll_dv.RecalcularDV();
            MessageBox.Show("Los valores del DV fueron recalculados correctamente.", "Recalcular DV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void grillaInconsistencias_SelectionChanged(object sender, EventArgs e)
        {
            if (grillaInconsistencias.SelectedRows.Count == 0)
            {
                richTextBox1.Clear();
                return;
            }

            var seleccionada = (SER_Inconsistencia)grillaInconsistencias.SelectedRows[0].DataBoundItem;
            richTextBox1.Text = seleccionada.Mensaje;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
