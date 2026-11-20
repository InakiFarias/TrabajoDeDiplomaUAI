using System.Runtime.CompilerServices;
using BLL.BLL_SER;

namespace UI
{
    // Ayuda en línea reutilizable. Cada formulario la activa con una sola línea dentro de su
    // ActualizarIdioma_351FI:  AyudaFormulario_351FI.Aplicar_351FI(this, bll_idioma_351FI);
    //  - Agrega un botón "?" en la esquina superior derecha que muestra la ayuda general del formulario.
    //  - Asigna un tooltip a cada botón y opción de filtro del formulario.
    // Los textos viven en los archivos de idioma, con las claves:
    //  "<Formulario>.ayuda"                -> ayuda general del formulario
    //  "<Formulario>.<control>.ayuda"      -> tooltip del botón
    public static class AyudaFormulario_351FI
    {
        private const string NombreBoton_351FI = "btnAyudaFormulario_351FI";
        private const int Tamanio_351FI = 20;
        private const int Margen_351FI = 4;

        // Un ToolTip por formulario, liberado junto con él
        private static readonly ConditionalWeakTable<Form, ToolTip> tooltips_351FI = new();

        public static void Aplicar_351FI(Form formulario_351FI, BLL_Idioma_351FI idioma_351FI)
        {
            ToolTip tooltip = tooltips_351FI.GetValue(formulario_351FI, f => CrearTooltip_351FI());
            string claveForm = formulario_351FI.GetType().Name;

            AsegurarBotonAyuda_351FI(formulario_351FI, idioma_351FI, claveForm, tooltip);
            AsignarTooltips_351FI(formulario_351FI, formulario_351FI, idioma_351FI, claveForm, tooltip);
        }

        // Texto de ayuda general del formulario; vacío si no tiene clave
        public static string ObtenerAyuda_351FI(Form formulario_351FI, BLL_Idioma_351FI idioma_351FI)
        {
            string clave = formulario_351FI.GetType().Name + ".ayuda";
            string texto = idioma_351FI.Traducir_351FI(clave);
            return texto == clave ? string.Empty : texto;
        }

        // Muestra la ayuda general (la usa el botón "?" y el botón Ayuda del menú lateral)
        public static void Mostrar_351FI(Form formulario_351FI, BLL_Idioma_351FI idioma_351FI)
        {
            string texto = ObtenerAyuda_351FI(formulario_351FI, idioma_351FI);
            if (texto.Length == 0) return;
            string titulo = idioma_351FI.Traducir_351FI("Ayuda.titulo") + " - " + formulario_351FI.Text;
            MessageBox.Show(texto, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static ToolTip CrearTooltip_351FI()
        {
            return new ToolTip
            {
                AutoPopDelay = 12000,
                InitialDelay = 400,
                ReshowDelay = 200,
                ShowAlways = true
            };
        }

        private static void AsegurarBotonAyuda_351FI(Form formulario_351FI, BLL_Idioma_351FI idioma_351FI, string claveForm_351FI, ToolTip tooltip_351FI)
        {
            // El menú principal no lleva "?": su botón Ayuda del lateral cumple esa función
            if (formulario_351FI is FrmMenu_351FI) return;

            Button? boton = formulario_351FI.Controls[NombreBoton_351FI] as Button;
            if (boton == null)
            {
                Button nuevo = new Button
                {
                    Name = NombreBoton_351FI,
                    Text = Tema_351FI.Iconos_351FI.Ayuda,
                    Font = new Font(Tema_351FI.FamiliaIconos, 9F),
                    Size = new Size(Tamanio_351FI, Tamanio_351FI),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Tema_351FI.BordoClaro_351FI,
                    ForeColor = Tema_351FI.Bordo_351FI,
                    Cursor = Cursors.Hand,
                    TabStop = false,
                    Anchor = AnchorStyles.Top | AnchorStyles.Right
                };
                nuevo.FlatAppearance.BorderSize = 0;
                nuevo.FlatAppearance.MouseOverBackColor = Tema_351FI.Bordo_351FI;
                nuevo.MouseEnter += (s, e) => nuevo.ForeColor = Color.White;
                nuevo.MouseLeave += (s, e) => nuevo.ForeColor = Tema_351FI.Bordo_351FI;
                nuevo.Click += (s, e) => Mostrar_351FI(formulario_351FI, idioma_351FI);
                nuevo.Location = new Point(formulario_351FI.ClientSize.Width - Tamanio_351FI - Margen_351FI, 0);
                formulario_351FI.Controls.Add(nuevo);
                nuevo.BringToFront();
                boton = nuevo;
            }
            tooltip_351FI.SetToolTip(boton, idioma_351FI.Traducir_351FI("Ayuda.boton"));
        }

        private static void AsignarTooltips_351FI(Form formulario_351FI, Control contenedor_351FI, BLL_Idioma_351FI idioma_351FI, string claveForm_351FI, ToolTip tooltip_351FI)
        {
            foreach (Control control in contenedor_351FI.Controls)
            {
                if ((control is Button || control is RadioButton) && control.Name != NombreBoton_351FI)
                {
                    string clave = claveForm_351FI + "." + control.Name + ".ayuda";
                    string texto = idioma_351FI.Traducir_351FI(clave);
                    tooltip_351FI.SetToolTip(control, texto == clave ? null : texto);
                }
                if (control.HasChildren)
                    AsignarTooltips_351FI(formulario_351FI, control, idioma_351FI, claveForm_351FI, tooltip_351FI);
            }
        }
    }
}
