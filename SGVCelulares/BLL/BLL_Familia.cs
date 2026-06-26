using DAL;
using MAP;
using Servicio;

namespace BLL
{
    public class BLL_Familia : IABMC<SER_Familia>
    {
        MAP_Familia map_familia;
        BLL_Bitacora bll_bitacora;
        public BLL_Familia()
        {
            map_familia = new MAP_Familia();
            bll_bitacora = new BLL_Bitacora();
        }
        public void Agregar(SER_Familia familia)
        {
            map_familia.Agregar(familia);
        }

        public void Borrar(SER_Familia familia)
        {
            if (map_familia.EstaEnUso(familia))
                throw new Exception("No se puede borrar: la familia está asignada a un rol u otra familia.");
            map_familia.Borrar(familia);
            bll_bitacora.RegistrarBitacora(new SER_Bitacora(SER_SesionManager.ObtenerSesion().Usuario, DateTime.Now, "Roles", "Borrar familia", 1));
        }

        public List<SER_Familia> Consultar()
        {
            return map_familia.Consultar();
        }
        public SER_Familia ConsultarPorId(SER_Familia familia)
        {
            return map_familia.ObtenerArbol(familia.Id);
        }

        public void Modificar(SER_Familia familia)
        {
            throw new NotImplementedException();
        }
        public void Agregar(SER_Familia familia, List<SER_Componente> componentes)
        {
            if (componentes.Count == 0) throw new Exception("No hay permisos o familias cargadas!");
            if (map_familia.ExisteFamilia(familia)) throw new Exception("Ya existe la familia!");
            if (ValidarPermisosRepetidos(componentes)) throw new Exception("Existe un permiso repetido!");
            map_familia.Agregar(familia);
            familia.Id = map_familia.ObtenerIdPorNombre(familia).Id;

            foreach (SER_Componente c in componentes)
            {
                map_familia.AgregarPermisoFamilia(familia, c);
            }
            bll_bitacora.RegistrarBitacora(new SER_Bitacora(SER_SesionManager.ObtenerSesion().Usuario, DateTime.Now, "Roles", "Crear familia", 1));
        }
        public bool ValidarPermisosRepetidos(List<SER_Componente> componentes)
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
    }
}
