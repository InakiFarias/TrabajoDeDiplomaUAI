using DAL;
using Microsoft.Data.SqlClient;
using Servicio;
using Servicios;

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
        public List<SER_Familia> ConsultarFamilias(SER_Familia familia)
        {
            List<SER_Familia> lista = new List<SER_Familia>();
            SqlDataReader dr = dao.ConsultarFamilias(familia.Id);

            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                lista.Add(new SER_Familia(datos));
            }
            dr.Close();
            return lista;
        }
        public List<SER_Permiso> ConsultarPermisos(SER_Familia familia)
        {
            List<SER_Permiso> lista = new List<SER_Permiso>();
            SqlDataReader dr = dao.ConsultarPermisos(familia.Id);

            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                lista.Add(new SER_Permiso(datos));
            }
            dr.Close();
            return lista;
        }
    }
}
