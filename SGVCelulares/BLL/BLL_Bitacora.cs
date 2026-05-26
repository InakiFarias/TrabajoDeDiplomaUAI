using MAP;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Bitacora
    {
        MAP_Bitacora map_bitacora;
        public BLL_Bitacora()
        {
            map_bitacora = new MAP_Bitacora();
        }
        public void RegistrarBitacora(SER_Bitacora bitacora)
        {
            map_bitacora.RegistrarBitacora(bitacora);
        }
    }
}
