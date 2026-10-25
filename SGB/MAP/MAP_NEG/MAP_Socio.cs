using BE;
using DAL;
using Microsoft.Data.SqlClient;

namespace MAP
{
    public class MAP_Socio
    {
        DAO_Socio dao_socio;
        public MAP_Socio()
        {
            dao_socio = new DAO_Socio();
        }

        public List<BE_Socio> ObtenerSocios(bool soloActivos) => Mapear(dao_socio.ObtenerSocios(soloActivos));

        public List<BE_Socio> BuscarPorDni(string dni, bool soloActivos) => Mapear(dao_socio.BuscarPorDni(dni, soloActivos));

        public bool ExisteDni(string dni, int numeroSocioExcluido) => dao_socio.ExisteDni(dni, numeroSocioExcluido);

        public int InsertarSocio(BE_Socio socio) => dao_socio.InsertarSocio(socio.Nombre, socio.Apellido, socio.Dni, socio.Estado);

        public void ModificarSocio(BE_Socio socio) => dao_socio.ModificarSocio(socio.NumeroSocio, socio.Nombre, socio.Apellido, socio.Dni);

        public void ActualizarEstado(BE_Socio socio, string estado) => dao_socio.ActualizarEstado(socio.NumeroSocio, estado);

        public int ContarPrestamosVigentes(BE_Socio socio) => dao_socio.ContarPrestamosVigentes(socio.NumeroSocio);
        public int ContarPrestamosVencidos(BE_Socio socio) => dao_socio.ContarPrestamosVencidos(socio.NumeroSocio);
        public int ContarMultasPendientes(BE_Socio socio) => dao_socio.ContarMultasPendientes(socio.NumeroSocio);

        private List<BE_Socio> Mapear(SqlDataReader dr)
        {
            List<BE_Socio> lista = new List<BE_Socio>();
            while (dr.Read())
            {
                lista.Add(new BE_Socio(
                    Convert.ToInt32(dr["NumeroSocio"]),
                    Convert.ToString(dr["Nombre"]),
                    Convert.ToString(dr["Apellido"]),
                    Convert.ToString(dr["Dni"]),
                    Convert.ToString(dr["Estado"])));
            }
            dr.Close();
            return lista;
        }
    }
}
