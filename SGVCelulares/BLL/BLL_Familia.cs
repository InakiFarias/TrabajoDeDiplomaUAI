using DAL;
using MAP;
using Servicio;

namespace BLL
{
    public class BLL_Familia : IABMC<SER_Familia>
    {
        MAP_Familia map_familia;
        public BLL_Familia()
        {
            map_familia = new MAP_Familia();
        }
        public void Agregar(SER_Familia familia)
        {
            map_familia.Agregar(familia);
        }

        public void Borrar(SER_Familia obj)
        {
            throw new NotImplementedException();
        }

        public List<SER_Familia> Consultar()
        {
            return map_familia.Consultar();
        }
        public SER_Familia ConsultarPorId(SER_Familia familia)
        {
            return map_familia.ObtenerArbol(familia.Id);
        }

        public void Modificar(SER_Familia familia)
        {
            throw new NotImplementedException();
        }

        public void AgregarPermiso(SER_Familia familia, SER_Permiso permiso)
        {
            if (familia == null) throw new Exception("Debe seleccionar una familia");
            if (permiso == null) throw new Exception("Debe seleccionar un permiso");
            if (map_familia.ExistePermiso(familia, permiso)) throw new Exception("La familia ya posee ese permiso");
            map_familia.AgregarPermiso(familia, permiso);
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
