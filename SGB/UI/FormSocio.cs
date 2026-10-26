using BE;
using BLL.BLL_NEG;
using BLL.BLL_SER;
using Servicio;

namespace UI
{
    public partial class FormSocio : Form, IObservadorIdioma
    {
        BLL_Idioma bll_idioma = new BLL_Idioma();
        BLL_Socio bll_Socio;
        BE_Socio? socioSeleccionado;

        public FormSocio()
        {
            InitializeComponent();
            bll_idioma.Suscribir(this);
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
            ActualizarIdioma();
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
            txtNombre.Text = socioSeleccionado.Nombre;
            txtApellido.Text = socioSeleccionado.Apellido;
            txtDni.Text = socioSeleccionado.Dni;
            MostrarEstado();
        }

        // Número del socio y botones disponibles según su estado
        private void MostrarEstado()
        {
            if (socioSeleccionado == null)
            {
                lblNumero.Text = bll_idioma.Traducir("FormSocio.numeroNuevo");
                btnModificar.Enabled = false;
                btnBaja.Enabled = false;
                btnReactivar.Enabled = false;
                return;
            }

            bool dadoDeBaja = socioSeleccionado.Estado == "Baja";
            lblNumero.Text = $"{bll_idioma.Traducir("FormSocio.lblNumero")} {socioSeleccionado.NumeroSocio} ({socioSeleccionado.Estado})";
            btnModificar.Enabled = true;
            btnBaja.Enabled = !dadoDeBaja;
            btnReactivar.Enabled = dadoDeBaja;
        }

        private void Limpiar()
        {
            socioSeleccionado = null;
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            MostrarEstado();
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

        // ------------------------------------------------------------ Reactivación (vuelve a dar de alta a un socio dado de baja)
        private void btnReactivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (socioSeleccionado == null) throw new Exception("Seleccione el socio a reactivar.");

                if (MessageBox.Show($"¿Confirma la reactivación del socio {socioSeleccionado.Apellido}, {socioSeleccionado.Nombre}?",
                                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_Socio.Reactivar(socioSeleccionado);
                MessageBox.Show("Socio reactivado correctamente. Ya puede volver a realizar préstamos.", "Reactivación de socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // ------------------------------------------------------------ Idioma
        public void ActualizarIdioma()
        {
            this.Text = bll_idioma.Traducir("FormSocio.Form");
            lblSeccionSocios.Text = bll_idioma.Traducir("FormSocio.lblSeccionSocios");
            lblBuscarDni.Text = bll_idioma.Traducir("FormSocio.lblBuscarDni");
            colSocNumero.HeaderText = bll_idioma.Traducir("FormSocio.colSocNumero");
            colSocApellido.HeaderText = bll_idioma.Traducir("FormSocio.colSocApellido");
            colSocNombre.HeaderText = bll_idioma.Traducir("FormSocio.colSocNombre");
            colSocDni.HeaderText = bll_idioma.Traducir("FormSocio.colSocDni");
            colSocEstado.HeaderText = bll_idioma.Traducir("FormSocio.colSocEstado");
            lblSeccionDatos.Text = bll_idioma.Traducir("FormSocio.lblSeccionDatos");
            lblNombre.Text = bll_idioma.Traducir("FormSocio.lblNombre");
            lblApellido.Text = bll_idioma.Traducir("FormSocio.lblApellido");
            lblDni.Text = bll_idioma.Traducir("FormSocio.lblDni");
            btnAlta.Text = bll_idioma.Traducir("FormSocio.btnAlta");
            btnModificar.Text = bll_idioma.Traducir("FormSocio.btnModificar");
            btnBaja.Text = bll_idioma.Traducir("FormSocio.btnBaja");
            btnReactivar.Text = bll_idioma.Traducir("FormSocio.btnReactivar");
            btnLimpiar.Text = bll_idioma.Traducir("FormSocio.btnLimpiar");
            btnCerrar.Text = bll_idioma.Traducir("FormSocio.btnCerrar");
            if (bll_Socio != null) MostrarEstado();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma.Desuscribir(this);
            base.OnFormClosed(e);
        }
    }
}
