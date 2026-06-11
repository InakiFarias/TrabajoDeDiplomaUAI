using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class SER_Familia : SER_Rol
    {
        public List<SER_Rol> hijos   { get; set; }
        public SER_Familia(int id, string nom) : base(id, nom)
        {
            hijos = new List<SER_Rol>();
        }
    }
}
