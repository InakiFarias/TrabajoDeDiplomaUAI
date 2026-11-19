namespace BE
{
    public class BE_Pago_351FI
    {
        public int NumeroPago_351FI { get; set; }
        public BE_Socio_351FI Socio_351FI { get; set; }
        public DateTime FechaPago_351FI { get; set; }
        public List<BE_Multa_351FI> Multas_351FI { get; set; }
        public string MetodoPago_351FI { get; set; }
        public decimal Total_351FI { get; set; }

        public BE_Pago_351FI() { }

        public BE_Pago_351FI(int numeroPago_351FI, BE_Socio_351FI socio_351FI, DateTime fechaPago_351FI, List<BE_Multa_351FI> multas_351FI, string metodoPago_351FI, decimal total_351FI)
        {
            NumeroPago_351FI = numeroPago_351FI;
            Socio_351FI = socio_351FI;
            FechaPago_351FI = fechaPago_351FI;
            Multas_351FI = multas_351FI;
            MetodoPago_351FI = metodoPago_351FI;
            Total_351FI = total_351FI;
        }
    }
}
