namespace BE
{
    public class BE_ComprobanteDevolucion
    {
        public int NumeroComprobante { get; set; }
        public BE_Devolucion Devolucion { get; set; }
        public DateTime FechaEmision { get; set; }

        public BE_ComprobanteDevolucion() { }

        public BE_ComprobanteDevolucion(int numeroComprobante, BE_Devolucion devolucion, DateTime fechaEmision)
        {
            NumeroComprobante = numeroComprobante;
            Devolucion = devolucion;
            FechaEmision = fechaEmision;
        }
    }
}
