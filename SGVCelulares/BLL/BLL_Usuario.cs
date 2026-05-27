using MAP;
using Servicios;

namespace BLL
{
    public class BLL_Usuario : IABMC<SER_Usuario>
    {
        MAP_Usuario map_usuario;
        BLL_Bitacora bll_bitacora;
        public BLL_Usuario()
        {
            map_usuario = new MAP_Usuario();
            bll_bitacora = new BLL_Bitacora();
        }

        public void Agregar(SER_Usuario usuario)
        {
            try
            {
                if (map_usuario.ValidarDniRepetido(usuario)) throw new Exception("El DNI está repetido!");
                if (map_usuario.ValidarNombreUsuarioRepetido(usuario)) throw new Exception("El nombre de usuario está repetido!");
                if (map_usuario.ValidarCorreoRepetido(usuario)) throw new Exception("El correo electrónico está repetido!");
                string passwordHasheado = SER_Cripto.Encriptar(usuario.Password);
                usuario.Password = passwordHasheado;
                map_usuario.Agregar(usuario);
                SER_Bitacora bitacora = new SER_Bitacora(usuario, DateTime.Now, "Crear usuario", "Usuario", 3);
                bll_bitacora.RegistrarBitacora(bitacora);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Borrar(SER_Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Modificar(SER_Usuario usuario)
        {
            throw new NotImplementedException();
        }
        public List<SER_Usuario> Consultar() => map_usuario.Consultar();
        public List<object> ConsultarParaGrilla()
        {
            var consulta = from u in Consultar()
                           select new
                           {
                               DNI = u.Dni,
                               Apellido = u.Apellido,
                               Nombre = u.Nombre,
                               Login = u.NombreUsuario,
                           };
            return consulta.ToList<object>();
        }

        public SER_Usuario ConsultarPorId(SER_Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
