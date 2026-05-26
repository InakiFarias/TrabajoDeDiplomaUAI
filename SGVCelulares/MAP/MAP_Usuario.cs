using DAL;
using Servicios;

namespace MAP
{
    public class MAP_Usuario
    {
        DAO_Usuario dao_usuario;
        public MAP_Usuario()
        {
            dao_usuario = new DAO_Usuario();
        }
        public bool ValidarDniRepetido(SER_Usuario usuario)
        {
            return dao_usuario.ValidarRepetido(usuario.Dni);
        }
        public bool ValidarNombreUsuarioRepetido(SER_Usuario usuario)
        {
            return dao_usuario.ValidarNombreUsuarioRepetido(usuario.NombreUsuario);
        }
        public bool ValidarCorreoRepetido(SER_Usuario usuario)
        {
            return dao_usuario.ValidarCorreoRepetido(usuario.Correo);
        }
        public void CrearUsuario(SER_Usuario usuario)
        {
            dao_usuario.Agregar(usuario.Dni, usuario.Nombre, usuario.Apellido, usuario.Correo, usuario.NombreUsuario, usuario.Password, usuario.Bloqueo, usuario.Activo);
        }
    }
}
