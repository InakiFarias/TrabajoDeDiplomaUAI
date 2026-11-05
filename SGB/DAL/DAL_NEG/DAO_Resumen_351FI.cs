using Microsoft.Data.SqlClient;

namespace DAL
{
    // Cifras del día que se muestran en la pantalla de inicio
    public class DAO_Resumen_351FI : Conexion_351FI
    {
        SqlCommand cm_351FI;
        public DAO_Resumen_351FI() : base()
        {
            cm_351FI = new SqlCommand("select 1", con_351FI);
        }

        private object Consultar_351FI(string sql_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.CommandText = sql_351FI;
            con_351FI.Open();
            object valor = cm_351FI.ExecuteScalar();
            con_351FI.Close();
            return valor;
        }

        public int ContarPrestamosVigentes_351FI() =>
            Convert.ToInt32(Consultar_351FI("SELECT COUNT(*) FROM Prestamo_351FI WHERE Estado_351FI = 'Vigente'"));

        public int ContarPrestamosVencidos_351FI() =>
            Convert.ToInt32(Consultar_351FI(@"SELECT COUNT(*) FROM Prestamo_351FI
                                        WHERE Estado_351FI = 'Vigente' AND FechaDevolucionPrevista_351FI < CAST(GETDATE() AS date)"));

        public int ContarMultasPendientes_351FI() =>
            Convert.ToInt32(Consultar_351FI("SELECT COUNT(*) FROM Multa_351FI WHERE Estado_351FI = 'Pendiente de pago'"));

        public decimal SumarMultasPendientes_351FI() =>
            Convert.ToDecimal(Consultar_351FI("SELECT ISNULL(SUM(Monto_351FI), 0) FROM Multa_351FI WHERE Estado_351FI = 'Pendiente de pago'"));
    }
}
