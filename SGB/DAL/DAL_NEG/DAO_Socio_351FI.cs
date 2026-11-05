using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Socio_351FI : Conexion_351FI
    {
        SqlCommand cm_351FI;
        public DAO_Socio_351FI() : base()
        {
            cm_351FI = new SqlCommand("select * from Socio_351FI", con_351FI);
        }

        public SqlDataReader ObtenerSocios_351FI(bool soloActivos_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.CommandText = "SELECT * FROM Socio_351FI" + (soloActivos_351FI ? " WHERE Estado_351FI = 'Activo'" : "") + " ORDER BY Apellido_351FI, Nombre_351FI";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader BuscarPorDni_351FI(string dni_351FI, bool soloActivos_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni_351FI + "%";
            cm_351FI.CommandText = "SELECT * FROM Socio_351FI WHERE Dni_351FI LIKE @dni" + (soloActivos_351FI ? " AND Estado_351FI = 'Activo'" : "") + " ORDER BY Apellido_351FI, Nombre_351FI";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public bool ExisteDni_351FI(string dni_351FI, int numeroSocioExcluido_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni_351FI;
            cm_351FI.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocioExcluido_351FI;
            cm_351FI.CommandText = "SELECT COUNT(*) FROM Socio_351FI WHERE Dni_351FI = @dni AND NumeroSocio_351FI <> @numeroSocio";
            con_351FI.Open();
            int cantidad = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return cantidad > 0;
        }

        public int InsertarSocio_351FI(string nombre_351FI, string apellido_351FI, string dni_351FI, string estado_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre_351FI;
            cm_351FI.Parameters.Add("@apellido", SqlDbType.VarChar).Value = apellido_351FI;
            cm_351FI.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni_351FI;
            cm_351FI.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado_351FI;
            cm_351FI.CommandText = @"INSERT INTO Socio_351FI (Nombre_351FI, Apellido_351FI, Dni_351FI, Estado_351FI)
                               OUTPUT INSERTED.NumeroSocio_351FI
                               VALUES (@nombre, @apellido, @dni, @estado)";
            con_351FI.Open();
            int numeroSocio = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return numeroSocio;
        }

        public void ModificarSocio_351FI(int numeroSocio_351FI, string nombre_351FI, string apellido_351FI, string dni_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio_351FI;
            cm_351FI.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre_351FI;
            cm_351FI.Parameters.Add("@apellido", SqlDbType.VarChar).Value = apellido_351FI;
            cm_351FI.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni_351FI;
            cm_351FI.CommandText = @"UPDATE Socio_351FI SET Nombre_351FI = @nombre, Apellido_351FI = @apellido, Dni_351FI = @dni
                               WHERE NumeroSocio_351FI = @numeroSocio";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public void ActualizarEstado_351FI(int numeroSocio_351FI, string estado_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio_351FI;
            cm_351FI.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado_351FI;
            cm_351FI.CommandText = "UPDATE Socio_351FI SET Estado_351FI = @estado WHERE NumeroSocio_351FI = @numeroSocio";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public int ContarPrestamosVigentes_351FI(int numeroSocio_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio_351FI;
            cm_351FI.CommandText = "SELECT COUNT(*) FROM Prestamo_351FI WHERE NumeroSocio_351FI = @numeroSocio AND Estado_351FI = 'Vigente'";
            con_351FI.Open();
            int cantidad = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return cantidad;
        }

        public int ContarPrestamosVencidos_351FI(int numeroSocio_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio_351FI;
            cm_351FI.CommandText = @"SELECT COUNT(*) FROM Prestamo_351FI
                               WHERE NumeroSocio_351FI = @numeroSocio
                               AND Estado_351FI = 'Vigente'
                               AND FechaDevolucionPrevista_351FI < CAST(GETDATE() AS date)";
            con_351FI.Open();
            int cantidad = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return cantidad;
        }

        public int ContarMultasPendientes_351FI(int numeroSocio_351FI)
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
    }
}
