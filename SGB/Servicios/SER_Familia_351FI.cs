namespace Servicio
{
    public class SER_Familia_351FI : SER_Componente_351FI
    {
        public List<SER_Componente_351FI> Componentes_351FI { get; set; }
        public SER_Familia_351FI(int id_351FI, string nombre_351FI) : base(id_351FI, nombre_351FI)
        {
            Componentes_351FI = new List<SER_Componente_351FI>();
        }

        public SER_Familia_351FI(string nombre_351FI) : base(nombre_351FI)
        {
            Nombre_351FI = nombre_351FI;
            Componentes_351FI = new List<SER_Componente_351FI>();
        }
        public SER_Familia_351FI(object[] datos_351FI) : base(Convert.ToInt16(datos_351FI[0]), Convert.ToString(datos_351FI[1]))
        {
            Componentes_351FI = new List<SER_Componente_351FI>();
        }
        public override bool TienePermiso_351FI(string nombrePermiso_351FI)
        {
            foreach (SER_Componente_351FI hijo in Componentes_351FI)
            {
                if (hijo.TienePermiso_351FI(nombrePermiso_351FI))
                    return true;
            }
            return false;
        }
    }
}
