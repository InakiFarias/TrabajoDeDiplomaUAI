using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class SER_Idioma_351FI
    {
        public string Codigo_351FI { get; set; }
        public string Nombre_351FI { get; set; }
        public Dictionary<string, string> Textos_351FI { get; set; }
        public SER_Idioma_351FI()
        {
            Textos_351FI = new Dictionary<string, string>();
        }

        public SER_Idioma_351FI(string codigo_351FI)
        {
            Codigo_351FI = codigo_351FI;
            Textos_351FI = new Dictionary<string, string>();
        }

        public SER_Idioma_351FI(string codigo_351FI, Dictionary<string, string> textos_351FI)
        {
            Codigo_351FI = codigo_351FI;
            Textos_351FI = textos_351FI ?? new Dictionary<string, string>();
        }
        public SER_Idioma_351FI(string codigo_351FI, string nombre_351FI)
        {
            Codigo_351FI = codigo_351FI;
            Nombre_351FI = nombre_351FI;
            Textos_351FI = new Dictionary<string, string>();
        }

    }
}
