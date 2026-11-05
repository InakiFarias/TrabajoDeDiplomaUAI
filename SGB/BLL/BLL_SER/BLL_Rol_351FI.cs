using MAP.MAP_SER;
using Servicio;
using System.Net.Http.Headers;

namespace BLL.BLL_SER
{
    public class BLL_Rol_351FI
    {
        MAP_Rol_351FI map_rol_351FI;
        BLL_Bitacora_351FI bll_bitacora_351FI;
        BLL_DV_351FI bll_dv_351FI;

        public BLL_Rol_351FI()
        {
            map_rol_351FI = new MAP_Rol_351FI();
            bll_bitacora_351FI = new BLL_Bitacora_351FI();
            bll_dv_351FI = new BLL_DV_351FI();
        }
        public List<SER_Rol_351FI> Consultar_351FI()
        {
            return map_rol_351FI.Consultar_351FI();
        }

        public void Agregar_351FI(SER_Rol_351FI rol_351FI, List<SER_Componente_351FI> componentes_351FI)
        {
            if (componentes_351FI.Count == 0) throw new Exception("No hay permisos o familias cargadas!");
            if (map_rol_351FI.ExisteRol_351FI(rol_351FI)) throw new Exception("El nombre del rol está repetido!");
            if (ValidarPermisosRepetidos_351FI(componentes_351FI)) throw new Exception("El permiso repite con otro");
            map_rol_351FI.Agregar_351FI(rol_351FI);
            rol_351FI.Id_351FI = map_rol_351FI.ObtenerIdPorNombre_351FI(rol_351FI).Id_351FI;
            bll_dv_351FI.GenerarDVH_351FI("rol_351FI", rol_351FI.Id_351FI);
            bll_dv_351FI.GenerarDVV_351FI("rol_351FI");
            
            foreach (SER_Componente_351FI c in componentes_351FI)
            {
                map_rol_351FI.AgregarPermisoFamilia_351FI(rol_351FI, c);
                if(c is SER_Familia_351FI familia)
                {
                    bll_dv_351FI.GenerarDVH_351FI("rol_familia_351FI", rol_351FI.Id_351FI, c.Id_351FI);
                    bll_dv_351FI.GenerarDVV_351FI("rol_familia_351FI");
                }
                else if (c is SER_Permiso_351FI permiso)
                {
                    bll_dv_351FI.GenerarDVH_351FI("rol_permiso_351FI", rol_351FI.Id_351FI, c.Id_351FI);
                    bll_dv_351FI.GenerarDVV_351FI("rol_permiso_351FI");
                }
            }
            
            bll_bitacora_351FI.RegistrarBitacora_351FI(new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Roles", "Crear rol", 1));
        }
        private bool ValidarPermisosRepetidos_351FI(List<SER_Componente_351FI> componentes_351FI)
        {
            bool rdo = false;
            HashSet<int> permisos = new HashSet<int>();
            foreach (SER_Componente_351FI componente in componentes_351FI)
            {
                if (!AgregarPermisos_351FI(componente, permisos)) rdo = true;
            }
            return rdo;
        }
        private bool AgregarPermisos_351FI(SER_Componente_351FI componente_351FI, HashSet<int> permisos_351FI)
        {
            if (componente_351FI is SER_Permiso_351FI permiso)
            {
                return permisos_351FI.Add(permiso.Id_351FI);
            }
            if (componente_351FI is SER_Familia_351FI familia)
            {
                foreach (SER_Componente_351FI hijo in familia.Componentes_351FI)
                {
                    if (!AgregarPermisos_351FI(hijo, permisos_351FI))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void Borrar_351FI(SER_Rol_351FI rol_351FI)
        {
            if (map_rol_351FI.EstaEnUso_351FI(rol_351FI))
                throw new Exception("No se puede borrar: el rol está asignado a uno o más usuarios.");

            map_rol_351FI.Borrar_351FI(rol_351FI);

            bll_dv_351FI.BorrarDVH_351FI("rol_351FI", rol_351FI.Id_351FI);

            foreach (SER_Componente_351FI componente in rol_351FI.Componentes_351FI)
            {
                string tabla = componente is SER_Familia_351FI ? "rol_familia_351FI" : "rol_permiso_351FI";
                bll_dv_351FI.BorrarDVH_351FI(tabla, rol_351FI.Id_351FI, componente.Id_351FI);
            }

            bll_dv_351FI.GenerarDVV_351FI("rol_351FI");
            bll_dv_351FI.GenerarDVV_351FI("rol_familia_351FI");
            bll_dv_351FI.GenerarDVV_351FI("rol_permiso_351FI");

            bll_bitacora_351FI.RegistrarBitacora_351FI(new SER_Bitacora_351FI(
                SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Roles", "Borrar rol", 1));
        }
    }
}
