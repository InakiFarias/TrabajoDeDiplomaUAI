using BE;
using BLL.BLL_SER;
using MAP;
using Servicio;

namespace BLL.BLL_NEG
{
    public class BLL_Prestamo_351FI
    {
        // Políticas de préstamo definidas por la Comisión Directiva
        public const int MAXIMO_PRESTAMOS_VIGENTES = 3;
        public const int PLAZO_PRESTAMO_DIAS = 14;
        public const int MAXIMO_EJEMPLARES_POR_PRESTAMO = 5;

        MAP_Prestamo_351FI map_prestamo_351FI;
        BLL_Bitacora_351FI bll_bitacora_351FI;
        BLL_DV_351FI bll_dv_351FI;
        public BLL_Prestamo_351FI()
        {
            map_prestamo_351FI = new MAP_Prestamo_351FI();
            bll_bitacora_351FI = new BLL_Bitacora_351FI();
            bll_dv_351FI = new BLL_DV_351FI();
        }

        public DateTime CalcularFechaDevolucionPrevista_351FI(DateTime fechaPrestamo_351FI) => fechaPrestamo_351FI.Date.AddDays(PLAZO_PRESTAMO_DIAS);

        public DateTime? ObtenerFechaDevolucionPrevista_351FI(string codigoEjemplar_351FI) => map_prestamo_351FI.ObtenerFechaDevolucionPrevista_351FI(codigoEjemplar_351FI);

        public BE_Prestamo_351FI BuscarVigente_351FI(string numeroPrestamo_351FI)
        {
            if (!int.TryParse(numeroPrestamo_351FI?.Trim(), out int numero) || numero <= 0)
                throw new Exception("Ingrese un número de préstamo válido.");

            BE_Prestamo_351FI? prestamo = map_prestamo_351FI.ObtenerPrestamoVigente_351FI(numero);
            if (prestamo == null) throw new Exception("No se encontró un préstamo vigente con el número ingresado.");
            return prestamo;
        }

        // Préstamos vigentes que coinciden con el número de préstamo o el DNI del socio
        public List<BE_Prestamo_351FI> BuscarVigentes_351FI(string texto_351FI) => map_prestamo_351FI.BuscarVigentes_351FI(texto_351FI?.Trim() ?? "");

        public List<object> ConsultarParaGrilla_351FI(List<BE_Prestamo_351FI> prestamos_351FI)
        {
            var consulta = from p in prestamos_351FI
                           select new
                           {
                               Numero = p.NumeroPrestamo_351FI,
                               Socio = $"{p.Socio_351FI.Apellido_351FI}, {p.Socio_351FI.Nombre_351FI}",
                               Dni = p.Socio_351FI.Dni_351FI,
                               FechaPrestamo = p.FechaPrestamo_351FI.ToString("dd/MM/yyyy"),
                               FechaDevolucionPrevista = p.FechaDevolucionPrevista_351FI.ToString("dd/MM/yyyy")
                           };
            return consulta.ToList<object>();
        }

        public BE_Comprobante_351FI Registrar_351FI(BE_Prestamo_351FI prestamo_351FI)
        {
            if (prestamo_351FI.Socio_351FI == null) throw new Exception("Debe seleccionar un socio.");
            if (prestamo_351FI.Ejemplares_351FI == null || prestamo_351FI.Ejemplares_351FI.Count == 0) throw new Exception("Debe seleccionar al menos un ejemplar.");
            if (prestamo_351FI.Ejemplares_351FI.Count > MAXIMO_EJEMPLARES_POR_PRESTAMO)
                throw new Exception($"Un préstamo puede incluir como máximo {MAXIMO_EJEMPLARES_POR_PRESTAMO} ejemplares.");

            prestamo_351FI.FechaPrestamo_351FI = DateTime.Today;
            prestamo_351FI.FechaDevolucionPrevista_351FI = CalcularFechaDevolucionPrevista_351FI(prestamo_351FI.FechaPrestamo_351FI);
            prestamo_351FI.Estado_351FI = "Vigente";
            prestamo_351FI.NumeroPrestamo_351FI = map_prestamo_351FI.InsertarPrestamo_351FI(prestamo_351FI);
            bll_dv_351FI.GenerarDVH_351FI("Prestamo_351FI", prestamo_351FI.NumeroPrestamo_351FI);

            foreach (BE_Ejemplar_351FI ejemplar in prestamo_351FI.Ejemplares_351FI)
            {
                bll_dv_351FI.GenerarDVH_351FI("Prestamo_Ejemplar_351FI", prestamo_351FI.NumeroPrestamo_351FI, ejemplar.CodigoEjemplar_351FI);

                map_prestamo_351FI.ActualizarEstadoEjemplar_351FI(ejemplar, "Prestado");
                ejemplar.Estado_351FI = "Prestado";
                bll_dv_351FI.GenerarDVH_351FI("Ejemplar_351FI", ejemplar.CodigoEjemplar_351FI);
            }

            BE_Comprobante_351FI comprobante = new BE_Comprobante_351FI(0, prestamo_351FI, DateTime.Today);
            comprobante.NumeroComprobante_351FI = map_prestamo_351FI.InsertarComprobante_351FI(comprobante);
            bll_dv_351FI.GenerarDVH_351FI("Comprobante_351FI", comprobante.NumeroComprobante_351FI);

            bll_dv_351FI.GenerarDVV_351FI("Prestamo_351FI");
            bll_dv_351FI.GenerarDVV_351FI("Prestamo_Ejemplar_351FI");
            bll_dv_351FI.GenerarDVV_351FI("Ejemplar_351FI");
            bll_dv_351FI.GenerarDVV_351FI("Comprobante_351FI");

            SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Préstamos", "Registrar préstamo", 2);
            bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);

            return comprobante;
        }
    }
}
