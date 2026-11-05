using BE;
using DAL;
using Microsoft.Data.SqlClient;

namespace MAP
{
    public class MAP_Libro_351FI
    {
        DAO_Libro_351FI dao_libro_351FI;
        public MAP_Libro_351FI()
        {
            dao_libro_351FI = new DAO_Libro_351FI();
        }

        public List<BE_Libro_351FI> BuscarPorTexto_351FI(string texto_351FI, bool soloActivos_351FI)
        {
            List<BE_Libro_351FI> lista = new List<BE_Libro_351FI>();
            SqlDataReader dr = dao_libro_351FI.BuscarPorTexto_351FI(texto_351FI, soloActivos_351FI);
            while (dr.Read())
            {
                BE_Libro_351FI libro = new BE_Libro_351FI(
                    Convert.ToString(dr["CodigoLibro_351FI"]),
                    Convert.ToString(dr["Titulo_351FI"]),
                    new List<BE_Autor_351FI>(),
                    new List<BE_Tema_351FI>());
                libro.Estado_351FI = Convert.ToString(dr["Estado_351FI"]);
                lista.Add(libro);
            }
            dr.Close();

            foreach (BE_Libro_351FI libro in lista)
            {
                libro.Autores_351FI = MapearAutores_351FI(dao_libro_351FI.ObtenerAutoresDeLibro_351FI(libro.CodigoLibro_351FI));
                libro.Temas_351FI = MapearTemas_351FI(dao_libro_351FI.ObtenerTemasDeLibro_351FI(libro.CodigoLibro_351FI));
            }
            return lista;
        }

        public List<BE_Autor_351FI> ObtenerAutoresDeLibro_351FI(BE_Libro_351FI libro_351FI) => MapearAutores_351FI(dao_libro_351FI.ObtenerAutoresDeLibro_351FI(libro_351FI.CodigoLibro_351FI));

        public List<BE_Tema_351FI> ObtenerTemasDeLibro_351FI(BE_Libro_351FI libro_351FI) => MapearTemas_351FI(dao_libro_351FI.ObtenerTemasDeLibro_351FI(libro_351FI.CodigoLibro_351FI));

        public string ObtenerSiguienteCodigo_351FI() => dao_libro_351FI.ObtenerSiguienteCodigo_351FI();

        public void InsertarLibro_351FI(BE_Libro_351FI libro_351FI)
        {
            dao_libro_351FI.InsertarLibro_351FI(libro_351FI.CodigoLibro_351FI, libro_351FI.Titulo_351FI, libro_351FI.Estado_351FI);
            GuardarAutoresYTemas_351FI(libro_351FI);
        }

        public void ModificarLibro_351FI(BE_Libro_351FI libro_351FI)
        {
            dao_libro_351FI.ModificarLibro_351FI(libro_351FI.CodigoLibro_351FI, libro_351FI.Titulo_351FI);
            dao_libro_351FI.BorrarAutoresDeLibro_351FI(libro_351FI.CodigoLibro_351FI);
            dao_libro_351FI.BorrarTemasDeLibro_351FI(libro_351FI.CodigoLibro_351FI);
            GuardarAutoresYTemas_351FI(libro_351FI);
        }

        private void GuardarAutoresYTemas_351FI(BE_Libro_351FI libro_351FI)
        {
            foreach (BE_Autor_351FI autor in libro_351FI.Autores_351FI)
                dao_libro_351FI.InsertarAutorDeLibro_351FI(libro_351FI.CodigoLibro_351FI, autor.CodigoAutor_351FI);
            foreach (BE_Tema_351FI tema in libro_351FI.Temas_351FI)
                dao_libro_351FI.InsertarTemaDeLibro_351FI(libro_351FI.CodigoLibro_351FI, tema.CodigoTema_351FI);
        }

        public void ActualizarEstado_351FI(BE_Libro_351FI libro_351FI, string estado_351FI) => dao_libro_351FI.ActualizarEstado_351FI(libro_351FI.CodigoLibro_351FI, estado_351FI);

        public int ContarEjemplaresActivos_351FI(BE_Libro_351FI libro_351FI) => dao_libro_351FI.ContarEjemplaresActivos_351FI(libro_351FI.CodigoLibro_351FI);

        // ------------------------------------------------------------ Autores y temas

        public List<BE_Autor_351FI> ObtenerAutores_351FI() => MapearAutores_351FI(dao_libro_351FI.ObtenerAutores_351FI());

        public bool ExisteAutor_351FI(BE_Autor_351FI autor_351FI) => dao_libro_351FI.ExisteAutor_351FI(autor_351FI.Nombre_351FI, autor_351FI.Apellido_351FI);

        public int InsertarAutor_351FI(BE_Autor_351FI autor_351FI) => dao_libro_351FI.InsertarAutor_351FI(autor_351FI.Nombre_351FI, autor_351FI.Apellido_351FI);

        public List<BE_Tema_351FI> ObtenerTemas_351FI() => MapearTemas_351FI(dao_libro_351FI.ObtenerTemas_351FI());

        public bool ExisteTema_351FI(BE_Tema_351FI tema_351FI) => dao_libro_351FI.ExisteTema_351FI(tema_351FI.Descripcion_351FI);

        public int InsertarTema_351FI(BE_Tema_351FI tema_351FI) => dao_libro_351FI.InsertarTema_351FI(tema_351FI.Descripcion_351FI);

        private List<BE_Autor_351FI> MapearAutores_351FI(SqlDataReader dr_351FI)
        {
            List<BE_Autor_351FI> autores = new List<BE_Autor_351FI>();
            while (dr_351FI.Read())
            {
                autores.Add(new BE_Autor_351FI(
                    Convert.ToInt32(dr_351FI["CodigoAutor_351FI"]),
                    Convert.ToString(dr_351FI["Nombre_351FI"]),
                    Convert.ToString(dr_351FI["Apellido_351FI"])));
            }
            dr_351FI.Close();
            return autores;
        }

        private List<BE_Tema_351FI> MapearTemas_351FI(SqlDataReader dr_351FI)
        {
            List<BE_Tema_351FI> temas = new List<BE_Tema_351FI>();
            while (dr_351FI.Read())
            {
                temas.Add(new BE_Tema_351FI(
                    Convert.ToInt32(dr_351FI["CodigoTema_351FI"]),
                    Convert.ToString(dr_351FI["Descripcion_351FI"])));
            }
            dr_351FI.Close();
            return temas;
        }
    }
}
