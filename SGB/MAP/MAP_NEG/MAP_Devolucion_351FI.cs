using BE;
using DAL;
using Microsoft.Data.SqlClient;

namespace MAP
{
    public class MAP_Devolucion_351FI
    {
        DAO_Devolucion_351FI dao_devolucion_351FI;
        public MAP_Devolucion_351FI()
        {
            dao_devolucion_351FI = new DAO_Devolucion_351FI();
        }

        public int InsertarDevolucion_351FI(BE_Devolucion_351FI devolucion_351FI) => dao_devolucion_351FI.InsertarDevolucion_351FI(devolucion_351FI.Prestamo_351FI.NumeroPrestamo_351FI, devolucion_351FI.FechaDevolucion_351FI);

        // Devoluciones del período para el reporte (el préstamo viaja sin ejemplares)
        public List<BE_Devolucion_351FI> ObtenerDevolucionesPorFecha_351FI(DateTime desde_351FI, DateTime hasta_351FI)
        {
            List<BE_Devolucion_351FI> lista = new List<BE_Devolucion_351FI>();
            SqlDataReader dr = dao_devolucion_351FI.ObtenerDevolucionesPorFecha_351FI(desde_351FI, hasta_351FI);
            while (dr.Read())
            {
                BE_Socio_351FI socio = new BE_Socio_351FI(
                    Convert.ToInt32(dr["NumeroSocio_351FI"]),
                    Convert.ToString(dr["Nombre_351FI"]),
                    Convert.ToString(dr["Apellido_351FI"]),
                    Convert.ToString(dr["Dni_351FI"]),
                    Convert.ToString(dr["EstadoSocio"]));
                BE_Prestamo_351FI prestamo = new BE_Prestamo_351FI(
                    Convert.ToInt32(dr["NumeroPrestamo_351FI"]),
                    socio,
                    Convert.ToDateTime(dr["FechaPrestamo_351FI"]),
                    Convert.ToDateTime(dr["FechaDevolucionPrevista_351FI"]),
                    Convert.ToString(dr["EstadoPrestamo"]),
                    new List<BE_Ejemplar_351FI>());
                lista.Add(new BE_Devolucion_351FI(Convert.ToInt32(dr["NumeroDevolucion_351FI"]), prestamo, Convert.ToDateTime(dr["FechaDevolucion_351FI"])));
            }
            dr.Close();
            return lista;
        }
    }
}
