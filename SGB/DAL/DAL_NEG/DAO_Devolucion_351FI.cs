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

        public int InsertarMulta_351FI(int numeroDevolucion_351FI, int diasAtraso_351FI, decimal montoPorDia_351FI, decimal monto_351FI, DateTime fechaGeneracion_351FI, string estado_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroDevolucion", SqlDbType.Int).Value = numeroDevolucion_351FI;
            cm_351FI.Parameters.Add("@diasAtraso", SqlDbType.Int).Value = diasAtraso_351FI;
            cm_351FI.Parameters.Add("@montoPorDia", SqlDbType.Decimal).Value = montoPorDia_351FI;
            cm_351FI.Parameters.Add("@monto", SqlDbType.Decimal).Value = monto_351FI;
            cm_351FI.Parameters.Add("@fechaGeneracion", SqlDbType.Date).Value = fechaGeneracion_351FI;
            cm_351FI.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado_351FI;
            cm_351FI.CommandText = @"INSERT INTO Multa_351FI (NumeroDevolucion_351FI, DiasAtraso_351FI, MontoPorDia_351FI, Monto_351FI, FechaGeneracion_351FI, Estado_351FI)
                               OUTPUT INSERTED.NumeroMulta_351FI
                               VALUES (@numeroDevolucion, @diasAtraso, @montoPorDia, @monto, @fechaGeneracion, @estado)";
            con_351FI.Open();
            int numeroMulta = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return numeroMulta;
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

        public void ActualizarEstadoPrestamo_351FI(int numeroPrestamo_351FI, string estado_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroPrestamo", SqlDbType.Int).Value = numeroPrestamo_351FI;
            cm_351FI.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado_351FI;
            cm_351FI.CommandText = "UPDATE Prestamo_351FI SET Estado_351FI = @estado WHERE NumeroPrestamo_351FI = @numeroPrestamo";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public int InsertarComprobante_351FI(int numeroDevolucion_351FI, DateTime fechaEmision_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@numeroDevolucion", SqlDbType.Int).Value = numeroDevolucion_351FI;
            cm_351FI.Parameters.Add("@fechaEmision", SqlDbType.Date).Value = fechaEmision_351FI;
            cm_351FI.CommandText = @"INSERT INTO ComprobanteDevolucion_351FI (NumeroDevolucion_351FI, FechaEmision_351FI)
                               OUTPUT INSERTED.NumeroComprobante_351FI
                               VALUES (@numeroDevolucion, @fechaEmision)";
            con_351FI.Open();
            int numeroComprobante = Convert.ToInt32(cm_351FI.ExecuteScalar());
            con_351FI.Close();
            return numeroComprobante;
        }
    }
}
