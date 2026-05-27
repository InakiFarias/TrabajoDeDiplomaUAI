using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface IABMC<T>
    {
        void Agregar(T obj);
        void Borrar(T obj);
        void Modificar(T obj);
        List<T> Consultar();
        T ConsultarPorId(T obj);
    }
}
