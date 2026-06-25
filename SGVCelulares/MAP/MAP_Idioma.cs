using DAL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP
{
    public class MAP_Idioma
    {
        DAO_Idioma dao_idioma;

        public MAP_Idioma()
        {
            dao_idioma = new DAO_Idioma();
        }

        public Dictionary<string, string> ObtenerTraducciones(string codigo)
        {
            return dao_idioma.ObtenerTraducciones(codigo);
        }

        public List<CultureInfo> ObtenerIdiomasDisponibles()
        {
            return dao_idioma.ObtenerIdiomasDisponibles();
        }
    }
}
