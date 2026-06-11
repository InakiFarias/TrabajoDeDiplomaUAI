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
    public partial class FrmMenu : Form
    {
        BLL_Usuario bll_usuario;
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            bll_usuario = new BLL_Usuario();
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FrmUsuarios"];

            if (frm == null)
            {
                FrmGestionUsuarios frmUsuarios = new FrmGestionUsuarios();
                frmUsuarios.ShowDialog();
            }
            else
            {
                frm.WindowState = FormWindowState.Normal;
                frm.BringToFront();
                frm.Focus();
            }
        }
        private void btnBitacora_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FrmBitacora"];

            if (frm == null)
            {
                FrmBitacora frmBitacora = new FrmBitacora();
                frmBitacora.ShowDialog();
            }
            else
            {
                frm.WindowState = FormWindowState.Normal;
                frm.BringToFront();
                frm.Focus();
            }
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FrmCambiarClave"];

            if (frm == null)
            {
                frmCambiarClave frmCambiarClave = new frmCambiarClave();
                frmCambiarClave.ShowDialog();
            }
            else
            {
                frm.WindowState = FormWindowState.Normal;
                frm.BringToFront();
                frm.Focus();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Seguro que desea cerrar la sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                bll_usuario.Logout();
                this.Close();
            }
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            bll_usuario.Logout();
        }

        private void btnRelogin_Click(object sender, EventArgs e)
        {
            SER_SesionManager sesion1 = SER_SesionManager.ObtenerSesion();
            SER_SesionManager sesion2 = SER_SesionManager.ObtenerSesion();

            if(sesion1 == sesion2)
            {
                MessageBox.Show("Usted tiene una sesión única en todo el sistema!", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
