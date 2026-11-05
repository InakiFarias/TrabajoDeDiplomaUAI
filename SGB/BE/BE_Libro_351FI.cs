namespace BE
{
    public class BE_Libro_351FI
    {
        public string CodigoLibro_351FI { get; set; }
        public string Titulo_351FI { get; set; }
        public string Estado_351FI { get; set; }
        public List<BE_Autor_351FI> Autores_351FI { get; set; }
        public List<BE_Tema_351FI> Temas_351FI { get; set; }

        public BE_Libro_351FI() { }

        public BE_Libro_351FI(string codigoLibro_351FI, string titulo_351FI, List<BE_Autor_351FI> autores_351FI, List<BE_Tema_351FI> temas_351FI)
        {
            CodigoLibro_351FI = codigoLibro_351FI;
            Titulo_351FI = titulo_351FI;
            Autores_351FI = autores_351FI;
            Temas_351FI = temas_351FI;
        }
    }
}
