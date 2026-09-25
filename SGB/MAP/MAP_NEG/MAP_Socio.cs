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

        public List<BE_Socio> ObtenerSocios()
        {
            List<BE_Socio> lista = new List<BE_Socio>();
            SqlDataReader dr = dao_socio.ObtenerSocios();
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

        public List<BE_Socio> BuscarPorNumero(string numero)
        {
            List<BE_Socio> lista = new List<BE_Socio>();
            SqlDataReader dr = dao_socio.BuscarPorNumero(numero);
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

        public int ContarPrestamosVencidos(BE_Socio socio) => dao_socio.ContarPrestamosVencidos(socio.NumeroSocio);
        public int ContarMultasPendientes(BE_Socio socio) => dao_socio.ContarMultasPendientes(socio.NumeroSocio);
    }
}