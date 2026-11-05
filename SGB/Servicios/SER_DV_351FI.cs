using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public abstract class SER_DV_351FI
    {
        public string NombreTabla_351FI { get; set; }
        public string Valor_351FI { get; set; }

        public SER_DV_351FI(string nombreTabla_351FI, string valor_351FI)
        {
            NombreTabla_351FI = nombreTabla_351FI;
            Valor_351FI = valor_351FI;
        }
    }

}
