using DAL;
using Microsoft.Data.SqlClient;
using Servicio;

namespace MAP
{
    public class MAP_Familia : IABMC<SER_Familia>
    {
        DAO_Familia dao;
        public MAP_Familia()
        {
            dao = new DAO_Familia();
        }
        public void Agregar(SER_Familia familia)
        {
            dao.Agregar(familia.Nombre);
        }

        public void Borrar(SER_Familia familia)
        {
            throw new NotImplementedException();
        }

        public List<SER_Familia> Consultar()
        {
            List<SER_Familia> lista = new List<SER_Familia>();
            SqlDataReader dr = dao.Consultar();

            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                lista.Add(new SER_Familia(datos));
            }
            dr.Close();
            return lista;
        }

        public SER_Familia ConsultarPorId(SER_Familia familia)
        {
            throw new NotImplementedException();
        }

        public void Modificar(SER_Familia familia)
        {
            throw new NotImplementedException();
        }
        public void AgregarPermiso(SER_Familia familia, SER_Permiso permiso)
        {
            dao.AgregarPermiso(familia.Id, permiso.Id);
        }
        public void QuitarPermiso(SER_Permiso permiso)
        {

        }
        public void AgregarFamilia(SER_Familia familia)
        {

        }
        public void QuitarFamilia(SER_Familia familia)
        {

        }
        public bool ExistePermiso(SER_Familia familia, SER_Permiso permiso)
        {
            return dao.ExistePermiso(familia.Id, permiso.Id);
        }
        public List<SER_Familia> ConsultarArbol()
        {
            Dictionary<int, SER_Familia> familias = new Dictionary<int, SER_Familia>();
            SqlDataReader dr = dao.ConsultarFamilias();
            while (dr.Read())
            {
                int id = Convert.ToInt32(dr["idFamilia"]);
                string nombre = dr["nombre"].ToString();

                familias[id] = new SER_Familia(id, nombre);
            }
            dr.Close();

            dr = dao.ConsultarRelacionesFamilia();
            while (dr.Read())
            {
                int padreId = Convert.ToInt32(dr["idFamiliaPadre"]);
                int hijoId = Convert.ToInt32(dr["idFamiliaHija"]);

                familias[padreId].Componentes.Add(familias[hijoId]);
            }
            dr.Close();

            dr = dao.ConsultarPermisosFamilia();
            while (dr.Read())
            {
                int famId = Convert.ToInt32(dr["idFamilia"]);
                int permId = Convert.ToInt32(dr["idPermiso"]);

                familias[famId].Componentes.Add(new SER_Permiso(permId, ""));
            }
            dr.Close();

            HashSet<int> hijos = new HashSet<int>();
            dr = dao.ConsultarRelacionesFamilia();
            while (dr.Read())
            {
                hijos.Add(Convert.ToInt32(dr["idFamiliaHija"]));
            }
            dr.Close();

            List<SER_Familia> arbol = new List<SER_Familia>();

            foreach (var f in familias)
            {
                if (!hijos.Contains(f.Key))
                {
                    arbol.Add(f.Value);
                }
            }

            return arbol;
        }
    }
}
