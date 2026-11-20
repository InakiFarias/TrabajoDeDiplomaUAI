using BE;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using Servicio;

namespace BLL.BLL_NEG
{
    // CU-SER-20 y CU-SER-21: arma el reporte de cada requerimiento funcional con las tablas que arma la BLL de cada entidad
    // y lo exporta a PDF (A4 apaisado). El reporte no se persiste: el archivo queda en la ruta que elige el usuario.
    public class BLL_Reporte_351FI
    {
        private const string INSTITUCION = "Biblioteca Popular Rivadavia";

        BLL_Prestamo_351FI bll_prestamo_351FI;
        BLL_Devolucion_351FI bll_devolucion_351FI;
        BLL_Multa_351FI bll_multa_351FI;
        BLL_Donacion_351FI bll_donacion_351FI;
        public BLL_Reporte_351FI()
        {
            bll_prestamo_351FI = new BLL_Prestamo_351FI();
            bll_devolucion_351FI = new BLL_Devolucion_351FI();
            bll_multa_351FI = new BLL_Multa_351FI();
            bll_donacion_351FI = new BLL_Donacion_351FI();
        }

        // Reporte del RF-001: préstamos y devoluciones del período (CU-SER-20)
        public BE_Reporte_351FI ArmarReportePrestamosDevoluciones_351FI(DateTime desde_351FI, DateTime hasta_351FI)
        {
            BE_Reporte_351FI reporte = CrearReporte_351FI("Reporte de préstamos y devoluciones", desde_351FI, hasta_351FI);
            reporte.Tablas_351FI.Add(bll_prestamo_351FI.ArmarTablaReporte_351FI(desde_351FI, hasta_351FI));
            reporte.Tablas_351FI.Add(bll_devolucion_351FI.ArmarTablaReporte_351FI(desde_351FI, hasta_351FI));
            return reporte;
        }

        // Reporte del RF-002: multas y donaciones del período (CU-SER-21)
        public BE_Reporte_351FI ArmarReporteMultasDonaciones_351FI(DateTime desde_351FI, DateTime hasta_351FI)
        {
            BE_Reporte_351FI reporte = CrearReporte_351FI("Reporte de multas y donaciones", desde_351FI, hasta_351FI);
            reporte.Tablas_351FI.Add(bll_multa_351FI.ArmarTablaReporte_351FI(desde_351FI, hasta_351FI));
            reporte.Tablas_351FI.Add(bll_donacion_351FI.ArmarTablaReporte_351FI(desde_351FI, hasta_351FI));
            return reporte;
        }

        private BE_Reporte_351FI CrearReporte_351FI(string titulo_351FI, DateTime desde_351FI, DateTime hasta_351FI)
        {
            if (desde_351FI.Date > hasta_351FI.Date) throw new Exception("La fecha desde no puede ser posterior a la fecha hasta.");
            SER_Usuario_351FI usuario = SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI;
            return new BE_Reporte_351FI(titulo_351FI, DateTime.Now, usuario.NombreUsuario_351FI, desde_351FI.Date, hasta_351FI.Date);
        }

        // Genera el PDF del reporte en la ruta elegida por el usuario
        public void ExportarPdf_351FI(BE_Reporte_351FI reporte_351FI, string ruta_351FI)
        {
            if (reporte_351FI == null) throw new Exception("Primero debe generar la vista previa del reporte.");
            if (string.IsNullOrWhiteSpace(ruta_351FI)) throw new Exception("Debe indicar dónde guardar el archivo.");

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4.Landscape());
                    page.Margin(30);
                    page.DefaultTextStyle(x => x.FontSize(9));

                    page.Header().Column(col =>
                    {
                        col.Item().Text(INSTITUCION).FontSize(15).Bold();
                        col.Item().Text(reporte_351FI.Titulo_351FI).FontSize(12);
                        col.Item().Text($"Fecha de emisión: {reporte_351FI.FechaEmision_351FI:dd/MM/yyyy HH:mm} - Emitido por: {reporte_351FI.Usuario_351FI}");
                        col.Item().Text($"Período: desde {reporte_351FI.Desde_351FI:dd/MM/yyyy} hasta {reporte_351FI.Hasta_351FI:dd/MM/yyyy}");
                        col.Item().PaddingTop(5).LineHorizontal(1);
                    });

                    page.Content().PaddingVertical(10).Column(col =>
                    {
                        col.Spacing(12);
                        foreach (BE_TablaReporte_351FI tabla in reporte_351FI.Tablas_351FI)
                        {
                            col.Item().Column(seccion =>
                            {
                                seccion.Spacing(4);
                                seccion.Item().Text(tabla.Titulo_351FI).FontSize(11).Bold();
                                seccion.Item().Text(tabla.Resumen_351FI);
                                if (tabla.Filas_351FI.Count == 0)
                                {
                                    seccion.Item().Text("No hay registros en el período seleccionado.").Italic();
                                    return;
                                }
                                seccion.Item().Table(table =>
                                {
                                    table.ColumnsDefinition(columns =>
                                    {
                                        foreach (string columna in tabla.Columnas_351FI)
                                            columns.RelativeColumn();
                                    });
                                    table.Header(header =>
                                    {
                                        foreach (string columna in tabla.Columnas_351FI)
                                            header.Cell().Border(1).Padding(4).Text(columna).Bold();
                                    });
                                    foreach (string[] fila in tabla.Filas_351FI)
                                        foreach (string celda in fila)
                                            table.Cell().Border(1).Padding(4).Text(celda);
                                });
                            });
                        }
                    });

                    page.Footer().AlignCenter().Text(texto =>
                    {
                        texto.DefaultTextStyle(x => x.FontSize(8));
                        texto.Span("Sistema de Gestión de Biblioteca (SGB) - Página ");
                        texto.CurrentPageNumber();
                        texto.Span(" de ");
                        texto.TotalPages();
                    });
                });
            }).GeneratePdf(ruta_351FI);
        }
    }
}
