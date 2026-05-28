using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;

namespace UI
{
    public partial class frmCambiarClave : Form
    {
        BLL_Usuario bll_usuario;
        public frmCambiarClave()
        {
            InitializeComponent();
        }
        private void frmCambiarClave_Load(object sender, EventArgs e)
        {
            bll_usuario = new BLL_Usuario();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                SER_Usuario usuario = SER_SesionManager.ObtenerSesion().Usuario;
                string claveActual = txtClaveActual.Text;
                string claveNueva = txtClaveNueva.Text;
                bll_usuario.ModificarPassword(claveActual, claveNueva, usuario.Password);
                MessageBox.Show("Se modifico la contraseña con exito");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
