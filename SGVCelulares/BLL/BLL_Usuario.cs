using MAP;
using Servicios;

namespace BLL
{
    public class BLL_Usuario
    {
        MAP_Usuario map_usuario;
        BLL_Bitacora bll_bitacora;
        public BLL_Usuario()
        {
            map_usuario = new MAP_Usuario();
            bll_bitacora = new BLL_Bitacora();
        }
        public void CrearUsuario(SER_Usuario usuario)
        {
            try
            {
                if (map_usuario.ValidarDniRepetido(usuario)) throw new Exception("DNI repetido!");
                if (map_usuario.ValidarNombreUsuarioRepetido(usuario)) throw new Exception("Nombre de usuario repetido!");
                if (map_usuario.ValidarCorreoRepetido(usuario)) throw new Exception("Correo repetido!");
                string passwordHasheado = SER_Cripto.Encriptar(usuario.Password);
                usuario.Password = passwordHasheado;
                map_usuario.CrearUsuario(usuario);
                SER_Bitacora bitacora = new SER_Bitacora(usuario, DateTime.Now, "Crear usuario", "Usuario", 3);
                bll_bitacora.RegistrarBitacora(bitacora);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
