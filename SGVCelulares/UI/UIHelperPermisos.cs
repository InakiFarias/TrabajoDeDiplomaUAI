using BLL;
using Servicio;

namespace UI
{
    public static class UIHelperPermisos
    {
        public static void AplicarPermisos(Control.ControlCollection controles)
        {
            BLL_Rol bll_rol = new BLL_Rol();
            foreach (Control c in controles)
            {
                if (c.Tag is string permiso)
                {
                    c.Visible = bll_rol.TienePermiso(SER_SesionManager.ObtenerSesion().Usuario.Rol, permiso);
                }
                if (c.HasChildren) AplicarPermisos(c.Controls);
            }
        }
    }
}
