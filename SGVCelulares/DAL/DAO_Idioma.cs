using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAO_Idioma
    {
        private readonly string carpeta =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Idiomas");
        public Dictionary<string, string> ObtenerTraducciones(string codigo)
        {
            string ruta = Path.Combine(carpeta, codigo + ".json");

            if (!File.Exists(ruta))
                throw new Exception("No se encontró el archivo del idioma seleccionado.");

            string contenido = File.ReadAllText(ruta);

            return System.Text.Json.JsonSerializer
                       .Deserialize<Dictionary<string, string>>(contenido)
                   ?? new Dictionary<string, string>();
        }
        public List<CultureInfo> ObtenerIdiomasDisponibles()
        {
            var idiomas = new List<CultureInfo>();

            if (!Directory.Exists(carpeta))
                return idiomas;

            foreach (string archivo in Directory.GetFiles(carpeta, "*.json"))
            {
                string codigo = Path.GetFileNameWithoutExtension(archivo);
                try
                {
                    idiomas.Add(new CultureInfo(codigo));
                }
                catch (CultureNotFoundException)
                {
                }
            }

            return idiomas;
        }
    }
}
