using DAL.DAL_SER;
using Microsoft.Data.SqlClient;
using Servicio;

namespace MAP.MAP_SER
{
    public class MAP_Bitacora_351FI
    {
        DAO_Bitacora_351FI dao_bitacora_351FI;
        MAP_Usuario_351FI map_usuario_351FI;
        public MAP_Bitacora_351FI()
        {
            dao_bitacora_351FI = new DAO_Bitacora_351FI();
            map_usuario_351FI = new MAP_Usuario_351FI();
        }
        public void RegistrarBitacora_351FI(SER_Bitacora_351FI bitacora_351FI) => dao_bitacora_351FI.Agregar_351FI(bitacora_351FI.Usuario_351FI.Dni_351FI, bitacora_351FI.Fecha_351FI, bitacora_351FI.Modulo_351FI, bitacora_351FI.Evento_351FI, bitacora_351FI.Criticidad_351FI);
        public List<SER_Bitacora_351FI> Consultar_351FI()
        {
            List<SER_Bitacora_351FI> lista = new List<SER_Bitacora_351FI>();
            SqlDataReader dr = dao_bitacora_351FI.Consultar_351FI();

            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);

                SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(
                    map_usuario_351FI.ConsultarPorId_351FI(new SER_Usuario_351FI(datos[1].ToString())),
                    Convert.ToDateTime(datos[2]),
                    Convert.ToString(datos[3]),
                    Convert.ToString(datos[4]),
                    Convert.ToInt16(datos[5])
                );
                lista.Add(bitacora);
            }
            dr.Close();
            return lista;
        }
    }
}
