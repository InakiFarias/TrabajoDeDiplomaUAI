using Microsoft.VisualBasic;
using Servicio;
using BLL;

namespace UI
{
    public partial class FrmGestionRoles : Form
    {
        BLL_Permiso bll_permiso;
        BLL_Familia bll_familia;
        List<SER_Rol> componentes;

        Dictionary<int, SER_Familia> cacheFamilias;
        public FrmGestionRoles()
        {
            InitializeComponent();
        }

        private void FrmGestionRoles_Load(object sender, EventArgs e)
        {
            bll_permiso = new BLL_Permiso();
            bll_familia = new BLL_Familia();
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

        }

        private void btnEliminarSeleccionados_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < clbComponentes.Items.Count; i++)
            {
                clbComponentes.SetItemChecked(i, false);
            }
            clbComponentes.ClearSelected();
        }
    }
}
