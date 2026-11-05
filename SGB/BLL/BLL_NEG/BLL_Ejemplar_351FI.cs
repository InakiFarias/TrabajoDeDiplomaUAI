using BE;
using BLL.BLL_SER;
using MAP;
using Servicio;

namespace BLL.BLL_NEG
{
    public class BLL_Ejemplar_351FI
    {
        MAP_Ejemplar_351FI map_ejemplar_351FI;
        BLL_Bitacora_351FI bll_bitacora_351FI;
        BLL_DV_351FI bll_dv_351FI;
        public BLL_Ejemplar_351FI()
        {
            map_ejemplar_351FI = new MAP_Ejemplar_351FI();
            bll_bitacora_351FI = new BLL_Bitacora_351FI();
            bll_dv_351FI = new BLL_DV_351FI();
        }

        // ------------------------------------------------ Consultas para las operaciones (sin ejemplares dados de baja)

        // Ejemplares disponibles para prestar (sin texto devuelve todos los disponibles)
        public List<BE_Ejemplar_351FI> BuscarDisponibles_351FI(string texto_351FI) =>
            map_ejemplar_351FI.BuscarPorTexto_351FI(texto_351FI?.Trim() ?? "", false).Where(ej => ej.Estado_351FI == "Disponible").ToList();

        // Ejemplar para un préstamo: debe existir, no estar dado de baja y estar disponible
        public BE_Ejemplar_351FI BuscarPorCodigo_351FI(string codigo_351FI)
        {
            BE_Ejemplar_351FI? ejemplar = map_ejemplar_351FI.BuscarPorCodigo_351FI(codigo_351FI);
            if (ejemplar == null) throw new Exception("El ejemplar no existe.");
            if (ejemplar.Estado_351FI == "Baja") throw new Exception("El ejemplar fue dado de baja.");
            if (ejemplar.Estado_351FI == "Prestado")
            {
                DateTime? fecha = new BLL_Prestamo_351FI().ObtenerFechaDevolucionPrevista_351FI(codigo_351FI);
                throw new Exception($"El ejemplar se encuentra prestado. Fecha de devolución prevista: {fecha:dd/MM/yyyy}.");
            }
            return ejemplar;
        }

        // ------------------------------------------------ Consultas para el ABM (todos los ejemplares)

        public List<BE_Ejemplar_351FI> BuscarParaGestion_351FI(string texto_351FI) => map_ejemplar_351FI.BuscarPorTexto_351FI(texto_351FI?.Trim() ?? "", true);

        // ------------------------------------------------ ABM de ejemplares

        public void Alta_351FI(BE_Ejemplar_351FI ejemplar_351FI)
        {
            if (ejemplar_351FI.Libro_351FI == null || string.IsNullOrEmpty(ejemplar_351FI.Libro_351FI.CodigoLibro_351FI)) throw new Exception("Seleccione el libro al que pertenece el ejemplar.");

            ejemplar_351FI.CodigoEjemplar_351FI = map_ejemplar_351FI.ObtenerSiguienteCodigo_351FI();
            ejemplar_351FI.Estado_351FI = "Disponible";
            map_ejemplar_351FI.InsertarEjemplar_351FI(ejemplar_351FI);
            bll_dv_351FI.GenerarDVH_351FI("Ejemplar_351FI", ejemplar_351FI.CodigoEjemplar_351FI);
            bll_dv_351FI.GenerarDVV_351FI("Ejemplar_351FI");
            RegistrarBitacora_351FI("Alta de ejemplar", 3);
        }

        public void Baja_351FI(BE_Ejemplar_351FI ejemplar_351FI)
        {
            if (ejemplar_351FI.Estado_351FI == "Baja") throw new Exception("El ejemplar ya se encuentra dado de baja.");
            if (map_ejemplar_351FI.ContarPrestamosVigentes_351FI(ejemplar_351FI) > 0)
                throw new Exception("No se puede dar de baja el ejemplar porque está asignado a un préstamo vigente.");

            map_ejemplar_351FI.ActualizarEstado_351FI(ejemplar_351FI, "Baja");
            ejemplar_351FI.Estado_351FI = "Baja";
            bll_dv_351FI.GenerarDVH_351FI("Ejemplar_351FI", ejemplar_351FI.CodigoEjemplar_351FI);
            bll_dv_351FI.GenerarDVV_351FI("Ejemplar_351FI");
            RegistrarBitacora_351FI("Baja de ejemplar", 2);
        }

        // Vuelve a dejar disponible un ejemplar dado de baja, siempre que su libro esté activo
        public void Reactivar_351FI(BE_Ejemplar_351FI ejemplar_351FI)
        {
            if (ejemplar_351FI.Estado_351FI != "Baja") throw new Exception("El ejemplar no se encuentra dado de baja.");
            bool libroActivo = new BLL_Libro_351FI().ObtenerActivos_351FI().Any(l => l.CodigoLibro_351FI == ejemplar_351FI.Libro_351FI.CodigoLibro_351FI);
            if (!libroActivo)
                throw new Exception("No se puede reactivar el ejemplar porque su libro está dado de baja. Primero reactive el libro en Gestión de libros.");

            map_ejemplar_351FI.ActualizarEstado_351FI(ejemplar_351FI, "Disponible");
            ejemplar_351FI.Estado_351FI = "Disponible";
            bll_dv_351FI.GenerarDVH_351FI("Ejemplar_351FI", ejemplar_351FI.CodigoEjemplar_351FI);
            bll_dv_351FI.GenerarDVV_351FI("Ejemplar_351FI");
            RegistrarBitacora_351FI("Reactivación de ejemplar", 3);
        }

        // ------------------------------------------------ Presentación

        public List<object> ConsultarParaGrilla_351FI(List<BE_Ejemplar_351FI> ejemplares_351FI)
        {
            var consulta = from ej in ejemplares_351FI
                           select new
                           {
                               Codigo = ej.CodigoEjemplar_351FI,
                               Titulo = ej.Libro_351FI.Titulo_351FI,
                               Autor = string.Join(", ", ej.Libro_351FI.Autores_351FI.Select(a => a.Nombre_351FI + " " + a.Apellido_351FI)),
                               Estado = ej.Estado_351FI
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
