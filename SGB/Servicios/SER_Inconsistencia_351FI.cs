using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class SER_Inconsistencia_351FI
    {
        public string NombreTabla_351FI { get; set; }
        public string IdRegistro_351FI { get; set; }
        public string Mensaje_351FI { get; set; }

        public SER_Inconsistencia_351FI(string nombreTabla_351FI, string idRegistro_351FI, string mensaje_351FI)
        {
            NombreTabla_351FI = nombreTabla_351FI;
            IdRegistro_351FI = idRegistro_351FI;
            Mensaje_351FI = mensaje_351FI;
        }
    }
}
