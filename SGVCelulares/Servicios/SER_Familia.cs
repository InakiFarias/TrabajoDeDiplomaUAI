namespace Servicio
{
    public class SER_Familia : SER_Rol
    {
        public List<SER_Rol> Componentes { get; set; }
        public SER_Familia(int id, string nombre) : base(id, nombre)
        {
            Componentes = new List<SER_Rol>();
        }

        public SER_Familia(string nombre) : base(nombre)
        {
            Nombre = nombre;
            Componentes = new List<SER_Rol>();
        }
        public SER_Familia(object[] datos) : base(Convert.ToInt16(datos[0]), Convert.ToString(datos[1]))
        {
            Componentes = new List<SER_Rol>();
        }
    }
}
