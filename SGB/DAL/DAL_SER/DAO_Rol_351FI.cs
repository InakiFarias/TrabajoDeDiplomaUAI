using Microsoft.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL.DAL_SER
{
    public class DAO_Rol_351FI : Conexion_351FI
    {
        SqlCommand cm_351FI;
        public DAO_Rol_351FI() : base()
        {
            cm_351FI = new SqlCommand("select * from rol_351FI", con_351FI);
        }
        public void Agregar_351FI(params object[] datos_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@nombre", SqlDbType.VarChar).Value = datos_351FI[0];

            cm_351FI.CommandText = "INSERT INTO rol_351FI(nombre_351FI) values (@nombre)";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }
        public SqlDataReader ObtenerIdPorNombre_351FI(string nombre_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre_351FI;
            cm_351FI.CommandText = "SELECT TOP 1 idRol_351FI, nombre_351FI FROM rol_351FI WHERE nombre_351FI=@nombre";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader Consultar_351FI()
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.CommandText = "SELECT * FROM rol_351FI";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public SqlDataReader ConsultarRol_351FI(int idRol_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@idRol", SqlDbType.Int).Value = idRol_351FI;
            cm_351FI.CommandText = "SELECT idRol_351FI, nombre_351FI FROM rol_351FI WHERE idRol_351FI=@idRol";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public SqlDataReader ConsultarPermisos_351FI(int idRol_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@idRol", SqlDbType.Int).Value = idRol_351FI;
            cm_351FI.CommandText = "select p.idPermiso_351FI, p.nombre_351FI from permiso_351FI p inner join rol_permiso_351FI rp on p.idPermiso_351FI = rp.idPermiso_351FI where rp.idRol_351FI = @idRol";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public SqlDataReader ConsultarFamilia_351FI(int idRol_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@idRol", SqlDbType.Int).Value = idRol_351FI;
            cm_351FI.CommandText = "select f.idFamilia_351FI, f.nombre_351FI from familia_351FI f inner join rol_familia_351FI rf on f.idFamilia_351FI = rf.idFamilia_351FI where rf.idRol_351FI = @idRol";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }


        public bool ExisteRol_351FI(string nombreRol_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@rol", SqlDbType.VarChar).Value = nombreRol_351FI;
            cm_351FI.CommandText = "SELECT COUNT(*) FROM rol_351FI WHERE nombre_351FI = @rol";
            con_351FI.Open();
            bool existe = Convert.ToInt16(cm_351FI.ExecuteScalar()) > 0;
            con_351FI.Close();
            return existe;
        }
        public void AgregarPermiso_351FI(int idRol_351FI, int idPermiso_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@idRol", SqlDbType.Int).Value = idRol_351FI;
            cm_351FI.Parameters.Add("@idPermiso", SqlDbType.Int).Value = idPermiso_351FI;

            cm_351FI.CommandText = "INSERT INTO rol_permiso_351FI(idRol_351FI,idPermiso_351FI) values (@idRol,@idPermiso)";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }
        public void AgregarFamilia_351FI(int idRol_351FI, int idFamilia_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@idRol", SqlDbType.Int).Value = idRol_351FI;
            cm_351FI.Parameters.Add("@idFamilia", SqlDbType.Int).Value = idFamilia_351FI;

            cm_351FI.CommandText = "INSERT INTO rol_familia_351FI(idRol_351FI,idFamilia_351FI) values (@idRol,@idFamilia)";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }
        public void Borrar_351FI(int idRol_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@idRol", SqlDbType.Int).Value = idRol_351FI;
            cm_351FI.CommandText = @"DELETE FROM rol_permiso_351FI WHERE idRol_351FI=@idRol;
                       DELETE FROM rol_familia_351FI WHERE idRol_351FI=@idRol;
                       DELETE FROM rol_351FI WHERE idRol_351FI=@idRol";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }
        public bool EstaEnUso_351FI(int idRol_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@idRol", SqlDbType.Int).Value = idRol_351FI;
            cm_351FI.CommandText = "SELECT COUNT(*) FROM usuario_351FI WHERE idRol_351FI=@idRol";
            con_351FI.Open();
            bool enUso = Convert.ToInt32(cm_351FI.ExecuteScalar()) > 0;
            con_351FI.Close();
            return enUso;
        }
    }
}
