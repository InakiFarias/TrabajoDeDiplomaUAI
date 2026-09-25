namespace BE
{
    public class BE_Libro
    {
        public string CodigoLibro { get; set; }
        public string Titulo { get; set; }
        public List<BE_Autor> Autores { get; set; }
        public List<BE_Tema> Temas { get; set; }

        public BE_Libro() { }

        public BE_Libro(string codigoLibro, string titulo, List<BE_Autor> autores, List<BE_Tema> temas)
        {
            CodigoLibro = codigoLibro;
            Titulo = titulo;
            Autores = autores;
            Temas = temas;
        }
    }
}
