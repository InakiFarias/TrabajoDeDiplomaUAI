using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class SER_Bitacora
    {
        public SER_Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Evento { get; set; }
        public string Modulo { get; set; }
        public int Criticidad { get; set; }
        public SER_Bitacora(SER_Usuario usuario, DateTime fecha, string evento, string modulo, int criticidad)
        {
            Usuario = usuario;
            Fecha = fecha;
            Evento = evento;
            Modulo = modulo;
            Criticidad = criticidad;
        }
    }
}
