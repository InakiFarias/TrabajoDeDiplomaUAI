using BE;
using DAL;
using Microsoft.Data.SqlClient;

namespace MAP
{
    public class MAP_Multa_351FI
    {
        DAO_Multa_351FI dao_multa_351FI;
        public MAP_Multa_351FI()
        {
            dao_multa_351FI = new DAO_Multa_351FI();
        }

        public int ContarPendientes_351FI(BE_Socio_351FI socio_351FI) => dao_multa_351FI.ContarPendientes_351FI(socio_351FI.NumeroSocio_351FI);

        public List<BE_Multa_351FI> ObtenerMultasPendientes_351FI(BE_Socio_351FI socio_351FI)
        {
            List<BE_Multa_351FI> lista = new List<BE_Multa_351FI>();
            SqlDataReader dr = dao_multa_351FI.ObtenerMultasPendientes_351FI(socio_351FI.NumeroSocio_351FI);
            while (dr.Read())
            {
                BE_Prestamo_351FI prestamo = new BE_Prestamo_351FI();
                prestamo.NumeroPrestamo_351FI = Convert.ToInt32(dr["NumeroPrestamo_351FI"]);
                prestamo.Socio_351FI = socio_351FI;

                BE_Devolucion_351FI devolucion = new BE_Devolucion_351FI(
                    Convert.ToInt32(dr["NumeroDevolucion_351FI"]),
                    prestamo,
                    Convert.ToDateTime(dr["FechaDevolucion_351FI"]));

                lista.Add(new BE_Multa_351FI(
                    Convert.ToInt32(dr["NumeroMulta_351FI"]),
                    devolucion,
                    Convert.ToInt32(dr["DiasAtraso_351FI"]),
                    Convert.ToDecimal(dr["MontoPorDia_351FI"]),
                    Convert.ToDecimal(dr["Monto_351FI"]),
                    Convert.ToDateTime(dr["FechaGeneracion_351FI"]),
                    dr["FechaPago_351FI"] == DBNull.Value ? null : Convert.ToDateTime(dr["FechaPago_351FI"]),
                    Convert.ToString(dr["Estado_351FI"])));
            }
            dr.Close();
            return lista;
        }

        public int InsertarPago_351FI(BE_Pago_351FI pago_351FI) => dao_multa_351FI.InsertarPago_351FI(pago_351FI.Socio_351FI.NumeroSocio_351FI, pago_351FI.FechaPago_351FI, pago_351FI.MetodoPago_351FI, pago_351FI.Total_351FI);

        public void ActualizarPagoMulta_351FI(BE_Multa_351FI multa_351FI, int numeroPago_351FI) => dao_multa_351FI.ActualizarPagoMulta_351FI(multa_351FI.NumeroMulta_351FI, multa_351FI.FechaPago_351FI.Value, multa_351FI.Estado_351FI, numeroPago_351FI);

        public int InsertarMulta_351FI(BE_Multa_351FI multa_351FI) => dao_multa_351FI.InsertarMulta_351FI(multa_351FI.Devolucion_351FI.NumeroDevolucion_351FI, multa_351FI.DiasAtraso_351FI, multa_351FI.MontoPorDia_351FI, multa_351FI.Monto_351FI, multa_351FI.FechaGeneracion_351FI, multa_351FI.Estado_351FI);
    }
}
