using BE;
using BLL.BLL_SER;
using MAP;
using Servicio;

namespace BLL.BLL_NEG
{
    public class BLL_Prestamo
    {
        private const int MAXIMO_PRESTAMOS_VIGENTES = 3; // TODO: valor definido por la Comisión Directiva
        private const int PLAZO_PRESTAMO_DIAS = 14;      // TODO: valor definido por la Comisión Directiva

        MAP_Prestamo map_prestamo;
        BLL_Bitacora bll_bitacora;
        public BLL_Prestamo()
        {
            map_prestamo = new MAP_Prestamo();
            bll_bitacora = new BLL_Bitacora();
        }

        public void ValidarLimite(BE_Socio socio)
        {
            if (map_prestamo.ContarPrestamosVigentes(socio.NumeroSocio) >= MAXIMO_PRESTAMOS_VIGENTES)
                throw new Exception($"El socio alcanzó el límite de {MAXIMO_PRESTAMOS_VIGENTES} préstamos vigentes.");
        }

        public DateTime CalcularFechaDevolucionPrevista(DateTime fechaPrestamo) => fechaPrestamo.Date.AddDays(PLAZO_PRESTAMO_DIAS);

        public DateTime? ObtenerFechaDevolucionPrevista(string codigoEjemplar) => map_prestamo.ObtenerFechaDevolucionPrevista(codigoEjemplar);

        public BE_Comprobante Registrar(BE_Prestamo prestamo)
        {
            prestamo.FechaPrestamo = DateTime.Today;
            prestamo.FechaDevolucionPrevista = CalcularFechaDevolucionPrevista(prestamo.FechaPrestamo);
            prestamo.Estado = "Vigente";
            prestamo.NumeroPrestamo = map_prestamo.InsertarPrestamo(prestamo);

            foreach (BE_Ejemplar ejemplar in prestamo.Ejemplares)
            {
                map_prestamo.ActualizarEstadoEjemplar(ejemplar, "Prestado");
                ejemplar.Estado = "Prestado";
            }

            BE_Comprobante comprobante = new BE_Comprobante(0, prestamo, DateTime.Today);
            comprobante.NumeroComprobante = map_prestamo.InsertarComprobante(comprobante);

            SER_Bitacora bitacora = new SER_Bitacora(SER_SesionManager.ObtenerSesion().Usuario, DateTime.Now, "Préstamos", "Registrar préstamo", 2);
            bll_bitacora.RegistrarBitacora(bitacora);

            return comprobante;
        }
    }
}