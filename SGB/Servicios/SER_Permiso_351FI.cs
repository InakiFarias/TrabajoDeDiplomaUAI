namespace Servicio
{
    public class SER_Permiso_351FI : SER_Componente_351FI
    {
        public SER_Permiso_351FI(int id_351FI, string nombre_351FI) : base(id_351FI, nombre_351FI)
        {
        }

        public SER_Permiso_351FI(object[] datos_351FI) : base(Convert.ToInt16(datos_351FI[0]), Convert.ToString(datos_351FI[1]))
        {
        }
        public override bool TienePermiso_351FI(string nombrePermiso_351FI)
        {
            return this.Nombre_351FI == nombrePermiso_351FI;
        }
    }
}
