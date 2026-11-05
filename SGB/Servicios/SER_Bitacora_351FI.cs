namespace Servicio
{
    public class SER_Bitacora_351FI
    {
        public SER_Usuario_351FI Usuario_351FI { get; set; }
        public DateTime Fecha_351FI { get; set; }
        public string Evento_351FI { get; set; }
        public string Modulo_351FI { get; set; }
        public int Criticidad_351FI { get; set; }
        public SER_Bitacora_351FI(SER_Usuario_351FI usuario_351FI, DateTime fecha_351FI, string modulo_351FI, string evento_351FI, int criticidad_351FI)
        {
            Usuario_351FI = usuario_351FI;
            Fecha_351FI = fecha_351FI;
            Modulo_351FI = modulo_351FI;
            Evento_351FI = evento_351FI;
            Criticidad_351FI = criticidad_351FI;
        }
    }
}
