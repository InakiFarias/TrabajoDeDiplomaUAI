namespace BE
{
    public class BE_ComprobantePago_351FI
    {
        public int NumeroComprobante_351FI { get; set; }
        public BE_Socio_351FI Socio_351FI { get; set; }
        public DateTime FechaEmision_351FI { get; set; }
        public List<BE_Multa_351FI> Multas_351FI { get; set; }
        public string MetodoPago_351FI { get; set; }
        public decimal Total_351FI { get; set; }

        public BE_ComprobantePago_351FI() { }

        public BE_ComprobantePago_351FI(int numeroComprobante_351FI, BE_Socio_351FI socio_351FI, DateTime fechaEmision_351FI, List<BE_Multa_351FI> multas_351FI, string metodoPago_351FI, decimal total_351FI)
        {
            NumeroComprobante_351FI = numeroComprobante_351FI;
            Socio_351FI = socio_351FI;
            FechaEmision_351FI = fechaEmision_351FI;
            Multas_351FI = multas_351FI;
            MetodoPago_351FI = metodoPago_351FI;
            Total_351FI = total_351FI;
        }
    }
}
