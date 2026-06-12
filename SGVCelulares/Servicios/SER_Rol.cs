using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class SER_Rol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public SER_Rol(int id, string nombre) 
        {
            Id = id;
            Nombre = nombre;
        }
        public SER_Rol(string nombre)
        {
            Nombre = nombre;
        }
        public SER_Rol(object[] datos)
        {
            Id = Convert.ToInt16(datos[0]);
            Nombre = Convert.ToString(datos[1]);
        }
    }

}
