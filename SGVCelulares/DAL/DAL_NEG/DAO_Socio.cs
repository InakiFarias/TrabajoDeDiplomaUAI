using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Socio : Conexion
    {
        SqlCommand cm;
        public DAO_Socio() : base()
        {
            cm = new SqlCommand("select * from Socio", con);
        }

        public SqlDataReader ObtenerSocios()
        {
            cm.Parameters.Clear();
            cm.CommandText = "SELECT * FROM Socio";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader BuscarPorNumero(string numero)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numero", SqlDbType.VarChar).Value = numero + "%";
            cm.CommandText = "SELECT * FROM Socio WHERE CAST(NumeroSocio AS varchar) LIKE @numero";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public int ContarPrestamosVencidos(int numeroSocio)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio;
            cm.CommandText = @"SELECT COUNT(*) FROM Prestamo
                               WHERE NumeroSocio = @numeroSocio
                               AND Estado = 'Vigente'
                               AND FechaDevolucionPrevista < CAST(GETDATE() AS date)";
            con.Open();
            int cantidad = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return cantidad;
        }

        public int ContarMultasPendientes(int numeroSocio)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio;
            cm.CommandText = @"SELECT COUNT(*) FROM Multa m
                               INNER JOIN Devolucion d ON d.NumeroDevolucion = m.NumeroDevolucion
                               INNER JOIN Prestamo p ON p.NumeroPrestamo = d.NumeroPrestamo
                               WHERE p.NumeroSocio = @numeroSocio
                               AND m.Estado = 'Pendiente de pago'";
            con.Open();
            int cantidad = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return cantidad;
        }
    }
}