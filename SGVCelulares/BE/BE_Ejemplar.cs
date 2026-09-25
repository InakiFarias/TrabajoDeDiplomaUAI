namespace BE
{
    public class BE_Ejemplar
    {
        public string CodigoEjemplar { get; set; }
        public BE_Libro Libro { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaDevolucionPrevista { get; set; }

        public BE_Ejemplar() { }

        public BE_Ejemplar(string codigoEjemplar, BE_Libro libro, string estado)
        {
            CodigoEjemplar = codigoEjemplar;
            Libro = libro;
            Estado = estado;
        }
    }
}