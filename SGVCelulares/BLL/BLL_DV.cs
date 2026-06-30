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
       
        public BLL_DV() 
        { 
            map_dv = new MAP_DV();
            
        }
        public bool VerificarIntegridad()
        {
            var bll_usuario = new BLL_Usuario();
            var bll_rol = new BLL_Rol();
            var bll_familia = new BLL_Familia();

            var l = bll_usuario.Consultar().OrderBy(u => u.Dni).ToList();
            var l2 = bll_rol.Consultar().OrderBy(r => r.Id).ToList();
            var l3 = bll_familia.Consultar().OrderBy(f => f.Id).ToList();

            return VerificarTabla("usuario", l, u => u.Dni)
                && VerificarTabla("rol", l2, r => Convert.ToString(r.Id))
                && VerificarTabla("familia", l3, f => Convert.ToString(f.Id));
        }

        private bool VerificarTabla<T>(string nombreTabla, List<T> registros, Func<T, string> getId)
        {
            int cantidadDVH = map_dv.ConsultarDVHValores(nombreTabla).Count();

            if (registros.Count == 0 && cantidadDVH == 0)
                return true;

            if (registros.Count != cantidadDVH)
                return false;

            List<string> dvhCalculados = new List<string>();

            foreach (var reg in registros)
            {
                string dvhCalc = CalcularHash(reg);
                SER_DVH dvh = map_dv.ObtenerDVH(nombreTabla, getId(reg));

                if (dvh == null)
                    return false;

                if (dvhCalc != dvh.Valor)
                    return false;

                dvhCalculados.Add(dvhCalc);
            }

            string dvvCalc = CalcularHash(dvhCalculados);
            SER_DVV dvv = map_dv.ObtenerDVV(nombreTabla);

            if (dvv == null) return false;
              

            return dvvCalc == dvv.Valor;
        }
        public void RecalcularDV()
        {
            var bll_usuario = new BLL_Usuario();
            var bll_rol = new BLL_Rol();
            var bll_familia = new BLL_Familia();
            
            // Usuarios
            var usuarios = bll_usuario.Consultar().OrderBy(u => u.Dni).ToList();
            if(usuarios.Count > 0) 
            {
                foreach (var usuario in usuarios)
                {
                    GenerarDVH(usuario, usuario.Dni, "usuario");
                }

                GenerarDVV("usuario");
            }
           
            // Roles
            var roles = bll_rol.Consultar().OrderBy(r => r.Id).ToList();
            if (roles.Count > 0)
            {
                foreach (var rol in roles)
                {
                    GenerarDVH(rol, rol.Id.ToString(), "rol");

                }

                GenerarDVV("rol");
            }

            // Familias
            var familias = bll_familia.Consultar().OrderBy(f => f.Id).ToList();
            if(familias.Count > 0) 
            {
                foreach (var familia in familias)
                {
                    GenerarDVH(familia, familia.Id.ToString(), "familia");
                }

                GenerarDVV("familia");
            }
           
        }
        
        public string CalcularHash(object o) { return SER_Cripto.Encriptar(Concatenar(o)); }
        public void GenerarDVH(object o, string id, string nombreTabla)
        {
            string hash = CalcularHash(o);
            SER_DVH ser_dvh = new SER_DVH(nombreTabla,id,hash);
            if (map_dv.ExisteDVH(nombreTabla, id))
            {
                map_dv.ModificarDVH(ser_dvh);
            }
            else
            {
                map_dv.AgregarDVH(ser_dvh);
            }
        }
        public void BorrarDVH(string nombreTabla, string id)
        {
            if (map_dv.ExisteDVH(nombreTabla, id))
            {
                map_dv.BorrarDVH(nombreTabla, id);
            }
        }



        public void GenerarDVV(string nombreTabla)
        {
            List<string> listaDVH = map_dv.ConsultarDVHValores(nombreTabla);

            if (listaDVH.Count == 0) return;
            
            string hash = CalcularHash(listaDVH);

            SER_DVV ser_dvv = new SER_DVV(nombreTabla, hash);

            if (map_dv.ExisteDVV(nombreTabla))
            {
                map_dv.ModificarDVV(ser_dvv);
            }
            else
            {
                map_dv.AgregarDVV(ser_dvv);
            }
        }

        public string Concatenar(object obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            
            if (obj is IEnumerable<string> lista)
            {
                return string.Concat(lista);
            }
            StringBuilder sb = new StringBuilder();

            PropertyInfo[] propiedades = obj.GetType().GetProperties()
                .Where(p => p.PropertyType != typeof(List<SER_Componente>)) // excluye relaciones, no columnas en caso que sea un ROL o FAMILIA
                .OrderBy(p => p.Name)
                .ToArray();

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
