using MAP;

namespace BLL.BLL_NEG
{
    // Resumen de la actividad para la pantalla de inicio
    public class BLL_Resumen_351FI
    {
        MAP_Resumen_351FI map_resumen_351FI;
        public BLL_Resumen_351FI()
        {
            map_resumen_351FI = new MAP_Resumen_351FI();
        }

        public int ContarPrestamosVigentes_351FI() => map_resumen_351FI.ContarPrestamosVigentes_351FI();
        public int ContarPrestamosVencidos_351FI() => map_resumen_351FI.ContarPrestamosVencidos_351FI();
        public int ContarMultasPendientes_351FI() => map_resumen_351FI.ContarMultasPendientes_351FI();
        public decimal TotalAdeudado_351FI() => map_resumen_351FI.SumarMultasPendientes_351FI();
    }
}
