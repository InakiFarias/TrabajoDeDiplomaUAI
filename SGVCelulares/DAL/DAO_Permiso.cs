using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Permiso : Conexion, IABMC
    {
        SqlCommand cm;
        public DAO_Permiso() : base()
        {
            cm = new SqlCommand("select * from permiso", con);
        }
        public void Agregar(params object[] datos)
        {
            throw new NotImplementedException();
        }

        public void Borrar(string id)
        {
            throw new NotImplementedException();
        }

        public SqlDataReader Consultar()
        {
            cm.Parameters.Clear();
            cm.CommandText = "SELECT * FROM permiso";
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
