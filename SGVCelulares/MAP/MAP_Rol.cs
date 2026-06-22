using DAL;
using Microsoft.Data.SqlClient;
using Servicio;

namespace MAP
{
    public class MAP_Rol
    {
        DAO_Rol dao_rol;
        public MAP_Rol()
        {
            dao_rol = new DAO_Rol();
        }

        public List<SER_Rol> Consultar()
        {
            List<SER_Rol> lista = new List<SER_Rol>();
            SqlDataReader dr = dao_rol.Consultar();

            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                lista.Add(new SER_Familia(datos));
            }
            dr.Close();
            return lista;
        }
        public bool ExisteRol(SER_Rol rol) => dao_rol.ExisteRol(rol.Nombre);
        public void AgregarPermisoFamilia(SER_Rol permiso, SER_Rol familia)
        {

        }

    }
}
