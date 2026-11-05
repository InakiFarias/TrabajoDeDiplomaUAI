namespace BE
{
    public class BE_ReciboDonacion_351FI
    {
        public int NumeroRecibo_351FI { get; set; }
        public BE_Donacion_351FI Donacion_351FI { get; set; }
        public DateTime FechaEmision_351FI { get; set; }

        public BE_ReciboDonacion_351FI() { }

        public BE_ReciboDonacion_351FI(int numeroRecibo_351FI, BE_Donacion_351FI donacion_351FI, DateTime fechaEmision_351FI)
        {
            NumeroRecibo_351FI = numeroRecibo_351FI;
            Donacion_351FI = donacion_351FI;
            FechaEmision_351FI = fechaEmision_351FI;
        }
    }
}
