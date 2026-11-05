using BE;
using MAP;
using Servicio;
using BLL.BLL_SER;

namespace BLL.BLL_NEG
{
    public class BLL_Devolucion_351FI
    {
        // Política definida por la Comisión Directiva
        public const decimal MONTO_POR_DIA_ATRASO = 500m;

        MAP_Devolucion_351FI map_devolucion_351FI;
        BLL_Bitacora_351FI bll_bitacora_351FI;
        BLL_DV_351FI bll_dv_351FI;
        public BLL_Devolucion_351FI()
        {
            map_devolucion_351FI = new MAP_Devolucion_351FI();
            bll_bitacora_351FI = new BLL_Bitacora_351FI();
            bll_dv_351FI = new BLL_DV_351FI();
        }

        public int CalcularDiasAtraso_351FI(BE_Prestamo_351FI prestamo_351FI, DateTime fechaDevolucion_351FI)
        {
            int dias = (fechaDevolucion_351FI.Date - prestamo_351FI.FechaDevolucionPrevista_351FI.Date).Days;
            return dias > 0 ? dias : 0;
        }

        // Devuelve null si la devolución está en término
        public BE_Multa_351FI? CalcularMulta_351FI(BE_Prestamo_351FI prestamo_351FI, DateTime fechaDevolucion_351FI)
        {
            int diasAtraso = CalcularDiasAtraso_351FI(prestamo_351FI, fechaDevolucion_351FI);
            if (diasAtraso == 0) return null;

            BE_Multa_351FI multa = new BE_Multa_351FI();
            multa.DiasAtraso_351FI = diasAtraso;
            multa.MontoPorDia_351FI = MONTO_POR_DIA_ATRASO;
            multa.Monto_351FI = diasAtraso * MONTO_POR_DIA_ATRASO;
            multa.FechaGeneracion_351FI = fechaDevolucion_351FI.Date;
            multa.FechaPago_351FI = null;
            multa.Estado_351FI = "Pendiente de pago";
            return multa;
        }

        public BE_ComprobanteDevolucion_351FI Registrar_351FI(BE_Prestamo_351FI prestamo_351FI, bool recepcionCompleta_351FI)
        {
            if (prestamo_351FI == null) throw new Exception("Debe buscar un préstamo vigente.");
            if (!recepcionCompleta_351FI) throw new Exception("La devolución debe incluir todos los ejemplares del préstamo. Si el socio no los devuelve todos, la devolución no se registra.");

            BE_Devolucion_351FI devolucion = new BE_Devolucion_351FI(0, prestamo_351FI, DateTime.Today);
            devolucion.Multa_351FI = CalcularMulta_351FI(prestamo_351FI, devolucion.FechaDevolucion_351FI);
            devolucion.NumeroDevolucion_351FI = map_devolucion_351FI.InsertarDevolucion_351FI(devolucion);
            bll_dv_351FI.GenerarDVH_351FI("Devolucion_351FI", devolucion.NumeroDevolucion_351FI);

            if (devolucion.Multa_351FI != null)
            {
                devolucion.Multa_351FI.Devolucion_351FI = devolucion;
                devolucion.Multa_351FI.NumeroMulta_351FI = map_devolucion_351FI.InsertarMulta_351FI(devolucion.Multa_351FI);
                bll_dv_351FI.GenerarDVH_351FI("Multa_351FI", devolucion.Multa_351FI.NumeroMulta_351FI);
            }

            foreach (BE_Ejemplar_351FI ejemplar in prestamo_351FI.Ejemplares_351FI)
            {
                map_devolucion_351FI.ActualizarEstadoEjemplar_351FI(ejemplar, "Disponible");
                ejemplar.Estado_351FI = "Disponible";
                bll_dv_351FI.GenerarDVH_351FI("Ejemplar_351FI", ejemplar.CodigoEjemplar_351FI);
            }

            map_devolucion_351FI.ActualizarEstadoPrestamo_351FI(prestamo_351FI, "Finalizado");
            prestamo_351FI.Estado_351FI = "Finalizado";
            bll_dv_351FI.GenerarDVH_351FI("Prestamo_351FI", prestamo_351FI.NumeroPrestamo_351FI);

            BE_ComprobanteDevolucion_351FI comprobante = new BE_ComprobanteDevolucion_351FI(0, devolucion, DateTime.Today);
            comprobante.NumeroComprobante_351FI = map_devolucion_351FI.InsertarComprobante_351FI(comprobante);
            bll_dv_351FI.GenerarDVH_351FI("ComprobanteDevolucion_351FI", comprobante.NumeroComprobante_351FI);

            bll_dv_351FI.GenerarDVV_351FI("Devolucion_351FI");
            if (devolucion.Multa_351FI != null) bll_dv_351FI.GenerarDVV_351FI("Multa_351FI");
            bll_dv_351FI.GenerarDVV_351FI("Ejemplar_351FI");
            bll_dv_351FI.GenerarDVV_351FI("Prestamo_351FI");
            bll_dv_351FI.GenerarDVV_351FI("ComprobanteDevolucion_351FI");

            SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Préstamos", "Registrar devolución", 2);
            bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);

            return comprobante;
        }
    }
}
