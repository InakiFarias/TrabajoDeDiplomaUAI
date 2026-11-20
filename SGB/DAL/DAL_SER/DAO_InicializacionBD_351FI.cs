using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace DAL.DAL_SER
{
    // Crea la base del sistema en el primer inicio, ejecutando los scripts de BD_SQL contra master
    public class DAO_InicializacionBD_351FI : Conexion_351FI
    {
        // Los scripts de BD_SQL crean y usan esta base (CREATE DATABASE / USE bd_sgb)
        private const string NOMBRE_BASE_351FI = "bd_sgb";

        SqlCommand cm_351FI;
        SqlConnection conMaster_351FI;
        private readonly string carpetaScripts_351FI =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BD_SQL");

        public DAO_InicializacionBD_351FI() : base()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(this.ObtenerCadenaConexion_351FI());
            if (!string.Equals(builder.InitialCatalog, NOMBRE_BASE_351FI, StringComparison.OrdinalIgnoreCase))
                throw new Exception($"La cadena de conexión del archivo .env debe indicar Database={NOMBRE_BASE_351FI}, que es la base que crean los scripts.");

            builder.InitialCatalog = "master";
            conMaster_351FI = new SqlConnection(builder.ConnectionString);
            cm_351FI = new SqlCommand();
            cm_351FI.Connection = conMaster_351FI;
            cm_351FI.CommandType = CommandType.Text;
            cm_351FI.CommandTimeout = 120;
        }

        public bool ExisteBase_351FI()
        {
            bool existe;
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = NOMBRE_BASE_351FI;
            cm_351FI.CommandText = "SELECT DB_ID(@nombre)";
            try
            {
                conMaster_351FI.Open();
                existe = cm_351FI.ExecuteScalar() != DBNull.Value;
            }
            catch (SqlException ex)
            {
                throw new Exception(TraducirError_351FI(ex));
            }
            finally
            {
                conMaster_351FI.Close();
            }
            return existe;
        }

        // Ejecuta los scripts en orden, en una sola conexión (los USE y las transacciones dependen de la sesión).
        // Si algo falla, borra la base a medias para que el próximo inicio la vuelva a crear desde cero.
        public void CrearBase_351FI(List<string> scripts_351FI)
        {
            // Se leen todos antes de empezar: si falta uno, no se crea nada
            List<string> lotes = new List<string>();
            foreach (string script in scripts_351FI)
            {
                string ruta = Path.Combine(carpetaScripts_351FI, script);
                if (!File.Exists(ruta))
                    throw new Exception($"No se encontró el script de base de datos {ruta}.");
                lotes.AddRange(SepararLotes_351FI(File.ReadAllText(ruta)));
            }

            cm_351FI.Parameters.Clear();
            try
            {
                conMaster_351FI.Open();
                foreach (string lote in lotes)
                {
                    cm_351FI.CommandText = lote;
                    cm_351FI.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                conMaster_351FI.Close();
                BorrarBaseIncompleta_351FI();
                throw new Exception(TraducirError_351FI(ex));
            }
            finally
            {
                conMaster_351FI.Close();
            }
        }

        // Abre la base con la cadena del .env, para detectar si existe pero el usuario no tiene acceso
        public void VerificarAcceso_351FI()
        {
            try
            {
                con_351FI.Open();
            }
            catch (SqlException ex)
            {
                throw new Exception(TraducirError_351FI(ex));
            }
            finally
            {
                con_351FI.Close();
            }
        }

        // GO no es T-SQL: es el separador de lotes de SSMS/sqlcmd, así que se parte el script por esas líneas
        private List<string> SepararLotes_351FI(string script_351FI)
        {
            List<string> lotes = new List<string>();
            foreach (string lote in Regex.Split(script_351FI, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase))
            {
                if (!string.IsNullOrWhiteSpace(lote))
                    lotes.Add(lote);
            }
            return lotes;
        }

        private void BorrarBaseIncompleta_351FI()
        {
            // La conexión que falló quedó en el pool apuntando a la base: se descartan para poder borrarla
            SqlConnection.ClearAllPools();
            cm_351FI.CommandText = $@"IF DB_ID('{NOMBRE_BASE_351FI}') IS NOT NULL
                                      BEGIN
                                          ALTER DATABASE [{NOMBRE_BASE_351FI}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                                          DROP DATABASE [{NOMBRE_BASE_351FI}];
                                      END";
            try
            {
                conMaster_351FI.Open();
                cm_351FI.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                // Si no se puede borrar, se informa el error original igual
            }
            finally
            {
                conMaster_351FI.Close();
            }
        }

        private string TraducirError_351FI(SqlException ex_351FI)
        {
            string mensaje;
            switch (ex_351FI.Number)
            {
                case -1:
                case 2:
                case 26:
                case 53:
                    mensaje = "No se encontró la instancia de SQL Server indicada en el archivo .env (Server=...), o el servicio de SQL Server está detenido.";
                    break;
                case 18456:
                    mensaje = "Tu usuario de Windows no tiene acceso a la instancia de SQL Server. Pedí que te den un login en la instancia.";
                    break;
                case 262:
                case 1802:
                    mensaje = "Tu usuario de Windows no tiene permiso para crear bases de datos en la instancia (rol dbcreator).";
                    break;
                case 4060:
                    mensaje = $"La base {NOMBRE_BASE_351FI} existe, pero tu usuario de Windows no tiene acceso a ella (puede haberla creado otro usuario de esta PC).";
                    break;
                default:
                    if (ex_351FI.Message.Contains("certificate", StringComparison.OrdinalIgnoreCase))
                        mensaje = "SQL Server usa un certificado no confiable. Agregá TrustServerCertificate=True a la cadena del archivo .env.";
                    else
                        mensaje = $"Error de SQL Server al crear la base ({ex_351FI.Number}): {ex_351FI.Message}";
                    break;
            }
            return mensaje;
        }
    }
}
