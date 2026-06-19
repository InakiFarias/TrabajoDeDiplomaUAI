using MAP;
using Servicio;

namespace BLL
{
    public class BLL_Familia : IABMC<SER_Familia>
    {
        MAP_Familia map;
        public BLL_Familia()
        {
            map = new MAP_Familia();
        }
        public void Agregar(SER_Familia familia)
        {
            map.Agregar(familia);
        }

        public void Borrar(SER_Familia obj)
        {
            throw new NotImplementedException();
        }

        public List<SER_Familia> Consultar()
        {
            return map.Consultar();
        }

        public SER_Familia ConsultarPorId(SER_Familia obj)
        {
            throw new NotImplementedException();
        }

        public void Modificar(SER_Familia obj)
        {
            throw new NotImplementedException();
        }

        public void AgregarPermiso(SER_Familia familia, SER_Permiso permiso)
        {
            if (familia == null) throw new Exception("Debe seleccionar una familia");
            if (permiso == null) throw new Exception("Debe seleccionar un permiso");
            if (map.ExistePermiso(familia, permiso)) throw new Exception("La familia ya posee ese permiso");
            map.AgregarPermiso(familia, permiso);
        }
        public void QuitarPermiso(SER_Familia familia, SER_Permiso permiso)
        {

        }
        public void AgregarFamilia(SER_Familia familia, SER_Permiso permiso)
        {

        }
        public void QuitarFamilia(SER_Familia familia, SER_Permiso permiso)
        {

        }
        
    }
}
