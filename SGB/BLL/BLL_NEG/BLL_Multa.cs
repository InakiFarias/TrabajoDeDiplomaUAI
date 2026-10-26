using BE;
using MAP;
using Servicio;
using BLL.BLL_SER;

namespace BLL.BLL_NEG
{
    public class BLL_Multa
    {
        MAP_Multa map_multa;
        BLL_Bitacora bll_bitacora;
        public BLL_Multa()
        {
            map_multa = new MAP_Multa();
            bll_bitacora = new BLL_Bitacora();
        }

        // Solo los socios que tienen multas pendientes, con el total adeudado
        public List<BE_Socio> BuscarSociosConMultas(string dni) => map_multa.ObtenerSociosConMultas(dni?.Trim() ?? "");

        public List<BE_Multa> ObtenerPendientes(BE_Socio socio)
        {
            List<BE_Multa> multas = map_multa.ObtenerMultasPendientes(socio);
            if (multas.Count == 0) throw new Exception("El socio no posee multas pendientes de pago.");
            return multas;
        }

        public decimal CalcularTotalAdeudado(List<BE_Multa> multas) => multas.Sum(m => m.Monto);

        public BE_ComprobantePago RegistrarPago(BE_Socio socio, List<BE_Multa> multas)
        {
            if (socio == null) throw new Exception("Debe seleccionar un socio.");
            if (multas == null || multas.Count == 0) throw new Exception("El socio no posee multas pendientes de pago.");

            BE_ComprobantePago comprobante = new BE_ComprobantePago(0, socio, DateTime.Today, multas, CalcularTotalAdeudado(multas));
            comprobante.NumeroComprobante = map_multa.InsertarComprobantePago(comprobante);

            foreach (BE_Multa multa in multas)
            {
                multa.FechaPago = DateTime.Today;
                multa.Estado = "Pagada";
                map_multa.ActualizarPagoMulta(multa, comprobante.NumeroComprobante);
            }

            SER_Bitacora bitacora = new SER_Bitacora(SER_SesionManager.ObtenerSesion().Usuario, DateTime.Now, "Multas y donaciones", "Cobrar multas", 1);
            bll_bitacora.RegistrarBitacora(bitacora);

            return comprobante;
        }

        public List<object> ConsultarParaGrilla(List<BE_Multa> multas)
        {
            var consulta = from m in multas
                           select new
                           {
                               Numero = m.NumeroMulta,
                               Prestamo = m.Devolucion.Prestamo.NumeroPrestamo,
                               FechaGeneracion = m.FechaGeneracion.ToString("dd/MM/yyyy"),
                               DiasAtraso = m.DiasAtraso,
                               Monto = m.Monto.ToString("N2")
                           };
            return consulta.ToList<object>();
        }
    }
}
