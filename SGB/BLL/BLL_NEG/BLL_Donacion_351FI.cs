using BE;
using MAP;
using Servicio;
using BLL.BLL_SER;

namespace BLL.BLL_NEG
{
    public class BLL_Donacion_351FI
    {
        MAP_Donacion_351FI map_donacion_351FI;
        BLL_Ejemplar_351FI bll_ejemplar_351FI;
        BLL_Bitacora_351FI bll_bitacora_351FI;
        BLL_DV_351FI bll_dv_351FI;
        public BLL_Donacion_351FI()
        {
            map_donacion_351FI = new MAP_Donacion_351FI();
            bll_ejemplar_351FI = new BLL_Ejemplar_351FI();
            bll_bitacora_351FI = new BLL_Bitacora_351FI();
            bll_dv_351FI = new BLL_DV_351FI();
        }

        // Agrega al detalle un ejemplar nuevo del libro donado, uno por cada ejemplar recibido; el código se asigna al registrar la donación
        public BE_Ejemplar_351FI AgregarLibro_351FI(List<BE_Ejemplar_351FI> detalle_351FI, BE_Libro_351FI libro_351FI)
        {
            if (libro_351FI == null) throw new Exception("Seleccione el libro donado.");
            BE_Ejemplar_351FI ejemplar = new BE_Ejemplar_351FI("", libro_351FI, "Disponible");
            detalle_351FI.Add(ejemplar);
            return ejemplar;
        }

        // Da de alta un ejemplar disponible por cada libro del detalle y registra la donación
        public void Registrar_351FI(BE_Donacion_351FI donacion_351FI)
        {
            if (donacion_351FI.Socio_351FI == null) throw new Exception("Debe seleccionar al socio donante.");
            if (donacion_351FI.Ejemplares_351FI == null || donacion_351FI.Ejemplares_351FI.Count == 0) throw new Exception("Debe seleccionar al menos un libro.");

            foreach (BE_Ejemplar_351FI ejemplar in donacion_351FI.Ejemplares_351FI)
                bll_ejemplar_351FI.AltaPorDonacion_351FI(ejemplar);

            donacion_351FI.NumeroDonacion_351FI = map_donacion_351FI.InsertarDonacion_351FI(donacion_351FI);

            foreach (BE_Ejemplar_351FI ejemplar in donacion_351FI.Ejemplares_351FI)
                bll_dv_351FI.GenerarDVH_351FI("Ejemplar_351FI", ejemplar.CodigoEjemplar_351FI);
            bll_dv_351FI.GenerarDVH_351FI("Donacion_351FI", donacion_351FI.NumeroDonacion_351FI);
            foreach (BE_Ejemplar_351FI ejemplar in donacion_351FI.Ejemplares_351FI)
                bll_dv_351FI.GenerarDVH_351FI("Donacion_Ejemplar_351FI", donacion_351FI.NumeroDonacion_351FI, ejemplar.CodigoEjemplar_351FI);
            bll_dv_351FI.GenerarDVV_351FI("Ejemplar_351FI");
            bll_dv_351FI.GenerarDVV_351FI("Donacion_351FI");
            bll_dv_351FI.GenerarDVV_351FI("Donacion_Ejemplar_351FI");

            SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Multas y donaciones", "Registrar donación", 3);
            bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);
        }

        // Comprobante de la donación registrada (CU-NEG-7); no se persiste
        public BE_Comprobante_351FI ArmarComprobante_351FI(BE_Donacion_351FI donacion_351FI)
        {
            BE_Comprobante_351FI comprobante = new BE_Comprobante_351FI("Comprobante de donación", donacion_351FI.NumeroDonacion_351FI, DateTime.Today, donacion_351FI.Socio_351FI);
            comprobante.Datos_351FI.Add($"Fecha de la donación: {donacion_351FI.FechaDonacion_351FI:dd/MM/yyyy}");
            comprobante.Columnas_351FI = new[] { "Código", "Título", "Autor" };
            foreach (BE_Ejemplar_351FI ejemplar in donacion_351FI.Ejemplares_351FI)
                comprobante.Filas_351FI.Add(new[] { ejemplar.CodigoEjemplar_351FI, ejemplar.Libro_351FI.Titulo_351FI, string.Join(", ", ejemplar.Libro_351FI.Autores_351FI.Select(a => a.Nombre_351FI + " " + a.Apellido_351FI)) });
            comprobante.Pie_351FI.Add($"La biblioteca agradece la donación de {donacion_351FI.Ejemplares_351FI.Count} ejemplar(es), que se incorporan a su acervo.");
            return comprobante;
        }

        // Donaciones registradas, de la más reciente a la más antigua
        public List<BE_Donacion_351FI> ObtenerDonaciones_351FI() => map_donacion_351FI.ObtenerDonaciones_351FI();

        public List<object> ConsultarDonacionesParaGrilla_351FI(List<BE_Donacion_351FI> donaciones_351FI)
        {
            var consulta = from d in donaciones_351FI
                           select new
                           {
                               Numero = d.NumeroDonacion_351FI,
                               Fecha = d.FechaDonacion_351FI.ToString("dd/MM/yyyy"),
                               Socio = $"{d.Socio_351FI.Apellido_351FI}, {d.Socio_351FI.Nombre_351FI}",
                               Cantidad = d.Ejemplares_351FI.Count,
                               Libros = string.Join(", ", d.Ejemplares_351FI.Select(ej => ej.Libro_351FI.Titulo_351FI).Distinct())
                           };
            return consulta.ToList<object>();
        }

        // Tabla de donaciones del período para el reporte de multas y donaciones (CU-SER-21)
        public BE_TablaReporte_351FI ArmarTablaReporte_351FI(DateTime desde_351FI, DateTime hasta_351FI)
        {
            List<BE_Donacion_351FI> donaciones = map_donacion_351FI.ObtenerDonaciones_351FI()
                .Where(d => d.FechaDonacion_351FI.Date >= desde_351FI.Date && d.FechaDonacion_351FI.Date <= hasta_351FI.Date).ToList();
            BE_TablaReporte_351FI tabla = new BE_TablaReporte_351FI("Donaciones", new[] { "N° donación", "Fecha", "Socio", "DNI", "Ejemplares", "Libros" });
            foreach (BE_Donacion_351FI donacion in donaciones)
                tabla.Filas_351FI.Add(new[]
                {
                    donacion.NumeroDonacion_351FI.ToString(),
                    donacion.FechaDonacion_351FI.ToString("dd/MM/yyyy"),
                    $"{donacion.Socio_351FI.Apellido_351FI}, {donacion.Socio_351FI.Nombre_351FI}",
                    donacion.Socio_351FI.Dni_351FI,
                    donacion.Ejemplares_351FI.Count.ToString(),
                    string.Join(", ", donacion.Ejemplares_351FI.Select(ej => ej.Libro_351FI.Titulo_351FI).Distinct())
                });
            tabla.Resumen_351FI = $"Total de donaciones: {donaciones.Count}. Ejemplares recibidos: {donaciones.Sum(d => d.Ejemplares_351FI.Count)}.";
            return tabla;
        }
    }
}
