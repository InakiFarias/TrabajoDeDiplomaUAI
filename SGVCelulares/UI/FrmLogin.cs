using BLL;
using Servicio;
using System.Text.RegularExpressions;

namespace UI
{
    public partial class FrmLogin : Form, IObservadorIdioma
    {
        BLL_Usuario bll_usuario;
        BLL_Idioma bll_idioma = new BLL_Idioma();
        bool cargandoIdiomas;
        public FrmLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnEntrar;
            bll_idioma.Suscribir(this);
            CargarIdiomas();
            bll_idioma.CambiarIdioma("es-AR");
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            bll_usuario = new BLL_Usuario();
        }
        private bool ValidarDatos(string texto, string expresionRegular)
        {
            Regex re = new Regex(expresionRegular);
            return re.IsMatch(texto);
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = txtNombreUsuario.Text;
                if (!ValidarDatos(nombreUsuario, @"^[a-zA-Z0-9_]{1,50}$")) throw new Exception("Datos erróneos!");

                string password = txtPassword.Text;
                if (password.Length == 0) throw new Exception("Datos erróneos!");

                if (bll_usuario.Login(new SER_Usuario(nombreUsuario, password)))
                {
                    txtNombreUsuario.Text = "";
                    txtPassword.Text = "";
                    this.Hide();
                    FrmMenu frmMenu = new FrmMenu();
                    frmMenu.ShowDialog();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarIdiomas()
        {
            cargandoIdiomas = true;
            cboIdioma.DisplayMember = "NativeName";
            cboIdioma.ValueMember = "Name";
            cboIdioma.DataSource = bll_idioma.ObtenerIdiomasDisponibles();
            cargandoIdiomas = false;
        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoIdiomas) return;

            try
            {
                string codigo = cboIdioma.SelectedValue.ToString();
                bll_idioma.CambiarIdioma(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ActualizarIdioma()
        {
            this.Text = bll_idioma.Traducir("FrmLogin.Form");
            lblTitulo.Text = bll_idioma.Traducir("FrmLogin.lblTitulo");
            lblUsuario.Text = bll_idioma.Traducir("FrmLogin.lblUsuario");
            lblPassword.Text = bll_idioma.Traducir("FrmLogin.lblPassword");
            btnEntrar.Text = bll_idioma.Traducir("FrmLogin.btnEntrar");
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma.Desuscribir(this);
            base.OnFormClosed(e);
        }
    }
}
