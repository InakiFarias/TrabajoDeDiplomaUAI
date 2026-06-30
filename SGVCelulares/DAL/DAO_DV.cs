using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAO_DV : Conexion
    {
        SqlCommand cm;

        public DAO_DV() : base()
        {
            cm = new SqlCommand("select * from dvh", con);
        }
        public void AgregarDVH(params object[] T)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@NombreTabla", SqlDbType.VarChar).Value = T[0];
            cm.Parameters.Add("@IdRegistro", SqlDbType.VarChar).Value = T[1];
            cm.Parameters.Add("@Valor", SqlDbType.VarChar).Value = T[2];

            cm.CommandText = @"INSERT INTO dvh
                           (NombreTabla, IdRegistro, Valor)
                           VALUES
                           (@NombreTabla, @IdRegistro, @Valor)";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        public void ModificarDVH(params object[] T)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@NombreTabla", SqlDbType.VarChar).Value = T[0];
            cm.Parameters.Add("@IdRegistro", SqlDbType.VarChar).Value = T[1];
            cm.Parameters.Add("@Valor", SqlDbType.VarChar).Value = T[2];

            cm.CommandText = @"UPDATE dvh
                           SET Valor=@Valor
                           WHERE NombreTabla=@NombreTabla
                           AND IdRegistro=@IdRegistro";
            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        public void AgregarDVV(params object[] T)
        {
            cm.Parameters.Clear();

            cm.CommandText = @"INSERT INTO dvv
                           (NombreTabla, Valor)
                           VALUES
                           (@NombreTabla, @Valor)";

            cm.Parameters.Add("@NombreTabla", SqlDbType.VarChar).Value = T[0];
            cm.Parameters.Add("@Valor", SqlDbType.VarChar).Value = T[1];

            con.Open();
            cm.ExecuteNonQuery();
            con.Close();
        }

        public bool ExisteDVH(string nombreTabla, string idRegistro)
        {
            cm.Parameters.Clear();
            cm.Parameters.Add("@NombreTabla", SqlDbType.VarChar).Value = nombreTabla;
            cm.Parameters.Add("@IdRegistro", SqlDbType.VarChar).Value = idRegistro;
            cm.CommandText = @"SELECT COUNT(*) 
                       FROM dvh 
                       WHERE NombreTabla = @NombreTabla 
                         AND IdRegistro = @IdRegistro";
            con.Open();

            int cantidad = (int)cm.ExecuteScalar();

            con.Close();

            return cantidad > 0;
        }
        public SqlDataReader ConsultarDVH(string nombreTabla)
        {
            cm.Parameters.Clear();
            cm.CommandText = @"SELECT * 
                       FROM dvh 
                       WHERE NombreTabla = @NombreTabla
                        ORDERBY IdRegistro";
            cm.Parameters.Add("@NombreTabla", SqlDbType.VarChar).Value = nombreTabla;
            con.Open();
            SqlDataReader reader = cm.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

    }
}
