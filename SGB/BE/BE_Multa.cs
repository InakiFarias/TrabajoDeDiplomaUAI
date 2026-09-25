namespace BE
{
    public class BE_Multa
    {
        public int NumeroMulta { get; set; }
        public BE_Devolucion Devolucion { get; set; }
        public int DiasAtraso { get; set; }
        public decimal MontoPorDia { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public DateTime? FechaPago { get; set; }
        public string Estado { get; set; }

        public BE_Multa() { }

        public BE_Multa(int numeroMulta, BE_Devolucion devolucion, int diasAtraso, decimal montoPorDia, decimal monto, DateTime fechaGeneracion, DateTime? fechaPago, string estado)
        {
            NumeroMulta = numeroMulta;
            Devolucion = devolucion;
            DiasAtraso = diasAtraso;
            MontoPorDia = montoPorDia;
            Monto = monto;
            FechaGeneracion = fechaGeneracion;
            FechaPago = fechaPago;
            Estado = estado;
        }
    }
}
