using BE;
using BLL.BLL_SER;
using MAP;
using Servicio;

namespace BLL.BLL_NEG
{
    // Control de cambios de socios (T06b - CU-SER-10 Auditar control de cambios)
    public class BLL_SocioC_351FI
    {
        MAP_SocioC_351FI map_socioC_351FI;
        BLL_Socio_351FI bll_socio_351FI;
        BLL_Bitacora_351FI bll_bitacora_351FI;
        BLL_DV_351FI bll_dv_351FI;
        public BLL_SocioC_351FI()
        {
            map_socioC_351FI = new MAP_SocioC_351FI();
            bll_socio_351FI = new BLL_Socio_351FI();
            bll_bitacora_351FI = new BLL_Bitacora_351FI();
            bll_dv_351FI = new BLL_DV_351FI();
        }

        public List<BE_SocioC_351FI> ConsultarVersiones_351FI(int? numeroSocio_351FI, string apellido_351FI, DateTime fechaDesde_351FI, DateTime fechaHasta_351FI)
        {
            if (fechaDesde_351FI.Date > fechaHasta_351FI.Date) throw new Exception("La fecha desde no puede ser posterior a la fecha hasta.");
            return map_socioC_351FI.ConsultarVersiones_351FI(numeroSocio_351FI, apellido_351FI?.Trim() ?? "", fechaDesde_351FI, fechaHasta_351FI);
        }

        // Deja vigente una versión anterior del socio. El trigger TR_Socio_C_Restaurar_351FI actualiza Socio_351FI.
        public void Activar_351FI(BE_SocioC_351FI version_351FI)
        {
            if (version_351FI.Activo_351FI) throw new Exception("La versión seleccionada ya se encuentra vigente.");
            if (bll_socio_351FI.ExisteDniEnOtroSocio_351FI(version_351FI.Dni_351FI, version_351FI.NumeroSocio_351FI))
                throw new Exception($"No se puede activar la versión porque el DNI {version_351FI.Dni_351FI} está registrado en otro socio.");
            if (version_351FI.Estado_351FI == "Baja") bll_socio_351FI.ValidarBaja_351FI(version_351FI);

            map_socioC_351FI.ActivarVersion_351FI(version_351FI);

            // CU-SER-17: el socio cambió en Socio_351FI y sus versiones cambiaron en Socio_C_351FI
            bll_dv_351FI.GenerarDVH_351FI("Socio_351FI", version_351FI.NumeroSocio_351FI);
            bll_dv_351FI.GenerarDVV_351FI("Socio_351FI");
            bll_dv_351FI.GenerarDVHPorColumna_351FI("Socio_C_351FI", "NumeroSocio_351FI", version_351FI.NumeroSocio_351FI);
            bll_dv_351FI.GenerarDVV_351FI("Socio_C_351FI");

            // CU-SER-9
            SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Control de cambios", "Activar versión de socio", 2);
            bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);
        }
    }
}
