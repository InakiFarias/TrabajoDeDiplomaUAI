namespace BE
{
    // Tabla de un reporte (por ejemplo, los préstamos del período). La arma la BLL de cada entidad y no se persiste
    public class BE_TablaReporte_351FI
    {
        public string Titulo_351FI { get; set; }
        public string Resumen_351FI { get; set; }
        public string[] Columnas_351FI { get; set; }
        public List<string[]> Filas_351FI { get; set; }

        public BE_TablaReporte_351FI()
        {
            Columnas_351FI = new string[0];
            Filas_351FI = new List<string[]>();
        }

        public BE_TablaReporte_351FI(string titulo_351FI, string[] columnas_351FI) : this()
        {
            Titulo_351FI = titulo_351FI;
            Columnas_351FI = columnas_351FI;
        }
    }
}
