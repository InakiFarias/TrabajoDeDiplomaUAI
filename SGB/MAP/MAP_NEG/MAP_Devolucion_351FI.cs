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

        public int InsertarMulta_351FI(BE_Multa_351FI multa_351FI) => dao_devolucion_351FI.InsertarMulta_351FI(multa_351FI.Devolucion_351FI.NumeroDevolucion_351FI, multa_351FI.DiasAtraso_351FI, multa_351FI.MontoPorDia_351FI, multa_351FI.Monto_351FI, multa_351FI.FechaGeneracion_351FI, multa_351FI.Estado_351FI);

        public void ActualizarEstadoEjemplar_351FI(BE_Ejemplar_351FI ejemplar_351FI, string estado_351FI) => dao_devolucion_351FI.ActualizarEstadoEjemplar_351FI(ejemplar_351FI.CodigoEjemplar_351FI, estado_351FI);

        public void ActualizarEstadoPrestamo_351FI(BE_Prestamo_351FI prestamo_351FI, string estado_351FI) => dao_devolucion_351FI.ActualizarEstadoPrestamo_351FI(prestamo_351FI.NumeroPrestamo_351FI, estado_351FI);

        public int InsertarComprobante_351FI(BE_ComprobanteDevolucion_351FI comprobante_351FI) => dao_devolucion_351FI.InsertarComprobante_351FI(comprobante_351FI.Devolucion_351FI.NumeroDevolucion_351FI, comprobante_351FI.FechaEmision_351FI);
    }
}
