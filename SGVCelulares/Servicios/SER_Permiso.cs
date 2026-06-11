using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class SER_Permiso : SER_Rol
    {
        public SER_Permiso(int id, string nombre) : base(id, nombre)
        {
        }

        public SER_Permiso(object[] datos) : base(Convert.ToInt16(datos[0]), Convert.ToString(datos[1]))
        {
        }
    }
}
