using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Prestamo : Conexion
    {
        SqlCommand cm;
        public DAO_Prestamo() : base()
        {
            cm = new SqlCommand("select * from Prestamo", con);
        }

        public int ContarPrestamosVigentes(int numeroSocio)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio;
            cm.CommandText = "SELECT COUNT(*) FROM Prestamo WHERE NumeroSocio = @numeroSocio AND Estado = 'Vigente'";
            con.Open();
            int cantidad = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return cantidad;
        }

        public int InsertarPrestamo(int numeroSocio, DateTime fechaPrestamo, DateTime fechaDevolucionPrevista, string estado)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio;
            cm.Parameters.Add("@fechaPrestamo", SqlDbType.Date).Value = fechaPrestamo;
            cm.Parameters.Add("@fechaDevolucionPrevista", SqlDbType.Date).Value = fechaDevolucionPrevista;
            cm.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado;
            cm.CommandText = @"INSERT INTO Prestamo (NumeroSocio, FechaPrestamo, FechaDevolucionPrevista, Estado)
                               OUTPUT INSERTED.NumeroPrestamo
                               VALUES (@numeroSocio, @fechaPrestamo, @fechaDevolucionPrevista, @estado)";
            con.Open();
            int numeroPrestamo = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return numeroPrestamo;
        }

        public void InsertarDetalle(int numeroPrestamo, string codigoEjemplar)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroPrestamo", SqlDbType.Int).Value = numeroPrestamo;
            cm.Parameters.Add("@codigoEjemplar", SqlDbType.VarChar).Value = codigoEjemplar;
            cm.CommandText = "INSERT INTO Prestamo_Ejemplar (NumeroPrestamo, CodigoEjemplar) VALUES (@numeroPrestamo, @codigoEjemplar)";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
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

        public int InsertarComprobante(int numeroPrestamo, DateTime fechaEmision)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroPrestamo", SqlDbType.Int).Value = numeroPrestamo;
            cm.Parameters.Add("@fechaEmision", SqlDbType.Date).Value = fechaEmision;
            cm.CommandText = @"INSERT INTO Comprobante (NumeroPrestamo, FechaEmision)
                               OUTPUT INSERTED.NumeroComprobante
                               VALUES (@numeroPrestamo, @fechaEmision)";
            con.Open();
            int numeroComprobante = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return numeroComprobante;
        }

        public object ObtenerFechaDevolucionPrevista(string codigoEjemplar)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@codigoEjemplar", SqlDbType.VarChar).Value = codigoEjemplar;
            cm.CommandText = @"SELECT p.FechaDevolucionPrevista
                               FROM Prestamo p
                               INNER JOIN Prestamo_Ejemplar pe ON pe.NumeroPrestamo = p.NumeroPrestamo
                               WHERE pe.CodigoEjemplar = @codigoEjemplar AND p.Estado = 'Vigente'";
            con.Open();
            object fecha = cm.ExecuteScalar();
            con.Close();
            return fecha;
        }
    }
}