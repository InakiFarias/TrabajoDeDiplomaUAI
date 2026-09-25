using BE;
using MAP;
using Servicio;
using BLL.BLL_SER;

namespace BLL.BLL_NEG
{
    public class BLL_Multa
    {
        MAP_Multa map_multa;
        BLL_Bitacora bll_bitacora;
        BLL_DV bll_dv;
        public BLL_Multa()
        {
            map_multa = new MAP_Multa();
            bll_bitacora = new BLL_Bitacora();
            bll_dv = new BLL_DV();
        }
    }
}
