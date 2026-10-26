using BE;
using DAL;
using Microsoft.Data.SqlClient;

namespace MAP
{
    public class MAP_Multa
    {
        DAO_Multa dao_multa;
        public MAP_Multa()
        {
            dao_multa = new DAO_Multa();
        }

        public List<BE_Socio> ObtenerSociosConMultas(string dni)
        {
            List<BE_Socio> lista = new List<BE_Socio>();
            SqlDataReader dr = dao_multa.ObtenerSociosConMultas(dni);
            while (dr.Read())
            {
                BE_Socio socio = new BE_Socio(
                    Convert.ToInt32(dr["NumeroSocio"]),
                    Convert.ToString(dr["Nombre"]),
                    Convert.ToString(dr["Apellido"]),
                    Convert.ToString(dr["Dni"]),
                    Convert.ToString(dr["Estado"]));
                socio.MontoAdeudado = Convert.ToDecimal(dr["MontoAdeudado"]);
                lista.Add(socio);
            }
            dr.Close();
            return lista;
        }

        public List<BE_Multa> ObtenerMultasPendientes(BE_Socio socio)
        {
            List<BE_Multa> lista = new List<BE_Multa>();
            SqlDataReader dr = dao_multa.ObtenerMultasPendientes(socio.NumeroSocio);
            while (dr.Read())
            {
                BE_Prestamo prestamo = new BE_Prestamo();
                prestamo.NumeroPrestamo = Convert.ToInt32(dr["NumeroPrestamo"]);
                prestamo.Socio = socio;

                BE_Devolucion devolucion = new BE_Devolucion(
                    Convert.ToInt32(dr["NumeroDevolucion"]),
                    prestamo,
                    Convert.ToDateTime(dr["FechaDevolucion"]));

                lista.Add(new BE_Multa(
                    Convert.ToInt32(dr["NumeroMulta"]),
                    devolucion,
                    Convert.ToInt32(dr["DiasAtraso"]),
                    Convert.ToDecimal(dr["MontoPorDia"]),
                    Convert.ToDecimal(dr["Monto"]),
                    Convert.ToDateTime(dr["FechaGeneracion"]),
                    dr["FechaPago"] == DBNull.Value ? null : Convert.ToDateTime(dr["FechaPago"]),
                    Convert.ToString(dr["Estado"])));
            }
            dr.Close();
            return lista;
        }

        public int InsertarComprobantePago(BE_ComprobantePago comprobante) => dao_multa.InsertarComprobantePago(comprobante.Socio.NumeroSocio, comprobante.FechaEmision, comprobante.Total);

        public void ActualizarPagoMulta(BE_Multa multa, int numeroComprobante) => dao_multa.ActualizarPagoMulta(multa.NumeroMulta, multa.FechaPago.Value, multa.Estado, numeroComprobante);
    }
}
