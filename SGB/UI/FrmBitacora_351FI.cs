using QuestPDF.Fluent;
using System.Data;
using System.Diagnostics;
using Servicio;
using BLL.BLL_SER;

namespace UI
{
    public partial class FrmBitacora_351FI : Form, IObservadorIdioma_351FI
    {
        BLL_Bitacora_351FI bll_bitacora_351FI;
        BLL_Usuario_351FI bll_usuario_351FI;
        BLL_Idioma_351FI bll_idioma_351FI = new BLL_Idioma_351FI();

        private readonly Dictionary<string, string[]> eventosPorModulo_351FI =
        new Dictionary<string, string[]>
        {
            {
                "Usuarios",
                new[]
                {
                    "Login",
                    "Cambiar clave",
                    "Logout",
                    "Crear usuario",
                    "Desbloquear usuario",
                    "Modificar usuario",
                    "Activar usuario",
                    "Desactivar usuario",
                    "Cambiar idioma"
                }
            },
            {
                "Roles",
                new[]
                {
                    "Crear rol",
                    "Modificar rol",
                    "Borrar rol",
                    "Crear familia",
                    "Borrar familia"
                }
            },
            {
                "Bitácora",
                new[]
                {
                    "Auditar bitácora"
                }
            }

        };

        public FrmBitacora_351FI()
        {
            InitializeComponent();
            bll_idioma_351FI.Suscribir_351FI(this);
            ActualizarIdioma_351FI();
        }

        private void FrmBitacora_351FI_Load(object sender_351FI, EventArgs e_351FI)
        {
            bll_bitacora_351FI = new BLL_Bitacora_351FI();
            bll_usuario_351FI = new BLL_Usuario_351FI();
            grillaBitacora_351FI.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaBitacora_351FI.MultiSelect = false;
            grillaBitacora_351FI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtpFechaInicio_351FI.MaxDate = DateTime.Today;
            dtpFechaFin_351FI.MaxDate = DateTime.Today;

            cbxCriticidad_351FI.Items.AddRange(new string[] { "Alta", "Media", "Baja" });
            MostrarTodosLosEventos_351FI();
            txtNombre_351FI.ReadOnly = true;
            txtApellido_351FI.ReadOnly = true;
            Mostrar_351FI(grillaBitacora_351FI, bll_bitacora_351FI.ConsultarParaGrilla3Dias_351FI());
            ActualizarTxt_351FI();
            SER_Usuario_351FI usuario = SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI;
            btnImprimirBitacora_351FI.Enabled = usuario.Rol_351FI.TienePermiso_351FI("Exportar Bitácora");
        }

        private void MostrarTodosLosEventos_351FI()
        {
            cbxModulo_351FI.Items.AddRange(new string[] { "Usuarios", "Roles", "Bitácora" });
            cbxEvento_351FI.Items.AddRange(new string[] {
                "Login", "Cambiar clave", "Logout", "Crear usuario", "Desbloquear usuario", "Modificar usuario", "Activar Usuario", "Desactivar Usuario", "Cambiar idioma",
                "Crear rol", "Modificar rol", "Borrar rol", "Crear familia", "Borrar familia",
                "Auditar bitácora"
            });
        }

        private void ActualizarTxt_351FI()
        {
            try
            {
                if (grillaBitacora_351FI.SelectedRows.Count == 0)
                    return;

                if (grillaBitacora_351FI.SelectedRows[0].Cells["Usuario"].Value == null)
                    return;

                string login = grillaBitacora_351FI.SelectedRows[0].Cells["Usuario"].Value.ToString();

                SER_Usuario_351FI us = bll_bitacora_351FI.ConsultarPorNombreUsuario_351FI(login);

                if (us == null)
                    return;

                txtNombre_351FI.Text = us.Nombre_351FI;
                txtApellido_351FI.Text = us.Apellido_351FI;
            }
            catch
            {

            }
        }
        private void Mostrar_351FI(DataGridView grilla_351FI, object datos_351FI)
        {
            grilla_351FI.DataSource = null;
            grilla_351FI.DataSource = datos_351FI;
            TraducirColumnas_351FI(grilla_351FI);
        }

        private void TraducirColumnas_351FI(DataGridView grilla_351FI)
        {
            if (grilla_351FI.Columns.Count == 0) return;

            grilla_351FI.Columns["Usuario"].HeaderText = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.colUsuario");
            grilla_351FI.Columns["Fecha"].HeaderText = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.colFecha");
            grilla_351FI.Columns["Hora"].HeaderText = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.colHora");
            grilla_351FI.Columns["Modulo"].HeaderText = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.colModulo");
            grilla_351FI.Columns["Evento"].HeaderText = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.colEvento");
            grilla_351FI.Columns["Criticidad"].HeaderText = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.colCriticidad");
        }
        private void btnSalir_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            this.Close();
        }

        private void btnAplicar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                string nombreUsuario = txtNombreUsuario_351FI.Text;
                string modulo = cbxModulo_351FI.SelectedItem?.ToString();
                string evento = cbxEvento_351FI.SelectedItem?.ToString();
                int? criticidad = cbxCriticidad_351FI.SelectedIndex >= 0 ? (int?)cbxCriticidad_351FI.SelectedIndex + 1 : null;
                DateTime? fechaInicio = dtpFechaInicio_351FI.Value.Date;
                DateTime? fechaFin = dtpFechaFin_351FI.Value.Date.AddDays(1).AddTicks(-1);
                if (fechaInicio > fechaFin) throw new Exception("La fecha de inicio no puede ser mayor a la fecha de fin!!");
                Mostrar_351FI(grillaBitacora_351FI, bll_bitacora_351FI.ConsultarFiltradoBitacora_351FI(nombreUsuario, modulo, evento, criticidad, fechaInicio, fechaFin));
                if (grillaBitacora_351FI.Rows.Count == 0)
                {
                    txtApellido_351FI.Text = "";
                    txtNombre_351FI.Text = "";
                }
                else
                {
                    ActualizarTxt_351FI();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                txtNombreUsuario_351FI.Clear();
                cbxCriticidad_351FI.SelectedIndex = -1;
                cbxEvento_351FI.SelectedIndex = -1;
                cbxModulo_351FI.SelectedIndex = -1;
                dtpFechaFin_351FI.Value = DateTime.Today;
                dtpFechaInicio_351FI.Value = DateTime.Today;
                Mostrar_351FI(grillaBitacora_351FI, bll_bitacora_351FI.ConsultarParaGrilla3Dias_351FI());
                cbxModulo_351FI.Items.Clear(); cbxEvento_351FI.Items.Clear();
                MostrarTodosLosEventos_351FI();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void grillaBitacora_351FI_SelectionChanged(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (grillaBitacora_351FI.Rows.Count > 0) ActualizarTxt_351FI();
            }
            catch (Exception) { }
        }

        private void cbxModulo_351FI_SelectedIndexChanged(object sender_351FI, EventArgs e_351FI)
        {
            cbxEvento_351FI.Items.Clear();
            if (cbxModulo_351FI.SelectedItem != null && eventosPorModulo_351FI.ContainsKey(cbxModulo_351FI.SelectedItem.ToString()))
            {
                cbxEvento_351FI.Items.AddRange(eventosPorModulo_351FI[cbxModulo_351FI.SelectedItem.ToString()]);
            }

            cbxEvento_351FI.SelectedIndex = -1;
        }

        private void btnImprimirBitacora_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (grillaBitacora_351FI.Rows.Count == 0) throw new Exception("No hay registros para imprimir!");

                var columnasVisibles = grillaBitacora_351FI.Columns
                                       .Cast<DataGridViewColumn>()
                                       .Where(c => c.Visible)
                                       .ToList();
                var filas = grillaBitacora_351FI.Rows
                            .Cast<DataGridViewRow>()
                            .Where(f => !f.IsNewRow)
                            .ToList();

                using SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveDialog.FileName = $"Bitacora_{DateTime.Now:ddMMyyyy_HHmmss}.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    GuardarPdf_351FI(columnasVisibles, filas, saveDialog);
                    AbrirPdf_351FI(saveDialog.FileName);
                    MessageBox.Show("PDF generado correctamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GuardarPdf_351FI(List<DataGridViewColumn> columnasVisibles_351FI, List<DataGridViewRow> filas_351FI, SaveFileDialog saveDialog_351FI)
        {
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(20);
                    page.Header()
                        .Text("Reporte de Bitácora")
                        .FontSize(18)
                        .Bold();

                    page.Content().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            foreach (var columna in columnasVisibles_351FI)
                                columns.RelativeColumn();
                        });
                        table.Header(header =>
                        {
                            foreach (var columna in columnasVisibles_351FI)
                            {
                                header.Cell()
                                    .Border(1)
                                    .Padding(5)
                                    .Text(columna.HeaderText)
                                    .Bold();
                            }
                        });
                        foreach (var fila in filas_351FI)
                        {
                            foreach (var columna in columnasVisibles_351FI)
                            {
                                string valor =
                                    fila.Cells[columna.Index].Value?.ToString() ?? "";

                                table.Cell()
                                    .Border(1)
                                    .Padding(5)
                                    .Text(valor);
                            }
                        }
                    });
                });
            }).GeneratePdf(saveDialog_351FI.FileName);
        }
        private void AbrirPdf_351FI(string ruta_351FI)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = ruta_351FI,
                UseShellExecute = true
            });
        }
        public void ActualizarIdioma_351FI()
        {
            this.Text = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.Form");
            lblTitulo_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.lblTitulo_351FI");
            lblNombre_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.lblNombre_351FI");
            lblApellido_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.lblApellido_351FI");
            lblLogin_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.lblLogin_351FI");
            lblModulo_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.lblModulo_351FI");
            lblFechaInicio_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.lblFechaInicio_351FI");
            lblEvento_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.lblEvento_351FI");
            lblFechaFin_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.lblFechaFin_351FI");
            lblCriticidad_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.lblCriticidad_351FI");
            btnImprimirBitacora_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.btnImprimirBitacora_351FI");
            btnAplicar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.btnAplicar_351FI");
            btnLimpiar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.btnLimpiar_351FI");
            btnSalir_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmBitacora_351FI.btnSalir_351FI");
            TraducirColumnas_351FI(grillaBitacora_351FI);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma_351FI.Desuscribir_351FI(this);
            base.OnFormClosed(e);
        }
    }
}
