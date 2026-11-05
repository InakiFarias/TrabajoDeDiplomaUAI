using BE;
using DAL;
using Microsoft.Data.SqlClient;

namespace MAP
{
    public class MAP_Ejemplar_351FI
    {
        DAO_Ejemplar_351FI dao_ejemplar_351FI;
        public MAP_Ejemplar_351FI()
        {
            dao_ejemplar_351FI = new DAO_Ejemplar_351FI();
        }

        public List<BE_Ejemplar_351FI> BuscarPorTexto_351FI(string texto_351FI, bool incluirBajas_351FI)
        {
            List<BE_Ejemplar_351FI> lista = new List<BE_Ejemplar_351FI>();
            SqlDataReader dr = dao_ejemplar_351FI.BuscarPorTexto_351FI(texto_351FI, incluirBajas_351FI);
            while (dr.Read())
            {
                lista.Add(Mapear_351FI(dr));
            }
            dr.Close();

            foreach (BE_Ejemplar_351FI ejemplar in lista)
                ejemplar.Libro_351FI.Autores_351FI = ObtenerAutores_351FI(ejemplar.Libro_351FI.CodigoLibro_351FI);

            return lista;
        }

        public BE_Ejemplar_351FI? BuscarPorCodigo_351FI(string codigo_351FI)
        {
            BE_Ejemplar_351FI? ejemplar = null;
            SqlDataReader dr = dao_ejemplar_351FI.BuscarPorCodigo_351FI(codigo_351FI);
            if (dr.Read()) ejemplar = Mapear_351FI(dr);
            dr.Close();

            if (ejemplar != null)
                ejemplar.Libro_351FI.Autores_351FI = ObtenerAutores_351FI(ejemplar.Libro_351FI.CodigoLibro_351FI);

            return ejemplar;
        }

        public List<BE_Ejemplar_351FI> ObtenerPorPrestamo_351FI(int numeroPrestamo_351FI)
        {
            List<BE_Ejemplar_351FI> lista = new List<BE_Ejemplar_351FI>();
            SqlDataReader dr = dao_ejemplar_351FI.ObtenerPorPrestamo_351FI(numeroPrestamo_351FI);
            while (dr.Read())
            {
                lista.Add(Mapear_351FI(dr));
            }
            dr.Close();

            foreach (BE_Ejemplar_351FI ejemplar in lista)
                ejemplar.Libro_351FI.Autores_351FI = ObtenerAutores_351FI(ejemplar.Libro_351FI.CodigoLibro_351FI);

            return lista;
        }

        public string ObtenerSiguienteCodigo_351FI() => dao_ejemplar_351FI.ObtenerSiguienteCodigo_351FI();

        public void InsertarEjemplar_351FI(BE_Ejemplar_351FI ejemplar_351FI) => dao_ejemplar_351FI.InsertarEjemplar_351FI(ejemplar_351FI.CodigoEjemplar_351FI, ejemplar_351FI.Libro_351FI.CodigoLibro_351FI, ejemplar_351FI.Estado_351FI);

        public void ActualizarEstado_351FI(BE_Ejemplar_351FI ejemplar_351FI, string estado_351FI) => dao_ejemplar_351FI.ActualizarEstado_351FI(ejemplar_351FI.CodigoEjemplar_351FI, estado_351FI);

        public int ContarPrestamosVigentes_351FI(BE_Ejemplar_351FI ejemplar_351FI) => dao_ejemplar_351FI.ContarPrestamosVigentes_351FI(ejemplar_351FI.CodigoEjemplar_351FI);

        private List<BE_Autor_351FI> ObtenerAutores_351FI(string codigoLibro_351FI)
        {
            List<BE_Autor_351FI> autores = new List<BE_Autor_351FI>();
            SqlDataReader dr = dao_ejemplar_351FI.ObtenerAutores_351FI(codigoLibro_351FI);
            while (dr.Read())
            {
                autores.Add(new BE_Autor_351FI(
                    Convert.ToInt32(dr["CodigoAutor_351FI"]),
                    Convert.ToString(dr["Nombre_351FI"]),
                    Convert.ToString(dr["Apellido_351FI"])));
            }
            dr.Close();
            return autores;
        }

        private BE_Ejemplar_351FI Mapear_351FI(SqlDataReader dr_351FI)
        {
            BE_Libro_351FI libro = new BE_Libro_351FI(
                Convert.ToString(dr_351FI["CodigoLibro_351FI"]),
                Convert.ToString(dr_351FI["Titulo_351FI"]),
                new List<BE_Autor_351FI>(),
                new List<BE_Tema_351FI>());

            return new BE_Ejemplar_351FI(
                Convert.ToString(dr_351FI["CodigoEjemplar_351FI"]),
                libro,
                Convert.ToString(dr_351FI["Estado_351FI"]));
        }
    }
}