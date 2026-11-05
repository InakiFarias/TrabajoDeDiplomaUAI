namespace Servicio
{
    public class SER_SesionManager_351FI
    {
        public SER_Usuario_351FI Usuario_351FI { get; set; }
        private static SER_SesionManager_351FI sesion_351FI;
        private SER_SesionManager_351FI() { }
        static public SER_SesionManager_351FI ObtenerSesion_351FI()
        {
            if (sesion_351FI == null)
            {
                sesion_351FI = new SER_SesionManager_351FI();
            }
            return sesion_351FI;
        }
        static public void CerrarSesion_351FI() => sesion_351FI = null;
    }
}
