using BE;
using BLL.BLL_SER;
using MAP;
using Servicio;

namespace BLL.BLL_NEG
{
    public class BLL_Ejemplar
    {
        MAP_Ejemplar map_ejemplar;
        BLL_Bitacora bll_bitacora;
        public BLL_Ejemplar()
        {
            map_ejemplar = new MAP_Ejemplar();
            bll_bitacora = new BLL_Bitacora();
        }

        // ------------------------------------------------ Consultas para las operaciones (sin ejemplares dados de baja)

        // Ejemplares disponibles para prestar (sin texto devuelve todos los disponibles)
        public List<BE_Ejemplar> BuscarDisponibles(string texto) =>
            map_ejemplar.BuscarPorTexto(texto?.Trim() ?? "", false).Where(ej => ej.Estado == "Disponible").ToList();

        // Ejemplar para un préstamo: debe existir, no estar dado de baja y estar disponible
        public BE_Ejemplar BuscarPorCodigo(string codigo)
        {
            BE_Ejemplar? ejemplar = map_ejemplar.BuscarPorCodigo(codigo);
            if (ejemplar == null) throw new Exception("El ejemplar no existe.");
            if (ejemplar.Estado == "Baja") throw new Exception("El ejemplar fue dado de baja.");
            if (ejemplar.Estado == "Prestado")
            {
                DateTime? fecha = new BLL_Prestamo().ObtenerFechaDevolucionPrevista(codigo);
                throw new Exception($"El ejemplar se encuentra prestado. Fecha de devolución prevista: {fecha:dd/MM/yyyy}.");
            }
            return ejemplar;
        }

        // ------------------------------------------------ Consultas para el ABM (todos los ejemplares)

        public List<BE_Ejemplar> BuscarParaGestion(string texto) => map_ejemplar.BuscarPorTexto(texto?.Trim() ?? "", true);

        // ------------------------------------------------ ABM de ejemplares

        public void Alta(BE_Ejemplar ejemplar)
        {
            if (ejemplar.Libro == null || string.IsNullOrEmpty(ejemplar.Libro.CodigoLibro)) throw new Exception("Seleccione el libro al que pertenece el ejemplar.");

            ejemplar.CodigoEjemplar = map_ejemplar.ObtenerSiguienteCodigo();
            ejemplar.Estado = "Disponible";
            map_ejemplar.InsertarEjemplar(ejemplar);
            RegistrarBitacora("Alta de ejemplar", 3);
        }

        public void Baja(BE_Ejemplar ejemplar)
        {
            if (ejemplar.Estado == "Baja") throw new Exception("El ejemplar ya se encuentra dado de baja.");
            if (map_ejemplar.ContarPrestamosVigentes(ejemplar) > 0)
                throw new Exception("No se puede dar de baja el ejemplar porque está asignado a un préstamo vigente.");

            map_ejemplar.ActualizarEstado(ejemplar, "Baja");
            ejemplar.Estado = "Baja";
            RegistrarBitacora("Baja de ejemplar", 2);
        }

        // Vuelve a dejar disponible un ejemplar dado de baja, siempre que su libro esté activo
        public void Reactivar(BE_Ejemplar ejemplar)
        {
            if (ejemplar.Estado != "Baja") throw new Exception("El ejemplar no se encuentra dado de baja.");
            bool libroActivo = new BLL_Libro().ObtenerActivos().Any(l => l.CodigoLibro == ejemplar.Libro.CodigoLibro);
            if (!libroActivo)
                throw new Exception("No se puede reactivar el ejemplar porque su libro está dado de baja. Primero reactive el libro en Gestión de libros.");

            map_ejemplar.ActualizarEstado(ejemplar, "Disponible");
            ejemplar.Estado = "Disponible";
            RegistrarBitacora("Reactivación de ejemplar", 3);
        }

        // ------------------------------------------------ Presentación

        public List<object> ConsultarParaGrilla(List<BE_Ejemplar> ejemplares)
        {
            var consulta = from ej in ejemplares
                           select new
                           {
                               Codigo = ej.CodigoEjemplar,
                               Titulo = ej.Libro.Titulo,
                               Autor = string.Join(", ", ej.Libro.Autores.Select(a => a.Nombre + " " + a.Apellido)),
                               Estado = ej.Estado
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
