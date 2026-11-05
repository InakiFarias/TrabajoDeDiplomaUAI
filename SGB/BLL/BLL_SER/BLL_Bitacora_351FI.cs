using MAP.MAP_SER;
using Servicio;

namespace BLL.BLL_SER
{
    public class BLL_Bitacora_351FI
    {
        MAP_Bitacora_351FI map_bitacora_351FI;
        public BLL_Bitacora_351FI()
        {
            map_bitacora_351FI = new MAP_Bitacora_351FI();
        }
        public void RegistrarBitacora_351FI(SER_Bitacora_351FI bitacora_351FI) => map_bitacora_351FI.RegistrarBitacora_351FI(bitacora_351FI);
        public List<SER_Bitacora_351FI> Consultar_351FI() => map_bitacora_351FI.Consultar_351FI();
        public List<object> ConsultarParaGrilla_351FI()
        {
            var consulta = from b in Consultar_351FI()
                           select new
                           {
                               Usuario = b.Usuario_351FI.NombreUsuario_351FI,
                               Fecha = b.Fecha_351FI.ToShortDateString(),
                               Hora = b.Fecha_351FI.ToString("HH:mm"),
                               Modulo = b.Modulo_351FI,
                               Evento = b.Evento_351FI,
                               Criticidad = b.Criticidad_351FI
                           };
            return consulta.ToList<object>();
        }
        public List<object> ConsultarParaGrilla3Dias_351FI()
        {
            var consulta = from b in Consultar_351FI() where b.Fecha_351FI >= (DateTime.Now.AddDays(-3))
                           select new
                           {
                               Usuario = b.Usuario_351FI.NombreUsuario_351FI,
                               Fecha = b.Fecha_351FI.ToShortDateString(),
                               Hora = b.Fecha_351FI.ToString("HH:mm"),
                               Modulo = b.Modulo_351FI,
                               Evento = b.Evento_351FI,
                               Criticidad = b.Criticidad_351FI
                           };
            return consulta.ToList<object>();
        }
        public SER_Usuario_351FI ConsultarPorNombreUsuario_351FI(string nombreUsuario_351FI) 
        {
            var cta = (from b in Consultar_351FI()
                      where b.Usuario_351FI.NombreUsuario_351FI == nombreUsuario_351FI
                      select new
                      {
                          Nombre = b.Usuario_351FI.Nombre_351FI,
                          Apellido = b.Usuario_351FI.Apellido_351FI
                      }).ToList();
            SER_Usuario_351FI us = new SER_Usuario_351FI();
            us.Nombre_351FI = cta[0].Nombre;
            us.Apellido_351FI = cta[0].Apellido;
            return us;
        }
        public List<object> ConsultarFiltradoBitacora_351FI(string login_351FI,string modulo_351FI,string evento_351FI,int? criticidad_351FI,DateTime? fechaInicio_351FI,DateTime? fechaFin_351FI)
        {
            var consulta = from bit in map_bitacora_351FI.Consultar_351FI()
                           where
                           (string.IsNullOrWhiteSpace(login_351FI)
                           || bit.Usuario_351FI.NombreUsuario_351FI.Contains(login_351FI))
                           &&
                           (string.IsNullOrWhiteSpace(modulo_351FI)
                           || bit.Modulo_351FI.Contains(modulo_351FI))
                           &&
                           (string.IsNullOrWhiteSpace(evento_351FI)
                           || bit.Evento_351FI.Contains(evento_351FI))
                           &&
                           (!criticidad_351FI.HasValue
                            || bit.Criticidad_351FI == criticidad_351FI.Value)
                           &&
                           (!fechaInicio_351FI.HasValue
                           || bit.Fecha_351FI >= fechaInicio_351FI.Value)
                           &&
                           (!fechaFin_351FI.HasValue
                           || bit.Fecha_351FI <= fechaFin_351FI.Value)
                            select new
                           {
                                Usuario = bit.Usuario_351FI.NombreUsuario_351FI,
                                Fecha = bit.Fecha_351FI.ToShortDateString(),
                                Hora = bit.Fecha_351FI.ToString("HH:mm"),
                                Modulo = bit.Modulo_351FI,
                                Evento = bit.Evento_351FI,
                                Criticidad = bit.Criticidad_351FI
                           };

            return consulta.ToList<object>();
        }
    }
}
