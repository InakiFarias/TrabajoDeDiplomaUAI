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
        BLL_Ejemplar_351FI bll_ejemplar_351FI;
        BLL_Bitacora_351FI bll_bitacora_351FI;
        BLL_DV_351FI bll_dv_351FI;
        public BLL_Prestamo_351FI()
        {
            map_prestamo_351FI = new MAP_Prestamo_351FI();
            bll_ejemplar_351FI = new BLL_Ejemplar_351FI();
            bll_bitacora_351FI = new BLL_Bitacora_351FI();
            bll_dv_351FI = new BLL_DV_351FI();
        }

        public DateTime CalcularFechaDevolucionPrevista_351FI(DateTime fechaPrestamo_351FI) => fechaPrestamo_351FI.Date.AddDays(PLAZO_PRESTAMO_DIAS);

        // Agrega un ejemplar al detalle del préstamo: valida el máximo por préstamo y que el ejemplar esté disponible (CU-NEG-1)
        public BE_Ejemplar_351FI AgregarEjemplar_351FI(List<BE_Ejemplar_351FI> detalle_351FI, string codigoEjemplar_351FI)
        {
            if (detalle_351FI.Count >= MAXIMO_EJEMPLARES_POR_PRESTAMO)
                throw new Exception($"Un préstamo puede incluir como máximo {MAXIMO_EJEMPLARES_POR_PRESTAMO} ejemplares.");

            BE_Ejemplar_351FI ejemplar = bll_ejemplar_351FI.BuscarPorCodigo_351FI(codigoEjemplar_351FI);
            if (ejemplar.Estado_351FI != "Disponible")
            {
                DateTime? fecha = map_prestamo_351FI.ObtenerFechaDevolucionPrevista_351FI(codigoEjemplar_351FI);
                throw new Exception(fecha == null
                    ? "El ejemplar no se encuentra disponible."
                    : $"El ejemplar se encuentra prestado. Fecha de devolución prevista: {fecha:dd/MM/yyyy}.");
            }

            AgregarAlDetalle_351FI(detalle_351FI, ejemplar);
            return ejemplar;
        }

        private void AgregarAlDetalle_351FI(List<BE_Ejemplar_351FI> detalle_351FI, BE_Ejemplar_351FI ejemplar_351FI) => detalle_351FI.Add(ejemplar_351FI);

        public int ContarVigentes_351FI(BE_Socio_351FI socio_351FI) => map_prestamo_351FI.ContarVigentes_351FI(socio_351FI);

        public int ContarVencidos_351FI(BE_Socio_351FI socio_351FI) => map_prestamo_351FI.ContarVencidos_351FI(socio_351FI);

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

        // Registra el préstamo con las fechas calculadas al finalizar la selección y deja los ejemplares en estado prestado (CU-NEG-1)
        public void Registrar_351FI(BE_Prestamo_351FI prestamo_351FI)
        {
            if (prestamo_351FI.Socio_351FI == null) throw new Exception("Debe seleccionar un socio.");
            if (prestamo_351FI.Ejemplares_351FI == null || prestamo_351FI.Ejemplares_351FI.Count == 0) throw new Exception("Debe seleccionar al menos un ejemplar.");
            if (prestamo_351FI.Ejemplares_351FI.Count > MAXIMO_EJEMPLARES_POR_PRESTAMO)
                throw new Exception($"Un préstamo puede incluir como máximo {MAXIMO_EJEMPLARES_POR_PRESTAMO} ejemplares.");

            prestamo_351FI.Estado_351FI = "Vigente";
            prestamo_351FI.NumeroPrestamo_351FI = map_prestamo_351FI.InsertarPrestamo_351FI(prestamo_351FI);

            foreach (BE_Ejemplar_351FI ejemplar in prestamo_351FI.Ejemplares_351FI)
                bll_ejemplar_351FI.ActualizarEstado_351FI(ejemplar, "Prestado");

            // CU-SER-17: dígitos verificadores de las tablas modificadas por el préstamo
            bll_dv_351FI.GenerarDVH_351FI("Prestamo_351FI", prestamo_351FI.NumeroPrestamo_351FI);
            foreach (BE_Ejemplar_351FI ejemplar in prestamo_351FI.Ejemplares_351FI)
            {
                bll_dv_351FI.GenerarDVH_351FI("Prestamo_Ejemplar_351FI", prestamo_351FI.NumeroPrestamo_351FI, ejemplar.CodigoEjemplar_351FI);
                bll_dv_351FI.GenerarDVH_351FI("Ejemplar_351FI", ejemplar.CodigoEjemplar_351FI);
            }
            bll_dv_351FI.GenerarDVV_351FI("Prestamo_351FI");
            bll_dv_351FI.GenerarDVV_351FI("Prestamo_Ejemplar_351FI");
            bll_dv_351FI.GenerarDVV_351FI("Ejemplar_351FI");

            // CU-SER-9
            SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Préstamos", "Registrar préstamo", 2);
            bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);
        }

        // Comprobante del préstamo registrado (CU-NEG-7); no se persiste
        public BE_Comprobante_351FI ArmarComprobante_351FI(BE_Prestamo_351FI prestamo_351FI)
        {
            BE_Comprobante_351FI comprobante = new BE_Comprobante_351FI("Comprobante de préstamo", prestamo_351FI.NumeroPrestamo_351FI, DateTime.Today, prestamo_351FI.Socio_351FI);
            comprobante.Datos_351FI.Add($"Fecha del préstamo: {prestamo_351FI.FechaPrestamo_351FI:dd/MM/yyyy}");
            comprobante.Columnas_351FI = new[] { "Código", "Título", "Autor" };
            foreach (BE_Ejemplar_351FI ejemplar in prestamo_351FI.Ejemplares_351FI)
                comprobante.Filas_351FI.Add(new[] { ejemplar.CodigoEjemplar_351FI, ejemplar.Libro_351FI.Titulo_351FI, string.Join(", ", ejemplar.Libro_351FI.Autores_351FI.Select(a => a.Nombre_351FI + " " + a.Apellido_351FI)) });
            comprobante.Pie_351FI.Add($"Fecha de devolución prevista: {prestamo_351FI.FechaDevolucionPrevista_351FI:dd/MM/yyyy}");
            comprobante.Pie_351FI.Add("La devolución posterior a esta fecha genera una multa por cada día de atraso.");
            return comprobante;
        }
    }
}
