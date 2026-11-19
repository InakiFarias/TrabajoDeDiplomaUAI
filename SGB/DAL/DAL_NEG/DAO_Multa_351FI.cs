using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Multa_351FI : Conexion_351FI
    {
        SqlCommand cm_351FI;
        public DAO_Multa_351FI() : base()
        {
            cm_351FI = new SqlCommand("select * from Multa_351FI", con_351FI);
        }

        // Multas pendientes de pago del socio (habilitación para préstamos y baja de socio)
        public int ContarPendientes_351FI(int numeroSocio_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio_351FI;
            cm_351FI.CommandText = @"SELECT COUNT(*) FROM Multa_351FI m
                               INNER JOIN Devolucion_351FI d ON d.NumeroDevolucion_351FI = m.NumeroDevolucion_351FI
                               INNER JOIN Prestamo_351FI p ON p.NumeroPrestamo_351FI = d.NumeroPrestamo_351FI
                               WHERE p.NumeroSocio_351FI = @numeroSocio
                               AND m.Estado_351FI = 'Pendiente de pago'";
            con_351FI.Open();
            int cantidad = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return cantidad;
        }

        public SqlDataReader ObtenerMultasPendientes_351FI(int numeroSocio_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio_351FI;
            cm_351FI.CommandText = @"SELECT m.NumeroMulta_351FI, m.DiasAtraso_351FI, m.MontoPorDia_351FI, m.Monto_351FI, m.FechaGeneracion_351FI, m.FechaPago_351FI, m.Estado_351FI,
                                      d.NumeroDevolucion_351FI, d.FechaDevolucion_351FI, p.NumeroPrestamo_351FI
                               FROM Multa_351FI m
                               INNER JOIN Devolucion_351FI d ON d.NumeroDevolucion_351FI = m.NumeroDevolucion_351FI
                               INNER JOIN Prestamo_351FI p ON p.NumeroPrestamo_351FI = d.NumeroPrestamo_351FI
                               WHERE p.NumeroSocio_351FI = @numeroSocio
                               AND m.Estado_351FI = 'Pendiente de pago'
                               ORDER BY m.FechaGeneracion_351FI";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public int InsertarPago_351FI(int numeroSocio_351FI, DateTime fechaPago_351FI, string metodoPago_351FI, decimal total_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio_351FI;
            cm_351FI.Parameters.Add("@fechaPago", SqlDbType.Date).Value = fechaPago_351FI;
            cm_351FI.Parameters.Add("@metodoPago", SqlDbType.VarChar).Value = metodoPago_351FI;
            cm_351FI.Parameters.Add("@total", SqlDbType.Decimal).Value = total_351FI;
            cm_351FI.CommandText = @"INSERT INTO Pago_351FI (NumeroSocio_351FI, FechaPago_351FI, MetodoPago_351FI, Total_351FI)
                               OUTPUT INSERTED.NumeroPago_351FI
                               VALUES (@numeroSocio, @fechaPago, @metodoPago, @total)";
            con_351FI.Open();
            int numeroPago = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return numeroPago;
        }

        public void ActualizarPagoMulta_351FI(int numeroMulta_351FI, DateTime fechaPago_351FI, string estado_351FI, int numeroPago_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroMulta", SqlDbType.Int).Value = numeroMulta_351FI;
            cm_351FI.Parameters.Add("@fechaPago", SqlDbType.Date).Value = fechaPago_351FI;
            cm_351FI.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado_351FI;
            cm_351FI.Parameters.Add("@numeroPago", SqlDbType.Int).Value = numeroPago_351FI;
            cm_351FI.CommandText = @"UPDATE Multa_351FI SET FechaPago_351FI = @fechaPago, Estado_351FI = @estado, NumeroPago_351FI = @numeroPago
                               WHERE NumeroMulta_351FI = @numeroMulta";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }
    }
}
