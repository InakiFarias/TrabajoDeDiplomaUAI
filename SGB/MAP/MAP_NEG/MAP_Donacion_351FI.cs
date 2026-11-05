using BE;
using DAL;
using Microsoft.Data.SqlClient;

namespace MAP
{
    public class MAP_Donacion_351FI
    {
        DAO_Donacion_351FI dao_donacion_351FI;
        public MAP_Donacion_351FI()
        {
            dao_donacion_351FI = new DAO_Donacion_351FI();
        }

        // Agrupa las filas de la consulta en una donación con la lista de sus ejemplares
        public List<BE_Donacion_351FI> ObtenerDonaciones_351FI()
        {
            List<BE_Donacion_351FI> lista = new List<BE_Donacion_351FI>();
            SqlDataReader dr = dao_donacion_351FI.ObtenerDonaciones_351FI();
            while (dr.Read())
            {
                int numero = Convert.ToInt32(dr["NumeroDonacion_351FI"]);
                BE_Donacion_351FI? donacion = lista.FirstOrDefault(d => d.NumeroDonacion_351FI == numero);
                if (donacion == null)
                {
                    BE_Socio_351FI socio = new BE_Socio_351FI(
                        Convert.ToInt32(dr["NumeroSocio_351FI"]),
                        Convert.ToString(dr["Nombre_351FI"]),
                        Convert.ToString(dr["Apellido_351FI"]),
                        Convert.ToString(dr["Dni_351FI"]),
                        Convert.ToString(dr["EstadoSocio"]));
                    donacion = new BE_Donacion_351FI(numero, socio, Convert.ToDateTime(dr["FechaDonacion_351FI"]), new List<BE_Ejemplar_351FI>());
                    lista.Add(donacion);
                }

                BE_Libro_351FI libro = new BE_Libro_351FI(Convert.ToString(dr["CodigoLibro_351FI"]), Convert.ToString(dr["Titulo_351FI"]), new List<BE_Autor_351FI>(), new List<BE_Tema_351FI>());
                donacion.Ejemplares_351FI.Add(new BE_Ejemplar_351FI(Convert.ToString(dr["CodigoEjemplar_351FI"]), libro, Convert.ToString(dr["EstadoEjemplar"])));
            }
            dr.Close();
            return lista;
        }

        public int InsertarDonacion_351FI(BE_Donacion_351FI donacion_351FI)
        {
            int numeroDonacion = dao_donacion_351FI.InsertarDonacion_351FI(donacion_351FI.Socio_351FI.NumeroSocio_351FI, donacion_351FI.FechaDonacion_351FI);
            foreach (BE_Ejemplar_351FI ejemplar in donacion_351FI.Ejemplares_351FI)
                dao_donacion_351FI.InsertarDetalle_351FI(numeroDonacion, ejemplar.CodigoEjemplar_351FI);
            return numeroDonacion;
        }

        public int InsertarRecibo_351FI(BE_ReciboDonacion_351FI recibo_351FI) => dao_donacion_351FI.InsertarRecibo_351FI(recibo_351FI.Donacion_351FI.NumeroDonacion_351FI, recibo_351FI.FechaEmision_351FI);
    }
}
