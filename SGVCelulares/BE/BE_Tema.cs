namespace BE
{
    public class BE_Tema
    {
        public int CodigoTema { get; set; }
        public string Descripcion { get; set; }

        public BE_Tema() { }

        public BE_Tema(int codigoTema, string descripcion)
        {
            CodigoTema = codigoTema;
            Descripcion = descripcion;
        }
    }
}
