namespace BE
{
    public class BE_Donacion_351FI
    {
        public int NumeroDonacion_351FI { get; set; }
        public BE_Socio_351FI Socio_351FI { get; set; }
        public DateTime FechaDonacion_351FI { get; set; }
        public List<BE_Ejemplar_351FI> Ejemplares_351FI { get; set; }

        public BE_Donacion_351FI() { }

        public BE_Donacion_351FI(int numeroDonacion_351FI, BE_Socio_351FI socio_351FI, DateTime fechaDonacion_351FI, List<BE_Ejemplar_351FI> ejemplares_351FI)
        {
            NumeroDonacion_351FI = numeroDonacion_351FI;
            Socio_351FI = socio_351FI;
            FechaDonacion_351FI = fechaDonacion_351FI;
            Ejemplares_351FI = ejemplares_351FI;
        }
    }
}
