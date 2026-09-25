namespace BE
{
    public class BE_Socio
    {
        public int NumeroSocio { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Estado { get; set; }
        public string EstadoHabilitacion { get; set; }

        public BE_Socio() { }

        public BE_Socio(int numeroSocio, string nombre, string apellido, string dni, string estado)
        {
            NumeroSocio = numeroSocio;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Estado = estado;
        }
    }
}