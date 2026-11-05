using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Prestamo_351FI : Conexion_351FI
    {
        SqlCommand cm_351FI;
        public DAO_Prestamo_351FI() : base()
        {
            cm_351FI = new SqlCommand("select * from Prestamo_351FI", con_351FI);
        }

        public SqlDataReader ObtenerPrestamoVigente_351FI(int numeroPrestamo_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroPrestamo", SqlDbType.Int).Value = numeroPrestamo_351FI;
            cm_351FI.CommandText = @"SELECT p.NumeroPrestamo_351FI, p.FechaPrestamo_351FI, p.FechaDevolucionPrevista_351FI, p.Estado_351FI AS EstadoPrestamo,
                                      s.NumeroSocio_351FI, s.Nombre_351FI, s.Apellido_351FI, s.Dni_351FI, s.Estado_351FI AS EstadoSocio
                               FROM Prestamo_351FI p
                               INNER JOIN Socio_351FI s ON s.NumeroSocio_351FI = p.NumeroSocio_351FI
                               WHERE p.NumeroPrestamo_351FI = @numeroPrestamo AND p.Estado_351FI = 'Vigente'";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        // Préstamos vigentes cuyo número o DNI del socio empieza con el texto ingresado (búsqueda incremental)
        public SqlDataReader BuscarVigentes_351FI(string texto_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@texto", SqlDbType.VarChar).Value = texto_351FI + "%";
            cm_351FI.CommandText = @"SELECT p.NumeroPrestamo_351FI, p.FechaPrestamo_351FI, p.FechaDevolucionPrevista_351FI, p.Estado_351FI AS EstadoPrestamo,
                                      s.NumeroSocio_351FI, s.Nombre_351FI, s.Apellido_351FI, s.Dni_351FI, s.Estado_351FI AS EstadoSocio
                               FROM Prestamo_351FI p
                               INNER JOIN Socio_351FI s ON s.NumeroSocio_351FI = p.NumeroSocio_351FI
                               WHERE p.Estado_351FI = 'Vigente'
                                 AND (CAST(p.NumeroPrestamo_351FI AS varchar(10)) LIKE @texto OR s.Dni_351FI LIKE @texto)
                               ORDER BY p.FechaDevolucionPrevista_351FI, p.NumeroPrestamo_351FI";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public int InsertarPrestamo_351FI(int numeroSocio_351FI, DateTime fechaPrestamo_351FI, DateTime fechaDevolucionPrevista_351FI, string estado_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio_351FI;
            cm_351FI.Parameters.Add("@fechaPrestamo", SqlDbType.Date).Value = fechaPrestamo_351FI;
            cm_351FI.Parameters.Add("@fechaDevolucionPrevista", SqlDbType.Date).Value = fechaDevolucionPrevista_351FI;
            cm_351FI.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado_351FI;
            cm_351FI.CommandText = @"INSERT INTO Prestamo_351FI (NumeroSocio_351FI, FechaPrestamo_351FI, FechaDevolucionPrevista_351FI, Estado_351FI)
                               OUTPUT INSERTED.NumeroPrestamo_351FI
                               VALUES (@numeroSocio, @fechaPrestamo, @fechaDevolucionPrevista, @estado)";
            con_351FI.Open();
            int numeroPrestamo = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return numeroPrestamo;
        }

        public void InsertarDetalle_351FI(int numeroPrestamo_351FI, string codigoEjemplar_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroPrestamo", SqlDbType.Int).Value = numeroPrestamo_351FI;
            cm_351FI.Parameters.Add("@codigoEjemplar", SqlDbType.VarChar).Value = codigoEjemplar_351FI;
            cm_351FI.CommandText = "INSERT INTO Prestamo_Ejemplar_351FI (NumeroPrestamo_351FI, CodigoEjemplar_351FI) VALUES (@numeroPrestamo, @codigoEjemplar)";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public void ActualizarEstadoEjemplar_351FI(string codigoEjemplar_351FI, string estado_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@codigoEjemplar", SqlDbType.VarChar).Value = codigoEjemplar_351FI;
            cm_351FI.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado_351FI;
            cm_351FI.CommandText = "UPDATE Ejemplar_351FI SET Estado_351FI = @estado WHERE CodigoEjemplar_351FI = @codigoEjemplar";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public int InsertarComprobante_351FI(int numeroPrestamo_351FI, DateTime fechaEmision_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroPrestamo", SqlDbType.Int).Value = numeroPrestamo_351FI;
            cm_351FI.Parameters.Add("@fechaEmision", SqlDbType.Date).Value = fechaEmision_351FI;
            cm_351FI.CommandText = @"INSERT INTO Comprobante_351FI (NumeroPrestamo_351FI, FechaEmision_351FI)
                               OUTPUT INSERTED.NumeroComprobante_351FI
                               VALUES (@numeroPrestamo, @fechaEmision)";
            con_351FI.Open();
            int numeroComprobante = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return numeroComprobante;
        }

        public object ObtenerFechaDevolucionPrevista_351FI(string codigoEjemplar_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@codigoEjemplar", SqlDbType.VarChar).Value = codigoEjemplar_351FI;
            cm_351FI.CommandText = @"SELECT p.FechaDevolucionPrevista_351FI
                               FROM Prestamo_351FI p
                               INNER JOIN Prestamo_Ejemplar_351FI pe ON pe.NumeroPrestamo_351FI = p.NumeroPrestamo_351FI
                               WHERE pe.CodigoEjemplar_351FI = @codigoEjemplar AND p.Estado_351FI = 'Vigente'";
            con_351FI.Open();
            object fecha = cm_351FI.ExecuteScalar();
            con_351FI.Close();
            return fecha;
        }
    }
}