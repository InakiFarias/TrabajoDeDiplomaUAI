using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace UI
{
    public enum EstiloBoton_351FI
    {
        Primario,
        Secundario,
        Peligro,
        Menu
    }

    // Botón redondeado con ícono de Segoe MDL2 Assets. El estilo Menu se usa en la barra lateral.
    public class BotonSGB_351FI : Button
    {
        private EstiloBoton_351FI estilo_351FI = EstiloBoton_351FI.Primario;
        private string icono_351FI = "";
        private bool activo_351FI;
        private bool hover_351FI;
        private bool presionado_351FI;

        public BotonSGB_351FI()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
            UseVisualStyleBackColor = false;
        }

        [Category("SGB"), DefaultValue(EstiloBoton_351FI.Primario)]
        public EstiloBoton_351FI Estilo_351FI
        {
            get => estilo_351FI;
            set { estilo_351FI = value; Invalidate(); }
        }

        // Carácter de la fuente Segoe MDL2 Assets (ver las constantes de Tema.Iconos)
        [Category("SGB"), DefaultValue("")]
        public string Icono_351FI
        {
            get => icono_351FI;
            set { icono_351FI = value ?? ""; Invalidate(); }
        }

        // Marca la opción del menú lateral que corresponde a la pantalla abierta
        [Category("SGB"), DefaultValue(false)]
        public bool Activo_351FI
        {
            get => activo_351FI;
            set { activo_351FI = value; Invalidate(); }
        }

        protected override void OnMouseEnter(EventArgs e) { hover_351FI = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { hover_351FI = false; presionado_351FI = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnMouseDown(MouseEventArgs e) { presionado_351FI = true; Invalidate(); base.OnMouseDown(e); }
        protected override void OnMouseUp(MouseEventArgs e) { presionado_351FI = false; Invalidate(); base.OnMouseUp(e); }
        protected override void OnEnabledChanged(EventArgs e) { Invalidate(); base.OnEnabledChanged(e); }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Tema_351FI.FondoEfectivo_351FI(Parent));

            ObtenerColores_351FI(out Color fondo, out Color texto, out Color borde);

            Rectangle r = new Rectangle(0, 0, Width - 1, Height - 1);
            int radio = estilo_351FI == EstiloBoton_351FI.Menu ? 6 : 8;
            using (GraphicsPath path = Tema_351FI.Redondeado_351FI(r, radio))
            {
                using (SolidBrush brush = new SolidBrush(fondo))
                    g.FillPath(brush, path);
                if (borde != Color.Empty)
                    using (Pen pen = new Pen(borde))
                        g.DrawPath(pen, path);
            }

            // Franja bordó de la opción activa del menú
            if (estilo_351FI == EstiloBoton_351FI.Menu && activo_351FI)
                using (SolidBrush franja = new SolidBrush(Tema_351FI.Bordo_351FI))
                    g.FillRectangle(franja, 0, 6, 4, Height - 12);

            bool alineadoIzquierda = estilo_351FI == EstiloBoton_351FI.Menu;
            Size tamTexto = TextRenderer.MeasureText(Text, Font);
            int anchoIcono = icono_351FI == "" ? 0 : 26;
            int x = alineadoIzquierda ? 16 : (Width - anchoIcono - tamTexto.Width) / 2;

            if (icono_351FI != "")
            {
                using Font fuenteIcono = new Font(Tema_351FI.FamiliaIconos, Font.Size + 1F);
                Rectangle rIcono = new Rectangle(x, 0, anchoIcono, Height);
                TextRenderer.DrawText(g, icono_351FI, fuenteIcono, rIcono, texto, TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPadding);
            }

            Rectangle rTexto = new Rectangle(x + anchoIcono, 0, Width - x - anchoIcono - 4, Height);
            TextRenderer.DrawText(g, Text, Font, rTexto, texto, TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
        }

        private void ObtenerColores_351FI(out Color fondo_351FI, out Color texto_351FI, out Color borde_351FI)
        {
            borde_351FI = Color.Empty;
            switch (estilo_351FI)
            {
                case EstiloBoton_351FI.Secundario:
                    fondo_351FI = presionado_351FI ? Tema_351FI.Borde_351FI : hover_351FI ? Tema_351FI.FondoSuave_351FI : Color.White;
                    texto_351FI = Tema_351FI.Texto_351FI;
                    borde_351FI = Tema_351FI.Borde_351FI;
                    break;
                case EstiloBoton_351FI.Peligro:
                    fondo_351FI = presionado_351FI || hover_351FI ? Tema_351FI.PeligroOscuro_351FI : Tema_351FI.Peligro_351FI;
                    texto_351FI = Color.White;
                    break;
                case EstiloBoton_351FI.Menu:
                    fondo_351FI = activo_351FI || hover_351FI ? Tema_351FI.LateralHover_351FI : Tema_351FI.Lateral_351FI;
                    texto_351FI = activo_351FI ? Color.White : Tema_351FI.LateralTexto_351FI;
                    break;
                default:
                    fondo_351FI = presionado_351FI || hover_351FI ? Tema_351FI.BordoOscuro_351FI : Tema_351FI.Bordo_351FI;
                    texto_351FI = Color.White;
                    break;
            }

            if (!Enabled)
            {
                fondo_351FI = estilo_351FI == EstiloBoton_351FI.Menu ? Tema_351FI.Lateral_351FI : Tema_351FI.FondoSuave_351FI;
                texto_351FI = estilo_351FI == EstiloBoton_351FI.Menu ? Tema_351FI.LateralSeccion_351FI : Color.FromArgb(156, 163, 175);
                borde_351FI = estilo_351FI == EstiloBoton_351FI.Menu ? Color.Empty : Tema_351FI.Borde_351FI;
            }
        }
    }
}
