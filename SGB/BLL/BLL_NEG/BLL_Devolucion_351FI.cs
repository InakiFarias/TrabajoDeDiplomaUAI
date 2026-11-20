using BE;
using MAP;
using Servicio;
using BLL.BLL_SER;

namespace BLL.BLL_NEG
{
    public class BLL_Devolucion_351FI
    {
        MAP_Devolucion_351FI map_devolucion_351FI;
        BLL_Prestamo_351FI bll_prestamo_351FI;
        BLL_Multa_351FI bll_multa_351FI;
        BLL_Bitacora_351FI bll_bitacora_351FI;
        BLL_DV_351FI bll_dv_351FI;
        public BLL_Devolucion_351FI()
        {
            map_devolucion_351FI = new MAP_Devolucion_351FI();
            bll_prestamo_351FI = new BLL_Prestamo_351FI();
            bll_multa_351FI = new BLL_Multa_351FI();
            bll_bitacora_351FI = new BLL_Bitacora_351FI();
            bll_dv_351FI = new BLL_DV_351FI();
        }

        // Días entre la fecha de devolución prevista y la fecha real (0 si se devuelve en término)
        public int CalcularDiasAtraso_351FI(BE_Prestamo_351FI prestamo_351FI, DateTime fechaDevolucion_351FI)
        {
            int dias = (fechaDevolucion_351FI.Date - prestamo_351FI.FechaDevolucionPrevista_351FI.Date).Days;
            return dias > 0 ? dias : 0;
        }

        // Registra la devolución armada con el resumen (fecha real y multa, si hubo atraso), registra la multa y finaliza el préstamo (CU-NEG-2)
        public void Registrar_351FI(BE_Devolucion_351FI devolucion_351FI, bool recepcionCompleta_351FI)
        {
            if (devolucion_351FI == null || devolucion_351FI.Prestamo_351FI == null) throw new Exception("Debe seleccionar un préstamo vigente.");
            if (!recepcionCompleta_351FI) throw new Exception("La devolución debe incluir todos los ejemplares del préstamo. Si el socio no los devuelve todos, la devolución no se registra.");

            devolucion_351FI.NumeroDevolucion_351FI = map_devolucion_351FI.InsertarDevolucion_351FI(devolucion_351FI);

            if (devolucion_351FI.Multa_351FI != null)
            {
                devolucion_351FI.Multa_351FI.Devolucion_351FI = devolucion_351FI;
                bll_multa_351FI.Registrar_351FI(devolucion_351FI.Multa_351FI);
            }

            bll_prestamo_351FI.Finalizar_351FI(devolucion_351FI.Prestamo_351FI);

            // CU-SER-17: dígitos verificadores de las tablas modificadas por la devolución
            bll_dv_351FI.GenerarDVH_351FI("Devolucion_351FI", devolucion_351FI.NumeroDevolucion_351FI);
            if (devolucion_351FI.Multa_351FI != null) bll_dv_351FI.GenerarDVH_351FI("Multa_351FI", devolucion_351FI.Multa_351FI.NumeroMulta_351FI);
            bll_dv_351FI.GenerarDVH_351FI("Prestamo_351FI", devolucion_351FI.Prestamo_351FI.NumeroPrestamo_351FI);
            foreach (BE_Ejemplar_351FI ejemplar in devolucion_351FI.Prestamo_351FI.Ejemplares_351FI)
                bll_dv_351FI.GenerarDVH_351FI("Ejemplar_351FI", ejemplar.CodigoEjemplar_351FI);
            bll_dv_351FI.GenerarDVV_351FI("Devolucion_351FI");
            if (devolucion_351FI.Multa_351FI != null) bll_dv_351FI.GenerarDVV_351FI("Multa_351FI");
            bll_dv_351FI.GenerarDVV_351FI("Prestamo_351FI");
            bll_dv_351FI.GenerarDVV_351FI("Ejemplar_351FI");

            // CU-SER-9
            SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Préstamos", "Registrar devolución", 2);
            bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);
        }

        // Comprobante de la devolución registrada (CU-NEG-7); no se persiste
        public BE_Comprobante_351FI ArmarComprobante_351FI(BE_Devolucion_351FI devolucion_351FI)
        {
            BE_Prestamo_351FI prestamo = devolucion_351FI.Prestamo_351FI;
            BE_Comprobante_351FI comprobante = new BE_Comprobante_351FI("Comprobante de devolución", devolucion_351FI.NumeroDevolucion_351FI, DateTime.Today, prestamo.Socio_351FI);
            comprobante.Datos_351FI.Add($"Préstamo N° {prestamo.NumeroPrestamo_351FI}");
            comprobante.Datos_351FI.Add($"Fecha de devolución prevista: {prestamo.FechaDevolucionPrevista_351FI:dd/MM/yyyy}");
            comprobante.Datos_351FI.Add($"Fecha de devolución: {devolucion_351FI.FechaDevolucion_351FI:dd/MM/yyyy}");
            comprobante.Columnas_351FI = new[] { "Código", "Título", "Autor" };
            foreach (BE_Ejemplar_351FI ejemplar in prestamo.Ejemplares_351FI)
                comprobante.Filas_351FI.Add(new[] { ejemplar.CodigoEjemplar_351FI, ejemplar.Libro_351FI.Titulo_351FI, string.Join(", ", ejemplar.Libro_351FI.Autores_351FI.Select(a => a.Nombre_351FI + " " + a.Apellido_351FI)) });
            if (devolucion_351FI.Multa_351FI != null)
            {
                comprobante.Pie_351FI.Add($"Multa por atraso: {devolucion_351FI.Multa_351FI.DiasAtraso_351FI} día(s) x $ {devolucion_351FI.Multa_351FI.MontoPorDia_351FI:N2} = $ {devolucion_351FI.Multa_351FI.Monto_351FI:N2}");
                comprobante.Pie_351FI.Add("La multa queda pendiente de pago. El socio no podrá realizar nuevos préstamos hasta abonarla.");
            }
            else
                comprobante.Pie_351FI.Add("Devolución en término: no se generó multa.");
            return comprobante;
        }

        // Tabla de devoluciones del período para el reporte de préstamos y devoluciones (CU-SER-20)
        public BE_TablaReporte_351FI ArmarTablaReporte_351FI(DateTime desde_351FI, DateTime hasta_351FI)
        {
            List<BE_Devolucion_351FI> devoluciones = map_devolucion_351FI.ObtenerDevolucionesPorFecha_351FI(desde_351FI, hasta_351FI);
            BE_TablaReporte_351FI tabla = new BE_TablaReporte_351FI("Devoluciones", new[] { "N° devolución", "Fecha", "N° préstamo", "Socio", "DNI", "Días de atraso" });
            int conAtraso = 0;
            foreach (BE_Devolucion_351FI devolucion in devoluciones)
            {
                int dias = CalcularDiasAtraso_351FI(devolucion.Prestamo_351FI, devolucion.FechaDevolucion_351FI);
                if (dias > 0) conAtraso++;
                tabla.Filas_351FI.Add(new[]
                {
                    devolucion.NumeroDevolucion_351FI.ToString(),
                    devolucion.FechaDevolucion_351FI.ToString("dd/MM/yyyy"),
                    devolucion.Prestamo_351FI.NumeroPrestamo_351FI.ToString(),
                    $"{devolucion.Prestamo_351FI.Socio_351FI.Apellido_351FI}, {devolucion.Prestamo_351FI.Socio_351FI.Nombre_351FI}",
                    devolucion.Prestamo_351FI.Socio_351FI.Dni_351FI,
                    dias.ToString()
                });
            }
            tabla.Resumen_351FI = $"Total de devoluciones: {devoluciones.Count} ({conAtraso} con atraso y {devoluciones.Count - conAtraso} en término).";
            return tabla;
        }
    }
}
