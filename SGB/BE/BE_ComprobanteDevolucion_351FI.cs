namespace BE
{
    public class BE_ComprobanteDevolucion_351FI
    {
        public int NumeroComprobante_351FI { get; set; }
        public BE_Devolucion_351FI Devolucion_351FI { get; set; }
        public DateTime FechaEmision_351FI { get; set; }

        public BE_ComprobanteDevolucion_351FI() { }

        public BE_ComprobanteDevolucion_351FI(int numeroComprobante_351FI, BE_Devolucion_351FI devolucion_351FI, DateTime fechaEmision_351FI)
        {
            NumeroComprobante_351FI = numeroComprobante_351FI;
            Devolucion_351FI = devolucion_351FI;
            FechaEmision_351FI = fechaEmision_351FI;
        }
    }
}
