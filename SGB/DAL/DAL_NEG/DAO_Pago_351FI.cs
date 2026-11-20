using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Pago_351FI : Conexion_351FI
    {
        SqlCommand cm_351FI;
        public DAO_Pago_351FI() : base()
        {
            cm_351FI = new SqlCommand("select * from Pago_351FI", con_351FI);
        }

        public int InsertarPago_351FI(int numeroSocio_351FI, DateTime fechaPago_351FI, string metodoPago_351FI, decimal total_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio_351FI;
            cm_351FI.Parameters.Add("@fechaPago", SqlDbType.Date).Value = fechaPago_351FI;
            cm_351FI.Parameters.Add("@metodoPago", SqlDbType.VarChar).Value = metodoPago_351FI;
            cm_351FI.Parameters.Add("@total", SqlDbType.Decimal).Value = total_351FI;
            cm_351FI.CommandText = @"INSERT INTO Pago_351FI (NumeroSocio_351FI, FechaPago_351FI, MetodoPago_351FI, Total_351FI)
                               OUTPUT INSERTED.NumeroPago_351FI
                               VALUES (@numeroSocio, @fechaPago, @metodoPago, @total)";
            con_351FI.Open();
            int numeroPago = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return numeroPago;
        }
    }
}
