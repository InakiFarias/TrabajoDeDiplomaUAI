namespace BE
{
    public class BE_Ejemplar_351FI
    {
        public string CodigoEjemplar_351FI { get; set; }
        public BE_Libro_351FI Libro_351FI { get; set; }
        public string Estado_351FI { get; set; }
        public DateTime? FechaDevolucionPrevista_351FI { get; set; }

        public BE_Ejemplar_351FI() { }

        public BE_Ejemplar_351FI(string codigoEjemplar_351FI, BE_Libro_351FI libro_351FI, string estado_351FI)
        {
            CodigoEjemplar_351FI = codigoEjemplar_351FI;
            Libro_351FI = libro_351FI;
            Estado_351FI = estado_351FI;
        }
    }
}