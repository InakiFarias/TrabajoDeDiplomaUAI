namespace Servicio
{
    public class SER_Rol_351FI 
    {
        public int Id_351FI { get; set; }
        public string Nombre_351FI { get; set; }
        public List<SER_Componente_351FI> Componentes_351FI { get; set; }
        public SER_Rol_351FI(int id_351FI, string nombre_351FI) 
        {
            Id_351FI = id_351FI;
            Nombre_351FI = nombre_351FI;
            Componentes_351FI = new List<SER_Componente_351FI>();
        }
        public SER_Rol_351FI(string nombre_351FI)
        {
            Nombre_351FI = nombre_351FI;
            Componentes_351FI = new List<SER_Componente_351FI>();
        }
        public SER_Rol_351FI(object[] datos_351FI)
        {
            Id_351FI = Convert.ToInt16(datos_351FI[0]);
            Nombre_351FI = Convert.ToString(datos_351FI[1]);
            Componentes_351FI = new List<SER_Componente_351FI>();
        }
        public override string ToString()
        {
            return $"{this.Nombre_351FI}";
        }
        public bool TienePermiso_351FI(string nombrePermiso_351FI)
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
