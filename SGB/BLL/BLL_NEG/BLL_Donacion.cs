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

        // Valida que el ejemplar exista y que no pertenezca a otra donación (RF-002-6)
        public BE_Ejemplar ValidarEjemplar(string codigoEjemplar)
        {
            BE_Ejemplar? ejemplar = map_ejemplar.BuscarPorCodigo(codigoEjemplar);
            if (ejemplar == null) throw new Exception("El ejemplar no existe.");
            if (ejemplar.Estado == "Baja") throw new Exception("El ejemplar fue dado de baja.");

            int? numeroDonacion = map_donacion.ObtenerDonacionDeEjemplar(codigoEjemplar);
            if (numeroDonacion != null) throw new Exception($"El ejemplar ya se encuentra asociado a la donación N° {numeroDonacion}.");

            return ejemplar;
        }

        public BE_ReciboDonacion Registrar(BE_Donacion donacion)
        {
            if (donacion.Socio == null) throw new Exception("Debe seleccionar al socio donante.");
            if (donacion.Ejemplares == null || donacion.Ejemplares.Count == 0) throw new Exception("Debe seleccionar al menos un ejemplar donado.");

            donacion.FechaDonacion = DateTime.Today;
            donacion.NumeroDonacion = map_donacion.InsertarDonacion(donacion);

            BE_ReciboDonacion recibo = new BE_ReciboDonacion(0, donacion, DateTime.Today);
            recibo.NumeroRecibo = map_donacion.InsertarRecibo(recibo);

            SER_Bitacora bitacora = new SER_Bitacora(SER_SesionManager.ObtenerSesion().Usuario, DateTime.Now, "Multas y donaciones", "Registrar donación", 3);
            bll_bitacora.RegistrarBitacora(bitacora);

            return recibo;
        }
    }
}
