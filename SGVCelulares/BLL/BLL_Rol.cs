using MAP;
using Servicio;

namespace BLL
{
    public class BLL_Rol
    {
        MAP_Rol map_rol;
        public BLL_Rol()
        {
            map_rol = new MAP_Rol();
        }
        public List<SER_Rol> Consultar()
        {
            return map_rol.Consultar();
        }

        public void Agregar(SER_Rol rol, List<SER_Rol> componentes)
        {
            if (componentes.Count == 0) throw new Exception("No hay permisos o familias cargadas!");
            if (!map_rol.ExisteRol(rol)) throw new Exception("El nombre del rol está repetido!");

        }

        //public bool ValidarRolDuplicado(SER_Rol rol)
        //{

        //}
        //public bool ValidarPermisosRepetidos(List<SER_Rol> componentes)
        //{

        //}
    }
}
