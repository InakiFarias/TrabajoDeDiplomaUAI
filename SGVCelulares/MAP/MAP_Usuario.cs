using DAL;
using Microsoft.Data.SqlClient;
using Servicios;

namespace MAP
{
    public class MAP_Usuario : IABMC<SER_Usuario>
    {
        DAO_Usuario dao_usuario;
        public MAP_Usuario()
        {
            dao_usuario = new DAO_Usuario();
        }

        public void Agregar(SER_Usuario usuario)
        {
            dao_usuario.Agregar(usuario.Dni, usuario.Nombre, usuario.Apellido, usuario.Correo, usuario.NombreUsuario, usuario.Password, usuario.Bloqueo, usuario.Activo);
        }

        public void Borrar(SER_Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Modificar(SER_Usuario usuario)
        {
            throw new NotImplementedException();
        }
        public List<SER_Usuario> Consultar()
        {
            List<SER_Usuario> lista = new List<SER_Usuario>();
            SqlDataReader dr = dao_usuario.Consultar();

            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                lista.Add(new SER_Usuario(datos));
            }
            dr.Close();
            return lista;
        }
        public SER_Usuario ConsultarPorId(SER_Usuario usuario)
        {
            throw new NotImplementedException();
        }
        public bool ValidarDniRepetido(SER_Usuario usuario) => dao_usuario.ValidarRepetido(usuario.Dni);
        public bool ValidarNombreUsuarioRepetido(SER_Usuario usuario) => dao_usuario.ValidarNombreUsuarioRepetido(usuario.NombreUsuario);
        public bool ValidarCorreoRepetido(SER_Usuario usuario) => dao_usuario.ValidarCorreoRepetido(usuario.Correo);
    }
}
