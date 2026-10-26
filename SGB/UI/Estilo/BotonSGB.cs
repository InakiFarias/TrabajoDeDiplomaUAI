using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace UI
{
    public enum EstiloBoton
    {
        Primario,
        Secundario,
        Peligro,
        Menu
    }

    // Botón redondeado con ícono de Segoe MDL2 Assets. El estilo Menu se usa en la barra lateral.
    public class BotonSGB : Button
    {
        private EstiloBoton estilo = EstiloBoton.Primario;
        private string icono = "";
        private bool activo;
        private bool hover;
        private bool presionado;

        public BotonSGB()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
            UseVisualStyleBackColor = false;
        }

        [Category("SGB"), DefaultValue(EstiloBoton.Primario)]
        public EstiloBoton Estilo
        {
            get => estilo;
            set { estilo = value; Invalidate(); }
        }

        // Carácter de la fuente Segoe MDL2 Assets (ver las constantes de Tema.Iconos)
        [Category("SGB"), DefaultValue("")]
        public string Icono
        {
            get => icono;
            set { icono = value ?? ""; Invalidate(); }
        }

        // Marca la opción del menú lateral que corresponde a la pantalla abierta
        [Category("SGB"), DefaultValue(false)]
        public bool Activo
        {
            get => activo;
            set { activo = value; Invalidate(); }
        }

        protected override void OnMouseEnter(EventArgs e) { hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { hover = false; presionado = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnMouseDown(MouseEventArgs e) { presionado = true; Invalidate(); base.OnMouseDown(e); }
        protected override void OnMouseUp(MouseEventArgs e) { presionado = false; Invalidate(); base.OnMouseUp(e); }
        protected override void OnEnabledChanged(EventArgs e) { Invalidate(); base.OnEnabledChanged(e); }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Tema.FondoEfectivo(Parent));

            ObtenerColores(out Color fondo, out Color texto, out Color borde);

            Rectangle r = new Rectangle(0, 0, Width - 1, Height - 1);
            int radio = estilo == EstiloBoton.Menu ? 6 : 8;
            using (GraphicsPath path = Tema.Redondeado(r, radio))
            {
                using (SolidBrush brush = new SolidBrush(fondo))
                    g.FillPath(brush, path);
                if (borde != Color.Empty)
                    using (Pen pen = new Pen(borde))
                        g.DrawPath(pen, path);
            }

            // Franja bordó de la opción activa del menú
            if (estilo == EstiloBoton.Menu && activo)
                using (SolidBrush franja = new SolidBrush(Tema.Bordo))
                    g.FillRectangle(franja, 0, 6, 4, Height - 12);

            bool alineadoIzquierda = estilo == EstiloBoton.Menu;
            Size tamTexto = TextRenderer.MeasureText(Text, Font);
            int anchoIcono = icono == "" ? 0 : 26;
            int x = alineadoIzquierda ? 16 : (Width - anchoIcono - tamTexto.Width) / 2;

            if (icono != "")
            {
                using Font fuenteIcono = new Font(Tema.FamiliaIconos, Font.Size + 1F);
                Rectangle rIcono = new Rectangle(x, 0, anchoIcono, Height);
                TextRenderer.DrawText(g, icono, fuenteIcono, rIcono, texto, TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPadding);
            }

            Rectangle rTexto = new Rectangle(x + anchoIcono, 0, Width - x - anchoIcono - 4, Height);
            TextRenderer.DrawText(g, Text, Font, rTexto, texto, TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
        }

        private void ObtenerColores(out Color fondo, out Color texto, out Color borde)
        {
            borde = Color.Empty;
            switch (estilo)
            {
                case EstiloBoton.Secundario:
                    fondo = presionado ? Tema.Borde : hover ? Tema.FondoSuave : Color.White;
                    texto = Tema.Texto;
                    borde = Tema.Borde;
                    break;
                case EstiloBoton.Peligro:
                    fondo = presionado || hover ? Tema.PeligroOscuro : Tema.Peligro;
                    texto = Color.White;
                    break;
                case EstiloBoton.Menu:
                    fondo = activo || hover ? Tema.LateralHover : Tema.Lateral;
                    texto = activo ? Color.White : Tema.LateralTexto;
                    break;
                default:
                    fondo = presionado || hover ? Tema.BordoOscuro : Tema.Bordo;
                    texto = Color.White;
                    break;
            }

            if (!Enabled)
            {
                fondo = estilo == EstiloBoton.Menu ? Tema.Lateral : Tema.FondoSuave;
                texto = estilo == EstiloBoton.Menu ? Tema.LateralSeccion : Color.FromArgb(156, 163, 175);
                borde = estilo == EstiloBoton.Menu ? Color.Empty : Tema.Borde;
            }
        }
    }
}
