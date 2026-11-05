using BLL.BLL_SER;
using Servicio;
using System.Data;
using System.Text.RegularExpressions;


namespace UI
{
    public partial class frmCambiarClave_351FI : Form, IObservadorIdioma_351FI
    {
        BLL_Usuario_351FI bll_usuario_351FI;
        BLL_Idioma_351FI bll_idioma_351FI = new BLL_Idioma_351FI();
        public frmCambiarClave_351FI()
        {
            InitializeComponent();
            this.AcceptButton = btnConfirmar_351FI;
            bll_idioma_351FI.Suscribir_351FI(this);
            ActualizarIdioma_351FI();
        }
        private bool ValidarDatos_351FI(string texto_351FI, string expresionRegular_351FI)
        {
            Regex re = new Regex(expresionRegular_351FI);
            return re.IsMatch(texto_351FI);
        }
        private void frmCambiarClave_351FI_Load(object sender_351FI, EventArgs e_351FI)
        {
            bll_usuario_351FI = new BLL_Usuario_351FI();
        }

        private void btnConfirmar_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                string claveActual = txtClaveActual_351FI.Text;
                if (claveActual.Length == 0) throw new Exception("La clave actual está vacía!");

                string claveNueva = txtClaveNueva_351FI.Text;
                if (!ValidarDatos_351FI(claveNueva, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,50}$")) throw new Exception("El password debe tener al menos 8 caracteres, una mayúscula, una minúscula, un número y un carácter especial!");

                bll_usuario_351FI.ModificarPassword_351FI(claveActual, claveNueva);
                MessageBox.Show("Se modifico la contraseña con éxito!", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var formularios = Application.OpenForms
                                  .Cast<Form>()
                                  .Where(f => f.Name != "FrmLogin_351FI")
                                  .ToList();
                
                bll_usuario_351FI.Logout_351FI();
                foreach (var form in formularios)
                {
                    form.Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ActualizarIdioma_351FI()
        {
            this.Text = bll_idioma_351FI.Traducir_351FI("frmCambiarClave_351FI.Form");
            lblTitulo_351FI.Text = bll_idioma_351FI.Traducir_351FI("frmCambiarClave_351FI.lblTitulo_351FI");
            lblClaveActual_351FI.Text = bll_idioma_351FI.Traducir_351FI("frmCambiarClave_351FI.lblClaveActual_351FI");
            lblClaveNueva_351FI.Text = bll_idioma_351FI.Traducir_351FI("frmCambiarClave_351FI.lblClaveNueva_351FI");
            btnConfirmar_351FI.Text = bll_idioma_351FI.Traducir_351FI("frmCambiarClave_351FI.btnConfirmar_351FI");
            lblRequisitos_351FI.Text = bll_idioma_351FI.Traducir_351FI("frmCambiarClave_351FI.lblRequisitos_351FI");
            lblAviso_351FI.Text = bll_idioma_351FI.Traducir_351FI("frmCambiarClave_351FI.lblAviso_351FI");
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma_351FI.Desuscribir_351FI(this);
            base.OnFormClosed(e);
        }
    }
}
