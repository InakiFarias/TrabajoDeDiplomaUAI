using DAL;
using MAP.MAP_SER;
using Microsoft.VisualBasic;
using Servicio;

namespace BLL.BLL_SER
{
    public class BLL_Familia_351FI : IABMC_351FI<SER_Familia_351FI>
    {
        MAP_Familia_351FI map_familia_351FI;
        BLL_Bitacora_351FI bll_bitacora_351FI;
        BLL_DV_351FI bll_dv_351FI;

        public BLL_Familia_351FI()
        {
            map_familia_351FI = new MAP_Familia_351FI();
            bll_bitacora_351FI = new BLL_Bitacora_351FI();
            bll_dv_351FI = new BLL_DV_351FI();
        }
        public void Agregar_351FI(SER_Familia_351FI familia_351FI)
        {
            map_familia_351FI.Agregar_351FI(familia_351FI);
          
        }

        public void Borrar_351FI(SER_Familia_351FI familia_351FI)
        {
            if (map_familia_351FI.EstaEnUso_351FI(familia_351FI))
                throw new Exception("No se puede borrar: la familia está asignada a un rol u otra familia.");

            map_familia_351FI.Borrar_351FI(familia_351FI);

            bll_dv_351FI.BorrarDVH_351FI("familia_351FI", familia_351FI.Id_351FI);

            foreach (SER_Componente_351FI componente in familia_351FI.Componentes_351FI)
            {
                string tabla = componente is SER_Familia_351FI ? "familia_familia_351FI" : "permiso_familia_351FI";
                bll_dv_351FI.BorrarDVH_351FI(tabla, familia_351FI.Id_351FI, componente.Id_351FI);
            }

            bll_dv_351FI.GenerarDVV_351FI("familia_351FI");
            bll_dv_351FI.GenerarDVV_351FI("familia_familia_351FI");
            bll_dv_351FI.GenerarDVV_351FI("permiso_familia_351FI");

            bll_bitacora_351FI.RegistrarBitacora_351FI(new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Roles", "Borrar familia", 1));
        }

        public List<SER_Familia_351FI> Consultar_351FI()
        {
            return map_familia_351FI.Consultar_351FI();
        }
        public SER_Familia_351FI ConsultarPorId_351FI(SER_Familia_351FI familia_351FI)
        {
            return map_familia_351FI.ObtenerArbol_351FI(familia_351FI.Id_351FI);
        }

        public void Modificar_351FI(SER_Familia_351FI familia_351FI)
        {
            throw new NotImplementedException();
        }
        public void Agregar_351FI(SER_Familia_351FI familia_351FI, List<SER_Componente_351FI> componentes_351FI)
        {
            if (componentes_351FI.Count == 0) throw new Exception("No hay permisos o familias cargadas!");
            if (map_familia_351FI.ExisteFamilia_351FI(familia_351FI)) throw new Exception("Ya existe la familia!");
            if (ValidarPermisosRepetidos_351FI(componentes_351FI)) throw new Exception("Existe un permiso repetido!");
            map_familia_351FI.Agregar_351FI(familia_351FI);
            familia_351FI.Id_351FI = map_familia_351FI.ObtenerIdPorNombre_351FI(familia_351FI).Id_351FI;
            
            bll_dv_351FI.GenerarDVH_351FI("familia_351FI", familia_351FI.Id_351FI);
            bll_dv_351FI.GenerarDVV_351FI("familia_351FI");
            
            foreach (SER_Componente_351FI c in componentes_351FI)
            {
                map_familia_351FI.AgregarPermisoFamilia_351FI(familia_351FI, c);
                if (c is SER_Familia_351FI familiaHijo)
                {
                    bll_dv_351FI.GenerarDVH_351FI("familia_familia_351FI", familia_351FI.Id_351FI, c.Id_351FI);
                    bll_dv_351FI.GenerarDVV_351FI("familia_familia_351FI");
                }
                else if (c is SER_Permiso_351FI permiso)
                {
                    bll_dv_351FI.GenerarDVH_351FI("permiso_familia_351FI", familia_351FI.Id_351FI, c.Id_351FI);
                    bll_dv_351FI.GenerarDVV_351FI("permiso_familia_351FI");
                }
            }
            bll_bitacora_351FI.RegistrarBitacora_351FI(new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Roles", "Crear familia", 1));
        }
        public bool ValidarPermisosRepetidos_351FI(List<SER_Componente_351FI> componentes_351FI)
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
    }
}
