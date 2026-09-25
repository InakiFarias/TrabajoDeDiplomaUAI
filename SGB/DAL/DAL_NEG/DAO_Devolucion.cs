using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Devolucion : Conexion
    {
        SqlCommand cm;
        public DAO_Devolucion() : base()
        {
            cm = new SqlCommand("select * from Devolucion", con);
        }
    }
}
