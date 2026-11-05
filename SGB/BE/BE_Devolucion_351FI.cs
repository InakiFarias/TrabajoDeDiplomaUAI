namespace BE
{
    public class BE_Devolucion_351FI
    {
        public int NumeroDevolucion_351FI { get; set; }
        public BE_Prestamo_351FI Prestamo_351FI { get; set; }
        public DateTime FechaDevolucion_351FI { get; set; }
        public BE_Multa_351FI? Multa_351FI { get; set; }

        public BE_Devolucion_351FI() { }

        public BE_Devolucion_351FI(int numeroDevolucion_351FI, BE_Prestamo_351FI prestamo_351FI, DateTime fechaDevolucion_351FI)
        {
            NumeroDevolucion_351FI = numeroDevolucion_351FI;
            Prestamo_351FI = prestamo_351FI;
            FechaDevolucion_351FI = fechaDevolucion_351FI;
        }
    }
}
