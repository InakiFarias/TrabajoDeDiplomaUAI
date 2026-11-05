using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_SER
{
    public class DAO_Idioma_351FI : Conexion_351FI
    {
        SqlCommand cm_351FI;
        private readonly string carpeta_351FI =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Idiomas");
        public DAO_Idioma_351FI() : base()
        {
            cm_351FI = new SqlCommand();
            cm_351FI.Connection = con_351FI;
        }
        public SqlDataReader ObtenerIdiomasDisponibles_351FI()
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.CommandText = "SELECT idIdioma_351FI, Nombre_351FI FROM idioma_351FI ORDER BY CASE WHEN idIdioma_351FI = 'es-AR' THEN 0 ELSE 1 END, Nombre_351FI";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public Dictionary<string, string> ObtenerTraducciones_351FI(string codigo_351FI)
        {
            string ruta = Path.Combine(carpeta_351FI, codigo_351FI + ".json");

            if (!File.Exists(ruta))
                throw new Exception("No se encontró el archivo del idioma seleccionado.");

            string contenido = File.ReadAllText(ruta);

            return System.Text.Json.JsonSerializer
                       .Deserialize<Dictionary<string, string>>(contenido)
                   ?? new Dictionary<string, string>();
        }
    }
}
