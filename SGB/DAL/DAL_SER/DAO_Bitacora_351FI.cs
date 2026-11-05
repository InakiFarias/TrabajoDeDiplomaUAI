using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL_SER
{
    public class DAO_Bitacora_351FI : Conexion_351FI,IABMC_351FI
    {
        SqlCommand cm_351FI;
        public DAO_Bitacora_351FI() : base() 
        { 
            cm_351FI = new SqlCommand("select * from bitacora_351FI", con_351FI); 
        }
        public void Agregar_351FI(params object[] T_351FI)
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.Parameters.Add("@dni", SqlDbType.VarChar).Value = T_351FI[0];
            cm_351FI.Parameters.Add("@fecha", SqlDbType.DateTime).Value = T_351FI[1];
            cm_351FI.Parameters.Add("@modulo", SqlDbType.VarChar).Value = T_351FI[2];
            cm_351FI.Parameters.Add("@evento", SqlDbType.VarChar).Value = T_351FI[3];
            cm_351FI.Parameters.Add("@criticidad", SqlDbType.TinyInt).Value = T_351FI[4];

            cm_351FI.CommandText = "INSERT INTO bitacora_351FI(dni_351FI,fecha_351FI,modulo_351FI,evento_351FI,criticidad_351FI) values (@dni,@fecha,@modulo,@evento,@criticidad)";
            con_351FI.Open();
            cm_351FI.ExecuteNonQuery();
            con_351FI.Close();
        }

        public void Borrar_351FI(string id_351FI)
        {
            throw new NotImplementedException();
        }

        public void Modificar_351FI(string id_351FI, params object[] T_351FI)
        {
            throw new NotImplementedException();
        }
        public SqlDataReader Consultar_351FI()
        {
            cm_351FI.Parameters.Clear();
            cm_351FI.CommandText = "SELECT * FROM bitacora_351FI";
            con_351FI.Open();
            return cm_351FI.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader ConsultarPorId_351FI(string id_351FI)
        {
            throw new NotImplementedException();
        }

        public bool ValidarRepetido_351FI(string id_351FI)
        {
            throw new NotImplementedException();
        }

    }
}
