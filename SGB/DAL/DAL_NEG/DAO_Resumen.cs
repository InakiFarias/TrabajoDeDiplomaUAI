using Microsoft.Data.SqlClient;

namespace DAL
{
    // Cifras del día que se muestran en la pantalla de inicio
    public class DAO_Resumen : Conexion
    {
        SqlCommand cm;
        public DAO_Resumen() : base()
        {
            cm = new SqlCommand("select 1", con);
        }

        private object Consultar(string sql)
        {
            cm.Parameters.Clear();
            cm.CommandText = sql;
            con.Open();
            object valor = cm.ExecuteScalar();
            con.Close();
            return valor;
        }

        public int ContarPrestamosVigentes() =>
            Convert.ToInt32(Consultar("SELECT COUNT(*) FROM Prestamo WHERE Estado = 'Vigente'"));

        public int ContarPrestamosVencidos() =>
            Convert.ToInt32(Consultar(@"SELECT COUNT(*) FROM Prestamo
                                        WHERE Estado = 'Vigente' AND FechaDevolucionPrevista < CAST(GETDATE() AS date)"));

        public int ContarMultasPendientes() =>
            Convert.ToInt32(Consultar("SELECT COUNT(*) FROM Multa WHERE Estado = 'Pendiente de pago'"));

        public decimal SumarMultasPendientes() =>
            Convert.ToDecimal(Consultar("SELECT ISNULL(SUM(Monto), 0) FROM Multa WHERE Estado = 'Pendiente de pago'"));
    }
}
