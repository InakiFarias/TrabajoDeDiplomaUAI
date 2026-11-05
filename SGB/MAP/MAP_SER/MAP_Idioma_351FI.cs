using DAL.DAL_SER;
using Microsoft.Data.SqlClient;
using Servicio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP.MAP_SER
{
    public class MAP_Idioma_351FI
    {
        DAO_Idioma_351FI dao_idioma_351FI;

        public MAP_Idioma_351FI()
        {
            dao_idioma_351FI = new DAO_Idioma_351FI();
        }
        public List<SER_Idioma_351FI> ObtenerIdiomasDisponibles_351FI()
        {
            List<SER_Idioma_351FI> idiomas = new List<SER_Idioma_351FI>();
            SqlDataReader reader = dao_idioma_351FI.ObtenerIdiomasDisponibles_351FI();
            while (reader.Read())
            {
                string codigo = reader.GetString(0);   
                string nombre = reader.GetString(1);   
                idiomas.Add(new SER_Idioma_351FI(codigo, nombre));
            }
            reader.Close();
            return idiomas;
        }
        public Dictionary<string, string> ObtenerTraducciones_351FI(string codigo_351FI)
        {
            return dao_idioma_351FI.ObtenerTraducciones_351FI(codigo_351FI);
        }
    }
}
