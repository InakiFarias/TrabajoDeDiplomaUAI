using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO_Donacion : Conexion
    {
        SqlCommand cm;
        public DAO_Donacion() : base()
        {
            cm = new SqlCommand("select * from Donacion", con);
        }

        public object ObtenerDonacionDeEjemplar(string codigoEjemplar)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@codigoEjemplar", SqlDbType.VarChar).Value = codigoEjemplar;
            cm.CommandText = "SELECT NumeroDonacion FROM Donacion_Ejemplar WHERE CodigoEjemplar = @codigoEjemplar";
            con.Open();
            object numeroDonacion = cm.ExecuteScalar();
            con.Close();
            return numeroDonacion;
        }

        public int InsertarDonacion(int numeroSocio, DateTime fechaDonacion)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroSocio", SqlDbType.Int).Value = numeroSocio;
            cm.Parameters.Add("@fechaDonacion", SqlDbType.Date).Value = fechaDonacion;
            cm.CommandText = @"INSERT INTO Donacion (NumeroSocio, FechaDonacion)
                               OUTPUT INSERTED.NumeroDonacion
                               VALUES (@numeroSocio, @fechaDonacion)";
            con.Open();
            int numeroDonacion = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return numeroDonacion;
        }

        public void InsertarDetalle(int numeroDonacion, string codigoEjemplar)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroDonacion", SqlDbType.Int).Value = numeroDonacion;
            cm.Parameters.Add("@codigoEjemplar", SqlDbType.VarChar).Value = codigoEjemplar;
            cm.CommandText = "INSERT INTO Donacion_Ejemplar (NumeroDonacion, CodigoEjemplar) VALUES (@numeroDonacion, @codigoEjemplar)";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        public int InsertarRecibo(int numeroDonacion, DateTime fechaEmision)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@numeroDonacion", SqlDbType.Int).Value = numeroDonacion;
            cm.Parameters.Add("@fechaEmision", SqlDbType.Date).Value = fechaEmision;
            cm.CommandText = @"INSERT INTO ReciboDonacion (NumeroDonacion, FechaEmision)
                               OUTPUT INSERTED.NumeroRecibo
                               VALUES (@numeroDonacion, @fechaEmision)";
            con.Open();
            int numeroRecibo = Convert.ToInt32(cm.ExecuteScalar());
            con.Close();
            return numeroRecibo;
        }
    }
}
