using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL.DAL_SER
{
    public class DAO_DV_351FI : Conexion_351FI
    {
        SqlCommand cm_351FI;
        public DAO_DV_351FI() : base()
        {
            cm_351FI = new SqlCommand("select * from dvh_351FI", con_351FI);
        }

        // ------------------------------------------------ Registros de las tablas protegidas

        public SqlDataReader ConsultarRegistros_351FI(string nombreTabla_351FI, string[] columnasClave_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.CommandText = $"SELECT * FROM {Identificador_351FI(nombreTabla_351FI)} ORDER BY {string.Join(", ", columnasClave_351FI.Select(Identificador_351FI))}";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader ObtenerRegistro_351FI(string nombreTabla_351FI, string[] columnasClave_351FI, object[] valoresClave_351FI)
        {
            if (columnasClave_351FI.Length != valoresClave_351FI.Length)
                throw new ArgumentException($"La clave de la tabla '{nombreTabla_351FI}' tiene {columnasClave_351FI.Length} columnas y se recibieron {valoresClave_351FI.Length} valores.");

            cm_351FI.Parameters.Clear();
            List<string> condiciones = new List<string>();
            for (int i = 0; i < columnasClave_351FI.Length; i++)
            {
                condiciones.Add($"{Identificador_351FI(columnasClave_351FI[i])} = @clave{i}");
                cm_351FI.Parameters.AddWithValue($"@clave{i}", valoresClave_351FI[i]);
            }
            cm_351FI.CommandText = $"SELECT * FROM {Identificador_351FI(nombreTabla_351FI)} WHERE {string.Join(" AND ", condiciones)}";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        // Los nombres de tabla y columna no se pueden pasar como parámetro: se validan y se encierran entre corchetes
        private string Identificador_351FI(string nombre_351FI)
        {
            if (string.IsNullOrEmpty(nombre_351FI) || !nombre_351FI.All(c => char.IsLetterOrDigit(c) || c == '_'))
                throw new ArgumentException($"Nombre de tabla o columna inválido: '{nombre_351FI}'.");
            return $"[{nombre_351FI}]";
        }

        // ------------------------------------------------ DVH

        public void AgregarDVH_351FI(params object[] T_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@NombreTabla", SqlDbType.VarChar).Value = T_351FI[0];
            cm_351FI.Parameters.Add("@IdRegistro", SqlDbType.VarChar).Value = T_351FI[1];
            cm_351FI.Parameters.Add("@Valor", SqlDbType.VarChar).Value = T_351FI[2];

            cm_351FI.CommandText = @"INSERT INTO dvh_351FI
                           (NombreTabla_351FI, IdRegistro_351FI, Valor_351FI)
                           VALUES
                           (@NombreTabla, @IdRegistro, @Valor)";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public void ModificarDVH_351FI(params object[] T_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@NombreTabla", SqlDbType.VarChar).Value = T_351FI[0];
            cm_351FI.Parameters.Add("@IdRegistro", SqlDbType.VarChar).Value = T_351FI[1];
            cm_351FI.Parameters.Add("@Valor", SqlDbType.VarChar).Value = T_351FI[2];

            cm_351FI.CommandText = @"UPDATE dvh_351FI
                           SET Valor_351FI=@Valor
                           WHERE NombreTabla_351FI=@NombreTabla
                           AND IdRegistro_351FI=@IdRegistro";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public void BorrarDVH_351FI(params object[] T_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@NombreTabla", SqlDbType.VarChar).Value = T_351FI[0];
            cm_351FI.Parameters.Add("@IdRegistro", SqlDbType.VarChar).Value = T_351FI[1];
            cm_351FI.CommandText = @"DELETE FROM dvh_351FI
                           WHERE NombreTabla_351FI=@NombreTabla
                           AND IdRegistro_351FI=@IdRegistro";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public bool ExisteDVH_351FI(string nombreTabla_351FI, string idRegistro_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@NombreTabla", SqlDbType.VarChar).Value = nombreTabla_351FI;
            cm_351FI.Parameters.Add("@IdRegistro", SqlDbType.VarChar).Value = idRegistro_351FI;
            cm_351FI.CommandText = @"SELECT COUNT(*)
                       FROM dvh_351FI
                       WHERE NombreTabla_351FI = @NombreTabla
                         AND IdRegistro_351FI = @IdRegistro";
            con_351FI.Open();
            int cantidad = (int)cm_351FI.ExecuteScalar();
            con_351FI.Close();
            return cantidad > 0;
        }

        public SqlDataReader ConsultarDVH_351FI(string nombreTabla_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@NombreTabla", SqlDbType.VarChar).Value = nombreTabla_351FI;
            cm_351FI.CommandText = @"SELECT NombreTabla_351FI, IdRegistro_351FI, Valor_351FI
                               FROM dvh_351FI
                               WHERE NombreTabla_351FI = @NombreTabla";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        // ------------------------------------------------ DVV

        public void AgregarDVV_351FI(params object[] T_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@NombreTabla", SqlDbType.VarChar).Value = T_351FI[0];
            cm_351FI.Parameters.Add("@Valor", SqlDbType.VarChar).Value = T_351FI[1];
            cm_351FI.CommandText = @"INSERT INTO dvv_351FI
                           (NombreTabla_351FI, Valor_351FI)
                           VALUES
                           (@NombreTabla, @Valor)";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public void ModificarDVV_351FI(params object[] T_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@NombreTabla", SqlDbType.VarChar).Value = T_351FI[0];
            cm_351FI.Parameters.Add("@Valor", SqlDbType.VarChar).Value = T_351FI[1];
            cm_351FI.CommandText = @"UPDATE dvv_351FI
                           SET Valor_351FI=@Valor
                           WHERE NombreTabla_351FI=@NombreTabla";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public void BorrarDVV_351FI(params object[] T_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@NombreTabla", SqlDbType.VarChar).Value = T_351FI[0];
            cm_351FI.CommandText = @"DELETE FROM dvv_351FI
                           WHERE NombreTabla_351FI=@NombreTabla";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public bool ExisteDVV_351FI(string nombreTabla_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@NombreTabla", SqlDbType.VarChar).Value = nombreTabla_351FI;
            cm_351FI.CommandText = @"SELECT COUNT(*)
                       FROM dvv_351FI
                       WHERE NombreTabla_351FI = @NombreTabla";
            con_351FI.Open();
            int cantidad = (int)cm_351FI.ExecuteScalar();
            con_351FI.Close();
            return cantidad > 0;
        }

        public SqlDataReader ObtenerDVV_351FI(string nombreTabla_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@NombreTabla", SqlDbType.VarChar).Value = nombreTabla_351FI;
            cm_351FI.CommandText = @"SELECT NombreTabla_351FI, Valor_351FI
                                FROM dvv_351FI
                                WHERE NombreTabla_351FI = @NombreTabla";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
