namespace BE
{
    public class BE_ReciboDonacion
    {
        public int NumeroRecibo { get; set; }
        public BE_Donacion Donacion { get; set; }
        public DateTime FechaEmision { get; set; }

        public BE_ReciboDonacion() { }

        public BE_ReciboDonacion(int numeroRecibo, BE_Donacion donacion, DateTime fechaEmision)
        {
            NumeroRecibo = numeroRecibo;
            Donacion = donacion;
            FechaEmision = fechaEmision;
        }
    }
}
