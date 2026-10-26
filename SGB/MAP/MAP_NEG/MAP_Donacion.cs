using BE;
using DAL;
using Microsoft.Data.SqlClient;

namespace MAP
{
    public class MAP_Donacion
    {
        DAO_Donacion dao_donacion;
        public MAP_Donacion()
        {
            dao_donacion = new DAO_Donacion();
        }

        // Agrupa las filas de la consulta en una donación con la lista de sus ejemplares
        public List<BE_Donacion> ObtenerDonaciones()
        {
            List<BE_Donacion> lista = new List<BE_Donacion>();
            SqlDataReader dr = dao_donacion.ObtenerDonaciones();
            while (dr.Read())
            {
                int numero = Convert.ToInt32(dr["NumeroDonacion"]);
                BE_Donacion? donacion = lista.FirstOrDefault(d => d.NumeroDonacion == numero);
                if (donacion == null)
                {
                    BE_Socio socio = new BE_Socio(
                        Convert.ToInt32(dr["NumeroSocio"]),
                        Convert.ToString(dr["Nombre"]),
                        Convert.ToString(dr["Apellido"]),
                        Convert.ToString(dr["Dni"]),
                        Convert.ToString(dr["EstadoSocio"]));
                    donacion = new BE_Donacion(numero, socio, Convert.ToDateTime(dr["FechaDonacion"]), new List<BE_Ejemplar>());
                    lista.Add(donacion);
                }

                BE_Libro libro = new BE_Libro(Convert.ToString(dr["CodigoLibro"]), Convert.ToString(dr["Titulo"]), new List<BE_Autor>(), new List<BE_Tema>());
                donacion.Ejemplares.Add(new BE_Ejemplar(Convert.ToString(dr["CodigoEjemplar"]), libro, Convert.ToString(dr["EstadoEjemplar"])));
            }
            dr.Close();
            return lista;
        }

        public int InsertarDonacion(BE_Donacion donacion)
        {
            int numeroDonacion = dao_donacion.InsertarDonacion(donacion.Socio.NumeroSocio, donacion.FechaDonacion);
            foreach (BE_Ejemplar ejemplar in donacion.Ejemplares)
                dao_donacion.InsertarDetalle(numeroDonacion, ejemplar.CodigoEjemplar);
            return numeroDonacion;
        }

        public int InsertarRecibo(BE_ReciboDonacion recibo) => dao_donacion.InsertarRecibo(recibo.Donacion.NumeroDonacion, recibo.FechaEmision);
    }
}
