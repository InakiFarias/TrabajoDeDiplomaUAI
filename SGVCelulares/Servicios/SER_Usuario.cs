namespace Servicio
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
        public int CantIntentos { get; set; }
        public int IdRol { get; set; }
        public SER_Usuario() { }
        public SER_Usuario(string dni)
        {
            Dni = dni;
        }
        public SER_Usuario(string dni, string nombre, string apellido, string correo,string nombreUsuario)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            NombreUsuario = nombreUsuario;
            
        }
        public SER_Usuario(string nombreUsuario, string password)
        {
            NombreUsuario = nombreUsuario;
            Password = password;
        }
       

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
        public SER_Usuario(string dni, string nombre, string apellido, string correo, bool bloqueo, bool activo)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            NombreUsuario = apellido.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries)[0] + dni;
            Password = dni + apellido.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];
            Bloqueo = bloqueo;
            Activo = activo;
            CantIntentos = 0;
        }
        public SER_Usuario(object[] datos)
        {
            Dni = Convert.ToString(datos[0]);
            Nombre = Convert.ToString(datos[1]);
            Apellido = Convert.ToString(datos[2]);
            Correo = Convert.ToString(datos[3]);
            NombreUsuario = Convert.ToString(datos[4]);
            Password = Convert.ToString(datos[5]);
            Bloqueo = Convert.ToBoolean(datos[6]);
            Activo = Convert.ToBoolean(datos[7]);
            CantIntentos = Convert.ToInt16(datos[8]);
        }
    }
}
