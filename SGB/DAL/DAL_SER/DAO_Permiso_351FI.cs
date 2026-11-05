using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL.DAL_SER
{
    public class DAO_Permiso_351FI : Conexion_351FI
    {
        SqlCommand cm_351FI;
        public DAO_Permiso_351FI() : base()
        {
            cm_351FI = new SqlCommand("select * from permiso_351FI", con_351FI);
        }

        public SqlDataReader Consultar_351FI()
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.CommandText = "SELECT * FROM permiso_351FI";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
