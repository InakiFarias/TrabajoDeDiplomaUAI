using BLL;
using Microsoft.VisualBasic;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UI
{
    public partial class FrmGestionUsuarios : Form
    {
        BLL_Usuario bll_usuario;
        public FrmGestionUsuarios()
        {
            InitializeComponent();
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            grillaUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaUsuarios.MultiSelect = false;
            bll_usuario = new BLL_Usuario();
            Mostrar(grillaUsuarios, bll_usuario.ConsultarActivos());
        }
        private void Mostrar(DataGridView grilla, object datos)
        {
            grilla.DataSource = null;
            grilla.DataSource = datos;
            ContarUsuarios(lblNumeroUsuarios);
        }
        private void ContarUsuarios(Label lbl) 
        {
            int cant = bll_usuario.Consultar().Count();
            lbl.Text = $"Número de usuarios: {cant}";
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


                SER_Usuario usuario = new SER_Usuario(dni, nombre, apellido, correo, false, true);
                bll_usuario.Agregar(usuario);
                MessageBox.Show("Usuario creado con éxito!", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (radioButton1.Checked)
                {
                    Mostrar(grillaUsuarios, bll_usuario.ConsultarActivos());
                }
                else
                {
                    Mostrar(grillaUsuarios, bll_usuario.ConsultarParaGrilla());
                }
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
                if (grillaUsuarios.SelectedRows.Count == 0) throw new Exception("NO EXISTEN USUARIOS REGISTRADOS!");
                SER_Usuario usAux = new SER_Usuario(grillaUsuarios.SelectedRows[0].Cells["DNI"].Value.ToString());
                SER_Usuario us = bll_usuario.ConsultarPorId(usAux);
                bll_usuario.Desbloquear(us);
                MessageBox.Show("El usuario con DNI " + us.Dni + " ha sido desbloqueado correctamente ", "Desbloqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mostrar(grillaUsuarios, bll_usuario.ConsultarActivos());
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCambiarEstadoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaUsuarios.SelectedRows.Count == 0) throw new Exception("NO EXISTEN USUARIOS REGISTRADOS!");
                SER_Usuario usAux = new SER_Usuario(grillaUsuarios.SelectedRows[0].Cells["DNI"].Value.ToString());
                SER_Usuario us = bll_usuario.ConsultarPorId(usAux);

                DialogResult res = MessageBox.Show($"¿Desea cambiar el estado de {us.NombreUsuario} de {(us.Activo ? "Activo" : "Inactivo")} a {(us.Activo ? "Inactivo" : "Activo")}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    bll_usuario.CambiarEstadoActivo(usAux);
                    if (radioButton1.Checked)
                    {
                        Mostrar(grillaUsuarios, bll_usuario.ConsultarActivos());
                    }
                    else
                    {
                        Mostrar(grillaUsuarios, bll_usuario.ConsultarParaGrilla());
                    }
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaUsuarios.SelectedRows.Count == 0) throw new Exception("NO EXISTEN USUARIOS REGISTRADOS");
                SER_Usuario usAux = new SER_Usuario(grillaUsuarios.SelectedRows[0].Cells["DNI"].Value.ToString());
                SER_Usuario us = bll_usuario.ConsultarPorId(usAux);
                string nombre = Interaction.InputBox("Ingrese nombre del usuario", "Modificar usuario", grillaUsuarios.SelectedRows[0].Cells["Nombre"].Value.ToString());
                if (!ValidarDatos(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]{1,50}$")) throw new Exception("El formato del nombre es incorrecto!");

                string apellido = Interaction.InputBox("Ingrese apellido del usuario", "Modificar usuario", grillaUsuarios.SelectedRows[0].Cells["Apellido"].Value.ToString());
                if (!ValidarDatos(apellido, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]{1,50}$")) throw new Exception("El formato del apellido es incorrecto!");

                string nombreUsuario = Interaction.InputBox("Ingrese nombre de usuario", "Modificar usuario", grillaUsuarios.SelectedRows[0].Cells["Login"].Value.ToString());
                if (!ValidarDatos(nombreUsuario, @"^[a-zA-Z0-9_]{1,50}$")) throw new Exception("El formato del nombre de usuario es incorrecto!");

                us.Nombre = nombre;
                us.Apellido = apellido;
                us.NombreUsuario = nombreUsuario;
                bll_usuario.Modificar(us);
                MessageBox.Show("El usuario con DNI " + us.Dni + " ha sido modificado correctamente ", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (radioButton1.Checked)
                {
                    Mostrar(grillaUsuarios, bll_usuario.ConsultarActivos());
                }
                else
                {
                    Mostrar(grillaUsuarios, bll_usuario.ConsultarParaGrilla());
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAplicarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                
                string dni = txtDni.Text;

                string nombre = txtNombre.Text;

                string apellido = txtApellido.Text;

                string correo = txtCorreo.Text;

                string nombreUsuario = txtNombreUsuario.Text;

                SER_Usuario usuario = new SER_Usuario(dni, nombre, apellido, correo, nombreUsuario);
                Mostrar(grillaUsuarios, bll_usuario.ConsultarFiltrado(usuario));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked) 
                {
                    Mostrar(grillaUsuarios,bll_usuario.ConsultarActivos());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(radioButton2.Checked)
                {
                    Mostrar(grillaUsuarios, bll_usuario.ConsultarParaGrilla());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
