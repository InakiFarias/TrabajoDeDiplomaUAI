using DAL;

namespace MAP
{
    public class MAP_Resumen
    {
        DAO_Resumen dao_resumen;
        public MAP_Resumen()
        {
            dao_resumen = new DAO_Resumen();
        }

        public int ContarPrestamosVigentes() => dao_resumen.ContarPrestamosVigentes();
        public int ContarPrestamosVencidos() => dao_resumen.ContarPrestamosVencidos();
        public int ContarMultasPendientes() => dao_resumen.ContarMultasPendientes();
        public decimal SumarMultasPendientes() => dao_resumen.SumarMultasPendientes();
    }
}
