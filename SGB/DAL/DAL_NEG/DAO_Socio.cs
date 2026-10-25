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

        public SqlDataReader ObtenerSocios(bool soloActivos)
        {
            cm.Parameters.Clear();
            cm.CommandText = "SELECT * FROM Socio" + (soloActivos ? " WHERE Estado = 'Activo'" : "") + " ORDER BY Apellido, Nombre";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader BuscarPorDni(string dni, bool soloActivos)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni + "%";
            cm.CommandText = "SELECT * FROM Socio WHERE Dni LIKE @dni" + (soloActivos ? " AND Estado = 'Activo'" : "") + " ORDER BY Apellido, Nombre";
            con.Open();
            return cm.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public bool ExisteDni(string dni, int numeroSocioExcluido)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni;
            cm.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocioExcluido;
            cm.CommandText = "SELECT COUNT(*) FROM Socio WHERE Dni = @dni AND NumeroSocio <> @numeroSocio";
            con.Open();
            int cantidad = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return cantidad > 0;
        }

        public int InsertarSocio(string nombre, string apellido, string dni, string estado)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
            cm.Parameters.Add("@apellido", SqlDbType.VarChar).Value = apellido;
            cm.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni;
            cm.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado;
            cm.CommandText = @"INSERT INTO Socio (Nombre, Apellido, Dni, Estado)
                               OUTPUT INSERTED.NumeroSocio
                               VALUES (@nombre, @apellido, @dni, @estado)";
            con.Open();
            int numeroSocio = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return numeroSocio;
        }

        public void ModificarSocio(int numeroSocio, string nombre, string apellido, string dni)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio;
            cm.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
            cm.Parameters.Add("@apellido", SqlDbType.VarChar).Value = apellido;
            cm.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni;
            cm.CommandText = @"UPDATE Socio SET Nombre = @nombre, Apellido = @apellido, Dni = @dni
                               WHERE NumeroSocio = @numeroSocio";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        public void ActualizarEstado(int numeroSocio, string estado)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio;
            cm.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado;
            cm.CommandText = "UPDATE Socio SET Estado = @estado WHERE NumeroSocio = @numeroSocio";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
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
