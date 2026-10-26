using BE;
using BLL.BLL_SER;
using MAP;
using Servicio;

namespace BLL.BLL_NEG
{
    public class BLL_Prestamo
    {
        // Políticas de préstamo definidas por la Comisión Directiva
        public const int MAXIMO_PRESTAMOS_VIGENTES = 3;
        public const int PLAZO_PRESTAMO_DIAS = 14;
        public const int MAXIMO_EJEMPLARES_POR_PRESTAMO = 5;

        MAP_Prestamo map_prestamo;
        BLL_Bitacora bll_bitacora;
        public BLL_Prestamo()
        {
            map_prestamo = new MAP_Prestamo();
            bll_bitacora = new BLL_Bitacora();
        }

        public DateTime CalcularFechaDevolucionPrevista(DateTime fechaPrestamo) => fechaPrestamo.Date.AddDays(PLAZO_PRESTAMO_DIAS);

        public DateTime? ObtenerFechaDevolucionPrevista(string codigoEjemplar) => map_prestamo.ObtenerFechaDevolucionPrevista(codigoEjemplar);

        public BE_Prestamo BuscarVigente(string numeroPrestamo)
        {
            if (!int.TryParse(numeroPrestamo?.Trim(), out int numero) || numero <= 0)
                throw new Exception("Ingrese un número de préstamo válido.");

            BE_Prestamo? prestamo = map_prestamo.ObtenerPrestamoVigente(numero);
            if (prestamo == null) throw new Exception("No se encontró un préstamo vigente con el número ingresado.");
            return prestamo;
        }

        // Préstamos vigentes que coinciden con el número de préstamo o el DNI del socio
        public List<BE_Prestamo> BuscarVigentes(string texto) => map_prestamo.BuscarVigentes(texto?.Trim() ?? "");

        public List<object> ConsultarParaGrilla(List<BE_Prestamo> prestamos)
        {
            var consulta = from p in prestamos
                           select new
                           {
                               Numero = p.NumeroPrestamo,
                               Socio = $"{p.Socio.Apellido}, {p.Socio.Nombre}",
                               Dni = p.Socio.Dni,
                               FechaPrestamo = p.FechaPrestamo.ToString("dd/MM/yyyy"),
                               FechaDevolucionPrevista = p.FechaDevolucionPrevista.ToString("dd/MM/yyyy")
                           };
            return consulta.ToList<object>();
        }

        public BE_Comprobante Registrar(BE_Prestamo prestamo)
        {
            if (prestamo.Socio == null) throw new Exception("Debe seleccionar un socio.");
            if (prestamo.Ejemplares == null || prestamo.Ejemplares.Count == 0) throw new Exception("Debe seleccionar al menos un ejemplar.");
            if (prestamo.Ejemplares.Count > MAXIMO_EJEMPLARES_POR_PRESTAMO)
                throw new Exception($"Un préstamo puede incluir como máximo {MAXIMO_EJEMPLARES_POR_PRESTAMO} ejemplares.");

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
