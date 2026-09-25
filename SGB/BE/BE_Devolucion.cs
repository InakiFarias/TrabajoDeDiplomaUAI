namespace BE
{
    public class BE_Devolucion
    {
        public int NumeroDevolucion { get; set; }
        public BE_Prestamo Prestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

        public BE_Devolucion() { }

        public BE_Devolucion(int numeroDevolucion, BE_Prestamo prestamo, DateTime fechaDevolucion)
        {
            NumeroDevolucion = numeroDevolucion;
            Prestamo = prestamo;
            FechaDevolucion = fechaDevolucion;
        }
    }
}
