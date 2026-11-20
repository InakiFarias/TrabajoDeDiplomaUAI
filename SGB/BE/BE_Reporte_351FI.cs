namespace BE
{
    // Reporte de gestión de un requerimiento funcional (préstamos y devoluciones, o multas y donaciones). No se persiste
    public class BE_Reporte_351FI
    {
        public string Titulo_351FI { get; set; }
        public DateTime FechaEmision_351FI { get; set; }
        public string Usuario_351FI { get; set; }
        public DateTime Desde_351FI { get; set; }
        public DateTime Hasta_351FI { get; set; }
        public List<BE_TablaReporte_351FI> Tablas_351FI { get; set; }

        public BE_Reporte_351FI()
        {
            Tablas_351FI = new List<BE_TablaReporte_351FI>();
        }

        public BE_Reporte_351FI(string titulo_351FI, DateTime fechaEmision_351FI, string usuario_351FI, DateTime desde_351FI, DateTime hasta_351FI) : this()
        {
            Titulo_351FI = titulo_351FI;
            FechaEmision_351FI = fechaEmision_351FI;
            Usuario_351FI = usuario_351FI;
            Desde_351FI = desde_351FI;
            Hasta_351FI = hasta_351FI;
        }
    }
}
