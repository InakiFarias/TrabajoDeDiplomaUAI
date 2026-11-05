namespace BE
{
    public class BE_Tema_351FI
    {
        public int CodigoTema_351FI { get; set; }
        public string Descripcion_351FI { get; set; }

        public BE_Tema_351FI() { }

        public BE_Tema_351FI(int codigoTema_351FI, string descripcion_351FI)
        {
            CodigoTema_351FI = codigoTema_351FI;
            Descripcion_351FI = descripcion_351FI;
        }

        public override string ToString() => Descripcion_351FI;
    }
}
