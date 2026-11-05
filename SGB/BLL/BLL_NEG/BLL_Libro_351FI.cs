using System.Globalization;
using BE;
using BLL.BLL_SER;
using MAP;
using Servicio;

namespace BLL.BLL_NEG
{
    public class BLL_Libro_351FI
    {
        MAP_Libro_351FI map_libro_351FI;
        BLL_Bitacora_351FI bll_bitacora_351FI;
        BLL_DV_351FI bll_dv_351FI;
        public BLL_Libro_351FI()
        {
            map_libro_351FI = new MAP_Libro_351FI();
            bll_bitacora_351FI = new BLL_Bitacora_351FI();
            bll_dv_351FI = new BLL_DV_351FI();
        }

        // ------------------------------------------------ Consultas

        // Todos los libros (para el ABM), filtrados por código, título o autor
        public List<BE_Libro_351FI> BuscarPorTexto_351FI(string texto_351FI) => map_libro_351FI.BuscarPorTexto_351FI(texto_351FI?.Trim() ?? "", false);

        // Libros activos (para asignarlos a un ejemplar)
        public List<BE_Libro_351FI> ObtenerActivos_351FI() => map_libro_351FI.BuscarPorTexto_351FI("", true);

        public List<BE_Autor_351FI> ObtenerAutores_351FI() => map_libro_351FI.ObtenerAutores_351FI();

        // Filtra por nombre o apellido sin distinguir mayúsculas ni tildes ("garcia" encuentra "García")
        public List<BE_Autor_351FI> FiltrarAutores_351FI(List<BE_Autor_351FI> autores_351FI, string texto_351FI)
        {
            string filtro = texto_351FI?.Trim() ?? "";
            if (filtro == "") return autores_351FI;

            return autores_351FI.Where(a => Coincide_351FI(a.Nombre_351FI + " " + a.Apellido_351FI, filtro)
                                   || Coincide_351FI(a.Apellido_351FI + ", " + a.Nombre_351FI, filtro))
                          .ToList();
        }

        // Filtra por código, título o autor, con el mismo criterio que FiltrarAutores
        public List<BE_Libro_351FI> FiltrarLibros_351FI(List<BE_Libro_351FI> libros_351FI, string texto_351FI)
        {
            string filtro = texto_351FI?.Trim() ?? "";
            if (filtro == "") return libros_351FI;

            return libros_351FI.Where(l => Coincide_351FI(l.CodigoLibro_351FI, filtro)
                                  || Coincide_351FI(l.Titulo_351FI, filtro)
                                  || l.Autores_351FI.Any(a => Coincide_351FI(a.Nombre_351FI + " " + a.Apellido_351FI, filtro)))
                         .ToList();
        }

        private bool Coincide_351FI(string texto_351FI, string filtro_351FI)
        {
            return CultureInfo.InvariantCulture.CompareInfo.IndexOf(texto_351FI ?? "", filtro_351FI, CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace) >= 0;
        }

        public List<BE_Tema_351FI> ObtenerTemas_351FI() => map_libro_351FI.ObtenerTemas_351FI();

        // ------------------------------------------------ Autores y temas nuevos

        public BE_Autor_351FI AgregarAutor_351FI(string nombre_351FI, string apellido_351FI)
        {
            BE_Autor_351FI autor = new BE_Autor_351FI(0, nombre_351FI?.Trim() ?? "", apellido_351FI?.Trim() ?? "");
            if (autor.Nombre_351FI == "" || autor.Apellido_351FI == "") throw new Exception("Ingrese el nombre y el apellido del autor.");
            if (autor.Nombre_351FI.Length > 50 || autor.Apellido_351FI.Length > 50) throw new Exception("El nombre y el apellido del autor no pueden superar los 50 caracteres.");
            if (map_libro_351FI.ExisteAutor_351FI(autor)) throw new Exception("El autor ya se encuentra registrado.");

            autor.CodigoAutor_351FI = map_libro_351FI.InsertarAutor_351FI(autor);
            bll_dv_351FI.GenerarDVH_351FI("Autor_351FI", autor.CodigoAutor_351FI);
            bll_dv_351FI.GenerarDVV_351FI("Autor_351FI");
            return autor;
        }

        public BE_Tema_351FI AgregarTema_351FI(string descripcion_351FI)
        {
            BE_Tema_351FI tema = new BE_Tema_351FI(0, descripcion_351FI?.Trim() ?? "");
            if (tema.Descripcion_351FI == "") throw new Exception("Ingrese la descripción del tema.");
            if (tema.Descripcion_351FI.Length > 100) throw new Exception("La descripción del tema no puede superar los 100 caracteres.");
            if (map_libro_351FI.ExisteTema_351FI(tema)) throw new Exception("El tema ya se encuentra registrado.");

            tema.CodigoTema_351FI = map_libro_351FI.InsertarTema_351FI(tema);
            bll_dv_351FI.GenerarDVH_351FI("Tema_351FI", tema.CodigoTema_351FI);
            bll_dv_351FI.GenerarDVV_351FI("Tema_351FI");
            return tema;
        }

        // ------------------------------------------------ ABM de libros

        public void Alta_351FI(BE_Libro_351FI libro_351FI)
        {
            Validar_351FI(libro_351FI);
            libro_351FI.CodigoLibro_351FI = map_libro_351FI.ObtenerSiguienteCodigo_351FI();
            libro_351FI.Estado_351FI = "Activo";
            map_libro_351FI.InsertarLibro_351FI(libro_351FI);

            bll_dv_351FI.GenerarDVH_351FI("Libro_351FI", libro_351FI.CodigoLibro_351FI);
            foreach (BE_Autor_351FI autor in libro_351FI.Autores_351FI)
                bll_dv_351FI.GenerarDVH_351FI("Libro_Autor_351FI", libro_351FI.CodigoLibro_351FI, autor.CodigoAutor_351FI);
            foreach (BE_Tema_351FI tema in libro_351FI.Temas_351FI)
                bll_dv_351FI.GenerarDVH_351FI("Libro_Tema_351FI", libro_351FI.CodigoLibro_351FI, tema.CodigoTema_351FI);
            bll_dv_351FI.GenerarDVV_351FI("Libro_351FI");
            bll_dv_351FI.GenerarDVV_351FI("Libro_Autor_351FI");
            bll_dv_351FI.GenerarDVV_351FI("Libro_Tema_351FI");

            RegistrarBitacora_351FI("Alta de libro", 3);
        }

        public void Modificar_351FI(BE_Libro_351FI libro_351FI)
        {
            if (string.IsNullOrEmpty(libro_351FI.CodigoLibro_351FI)) throw new Exception("Seleccione el libro a modificar.");
            if (libro_351FI.Estado_351FI == "Baja") throw new Exception("No se puede modificar un libro dado de baja.");
            Validar_351FI(libro_351FI);

            // Autores y temas que tenía antes de modificarlo, para borrar los DVH de los que se quitaron
            List<BE_Autor_351FI> autoresAnteriores = map_libro_351FI.ObtenerAutoresDeLibro_351FI(libro_351FI);
            List<BE_Tema_351FI> temasAnteriores = map_libro_351FI.ObtenerTemasDeLibro_351FI(libro_351FI);

            map_libro_351FI.ModificarLibro_351FI(libro_351FI);

            bll_dv_351FI.GenerarDVH_351FI("Libro_351FI", libro_351FI.CodigoLibro_351FI);
            foreach (BE_Autor_351FI autor in autoresAnteriores)
                bll_dv_351FI.BorrarDVH_351FI("Libro_Autor_351FI", libro_351FI.CodigoLibro_351FI, autor.CodigoAutor_351FI);
            foreach (BE_Autor_351FI autor in libro_351FI.Autores_351FI)
                bll_dv_351FI.GenerarDVH_351FI("Libro_Autor_351FI", libro_351FI.CodigoLibro_351FI, autor.CodigoAutor_351FI);
            foreach (BE_Tema_351FI tema in temasAnteriores)
                bll_dv_351FI.BorrarDVH_351FI("Libro_Tema_351FI", libro_351FI.CodigoLibro_351FI, tema.CodigoTema_351FI);
            foreach (BE_Tema_351FI tema in libro_351FI.Temas_351FI)
                bll_dv_351FI.GenerarDVH_351FI("Libro_Tema_351FI", libro_351FI.CodigoLibro_351FI, tema.CodigoTema_351FI);
            bll_dv_351FI.GenerarDVV_351FI("Libro_351FI");
            bll_dv_351FI.GenerarDVV_351FI("Libro_Autor_351FI");
            bll_dv_351FI.GenerarDVV_351FI("Libro_Tema_351FI");

            RegistrarBitacora_351FI("Modificación de libro", 3);
        }

        public void Baja_351FI(BE_Libro_351FI libro_351FI)
        {
            if (libro_351FI.Estado_351FI == "Baja") throw new Exception("El libro ya se encuentra dado de baja.");
            if (map_libro_351FI.ContarEjemplaresActivos_351FI(libro_351FI) > 0)
                throw new Exception("No se puede dar de baja el libro porque tiene ejemplares registrados. Primero deben darse de baja sus ejemplares.");

            map_libro_351FI.ActualizarEstado_351FI(libro_351FI, "Baja");
            libro_351FI.Estado_351FI = "Baja";
            bll_dv_351FI.GenerarDVH_351FI("Libro_351FI", libro_351FI.CodigoLibro_351FI);
            bll_dv_351FI.GenerarDVV_351FI("Libro_351FI");
            RegistrarBitacora_351FI("Baja de libro", 2);
        }

        // Vuelve a dar de alta un libro dado de baja (sus ejemplares se reactivan aparte)
        public void Reactivar_351FI(BE_Libro_351FI libro_351FI)
        {
            if (libro_351FI.Estado_351FI != "Baja") throw new Exception("El libro ya se encuentra activo.");

            map_libro_351FI.ActualizarEstado_351FI(libro_351FI, "Activo");
            libro_351FI.Estado_351FI = "Activo";
            bll_dv_351FI.GenerarDVH_351FI("Libro_351FI", libro_351FI.CodigoLibro_351FI);
            bll_dv_351FI.GenerarDVV_351FI("Libro_351FI");
            RegistrarBitacora_351FI("Reactivación de libro", 3);
        }

        private void Validar_351FI(BE_Libro_351FI libro_351FI)
        {
            libro_351FI.Titulo_351FI = libro_351FI.Titulo_351FI?.Trim() ?? "";
            if (libro_351FI.Titulo_351FI == "") throw new Exception("Ingrese el título del libro.");
            if (libro_351FI.Titulo_351FI.Length > 150) throw new Exception("El título no puede superar los 150 caracteres.");
            if (libro_351FI.Autores_351FI == null || libro_351FI.Autores_351FI.Count == 0) throw new Exception("Seleccione al menos un autor.");
            if (libro_351FI.Temas_351FI == null) libro_351FI.Temas_351FI = new List<BE_Tema_351FI>();
        }

        // ------------------------------------------------ Presentación

        public List<object> ConsultarParaGrilla_351FI(List<BE_Libro_351FI> libros_351FI)
        {
            var consulta = from l in libros_351FI
                           select new
                           {
                               Codigo = l.CodigoLibro_351FI,
                               Titulo = l.Titulo_351FI,
                               Autores = string.Join(", ", l.Autores_351FI.Select(a => a.Nombre_351FI + " " + a.Apellido_351FI)),
                               Temas = string.Join(", ", l.Temas_351FI.Select(t => t.Descripcion_351FI)),
                               Estado = l.Estado_351FI
                           };
            return consulta.ToList<object>();
        }

        public List<object> ConsultarParaCombo_351FI(List<BE_Libro_351FI> libros_351FI)
        {
            var consulta = from l in libros_351FI
                           select new
                           {
                               Codigo = l.CodigoLibro_351FI,
                               Texto = $"{l.Titulo_351FI} ({l.CodigoLibro_351FI})"
                           };
            return consulta.ToList<object>();
        }

        private void RegistrarBitacora_351FI(string evento_351FI, int criticidad_351FI)
        {
            SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Catálogo", evento_351FI, criticidad_351FI);
            bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);
        }
    }
}
