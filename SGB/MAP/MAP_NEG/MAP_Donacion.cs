using BE;
using DAL;

namespace MAP
{
    public class MAP_Donacion
    {
        DAO_Donacion dao_donacion;
        public MAP_Donacion()
        {
            dao_donacion = new DAO_Donacion();
        }

        public int? ObtenerDonacionDeEjemplar(string codigoEjemplar)
        {
            object numero = dao_donacion.ObtenerDonacionDeEjemplar(codigoEjemplar);
            if (numero == null || numero == DBNull.Value) return null;
            return Convert.ToInt32(numero);
        }

        public int InsertarDonacion(BE_Donacion donacion)
        {
            int numeroDonacion = dao_donacion.InsertarDonacion(donacion.Socio.NumeroSocio, donacion.FechaDonacion);
            foreach (BE_Ejemplar ejemplar in donacion.Ejemplares)
                dao_donacion.InsertarDetalle(numeroDonacion, ejemplar.CodigoEjemplar);
            return numeroDonacion;
        }

        public int InsertarRecibo(BE_ReciboDonacion recibo) => dao_donacion.InsertarRecibo(recibo.Donacion.NumeroDonacion, recibo.FechaEmision);
    }
}
