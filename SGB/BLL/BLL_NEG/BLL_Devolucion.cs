using BE;
using MAP;
using Servicio;
using BLL.BLL_SER;

namespace BLL.BLL_NEG
{
    public class BLL_Devolucion
    {
        private const decimal MONTO_POR_DIA_ATRASO = 500m; // TODO: confirmar valor

        MAP_Devolucion map_devolucion;
        BLL_Bitacora bll_bitacora;
        BLL_DV bll_dv;
        public BLL_Devolucion()
        {
            map_devolucion = new MAP_Devolucion();
            bll_bitacora = new BLL_Bitacora();
            bll_dv = new BLL_DV();
        }
    }
}
