using BLL;
using Microsoft.VisualBasic;
using Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class FrmRoles : Form
    {
        BLL_Permiso bll_permiso;
        BLL_Familia bll_familia;
        BLL_Rol bll_rol;
        public FrmRoles()
        {
            InitializeComponent();
        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {
            bll_permiso = new BLL_Permiso();
            bll_familia = new BLL_Familia();
            bll_rol = new BLL_Rol();
            foreach (var control in Controls)
            {
                if (control is DataGridView grilla)
                {
                    grilla.MultiSelect = false;
                    grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            Mostrar(grillaPermisos, bll_permiso.Consultar());
            Mostrar(grillaFamilias, bll_familia.Consultar());
            Mostrar(grillaRoles, bll_rol.Consultar());
        }
        private void Mostrar(DataGridView grilla, object datos)
        {
            grilla.DataSource = null;
            grilla.DataSource = datos;
        }
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaOrigen.Rows.Count == 0) throw new Exception("No hay filas!");
                if (grillaDestino.Rows.Count == 0) throw new Exception("No hay filas!");

                if (radPermisoAFamilia.Checked)
                {
                    SER_Permiso permiso = grillaOrigen.SelectedRows[0].DataBoundItem as SER_Permiso;
                    SER_Familia familia = grillaDestino.SelectedRows[0].DataBoundItem as SER_Familia;
                    bll_familia.AgregarPermiso(familia, permiso);
                }
                MessageBox.Show("Asignación realizada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Interaction.InputBox("Nombre de familia:", "Agregando familia");
                if (nombre.Length == 0) throw new Exception("Nombre vacío!");
                SER_Familia familia = new SER_Familia(nombre);
                bll_familia.Agregar(familia);
                Mostrar(grillaFamilias, bll_familia.Consultar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Interaction.InputBox("Nombre de rol:", "Agregando roles");
                if (nombre.Length == 0) throw new Exception("Nombre vacío!");
                SER_Rol rol = new SER_Rol(nombre);
                bll_rol.Agregar(rol);
                Mostrar(grillaRoles, bll_rol.Consultar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarFamilia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROXIMAMENTE");
        }

        private void btnBorrarRol_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROXIMAMENTE");
        }

        private void radPermisoAFamilia_CheckedChanged(object sender, EventArgs e)
        {
            AlternarOrigenYDestino();
        }

        private void radPermisoARol_CheckedChanged(object sender, EventArgs e)
        {
            AlternarOrigenYDestino();
        }

        private void radFamiliaARol_CheckedChanged(object sender, EventArgs e)
        {
            AlternarOrigenYDestino();
        }

        private void radFamiliaAFamilia_CheckedChanged(object sender, EventArgs e)
        {
            AlternarOrigenYDestino();
        }
        private void AlternarOrigenYDestino()
        {
            if (radPermisoAFamilia.Checked)
            {
                Mostrar(grillaOrigen, bll_permiso.Consultar());
                Mostrar(grillaDestino, bll_familia.Consultar());
            }
            else if (radPermisoARol.Checked)
            {
                Mostrar(grillaOrigen, bll_permiso.Consultar());
                Mostrar(grillaDestino, bll_rol.Consultar());
            }
            else if (radFamiliaARol.Checked)
            {
                Mostrar(grillaOrigen, bll_familia.Consultar());
                Mostrar(grillaDestino, bll_rol.Consultar());
            }
            else if (radFamiliaAFamilia.Checked)
            {
                Mostrar(grillaOrigen, bll_familia.Consultar());
                Mostrar(grillaDestino, bll_familia.Consultar());
            }
        }

        private void grillaFamilias_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                SER_Familia familia = grillaFamilias.SelectedRows[0].DataBoundItem as SER_Familia;
                MostrarArbol(familia);
            }
            catch (Exception) { }
        }
        private void MostrarArbol(SER_Familia familia)
        {
            tvNodosComposite.Nodes.Clear();

            SER_Familia arbol =
                bll_familia.ObtenerArbol(familia);

            TreeNode nodoRaiz =
                tvNodosComposite.Nodes.Add(arbol.Nombre);

            foreach (SER_Rol hijo in arbol.Hijos)
            {
                AgregarNodo(nodoRaiz, hijo);
            }

            tvNodosComposite.ExpandAll();
        }
        private void AgregarNodo(TreeNode nodoPadre, SER_Rol componente)
        {
            TreeNode nodo = nodoPadre.Nodes.Add(componente.Nombre);
            if (componente is SER_Familia familia)
            {
                foreach (SER_Rol hijo in familia.Hijos)
                {
                    AgregarNodo(nodo, hijo);
                }
            }
        }
    }
}
