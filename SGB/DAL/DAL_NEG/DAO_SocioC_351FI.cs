using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_SocioC_351FI : Conexion_351FI
    {
        SqlCommand cm_351FI;
        public DAO_SocioC_351FI() : base()
        {
            cm_351FI = new SqlCommand("select * from Socio_C_351FI", con_351FI);
        }

        // Versiones de los socios entre dos fechas, filtradas opcionalmente por número de socio y apellido
        public SqlDataReader ConsultarVersiones_351FI(int? numeroSocio_351FI, string apellido_351FI, DateTime fechaDesde_351FI, DateTime fechaHasta_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio_351FI.HasValue ? numeroSocio_351FI.Value : DBNull.Value;
            cm_351FI.Parameters.Add("@apellido", SqlDbType.VarChar).Value = apellido_351FI + "%";
            cm_351FI.Parameters.Add("@fechaDesde", SqlDbType.Date).Value = fechaDesde_351FI.Date;
            cm_351FI.Parameters.Add("@fechaHasta", SqlDbType.Date).Value = fechaHasta_351FI.Date;
            cm_351FI.CommandText = @"SELECT * FROM Socio_C_351FI
                               WHERE (@numeroSocio IS NULL OR NumeroSocio_351FI = @numeroSocio)
                               AND Apellido_351FI LIKE @apellido
                               AND Fecha_351FI BETWEEN @fechaDesde AND @fechaHasta
                               ORDER BY NumeroSocio_351FI, IdVersion_351FI DESC";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        // Una sola sentencia: la versión elegida queda activa y las demás del socio no activas.
        // El trigger TR_Socio_C_Restaurar_351FI copia los datos de la versión a Socio_351FI dentro de la misma transacción.
        public void ActivarVersion_351FI(int idVersion_351FI, int numeroSocio_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@idVersion", SqlDbType.Int).Value = idVersion_351FI;
            cm_351FI.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio_351FI;
            cm_351FI.CommandText = @"UPDATE Socio_C_351FI
                               SET Activo_351FI = CASE WHEN IdVersion_351FI = @idVersion THEN 1 ELSE 0 END
                               WHERE NumeroSocio_351FI = @numeroSocio";
            con_351FI.Open();
            try
            {
                cm_351FI.ExecuteNonQuery();
            }
            finally
            {
                con_351FI.Close();
            }
        }
    }
}
