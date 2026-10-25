namespace BE
{
    public class BE_ComprobantePago
    {
        public int NumeroComprobante { get; set; }
        public BE_Socio Socio { get; set; }
        public DateTime FechaEmision { get; set; }
        public List<BE_Multa> Multas { get; set; }
        public decimal Total { get; set; }

        public BE_ComprobantePago() { }

        public BE_ComprobantePago(int numeroComprobante, BE_Socio socio, DateTime fechaEmision, List<BE_Multa> multas, decimal total)
        {
            NumeroComprobante = numeroComprobante;
            Socio = socio;
            FechaEmision = fechaEmision;
            Multas = multas;
            Total = total;
        }
    }
}
