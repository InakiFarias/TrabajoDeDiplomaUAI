using System.Diagnostics;
using BE;
using QuestPDF.Fluent;
using QuestPDF.Helpers;

namespace BLL.BLL_NEG
{
    // CU-NEG-7: genera en PDF el comprobante que arma la BLL de cada operación (préstamo, devolución, pago o donación).
    // El comprobante no se persiste: se guarda el archivo en Documentos\SGB\Comprobantes y se abre para imprimirlo.
    public class BLL_Comprobante_351FI
    {
        private const string INSTITUCION = "Biblioteca Popular Rivadavia";

        public string Emitir_351FI(BE_Comprobante_351FI comprobante_351FI)
        {
            string ruta = ObtenerRuta_351FI(comprobante_351FI);
            Generar_351FI(ruta, comprobante_351FI);
            Abrir_351FI(ruta);
            return ruta;
        }

        private string ObtenerRuta_351FI(BE_Comprobante_351FI comprobante_351FI)
        {
            string carpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SGB", "Comprobantes");
            Directory.CreateDirectory(carpeta);
            return Path.Combine(carpeta, $"{comprobante_351FI.Titulo_351FI.Replace(" ", "_")}_{comprobante_351FI.Numero_351FI:D6}.pdf");
        }

        private void Generar_351FI(string ruta_351FI, BE_Comprobante_351FI comprobante_351FI)
        {
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(40);
                    page.DefaultTextStyle(x => x.FontSize(11));

                    page.Header().Column(col =>
                    {
                        col.Item().Text(INSTITUCION).FontSize(16).Bold();
                        col.Item().Text(comprobante_351FI.Titulo_351FI).FontSize(13);
                        col.Item().Text($"N° {comprobante_351FI.Numero_351FI:D6} - Fecha de emisión: {comprobante_351FI.FechaEmision_351FI:dd/MM/yyyy}").FontSize(10);
                        col.Item().PaddingTop(5).LineHorizontal(1);
                    });

                    page.Content().PaddingVertical(15).Column(col =>
                    {
                        col.Spacing(4);
                        BE_Socio_351FI socio = comprobante_351FI.Socio_351FI;
                        col.Item().Text($"Socio: {socio.Apellido_351FI}, {socio.Nombre_351FI} (N° {socio.NumeroSocio_351FI}) - DNI {socio.Dni_351FI}");
                        foreach (string dato in comprobante_351FI.Datos_351FI)
                            col.Item().Text(dato);

                        if (comprobante_351FI.Columnas_351FI.Length > 0)
                        {
                            col.Item().PaddingTop(10).Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    foreach (string columna in comprobante_351FI.Columnas_351FI)
                                        columns.RelativeColumn();
                                });
                                table.Header(header =>
                                {
                                    foreach (string columna in comprobante_351FI.Columnas_351FI)
                                        header.Cell().Border(1).Padding(5).Text(columna).Bold();
                                });
                                foreach (string[] fila in comprobante_351FI.Filas_351FI)
                                    foreach (string celda in fila)
                                        table.Cell().Border(1).Padding(5).Text(celda);
                            });
                        }

                        if (comprobante_351FI.Pie_351FI.Count > 0)
                        {
                            col.Item().PaddingTop(15).Text(comprobante_351FI.Pie_351FI[0]).FontSize(13).Bold();
                            foreach (string linea in comprobante_351FI.Pie_351FI.Skip(1))
                                col.Item().Text(linea).FontSize(9);
                        }
                    });

                    page.Footer().AlignCenter().Text("Sistema de Gestión de Biblioteca (SGB)").FontSize(8);
                });
            }).GeneratePdf(ruta_351FI);
        }

        private void Abrir_351FI(string ruta_351FI)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = ruta_351FI,
                UseShellExecute = true
            });
        }
    }
}
