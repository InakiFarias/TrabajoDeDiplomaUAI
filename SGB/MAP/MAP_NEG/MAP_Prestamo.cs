using BE;
using DAL;
using Microsoft.Data.SqlClient;

namespace MAP
{
    public class MAP_Prestamo
    {
        DAO_Prestamo dao_prestamo;
        public MAP_Prestamo()
        {
            dao_prestamo = new DAO_Prestamo();
        }

        public BE_Prestamo? ObtenerPrestamoVigente(int numeroPrestamo)
        {
            BE_Prestamo? prestamo = null;
            SqlDataReader dr = dao_prestamo.ObtenerPrestamoVigente(numeroPrestamo);
            if (dr.Read())
            {
                BE_Socio socio = new BE_Socio(
                    Convert.ToInt32(dr["NumeroSocio"]),
                    Convert.ToString(dr["Nombre"]),
                    Convert.ToString(dr["Apellido"]),
                    Convert.ToString(dr["Dni"]),
                    Convert.ToString(dr["EstadoSocio"]));

                prestamo = new BE_Prestamo(
                    Convert.ToInt32(dr["NumeroPrestamo"]),
                    socio,
                    Convert.ToDateTime(dr["FechaPrestamo"]),
                    Convert.ToDateTime(dr["FechaDevolucionPrevista"]),
                    Convert.ToString(dr["EstadoPrestamo"]),
                    new List<BE_Ejemplar>());
            }
            dr.Close();

            if (prestamo != null)
                prestamo.Ejemplares = new MAP_Ejemplar().ObtenerPorPrestamo(prestamo.NumeroPrestamo);

            return prestamo;
        }

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
