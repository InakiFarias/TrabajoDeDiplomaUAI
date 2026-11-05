using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IABMC_351FI
    {
        void Agregar_351FI(params object[] datos_351FI);
        void Borrar_351FI(string id_351FI);
        void Modificar_351FI(string id_351FI, params object[] datos_351FI);
        SqlDataReader Consultar_351FI();
        SqlDataReader ConsultarPorId_351FI(string id_351FI);
        bool ValidarRepetido_351FI(string id_351FI);
    }
}
