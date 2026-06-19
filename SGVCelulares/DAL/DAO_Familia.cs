using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Familia : Conexion, IABMC
    {
        SqlCommand cm;
        public DAO_Familia() : base()
        {
            cm = new SqlCommand("select * from familia", con);
        }
        public void Agregar(params object[] datos)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@nombre", SqlDbType.VarChar).Value = datos[0];

            cm.CommandText = "INSERT INTO familia(nombre) values (@nombre)";
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
            cm.CommandText = "SELECT * FROM familia";
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
        public bool ExistePermiso(int idFamilia, int idPermiso)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@idFamilia", SqlDbType.Int).Value = idFamilia;
            cm.Parameters.Add("@idPermiso", SqlDbType.Int).Value = idPermiso;
            cm.CommandText = "SELECT COUNT(*) FROM permiso_familia WHERE idFamilia=@idFamilia and idPermiso=@idPermiso";
            con.Open();
            bool existe = Convert.ToInt16(cm.ExecuteScalar()) > 0;
            con.Close();
            return existe;
        }
        public void AgregarPermiso(int idFamilia, int idPermiso)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@idFamilia", SqlDbType.Int).Value = idFamilia;
            cm.Parameters.Add("@idPermiso", SqlDbType.Int).Value = idPermiso;

            cm.CommandText = "INSERT INTO permiso_familia(idFamilia, idPermiso) values (@idFamilia, @idPermiso)";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataReader ConsultarFamilias()
        {
            cm.Parameters.Clear();
            cm.CommandText = "SELECT idFamilia, nombre FROM familia";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public SqlDataReader ConsultarRelacionesFamilia()
        {
            cm.Parameters.Clear();
            cm.CommandText = "SELECT idFamiliaPadre, idFamiliaHija FROM familia_familia";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public SqlDataReader ConsultarPermisosFamilia()
        {
            cm.Parameters.Clear();
            cm.CommandText = "SELECT idFamilia, idPermiso FROM permiso_familia";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
