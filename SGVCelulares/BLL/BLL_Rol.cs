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

        public void Agregar(SER_Rol rol, List<SER_Componente> componentes)
        {
            if (componentes.Count == 0) throw new Exception("No hay permisos o familias cargadas!");
            if (map_rol.ExisteRol(rol)) throw new Exception("El nombre del rol está repetido!");
            if (ValidarPermisosRepetidos(componentes)) throw new Exception("El permiso repite con otro");
            map_rol.Agregar(rol);
            rol.Id = map_rol.ObtenerIdPorNombre(rol).Id;

            foreach (SER_Componente c in componentes)
            {
                map_rol.AgregarPermisoFamilia(rol, c);
            }
            bll_bitacora.RegistrarBitacora(new SER_Bitacora(SER_SesionManager.ObtenerSesion().Usuario, DateTime.Now, "Roles", "Crear rol", 1));
        }
        private bool ValidarPermisosRepetidos(List<SER_Componente> componentes)
        {
            bool rdo = false;
            HashSet<int> permisos = new HashSet<int>();
            foreach (SER_Componente componente in componentes)
            {
                if (!AgregarPermisos(componente, permisos)) rdo = true;
            }
            return rdo;
        }
        private bool AgregarPermisos(SER_Componente componente, HashSet<int> permisos)
        {
            if (componente is SER_Permiso permiso)
            {
                return permisos.Add(permiso.Id);
            }
            if (componente is SER_Familia familia)
            {
                foreach (SER_Componente hijo in familia.Componentes)
                {
                    if (!AgregarPermisos(hijo, permisos))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool TienePermiso(SER_Rol rol, string nombrePermiso)
        {
            foreach (SER_Componente componente in rol.Componentes)
            {
                if (BuscarPermiso(componente, nombrePermiso)) return true;
            }
            return false;
        }
        private bool BuscarPermiso(SER_Componente componente, string nombrePermiso)
        {
            if (componente.Nombre == nombrePermiso) return true;
            if (componente is SER_Familia familia)
            {
                foreach (SER_Componente hijo in familia.Componentes)
                {
                    if (BuscarPermiso(hijo, nombrePermiso)) return true;
                }
            }
            return false;
        }
        public void Borrar(SER_Rol rol)
        {
            if (map_rol.EstaEnUso(rol))
                throw new Exception("No se puede borrar: el rol está asignado a uno o más usuarios.");
            map_rol.Borrar(rol);
            bll_bitacora.RegistrarBitacora(new SER_Bitacora(SER_SesionManager.ObtenerSesion().Usuario, DateTime.Now, "Roles", "Borrar rol", 1));
        }
    }
}
