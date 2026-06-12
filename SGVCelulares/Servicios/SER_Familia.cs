using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class SER_Familia : SER_Rol
    {
        public List<SER_Rol> Hijos { get; set; }
        public SER_Familia(int id, string nombre) : base(id, nombre)
        {
            Hijos = new List<SER_Rol>();
        }

        public SER_Familia(string nombre) : base(nombre)
        {
            Nombre = nombre;
            Hijos = new List<SER_Rol>();
        }
        public SER_Familia(object[] datos) : base(Convert.ToInt16(datos[0]), Convert.ToString(datos[1]))
        {
            Hijos = new List<SER_Rol>();
        }
    }
}
