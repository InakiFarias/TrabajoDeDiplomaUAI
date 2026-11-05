using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace UI
{
    // Panel blanco con esquinas redondeadas y borde fino, para agrupar cada sección de una pantalla
    public class TarjetaSGB_351FI : Panel
    {
        private int radio_351FI = 10;

        public TarjetaSGB_351FI()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw, true);
            BackColor = Color.White;
            Padding = new Padding(20);
        }

        [Category("SGB"), DefaultValue(10)]
        public int Radio_351FI
        {
            get => radio_351FI;
            set { radio_351FI = value; Invalidate(); }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Tema_351FI.FondoEfectivo_351FI(Parent));

            Rectangle r = new Rectangle(0, 0, Width - 1, Height - 1);
            using GraphicsPath path = Tema_351FI.Redondeado_351FI(r, radio_351FI);
            using (SolidBrush brush = new SolidBrush(BackColor))
                g.FillPath(brush, path);
            using (Pen pen = new Pen(Tema_351FI.Borde_351FI))
                g.DrawPath(pen, path);
        }
    }
}
