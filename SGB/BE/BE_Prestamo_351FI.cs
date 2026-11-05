namespace BE
{
    public class BE_Prestamo_351FI
    {
        public int NumeroPrestamo_351FI { get; set; }
        public BE_Socio_351FI Socio_351FI { get; set; }
        public DateTime FechaPrestamo_351FI { get; set; }
        public DateTime FechaDevolucionPrevista_351FI { get; set; }
        public string Estado_351FI { get; set; }
        public List<BE_Ejemplar_351FI> Ejemplares_351FI { get; set; }

        public BE_Prestamo_351FI() { }

        public BE_Prestamo_351FI(int numeroPrestamo_351FI, BE_Socio_351FI socio_351FI, DateTime fechaPrestamo_351FI, DateTime fechaDevolucionPrevista_351FI, string estado_351FI, List<BE_Ejemplar_351FI> ejemplares_351FI)
        {
            NumeroPrestamo_351FI = numeroPrestamo_351FI;
            Socio_351FI = socio_351FI;
            FechaPrestamo_351FI = fechaPrestamo_351FI;
            FechaDevolucionPrevista_351FI = fechaDevolucionPrevista_351FI;
            Estado_351FI = estado_351FI;
            Ejemplares_351FI = ejemplares_351FI;
        }
    }
}
