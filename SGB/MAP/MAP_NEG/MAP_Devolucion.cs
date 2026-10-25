using BE;
using DAL;

namespace MAP
{
    public class MAP_Devolucion
    {
        DAO_Devolucion dao_devolucion;
        public MAP_Devolucion()
        {
            dao_devolucion = new DAO_Devolucion();
        }

        public int InsertarDevolucion(BE_Devolucion devolucion) => dao_devolucion.InsertarDevolucion(devolucion.Prestamo.NumeroPrestamo, devolucion.FechaDevolucion);

        public int InsertarMulta(BE_Multa multa) => dao_devolucion.InsertarMulta(multa.Devolucion.NumeroDevolucion, multa.DiasAtraso, multa.MontoPorDia, multa.Monto, multa.FechaGeneracion, multa.Estado);

        public void ActualizarEstadoEjemplar(BE_Ejemplar ejemplar, string estado) => dao_devolucion.ActualizarEstadoEjemplar(ejemplar.CodigoEjemplar, estado);

        public void ActualizarEstadoPrestamo(BE_Prestamo prestamo, string estado) => dao_devolucion.ActualizarEstadoPrestamo(prestamo.NumeroPrestamo, estado);
    }
}
