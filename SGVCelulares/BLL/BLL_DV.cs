using MAP;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DV
    {
        MAP_DV map_dv;
        public BLL_DV() { map_dv = new MAP_DV(); }
        public void VerificarIntegridad()
        {
            //not implemented.
        }

        public void RecalcularDV()
        {
            // Lógica para recalcular el DV
            // Aquí puedes implementar la lógica específica para recalcular el DV según tus 	necesidades
        }
        public void GenerarDVH(object o, string id, string nombreTabla)
        {
            string concatenado = Concatenar(o);
            string hash = SER_Cripto.Encriptar(concatenado);
            SER_DVH ser_dvh = new SER_DVH(nombreTabla, hash, id);
            if (map_dv.ExisteDVH(nombreTabla, id))
            {
                map_dv.ModificarDVH(ser_dvh);
            }
            else
            {
                map_dv.AgregarDVH(ser_dvh);
            }
        }


        public void GenerarDVV(string nombreTabla)
        {
            List<SER_DVH> listaDVH = map_dv.ConsultarDVH(nombreTabla);
            string concatenado = Concatenar(listaDVH);
            SER_DVV ser_dvv = new SER_DVV(nombreTabla, concatenado);
            map_dv.AgregarDVV(ser_dvv);
        }

        public string Concatenar(object obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));

            StringBuilder sb = new StringBuilder();

            PropertyInfo[] propiedades = obj.GetType().GetProperties();

            foreach (PropertyInfo propiedad in propiedades)
            {
                object valor = propiedad.GetValue(obj);

                if (valor != null)
                    sb.Append(valor.ToString());
            }

            return sb.ToString();
        }


    }

}
