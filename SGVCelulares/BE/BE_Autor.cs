namespace BE
{
    public class BE_Autor
    {
        public int CodigoAutor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public BE_Autor() { }

        public BE_Autor(int codigoAutor, string nombre, string apellido)
        {
            CodigoAutor = codigoAutor;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
