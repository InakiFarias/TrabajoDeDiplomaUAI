namespace BE
{
    public class BE_Prestamo
    {
        public int NumeroPrestamo { get; set; }
        public BE_Socio Socio { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucionPrevista { get; set; }
        public string Estado { get; set; }
        public List<BE_Ejemplar> Ejemplares { get; set; }

        public BE_Prestamo() { }

        public BE_Prestamo(int numeroPrestamo, BE_Socio socio, DateTime fechaPrestamo, DateTime fechaDevolucionPrevista, string estado, List<BE_Ejemplar> ejemplares)
        {
            NumeroPrestamo = numeroPrestamo;
            Socio = socio;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucionPrevista = fechaDevolucionPrevista;
            Estado = estado;
            Ejemplares = ejemplares;
        }
    }
}
