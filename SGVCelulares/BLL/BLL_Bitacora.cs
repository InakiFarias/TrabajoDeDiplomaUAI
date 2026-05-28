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
        public void RegistrarBitacora(SER_Bitacora bitacora) => map_bitacora.RegistrarBitacora(bitacora);
        public List<SER_Bitacora> Consultar() => map_bitacora.Consultar();
        public List<object> ConsultarParaGrilla()
        {
            var consulta = from b in Consultar()
                           select new
                           {
                               Login = b.Usuario.NombreUsuario,
                               Fecha = b.Fecha.ToShortDateString(),
                               Hora = b.Fecha.ToString("HH:mm"),
                               Modulo = b.Modulo,
                               Evento = b.Evento,
                               Criticidad = b.Criticidad
                           };
            return consulta.ToList<object>();
        }
    }
}
