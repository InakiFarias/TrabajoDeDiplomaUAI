using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL.DAL_SER
{
    public class DAO_Familia_351FI : Conexion_351FI, IABMC_351FI
    {
        SqlCommand cm_351FI;
        public DAO_Familia_351FI() : base()
        {
            cm_351FI = new SqlCommand("select * from familia_351FI", con_351FI);
        }
        public void Agregar_351FI(params object[] datos_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@nombre", SqlDbType.VarChar).Value = datos_351FI[0];

            cm_351FI.CommandText = "INSERT INTO familia_351FI(nombre_351FI) values (@nombre)";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public void Borrar_351FI(string id_351FI)
        {
            throw new NotImplementedException();
        }
        public void Modificar_351FI(string id_351FI, params object[] datos_351FI)
        {
            throw new NotImplementedException();
        }
        public SqlDataReader Consultar_351FI()
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.CommandText = "SELECT * FROM familia_351FI";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader ConsultarPorId_351FI(string id_351FI)
        {
            throw new NotImplementedException();
        }
        public bool ValidarRepetido_351FI(string id_351FI)
        {
            throw new NotImplementedException();
        }
        public void AgregarPermiso_351FI(int idFamilia_351FI, int idPermiso_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@idFamilia", SqlDbType.Int).Value = idFamilia_351FI;
            cm_351FI.Parameters.Add("@idPermiso", SqlDbType.Int).Value = idPermiso_351FI;

            cm_351FI.CommandText = "INSERT INTO permiso_familia_351FI(idFamilia_351FI, idPermiso_351FI) values (@idFamilia, @idPermiso)";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }
        public void AgregarFamilia_351FI(int idFamiliaPadre_351FI, int idFamiliaHija_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@idFamiliaPadre", SqlDbType.Int).Value = idFamiliaPadre_351FI;
            cm_351FI.Parameters.Add("@idFamiliaHija", SqlDbType.Int).Value = idFamiliaHija_351FI;

            cm_351FI.CommandText = "INSERT INTO familia_familia_351FI(idFamiliaPadre_351FI,idFamiliaHija_351FI) values (@idFamiliaPadre,@idFamiliaHija)";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }
        public SqlDataReader ObtenerIdPorNombre_351FI(string nombre_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre_351FI;
            cm_351FI.CommandText = "SELECT TOP 1 idFamilia_351FI, nombre_351FI FROM familia_351FI WHERE nombre_351FI=@nombre";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }
        // Métodos que van a servir para armar recursivamente los nodos de un arbol determinado
        public SqlDataReader ConsultarPermisos_351FI(int idFamilia_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@idFamilia", SqlDbType.Int).Value = idFamilia_351FI;
            cm_351FI.CommandText = "select p.idPermiso_351FI, p.nombre_351FI from permiso_351FI p inner join permiso_familia_351FI pf on p.idPermiso_351FI = pf.idPermiso_351FI where pf.idFamilia_351FI = @idFamilia";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public SqlDataReader ConsultarFamilia_351FI(int idFamilia_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@idFamilia", SqlDbType.Int).Value = idFamilia_351FI;
            cm_351FI.CommandText = "select idFamilia_351FI, nombre_351FI from familia_351FI where idFamilia_351FI = @idFamilia";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public SqlDataReader ConsultarFamiliasHijas_351FI(int idFamilia_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@idFamilia", SqlDbType.Int).Value = idFamilia_351FI;
            cm_351FI.CommandText = "select f.idFamilia_351FI, f.nombre_351FI from familia_351FI f inner join familia_familia_351FI ff on f.idFamilia_351FI = ff.idFamiliaHija_351FI where ff.idFamiliaPadre_351FI = @idFamilia";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public bool ExisteFamilia_351FI(string nombreFamilia_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@familia", SqlDbType.VarChar).Value = nombreFamilia_351FI;
            cm_351FI.CommandText = "SELECT COUNT(*) FROM familia_351FI WHERE nombre_351FI = @familia";
            con_351FI.Open();
            bool existe = Convert.ToInt16(cm_351FI.ExecuteScalar()) > 0;
            con_351FI.Close();
            return existe;
        }
        public bool EstaEnUso_351FI(int idFamilia_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@idFamilia", SqlDbType.Int).Value = idFamilia_351FI;
            cm_351FI.CommandText = @"SELECT
        (SELECT COUNT(*) FROM rol_familia_351FI WHERE idFamilia_351FI=@idFamilia) +
        (SELECT COUNT(*) FROM familia_familia_351FI WHERE idFamiliaHija_351FI=@idFamilia)";
            con_351FI.Open();
            bool enUso = Convert.ToInt32(cm_351FI.ExecuteScalar()) > 0;
            con_351FI.Close();
            return enUso;
        }

        public void Borrar_351FI(int idFamilia_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@idFamilia", SqlDbType.Int).Value = idFamilia_351FI;
            cm_351FI.CommandText = @"DELETE FROM permiso_familia_351FI WHERE idFamilia_351FI=@idFamilia;
                       DELETE FROM familia_familia_351FI WHERE idFamiliaPadre_351FI=@idFamilia;
                       DELETE FROM familia_351FI WHERE idFamilia_351FI=@idFamilia";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }
    }
}
