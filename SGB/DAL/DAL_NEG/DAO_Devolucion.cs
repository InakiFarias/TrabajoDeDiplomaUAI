using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Devolucion : Conexion
    {
        SqlCommand cm;
        public DAO_Devolucion() : base()
        {
            cm = new SqlCommand("select * from Devolucion", con);
        }

        public int InsertarDevolucion(int numeroPrestamo, DateTime fechaDevolucion)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroPrestamo", SqlDbType.Int).Value = numeroPrestamo;
            cm.Parameters.Add("@fechaDevolucion", SqlDbType.Date).Value = fechaDevolucion;
            cm.CommandText = @"INSERT INTO Devolucion (NumeroPrestamo, FechaDevolucion)
                               OUTPUT INSERTED.NumeroDevolucion
                               VALUES (@numeroPrestamo, @fechaDevolucion)";
            con.Open();
            int numeroDevolucion = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return numeroDevolucion;
        }

        public int InsertarMulta(int numeroDevolucion, int diasAtraso, decimal montoPorDia, decimal monto, DateTime fechaGeneracion, string estado)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroDevolucion", SqlDbType.Int).Value = numeroDevolucion;
            cm.Parameters.Add("@diasAtraso", SqlDbType.Int).Value = diasAtraso;
            cm.Parameters.Add("@montoPorDia", SqlDbType.Decimal).Value = montoPorDia;
            cm.Parameters.Add("@monto", SqlDbType.Decimal).Value = monto;
            cm.Parameters.Add("@fechaGeneracion", SqlDbType.Date).Value = fechaGeneracion;
            cm.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado;
            cm.CommandText = @"INSERT INTO Multa (NumeroDevolucion, DiasAtraso, MontoPorDia, Monto, FechaGeneracion, Estado)
                               OUTPUT INSERTED.NumeroMulta
                               VALUES (@numeroDevolucion, @diasAtraso, @montoPorDia, @monto, @fechaGeneracion, @estado)";
            con.Open();
            int numeroMulta = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return numeroMulta;
        }

        public void ActualizarEstadoEjemplar(string codigoEjemplar, string estado)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@codigoEjemplar", SqlDbType.VarChar).Value = codigoEjemplar;
            cm.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado;
            cm.CommandText = "UPDATE Ejemplar SET Estado = @estado WHERE CodigoEjemplar = @codigoEjemplar";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        public void ActualizarEstadoPrestamo(int numeroPrestamo, string estado)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroPrestamo", SqlDbType.Int).Value = numeroPrestamo;
            cm.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado;
            cm.CommandText = "UPDATE Prestamo SET Estado = @estado WHERE NumeroPrestamo = @numeroPrestamo";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }
    }
}
