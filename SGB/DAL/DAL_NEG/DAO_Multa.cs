using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Multa : Conexion
    {
        SqlCommand cm;
        public DAO_Multa() : base()
        {
            cm = new SqlCommand("select * from Multa", con);
        }

        // Socios con multas pendientes de pago y el total que adeuda cada uno
        public SqlDataReader ObtenerSociosConMultas(string dni)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni + "%";
            cm.CommandText = @"SELECT s.NumeroSocio, s.Nombre, s.Apellido, s.Dni, s.Estado, SUM(m.Monto) AS MontoAdeudado
                               FROM Socio s
                               INNER JOIN Prestamo p ON p.NumeroSocio = s.NumeroSocio
                               INNER JOIN Devolucion d ON d.NumeroPrestamo = p.NumeroPrestamo
                               INNER JOIN Multa m ON m.NumeroDevolucion = d.NumeroDevolucion
                               WHERE m.Estado = 'Pendiente de pago' AND s.Dni LIKE @dni
                               GROUP BY s.NumeroSocio, s.Nombre, s.Apellido, s.Dni, s.Estado
                               ORDER BY s.Apellido, s.Nombre";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader ObtenerMultasPendientes(int numeroSocio)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio;
            cm.CommandText = @"SELECT m.NumeroMulta, m.DiasAtraso, m.MontoPorDia, m.Monto, m.FechaGeneracion, m.FechaPago, m.Estado,
                                      d.NumeroDevolucion, d.FechaDevolucion, p.NumeroPrestamo
                               FROM Multa m
                               INNER JOIN Devolucion d ON d.NumeroDevolucion = m.NumeroDevolucion
                               INNER JOIN Prestamo p ON p.NumeroPrestamo = d.NumeroPrestamo
                               WHERE p.NumeroSocio = @numeroSocio
                               AND m.Estado = 'Pendiente de pago'
                               ORDER BY m.FechaGeneracion";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public int InsertarComprobantePago(int numeroSocio, DateTime fechaEmision, decimal total)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio;
            cm.Parameters.Add("@fechaEmision", SqlDbType.Date).Value = fechaEmision;
            cm.Parameters.Add("@total", SqlDbType.Decimal).Value = total;
            cm.CommandText = @"INSERT INTO ComprobantePago (NumeroSocio, FechaEmision, Total)
                               OUTPUT INSERTED.NumeroComprobante
                               VALUES (@numeroSocio, @fechaEmision, @total)";
            con.Open();
            int numeroComprobante = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return numeroComprobante;
        }

        public void ActualizarPagoMulta(int numeroMulta, DateTime fechaPago, string estado, int numeroComprobante)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroMulta", SqlDbType.Int).Value = numeroMulta;
            cm.Parameters.Add("@fechaPago", SqlDbType.Date).Value = fechaPago;
            cm.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado;
            cm.Parameters.Add("@numeroComprobante", SqlDbType.Int).Value = numeroComprobante;
            cm.CommandText = @"UPDATE Multa SET FechaPago = @fechaPago, Estado = @estado, NumeroComprobantePago = @numeroComprobante
                               WHERE NumeroMulta = @numeroMulta";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }
    }
}
