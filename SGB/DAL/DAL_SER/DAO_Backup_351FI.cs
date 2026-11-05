using Microsoft.Data.SqlClient;
using System.Data;
using System.Net;
using DotNetEnv;

namespace DAL.DAL_SER
{
    public class DAO_Backup_351FI : Conexion_351FI
    {
        SqlCommand cm_351FI;
        SqlConnection con_351FI;
        string nombreBase_351FI;
        public DAO_Backup_351FI()
        {
            string cadena = this.ObtenerCadenaConexion_351FI();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cadena);

            // La base a respaldar es la de la cadena de conexión del .env; los comandos se ejecutan desde master
            if (string.IsNullOrWhiteSpace(builder.InitialCatalog))
                throw new InvalidOperationException("La cadena de conexión del archivo .env no indica la base de datos (Database=...).");
            nombreBase_351FI = "[" + builder.InitialCatalog.Replace("]", "]]") + "]";

            builder.InitialCatalog = "master";
            con_351FI = new SqlConnection(builder.ConnectionString);
            cm_351FI = new SqlCommand();
            cm_351FI.Connection = con_351FI;
            cm_351FI.CommandType = CommandType.Text;
        }

        public void Backup_351FI(string ruta_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@ruta", SqlDbType.VarChar).Value = ruta_351FI;
            cm_351FI.CommandText = $"BACKUP DATABASE {nombreBase_351FI} TO DISK = @ruta WITH INIT";
            con_351FI.Open();
            try
            {
                cm_351FI.ExecuteNonQuery();
            }
            finally
            {
                con_351FI.Close();
            }
        }

        public void Restore_351FI(string ruta_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@ruta", SqlDbType.VarChar).Value = ruta_351FI;
            // Si el restore falla, la base vuelve a MULTI_USER para no quedar bloqueada
            cm_351FI.CommandText = $@"ALTER DATABASE {nombreBase_351FI} SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                                    BEGIN TRY
                                        RESTORE DATABASE {nombreBase_351FI} FROM DISK = @ruta WITH REPLACE;
                                        ALTER DATABASE {nombreBase_351FI} SET MULTI_USER;
                                    END TRY
                                    BEGIN CATCH
                                        ALTER DATABASE {nombreBase_351FI} SET MULTI_USER;
                                        THROW;
                                    END CATCH";
            con_351FI.Open();
            try
            {
                cm_351FI.ExecuteNonQuery();
            }
            finally
            {
                con_351FI.Close();
                // El restore cortó las conexiones abiertas: se descartan las del pool para que el sistema abra nuevas
                SqlConnection.ClearAllPools();
            }
        }
    }
}
