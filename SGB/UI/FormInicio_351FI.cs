using System.Globalization;
using BLL.BLL_NEG;
using BLL.BLL_SER;
using Servicio;

namespace UI
{
    // Pantalla que se muestra al iniciar sesión: saludo y cifras del día
    public partial class FormInicio_351FI : Form, IObservadorIdioma_351FI
    {
        BLL_Idioma_351FI bll_idioma_351FI = new BLL_Idioma_351FI();
        bool errorResumen_351FI;

        public FormInicio_351FI()
        {
            InitializeComponent();
            bll_idioma_351FI.Suscribir_351FI(this);
        }

        private void FormInicio_351FI_Load(object sender_351FI, EventArgs e_351FI)
        {
            ActualizarIdioma_351FI();

            try
            {
                BLL_Resumen_351FI bll_resumen = new BLL_Resumen_351FI();
                lblVigentesValor_351FI.Text = bll_resumen.ContarPrestamosVigentes_351FI().ToString();
                lblVencidosValor_351FI.Text = bll_resumen.ContarPrestamosVencidos_351FI().ToString();
                lblMultasValor_351FI.Text = bll_resumen.ContarMultasPendientes_351FI().ToString();
                lblMontoValor_351FI.Text = $"$ {bll_resumen.TotalAdeudado_351FI():N2}";
            }
            catch (Exception ex)
            {
                errorResumen_351FI = true;
                lblAyuda_351FI.Text = $"No se pudo obtener el resumen: {ex.Message}";
            }
        }

        private void MostrarSaludo_351FI()
        {
            SER_Usuario_351FI usuario = SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI;
            if (usuario == null) return;
            string nombre = string.IsNullOrWhiteSpace(usuario.Nombre_351FI) ? usuario.NombreUsuario_351FI : usuario.Nombre_351FI;
            lblSaludo_351FI.Text = $"{Saludo_351FI()}, {nombre}";

            // La fecha se escribe con el formato largo del idioma elegido
            CultureInfo cultura = new CultureInfo(bll_idioma_351FI.IdiomaActual_351FI);
            string fecha = DateTime.Today.ToString("D", cultura);
            lblFecha_351FI.Text = cultura.TextInfo.ToUpper(fecha[0]) + fecha.Substring(1);
        }

        private string Saludo_351FI()
        {
            int hora = DateTime.Now.Hour;
            if (hora < 12) return bll_idioma_351FI.Traducir_351FI("FormInicio_351FI.buenosDias");
            if (hora < 20) return bll_idioma_351FI.Traducir_351FI("FormInicio_351FI.buenasTardes");
            return bll_idioma_351FI.Traducir_351FI("FormInicio_351FI.buenasNoches");
        }

        // ------------------------------------------------------------ Idioma
        public void ActualizarIdioma_351FI()
        {
            this.Text = bll_idioma_351FI.Traducir_351FI("FormInicio_351FI.Form");
            lblVigentesTitulo_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormInicio_351FI.lblVigentesTitulo_351FI");
            lblVigentesDetalle_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormInicio_351FI.lblVigentesDetalle_351FI");
            lblVencidosTitulo_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormInicio_351FI.lblVencidosTitulo_351FI");
            lblVencidosDetalle_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormInicio_351FI.lblVencidosDetalle_351FI");
            lblMultasTitulo_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormInicio_351FI.lblMultasTitulo_351FI");
            lblMultasDetalle_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormInicio_351FI.lblMultasDetalle_351FI");
            lblMontoTitulo_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormInicio_351FI.lblMontoTitulo_351FI");
            lblMontoDetalle_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormInicio_351FI.lblMontoDetalle_351FI");
            if (!errorResumen_351FI) lblAyuda_351FI.Text = bll_idioma_351FI.Traducir_351FI("FormInicio_351FI.lblAyuda_351FI");
            MostrarSaludo_351FI();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma_351FI.Desuscribir_351FI(this);
            base.OnFormClosed(e);
        }
    }
}
