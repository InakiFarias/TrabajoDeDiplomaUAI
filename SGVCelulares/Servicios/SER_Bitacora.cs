using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Servicios
{
    public class SER_Bitacora
    {
        public SER_Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Evento { get; set; }
        public string Modulo { get; set; }
        public int Criticidad { get; set; }
        public SER_Bitacora(SER_Usuario usuario, DateTime fecha, string modulo, string evento, int criticidad)
        {
            Usuario = usuario;
            Fecha = fecha;
            Modulo = modulo;
            Evento = evento;
            Criticidad = criticidad;
        }
    }
}
