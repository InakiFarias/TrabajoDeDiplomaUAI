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
        BLL_Rol bll_rol;
        public FrmGestionRoles()
        {
            InitializeComponent();
        }

        private void FrmGestionRoles_Load(object sender, EventArgs e)
        {
            bll_permiso = new BLL_Permiso();
            bll_familia = new BLL_Familia();
            bll_rol = new BLL_Rol();
            componentes = new List<SER_Rol>();
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
            tvNodosComposite.Nodes.Clear();
            string nombre = string.IsNullOrWhiteSpace(txtNombreFamilia.Text) ? "Nuevo rol" : txtNombreFamilia.Text;
            TreeNode raiz = new TreeNode(nombre);
            foreach (SER_Rol c in clbComponentes.CheckedItems)
            {
                AgregarNodo(raiz, c);
            }
            tvNodosComposite.Nodes.Add(raiz);
            raiz.ExpandAll();
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
        private void txtNombreFamilia_TextChanged(object sender, EventArgs e)
        {
            ActualizarTreeView();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
