using DAL.DAL_SER;
using Microsoft.Data.SqlClient;
using Servicio;

namespace MAP.MAP_SER
{
    public class MAP_DV_351FI
    {
        DAO_DV_351FI dao_dv_351FI;
        public MAP_DV_351FI()
        {
            dao_dv_351FI = new DAO_DV_351FI();
        }

        // ------------------------------------------------ Registros de las tablas protegidas

        public List<SER_Registro_351FI> ConsultarRegistros_351FI(string nombreTabla_351FI, string[] columnasClave_351FI)
        {
            List<SER_Registro_351FI> registros = new List<SER_Registro_351FI>();
            SqlDataReader dr = dao_dv_351FI.ConsultarRegistros_351FI(nombreTabla_351FI, columnasClave_351FI);
            while (dr.Read())
            {
                registros.Add(MapearRegistro_351FI(dr, nombreTabla_351FI, columnasClave_351FI));
            }
            dr.Close();
            return registros;
        }

        public SER_Registro_351FI? ObtenerRegistro_351FI(string nombreTabla_351FI, string[] columnasClave_351FI, object[] valoresClave_351FI)
        {
            SER_Registro_351FI? registro = null;
            SqlDataReader dr = dao_dv_351FI.ObtenerRegistro_351FI(nombreTabla_351FI, columnasClave_351FI, valoresClave_351FI);
            if (dr.Read())
            {
                registro = MapearRegistro_351FI(dr, nombreTabla_351FI, columnasClave_351FI);
            }
            dr.Close();
            return registro;
        }

        private SER_Registro_351FI MapearRegistro_351FI(SqlDataReader dr_351FI, string nombreTabla_351FI, string[] columnasClave_351FI)
        {
            object[] valores = new object[dr_351FI.FieldCount];
            dr_351FI.GetValues(valores);

            string[] campos = new string[dr_351FI.FieldCount];
            for (int i = 0; i < dr_351FI.FieldCount; i++)
                campos[i] = dr_351FI.GetName(i);

            string id = SER_Registro_351FI.ArmarId_351FI(columnasClave_351FI.Select(c => dr_351FI[c]));
            return new SER_Registro_351FI(nombreTabla_351FI, id, campos, valores);
        }

        // ------------------------------------------------ DVH

        public void AgregarDVH_351FI(SER_DVH_351FI dvh_351FI) => dao_dv_351FI.AgregarDVH_351FI(dvh_351FI.NombreTabla_351FI, dvh_351FI.IdRegistro_351FI, dvh_351FI.Valor_351FI);
        public void ModificarDVH_351FI(SER_DVH_351FI dvh_351FI) => dao_dv_351FI.ModificarDVH_351FI(dvh_351FI.NombreTabla_351FI, dvh_351FI.IdRegistro_351FI, dvh_351FI.Valor_351FI);
        public void BorrarDVH_351FI(string nombreTabla_351FI, string idRegistro_351FI) => dao_dv_351FI.BorrarDVH_351FI(nombreTabla_351FI, idRegistro_351FI);
        public bool ExisteDVH_351FI(string nombreTabla_351FI, string idRegistro_351FI) => dao_dv_351FI.ExisteDVH_351FI(nombreTabla_351FI, idRegistro_351FI);

        public List<SER_DVH_351FI> ConsultarDVH_351FI(string nombreTabla_351FI)
        {
            List<SER_DVH_351FI> lista = new List<SER_DVH_351FI>();
            SqlDataReader dr = dao_dv_351FI.ConsultarDVH_351FI(nombreTabla_351FI);
            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                lista.Add(new SER_DVH_351FI(datos));
            }
            dr.Close();
            return lista;
        }

        // ------------------------------------------------ DVV

        public void AgregarDVV_351FI(SER_DVV_351FI dvv_351FI) => dao_dv_351FI.AgregarDVV_351FI(dvv_351FI.NombreTabla_351FI, dvv_351FI.Valor_351FI);
        public void ModificarDVV_351FI(SER_DVV_351FI dvv_351FI) => dao_dv_351FI.ModificarDVV_351FI(dvv_351FI.NombreTabla_351FI, dvv_351FI.Valor_351FI);
        public void BorrarDVV_351FI(string nombreTabla_351FI) => dao_dv_351FI.BorrarDVV_351FI(nombreTabla_351FI);
        public bool ExisteDVV_351FI(string nombreTabla_351FI) => dao_dv_351FI.ExisteDVV_351FI(nombreTabla_351FI);

        public SER_DVV_351FI? ObtenerDVV_351FI(string nombreTabla_351FI)
        {
            SER_DVV_351FI? dvv = null;
            SqlDataReader dr = dao_dv_351FI.ObtenerDVV_351FI(nombreTabla_351FI);
            if (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                dvv = new SER_DVV_351FI(datos);
            }
            dr.Close();
            return dvv;
        }
    }
}
