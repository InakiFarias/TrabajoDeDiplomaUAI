using MAP;
using Servicio;
using Servicios;

namespace BLL
{
    public class BLL_Permiso : IABMC<SER_Permiso>
    {
        MAP_Permiso map;
        public BLL_Permiso()
        {
            map = new MAP_Permiso();
        }
        public void Agregar(SER_Permiso obj)
        {
            throw new NotImplementedException();
        }

        public void Borrar(SER_Permiso obj)
        {
            throw new NotImplementedException();
        }

        public List<SER_Permiso> Consultar()
        {
            return map.Consultar();
        }

        public SER_Permiso ConsultarPorId(SER_Permiso obj)
        {
            throw new NotImplementedException();
        }

        public void Modificar(SER_Permiso obj)
        {
            throw new NotImplementedException();
        }
    }
}
