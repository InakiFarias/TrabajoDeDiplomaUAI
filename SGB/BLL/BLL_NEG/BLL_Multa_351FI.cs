using BE;
using MAP;
using Servicio;
using BLL.BLL_SER;

namespace BLL.BLL_NEG
{
    public class BLL_Multa_351FI
    {
        public const string METODO_EFECTIVO = "Efectivo";
        public const string METODO_TARJETA = "Tarjeta";
        // Política definida por la Comisión Directiva
        public const decimal MONTO_POR_DIA_ATRASO = 500m;

        MAP_Multa_351FI map_multa_351FI;
        BLL_Bitacora_351FI bll_bitacora_351FI;
        BLL_DV_351FI bll_dv_351FI;
        public BLL_Multa_351FI()
        {
            map_multa_351FI = new MAP_Multa_351FI();
            bll_bitacora_351FI = new BLL_Bitacora_351FI();
            bll_dv_351FI = new BLL_DV_351FI();
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

        // Valida el pago con tarjeta; devuelve false si se rechaza. Los datos de la tarjeta no se guardan
        public bool ProcesarPagoConTarjeta_351FI(string numeroTarjeta_351FI, decimal totalAdeudado_351FI)
        {
            string numero = (numeroTarjeta_351FI ?? "").Replace(" ", "").Replace("-", "");
            if (numero.Length < 13 || numero.Length > 19 || !numero.All(char.IsDigit))
                throw new Exception("Ingrese un número de tarjeta válido (solo dígitos, entre 13 y 19).");

            if (totalAdeudado_351FI <= 0) return false;
            return NumeroTarjetaValido_351FI(numero);
        }

        // El pago se aprueba si el número de tarjeta es válido (algoritmo de Luhn)
        private bool NumeroTarjetaValido_351FI(string numeroTarjeta_351FI)
        {
            int suma = 0;
            bool duplicar = false;
            for (int i = numeroTarjeta_351FI.Length - 1; i >= 0; i--)
            {
                int digito = numeroTarjeta_351FI[i] - '0';
                if (duplicar)
                {
                    digito *= 2;
                    if (digito > 9) digito -= 9;
                }
                suma += digito;
                duplicar = !duplicar;
            }
            return suma % 10 == 0;
        }

        public BE_Pago_351FI RegistrarPago_351FI(BE_Socio_351FI socio_351FI, List<BE_Multa_351FI> multas_351FI, string metodoPago_351FI)
        {
            if (socio_351FI == null) throw new Exception("Debe seleccionar un socio.");
            if (multas_351FI == null || multas_351FI.Count == 0) throw new Exception("El socio no posee multas pendientes de pago.");
            if (metodoPago_351FI != METODO_EFECTIVO && metodoPago_351FI != METODO_TARJETA) throw new Exception("Seleccione el método de pago.");

            BE_Pago_351FI pago = new BE_Pago_351FI(0, socio_351FI, DateTime.Today, multas_351FI, metodoPago_351FI, CalcularTotalAdeudado_351FI(multas_351FI));
            pago.NumeroPago_351FI = map_multa_351FI.InsertarPago_351FI(pago);
            bll_dv_351FI.GenerarDVH_351FI("Pago_351FI", pago.NumeroPago_351FI);

            foreach (BE_Multa_351FI multa in multas_351FI)
            {
                multa.FechaPago_351FI = DateTime.Today;
                multa.Estado_351FI = "Pagada";
                map_multa_351FI.ActualizarPagoMulta_351FI(multa, pago.NumeroPago_351FI);
                bll_dv_351FI.GenerarDVH_351FI("Multa_351FI", multa.NumeroMulta_351FI);
            }

            bll_dv_351FI.GenerarDVV_351FI("Pago_351FI");
            bll_dv_351FI.GenerarDVV_351FI("Multa_351FI");

            SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Multas y donaciones", "Cobrar multas", 1);
            bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);

            return pago;
        }

        // Comprobante del pago registrado (CU-NEG-7); no se persiste
        public BE_Comprobante_351FI ArmarComprobante_351FI(BE_Pago_351FI pago_351FI)
        {
            BE_Comprobante_351FI comprobante = new BE_Comprobante_351FI("Comprobante de pago de multas", pago_351FI.NumeroPago_351FI, DateTime.Today, pago_351FI.Socio_351FI);
            comprobante.Datos_351FI.Add($"Fecha de pago: {pago_351FI.FechaPago_351FI:dd/MM/yyyy}");
            comprobante.Columnas_351FI = new[] { "N° multa", "Préstamo", "Fecha de generación", "Días de atraso", "Monto" };
            foreach (BE_Multa_351FI multa in pago_351FI.Multas_351FI)
                comprobante.Filas_351FI.Add(new[] { multa.NumeroMulta_351FI.ToString(), multa.Devolucion_351FI.Prestamo_351FI.NumeroPrestamo_351FI.ToString(), multa.FechaGeneracion_351FI.ToString("dd/MM/yyyy"), multa.DiasAtraso_351FI.ToString(), $"$ {multa.Monto_351FI:N2}" });
            comprobante.Pie_351FI.Add($"Total abonado: $ {pago_351FI.Total_351FI:N2}");
            comprobante.Pie_351FI.Add($"Método de pago: {pago_351FI.MetodoPago_351FI}");
            return comprobante;
        }

        public List<object> ConsultarParaGrilla_351FI(List<BE_Multa_351FI> multas_351FI)
        {
            var consulta = from m in multas_351FI
                           select new
                           {
                               Numero = m.NumeroMulta_351FI,
                               Prestamo = m.Devolucion_351FI.Prestamo_351FI.NumeroPrestamo_351FI,
                               FechaGeneracion = m.FechaGeneracion_351FI.ToString("dd/MM/yyyy"),
                               DiasAtraso = m.DiasAtraso_351FI,
                               Monto = m.Monto_351FI.ToString("N2")
                           };
            return consulta.ToList<object>();
        }
    }
}
