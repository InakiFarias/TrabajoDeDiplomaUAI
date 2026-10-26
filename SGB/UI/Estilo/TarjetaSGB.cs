using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace UI
{
    // Panel blanco con esquinas redondeadas y borde fino, para agrupar cada sección de una pantalla
    public class TarjetaSGB : Panel
    {
        private int radio = 10;

        public TarjetaSGB()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw, true);
            BackColor = Color.White;
            Padding = new Padding(20);
        }

        [Category("SGB"), DefaultValue(10)]
        public int Radio
        {
            get => radio;
            set { radio = value; Invalidate(); }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Tema.FondoEfectivo(Parent));

            Rectangle r = new Rectangle(0, 0, Width - 1, Height - 1);
            using GraphicsPath path = Tema.Redondeado(r, radio);
            using (SolidBrush brush = new SolidBrush(BackColor))
                g.FillPath(brush, path);
            using (Pen pen = new Pen(Tema.Borde))
                g.DrawPath(pen, path);
        }
    }
}
