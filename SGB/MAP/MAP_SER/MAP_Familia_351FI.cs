using DAL.DAL_SER;
using Microsoft.Data.SqlClient;
using Servicio;

namespace MAP.MAP_SER
{
    public class MAP_Familia_351FI : IABMC_351FI<SER_Familia_351FI>
    {
        DAO_Familia_351FI dao_familia_351FI;
        public MAP_Familia_351FI()
        {
            dao_familia_351FI = new DAO_Familia_351FI();
        }
        public void Agregar_351FI(SER_Familia_351FI familia_351FI)
        {
            dao_familia_351FI.Agregar_351FI(familia_351FI.Nombre_351FI);
        }
        public void Borrar_351FI(SER_Familia_351FI familia_351FI) => dao_familia_351FI.Borrar_351FI(familia_351FI.Id_351FI);

        public bool EstaEnUso_351FI(SER_Familia_351FI familia_351FI) => dao_familia_351FI.EstaEnUso_351FI(familia_351FI.Id_351FI);

        public List<SER_Familia_351FI> Consultar_351FI()
        {
            List<SER_Familia_351FI> listaAux = new List<SER_Familia_351FI>();
            List<SER_Familia_351FI> lista = new List<SER_Familia_351FI>();

            SqlDataReader dr = dao_familia_351FI.Consultar_351FI();

            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                listaAux.Add(new SER_Familia_351FI(datos));
            }
            dr.Close();

            foreach (SER_Familia_351FI familia in listaAux)
            {
                lista.Add(ObtenerArbol_351FI(familia.Id_351FI));
            }
            return lista;
        }

        public SER_Familia_351FI ConsultarPorId_351FI(SER_Familia_351FI familia_351FI)
        {
            throw new NotImplementedException();
        }

        public void Modificar_351FI(SER_Familia_351FI familia_351FI)
        {
            throw new NotImplementedException();
        }
        public bool ExisteFamilia_351FI(SER_Familia_351FI familia_351FI)
        {
            return dao_familia_351FI.ExisteFamilia_351FI(familia_351FI.Nombre_351FI);
        }
        public void AgregarPermisoFamilia_351FI(SER_Familia_351FI familia_351FI, SER_Componente_351FI componente_351FI)
        {
            if (componente_351FI is SER_Permiso_351FI p)
            {
                dao_familia_351FI.AgregarPermiso_351FI(familia_351FI.Id_351FI, p.Id_351FI);
            }
            else if (componente_351FI is SER_Familia_351FI f)
            {
                dao_familia_351FI.AgregarFamilia_351FI(familia_351FI.Id_351FI, f.Id_351FI);
            }
        }
        public SER_Familia_351FI ObtenerIdPorNombre_351FI(SER_Familia_351FI familia_351FI)
        {
            SER_Familia_351FI familiaAux = null;
            SqlDataReader dr = dao_familia_351FI.ObtenerIdPorNombre_351FI(familia_351FI.Nombre_351FI);
            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                familiaAux = new SER_Familia_351FI(datos);
            }
            dr.Close();
            return familiaAux;
        }

        public SER_Familia_351FI ObtenerArbol_351FI(int idFamilia_351FI)
        {
            SER_Familia_351FI familia = ConsultarFamilia_351FI(idFamilia_351FI);

            foreach (SER_Permiso_351FI permiso in ConsultarPermisos_351FI(idFamilia_351FI))
            {
                familia.Componentes_351FI.Add(permiso);
            }
            foreach (SER_Familia_351FI hija in ConsultarFamiliasHijas_351FI(idFamilia_351FI))
            {
                familia.Componentes_351FI.Add(ObtenerArbol_351FI(hija.Id_351FI));
            }
            return familia;
        }

        private SER_Familia_351FI ConsultarFamilia_351FI(int idFamilia_351FI)
        {
            SER_Familia_351FI familia = null;
            SqlDataReader dr = dao_familia_351FI.ConsultarFamilia_351FI(idFamilia_351FI);
            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                familia = new SER_Familia_351FI(datos);
            }
            dr.Close();
            return familia;
        }
        private List<SER_Permiso_351FI> ConsultarPermisos_351FI(int idFamilia_351FI)
        {
            List<SER_Permiso_351FI> lista = new List<SER_Permiso_351FI>();
            SqlDataReader dr = dao_familia_351FI.ConsultarPermisos_351FI(idFamilia_351FI);

            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                lista.Add(new SER_Permiso_351FI(datos));
            }
            dr.Close();
            return lista;
        }
        private List<SER_Familia_351FI> ConsultarFamiliasHijas_351FI(int idFamilia_351FI)
        {
            List<SER_Familia_351FI> lista = new List<SER_Familia_351FI>();
            SqlDataReader dr = dao_familia_351FI.ConsultarFamiliasHijas_351FI(idFamilia_351FI);

            while (dr.Read())
            {
                object[] datos = new object[dr.FieldCount];
                dr.GetValues(datos);
                lista.Add(new SER_Familia_351FI(datos));
            }
            dr.Close();
            return lista;
        }
    }
}
