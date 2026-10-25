using System.Diagnostics;
using BE;
using QuestPDF.Fluent;
using QuestPDF.Helpers;

namespace UI
{
    // Genera los comprobantes del sistema en PDF, los guarda en Documentos\SGB\Comprobantes y los abre
    public static class ComprobantesPDF
    {
        private const string INSTITUCION = "Biblioteca Popular Rivadavia";

        public static void ComprobantePrestamo(BE_Comprobante comprobante)
        {
            BE_Prestamo prestamo = comprobante.Prestamo;
            string ruta = ObtenerRuta($"Comprobante_Prestamo_{comprobante.NumeroComprobante:D6}.pdf");

            Generar(ruta, "Comprobante de préstamo", comprobante.NumeroComprobante, comprobante.FechaEmision, col =>
            {
                col.Item().Text($"Préstamo N° {prestamo.NumeroPrestamo}");
                col.Item().Text($"Socio: {prestamo.Socio.Apellido}, {prestamo.Socio.Nombre} (N° {prestamo.Socio.NumeroSocio}) - DNI {prestamo.Socio.Dni}");
                col.Item().Text($"Fecha del préstamo: {prestamo.FechaPrestamo:dd/MM/yyyy}");

                col.Item().PaddingTop(10).Text("Ejemplares prestados").Bold();
                TablaEjemplares(col, prestamo.Ejemplares);

                col.Item().PaddingTop(15).Text($"Fecha de devolución prevista: {prestamo.FechaDevolucionPrevista:dd/MM/yyyy}").FontSize(13).Bold();
                col.Item().Text("La devolución posterior a esta fecha genera una multa por cada día de atraso.").FontSize(9);
            });
        }

        public static void ComprobantePago(BE_ComprobantePago comprobante)
        {
            string ruta = ObtenerRuta($"Comprobante_Pago_{comprobante.NumeroComprobante:D6}.pdf");

            Generar(ruta, "Comprobante de pago de multas", comprobante.NumeroComprobante, comprobante.FechaEmision, col =>
            {
                col.Item().Text($"Socio: {comprobante.Socio.Apellido}, {comprobante.Socio.Nombre} (N° {comprobante.Socio.NumeroSocio}) - DNI {comprobante.Socio.Dni}");

                col.Item().PaddingTop(10).Text("Multas abonadas").Bold();
                col.Item().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(1);
                        columns.RelativeColumn(1);
                        columns.RelativeColumn(2);
                        columns.RelativeColumn(1);
                        columns.RelativeColumn(2);
                    });
                    table.Header(header =>
                    {
                        header.Cell().Border(1).Padding(5).Text("N° multa").Bold();
                        header.Cell().Border(1).Padding(5).Text("Préstamo").Bold();
                        header.Cell().Border(1).Padding(5).Text("Fecha de generación").Bold();
                        header.Cell().Border(1).Padding(5).Text("Días de atraso").Bold();
                        header.Cell().Border(1).Padding(5).AlignRight().Text("Monto").Bold();
                    });
                    foreach (BE_Multa multa in comprobante.Multas)
                    {
                        table.Cell().Border(1).Padding(5).Text(multa.NumeroMulta.ToString());
                        table.Cell().Border(1).Padding(5).Text(multa.Devolucion.Prestamo.NumeroPrestamo.ToString());
                        table.Cell().Border(1).Padding(5).Text(multa.FechaGeneracion.ToString("dd/MM/yyyy"));
                        table.Cell().Border(1).Padding(5).Text(multa.DiasAtraso.ToString());
                        table.Cell().Border(1).Padding(5).AlignRight().Text($"$ {multa.Monto:N2}");
                    }
                });

                col.Item().PaddingTop(15).AlignRight().Text($"Total abonado: $ {comprobante.Total:N2}").FontSize(13).Bold();
            });
        }

        public static void ReciboDonacion(BE_ReciboDonacion recibo)
        {
            BE_Donacion donacion = recibo.Donacion;
            string ruta = ObtenerRuta($"Recibo_Donacion_{recibo.NumeroRecibo:D6}.pdf");

            Generar(ruta, "Recibo de donación", recibo.NumeroRecibo, recibo.FechaEmision, col =>
            {
                col.Item().Text($"Donación N° {donacion.NumeroDonacion}");
                col.Item().Text($"Socio donante: {donacion.Socio.Apellido}, {donacion.Socio.Nombre} (N° {donacion.Socio.NumeroSocio}) - DNI {donacion.Socio.Dni}");
                col.Item().Text($"Fecha de la donación: {donacion.FechaDonacion:dd/MM/yyyy}");

                col.Item().PaddingTop(10).Text("Ejemplares donados").Bold();
                TablaEjemplares(col, donacion.Ejemplares);

                col.Item().PaddingTop(15).Text($"La biblioteca agradece la donación de {donacion.Ejemplares.Count} ejemplar(es), que se incorporan a su acervo.");
            });
        }

        private static void Generar(string ruta, string titulo, int numero, DateTime fechaEmision, Action<ColumnDescriptor> contenido)
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
                        col.Item().Text(titulo).FontSize(13);
                        col.Item().Text($"N° {numero:D6} - Fecha de emisión: {fechaEmision:dd/MM/yyyy}").FontSize(10);
                        col.Item().PaddingTop(5).LineHorizontal(1);
                    });

                    page.Content().PaddingVertical(15).Column(col =>
                    {
                        col.Spacing(4);
                        contenido(col);
                    });

                    page.Footer().AlignCenter().Text("Sistema de Gestión de Biblioteca (SGB)").FontSize(8);
                });
            }).GeneratePdf(ruta);

            Process.Start(new ProcessStartInfo
            {
                FileName = ruta,
                UseShellExecute = true
            });
        }

        private static void TablaEjemplares(ColumnDescriptor col, List<BE_Ejemplar> ejemplares)
        {
            col.Item().Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(1);
                    columns.RelativeColumn(3);
                    columns.RelativeColumn(2);
                });
                table.Header(header =>
                {
                    header.Cell().Border(1).Padding(5).Text("Código").Bold();
                    header.Cell().Border(1).Padding(5).Text("Título").Bold();
                    header.Cell().Border(1).Padding(5).Text("Autor").Bold();
                });
                foreach (BE_Ejemplar ejemplar in ejemplares)
                {
                    table.Cell().Border(1).Padding(5).Text(ejemplar.CodigoEjemplar);
                    table.Cell().Border(1).Padding(5).Text(ejemplar.Libro.Titulo);
                    table.Cell().Border(1).Padding(5).Text(string.Join(", ", ejemplar.Libro.Autores.Select(a => a.Nombre + " " + a.Apellido)));
                }
            });
        }

        private static string ObtenerRuta(string nombreArchivo)
        {
            string carpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SGB", "Comprobantes");
            Directory.CreateDirectory(carpeta);
            return Path.Combine(carpeta, nombreArchivo);
        }
    }
}
