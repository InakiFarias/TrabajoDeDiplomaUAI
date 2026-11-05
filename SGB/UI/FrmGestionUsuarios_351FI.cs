using BLL.BLL_SER;
using Microsoft.VisualBasic;
using Servicio;
using System.Text.RegularExpressions;

namespace UI
{
    public partial class FrmGestionUsuarios_351FI : Form, IObservadorIdioma_351FI
    {
        BLL_Usuario_351FI bll_usuario_351FI;
        BLL_Idioma_351FI bll_idioma_351FI = new BLL_Idioma_351FI();
        BLL_Rol_351FI bll_rol_351FI;
        public FrmGestionUsuarios_351FI()
        {
            InitializeComponent();
            bll_idioma_351FI.Suscribir_351FI(this);
            ActualizarIdioma_351FI();
        }
        private void FrmUsuarios_Load_351FI(object sender_351FI, EventArgs e_351FI)
        {
            grillaUsuarios_351FI.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cbxRoles_351FI.DropDownStyle = ComboBoxStyle.DropDownList;
            grillaUsuarios_351FI.MultiSelect = false;
            bll_usuario_351FI = new BLL_Usuario_351FI();
            bll_rol_351FI = new BLL_Rol_351FI();
            Mostrar_351FI(grillaUsuarios_351FI, bll_usuario_351FI.ConsultarActivos_351FI());
            foreach (SER_Rol_351FI c in bll_rol_351FI.Consultar_351FI())
            {
                cbxRoles_351FI.Items.Add(c);
            }
            SER_Usuario_351FI usuario = SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI;

            btnCrearUsuario_351FI.Enabled = usuario.Rol_351FI.TienePermiso_351FI("Crear Usuario");
            btnModificarUsuario_351FI.Enabled = usuario.Rol_351FI.TienePermiso_351FI("Modificar Usuario");
            btnDesbloquearUsuario_351FI.Enabled = usuario.Rol_351FI.TienePermiso_351FI("Desbloquear Usuario");
            btnCambiarEstadoUsuario_351FI.Enabled = usuario.Rol_351FI.TienePermiso_351FI("Activar Usuario");
        }
        private void Mostrar_351FI(DataGridView grilla_351FI, object datos_351FI)
        {
            grilla_351FI.DataSource = null;
            grilla_351FI.DataSource = datos_351FI;
            TraducirColumnas_351FI(grilla_351FI);
            ContarUsuarios_351FI(lblNumero_351FI);
        }
        private void TraducirColumnas_351FI(DataGridView grilla_351FI)
        {
            if (grilla_351FI.Columns.Count == 0) return;  

            grilla_351FI.Columns["DNI"].HeaderText = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.colDni");
            grilla_351FI.Columns["Nombre"].HeaderText = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.colNombre");
            grilla_351FI.Columns["Apellido"].HeaderText = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.colApellido");
            grilla_351FI.Columns["Usuario"].HeaderText = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.colUsuario");
            grilla_351FI.Columns["Activo"].HeaderText = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.colActivo");
            grilla_351FI.Columns["Bloqueado"].HeaderText = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.colBloqueado");
            grilla_351FI.Columns["Rol"].HeaderText = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.colRol");
        }
        private void ContarUsuarios_351FI(Label lbl_351FI) 
        {
            int cant = bll_usuario_351FI.Consultar_351FI().Count();
            lbl_351FI.Text = $"{cant}";
        }
        private bool ValidarDatos_351FI(string texto_351FI, string expresionRegular_351FI)
        {
            Regex re = new Regex(expresionRegular_351FI);
            return re.IsMatch(texto_351FI);
        }
        private void btnCrearUsuario_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                string dni = txtDni_351FI.Text;
                if (!ValidarDatos_351FI(dni, @"^\d{8}$")) throw new Exception("El formato del DNI es incorrecto!");

                string nombre = txtNombre_351FI.Text;
                if (!ValidarDatos_351FI(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]{1,50}$")) throw new Exception("El formato del nombre es incorrecto!");

                string apellido = txtApellido_351FI.Text;
                if (!ValidarDatos_351FI(apellido, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]{1,50}$")) throw new Exception("El formato del apellido es incorrecto!");

                string correo = txtCorreo_351FI.Text;
                if (!ValidarDatos_351FI(correo, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")) throw new Exception("El formato del correo es incorrecto!");


                SER_Rol_351FI rol = (SER_Rol_351FI)cbxRoles_351FI.SelectedItem;
                SER_Usuario_351FI usuario = new SER_Usuario_351FI(dni, nombre, apellido, correo, false, true, rol, "es-AR");
                

                bll_usuario_351FI.Agregar_351FI(usuario);
                MessageBox.Show("Usuario creado con éxito!", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTextBox_351FI();
                if (radioButton1_351FI.Checked)
                {
                    Mostrar_351FI(grillaUsuarios_351FI, bll_usuario_351FI.ConsultarActivos_351FI());
                }
                else
                {
                    Mostrar_351FI(grillaUsuarios_351FI, bll_usuario_351FI.ConsultarParaGrilla_351FI());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesbloquearUsuario_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (grillaUsuarios_351FI.SelectedRows.Count == 0) throw new Exception("NO EXISTEN USUARIOS REGISTRADOS!");
                SER_Usuario_351FI usAux = new SER_Usuario_351FI(grillaUsuarios_351FI.SelectedRows[0].Cells["DNI"].Value.ToString());
                bll_usuario_351FI.Desbloquear_351FI(usAux);
                MessageBox.Show("El usuario con DNI " + usAux.Dni_351FI + " ha sido desbloqueado correctamente ", "Desbloqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mostrar_351FI(grillaUsuarios_351FI, bll_usuario_351FI.ConsultarActivos_351FI());
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCambiarEstadoUsuario_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (grillaUsuarios_351FI.SelectedRows.Count == 0) throw new Exception("NO EXISTEN USUARIOS REGISTRADOS!");
                SER_Usuario_351FI usAux = new SER_Usuario_351FI(grillaUsuarios_351FI.SelectedRows[0].Cells["DNI"].Value.ToString());
                SER_Usuario_351FI us = bll_usuario_351FI.ConsultarPorId_351FI(usAux);

                DialogResult res = MessageBox.Show($"¿Desea cambiar el estado de {us.NombreUsuario_351FI} de {(us.Activo_351FI ? "Activo" : "Inactivo")} a {(us.Activo_351FI ? "Inactivo" : "Activo")}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    bll_usuario_351FI.CambiarEstadoActivo_351FI(usAux);
                    if (radioButton1_351FI.Checked)
                    {
                        Mostrar_351FI(grillaUsuarios_351FI, bll_usuario_351FI.ConsultarActivos_351FI());
                    }
                    else
                    {
                        Mostrar_351FI(grillaUsuarios_351FI, bll_usuario_351FI.ConsultarParaGrilla_351FI());
                    }
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModificarUsuario_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (grillaUsuarios_351FI.SelectedRows.Count == 0) throw new Exception("NO EXISTEN USUARIOS REGISTRADOS");
                SER_Usuario_351FI usAux = new SER_Usuario_351FI(grillaUsuarios_351FI.SelectedRows[0].Cells["DNI"].Value.ToString());
                SER_Usuario_351FI us = bll_usuario_351FI.ConsultarPorId_351FI(usAux);
                string nombre = Interaction.InputBox("Ingrese nombre del usuario", "Modificar usuario", grillaUsuarios_351FI.SelectedRows[0].Cells["Nombre"].Value.ToString());
                if (!ValidarDatos_351FI(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]{1,50}$")) throw new Exception("El formato del nombre es incorrecto!");

                string apellido = Interaction.InputBox("Ingrese apellido del usuario", "Modificar usuario", grillaUsuarios_351FI.SelectedRows[0].Cells["Apellido"].Value.ToString());
                if (!ValidarDatos_351FI(apellido, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]{1,50}$")) throw new Exception("El formato del apellido es incorrecto!");

                string nombreUsuario = Interaction.InputBox("Ingrese nombre de usuario", "Modificar usuario", grillaUsuarios_351FI.SelectedRows[0].Cells["Usuario"].Value.ToString());
                if (!ValidarDatos_351FI(nombreUsuario, @"^[a-zA-Z0-9_]{1,50}$")) throw new Exception("El formato del nombre de usuario es incorrecto!");

                us.Nombre_351FI = nombre;
                us.Apellido_351FI = apellido;
                us.NombreUsuario_351FI = nombreUsuario;
                bll_usuario_351FI.Modificar_351FI(us);
                MessageBox.Show("El usuario con DNI " + us.Dni_351FI + " ha sido modificado correctamente ", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (radioButton1_351FI.Checked)
                {
                    Mostrar_351FI(grillaUsuarios_351FI, bll_usuario_351FI.ConsultarActivos_351FI());
                }
                else
                {
                    Mostrar_351FI(grillaUsuarios_351FI, bll_usuario_351FI.ConsultarParaGrilla_351FI());
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            this.Close();
        }

        private void btnAplicarCambios_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                radioButton1_351FI.Checked = false;
                radioButton2_351FI.Checked = false;
                
                string dni = txtDni_351FI.Text;
                string nombre = txtNombre_351FI.Text;
                string apellido = txtApellido_351FI.Text;
                string correo = txtCorreo_351FI.Text;
                string nombreUsuario = txtNombreUsuario_351FI.Text;
                SER_Rol_351FI rol = (SER_Rol_351FI)cbxRoles_351FI.SelectedItem;


                SER_Usuario_351FI usuario = new SER_Usuario_351FI(dni, nombre, apellido, correo, nombreUsuario);
                usuario.Rol_351FI = rol;
                Mostrar_351FI(grillaUsuarios_351FI, bll_usuario_351FI.ConsultarFiltrado_351FI(usuario));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void radioButton1_351FI_CheckedChanged(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (radioButton1_351FI.Checked) 
                {
                    Mostrar_351FI(grillaUsuarios_351FI,bll_usuario_351FI.ConsultarActivos_351FI());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void radioButton2_351FI_CheckedChanged(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if(radioButton2_351FI.Checked)
                {
                    Mostrar_351FI(grillaUsuarios_351FI, bll_usuario_351FI.ConsultarParaGrilla_351FI());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ActualizarIdioma_351FI()
        {
            this.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.Form");
            lblTitulo_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.lblTitulo_351FI");
            lblSeccionDatos_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.lblSeccionDatos_351FI");
            btnCrearUsuario_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.btnCrearUsuario_351FI");
            btnDesbloquearUsuario_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.btnDesbloquearUsuario_351FI");
            btnModificarUsuario_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.btnModificarUsuario_351FI");
            btnCambiarEstadoUsuario_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.btnCambiarEstadoUsuario_351FI");
            btnAplicarCambios_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.btnAplicarCambios_351FI");
            btnSalir_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.btnSalir_351FI");
            label1_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.label1_351FI");
            lblDni_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.lblDni_351FI");
            lblRol_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.lblRol_351FI");
            lblNombre_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.lblNombre_351FI");
            lblApellido_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.lblApellido_351FI");
            lblCorreo_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.lblCorreo_351FI");
            lblFiltro_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.lblFiltro_351FI");
            lblNumeroUsuarios_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.lblNumeroUsuarios_351FI");
            radioButton1_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.radioButton1_351FI");
            radioButton2_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionUsuarios_351FI.radioButton2_351FI");
            TraducirColumnas_351FI(grillaUsuarios_351FI);   

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma_351FI.Desuscribir_351FI(this);
            base.OnFormClosed(e);
        }
        private void LimpiarTextBox_351FI()
        {
            txtDni_351FI.Text = "";
            txtNombre_351FI.Text = "";
            txtApellido_351FI.Text = "";
            txtCorreo_351FI.Text = "";
            txtNombreUsuario_351FI.Text = "";
            cbxRoles_351FI.SelectedIndex = 0;
        }
    }
}
