using BE;
using MAP;

namespace BLL.BLL_NEG
{
    public class BLL_Ejemplar
    {
        MAP_Ejemplar map_ejemplar;
        public BLL_Ejemplar()
        {
            map_ejemplar = new MAP_Ejemplar();
        }

        public List<BE_Ejemplar> BuscarPorTexto(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return new List<BE_Ejemplar>();
            return map_ejemplar.BuscarPorTexto(texto.Trim());
        }

        public BE_Ejemplar BuscarPorCodigo(string codigo)
        {
            BE_Ejemplar? ejemplar = map_ejemplar.BuscarPorCodigo(codigo);
            if (ejemplar == null) throw new Exception("El ejemplar no existe.");
            if (ejemplar.Estado == "Prestado")
            {
                DateTime? fecha = new BLL_Prestamo().ObtenerFechaDevolucionPrevista(codigo);
                throw new Exception($"El ejemplar se encuentra prestado. Fecha de devolución prevista: {fecha:dd/MM/yyyy}.");
            }
            return ejemplar;
        }

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
    }
}