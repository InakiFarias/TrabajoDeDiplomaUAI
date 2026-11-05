using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class SER_DVV_351FI : SER_DV_351FI
    {
        public SER_DVV_351FI(string nombreTabla_351FI, string valor_351FI) : base(nombreTabla_351FI, valor_351FI)
        {

        }
        public SER_DVV_351FI(object[] datos_351FI) : base(datos_351FI[0].ToString(), datos_351FI[1].ToString())
        {

        }
    }

}
