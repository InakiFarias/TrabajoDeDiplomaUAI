using System.Diagnostics;
using BE;
using QuestPDF.Fluent;
using QuestPDF.Helpers;

namespace UI
{
    // Genera los comprobantes del sistema en PDF, los guarda en Documentos\SGB\Comprobantes y los abre
    public static class ComprobantesPDF_351FI
    {
        private const string INSTITUCION = "Biblioteca Popular Rivadavia";

        public static void ComprobantePrestamo_351FI(BE_Comprobante_351FI comprobante_351FI)
        {
            BE_Prestamo_351FI prestamo = comprobante_351FI.Prestamo_351FI;
            string ruta = ObtenerRuta_351FI($"Comprobante_Prestamo_{comprobante_351FI.NumeroComprobante_351FI:D6}.pdf");

            Generar_351FI(ruta, "Comprobante de préstamo", comprobante_351FI.NumeroComprobante_351FI, comprobante_351FI.FechaEmision_351FI, col =>
            {
                col.Item().Text($"Préstamo N° {prestamo.NumeroPrestamo_351FI}");
                col.Item().Text($"Socio: {prestamo.Socio_351FI.Apellido_351FI}, {prestamo.Socio_351FI.Nombre_351FI} (N° {prestamo.Socio_351FI.NumeroSocio_351FI}) - DNI {prestamo.Socio_351FI.Dni_351FI}");
                col.Item().Text($"Fecha del préstamo: {prestamo.FechaPrestamo_351FI:dd/MM/yyyy}");

                col.Item().PaddingTop(10).Text("Ejemplares prestados").Bold();
                TablaEjemplares_351FI(col, prestamo.Ejemplares_351FI);

                col.Item().PaddingTop(15).Text($"Fecha de devolución prevista: {prestamo.FechaDevolucionPrevista_351FI:dd/MM/yyyy}").FontSize(13).Bold();
                col.Item().Text("La devolución posterior a esta fecha genera una multa por cada día de atraso.").FontSize(9);
            });
        }

        public static void ComprobanteDevolucion_351FI(BE_ComprobanteDevolucion_351FI comprobante_351FI)
        {
            BE_Devolucion_351FI devolucion = comprobante_351FI.Devolucion_351FI;
            BE_Prestamo_351FI prestamo = devolucion.Prestamo_351FI;
            string ruta = ObtenerRuta_351FI($"Comprobante_Devolucion_{comprobante_351FI.NumeroComprobante_351FI:D6}.pdf");

            Generar_351FI(ruta, "Comprobante de devolución", comprobante_351FI.NumeroComprobante_351FI, comprobante_351FI.FechaEmision_351FI, col =>
            {
                col.Item().Text($"Devolución N° {devolucion.NumeroDevolucion_351FI} - Préstamo N° {prestamo.NumeroPrestamo_351FI}");
                col.Item().Text($"Socio: {prestamo.Socio_351FI.Apellido_351FI}, {prestamo.Socio_351FI.Nombre_351FI} (N° {prestamo.Socio_351FI.NumeroSocio_351FI}) - DNI {prestamo.Socio_351FI.Dni_351FI}");
                col.Item().Text($"Fecha de devolución prevista: {prestamo.FechaDevolucionPrevista_351FI:dd/MM/yyyy}");
                col.Item().Text($"Fecha de devolución: {devolucion.FechaDevolucion_351FI:dd/MM/yyyy}");

                col.Item().PaddingTop(10).Text("Ejemplares devueltos").Bold();
                TablaEjemplares_351FI(col, prestamo.Ejemplares_351FI);

                if (devolucion.Multa_351FI != null)
                {
                    col.Item().PaddingTop(15).Text($"Multa por atraso: {devolucion.Multa_351FI.DiasAtraso_351FI} día(s) x $ {devolucion.Multa_351FI.MontoPorDia_351FI:N2} = $ {devolucion.Multa_351FI.Monto_351FI:N2}").FontSize(13).Bold();
                    col.Item().Text("La multa queda pendiente de pago. El socio no podrá realizar nuevos préstamos hasta abonarla.").FontSize(9);
                }
                else
                {
                    col.Item().PaddingTop(15).Text("Devolución en término: no se generó multa.");
                }
            });
        }

        public static void ComprobantePago_351FI(BE_ComprobantePago_351FI comprobante_351FI)
        {
            string ruta = ObtenerRuta_351FI($"Comprobante_Pago_{comprobante_351FI.NumeroComprobante_351FI:D6}.pdf");

            Generar_351FI(ruta, "Comprobante de pago de multas", comprobante_351FI.NumeroComprobante_351FI, comprobante_351FI.FechaEmision_351FI, col =>
            {
                col.Item().Text($"Socio: {comprobante_351FI.Socio_351FI.Apellido_351FI}, {comprobante_351FI.Socio_351FI.Nombre_351FI} (N° {comprobante_351FI.Socio_351FI.NumeroSocio_351FI}) - DNI {comprobante_351FI.Socio_351FI.Dni_351FI}");

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
                    foreach (BE_Multa_351FI multa in comprobante_351FI.Multas_351FI)
                    {
                        table.Cell().Border(1).Padding(5).Text(multa.NumeroMulta_351FI.ToString());
                        table.Cell().Border(1).Padding(5).Text(multa.Devolucion_351FI.Prestamo_351FI.NumeroPrestamo_351FI.ToString());
                        table.Cell().Border(1).Padding(5).Text(multa.FechaGeneracion_351FI.ToString("dd/MM/yyyy"));
                        table.Cell().Border(1).Padding(5).Text(multa.DiasAtraso_351FI.ToString());
                        table.Cell().Border(1).Padding(5).AlignRight().Text($"$ {multa.Monto_351FI:N2}");
                    }
                });

                col.Item().PaddingTop(15).AlignRight().Text($"Método de pago: {comprobante_351FI.MetodoPago_351FI}");
                col.Item().AlignRight().Text($"Total abonado: $ {comprobante_351FI.Total_351FI:N2}").FontSize(13).Bold();
            });
        }

        public static void ReciboDonacion_351FI(BE_ReciboDonacion_351FI recibo_351FI)
        {
            BE_Donacion_351FI donacion = recibo_351FI.Donacion_351FI;
            string ruta = ObtenerRuta_351FI($"Recibo_Donacion_{recibo_351FI.NumeroRecibo_351FI:D6}.pdf");

            Generar_351FI(ruta, "Recibo de donación", recibo_351FI.NumeroRecibo_351FI, recibo_351FI.FechaEmision_351FI, col =>
            {
                col.Item().Text($"Donación N° {donacion.NumeroDonacion_351FI}");
                col.Item().Text($"Socio donante: {donacion.Socio_351FI.Apellido_351FI}, {donacion.Socio_351FI.Nombre_351FI} (N° {donacion.Socio_351FI.NumeroSocio_351FI}) - DNI {donacion.Socio_351FI.Dni_351FI}");
                col.Item().Text($"Fecha de la donación: {donacion.FechaDonacion_351FI:dd/MM/yyyy}");

                col.Item().PaddingTop(10).Text("Ejemplares donados").Bold();
                TablaEjemplares_351FI(col, donacion.Ejemplares_351FI);

                col.Item().PaddingTop(15).Text($"La biblioteca agradece la donación de {donacion.Ejemplares_351FI.Count} ejemplar(es), que se incorporan a su acervo.");
            });
        }

        private static void Generar_351FI(string ruta_351FI, string titulo_351FI, int numero_351FI, DateTime fechaEmision_351FI, Action<ColumnDescriptor> contenido_351FI)
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
                        col.Item().Text(titulo_351FI).FontSize(13);
                        col.Item().Text($"N° {numero_351FI:D6} - Fecha de emisión: {fechaEmision_351FI:dd/MM/yyyy}").FontSize(10);
                        col.Item().PaddingTop(5).LineHorizontal(1);
                    });

                    page.Content().PaddingVertical(15).Column(col =>
                    {
                        col.Spacing(4);
                        contenido_351FI(col);
                    });

                    page.Footer().AlignCenter().Text("Sistema de Gestión de Biblioteca (SGB)").FontSize(8);
                });
            }).GeneratePdf(ruta_351FI);

            Process.Start(new ProcessStartInfo
            {
                FileName = ruta_351FI,
                UseShellExecute = true
            });
        }

        private static void TablaEjemplares_351FI(ColumnDescriptor col_351FI, List<BE_Ejemplar_351FI> ejemplares_351FI)
        {
            col_351FI.Item().Table(table =>
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
                foreach (BE_Ejemplar_351FI ejemplar in ejemplares_351FI)
                {
                    table.Cell().Border(1).Padding(5).Text(ejemplar.CodigoEjemplar_351FI);
                    table.Cell().Border(1).Padding(5).Text(ejemplar.Libro_351FI.Titulo_351FI);
                    table.Cell().Border(1).Padding(5).Text(string.Join(", ", ejemplar.Libro_351FI.Autores_351FI.Select(a => a.Nombre_351FI + " " + a.Apellido_351FI)));
                }
            });
        }

        private static string ObtenerRuta_351FI(string nombreArchivo_351FI)
        {
            string carpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SGB", "Comprobantes");
            Directory.CreateDirectory(carpeta);
            return Path.Combine(carpeta, nombreArchivo_351FI);
        }
    }
}
