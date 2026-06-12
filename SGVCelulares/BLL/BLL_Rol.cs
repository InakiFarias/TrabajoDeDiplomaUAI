using MAP;
using Servicio;
using Servicios;

namespace BLL
{
    public class BLL_Rol : IABMC<SER_Rol>
    {
        MAP_Rol map;
        public BLL_Rol()
        {
            map = new MAP_Rol();
        }
        public void Agregar(SER_Rol rol)
        {
            map.Agregar(rol);
        }

        public void Borrar(SER_Rol rol)
        {
            throw new NotImplementedException();
        }

        public List<SER_Rol> Consultar()
        {
            return map.Consultar();
        }

        public SER_Rol ConsultarPorId(SER_Rol rol)
        {
            throw new NotImplementedException();
        }

        public void Modificar(SER_Rol rol)
        {
            throw new NotImplementedException();
        }
    }
}
