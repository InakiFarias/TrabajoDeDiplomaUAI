using BE;
using DAL;
using Microsoft.Data.SqlClient;

namespace MAP
{
    public class MAP_Devolucion
    {
        DAO_Devolucion dao_devolucion;
        public MAP_Devolucion()
        {
            dao_devolucion = new DAO_Devolucion();
        }
    }
}
