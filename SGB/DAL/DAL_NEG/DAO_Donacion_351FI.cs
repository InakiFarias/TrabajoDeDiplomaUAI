using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Donacion_351FI : Conexion_351FI
    {
        SqlCommand cm_351FI;
        public DAO_Donacion_351FI() : base()
        {
            cm_351FI = new SqlCommand("select * from Donacion_351FI", con_351FI);
        }

        // Todas las donaciones con su socio y sus ejemplares (una fila por ejemplar donado)
        public SqlDataReader ObtenerDonaciones_351FI()
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.CommandText = @"SELECT d.NumeroDonacion_351FI, d.FechaDonacion_351FI,
                                      s.NumeroSocio_351FI, s.Nombre_351FI, s.Apellido_351FI, s.Dni_351FI, s.Estado_351FI AS EstadoSocio,
                                      e.CodigoEjemplar_351FI, e.Estado_351FI AS EstadoEjemplar, l.CodigoLibro_351FI, l.Titulo_351FI
                               FROM Donacion_351FI d
                               INNER JOIN Socio_351FI s ON s.NumeroSocio_351FI = d.NumeroSocio_351FI
                               INNER JOIN Donacion_Ejemplar_351FI de ON de.NumeroDonacion_351FI = d.NumeroDonacion_351FI
                               INNER JOIN Ejemplar_351FI e ON e.CodigoEjemplar_351FI = de.CodigoEjemplar_351FI
                               INNER JOIN Libro_351FI l ON l.CodigoLibro_351FI = e.CodigoLibro_351FI
                               ORDER BY d.FechaDonacion_351FI DESC, d.NumeroDonacion_351FI DESC, e.CodigoEjemplar_351FI";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public int InsertarDonacion_351FI(int numeroSocio_351FI, DateTime fechaDonacion_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio_351FI;
            cm_351FI.Parameters.Add("@fechaDonacion", SqlDbType.Date).Value = fechaDonacion_351FI;
            cm_351FI.CommandText = @"INSERT INTO Donacion_351FI (NumeroSocio_351FI, FechaDonacion_351FI)
                               OUTPUT INSERTED.NumeroDonacion_351FI
                               VALUES (@numeroSocio, @fechaDonacion)";
            con_351FI.Open();
            int numeroDonacion = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return numeroDonacion;
        }

        public void InsertarDetalle_351FI(int numeroDonacion_351FI, string codigoEjemplar_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroDonacion", SqlDbType.Int).Value = numeroDonacion_351FI;
            cm_351FI.Parameters.Add("@codigoEjemplar", SqlDbType.VarChar).Value = codigoEjemplar_351FI;
            cm_351FI.CommandText = "INSERT INTO Donacion_Ejemplar_351FI (NumeroDonacion_351FI, CodigoEjemplar_351FI) VALUES (@numeroDonacion, @codigoEjemplar)";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public int InsertarRecibo_351FI(int numeroDonacion_351FI, DateTime fechaEmision_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroDonacion", SqlDbType.Int).Value = numeroDonacion_351FI;
            cm_351FI.Parameters.Add("@fechaEmision", SqlDbType.Date).Value = fechaEmision_351FI;
            cm_351FI.CommandText = @"INSERT INTO ReciboDonacion_351FI (NumeroDonacion_351FI, FechaEmision_351FI)
                               OUTPUT INSERTED.NumeroRecibo_351FI
                               VALUES (@numeroDonacion, @fechaEmision)";
            con_351FI.Open();
            int numeroRecibo = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return numeroRecibo;
        }
    }
}
