using MAP;
using Servicio;
using System.Reflection;
using System.Text;

namespace BLL
{
    public class BLL_DV
    {
        MAP_DV map_dv;
        private const string SEPARADOR_HASH = "|";
        private const string SEPARADOR_ID = "-";
        public BLL_DV() 
        { 
            map_dv = new MAP_DV();
        }
        public void GenerarDVH(List<string> valores, string nombreTabla)
        {
            string id = string.Join(SEPARADOR_ID, valores);
            string hash = CalcularHash(valores.ToArray());

            SER_DVH ser_dvh = new SER_DVH(nombreTabla, id, hash);

            if (map_dv.ExisteDVH(nombreTabla, id))
                map_dv.ModificarDVH(ser_dvh);
            else
                map_dv.AgregarDVH(ser_dvh);
        }
        public void GenerarDVH(object o, string id, string nombreTabla)
        {
            string hash = CalcularHash(o);
            SER_DVH ser_dvh = new SER_DVH(nombreTabla, id, hash);
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
            List<string> listaDVH = map_dv.ConsultarDVHValores(nombreTabla);

            if (listaDVH.Count == 0)
            {
                if (map_dv.ExisteDVV(nombreTabla))
                    map_dv.BorrarDVV(nombreTabla);
                return;
            }

            string hash = CalcularHash(listaDVH);
            SER_DVV ser_dvv = new SER_DVV(nombreTabla, hash);

            if (map_dv.ExisteDVV(nombreTabla))
                map_dv.ModificarDVV(ser_dvv);
            else
                map_dv.AgregarDVV(ser_dvv);
        }
        public void RecalcularDV()
        {
            var bll_usuario = new BLL_Usuario();
            var bll_rol = new BLL_Rol();
            var bll_familia = new BLL_Familia();

            // Usuarios
            var usuarios = bll_usuario.Consultar().OrderBy(u => u.Dni).ToList();
            if (usuarios.Count > 0)
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
            if (familias.Count > 0)
            {
                foreach (var familia in familias)
                {
                    GenerarDVH(familia, familia.Id.ToString(), "familia");
                }

                GenerarDVV("familia");
            }

            // Tablas intermedias
            RecalcularTablaIntermedia(bll_rol.ConsultarRolFamilia(), "rol_familia");
            RecalcularTablaIntermedia(bll_rol.ConsultarRolPermiso(), "rol_permiso");
            RecalcularTablaIntermedia(bll_familia.ConsultarFamiliaFamilia(), "familia_familia");
            RecalcularTablaIntermedia(bll_familia.ConsultarFamiliaPermiso(), "permiso_familia");
        }
        public void BorrarDVH(string nombreTabla, string id)
        {
            if (map_dv.ExisteDVH(nombreTabla, id))
            {
                map_dv.BorrarDVH(nombreTabla, id);
            }
        }
        public bool VerificarIntegridad()
        {
            var bll_usuario = new BLL_Usuario();
            var bll_rol = new BLL_Rol();
            var bll_familia = new BLL_Familia();

            var usuarios = bll_usuario.Consultar().OrderBy(u => u.Dni).ToList();
            var roles = bll_rol.Consultar().OrderBy(r => r.Id).ToList();
            var familias = bll_familia.Consultar().OrderBy(f => f.Id).ToList();

            var rolFamilia = OrdenarCompuesta(bll_rol.ConsultarRolFamilia());
            var rolPermiso = OrdenarCompuesta(bll_rol.ConsultarRolPermiso());
            var familiaFamilia = OrdenarCompuesta(bll_familia.ConsultarFamiliaFamilia());
            var familiaPermiso = OrdenarCompuesta(bll_familia.ConsultarFamiliaPermiso());

            Func<object[], string> getIdCompuesto = x => $"{x[0]}-{x[1]}";

            return VerificarTabla("usuario", usuarios, u => u.Dni)
                && VerificarTabla("rol", roles, r => Convert.ToString(r.Id))
                && VerificarTabla("familia", familias, f => Convert.ToString(f.Id))
                && VerificarTabla("rol_familia", rolFamilia, getIdCompuesto)
                && VerificarTabla("rol_permiso", rolPermiso, getIdCompuesto)
                && VerificarTabla("familia_familia", familiaFamilia, getIdCompuesto)
                && VerificarTabla("permiso_familia", familiaPermiso, getIdCompuesto);
        }
        private bool VerificarTabla<T>(string nombreTabla, List<T> registros, Func<T, string> getId)
        {
            int cantidadDVH = map_dv.ConsultarDVHValores(nombreTabla).Count;

            if (registros.Count == 0 && cantidadDVH == 0 && !map_dv.ExisteDVV(nombreTabla))
                return true;

            if (cantidadDVH > registros.Count)
                throw new Exception($"La tabla '{nombreTabla}' tiene más entradas en DVH ({cantidadDVH}) que registros reales ({registros.Count}). Posible eliminación directa en BD.");

            var dvhCalculados = registros.Select(reg =>
            {
                string dvhCalc = CalcularHash(reg);
                SER_DVH dvh = map_dv.ObtenerDVH(nombreTabla, getId(reg));

                if (dvh == null)
                    throw new Exception($"No se encontró el DVH para el registro con Datos: {MostrarDatos(reg)}");

                if (dvhCalc != dvh.Valor)
                    throw new Exception($"El DVH para el registro con Datos: {MostrarDatos(reg)} no coincide.");

                return dvhCalc;
            }).ToList();

            SER_DVV dvv = map_dv.ObtenerDVV(nombreTabla);
            if (dvv == null) return false;

            string dvvCalc = CalcularHash(dvhCalculados);
            if (dvvCalc == dvv.Valor) return true;

            throw new Exception($"El DVV para la tabla {nombreTabla} no coincide con el valor calculado.");
        }
        private string Concatenar(object obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));

            if (obj is object[] valores)
            {
                return string.Join(SEPARADOR_HASH, valores.Select(v => v?.ToString() ?? string.Empty));
            }

            if (obj is IEnumerable<string> listaStr)
            {
                return string.Join(SEPARADOR_HASH, listaStr);
            }

            PropertyInfo[] propiedades = obj.GetType().GetProperties().OrderBy(p => p.Name).ToArray();

            return string.Join(SEPARADOR_HASH,
                propiedades.Select(p => p.GetValue(obj)?.ToString() ?? string.Empty));
        }
        private string MostrarDatos(object obj)
        {
            StringBuilder sb = new StringBuilder();
            PropertyInfo[] propiedades = obj.GetType().GetProperties()
                .Where(p => p.PropertyType == typeof(string) ||
                            !typeof(System.Collections.IEnumerable).IsAssignableFrom(p.PropertyType))
                .ToArray();

            foreach (PropertyInfo propiedad in propiedades)
            {
                object valor = propiedad.GetValue(obj);
                sb.Append($"{propiedad.Name}: {valor} | ");
            }
            return sb.ToString().TrimEnd('|', ' ');
        }

        private List<object[]> OrdenarCompuesta(List<object[]> lista)
        {
            return lista.OrderBy(x => Convert.ToInt32(x[0]))
                        .ThenBy(x => Convert.ToInt32(x[1]))
                        .ToList();
        }
        private void RecalcularTablaIntermedia(List<object[]> registros, string nombreTabla)
        {
            if (registros.Count == 0) return;

            foreach (var reg in registros)
            {
                GenerarDVH(new List<string>() { reg[0].ToString(), reg[1].ToString() }, nombreTabla);
            }
            GenerarDVV(nombreTabla);
        }
        public string CalcularHash(object o) => SER_Cripto.Encriptar(Concatenar(o));
    }
}
