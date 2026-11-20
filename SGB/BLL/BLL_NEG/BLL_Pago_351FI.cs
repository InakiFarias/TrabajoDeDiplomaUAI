using BE;
using MAP;
using Servicio;
using BLL.BLL_SER;

namespace BLL.BLL_NEG
{
    public class BLL_Pago_351FI
    {
        public const string METODO_EFECTIVO = "Efectivo";
        public const string METODO_TARJETA = "Tarjeta";

        MAP_Pago_351FI map_pago_351FI;
        BLL_Multa_351FI bll_multa_351FI;
        BLL_EntidadBancaria_351FI bll_entidadBancaria_351FI;
        BLL_Bitacora_351FI bll_bitacora_351FI;
        BLL_DV_351FI bll_dv_351FI;
        public BLL_Pago_351FI()
        {
            map_pago_351FI = new MAP_Pago_351FI();
            bll_multa_351FI = new BLL_Multa_351FI();
            bll_entidadBancaria_351FI = new BLL_EntidadBancaria_351FI();
            bll_bitacora_351FI = new BLL_Bitacora_351FI();
            bll_dv_351FI = new BLL_DV_351FI();
        }

        // Valida el formato del número de tarjeta y solicita la autorización a la entidad bancaria (CU-NEG-8). Los datos de la tarjeta no se guardan
        public bool ProcesarPagoConTarjeta_351FI(string numeroTarjeta_351FI, decimal total_351FI)
        {
            string numero = ValidarFormato_351FI(numeroTarjeta_351FI);
            return bll_entidadBancaria_351FI.Autorizar_351FI(numero, total_351FI);
        }

        // Devuelve el número de tarjeta sin espacios ni guiones; si el formato no es válido informa el error
        private string ValidarFormato_351FI(string numeroTarjeta_351FI)
        {
            string numero = (numeroTarjeta_351FI ?? "").Replace(" ", "").Replace("-", "");
            if (numero.Length < 13 || numero.Length > 19 || !numero.All(char.IsDigit))
                throw new Exception("El número de tarjeta no es válido. Ingrese solo dígitos, entre 13 y 19. El pago no fue aprobado.");
            return numero;
        }

        // Registra el pago y deja pagadas las multas asociadas (CU-NEG-3)
        public void Registrar_351FI(BE_Pago_351FI pago_351FI)
        {
            if (pago_351FI.Socio_351FI == null) throw new Exception("Debe seleccionar un socio.");
            if (pago_351FI.Multas_351FI == null || pago_351FI.Multas_351FI.Count == 0) throw new Exception("El socio no posee multas pendientes de pago.");
            if (pago_351FI.MetodoPago_351FI != METODO_EFECTIVO && pago_351FI.MetodoPago_351FI != METODO_TARJETA) throw new Exception("Seleccione el método de pago.");

            pago_351FI.NumeroPago_351FI = map_pago_351FI.InsertarPago_351FI(pago_351FI);
            bll_multa_351FI.MarcarPagadas_351FI(pago_351FI.Multas_351FI, pago_351FI);

            bll_dv_351FI.GenerarDVH_351FI("Pago_351FI", pago_351FI.NumeroPago_351FI);
            foreach (BE_Multa_351FI multa in pago_351FI.Multas_351FI)
                bll_dv_351FI.GenerarDVH_351FI("Multa_351FI", multa.NumeroMulta_351FI);
            bll_dv_351FI.GenerarDVV_351FI("Pago_351FI");
            bll_dv_351FI.GenerarDVV_351FI("Multa_351FI");

            SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI, DateTime.Now, "Multas y donaciones", "Cobrar multas", 1);
            bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);
        }

        // Comprobante del pago registrado (CU-NEG-7); no se persiste
        public BE_Comprobante_351FI ArmarComprobante_351FI(BE_Pago_351FI pago_351FI)
        {
            BE_Comprobante_351FI comprobante = new BE_Comprobante_351FI("Comprobante de pago de multas", pago_351FI.NumeroPago_351FI, DateTime.Today, pago_351FI.Socio_351FI);
            comprobante.Datos_351FI.Add($"Fecha de pago: {pago_351FI.FechaPago_351FI:dd/MM/yyyy}");
            comprobante.Columnas_351FI = new[] { "N° multa", "Préstamo", "Fecha de generación", "Días de atraso", "Monto" };
            foreach (BE_Multa_351FI multa in pago_351FI.Multas_351FI)
                comprobante.Filas_351FI.Add(new[] { multa.NumeroMulta_351FI.ToString(), multa.Devolucion_351FI.Prestamo_351FI.NumeroPrestamo_351FI.ToString(), multa.FechaGeneracion_351FI.ToString("dd/MM/yyyy"), multa.DiasAtraso_351FI.ToString(), $"$ {multa.Monto_351FI:N2}" });
            comprobante.Pie_351FI.Add($"Total abonado: $ {pago_351FI.Total_351FI:N2}");
            comprobante.Pie_351FI.Add($"Método de pago: {pago_351FI.MetodoPago_351FI}");
            return comprobante;
        }
    }
}
