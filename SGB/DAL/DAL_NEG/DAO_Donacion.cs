using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Donacion : Conexion
    {
        SqlCommand cm;
        public DAO_Donacion() : base()
        {
            cm = new SqlCommand("select * from Donacion", con);
        }

        // Todas las donaciones con su socio y sus ejemplares (una fila por ejemplar donado)
        public SqlDataReader ObtenerDonaciones()
        {
            cm.Parameters.Clear();
            cm.CommandText = @"SELECT d.NumeroDonacion, d.FechaDonacion,
                                      s.NumeroSocio, s.Nombre, s.Apellido, s.Dni, s.Estado AS EstadoSocio,
                                      e.CodigoEjemplar, e.Estado AS EstadoEjemplar, l.CodigoLibro, l.Titulo
                               FROM Donacion d
                               INNER JOIN Socio s ON s.NumeroSocio = d.NumeroSocio
                               INNER JOIN Donacion_Ejemplar de ON de.NumeroDonacion = d.NumeroDonacion
                               INNER JOIN Ejemplar e ON e.CodigoEjemplar = de.CodigoEjemplar
                               INNER JOIN Libro l ON l.CodigoLibro = e.CodigoLibro
                               ORDER BY d.FechaDonacion DESC, d.NumeroDonacion DESC, e.CodigoEjemplar";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public int InsertarDonacion(int numeroSocio, DateTime fechaDonacion)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio;
            cm.Parameters.Add("@fechaDonacion", SqlDbType.Date).Value = fechaDonacion;
            cm.CommandText = @"INSERT INTO Donacion (NumeroSocio, FechaDonacion)
                               OUTPUT INSERTED.NumeroDonacion
                               VALUES (@numeroSocio, @fechaDonacion)";
            con.Open();
            int numeroDonacion = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return numeroDonacion;
        }

        public void InsertarDetalle(int numeroDonacion, string codigoEjemplar)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroDonacion", SqlDbType.Int).Value = numeroDonacion;
            cm.Parameters.Add("@codigoEjemplar", SqlDbType.VarChar).Value = codigoEjemplar;
            cm.CommandText = "INSERT INTO Donacion_Ejemplar (NumeroDonacion, CodigoEjemplar) VALUES (@numeroDonacion, @codigoEjemplar)";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        public int InsertarRecibo(int numeroDonacion, DateTime fechaEmision)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroDonacion", SqlDbType.Int).Value = numeroDonacion;
            cm.Parameters.Add("@fechaEmision", SqlDbType.Date).Value = fechaEmision;
            cm.CommandText = @"INSERT INTO ReciboDonacion (NumeroDonacion, FechaEmision)
                               OUTPUT INSERTED.NumeroRecibo
                               VALUES (@numeroDonacion, @fechaEmision)";
            con.Open();
            int numeroRecibo = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return numeroRecibo;
        }
    }
}
