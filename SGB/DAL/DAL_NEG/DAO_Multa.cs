using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Multa : Conexion
    {
        SqlCommand cm;
        public DAO_Multa() : base()
        {
            cm = new SqlCommand("select * from Multa", con);
        }
    }
}
