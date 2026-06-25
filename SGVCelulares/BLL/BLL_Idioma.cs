using DAL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Idioma
    {
        private static readonly List<IObservadorIdioma> observadores = new List<IObservadorIdioma>();
        private static SER_Idioma idiomaActual = new SER_Idioma("es-AR");
        private DAO_Idioma dao_idioma;
        private BLL_Bitacora bll_bitacora;
        public string IdiomaActual => idiomaActual.Codigo;
        public BLL_Idioma()
        {
            dao_idioma = new DAO_Idioma();
            bll_bitacora = new BLL_Bitacora();
        }
        public void Suscribir(IObservadorIdioma observador)
        {
            if (!observadores.Contains(observador))
                observadores.Add(observador);
        }
        public void Desuscribir(IObservadorIdioma observador)
        {
            observadores.Remove(observador);
        }
        public void CambiarIdioma(string codigo)
        {
            Dictionary<string, string> textos = dao_idioma.ObtenerTraducciones(codigo);
            idiomaActual = new SER_Idioma(codigo, textos);
            Notificar();

            SER_Usuario usuario = SER_SesionManager.ObtenerSesion().Usuario;
            if (usuario != null)
            {
                SER_Bitacora bitacora = new SER_Bitacora(usuario, DateTime.Now, "Usuarios", "Cambiar Idioma", 3);
                bll_bitacora.RegistrarBitacora(bitacora);
            }
        }
        public string Traducir(string clave)
        {
            return idiomaActual.Textos.TryGetValue(clave, out string valor) ? valor : clave;
        }
        public List<CultureInfo> ObtenerIdiomasDisponibles()
        {
            return dao_idioma.ObtenerIdiomasDisponibles();
        }
        private void Notificar()
        {
            foreach (IObservadorIdioma observador in observadores.ToArray())
                observador.ActualizarIdioma();
        }
    }
}
