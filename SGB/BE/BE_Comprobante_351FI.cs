namespace BE
{
    // Comprobante genérico (préstamo, devolución, pago y donación). Lo arma la BLL de cada operación y no se persiste
    public class BE_Comprobante_351FI
    {
        public string Titulo_351FI { get; set; }
        public int Numero_351FI { get; set; }
        public DateTime FechaEmision_351FI { get; set; }
        public BE_Socio_351FI Socio_351FI { get; set; }
        public List<string> Datos_351FI { get; set; }
        public string[] Columnas_351FI { get; set; }
        public List<string[]> Filas_351FI { get; set; }
        public List<string> Pie_351FI { get; set; }

        public BE_Comprobante_351FI()
        {
            Datos_351FI = new List<string>();
            Columnas_351FI = new string[0];
            Filas_351FI = new List<string[]>();
            Pie_351FI = new List<string>();
        }

        public BE_Comprobante_351FI(string titulo_351FI, int numero_351FI, DateTime fechaEmision_351FI, BE_Socio_351FI socio_351FI) : this()
        {
            Titulo_351FI = titulo_351FI;
            Numero_351FI = numero_351FI;
            FechaEmision_351FI = fechaEmision_351FI;
            Socio_351FI = socio_351FI;
        }
    }
}
