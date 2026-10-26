using MAP;

namespace BLL.BLL_NEG
{
    // Resumen de la actividad para la pantalla de inicio
    public class BLL_Resumen
    {
        MAP_Resumen map_resumen;
        public BLL_Resumen()
        {
            map_resumen = new MAP_Resumen();
        }

        public int ContarPrestamosVigentes() => map_resumen.ContarPrestamosVigentes();
        public int ContarPrestamosVencidos() => map_resumen.ContarPrestamosVencidos();
        public int ContarMultasPendientes() => map_resumen.ContarMultasPendientes();
        public decimal TotalAdeudado() => map_resumen.SumarMultasPendientes();
    }
}
