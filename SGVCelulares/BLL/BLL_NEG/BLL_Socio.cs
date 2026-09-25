using BE;
using MAP;

namespace BLL.BLL_NEG
{
    public class BLL_Socio
    {
        MAP_Socio map_socio;
        public BLL_Socio()
        {
            map_socio = new MAP_Socio();
        }

        public List<BE_Socio> ObtenerSocios() => map_socio.ObtenerSocios();

        public List<BE_Socio> BuscarPorNumero(string numero)
        {
            if (string.IsNullOrWhiteSpace(numero)) return map_socio.ObtenerSocios();
            return map_socio.BuscarPorNumero(numero.Trim());
        }

        public string ValidarHabilitacion(BE_Socio socio)
        {
            if (socio.Estado == "Baja") socio.EstadoHabilitacion = "Dado de baja";
            else if (map_socio.ContarPrestamosVencidos(socio) > 0) socio.EstadoHabilitacion = "Préstamos vencidos";
            else if (map_socio.ContarMultasPendientes(socio) > 0) socio.EstadoHabilitacion = "Multas pendientes";
            else socio.EstadoHabilitacion = "Habilitado";

            return socio.EstadoHabilitacion;
        }
    }
}