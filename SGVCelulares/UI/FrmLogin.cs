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
    public partial class FrmLogin : Form
    {
        BLL_Usuario bll_usuario;
        public FrmLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnEntrar;
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
                    this.Hide();
                    FrmMenu frmMenu = new FrmMenu();
                    frmMenu.ShowDialog();
                    this.Close();
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
