using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    abstract public class SER_Componente_351FI
    {
        public int Id_351FI { get; set; }
        public string Nombre_351FI { get; set; }
        public SER_Componente_351FI(int id_351FI, string nombre_351FI)
        {
            Id_351FI = id_351FI;
            Nombre_351FI = nombre_351FI;
        }
        public SER_Componente_351FI(string nombre_351FI)
        {
            Nombre_351FI = nombre_351FI;
        }
        public SER_Componente_351FI(object[] datos_351FI)
        {
            Id_351FI = Convert.ToInt16(datos_351FI[0]);
            Nombre_351FI = Convert.ToString(datos_351FI[1]);
        }
        public override string ToString()
        {
            return $"{this.Nombre_351FI}";
        }
        public abstract bool TienePermiso_351FI(string nombrePermiso_351FI);
    }
}
