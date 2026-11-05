using DAL.DAL_SER;
using Servicio;

namespace MAP.MAP_SER
{
    public class MAP_Backup_351FI : IGestorBackup_351FI
    {
        DAO_Backup_351FI dao_backup_351FI;
        public MAP_Backup_351FI() { dao_backup_351FI = new(); }
        public void Backup_351FI(string ruta_351FI) => dao_backup_351FI.Backup_351FI(ruta_351FI);
        public void Restore_351FI(string ruta_351FI) => dao_backup_351FI.Restore_351FI(ruta_351FI);
    }
}
