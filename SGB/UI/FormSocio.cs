using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL.BLL_NEG;

namespace UI
{
    public partial class FormSocio : Form
    {
        BLL_Socio bll_Socio;
        BE_Socio? socioSeleccionado;

        public FormSocio()
        {
            InitializeComponent();
        }

        private void FormSocio_Load(object sender, EventArgs e)
        {
            bll_Socio = new BLL_Socio();

            dgvSocios.AutoGenerateColumns = false;
            colSocNumero.DataPropertyName = "NumeroSocio";
            colSocApellido.DataPropertyName = "Apellido";
            colSocNombre.DataPropertyName = "Nombre";
            colSocDni.DataPropertyName = "Dni";
            colSocEstado.DataPropertyName = "Estado";

            CargarSocios();
            this.Shown += FormSocio_Shown;
        }

        // La grilla selecciona la primera fila al mostrarse; se limpia para no precargar los datos de un socio
        private void FormSocio_Shown(object? sender, EventArgs e)
        {
            dgvSocios.ClearSelection();
            Limpiar();
        }

        private void CargarSocios()
        {
            dgvSocios.DataSource = null;
            dgvSocios.DataSource = bll_Socio.BuscarPorDni(txtBuscarDni.Text);
            dgvSocios.ClearSelection();
            Limpiar();
        }

        private void txtBuscarDni_TextChanged(object sender, EventArgs e)
        {
            CargarSocios();
        }

        private void dgvSocios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSocios.SelectedRows.Count == 0 || dgvSocios.SelectedRows[0].DataBoundItem == null) return;

            socioSeleccionado = (BE_Socio)dgvSocios.SelectedRows[0].DataBoundItem;
            lblNumero.Text = $"Número de socio: {socioSeleccionado.NumeroSocio} ({socioSeleccionado.Estado})";
            txtNombre.Text = socioSeleccionado.Nombre;
            txtApellido.Text = socioSeleccionado.Apellido;
            txtDni.Text = socioSeleccionado.Dni;
        }

        private void Limpiar()
        {
            socioSeleccionado = null;
            lblNumero.Text = "Número de socio: — (se asigna al dar de alta)";
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvSocios.ClearSelection();
            Limpiar();
            txtNombre.Focus();
        }

        // ------------------------------------------------------------ Alta
        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Socio socio = new BE_Socio(0, txtNombre.Text, txtApellido.Text, txtDni.Text, "Activo");
                bll_Socio.Alta(socio);

                MessageBox.Show($"Socio dado de alta correctamente con el número {socio.NumeroSocio}.", "Alta de socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSocios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ------------------------------------------------------------ Modificación
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (socioSeleccionado == null) throw new Exception("Seleccione el socio a modificar.");

                BE_Socio socio = new BE_Socio(socioSeleccionado.NumeroSocio, txtNombre.Text, txtApellido.Text, txtDni.Text, socioSeleccionado.Estado);
                if (MessageBox.Show($"¿Confirma la modificación del socio N° {socio.NumeroSocio}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_Socio.Modificar(socio);
                MessageBox.Show("Socio modificado correctamente.", "Modificación de socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSocios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ------------------------------------------------------------ Baja
        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (socioSeleccionado == null) throw new Exception("Seleccione el socio a dar de baja.");

                if (MessageBox.Show($"¿Confirma la baja del socio {socioSeleccionado.Apellido}, {socioSeleccionado.Nombre}?\nUn socio dado de baja no puede realizar préstamos, pagos ni donaciones.",
                                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_Socio.Baja(socioSeleccionado);
                MessageBox.Show("Socio dado de baja correctamente.", "Baja de socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSocios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
