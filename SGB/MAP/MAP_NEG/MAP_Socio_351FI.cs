using BE;
using DAL;
using Microsoft.Data.SqlClient;

namespace MAP
{
    public class MAP_Socio_351FI
    {
        DAO_Socio_351FI dao_socio_351FI;
        public MAP_Socio_351FI()
        {
            dao_socio_351FI = new DAO_Socio_351FI();
        }

        public List<BE_Socio_351FI> ObtenerSocios_351FI(bool soloActivos_351FI) => Mapear_351FI(dao_socio_351FI.ObtenerSocios_351FI(soloActivos_351FI));

        public List<BE_Socio_351FI> BuscarPorDni_351FI(string dni_351FI, bool soloActivos_351FI) => Mapear_351FI(dao_socio_351FI.BuscarPorDni_351FI(dni_351FI, soloActivos_351FI));

        public bool ExisteDni_351FI(string dni_351FI, int numeroSocioExcluido_351FI) => dao_socio_351FI.ExisteDni_351FI(dni_351FI, numeroSocioExcluido_351FI);

        public int InsertarSocio_351FI(BE_Socio_351FI socio_351FI) => dao_socio_351FI.InsertarSocio_351FI(socio_351FI.Nombre_351FI, socio_351FI.Apellido_351FI, socio_351FI.Dni_351FI, socio_351FI.Estado_351FI);

        public void ModificarSocio_351FI(BE_Socio_351FI socio_351FI) => dao_socio_351FI.ModificarSocio_351FI(socio_351FI.NumeroSocio_351FI, socio_351FI.Nombre_351FI, socio_351FI.Apellido_351FI, socio_351FI.Dni_351FI);

        public void ActualizarEstado_351FI(BE_Socio_351FI socio_351FI, string estado_351FI) => dao_socio_351FI.ActualizarEstado_351FI(socio_351FI.NumeroSocio_351FI, estado_351FI);

        public int ContarPrestamosVigentes_351FI(BE_Socio_351FI socio_351FI) => dao_socio_351FI.ContarPrestamosVigentes_351FI(socio_351FI.NumeroSocio_351FI);
        public int ContarPrestamosVencidos_351FI(BE_Socio_351FI socio_351FI) => dao_socio_351FI.ContarPrestamosVencidos_351FI(socio_351FI.NumeroSocio_351FI);
        public int ContarMultasPendientes_351FI(BE_Socio_351FI socio_351FI) => dao_socio_351FI.ContarMultasPendientes_351FI(socio_351FI.NumeroSocio_351FI);

        private List<BE_Socio_351FI> Mapear_351FI(SqlDataReader dr_351FI)
        {
            List<BE_Socio_351FI> lista = new List<BE_Socio_351FI>();
            while (dr_351FI.Read())
            {
                lista.Add(new BE_Socio_351FI(
                    Convert.ToInt32(dr_351FI["NumeroSocio_351FI"]),
                    Convert.ToString(dr_351FI["Nombre_351FI"]),
                    Convert.ToString(dr_351FI["Apellido_351FI"]),
                    Convert.ToString(dr_351FI["Dni_351FI"]),
                    Convert.ToString(dr_351FI["Estado_351FI"])));
            }
            dr_351FI.Close();
            return lista;
        }
    }
}
