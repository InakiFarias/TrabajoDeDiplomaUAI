using BE;
using DAL;

namespace MAP
{
    public class MAP_Devolucion_351FI
    {
        DAO_Devolucion_351FI dao_devolucion_351FI;
        public MAP_Devolucion_351FI()
        {
            dao_devolucion_351FI = new DAO_Devolucion_351FI();
        }

        public int InsertarDevolucion_351FI(BE_Devolucion_351FI devolucion_351FI) => dao_devolucion_351FI.InsertarDevolucion_351FI(devolucion_351FI.Prestamo_351FI.NumeroPrestamo_351FI, devolucion_351FI.FechaDevolucion_351FI);
    }
}
