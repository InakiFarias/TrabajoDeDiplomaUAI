using MAP.MAP_SER;
using Servicio;

namespace BLL.BLL_SER
{
    public class BLL_Permiso_351FI
    {
        MAP_Permiso_351FI map_permiso_351FI;
        public BLL_Permiso_351FI()
        {
            map_permiso_351FI = new MAP_Permiso_351FI();
        }

        public List<SER_Permiso_351FI> Consultar_351FI()
        {
            return map_permiso_351FI.Consultar_351FI();
        }
    }
}
