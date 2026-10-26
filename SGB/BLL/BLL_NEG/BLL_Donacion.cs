using BE;
using MAP;
using Servicio;
using BLL.BLL_SER;

namespace BLL.BLL_NEG
{
    public class BLL_Donacion
    {
        MAP_Donacion map_donacion;
        MAP_Ejemplar map_ejemplar;
        BLL_Bitacora bll_bitacora;
        public BLL_Donacion()
        {
            map_donacion = new MAP_Donacion();
            map_ejemplar = new MAP_Ejemplar();
            bll_bitacora = new BLL_Bitacora();
        }

        // Nuevo ejemplar donado de un libro del catálogo; el código se asigna al registrar la donación
        public BE_Ejemplar CrearEjemplarDonado(BE_Libro libro)
        {
            if (libro == null) throw new Exception("Seleccione el libro donado.");
            if (libro.Estado == "Baja") throw new Exception("El libro está dado de baja. Reactívelo en Gestión de libros antes de registrar la donación.");
            return new BE_Ejemplar("", libro, "Disponible");
        }

        // Registra la donación y da de alta un ejemplar disponible por cada copia donada
        public BE_ReciboDonacion Registrar(BE_Donacion donacion)
        {
            if (donacion.Socio == null) throw new Exception("Debe seleccionar al socio donante.");
            if (donacion.Ejemplares == null || donacion.Ejemplares.Count == 0) throw new Exception("Debe agregar al menos un ejemplar donado.");

            foreach (BE_Ejemplar ejemplar in donacion.Ejemplares)
            {
                ejemplar.CodigoEjemplar = map_ejemplar.ObtenerSiguienteCodigo();
                ejemplar.Estado = "Disponible";
                map_ejemplar.InsertarEjemplar(ejemplar);
            }

            donacion.FechaDonacion = DateTime.Today;
            donacion.NumeroDonacion = map_donacion.InsertarDonacion(donacion);

            BE_ReciboDonacion recibo = new BE_ReciboDonacion(0, donacion, DateTime.Today);
            recibo.NumeroRecibo = map_donacion.InsertarRecibo(recibo);

            SER_Bitacora bitacora = new SER_Bitacora(SER_SesionManager.ObtenerSesion().Usuario, DateTime.Now, "Multas y donaciones", "Registrar donación", 3);
            bll_bitacora.RegistrarBitacora(bitacora);

            return recibo;
        }

        // Donaciones registradas, de la más reciente a la más antigua
        public List<BE_Donacion> ObtenerDonaciones() => map_donacion.ObtenerDonaciones();

        public List<object> ConsultarDonacionesParaGrilla(List<BE_Donacion> donaciones)
        {
            var consulta = from d in donaciones
                           select new
                           {
                               Numero = d.NumeroDonacion,
                               Fecha = d.FechaDonacion.ToString("dd/MM/yyyy"),
                               Socio = $"{d.Socio.Apellido}, {d.Socio.Nombre}",
                               Cantidad = d.Ejemplares.Count,
                               Libros = string.Join(", ", d.Ejemplares.Select(ej => ej.Libro.Titulo).Distinct())
                           };
            return consulta.ToList<object>();
        }

        // Detalle de la donación antes de confirmarla (los ejemplares todavía no tienen código)
        public List<object> ConsultarDetalleParaGrilla(List<BE_Ejemplar> ejemplares)
        {
            var consulta = from ej in ejemplares
                           select new
                           {
                               Codigo = ej.Libro.CodigoLibro,
                               Titulo = ej.Libro.Titulo,
                               Autor = string.Join(", ", ej.Libro.Autores.Select(a => a.Nombre + " " + a.Apellido))
                           };
            return consulta.ToList<object>();
        }
    }
}
