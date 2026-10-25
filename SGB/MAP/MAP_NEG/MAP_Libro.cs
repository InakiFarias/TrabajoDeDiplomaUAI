using BE;
using DAL;
using Microsoft.Data.SqlClient;

namespace MAP
{
    public class MAP_Libro
    {
        DAO_Libro dao_libro;
        public MAP_Libro()
        {
            dao_libro = new DAO_Libro();
        }

        public List<BE_Libro> BuscarPorTexto(string texto, bool soloActivos)
        {
            List<BE_Libro> lista = new List<BE_Libro>();
            SqlDataReader dr = dao_libro.BuscarPorTexto(texto, soloActivos);
            while (dr.Read())
            {
                BE_Libro libro = new BE_Libro(
                    Convert.ToString(dr["CodigoLibro"]),
                    Convert.ToString(dr["Titulo"]),
                    new List<BE_Autor>(),
                    new List<BE_Tema>());
                libro.Estado = Convert.ToString(dr["Estado"]);
                lista.Add(libro);
            }
            dr.Close();

            foreach (BE_Libro libro in lista)
            {
                libro.Autores = MapearAutores(dao_libro.ObtenerAutoresDeLibro(libro.CodigoLibro));
                libro.Temas = MapearTemas(dao_libro.ObtenerTemasDeLibro(libro.CodigoLibro));
            }
            return lista;
        }

        public string ObtenerSiguienteCodigo() => dao_libro.ObtenerSiguienteCodigo();

        public void InsertarLibro(BE_Libro libro)
        {
            dao_libro.InsertarLibro(libro.CodigoLibro, libro.Titulo, libro.Estado);
            GuardarAutoresYTemas(libro);
        }

        public void ModificarLibro(BE_Libro libro)
        {
            dao_libro.ModificarLibro(libro.CodigoLibro, libro.Titulo);
            dao_libro.BorrarAutoresDeLibro(libro.CodigoLibro);
            dao_libro.BorrarTemasDeLibro(libro.CodigoLibro);
            GuardarAutoresYTemas(libro);
        }

        private void GuardarAutoresYTemas(BE_Libro libro)
        {
            foreach (BE_Autor autor in libro.Autores)
                dao_libro.InsertarAutorDeLibro(libro.CodigoLibro, autor.CodigoAutor);
            foreach (BE_Tema tema in libro.Temas)
                dao_libro.InsertarTemaDeLibro(libro.CodigoLibro, tema.CodigoTema);
        }

        public void ActualizarEstado(BE_Libro libro, string estado) => dao_libro.ActualizarEstado(libro.CodigoLibro, estado);

        public int ContarEjemplaresActivos(BE_Libro libro) => dao_libro.ContarEjemplaresActivos(libro.CodigoLibro);

        // ------------------------------------------------------------ Autores y temas

        public List<BE_Autor> ObtenerAutores() => MapearAutores(dao_libro.ObtenerAutores());

        public bool ExisteAutor(BE_Autor autor) => dao_libro.ExisteAutor(autor.Nombre, autor.Apellido);

        public int InsertarAutor(BE_Autor autor) => dao_libro.InsertarAutor(autor.Nombre, autor.Apellido);

        public List<BE_Tema> ObtenerTemas() => MapearTemas(dao_libro.ObtenerTemas());

        public bool ExisteTema(BE_Tema tema) => dao_libro.ExisteTema(tema.Descripcion);

        public int InsertarTema(BE_Tema tema) => dao_libro.InsertarTema(tema.Descripcion);

        private List<BE_Autor> MapearAutores(SqlDataReader dr)
        {
            List<BE_Autor> autores = new List<BE_Autor>();
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

        private List<BE_Tema> MapearTemas(SqlDataReader dr)
        {
            List<BE_Tema> temas = new List<BE_Tema>();
            while (dr.Read())
            {
                temas.Add(new BE_Tema(
                    Convert.ToInt32(dr["CodigoTema"]),
                    Convert.ToString(dr["Descripcion"])));
            }
            dr.Close();
            return temas;
        }
    }
}
