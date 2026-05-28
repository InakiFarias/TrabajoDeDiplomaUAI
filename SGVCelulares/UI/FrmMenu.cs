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
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FrmUsuarios"];

            if (frm == null)
            {
                FrmUsuarios frmUsuarios = new FrmUsuarios();
                frmUsuarios.Show();
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
                frmCambiarClave.Show();
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

        }
    }
}
