using DAL.DAL_SER;
using Microsoft.Data.SqlClient;
using Servicio;

namespace MAP.MAP_SER
{
    public class MAP_Permiso_351FI
    {
        DAO_Permiso_351FI dao_permiso_351FI;

        public MAP_Permiso_351FI()
        {
            dao_permiso_351FI = new DAO_Permiso_351FI();
        }
        public List<SER_Permiso_351FI> Consultar_351FI()
        {
            List<SER_Permiso_351FI> lista = new List<SER_Permiso_351FI>();
            SqlDataReader dr = dao_permiso_351FI.Consultar_351FI();

            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                lista.Add(new SER_Permiso_351FI(datos));
            }
            dr.Close();
            return lista;
        }
    }
}
