using BE;
using DAL;
using Microsoft.Data.SqlClient;

namespace MAP
{
    public class MAP_SocioC_351FI
    {
        DAO_SocioC_351FI dao_socioC_351FI;
        public MAP_SocioC_351FI()
        {
            dao_socioC_351FI = new DAO_SocioC_351FI();
        }

        public List<BE_SocioC_351FI> ConsultarVersiones_351FI(int? numeroSocio_351FI, string apellido_351FI, DateTime fechaDesde_351FI, DateTime fechaHasta_351FI)
            => Mapear_351FI(dao_socioC_351FI.ConsultarVersiones_351FI(numeroSocio_351FI, apellido_351FI, fechaDesde_351FI, fechaHasta_351FI));

        public void ActivarVersion_351FI(BE_SocioC_351FI version_351FI) => dao_socioC_351FI.ActivarVersion_351FI(version_351FI.IdVersion_351FI, version_351FI.NumeroSocio_351FI);

        private List<BE_SocioC_351FI> Mapear_351FI(SqlDataReader dr_351FI)
        {
            List<BE_SocioC_351FI> lista = new List<BE_SocioC_351FI>();
            while (dr_351FI.Read())
            {
                lista.Add(new BE_SocioC_351FI(
                    Convert.ToInt32(dr_351FI["IdVersion_351FI"]),
                    Convert.ToInt32(dr_351FI["NumeroSocio_351FI"]),
                    Convert.ToString(dr_351FI["Nombre_351FI"]),
                    Convert.ToString(dr_351FI["Apellido_351FI"]),
                    Convert.ToString(dr_351FI["Dni_351FI"]),
                    Convert.ToString(dr_351FI["Estado_351FI"]),
                    Convert.ToDateTime(dr_351FI["Fecha_351FI"]),
                    (TimeSpan)dr_351FI["Hora_351FI"],
                    Convert.ToBoolean(dr_351FI["Activo_351FI"])));
            }
            dr_351FI.Close();
            return lista;
        }
    }
}
