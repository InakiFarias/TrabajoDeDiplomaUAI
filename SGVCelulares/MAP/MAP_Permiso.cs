using DAL;
using Microsoft.Data.SqlClient;
using Servicio;
using Servicios;

namespace MAP
{
    public class MAP_Permiso : IABMC<SER_Permiso>
    {
        DAO_Permiso dao;

        public MAP_Permiso()
        {
            dao = new DAO_Permiso();
        }
        public void Agregar(SER_Permiso permiso)
        {
            throw new NotImplementedException();
        }

        public void Borrar(SER_Permiso permiso)
        {
            throw new NotImplementedException();
        }

        public List<SER_Permiso> Consultar()
        {
            List<SER_Permiso> lista = new List<SER_Permiso>();
            SqlDataReader dr = dao.Consultar();

            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                lista.Add(new SER_Permiso(datos));
            }
            dr.Close();
            return lista;
        }

        public SER_Permiso ConsultarPorId(SER_Permiso permiso)
        {
            throw new NotImplementedException();
        }

        public void Modificar(SER_Permiso permiso)
        {
            throw new NotImplementedException();
        }
    }
}
