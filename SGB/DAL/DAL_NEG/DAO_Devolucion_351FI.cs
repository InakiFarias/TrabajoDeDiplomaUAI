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
    }
}
