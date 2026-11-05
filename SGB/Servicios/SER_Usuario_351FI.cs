namespace Servicio
{
    public class SER_Usuario_351FI
    {

        public string Dni_351FI { get; set; }
        public string Nombre_351FI { get; set; }
        public string Apellido_351FI { get; set; }
        public string Correo_351FI { get; set; }
        public string NombreUsuario_351FI { get; set; }
        public string Password_351FI { get; set; }
        public bool Bloqueo_351FI { get; set; }
        public bool Activo_351FI { get; set; }
        public int CantIntentos_351FI { get; set; }
        public SER_Rol_351FI Rol_351FI { get; set; }
        public string IdIdioma_351FI { get; set; }
        public SER_Usuario_351FI() { }
        public SER_Usuario_351FI(string dni_351FI)
        {
            Dni_351FI = dni_351FI;
        }
        public SER_Usuario_351FI(string dni_351FI, string nombre_351FI, string apellido_351FI, string correo_351FI,string nombreUsuario_351FI)
        {
            Dni_351FI = dni_351FI;
            Nombre_351FI = nombre_351FI;
            Apellido_351FI = apellido_351FI;
            Correo_351FI = correo_351FI;
            NombreUsuario_351FI = nombreUsuario_351FI;
            
        }
        public SER_Usuario_351FI(string nombreUsuario_351FI, string password_351FI)
        {
            NombreUsuario_351FI = nombreUsuario_351FI;
            Password_351FI = password_351FI;
        }
       

        public SER_Usuario_351FI(string dni_351FI, string nombre_351FI, string apellido_351FI, string correo_351FI, string nombreUsuario_351FI, string password_351FI, bool bloqueo_351FI, bool activo_351FI)
        {
            Dni_351FI = dni_351FI;
            Nombre_351FI = nombre_351FI;
            Apellido_351FI = apellido_351FI;
            Correo_351FI = correo_351FI;
            NombreUsuario_351FI = nombreUsuario_351FI;
            Password_351FI = password_351FI;
            Bloqueo_351FI = bloqueo_351FI;
            Activo_351FI = activo_351FI;
        }
        public SER_Usuario_351FI(string dni_351FI, string nombre_351FI, string apellido_351FI, string correo_351FI, string nombreUsuario_351FI, string password_351FI, bool bloqueo_351FI, bool activo_351FI, int cantIntentos_351FI, SER_Rol_351FI rol_351FI, string idIdioma_351FI)
        {
            Dni_351FI = dni_351FI;
            Nombre_351FI = nombre_351FI;
            Apellido_351FI = apellido_351FI;
            Correo_351FI = correo_351FI;
            NombreUsuario_351FI = nombreUsuario_351FI;
            Password_351FI = password_351FI;
            Bloqueo_351FI = bloqueo_351FI;
            Activo_351FI = activo_351FI;
            CantIntentos_351FI = cantIntentos_351FI;
            Rol_351FI = rol_351FI;
            IdIdioma_351FI = idIdioma_351FI;
        }
        public SER_Usuario_351FI(string dni_351FI, string nombre_351FI, string apellido_351FI, string correo_351FI, string nombreUsuario_351FI, bool bloqueo_351FI, bool activo_351FI, SER_Rol_351FI rol_351FI)
        {
            Dni_351FI = dni_351FI;
            Nombre_351FI = nombre_351FI;
            Apellido_351FI = apellido_351FI;
            Correo_351FI = correo_351FI;
            NombreUsuario_351FI = nombreUsuario_351FI;
            Bloqueo_351FI = bloqueo_351FI;
            Activo_351FI = activo_351FI;
            Rol_351FI = rol_351FI;
        }
        public SER_Usuario_351FI(string dni_351FI, string nombre_351FI, string apellido_351FI, string correo_351FI, bool bloqueo_351FI, bool activo_351FI, SER_Rol_351FI rol_351FI, string idIdioma_351FI)
        {
            Dni_351FI = dni_351FI;
            Nombre_351FI = nombre_351FI;
            Apellido_351FI = apellido_351FI;
            Correo_351FI = correo_351FI;
            NombreUsuario_351FI = apellido_351FI.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries)[0] + dni_351FI;
            Password_351FI = dni_351FI + apellido_351FI.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];
            Bloqueo_351FI = bloqueo_351FI;
            Activo_351FI = activo_351FI;
            CantIntentos_351FI = 0;
            Rol_351FI = rol_351FI;
            IdIdioma_351FI = idIdioma_351FI;
        }
        public SER_Usuario_351FI(object[] datos_351FI)
        {
            Dni_351FI = Convert.ToString(datos_351FI[0]);
            Nombre_351FI = Convert.ToString(datos_351FI[1]);
            Apellido_351FI = Convert.ToString(datos_351FI[2]);
            Correo_351FI = Convert.ToString(datos_351FI[3]);
            NombreUsuario_351FI = Convert.ToString(datos_351FI[4]);
            Password_351FI = Convert.ToString(datos_351FI[5]);
            Bloqueo_351FI = Convert.ToBoolean(datos_351FI[6]);
            Activo_351FI = Convert.ToBoolean(datos_351FI[7]);
            CantIntentos_351FI = Convert.ToInt16(datos_351FI[8]);
            IdIdioma_351FI = Convert.ToString(datos_351FI[10]);
        }
    }
}
