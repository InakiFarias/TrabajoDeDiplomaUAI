using BE;
using DAL;

namespace MAP
{
    public class MAP_Pago_351FI
    {
        DAO_Pago_351FI dao_pago_351FI;
        public MAP_Pago_351FI()
        {
            dao_pago_351FI = new DAO_Pago_351FI();
        }

        public int InsertarPago_351FI(BE_Pago_351FI pago_351FI) => dao_pago_351FI.InsertarPago_351FI(pago_351FI.Socio_351FI.NumeroSocio_351FI, pago_351FI.FechaPago_351FI, pago_351FI.MetodoPago_351FI, pago_351FI.Total_351FI);
    }
}
