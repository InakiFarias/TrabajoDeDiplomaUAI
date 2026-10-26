using System.Globalization;
using BLL.BLL_NEG;
using BLL.BLL_SER;
using Servicio;

namespace UI
{
    // Pantalla que se muestra al iniciar sesión: saludo y cifras del día
    public partial class FormInicio : Form, IObservadorIdioma
    {
        BLL_Idioma bll_idioma = new BLL_Idioma();
        bool errorResumen;

        public FormInicio()
        {
            InitializeComponent();
            bll_idioma.Suscribir(this);
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            ActualizarIdioma();

            try
            {
                BLL_Resumen bll_resumen = new BLL_Resumen();
                lblVigentesValor.Text = bll_resumen.ContarPrestamosVigentes().ToString();
                lblVencidosValor.Text = bll_resumen.ContarPrestamosVencidos().ToString();
                lblMultasValor.Text = bll_resumen.ContarMultasPendientes().ToString();
                lblMontoValor.Text = $"$ {bll_resumen.TotalAdeudado():N2}";
            }
            catch (Exception ex)
            {
                errorResumen = true;
                lblAyuda.Text = $"No se pudo obtener el resumen: {ex.Message}";
            }
        }

        private void MostrarSaludo()
        {
            SER_Usuario usuario = SER_SesionManager.ObtenerSesion().Usuario;
            if (usuario == null) return;
            string nombre = string.IsNullOrWhiteSpace(usuario.Nombre) ? usuario.NombreUsuario : usuario.Nombre;
            lblSaludo.Text = $"{Saludo()}, {nombre}";

            // La fecha se escribe con el formato largo del idioma elegido
            CultureInfo cultura = new CultureInfo(bll_idioma.IdiomaActual);
            string fecha = DateTime.Today.ToString("D", cultura);
            lblFecha.Text = cultura.TextInfo.ToUpper(fecha[0]) + fecha.Substring(1);
        }

        private string Saludo()
        {
            int hora = DateTime.Now.Hour;
            if (hora < 12) return bll_idioma.Traducir("FormInicio.buenosDias");
            if (hora < 20) return bll_idioma.Traducir("FormInicio.buenasTardes");
            return bll_idioma.Traducir("FormInicio.buenasNoches");
        }

        // ------------------------------------------------------------ Idioma
        public void ActualizarIdioma()
        {
            this.Text = bll_idioma.Traducir("FormInicio.Form");
            lblVigentesTitulo.Text = bll_idioma.Traducir("FormInicio.lblVigentesTitulo");
            lblVigentesDetalle.Text = bll_idioma.Traducir("FormInicio.lblVigentesDetalle");
            lblVencidosTitulo.Text = bll_idioma.Traducir("FormInicio.lblVencidosTitulo");
            lblVencidosDetalle.Text = bll_idioma.Traducir("FormInicio.lblVencidosDetalle");
            lblMultasTitulo.Text = bll_idioma.Traducir("FormInicio.lblMultasTitulo");
            lblMultasDetalle.Text = bll_idioma.Traducir("FormInicio.lblMultasDetalle");
            lblMontoTitulo.Text = bll_idioma.Traducir("FormInicio.lblMontoTitulo");
            lblMontoDetalle.Text = bll_idioma.Traducir("FormInicio.lblMontoDetalle");
            if (!errorResumen) lblAyuda.Text = bll_idioma.Traducir("FormInicio.lblAyuda");
            MostrarSaludo();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma.Desuscribir(this);
            base.OnFormClosed(e);
        }
    }
}
