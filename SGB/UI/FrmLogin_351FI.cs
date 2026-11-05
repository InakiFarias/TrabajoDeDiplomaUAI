using BLL.BLL_SER;
using Servicio;
using System.Text.RegularExpressions;

namespace UI
{
    public partial class FrmLogin_351FI : Form, IObservadorIdioma_351FI
    {
        BLL_Usuario_351FI bll_usuario_351FI;
        BLL_Idioma_351FI bll_idioma_351FI = new BLL_Idioma_351FI();
        bool cargandoIdiomas_351FI;
        public FrmLogin_351FI()
        {
            InitializeComponent();
            this.AcceptButton = btnEntrar_351FI;
            bll_idioma_351FI.Suscribir_351FI(this);
            CargarIdiomas_351FI();
        }
        private void FrmLogin_351FI_Load(object sender_351FI, EventArgs e_351FI)
        {
            txtPassword_351FI.UseSystemPasswordChar = true;
            bll_usuario_351FI = new BLL_Usuario_351FI();
        }
        private bool ValidarDatos_351FI(string texto_351FI, string expresionRegular_351FI)
        {
            Regex re = new Regex(expresionRegular_351FI);
            return re.IsMatch(texto_351FI);
        }
        private void btnEntrar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                string nombreUsuario = txtNombreUsuario_351FI.Text;
                if (!ValidarDatos_351FI(nombreUsuario, @"^[a-zA-Z0-9_]{1,50}$")) throw new Exception("Datos erróneos!");

                string password = txtPassword_351FI.Text;
                if (password.Length == 0) throw new Exception("Datos erróneos!");

                string mensajeInconsistencia;

                if (bll_usuario_351FI.Login_351FI(new SER_Usuario_351FI(nombreUsuario, password), out mensajeInconsistencia))
                {
                    if (!string.IsNullOrEmpty(mensajeInconsistencia))
                    {
                        MessageBox.Show(
                            mensajeInconsistencia,
                            "Inconsistencia detectada",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                       
                        txtNombreUsuario_351FI.Text = "";
                        txtPassword_351FI.Text = "";

                        this.Hide();
                        
                        FrmRepararInconsistencia_351FI frmRepararInconsistencia = new FrmRepararInconsistencia_351FI();
                        frmRepararInconsistencia.ShowDialog();
                        this.Show();

                    }
                    else 
                    {

                        txtNombreUsuario_351FI.Text = "";
                        txtPassword_351FI.Text = "";

                        this.Hide();

                        FrmMenu_351FI frmMenu = new FrmMenu_351FI();
                        frmMenu.ShowDialog();

                        this.Show();

                        cargandoIdiomas_351FI = true;
                        cboIdioma_351FI.SelectedValue = bll_idioma_351FI.IdiomaActual_351FI;
                        cargandoIdiomas_351FI = false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarIdiomas_351FI()
        {
            cargandoIdiomas_351FI = true;
            cboIdioma_351FI.DisplayMember = "Nombre_351FI";   
            cboIdioma_351FI.ValueMember = "Codigo_351FI";   
            cboIdioma_351FI.DataSource = bll_idioma_351FI.ObtenerIdiomasDisponibles_351FI();
            cboIdioma_351FI.SelectedValue = bll_idioma_351FI.IdiomaActual_351FI;
            cargandoIdiomas_351FI = false;
        }

        private void cboIdioma_351FI_SelectedIndexChanged(object sender_351FI, EventArgs e_351FI)
        {
            if (cargandoIdiomas_351FI) return;

            try
            {
                string codigo = cboIdioma_351FI.SelectedValue.ToString();
                bll_idioma_351FI.CambiarIdioma_351FI(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ActualizarIdioma_351FI()
        {
            this.Text = bll_idioma_351FI.Traducir_351FI("FrmLogin_351FI.Form");
            lblTitulo_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmLogin_351FI.lblTitulo_351FI");
            lblUsuario_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmLogin_351FI.lblUsuario_351FI");
            lblPassword_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmLogin_351FI.lblPassword_351FI");
            btnEntrar_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmLogin_351FI.btnEntrar_351FI");
            lblSistema_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmLogin_351FI.lblSistema_351FI");
            lblBienvenida_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmLogin_351FI.lblBienvenida_351FI");
            lblIndicacion_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmLogin_351FI.lblIndicacion_351FI");
            lblPie_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmLogin_351FI.lblPie_351FI");
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma_351FI.Desuscribir_351FI(this);
            base.OnFormClosed(e);
        }
    }
}
