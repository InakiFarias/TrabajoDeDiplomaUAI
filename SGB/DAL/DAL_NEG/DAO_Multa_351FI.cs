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

        public int InsertarMulta_351FI(int numeroDevolucion_351FI, int diasAtraso_351FI, decimal montoPorDia_351FI, decimal monto_351FI, DateTime fechaGeneracion_351FI, string estado_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroDevolucion", SqlDbType.Int).Value = numeroDevolucion_351FI;
            cm_351FI.Parameters.Add("@diasAtraso", SqlDbType.Int).Value = diasAtraso_351FI;
            cm_351FI.Parameters.Add("@montoPorDia", SqlDbType.Decimal).Value = montoPorDia_351FI;
            cm_351FI.Parameters.Add("@monto", SqlDbType.Decimal).Value = monto_351FI;
            cm_351FI.Parameters.Add("@fechaGeneracion", SqlDbType.Date).Value = fechaGeneracion_351FI;
            cm_351FI.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado_351FI;
            cm_351FI.CommandText = @"INSERT INTO Multa_351FI (NumeroDevolucion_351FI, DiasAtraso_351FI, MontoPorDia_351FI, Monto_351FI, FechaGeneracion_351FI, Estado_351FI)
                               OUTPUT INSERTED.NumeroMulta_351FI
                               VALUES (@numeroDevolucion, @diasAtraso, @montoPorDia, @monto, @fechaGeneracion, @estado)";
            con_351FI.Open();
            int numeroMulta = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return numeroMulta;
        }

        // Multas con fecha de generación dentro del período, con su devolución, préstamo y socio
        public SqlDataReader ObtenerMultasPorFecha_351FI(DateTime desde_351FI, DateTime hasta_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@desde", SqlDbType.Date).Value = desde_351FI.Date;
            cm_351FI.Parameters.Add("@hasta", SqlDbType.Date).Value = hasta_351FI.Date;
            cm_351FI.CommandText = @"SELECT m.NumeroMulta_351FI, m.DiasAtraso_351FI, m.MontoPorDia_351FI, m.Monto_351FI, m.FechaGeneracion_351FI, m.FechaPago_351FI, m.Estado_351FI,
                                      d.NumeroDevolucion_351FI, d.FechaDevolucion_351FI, p.NumeroPrestamo_351FI,
                                      s.NumeroSocio_351FI, s.Nombre_351FI, s.Apellido_351FI, s.Dni_351FI, s.Estado_351FI AS EstadoSocio
                               FROM Multa_351FI m
                               INNER JOIN Devolucion_351FI d ON d.NumeroDevolucion_351FI = m.NumeroDevolucion_351FI
                               INNER JOIN Prestamo_351FI p ON p.NumeroPrestamo_351FI = d.NumeroPrestamo_351FI
                               INNER JOIN Socio_351FI s ON s.NumeroSocio_351FI = p.NumeroSocio_351FI
                               WHERE m.FechaGeneracion_351FI BETWEEN @desde AND @hasta
                               ORDER BY m.FechaGeneracion_351FI, m.NumeroMulta_351FI";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
