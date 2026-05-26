using DAL;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP
{
    public class MAP_Bitacora
    {
        DAO_Bitacora dao_bitacora;
        public MAP_Bitacora()
        {
            dao_bitacora = new DAO_Bitacora();
        }
        public void RegistrarBitacora(SER_Bitacora bitacora)
        {
            dao_bitacora.Agregar(bitacora.Usuario.Dni, bitacora.Fecha, bitacora.Modulo, bitacora.Evento, bitacora.Criticidad);
        }
    }
}
