using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class SER_SesionManager
    {
        public SER_Usuario Usuario { get; set; }
        private static SER_SesionManager sesion;
        private SER_SesionManager() { }
        static public SER_SesionManager ObtenerSesion()
        {
            if (sesion == null)
            {
                sesion = new SER_SesionManager();
            }
            return sesion;
        }
    }
}
