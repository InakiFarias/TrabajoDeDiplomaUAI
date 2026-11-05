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

        MAP_Multa_351FI map_multa_351FI;
        BLL_Bitacora_351FI bll_bitacora_351FI;
        BLL_DV_351FI bll_dv_351FI;
        public BLL_Multa_351FI()
        {
            map_multa_351FI = new MAP_Multa_351FI();
            bll_bitacora_351FI = new BLL_Bitacora_351FI();
            bll_dv_351FI = new BLL_DV_351FI();
        }

        // Solo los socios que tienen multas pendientes, con el total adeudado
        public List<BE_Socio_351FI> BuscarSociosConMultas_351FI(string dni_351FI) => map_multa_351FI.ObtenerSociosConMultas_351FI(dni_351FI?.Trim() ?? "");

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

        public BE_ComprobantePago_351FI RegistrarPago_351FI(BE_Socio_351FI socio_351FI, List<BE_Multa_351FI> multas_351FI, string metodoPago_351FI)
        {
            if (socio_351FI == null) throw new Exception("Debe seleccionar un socio.");
            if (multas_351FI == null || multas_351FI.Count == 0) throw new Exception("El socio no posee multas pendientes de pago.");
            if (metodoPago_351FI != METODO_EFECTIVO && metodoPago_351FI != METODO_TARJETA) throw new Exception("Seleccione el método de pago.");

            BE_ComprobantePago_351FI comprobante = new BE_ComprobantePago_351FI(0, socio_351FI, DateTime.Today, multas_351FI, metodoPago_351FI, CalcularTotalAdeudado_351FI(multas_351FI));
            comprobante.NumeroComprobante_351FI = map_multa_351FI.InsertarComprobantePago_351FI(comprobante);
            bll_dv_351FI.GenerarDVH_351FI("ComprobantePago_351FI", comprobante.NumeroComprobante_351FI);

            foreach (BE_Multa_351FI multa in multas_351FI)
            {
                multa.FechaPago_351FI = DateTime.Today;
                multa.Estado_351FI = "Pagada";
                map_multa_351FI.ActualizarPagoMulta_351FI(multa, comprobante.NumeroComprobante_351FI);
                bll_dv_351FI.GenerarDVH_351FI("Multa_351FI", multa.NumeroMulta_351FI);
            }

            bll_dv_351FI.GenerarDVV_351FI("ComprobantePago_351FI");
            bll_dv_351FI.GenerarDVV_351FI("Multa_351FI");

            SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Multas y donaciones", "Cobrar multas", 1);
            bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);

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
