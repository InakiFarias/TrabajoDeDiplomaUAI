namespace BE
{
    public class BE_Comprobante_351FI
    {
        public int NumeroComprobante_351FI { get; set; }
        public BE_Prestamo_351FI Prestamo_351FI { get; set; }
        public DateTime FechaEmision_351FI { get; set; }

        public BE_Comprobante_351FI() { }

        public BE_Comprobante_351FI(int numeroComprobante_351FI, BE_Prestamo_351FI prestamo_351FI, DateTime fechaEmision_351FI)
        {
            NumeroComprobante_351FI = numeroComprobante_351FI;
            Prestamo_351FI = prestamo_351FI;
            FechaEmision_351FI = fechaEmision_351FI;
        }
    }
}
