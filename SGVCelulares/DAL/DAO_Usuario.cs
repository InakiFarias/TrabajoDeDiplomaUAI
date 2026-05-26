using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Usuario : Conexion,IABMC
    {
        
        SqlCommand cm;

        public DAO_Usuario():base()
        {
            cm = new SqlCommand("select * from usuarios", con);
        }
        public void Agregar(params object[] T)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@dni", SqlDbType.VarChar).Value = T[0];
            cm.Parameters.Add("@nombre", SqlDbType.VarChar).Value = T[1];
            cm.Parameters.Add("@apellido", SqlDbType.VarChar).Value = T[2];
            cm.Parameters.Add("@correo", SqlDbType.VarChar).Value = T[3];
            cm.Parameters.Add("@nombreUsuario", SqlDbType.VarChar).Value = T[4];
            cm.Parameters.Add("@password", SqlDbType.VarChar).Value = T[5];
            cm.Parameters.Add("@bloqueo", SqlDbType.VarChar).Value = T[6];
            cm.Parameters.Add("@activo", SqlDbType.VarChar).Value = T[7];

            cm.CommandText = "INSERT INTO usuarios(dni,nombre,apellido,correo,nombreUsuario,password,bloqueo,activo) values (@dni,@nombre,@apellido,@correo,@nombreUsuario,@password,@bloqueo,@activo)";
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
            throw new NotImplementedException();
        }

        public SqlDataReader ConsultarPorId(string id)
        {
            throw new NotImplementedException();
        }

        public void Modificar(string id, params object[] T)
        {
            throw new NotImplementedException();
        }


        public bool ValidarRepetido(string id)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@dni", SqlDbType.VarChar).Value = id;
            cm.CommandText = "SELECT COUNT(*) FROM usuarios WHERE dni = @dni";
            con.Open();
            bool existe = Convert.ToInt16(cm.ExecuteScalar()) > 0;
            con.Close();
            return existe;
        }
        public bool ValidarNombreUsuarioRepetido(string nombreUsuario)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@nombreUsuario", SqlDbType.VarChar).Value = nombreUsuario;
            cm.CommandText = "SELECT COUNT(*) FROM usuarios WHERE nombreUsuario = @nombreUsuario";
            con.Open();
            bool existe = Convert.ToInt16(cm.ExecuteScalar()) > 0;
            con.Close();
            return existe;
        }
        public bool ValidarCorreoRepetido(string correo)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@correo", SqlDbType.VarChar).Value = correo;
            cm.CommandText = "SELECT COUNT(*) FROM usuarios WHERE correo = @correo";
            con.Open();
            bool existe = Convert.ToInt16(cm.ExecuteScalar()) > 0;
            con.Close();
            return existe;
        }
    }
}
