using BLL;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmUsuarios : Form
    {
        BLL_Usuario bll_usuario;
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            bll_usuario = new BLL_Usuario();
        }
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDni.Text;
                if (dni.Length != 8) throw new Exception("Dni vacio");

                string nombre = txtNombre.Text;
                if (nombre.Length == 0) throw new Exception("Nombre vacio");

                string apellido = txtApellido.Text;
                if (apellido.Length == 0) throw new Exception("apellido vacio");

                string correo = txtCorreo.Text;
                if (correo.Length == 0) throw new Exception("correo vacio");

                string nombreUsuario = txtNombreUsuario.Text;
                if (nombreUsuario.Length == 0) throw new Exception("Nombre de usuario vacio");

                SER_Usuario usuario = new SER_Usuario(dni, nombre, apellido, correo, nombreUsuario, dni + apellido, false, true);
                bll_usuario.CrearUsuario(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
