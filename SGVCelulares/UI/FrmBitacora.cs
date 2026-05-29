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
    public partial class FrmBitacora : Form
    {
        BLL_Bitacora bll_bitacora;
        BLL_Usuario bll_usuario;
        public FrmBitacora()
        {
            InitializeComponent();
        }

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            bll_bitacora = new BLL_Bitacora();
            bll_usuario = new BLL_Usuario();
            grillaBitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaBitacora.MultiSelect = false;
            grillaBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbxCriticidad.Items.AddRange(new string[] { "Alta", "Media", "Baja" });
            cbxModulo.Items.AddRange(new string[] { "Gestión de Usuarios", "Menú Principal" });
            cbxEvento.Items.AddRange(new string[] {
                "Login", "Logout", "Crear Usuario", "Modificar Usuario","Cambiar Clave", "Bloquear Usuario", "Activar Usuario", "Desactivar Usuario" });
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            Mostrar(grillaBitacora, bll_bitacora.ConsultarParaGrilla3Dias());
            ActualizarTXT();
        }
        private void ActualizarTXT()
        {
            try
            {
                if (grillaBitacora.SelectedRows.Count == 0)
                    return;

                if (grillaBitacora.SelectedRows[0].Cells["Login"].Value == null)
                    return;

                string login = grillaBitacora.SelectedRows[0].Cells["Login"].Value.ToString();

                SER_Usuario us = bll_bitacora.ConsultarPorNombreUsuario(login);

                if (us == null)
                    return;

                txtNombre.Text = us.Nombre;
                txtApellido.Text = us.Apellido;
            }
            catch
            {

            }
        }
        private void Mostrar(DataGridView grilla, object datos)
        {
            grilla.DataSource = null;
            grilla.DataSource = datos;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = txtNombreUsuario.Text;
                string modulo = cbxModulo.SelectedItem?.ToString();
                string evento = cbxEvento.SelectedItem?.ToString();
                int? criticidad = cbxCriticidad.SelectedIndex >= 0 ? (int?)cbxCriticidad.SelectedIndex + 1 : null;
                DateTime? fechaInicio = dtpFechaInicio.Value.Date;
                DateTime? fechaFin = dtpFechaFin.Value.Date.AddDays(1).AddTicks(-1);
                if(fechaInicio > fechaFin)throw new Exception("ERROR: La fecha de inicio no puede ser mayor a la fecha de fin!!");
                Mostrar(grillaBitacora, bll_bitacora.ConsultarFiltradoBitacora(nombreUsuario, modulo, evento, criticidad, fechaInicio, fechaFin));
                if(grillaBitacora.Rows.Count == 0) 
                {
                    txtApellido.Text = "";
                    txtNombre.Text = "";
                } else
                {
                    ActualizarTXT();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombreUsuario.Clear();
                cbxCriticidad.SelectedIndex = -1;
                cbxEvento.SelectedIndex = -1;
                cbxModulo.SelectedIndex = -1;
                dtpFechaFin.Value = DateTime.Now;
                dtpFechaInicio.Value = DateTime.Now;
                Mostrar(grillaBitacora, bll_bitacora.ConsultarParaGrilla3Dias());

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void grillaBitacora_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (grillaBitacora.Rows.Count > 0) ActualizarTXT();


            }
            catch (Exception)
            {

                
            }
        }
    }
}
