namespace BE
{
    public class BE_Multa_351FI
    {
        public int NumeroMulta_351FI { get; set; }
        public BE_Devolucion_351FI Devolucion_351FI { get; set; }
        public int DiasAtraso_351FI { get; set; }
        public decimal MontoPorDia_351FI { get; set; }
        public decimal Monto_351FI { get; set; }
        public DateTime FechaGeneracion_351FI { get; set; }
        public DateTime? FechaPago_351FI { get; set; }
        public string Estado_351FI { get; set; }

        public BE_Multa_351FI() { }

        public BE_Multa_351FI(int numeroMulta_351FI, BE_Devolucion_351FI devolucion_351FI, int diasAtraso_351FI, decimal montoPorDia_351FI, decimal monto_351FI, DateTime fechaGeneracion_351FI, DateTime? fechaPago_351FI, string estado_351FI)
        {
            NumeroMulta_351FI = numeroMulta_351FI;
            Devolucion_351FI = devolucion_351FI;
            DiasAtraso_351FI = diasAtraso_351FI;
            MontoPorDia_351FI = montoPorDia_351FI;
            Monto_351FI = monto_351FI;
            FechaGeneracion_351FI = fechaGeneracion_351FI;
            FechaPago_351FI = fechaPago_351FI;
            Estado_351FI = estado_351FI;
        }
    }
}
