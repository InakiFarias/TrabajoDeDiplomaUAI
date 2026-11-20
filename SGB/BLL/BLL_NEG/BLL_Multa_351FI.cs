using BE;
using MAP;

namespace BLL.BLL_NEG
{
    public class BLL_Multa_351FI
    {
        // Política definida por la Comisión Directiva
        public const decimal MONTO_POR_DIA_ATRASO = 500m;

        MAP_Multa_351FI map_multa_351FI;
        public BLL_Multa_351FI()
        {
            map_multa_351FI = new MAP_Multa_351FI();
        }

        public int ContarPendientes_351FI(BE_Socio_351FI socio_351FI) => map_multa_351FI.ContarPendientes_351FI(socio_351FI);

        // Multa por los días de atraso de una devolución (CU-NEG-2)
        public BE_Multa_351FI CalcularMulta_351FI(int diasAtraso_351FI, DateTime fechaDevolucion_351FI)
        {
            BE_Multa_351FI multa = new BE_Multa_351FI();
            multa.DiasAtraso_351FI = diasAtraso_351FI;
            multa.MontoPorDia_351FI = MONTO_POR_DIA_ATRASO;
            multa.Monto_351FI = diasAtraso_351FI * MONTO_POR_DIA_ATRASO;
            multa.FechaGeneracion_351FI = fechaDevolucion_351FI.Date;
            multa.FechaPago_351FI = null;
            multa.Estado_351FI = "Pendiente de pago";
            return multa;
        }

        // Registra la multa asociada a la devolución; los dígitos verificadores y la bitácora los registra la devolución (CU-NEG-2)
        public void Registrar_351FI(BE_Multa_351FI multa_351FI)
        {
            multa_351FI.NumeroMulta_351FI = map_multa_351FI.InsertarMulta_351FI(multa_351FI);
        }

        public List<BE_Multa_351FI> ObtenerPendientes_351FI(BE_Socio_351FI socio_351FI)
        {
            List<BE_Multa_351FI> multas = map_multa_351FI.ObtenerMultasPendientes_351FI(socio_351FI);
            if (multas.Count == 0) throw new Exception("El socio no posee multas pendientes de pago.");
            return multas;
        }

        public decimal CalcularTotalAdeudado_351FI(List<BE_Multa_351FI> multas_351FI) => multas_351FI.Sum(m => m.Monto_351FI);

        // Deja pagadas las multas y las asocia al pago; los dígitos verificadores y la bitácora los registra el pago (CU-NEG-3)
        public void MarcarPagadas_351FI(List<BE_Multa_351FI> multas_351FI, BE_Pago_351FI pago_351FI)
        {
            foreach (BE_Multa_351FI multa in multas_351FI)
            {
                multa.FechaPago_351FI = pago_351FI.FechaPago_351FI;
                multa.Estado_351FI = "Pagada";
                map_multa_351FI.ActualizarPagoMulta_351FI(multa, pago_351FI.NumeroPago_351FI);
            }
        }

        // Tabla de multas del período para el reporte de multas y donaciones (CU-SER-21)
        public BE_TablaReporte_351FI ArmarTablaReporte_351FI(DateTime desde_351FI, DateTime hasta_351FI)
        {
            List<BE_Multa_351FI> multas = map_multa_351FI.ObtenerMultasPorFecha_351FI(desde_351FI, hasta_351FI);
            BE_TablaReporte_351FI tabla = new BE_TablaReporte_351FI("Multas", new[] { "N° multa", "Generación", "Socio", "N° devolución", "Días de atraso", "Monto", "Estado", "Fecha de pago" });
            foreach (BE_Multa_351FI multa in multas)
                tabla.Filas_351FI.Add(new[]
                {
                    multa.NumeroMulta_351FI.ToString(),
                    multa.FechaGeneracion_351FI.ToString("dd/MM/yyyy"),
                    $"{multa.Devolucion_351FI.Prestamo_351FI.Socio_351FI.Apellido_351FI}, {multa.Devolucion_351FI.Prestamo_351FI.Socio_351FI.Nombre_351FI}",
                    multa.Devolucion_351FI.NumeroDevolucion_351FI.ToString(),
                    multa.DiasAtraso_351FI.ToString(),
                    multa.Monto_351FI.ToString("C2"),
                    multa.Estado_351FI,
                    multa.FechaPago_351FI.HasValue ? multa.FechaPago_351FI.Value.ToString("dd/MM/yyyy") : "-"
                });
            decimal pendiente = multas.Where(m => m.Estado_351FI == "Pendiente de pago").Sum(m => m.Monto_351FI);
            decimal pagado = multas.Where(m => m.Estado_351FI == "Pagada").Sum(m => m.Monto_351FI);
            tabla.Resumen_351FI = $"Total de multas: {multas.Count}. Monto pendiente de pago: {pendiente:C2}. Monto pagado: {pagado:C2}.";
            return tabla;
        }
    }
}
