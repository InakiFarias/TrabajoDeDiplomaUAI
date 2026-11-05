namespace BE
{
    public class BE_Autor_351FI
    {
        public int CodigoAutor_351FI { get; set; }
        public string Nombre_351FI { get; set; }
        public string Apellido_351FI { get; set; }

        public BE_Autor_351FI() { }

        public BE_Autor_351FI(int codigoAutor_351FI, string nombre_351FI, string apellido_351FI)
        {
            CodigoAutor_351FI = codigoAutor_351FI;
            Nombre_351FI = nombre_351FI;
            Apellido_351FI = apellido_351FI;
        }

        public override string ToString() => $"{Apellido_351FI}, {Nombre_351FI}";
    }
}
