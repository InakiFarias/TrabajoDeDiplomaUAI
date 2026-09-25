using BE;
using DAL;
using Microsoft.Data.SqlClient;

namespace MAP
{
    public class MAP_Ejemplar
    {
        DAO_Ejemplar dao_ejemplar;
        public MAP_Ejemplar()
        {
            dao_ejemplar = new DAO_Ejemplar();
        }

        public List<BE_Ejemplar> BuscarPorTexto(string texto)
        {
            List<BE_Ejemplar> lista = new List<BE_Ejemplar>();
            SqlDataReader dr = dao_ejemplar.BuscarPorTexto(texto);
            while (dr.Read())
            {
                lista.Add(Mapear(dr));
            }
            dr.Close();

            foreach (BE_Ejemplar ejemplar in lista)
                ejemplar.Libro.Autores = ObtenerAutores(ejemplar.Libro.CodigoLibro);

            return lista;
        }

        public BE_Ejemplar? BuscarPorCodigo(string codigo)
        {
            BE_Ejemplar? ejemplar = null;
            SqlDataReader dr = dao_ejemplar.BuscarPorCodigo(codigo);
            if (dr.Read()) ejemplar = Mapear(dr);
            dr.Close();

            if (ejemplar != null)
                ejemplar.Libro.Autores = ObtenerAutores(ejemplar.Libro.CodigoLibro);

            return ejemplar;
        }

        private List<BE_Autor> ObtenerAutores(string codigoLibro)
        {
            List<BE_Autor> autores = new List<BE_Autor>();
            SqlDataReader dr = dao_ejemplar.ObtenerAutores(codigoLibro);
            while (dr.Read())
            {
                autores.Add(new BE_Autor(
                    Convert.ToInt32(dr["CodigoAutor"]),
                    Convert.ToString(dr["Nombre"]),
                    Convert.ToString(dr["Apellido"])));
            }
            dr.Close();
            return autores;
        }

        private BE_Ejemplar Mapear(SqlDataReader dr)
        {
            BE_Libro libro = new BE_Libro(
                Convert.ToString(dr["CodigoLibro"]),
                Convert.ToString(dr["Titulo"]),
                new List<BE_Autor>(),
                new List<BE_Tema>());

            return new BE_Ejemplar(
                Convert.ToString(dr["CodigoEjemplar"]),
                libro,
                Convert.ToString(dr["Estado"]));
        }
    }
}