using BLL;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmCambiarClave : Form
    {
        BLL_Usuario bll_usuario;
        public frmCambiarClave()
        {
            InitializeComponent();
        }
        private bool ValidarDatos(string texto, string expresionRegular)
        {
            Regex re = new Regex(expresionRegular);
            return re.IsMatch(texto);
        }
        private void frmCambiarClave_Load(object sender, EventArgs e)
        {
            bll_usuario = new BLL_Usuario();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string claveActual = txtClaveActual.Text;
                if (claveActual.Length == 0) throw new Exception("La clave actual está vacía!");

                string claveNueva = txtClaveNueva.Text;
                if (!ValidarDatos(claveNueva, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,50}$")) throw new Exception("El password debe tener al menos 8 caracteres, una mayúscula, una minúscula, un número y un carácter especial!");

                bll_usuario.ModificarPassword(claveActual, claveNueva);
                MessageBox.Show("Se modifico la contraseña con éxito!");
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
