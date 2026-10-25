namespace BE
{
    public class BE_Donacion
    {
        public int NumeroDonacion { get; set; }
        public BE_Socio Socio { get; set; }
        public DateTime FechaDonacion { get; set; }
        public List<BE_Ejemplar> Ejemplares { get; set; }

        public BE_Donacion() { }

        public BE_Donacion(int numeroDonacion, BE_Socio socio, DateTime fechaDonacion, List<BE_Ejemplar> ejemplares)
        {
            NumeroDonacion = numeroDonacion;
            Socio = socio;
            FechaDonacion = fechaDonacion;
            Ejemplares = ejemplares;
        }
    }
}
