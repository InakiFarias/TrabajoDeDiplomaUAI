using BE;
using DAL;

namespace MAP
{
    public class MAP_Prestamo
    {
        DAO_Prestamo dao_prestamo;
        public MAP_Prestamo()
        {
            dao_prestamo = new DAO_Prestamo();
        }

        public int ContarPrestamosVigentes(int numeroSocio) => dao_prestamo.ContarPrestamosVigentes(numeroSocio);

        public int InsertarPrestamo(BE_Prestamo prestamo)
        {
            int numeroPrestamo = dao_prestamo.InsertarPrestamo(prestamo.Socio.NumeroSocio, prestamo.FechaPrestamo, prestamo.FechaDevolucionPrevista, prestamo.Estado);
            foreach (BE_Ejemplar ejemplar in prestamo.Ejemplares)
                dao_prestamo.InsertarDetalle(numeroPrestamo, ejemplar.CodigoEjemplar);
            return numeroPrestamo;
        }

        public void ActualizarEstadoEjemplar(BE_Ejemplar ejemplar, string estado) => dao_prestamo.ActualizarEstadoEjemplar(ejemplar.CodigoEjemplar, estado);

        public int InsertarComprobante(BE_Comprobante comprobante) => dao_prestamo.InsertarComprobante(comprobante.Prestamo.NumeroPrestamo, comprobante.FechaEmision);

        public DateTime? ObtenerFechaDevolucionPrevista(string codigoEjemplar)
        {
            object fecha = dao_prestamo.ObtenerFechaDevolucionPrevista(codigoEjemplar);
            if (fecha == null || fecha == DBNull.Value) return null;
            return Convert.ToDateTime(fecha);
        }
    }
}