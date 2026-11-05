using DAL.DAL_SER;
using Microsoft.Data.SqlClient;
using Servicio;

namespace MAP.MAP_SER
{
    public class MAP_Rol_351FI
    {
        DAO_Rol_351FI dao_rol_351FI;
        MAP_Familia_351FI map_familia_351FI;
        public MAP_Rol_351FI()
        {
            dao_rol_351FI = new DAO_Rol_351FI();
            map_familia_351FI = new MAP_Familia_351FI();
        }

        public List<SER_Rol_351FI> Consultar_351FI()
        {
            List<SER_Rol_351FI> listaAux = new List<SER_Rol_351FI>();
            List<SER_Rol_351FI> lista = new List<SER_Rol_351FI>();
            SqlDataReader dr = dao_rol_351FI.Consultar_351FI();

            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                listaAux.Add(new SER_Rol_351FI(datos));
            }
            dr.Close();

            foreach (SER_Rol_351FI rol in listaAux)
            {
                lista.Add(ObtenerArbol_351FI(rol.Id_351FI));
            }
            return lista;
        }
        public SER_Rol_351FI ObtenerArbol_351FI(int idRol_351FI)
        {
            SER_Rol_351FI rol = ConsultarRol_351FI(idRol_351FI);

            foreach (SER_Permiso_351FI permiso in ConsultarPermisos_351FI(idRol_351FI))
            {
                rol.Componentes_351FI.Add(permiso);
            }
            foreach (SER_Familia_351FI familia in ConsultarFamilia_351FI(idRol_351FI))
            {
                rol.Componentes_351FI.Add(map_familia_351FI.ObtenerArbol_351FI(familia.Id_351FI));
            }
            return rol;
        }

        private SER_Rol_351FI ConsultarRol_351FI(int idRol_351FI)
        {
            SER_Rol_351FI rol = null;
            SqlDataReader dr = dao_rol_351FI.ConsultarRol_351FI(idRol_351FI);
            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                rol = new SER_Rol_351FI(datos);
            }
            dr.Close();
            return rol;
        }
        private List<SER_Permiso_351FI> ConsultarPermisos_351FI(int idRol_351FI)
        {
            List<SER_Permiso_351FI> lista = new List<SER_Permiso_351FI>();
            SqlDataReader dr = dao_rol_351FI.ConsultarPermisos_351FI(idRol_351FI);

            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                lista.Add(new SER_Permiso_351FI(datos));
            }
            dr.Close();
            return lista;
        }
        private List<SER_Familia_351FI> ConsultarFamilia_351FI(int idRol_351FI)
        {
            List<SER_Familia_351FI> lista = new List<SER_Familia_351FI>();
            SqlDataReader dr = dao_rol_351FI.ConsultarFamilia_351FI(idRol_351FI);
            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                lista.Add(new SER_Familia_351FI(datos));
            }
            dr.Close();
            return lista;
        }
        public bool ExisteRol_351FI(SER_Rol_351FI rol_351FI) => dao_rol_351FI.ExisteRol_351FI(rol_351FI.Nombre_351FI);
        public void Agregar_351FI(SER_Rol_351FI rol_351FI) => dao_rol_351FI.Agregar_351FI(rol_351FI.Nombre_351FI);
        public void AgregarPermisoFamilia_351FI(SER_Rol_351FI rol_351FI, SER_Componente_351FI componente_351FI)
        {
            if (componente_351FI is SER_Permiso_351FI p)
            {
                dao_rol_351FI.AgregarPermiso_351FI(rol_351FI.Id_351FI, p.Id_351FI);
            }
            else if (componente_351FI is SER_Familia_351FI f)
            {
                dao_rol_351FI.AgregarFamilia_351FI(rol_351FI.Id_351FI, f.Id_351FI);
            }
        }
        public SER_Rol_351FI ObtenerIdPorNombre_351FI(SER_Rol_351FI rol_351FI)
        {
            SER_Rol_351FI rolAux = null;
            SqlDataReader dr = dao_rol_351FI.ObtenerIdPorNombre_351FI(rol_351FI.Nombre_351FI);
            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                rolAux = new SER_Rol_351FI(datos);
            }
            dr.Close();
            return rolAux;
        }
        public SER_Rol_351FI ObtenerRolPorId_351FI(int idRol_351FI)
        {
            SER_Rol_351FI rol = null;
            SqlDataReader dr = dao_rol_351FI.ConsultarRol_351FI(idRol_351FI);
            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                rol = new SER_Rol_351FI(datos);
            }
            dr.Close();
            return rol;
        }
        public void Borrar_351FI(SER_Rol_351FI rol_351FI) => dao_rol_351FI.Borrar_351FI(rol_351FI.Id_351FI);
        public bool EstaEnUso_351FI(SER_Rol_351FI rol_351FI) => dao_rol_351FI.EstaEnUso_351FI(rol_351FI.Id_351FI);
    }
}
