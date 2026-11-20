namespace BE
{
    // Versión de un socio guardada en la tabla copia Socio_C_351FI (control de cambios)
    public class BE_SocioC_351FI : BE_Socio_351FI
    {
        public int IdVersion_351FI { get; set; }
        public DateTime Fecha_351FI { get; set; }
        public TimeSpan Hora_351FI { get; set; }
        public bool Activo_351FI { get; set; }

        public BE_SocioC_351FI() { }

        public BE_SocioC_351FI(int idVersion_351FI, int numeroSocio_351FI, string nombre_351FI, string apellido_351FI, string dni_351FI, string estado_351FI, DateTime fecha_351FI, TimeSpan hora_351FI, bool activo_351FI)
            : base(numeroSocio_351FI, nombre_351FI, apellido_351FI, dni_351FI, estado_351FI)
        {
            IdVersion_351FI = idVersion_351FI;
            Fecha_351FI = fecha_351FI;
            Hora_351FI = hora_351FI;
            Activo_351FI = activo_351FI;
        }
    }
}
