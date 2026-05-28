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
    public partial class FrmUsuarios : Form
    {
        BLL_Usuario bll_usuario;
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            foreach (var control in Controls)
            {
                if (control is DataGridView grilla)
                {
                    grilla.MultiSelect = false;
                    grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            bll_usuario = new BLL_Usuario();
            Mostrar(grillaUsuarios, bll_usuario.ConsultarParaGrilla());
        }
        private void Mostrar(DataGridView grilla, object datos)
        {
            grilla.DataSource = null;
            grilla.DataSource = datos;
        }
        private bool ValidarDatos(string texto, string expresionRegular)
        {
            Regex re = new Regex(expresionRegular);
            return re.IsMatch(texto);
        }
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDni.Text;
                if (!ValidarDatos(dni, @"^\d{8}$")) throw new Exception("El formato del DNI es incorrecto!");

                string nombre = txtNombre.Text;
                if (!ValidarDatos(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]{1,50}$")) throw new Exception("El formato del nombre es incorrecto!");

                string apellido = txtApellido.Text;
                if (!ValidarDatos(apellido, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]{1,50}$")) throw new Exception("El formato del apellido es incorrecto!");

                string correo = txtCorreo.Text;
                if (!ValidarDatos(correo, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")) throw new Exception("El formato del correo es incorrecto!");

                string nombreUsuario = txtNombreUsuario.Text;
                if (!ValidarDatos(nombreUsuario, @"^[a-zA-Z0-9_]{1,50}$")) throw new Exception("El formato del nombre de usuario es incorrecto!");

                SER_Usuario usuario = new SER_Usuario(dni, nombre, apellido, correo, nombreUsuario, false, true);
                bll_usuario.Agregar(usuario);
                Mostrar(grillaUsuarios, bll_usuario.ConsultarParaGrilla());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesbloquearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaUsuarios.SelectedRows.Count == 0) throw new Exception("NO EXISTEN USUARIOS REGISTRADOS");
                SER_Usuario usAux = new SER_Usuario(grillaUsuarios.SelectedRows[0].Cells["DNI"].Value.ToString());
                SER_Usuario us = bll_usuario.ConsultarPorId(usAux);
                bll_usuario.Desbloquear(us);
                MessageBox.Show("El usuario con DNI " + us.Dni + " ha sido desbloqueado correctamente ", "Desbloqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);}

            
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
