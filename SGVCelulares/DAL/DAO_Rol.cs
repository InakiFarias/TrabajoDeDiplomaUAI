using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Rol : Conexion
    {
        SqlCommand cm;
        public DAO_Rol() : base()
        {
            cm = new SqlCommand("select * from rol", con);
        }
        public void Agregar(params object[] datos)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@nombre", SqlDbType.VarChar).Value = datos[0];

            cm.CommandText = "INSERT INTO rol(nombre) values (@nombre)";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        public SqlDataReader Consultar()
        {
            cm.Parameters.Clear();
            cm.CommandText = "SELECT * FROM rol";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public bool ExisteRol(string nombreRol)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@rol", SqlDbType.VarChar).Value = nombreRol;
            cm.CommandText = "SELECT COUNT(*) FROM rol WHERE nombre = @rol";
            con.Open();
            bool existe = Convert.ToInt16(cm.ExecuteScalar()) > 0;
            con.Close();
            return existe;
        }
    }
}
