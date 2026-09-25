using BE;
using DAL;
using Microsoft.Data.SqlClient;

namespace MAP
{
    public class MAP_Multa
    {
        DAO_Multa dao_multa;
        public MAP_Multa()
        {
            dao_multa = new DAO_Multa();
        }
    }
}
