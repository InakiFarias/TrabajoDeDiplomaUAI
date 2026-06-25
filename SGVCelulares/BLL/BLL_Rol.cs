using MAP;
using Servicio;

namespace BLL
{
    public class BLL_Rol
    {
        MAP_Rol map_rol;
        BLL_Bitacora bll_bitacora;
        public BLL_Rol()
        {
            map_rol = new MAP_Rol();
            bll_bitacora = new BLL_Bitacora();
        }
        public List<SER_Rol> Consultar()
        {
            return map_rol.Consultar();
        }

        public void Agregar(SER_Rol rol, List<SER_Rol> componentes)
        {
            if (componentes.Count == 0) throw new Exception("No hay permisos o familias cargadas!");
            if (map_rol.ExisteRol(rol)) throw new Exception("El nombre del rol está repetido!");
            if (ValidarPermisosRepetidos(componentes)) throw new Exception("El permiso repite con otro");
            map_rol.Agregar(rol);
            rol.Id = map_rol.ObtenerIdPorNombre(rol).Id;

            foreach (SER_Rol c in componentes)
            {
                map_rol.AgregarPermisoFamilia(rol, c);
            }
            bll_bitacora.RegistrarBitacora(new SER_Bitacora(SER_SesionManager.ObtenerSesion().Usuario, DateTime.Now, "Roles", "Crear rol", 1));
        }
        private bool ValidarPermisosRepetidos(List<SER_Rol> componentes)
        {
            bool rdo = false;
            HashSet<int> permisos = new HashSet<int>();
            foreach (SER_Rol componente in componentes)
            {
                if (!AgregarPermisos(componente, permisos)) rdo = true;
            }
            return rdo;
        }
        private bool AgregarPermisos(SER_Rol componente, HashSet<int> permisos)
        {
            bool rdo = false;
            if (componente is SER_Permiso permiso)
            {
                permisos.Add(permiso.Id);
            }
            if (componente is SER_Familia familia)
            {
                foreach (SER_Rol hijo in familia.Componentes)
                {
                    if (!AgregarPermisos(hijo, permisos)) rdo = false;
                }
            }
            rdo = true;
            return rdo;
        }
    }
}
