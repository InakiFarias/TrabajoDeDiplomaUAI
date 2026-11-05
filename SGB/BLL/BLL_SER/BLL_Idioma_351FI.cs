using MAP.MAP_SER;
using Servicio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL_SER
{
    public class BLL_Idioma_351FI
    {
        private static readonly List<IObservadorIdioma_351FI> observadores_351FI = new List<IObservadorIdioma_351FI>();
        private static SER_Idioma_351FI idiomaActual_351FI = new SER_Idioma_351FI("es-AR");
        MAP_Idioma_351FI map_idioma_351FI;
        BLL_Bitacora_351FI bll_bitacora_351FI;
        public string IdiomaActual_351FI => idiomaActual_351FI.Codigo_351FI;
        public BLL_Idioma_351FI()
        {
            map_idioma_351FI = new MAP_Idioma_351FI();  
            bll_bitacora_351FI = new BLL_Bitacora_351FI();
        }
        public void Suscribir_351FI(IObservadorIdioma_351FI observador_351FI)
        {
            if (!observadores_351FI.Contains(observador_351FI))
                observadores_351FI.Add(observador_351FI);
        }
        public void Desuscribir_351FI(IObservadorIdioma_351FI observador_351FI)
        {
            observadores_351FI.Remove(observador_351FI);
        }
        public void CambiarIdioma_351FI(string codigo_351FI)
        {
            Dictionary<string, string> textos = map_idioma_351FI.ObtenerTraducciones_351FI(codigo_351FI);
            idiomaActual_351FI = new SER_Idioma_351FI(codigo_351FI, textos);
            Notificar_351FI();

            SER_Usuario_351FI usuario = SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI;
            if (usuario != null)
            {
                SER_Bitacora_351FI bitacora = new SER_Bitacora_351FI(usuario, DateTime.Now, "Usuarios", "Cambiar Idioma", 3);
                bll_bitacora_351FI.RegistrarBitacora_351FI(bitacora);
            }
        }
        public string Traducir_351FI(string clave_351FI)
        {
            return idiomaActual_351FI.Textos_351FI.TryGetValue(clave_351FI, out string valor) ? valor : clave_351FI;
        }
        public List<SER_Idioma_351FI> ObtenerIdiomasDisponibles_351FI()
        {
            return map_idioma_351FI.ObtenerIdiomasDisponibles_351FI();
        }
        private void Notificar_351FI()
        {
            foreach (IObservadorIdioma_351FI observador in observadores_351FI.ToArray())
                observador.ActualizarIdioma_351FI();
        }
    }
}
