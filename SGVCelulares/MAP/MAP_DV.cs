using DAL;
using Microsoft.Data.SqlClient;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP
{
    public class MAP_DV
    {

        DAO_DV dao_dv;
        public MAP_DV() { dao_dv = new DAO_DV(); }
        public void AgregarDVH(SER_DVH dvh)
        {
            dao_dv.AgregarDVH(dvh.NombreTabla, dvh.IdRegistro, dvh.Valor);
        }

        public void ModificarDVH(SER_DVH dvh)
        {
            dao_dv.ModificarDVH(dvh.NombreTabla, dvh.IdRegistro, dvh.Valor);
        }

        public void AgregarDVV(SER_DVV dvv)
        {
            dao_dv.AgregarDVV(dvv.NombreTabla, dvv.Valor);
        }
        public bool ExisteDVH(string nombreTabla, string id)
        {
            return dao_dv.ExisteDVH(nombreTabla, id);
        }
        public List<SER_DVH> ConsultarDVH(string nombreTabla)
        {
            List<SER_DVH> listaDVH = new List<SER_DVH>();

            SqlDataReader dr = dao_dv.ConsultarDVH(nombreTabla);

            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                SER_DVH dvh = new SER_DVH(datos);
                listaDVH.Add(dvh);
            }

            dr.Close();

            return listaDVH;
        }

    }
}
