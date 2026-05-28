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
                if (map_usuario.ExisteNombreUsuario(usuario)) throw new Exception("El nombre de usuario está repetido!");
                if (map_usuario.ValidarCorreoRepetido(usuario)) throw new Exception("El correo electrónico está repetido!");
                string passwordHasheado = SER_Cripto.Encriptar(usuario.Password);
                usuario.Password = passwordHasheado;
                map_usuario.Agregar(usuario);
                SER_Bitacora bitacora = new SER_Bitacora(SER_SesionManager.ObtenerSesion().Usuario, DateTime.Now, "Crear usuario", "Usuario", 3);
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
            map_usuario.Modificar(usuario);
            SER_Bitacora bitacora = new SER_Bitacora(SER_SesionManager.ObtenerSesion().Usuario, DateTime.Now, "Modificar usuario", "Usuario", 2);
            bll_bitacora.RegistrarBitacora(bitacora);
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
            return map_usuario.ConsultarPorId(usuario);

        }
        public bool Login(SER_Usuario usuario)
        {
            bool rdo = false;
            SER_Usuario obj = map_usuario.ConsultarPorNombreUsuario(usuario);
            if (obj == null) throw new Exception("Datos erróneos!");

            if (EstaBloqueado(obj)) throw new Exception("La cuenta está bloqueada!");
            if (!EstaActivo(obj)) throw new Exception("El usuario se encuentra desactivado!");
            if (!CompararPassword(obj, usuario.Password))
            {
                map_usuario.SumarCantidadIntento(obj);
                if (map_usuario.ConsultarPorNombreUsuario(usuario).CantIntentos == 3)
                {
                    map_usuario.Bloquear(obj);
                    throw new Exception("Se bloqueó el usuario por motivos de seguridad!");
                }
            }
            
            rdo = true;
            SER_SesionManager sesion = SER_SesionManager.ObtenerSesion();
            sesion.Usuario = obj;
            map_usuario.ReiniciarIntentos(obj);


            SER_Bitacora bitacora = new SER_Bitacora(obj, DateTime.Now, "Login usuario", "Usuario", 1);
            bll_bitacora.RegistrarBitacora(bitacora);
            
            return rdo;
        }
        private bool CompararPassword(SER_Usuario usuario, string password)
        {
            bool rdo = false;
            string passwordHasheada = SER_Cripto.Encriptar(password);
            if (passwordHasheada == usuario.Password) rdo = true;
            return rdo;
        }
        private bool EstaBloqueado(SER_Usuario usuario)
        {
            bool rdo = false;
            if (usuario.Bloqueo) rdo = true;
            return rdo;
        }
        private bool EstaActivo(SER_Usuario usuario)
        {
            bool rdo = false;
            if (usuario.Activo) rdo = true;
            return rdo;
        }
        public void Desbloquear(SER_Usuario usuario)
        {
            try
            {
                if (!EstaBloqueado(usuario)) throw new Exception("El usuario no está bloqueado!");
                map_usuario.Desbloquear(usuario);
                SER_Bitacora bitacora = new SER_Bitacora(SER_SesionManager.ObtenerSesion().Usuario, DateTime.Now, "Desbloquear usuario", "Usuario", 3);
                bll_bitacora.RegistrarBitacora(bitacora);
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
    }
}
