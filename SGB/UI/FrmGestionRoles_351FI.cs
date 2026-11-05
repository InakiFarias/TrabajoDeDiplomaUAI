using Microsoft.VisualBasic;
using Servicio;
using BLL.BLL_SER;

namespace UI
{
    public partial class FrmGestionRoles_351FI : Form, IObservadorIdioma_351FI
    {
        BLL_Permiso_351FI bll_permiso_351FI;
        BLL_Familia_351FI bll_familia_351FI;
        BLL_Rol_351FI bll_rol_351FI;
        List<SER_Componente_351FI> componentes_351FI;
        BLL_Idioma_351FI bll_idioma_351FI = new BLL_Idioma_351FI();

        public FrmGestionRoles_351FI()
        {
            InitializeComponent();
            bll_idioma_351FI.Suscribir_351FI(this);
            ActualizarIdioma_351FI();
        }

        private void FrmGestionRoles_351FI_Load(object sender_351FI, EventArgs e_351FI)
        {
            clbComponentes_351FI.CheckOnClick = true;
            bll_permiso_351FI = new BLL_Permiso_351FI();
            bll_familia_351FI = new BLL_Familia_351FI();
            bll_rol_351FI = new BLL_Rol_351FI();

            foreach (var control in Controls)
            {
                if (control is DataGridView grilla)
                {
                    grilla.MultiSelect = false;
                    grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            CargarDatos_351FI();

            SER_Usuario_351FI usuario = SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI;
            btnBorrarRol_351FI.Enabled = usuario.Rol_351FI.TienePermiso_351FI("Eliminar Rol");
            btnBorrarFamilia_351FI.Enabled = usuario.Rol_351FI.TienePermiso_351FI("Eliminar Familia");
            AplicarPermisoCrear_351FI();

            radRol_351FI.CheckedChanged += (s, e) => AplicarPermisoCrear_351FI();
            radFamilia_351FI.CheckedChanged += (s, e) => AplicarPermisoCrear_351FI();
        }
        private void CargarDatos_351FI()
        {
            componentes_351FI = new List<SER_Componente_351FI>();
            componentes_351FI.AddRange(bll_permiso_351FI.Consultar_351FI());
            componentes_351FI.AddRange(bll_familia_351FI.Consultar_351FI());

            cbxRoles_351FI.Items.Clear();
            foreach (SER_Rol_351FI rol in bll_rol_351FI.Consultar_351FI())
                cbxRoles_351FI.Items.Add(rol);

            cbxFamilias_351FI.Items.Clear();
            foreach (SER_Componente_351FI c in componentes_351FI)
                if (c is SER_Familia_351FI f)
                    cbxFamilias_351FI.Items.Add(f);

            Mostrar_351FI(clbComponentes_351FI, componentes_351FI);
        }
        private void Mostrar_351FI(CheckedListBox listbox_351FI, object datos_351FI)
        {
            listbox_351FI.DataSource = null;
            listbox_351FI.DataSource = datos_351FI;
        }
        private void AplicarPermisoCrear_351FI()
        {
            SER_Usuario_351FI usuario = SER_SesionManager_351FI.ObtenerSesion_351FI().Usuario_351FI;

            if (radRol_351FI.Checked)
                btnCrear_351FI.Enabled = usuario.Rol_351FI.TienePermiso_351FI("Crear Rol");
            else
                btnCrear_351FI.Enabled = usuario.Rol_351FI.TienePermiso_351FI("Crear Familia");
        }

        private void clbComponentes_351FI_ItemCheck(object sender_351FI, ItemCheckEventArgs e_351FI)
        {
            BeginInvoke(new Action(ActualizarTreeView_351FI));
        }

        private void ActualizarTreeView_351FI()
        {
            tvNodosComposite_351FI.BeginUpdate();
            tvNodosComposite_351FI.Nodes.Clear();
            string nombreRaiz = string.IsNullOrWhiteSpace(txtNombreFamilia_351FI.Text) ? "Nuevo rol" : txtNombreFamilia_351FI.Text;
            TreeNode raiz = new TreeNode(nombreRaiz);

            foreach (SER_Componente_351FI componente in clbComponentes_351FI.CheckedItems)
            {
                AgregarNodo_351FI(raiz, componente);
            }
            tvNodosComposite_351FI.Nodes.Add(raiz);
            raiz.ExpandAll();
            tvNodosComposite_351FI.EndUpdate();
        }
        private void txtNombreFamilia_351FI_TextChanged(object sender_351FI, EventArgs e_351FI)
        {
            ActualizarTreeView_351FI();
        }
        private void AgregarNodo_351FI(TreeNode nodoPadre_351FI, SER_Componente_351FI componente_351FI)
        {
            TreeNode nodo = new TreeNode(componente_351FI.Nombre_351FI);
            nodoPadre_351FI.Nodes.Add(nodo);
            if (componente_351FI is SER_Familia_351FI familia)
            {
                foreach (SER_Componente_351FI hijo in familia.Componentes_351FI)
                {
                    AgregarNodo_351FI(nodo, hijo);
                }
            }
        }

        private void btnCrear_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (radRol_351FI.Checked)
                {
                    if (txtNombreFamilia_351FI.Text.Length == 0) throw new Exception("El nombre del rol no puede estar vacío!");
                    SER_Rol_351FI rol = new SER_Rol_351FI(txtNombreFamilia_351FI.Text);
                    List<SER_Componente_351FI> permisos = new List<SER_Componente_351FI>();
                    foreach (SER_Componente_351FI c in clbComponentes_351FI.CheckedItems)
                    {
                        permisos.Add(c);
                    }

                    bll_rol_351FI.Agregar_351FI(rol, permisos);
                    MessageBox.Show($"El rol {rol.Nombre_351FI} se creó con éxito!", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos_351FI();
                    ActualizarTreeView_351FI();
                    txtNombreFamilia_351FI.Text = "";
                }
                else
                {
                    if (txtNombreFamilia_351FI.Text.Length == 0) throw new Exception("El nombre de la familia no puede estar vacía!");
                    SER_Familia_351FI familia = new SER_Familia_351FI(txtNombreFamilia_351FI.Text);
                    List<SER_Componente_351FI> permisos = new List<SER_Componente_351FI>();
                    foreach (SER_Componente_351FI c in clbComponentes_351FI.CheckedItems)
                    {
                        permisos.Add(c);
                    }

                    bll_familia_351FI.Agregar_351FI(familia, permisos);
                    MessageBox.Show($"La familia {familia.Nombre_351FI} se creó con éxito!", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos_351FI();
                    ActualizarTreeView_351FI();
                    txtNombreFamilia_351FI.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarSeleccionados_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            for (int i = 0; i < clbComponentes_351FI.Items.Count; i++)
            {
                clbComponentes_351FI.SetItemChecked(i, false);
            }
            clbComponentes_351FI.ClearSelected();
        }
        public void ActualizarIdioma_351FI()
        {
            this.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionRoles_351FI.Form");
            label1_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionRoles_351FI.label1_351FI");
            label3_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionRoles_351FI.label3_351FI");
            label4_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionRoles_351FI.label4_351FI");
            label5_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionRoles_351FI.label5_351FI");
            label2_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionRoles_351FI.label2_351FI");
            btnCrear_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionRoles_351FI.btnCrear_351FI");
            radRol_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionRoles_351FI.radRol_351FI");
            radFamilia_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionRoles_351FI.radFamilia_351FI");
            btnEliminarSeleccionados_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionRoles_351FI.btnEliminarSeleccionados_351FI");
            btnSalir_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionRoles_351FI.btnSalir_351FI");
            label6_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionRoles_351FI.label6_351FI");
            btnBorrarRol_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionRoles_351FI.btnBorrarRol_351FI");
            btnBorrarFamilia_351FI.Text = bll_idioma_351FI.Traducir_351FI("FrmGestionRoles_351FI.btnBorrarFamilia_351FI");
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma_351FI.Desuscribir_351FI(this);
            base.OnFormClosed(e);
        }
        private void btnSalir_351FI_Click(object sender_351FI, EventArgs e_351FI) => this.Close();
        private void MostrarComponentesEnTreeView_351FI(string nombreRaiz_351FI, List<SER_Componente_351FI> componentes_351FI)
        {
            tvNodosComposite_351FI.BeginUpdate();
            tvNodosComposite_351FI.Nodes.Clear();

            TreeNode raiz = new TreeNode(nombreRaiz_351FI);
            foreach (SER_Componente_351FI componente in componentes_351FI)
                AgregarNodo_351FI(raiz, componente);

            tvNodosComposite_351FI.Nodes.Add(raiz);
            raiz.ExpandAll();
            tvNodosComposite_351FI.EndUpdate();
        }
        private void MostrarRolEnTreeView_351FI(SER_Rol_351FI rol_351FI) =>
            MostrarComponentesEnTreeView_351FI(rol_351FI.Nombre_351FI, rol_351FI.Componentes_351FI);
        private void cbxRoles_351FI_SelectedIndexChanged(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (cbxRoles_351FI.SelectedItem is SER_Rol_351FI rol)
                {
                    MostrarRolEnTreeView_351FI(rol);
                }
            }
            catch (Exception) { }
        }

        private void cbxFamilias_351FI_SelectedIndexChanged(object sender_351FI, EventArgs e_351FI)
        {
            if (cbxFamilias_351FI.SelectedItem is SER_Familia_351FI familia)
                MostrarComponentesEnTreeView_351FI(familia.Nombre_351FI, familia.Componentes_351FI);
        }

        private void btnBorrarRol_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (cbxRoles_351FI.SelectedItem is not SER_Rol_351FI rol)
                    throw new Exception("Seleccioná un rol para borrar.");

                if (MessageBox.Show($"¿Seguro que querés borrar el rol '{rol.Nombre_351FI}'?",
                        "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_rol_351FI.Borrar_351FI(rol);
                MessageBox.Show($"El rol '{rol.Nombre_351FI}' se borró con éxito!", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombreFamilia_351FI.Text = "";
                tvNodosComposite_351FI.Nodes.Clear();
                CargarDatos_351FI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarFamilia_351FI_Click(object sender_351FI, EventArgs e_351FI)
        {
            try
            {
                if (cbxFamilias_351FI.SelectedItem is not SER_Familia_351FI familia)
                    throw new Exception("Seleccioná una familia para borrar.");

                if (MessageBox.Show($"¿Seguro que querés borrar la familia '{familia.Nombre_351FI}'?",
                        "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                bll_familia_351FI.Borrar_351FI(familia);
                MessageBox.Show($"La familia '{familia.Nombre_351FI}' se borró con éxito!", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombreFamilia_351FI.Text = "";
                tvNodosComposite_351FI.Nodes.Clear();
                CargarDatos_351FI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
