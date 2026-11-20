using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Devolucion_351FI : Conexion_351FI
    {
        SqlCommand cm_351FI;
        public DAO_Devolucion_351FI() : base()
        {
            cm_351FI = new SqlCommand("select * from Devolucion_351FI", con_351FI);
        }

        public int InsertarDevolucion_351FI(int numeroPrestamo_351FI, DateTime fechaDevolucion_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroPrestamo", SqlDbType.Int).Value = numeroPrestamo_351FI;
            cm_351FI.Parameters.Add("@fechaDevolucion", SqlDbType.Date).Value = fechaDevolucion_351FI;
            cm_351FI.CommandText = @"INSERT INTO Devolucion_351FI (NumeroPrestamo_351FI, FechaDevolucion_351FI)
                               OUTPUT INSERTED.NumeroDevolucion_351FI
                               VALUES (@numeroPrestamo, @fechaDevolucion)";
            con_351FI.Open();
            int numeroDevolucion = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return numeroDevolucion;
        }

        // Devoluciones con fecha de devolución dentro del período, con su préstamo y el socio
        public SqlDataReader ObtenerDevolucionesPorFecha_351FI(DateTime desde_351FI, DateTime hasta_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@desde", SqlDbType.Date).Value = desde_351FI.Date;
            cm_351FI.Parameters.Add("@hasta", SqlDbType.Date).Value = hasta_351FI.Date;
            cm_351FI.CommandText = @"SELECT d.NumeroDevolucion_351FI, d.FechaDevolucion_351FI,
                                      p.NumeroPrestamo_351FI, p.FechaPrestamo_351FI, p.FechaDevolucionPrevista_351FI, p.Estado_351FI AS EstadoPrestamo,
                                      s.NumeroSocio_351FI, s.Nombre_351FI, s.Apellido_351FI, s.Dni_351FI, s.Estado_351FI AS EstadoSocio
                               FROM Devolucion_351FI d
                               INNER JOIN Prestamo_351FI p ON p.NumeroPrestamo_351FI = d.NumeroPrestamo_351FI
                               INNER JOIN Socio_351FI s ON s.NumeroSocio_351FI = p.NumeroSocio_351FI
                               WHERE d.FechaDevolucion_351FI BETWEEN @desde AND @hasta
                               ORDER BY d.FechaDevolucion_351FI, d.NumeroDevolucion_351FI";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
