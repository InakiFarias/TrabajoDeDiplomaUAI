using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Rol : Conexion, IABMC
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

        public void Borrar(string id)
        {
            throw new NotImplementedException();
        }

        public SqlDataReader Consultar()
        {
            cm.Parameters.Clear();
            cm.CommandText = "SELECT * FROM rol";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader ConsultarPorId(string id)
        {
            throw new NotImplementedException();
        }

        public void Modificar(string id, params object[] datos)
        {
            throw new NotImplementedException();
        }

        public bool ValidarRepetido(string id)
        {
            throw new NotImplementedException();
        }
    }
}
