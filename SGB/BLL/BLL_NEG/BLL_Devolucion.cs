using BE;
using MAP;
using Servicio;
using BLL.BLL_SER;

namespace BLL.BLL_NEG
{
    public class BLL_Devolucion
    {
        // Política definida por la Comisión Directiva
        public const decimal MONTO_POR_DIA_ATRASO = 500m;

        MAP_Devolucion map_devolucion;
        BLL_Bitacora bll_bitacora;
        public BLL_Devolucion()
        {
            map_devolucion = new MAP_Devolucion();
            bll_bitacora = new BLL_Bitacora();
        }

        public int CalcularDiasAtraso(BE_Prestamo prestamo, DateTime fechaDevolucion)
        {
            int dias = (fechaDevolucion.Date - prestamo.FechaDevolucionPrevista.Date).Days;
            return dias > 0 ? dias : 0;
        }

        // Devuelve null si la devolución está en término
        public BE_Multa? CalcularMulta(BE_Prestamo prestamo, DateTime fechaDevolucion)
        {
            int diasAtraso = CalcularDiasAtraso(prestamo, fechaDevolucion);
            if (diasAtraso == 0) return null;

            BE_Multa multa = new BE_Multa();
            multa.DiasAtraso = diasAtraso;
            multa.MontoPorDia = MONTO_POR_DIA_ATRASO;
            multa.Monto = diasAtraso * MONTO_POR_DIA_ATRASO;
            multa.FechaGeneracion = fechaDevolucion.Date;
            multa.FechaPago = null;
            multa.Estado = "Pendiente de pago";
            return multa;
        }

        public BE_Devolucion Registrar(BE_Prestamo prestamo, bool recepcionCompleta)
        {
            if (prestamo == null) throw new Exception("Debe buscar un préstamo vigente.");
            if (!recepcionCompleta) throw new Exception("La devolución debe incluir todos los ejemplares del préstamo. Si el socio no los devuelve todos, la devolución no se registra.");

            BE_Devolucion devolucion = new BE_Devolucion(0, prestamo, DateTime.Today);
            devolucion.Multa = CalcularMulta(prestamo, devolucion.FechaDevolucion);
            devolucion.NumeroDevolucion = map_devolucion.InsertarDevolucion(devolucion);

            if (devolucion.Multa != null)
            {
                devolucion.Multa.Devolucion = devolucion;
                devolucion.Multa.NumeroMulta = map_devolucion.InsertarMulta(devolucion.Multa);
            }

            foreach (BE_Ejemplar ejemplar in prestamo.Ejemplares)
            {
                map_devolucion.ActualizarEstadoEjemplar(ejemplar, "Disponible");
                ejemplar.Estado = "Disponible";
            }

            map_devolucion.ActualizarEstadoPrestamo(prestamo, "Finalizado");
            prestamo.Estado = "Finalizado";

            SER_Bitacora bitacora = new SER_Bitacora(SER_SesionManager.ObtenerSesion().Usuario, DateTime.Now, "Préstamos", "Registrar devolución", 2);
            bll_bitacora.RegistrarBitacora(bitacora);

            return devolucion;
        }
    }
}
