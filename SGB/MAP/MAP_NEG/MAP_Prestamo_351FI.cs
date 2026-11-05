using BE;
using DAL;
using Microsoft.Data.SqlClient;

namespace MAP
{
    public class MAP_Prestamo_351FI
    {
        DAO_Prestamo_351FI dao_prestamo_351FI;
        public MAP_Prestamo_351FI()
        {
            dao_prestamo_351FI = new DAO_Prestamo_351FI();
        }

        public BE_Prestamo_351FI? ObtenerPrestamoVigente_351FI(int numeroPrestamo_351FI)
        {
            BE_Prestamo_351FI? prestamo = null;
            SqlDataReader dr = dao_prestamo_351FI.ObtenerPrestamoVigente_351FI(numeroPrestamo_351FI);
            if (dr.Read()) prestamo = Mapear_351FI(dr);
            dr.Close();

            if (prestamo != null)
                prestamo.Ejemplares_351FI = new MAP_Ejemplar_351FI().ObtenerPorPrestamo_351FI(prestamo.NumeroPrestamo_351FI);

            return prestamo;
        }

        // Préstamos vigentes para la grilla de devoluciones (sin ejemplares; se cargan al elegir uno)
        public List<BE_Prestamo_351FI> BuscarVigentes_351FI(string texto_351FI)
        {
            List<BE_Prestamo_351FI> lista = new List<BE_Prestamo_351FI>();
            SqlDataReader dr = dao_prestamo_351FI.BuscarVigentes_351FI(texto_351FI);
            while (dr.Read())
            {
                lista.Add(Mapear_351FI(dr));
            }
            dr.Close();
            return lista;
        }

        private BE_Prestamo_351FI Mapear_351FI(SqlDataReader dr_351FI)
        {
            BE_Socio_351FI socio = new BE_Socio_351FI(
                Convert.ToInt32(dr_351FI["NumeroSocio_351FI"]),
                Convert.ToString(dr_351FI["Nombre_351FI"]),
                Convert.ToString(dr_351FI["Apellido_351FI"]),
                Convert.ToString(dr_351FI["Dni_351FI"]),
                Convert.ToString(dr_351FI["EstadoSocio"]));

            return new BE_Prestamo_351FI(
                Convert.ToInt32(dr_351FI["NumeroPrestamo_351FI"]),
                socio,
                Convert.ToDateTime(dr_351FI["FechaPrestamo_351FI"]),
                Convert.ToDateTime(dr_351FI["FechaDevolucionPrevista_351FI"]),
                Convert.ToString(dr_351FI["EstadoPrestamo"]),
                new List<BE_Ejemplar_351FI>());
        }

        public int InsertarPrestamo_351FI(BE_Prestamo_351FI prestamo_351FI)
        {
            int numeroPrestamo = dao_prestamo_351FI.InsertarPrestamo_351FI(prestamo_351FI.Socio_351FI.NumeroSocio_351FI, prestamo_351FI.FechaPrestamo_351FI, prestamo_351FI.FechaDevolucionPrevista_351FI, prestamo_351FI.Estado_351FI);
            foreach (BE_Ejemplar_351FI ejemplar in prestamo_351FI.Ejemplares_351FI)
                dao_prestamo_351FI.InsertarDetalle_351FI(numeroPrestamo, ejemplar.CodigoEjemplar_351FI);
            return numeroPrestamo;
        }

        public void ActualizarEstadoEjemplar_351FI(BE_Ejemplar_351FI ejemplar_351FI, string estado_351FI) => dao_prestamo_351FI.ActualizarEstadoEjemplar_351FI(ejemplar_351FI.CodigoEjemplar_351FI, estado_351FI);

        public int InsertarComprobante_351FI(BE_Comprobante_351FI comprobante_351FI) => dao_prestamo_351FI.InsertarComprobante_351FI(comprobante_351FI.Prestamo_351FI.NumeroPrestamo_351FI, comprobante_351FI.FechaEmision_351FI);

        public DateTime? ObtenerFechaDevolucionPrevista_351FI(string codigoEjemplar_351FI)
        {
            object fecha = dao_prestamo_351FI.ObtenerFechaDevolucionPrevista_351FI(codigoEjemplar_351FI);
            if (fecha == null || fecha == DBNull.Value) return null;
            return Convert.ToDateTime(fecha);
        }
    }
}
