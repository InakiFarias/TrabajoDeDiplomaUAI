using MAP.MAP_SER;
using Servicio;

namespace BLL.BLL_SER
{
    public class BLL_Backup_351FI : IGestorBackup_351FI
    {
        MAP_Backup_351FI map_backup_351FI;
        BLL_Bitacora_351FI bll_bitacora_351FI;
        public BLL_Backup_351FI() { map_backup_351FI = new(); bll_bitacora_351FI = new(); }
        public void Backup_351FI(string ruta_351FI)
        {
            map_backup_351FI.Backup_351FI(ruta_351FI);
            SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Respaldo", "Generar backup", 1);
            bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);
        }
        public void Restore_351FI(string ruta_351FI)
        {
            map_backup_351FI.Restore_351FI(ruta_351FI);
            SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Respaldo", "Generar restore", 1);
            bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);
            
        }
    }
}
