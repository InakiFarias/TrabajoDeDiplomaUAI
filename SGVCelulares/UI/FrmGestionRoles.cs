using Microsoft.VisualBasic;
using Servicio;
using BLL;

namespace UI
{
    public partial class FrmGestionRoles : Form, IObservadorIdioma
    {
        BLL_Permiso bll_permiso;
        BLL_Familia bll_familia;
        BLL_Rol bll_rol;
        List<SER_Rol> componentes;
        BLL_Idioma bll_idioma = new BLL_Idioma();

        Dictionary<int, SER_Familia> cacheFamilias;
        public FrmGestionRoles()
        {
            InitializeComponent();
            bll_idioma.Suscribir(this);
            ActualizarIdioma();
        }

        private void FrmGestionRoles_Load(object sender, EventArgs e)
        {
            bll_permiso = new BLL_Permiso();
            bll_familia = new BLL_Familia();
            bll_rol = new BLL_Rol();

            componentes = new List<SER_Rol>();
            cacheFamilias = new Dictionary<int, SER_Familia>();
            foreach (var control in Controls)
            {
                if (control is DataGridView grilla)
                {
                    grilla.MultiSelect = false;
                    grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            componentes.AddRange(bll_permiso.Consultar());
            componentes.AddRange(bll_familia.Consultar());
            Mostrar(clbComponentes, componentes);
        }
        private void Mostrar(CheckedListBox listbox, object datos)
        {
            listbox.DataSource = null;
            listbox.DataSource = datos;
        }
        private void clbComponentes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke(new Action(ActualizarTreeView));
        }

        private void ActualizarTreeView()
        {
            tvNodosComposite.BeginUpdate();
            tvNodosComposite.Nodes.Clear();
            string nombreRaiz = string.IsNullOrWhiteSpace(txtNombreFamilia.Text) ? "Nuevo rol" : txtNombreFamilia.Text;
            TreeNode raiz = new TreeNode(nombreRaiz);

            foreach (SER_Rol componente in clbComponentes.CheckedItems)
            {
                if (componente is SER_Familia familia)
                {
                    SER_Familia familiaCompleta = bll_familia.ConsultarPorId(familia);
                    AgregarNodo(raiz, ObtenerFamiliaCompleta(familia));
                }
                else
                {
                    AgregarNodo(raiz, componente);
                }
            }
            tvNodosComposite.Nodes.Add(raiz);
            raiz.ExpandAll();
            tvNodosComposite.EndUpdate();
        }
        private void txtNombreFamilia_TextChanged(object sender, EventArgs e)
        {
            ActualizarTreeView();
        }
        private void AgregarNodo(TreeNode nodoPadre, SER_Rol componente)
        {
            TreeNode nodo = new TreeNode(componente.Nombre);
            nodoPadre.Nodes.Add(nodo);
            if (componente is SER_Familia familia)
            {
                foreach (SER_Rol hijo in familia.Componentes)
                {
                    AgregarNodo(nodo, hijo);
                }
            }
        }
        private SER_Familia ObtenerFamiliaCompleta(SER_Familia familia)
        {
            if (!cacheFamilias.ContainsKey(familia.Id))
            {
                cacheFamilias[familia.Id] = bll_familia.ConsultarPorId(familia);
            }
            return cacheFamilias[familia.Id];
        }
        private void btnSalir_Click(object sender, EventArgs e) => this.Close();

        private void btnCrearFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreFamilia.Text.Length == 0) throw new Exception("El nombre del rol no puede estar vacío!");
                SER_Rol rol = new SER_Rol(txtNombreFamilia.Text);
                List<SER_Rol> componentes = new List<SER_Rol>();
                foreach (SER_Rol c in clbComponentes.CheckedItems)
                {
                    componentes.Add(c);
                }

                bll_rol.Agregar(rol, componentes);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarSeleccionados_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbComponentes.Items.Count; i++)
            {
                clbComponentes.SetItemChecked(i, false);
            }
            clbComponentes.ClearSelected();
        }
        public void ActualizarIdioma()
        {
            this.Text = bll_idioma.Traducir("FrmGestionRoles.Form");
            label1.Text = bll_idioma.Traducir("FrmGestionRoles.label1");
            label3.Text = bll_idioma.Traducir("FrmGestionRoles.label3");
            label4.Text = bll_idioma.Traducir("FrmGestionRoles.label4");
            label2.Text = bll_idioma.Traducir("FrmGestionRoles.label2");
            btnCrearFamilia.Text = bll_idioma.Traducir("FrmGestionRoles.btnCrearFamilia");
            radRol.Text = bll_idioma.Traducir("FrmGestionRoles.radRol");
            radFamilia.Text = bll_idioma.Traducir("FrmGestionRoles.radFamilia");
            btnEliminarSeleccionados.Text = bll_idioma.Traducir("FrmGestionRoles.btnEliminarSeleccionados");
            btnSalir.Text = bll_idioma.Traducir("FrmGestionRoles.btnSalir");
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bll_idioma.Desuscribir(this);
            base.OnFormClosed(e);
        }
    }
}
