namespace Servicios
{
    public class SER_Usuario
    {

        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public bool Bloqueo { get; set; }
        public bool Activo { get; set; }

        public SER_Usuario(string dni)
        {
            Dni = dni;
        }
        public SER_Usuario() { }
        public SER_Usuario(string dni, string nombre, string apellido, string correo, string nombreUsuario, string password, bool bloqueo, bool activo)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            NombreUsuario = nombreUsuario;
            Password = password;
            Bloqueo = bloqueo;
            Activo = activo;
        }
    }
}
