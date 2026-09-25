namespace BE
{
    public class BE_Comprobante
    {
        public int NumeroComprobante { get; set; }
        public BE_Prestamo Prestamo { get; set; }
        public DateTime FechaEmision { get; set; }

        public BE_Comprobante() { }

        public BE_Comprobante(int numeroComprobante, BE_Prestamo prestamo, DateTime fechaEmision)
        {
            NumeroComprobante = numeroComprobante;
            Prestamo = prestamo;
            FechaEmision = fechaEmision;
        }
    }
}
