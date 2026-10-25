using System.Globalization;
using BE;
using BLL.BLL_SER;
using MAP;
using Servicio;

namespace BLL.BLL_NEG
{
    public class BLL_Libro
    {
        MAP_Libro map_libro;
        BLL_Bitacora bll_bitacora;
        public BLL_Libro()
        {
            map_libro = new MAP_Libro();
            bll_bitacora = new BLL_Bitacora();
        }

        // ------------------------------------------------ Consultas

        // Todos los libros (para el ABM), filtrados por código, título o autor
        public List<BE_Libro> BuscarPorTexto(string texto) => map_libro.BuscarPorTexto(texto?.Trim() ?? "", false);

        // Libros activos (para asignarlos a un ejemplar)
        public List<BE_Libro> ObtenerActivos() => map_libro.BuscarPorTexto("", true);

        public List<BE_Autor> ObtenerAutores() => map_libro.ObtenerAutores();

        // Filtra por nombre o apellido sin distinguir mayúsculas ni tildes ("garcia" encuentra "García")
        public List<BE_Autor> FiltrarAutores(List<BE_Autor> autores, string texto)
        {
            string filtro = texto?.Trim() ?? "";
            if (filtro == "") return autores;

            return autores.Where(a => Coincide(a.Nombre + " " + a.Apellido, filtro)
                                   || Coincide(a.Apellido + ", " + a.Nombre, filtro))
                          .ToList();
        }

        // Filtra por código, título o autor, con el mismo criterio que FiltrarAutores
        public List<BE_Libro> FiltrarLibros(List<BE_Libro> libros, string texto)
        {
            string filtro = texto?.Trim() ?? "";
            if (filtro == "") return libros;

            return libros.Where(l => Coincide(l.CodigoLibro, filtro)
                                  || Coincide(l.Titulo, filtro)
                                  || l.Autores.Any(a => Coincide(a.Nombre + " " + a.Apellido, filtro)))
                         .ToList();
        }

        private bool Coincide(string texto, string filtro)
        {
            return CultureInfo.InvariantCulture.CompareInfo.IndexOf(texto ?? "", filtro, CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace) >= 0;
        }

        public List<BE_Tema> ObtenerTemas() => map_libro.ObtenerTemas();

        // ------------------------------------------------ Autores y temas nuevos

        public BE_Autor AgregarAutor(string nombre, string apellido)
        {
            BE_Autor autor = new BE_Autor(0, nombre?.Trim() ?? "", apellido?.Trim() ?? "");
            if (autor.Nombre == "" || autor.Apellido == "") throw new Exception("Ingrese el nombre y el apellido del autor.");
            if (autor.Nombre.Length > 50 || autor.Apellido.Length > 50) throw new Exception("El nombre y el apellido del autor no pueden superar los 50 caracteres.");
            if (map_libro.ExisteAutor(autor)) throw new Exception("El autor ya se encuentra registrado.");

            autor.CodigoAutor = map_libro.InsertarAutor(autor);
            return autor;
        }

        public BE_Tema AgregarTema(string descripcion)
        {
            BE_Tema tema = new BE_Tema(0, descripcion?.Trim() ?? "");
            if (tema.Descripcion == "") throw new Exception("Ingrese la descripción del tema.");
            if (tema.Descripcion.Length > 100) throw new Exception("La descripción del tema no puede superar los 100 caracteres.");
            if (map_libro.ExisteTema(tema)) throw new Exception("El tema ya se encuentra registrado.");

            tema.CodigoTema = map_libro.InsertarTema(tema);
            return tema;
        }

        // ------------------------------------------------ ABM de libros

        public void Alta(BE_Libro libro)
        {
            Validar(libro);
            libro.CodigoLibro = map_libro.ObtenerSiguienteCodigo();
            libro.Estado = "Activo";
            map_libro.InsertarLibro(libro);
            RegistrarBitacora("Alta de libro", 3);
        }

        public void Modificar(BE_Libro libro)
        {
            if (string.IsNullOrEmpty(libro.CodigoLibro)) throw new Exception("Seleccione el libro a modificar.");
            if (libro.Estado == "Baja") throw new Exception("No se puede modificar un libro dado de baja.");
            Validar(libro);
            map_libro.ModificarLibro(libro);
            RegistrarBitacora("Modificación de libro", 3);
        }

        public void Baja(BE_Libro libro)
        {
            if (libro.Estado == "Baja") throw new Exception("El libro ya se encuentra dado de baja.");
            if (map_libro.ContarEjemplaresActivos(libro) > 0)
                throw new Exception("No se puede dar de baja el libro porque tiene ejemplares registrados. Primero deben darse de baja sus ejemplares.");

            map_libro.ActualizarEstado(libro, "Baja");
            libro.Estado = "Baja";
            RegistrarBitacora("Baja de libro", 2);
        }

        private void Validar(BE_Libro libro)
        {
            libro.Titulo = libro.Titulo?.Trim() ?? "";
            if (libro.Titulo == "") throw new Exception("Ingrese el título del libro.");
            if (libro.Titulo.Length > 150) throw new Exception("El título no puede superar los 150 caracteres.");
            if (libro.Autores == null || libro.Autores.Count == 0) throw new Exception("Seleccione al menos un autor.");
            if (libro.Temas == null) libro.Temas = new List<BE_Tema>();
        }

        // ------------------------------------------------ Presentación

        public List<object> ConsultarParaGrilla(List<BE_Libro> libros)
        {
            var consulta = from l in libros
                           select new
                           {
                               Codigo = l.CodigoLibro,
                               Titulo = l.Titulo,
                               Autores = string.Join(", ", l.Autores.Select(a => a.Nombre + " " + a.Apellido)),
                               Temas = string.Join(", ", l.Temas.Select(t => t.Descripcion)),
                               Estado = l.Estado
                           };
            return consulta.ToList<object>();
        }

        public List<object> ConsultarParaCombo(List<BE_Libro> libros)
        {
            var consulta = from l in libros
                           select new
                           {
                               Codigo = l.CodigoLibro,
                               Texto = $"{l.Titulo} ({l.CodigoLibro})"
                           };
            return consulta.ToList<object>();
        }

        private void RegistrarBitacora(string evento, int criticidad)
        {
            SER_Bitacora bitacora = new SER_Bitacora(SER_SesionManager.ObtenerSesion().Usuario, DateTime.Now, "Catálogo", evento, criticidad);
            bll_bitacora.RegistrarBitacora(bitacora);
        }
    }
}
