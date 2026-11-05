using DAL;

namespace MAP
{
    public class MAP_Resumen_351FI
    {
        DAO_Resumen_351FI dao_resumen_351FI;
        public MAP_Resumen_351FI()
        {
            dao_resumen_351FI = new DAO_Resumen_351FI();
        }

        public int ContarPrestamosVigentes_351FI() => dao_resumen_351FI.ContarPrestamosVigentes_351FI();
        public int ContarPrestamosVencidos_351FI() => dao_resumen_351FI.ContarPrestamosVencidos_351FI();
        public int ContarMultasPendientes_351FI() => dao_resumen_351FI.ContarMultasPendientes_351FI();
        public decimal SumarMultasPendientes_351FI() => dao_resumen_351FI.SumarMultasPendientes_351FI();
    }
}
