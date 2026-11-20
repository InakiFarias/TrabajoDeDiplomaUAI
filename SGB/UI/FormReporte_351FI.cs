using System.Data;
using System.Diagnostics;
using BE;
using BLL.BLL_NEG;
using BLL.BLL_SER;
using Servicio;

namespace UI
{
    // CU-SER-20 y CU-SER-21: vista previa y exportación a PDF de los reportes de préstamos y devoluciones, y de multas y donaciones
    public partial class FormReporte_351FI : Form, IObservadorIdioma_351FI
    {
        BLL_Idioma_351FI bll_idioma_351FI = new BLL_Idioma_351FI();
        BLL_Reporte_351FI bll_reporte_351FI;
        BE_Reporte_351FI? reporte_351FI;

        public FormReporte_351FI()
        {
            InitializeComponent();
            bll_idioma_351FI.Suscribir_351FI(this);
        }

        private void FormReporte_351FI_Load(object sender_351FI, EventArgs e_351FI)
        {
            bll_reporte_351FI = new BLL_Reporte_351FI();

            SER_Usuario_351FI usuario = SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI;
            btnReportePrestamos_351FI.Visible = usuario.Rol_351FI.TienePermiso_351FI("Generar Reporte Préstamos y Devoluciones");
            btnReporteMultas_351FI.Visible = usuario.Rol_351FI.TienePermiso_351FI("Generar Reporte Multas y Donaciones");

            // Al abrir se propone el último mes
            dtpFechaHasta_351FI.Value = DateTime.Today;
            dtpFechaDesde_351FI.Value = DateTime.Today.AddMonths(-1);
            dtpFechaDesde_351FI.ValueChanged += Periodo_ValueChanged_351FI;
            dtpFechaHasta_351FI.ValueChanged += Periodo_ValueChanged_351FI;

            LimpiarVista_351FI();
            ActualizarIdioma_351FI();
        }

        // ------------------------------------------------------------ Vista previa

        private void btnReportePrestamos_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            GenerarVista_351FI(() => bll_reporte_351FI.ArmarReportePrestamosDevoluciones_351FI(dtpFechaDesde_351FI.Value, dtpFechaHasta_351FI.Value));
        }

        private void btnReporteMultas_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            GenerarVista_351FI(() => bll_reporte_351FI.ArmarReporteMultasDonaciones_351FI(dtpFechaDesde_351FI.Value, dtpFechaHasta_351FI.Value));
        }

        private void GenerarVista_351FI(Func<BE_Reporte_351FI> armar_351FI)
        {
            try
            {
                reporte_351FI = armar_351FI();
                MostrarTabla_351FI(reporte_351FI.Tablas_351FI[0], lblTitulo1_351FI, lblResumen1_351FI, dgvTabla1_351FI);
                MostrarTabla_351FI(reporte_351FI.Tablas_351FI[1], lblTitulo2_351FI, lblResumen2_351FI, dgvTabla2_351FI);
                lblSeccionVista_351FI.Text = reporte_351FI.Titulo_351FI;
                btnExportar_351FI.Enabled = true;
            }
            catch (Exception ex)
            {
                LimpiarVista_351FI();
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarTabla_351FI(BE_TablaReporte_351FI tabla_351FI, Label titulo_351FI, Label resumen_351FI, DataGridView grilla_351FI)
        {
            DataTable datos = new DataTable();
            foreach (string columna in tabla_351FI.Columnas_351FI)
                datos.Columns.Add(columna);
            foreach (string[] fila in tabla_351FI.Filas_351FI)
                datos.Rows.Add(fila);

            titulo_351FI.Text = tabla_351FI.Titulo_351FI;
            resumen_351FI.Text = tabla_351FI.Resumen_351FI;
            grilla_351FI.DataSource = datos;
            grilla_351FI.ClearSelection();
        }

        private void LimpiarVista_351FI()
        {
            reporte_351FI = null;
            btnExportar_351FI.Enabled = false;
            lblSeccionVista_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormReporte_351FI.lblSeccionVista_351FI");
            lblTitulo1_351FI.Text = "";
            lblResumen1_351FI.Text = "";
            lblTitulo2_351FI.Text = "";
            lblResumen2_351FI.Text = "";
            dgvTabla1_351FI.DataSource = null;
            dgvTabla2_351FI.DataSource = null;
        }

        // Si cambia el período la vista previa deja de corresponder a lo que se exportaría
        private void Periodo_ValueChanged_351FI(object? sender_351FI, EventArgs e_351FI)
        {
            if (reporte_351FI != null) LimpiarVista_351FI();
        }

        // ------------------------------------------------------------ Exportación

        private void btnExportar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (reporte_351FI == null) throw new Exception("Primero debe generar la vista previa del reporte.");
                string? ruta = SeleccionarRuta_351FI();
                if (ruta == null) return;

                bll_reporte_351FI.ExportarPdf_351FI(reporte_351FI, ruta);
                AbrirArchivo_351FI(ruta);
                MessageBox.Show("El reporte se exportó correctamente.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string? SeleccionarRuta_351FI()
        {
            using SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.Filter = "Archivos PDF (*.pdf)|*.pdf";
            dialogo.FileName = $"{reporte_351FI.Titulo_351FI.Replace(" ", "_")}_{DateTime.Now:ddMMyyyy_HHmmss}.pdf";
            return dialogo.ShowDialog() == DialogResult.OK ? dialogo.FileName : null;
        }

        private void AbrirArchivo_351FI(string ruta_351FI)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = ruta_351FI,
                UseShellExecute = true
            });
        }

        private void btnCerrar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            this.Close();
        }

        // ------------------------------------------------------------ Idioma
        public void ActualizarIdioma_351FI()
        {
            this.Text = bll_idioma_351FI.Traducir_351FI("FormReporte_351FI.Form");
            lblSeccionFiltros_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormReporte_351FI.lblSeccionFiltros_351FI");
            lblFechaDesde_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormReporte_351FI.lblFechaDesde_351FI");
            lblFechaHasta_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormReporte_351FI.lblFechaHasta_351FI");
            btnReportePrestamos_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormReporte_351FI.btnReportePrestamos_351FI");
            btnReporteMultas_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormReporte_351FI.btnReporteMultas_351FI");
            btnExportar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormReporte_351FI.btnExportar_351FI");
            btnCerrar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormReporte_351FI.btnCerrar_351FI");
            if (reporte_351FI == null) lblSeccionVista_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormReporte_351FI.lblSeccionVista_351FI");
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma_351FI.Desuscribir_351FI(this);
            base.OnFormClosed(e);
        }
    }
}
