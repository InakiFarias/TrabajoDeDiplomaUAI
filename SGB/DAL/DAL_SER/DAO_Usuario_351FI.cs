using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Usuario_351FI : Conexion_351FI,IABMC_351FI
    {
        SqlCommand cm_351FI;
        public DAO_Usuario_351FI() : base()
        {
            cm_351FI = new SqlCommand("select * from usuario_351FI", con_351FI);
        }
        public void Agregar_351FI(params object[] T_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@dni", SqlDbType.VarChar).Value = T_351FI[0];
            cm_351FI.Parameters.Add("@nombre", SqlDbType.VarChar).Value = T_351FI[1];
            cm_351FI.Parameters.Add("@apellido", SqlDbType.VarChar).Value = T_351FI[2];
            cm_351FI.Parameters.Add("@correo", SqlDbType.VarChar).Value = T_351FI[3];
            cm_351FI.Parameters.Add("@nombreUsuario", SqlDbType.VarChar).Value = T_351FI[4];
            cm_351FI.Parameters.Add("@password", SqlDbType.VarChar).Value = T_351FI[5];
            cm_351FI.Parameters.Add("@bloqueo", SqlDbType.Bit).Value = T_351FI[6];
            cm_351FI.Parameters.Add("@activo", SqlDbType.Bit).Value = T_351FI[7];
            cm_351FI.Parameters.Add("@cantIntentos", SqlDbType.TinyInt).Value = T_351FI[8];
            cm_351FI.Parameters.Add("@idRol", SqlDbType.Int).Value = T_351FI[9];
            cm_351FI.Parameters.Add("@idIdioma", SqlDbType.VarChar).Value = T_351FI[10];

            cm_351FI.CommandText = "INSERT INTO usuario_351FI(dni_351FI,nombre_351FI,apellido_351FI,correo_351FI,nombreUsuario_351FI,password_351FI,bloqueo_351FI,activo_351FI,cantIntentos_351FI,idRol_351FI,idIdioma_351FI) values (@dni,@nombre,@apellido,@correo,@nombreUsuario,@password,@bloqueo,@activo,@cantIntentos,@idRol,@idIdioma)";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public void Borrar_351FI(string id_351FI)
        {
            throw new NotImplementedException();
        }
        public void Modificar_351FI(string dni_351FI, params object[] T_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni_351FI;
            cm_351FI.Parameters.Add("@nombre", SqlDbType.VarChar).Value = T_351FI[0];
            cm_351FI.Parameters.Add("@apellido", SqlDbType.VarChar).Value = T_351FI[1];
            cm_351FI.Parameters.Add("@nombreUsuario", SqlDbType.VarChar).Value = T_351FI[2];
            cm_351FI.CommandText = "UPDATE usuario_351FI SET nombre_351FI=@nombre,apellido_351FI=@apellido,nombreUsuario_351FI=@nombreUsuario WHERE dni_351FI=@dni";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }
        public void ModificarPassword_351FI(string dni_351FI, string password_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni_351FI;
            cm_351FI.Parameters.Add("@password", SqlDbType.VarChar).Value = password_351FI;
            cm_351FI.CommandText = "UPDATE usuario_351FI SET password_351FI=@password WHERE dni_351FI=@dni";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }
        public SqlDataReader Consultar_351FI()
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.CommandText = "SELECT * FROM usuario_351FI";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader ConsultarPorId_351FI(string dni_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni_351FI;
            cm_351FI.CommandText = "SELECT * FROM usuario_351FI WHERE dni_351FI=@dni";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public SqlDataReader ConsultarPorNombreUsuario_351FI(string nombreUsuario_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@nombreUsuario", SqlDbType.VarChar).Value = nombreUsuario_351FI;
            cm_351FI.CommandText = "SELECT * FROM usuario_351FI WHERE nombreUsuario_351FI=@nombreUsuario";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }
      
        public bool ValidarRepetido_351FI(string dni_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni_351FI;
            cm_351FI.CommandText = "SELECT COUNT(*) FROM usuario_351FI WHERE dni_351FI = @dni";
            con_351FI.Open();
            bool existe = Convert.ToInt16(cm_351FI.ExecuteScalar()) > 0;
            con_351FI.Close();
            return existe;
        }
        public bool ExisteNombreUsuario_351FI(string nombreUsuario_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@nombreUsuario", SqlDbType.VarChar).Value = nombreUsuario_351FI;
            cm_351FI.CommandText = "SELECT COUNT(*) FROM usuario_351FI WHERE nombreUsuario_351FI = @nombreUsuario";
            con_351FI.Open();
            bool existe = Convert.ToInt16(cm_351FI.ExecuteScalar()) > 0;
            con_351FI.Close();
            return existe;
        }
        public bool ValidarCorreoRepetido_351FI(string correo_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@correo", SqlDbType.VarChar).Value = correo_351FI;
            cm_351FI.CommandText = "SELECT COUNT(*) FROM usuario_351FI WHERE correo_351FI = @correo";
            con_351FI.Open();
            bool existe = Convert.ToInt16(cm_351FI.ExecuteScalar()) > 0;
            con_351FI.Close();
            return existe;
        }
        public void ReiniciarIntentos_351FI(string dni_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni_351FI;
            cm_351FI.CommandText = "UPDATE usuario_351FI SET cantIntentos_351FI=0 WHERE dni_351FI=@dni";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }
        public void SumarCantidadIntento_351FI(string dni_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni_351FI;
            cm_351FI.CommandText = "UPDATE usuario_351FI SET cantIntentos_351FI=cantIntentos_351FI+1 WHERE dni_351FI=@dni";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }
        public void Bloquear_351FI(string dni_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni_351FI;
            cm_351FI.CommandText = "UPDATE usuario_351FI SET bloqueo_351FI=1 WHERE dni_351FI=@dni";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }
        public void Desbloquear_351FI(string dni_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni_351FI;
            cm_351FI.CommandText = "UPDATE usuario_351FI SET bloqueo_351FI=0 WHERE dni_351FI=@dni";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }
        public void CambiarEstadoActivo_351FI(string dni_351FI, bool activo_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni_351FI;
            cm_351FI.Parameters.Add("@activo", SqlDbType.Bit).Value = activo_351FI;
            cm_351FI.CommandText = "UPDATE usuario_351FI SET activo_351FI=@activo WHERE dni_351FI=@dni";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }
        public void ModificarIdioma_351FI(string dni_351FI, string idIdioma_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni_351FI;
            cm_351FI.Parameters.Add("@idIdioma", SqlDbType.VarChar).Value = idIdioma_351FI;
            cm_351FI.CommandText = "UPDATE usuario_351FI SET idIdioma_351FI=@idIdioma WHERE dni_351FI=@dni";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }
    }
}
