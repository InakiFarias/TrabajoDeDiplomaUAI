using DAL;
using Microsoft.Data.SqlClient;
using Servicio;
using Servicios;

namespace MAP
{
    public class MAP_Rol : IABMC<SER_Rol>
    {
        DAO_Rol dao;
        public MAP_Rol()
        {
            dao = new DAO_Rol();
        }
        public void Agregar(SER_Rol rol)
        {
            dao.Agregar(rol.Nombre);
        }

        public void Borrar(SER_Rol rol)
        {
            throw new NotImplementedException();
        }

        public List<SER_Rol> Consultar()
        {
            List<SER_Rol> lista = new List<SER_Rol>();
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

        public SER_Rol ConsultarPorId(SER_Rol rol)
        {
            throw new NotImplementedException();
        }

        public void Modificar(SER_Rol rol)
        {
            throw new NotImplementedException();
        }
    }
}
