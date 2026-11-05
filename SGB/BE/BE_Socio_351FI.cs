namespace BE
{
    public class BE_Socio_351FI
    {
        public int NumeroSocio_351FI { get; set; }
        public string Nombre_351FI { get; set; }
        public string Apellido_351FI { get; set; }
        public string Dni_351FI { get; set; }
        public string Estado_351FI { get; set; }
        public string EstadoHabilitacion_351FI { get; set; }
        public decimal MontoAdeudado_351FI { get; set; }

        public BE_Socio_351FI() { }

        public BE_Socio_351FI(int numeroSocio_351FI, string nombre_351FI, string apellido_351FI, string dni_351FI, string estado_351FI)
        {
            NumeroSocio_351FI = numeroSocio_351FI;
            Nombre_351FI = nombre_351FI;
            Apellido_351FI = apellido_351FI;
            Dni_351FI = dni_351FI;
            Estado_351FI = estado_351FI;
        }
    }
}