using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class SER_DVH_351FI : SER_DV_351FI
    {
        public string IdRegistro_351FI { get; set; }

        public SER_DVH_351FI(string nombreTabla_351FI, string ID_351FI, string valor_351FI) : base(nombreTabla_351FI, valor_351FI)
        {
            IdRegistro_351FI = ID_351FI;
        }

        public SER_DVH_351FI(object[] datos_351FI) : base(datos_351FI[0].ToString(), datos_351FI[2].ToString())
        {
            IdRegistro_351FI = datos_351FI[1].ToString();
        }
    }
}
