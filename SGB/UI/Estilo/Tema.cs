using System.Drawing.Drawing2D;

namespace UI
{
    // Paleta, tipografía e íconos del sistema. Todos los colores de la interfaz salen de acá.
    public static class Tema
    {
        // ------------------------------------------------ Colores
        public static readonly Color Bordo = Color.FromArgb(123, 30, 46);
        public static readonly Color BordoOscuro = Color.FromArgb(96, 22, 35);
        public static readonly Color BordoClaro = Color.FromArgb(248, 231, 234);

        public static readonly Color Fondo = Color.FromArgb(244, 245, 247);
        public static readonly Color Tarjeta = Color.White;
        public static readonly Color Borde = Color.FromArgb(226, 228, 233);
        public static readonly Color FondoSuave = Color.FromArgb(243, 244, 246);

        public static readonly Color Texto = Color.FromArgb(31, 41, 55);
        public static readonly Color TextoSecundario = Color.FromArgb(107, 114, 128);

        public static readonly Color Lateral = Color.FromArgb(33, 37, 41);
        public static readonly Color LateralHover = Color.FromArgb(48, 53, 59);
        public static readonly Color LateralTexto = Color.FromArgb(209, 213, 219);
        public static readonly Color LateralSeccion = Color.FromArgb(134, 142, 150);

        public static readonly Color Peligro = Color.FromArgb(185, 28, 28);
        public static readonly Color PeligroOscuro = Color.FromArgb(153, 27, 27);
        public static readonly Color Advertencia = Color.FromArgb(180, 83, 9);

        // ------------------------------------------------ Tipografía
        public const string Familia = "Segoe UI";
        public const string FamiliaIconos = "Segoe MDL2 Assets";

        public static readonly Font Fuente = new Font(Familia, 11F);
        public static readonly Font FuenteSemibold = new Font("Segoe UI Semibold", 11F);
        public static readonly Font FuenteIconos = new Font(FamiliaIconos, 12F);

        // ------------------------------------------------ Íconos (Segoe MDL2 Assets)
        public static class Iconos
        {
            public const string Agregar = "\uE710";
            public const string Editar = "\uE70F";
            public const string Eliminar = "\uE74D";
            public const string Buscar = "\uE721";
            public const string Confirmar = "\uE73E";
            public const string Cancelar = "\uE711";
            public const string Cerrar = "\uE8BB";
            public const string Limpiar = "\uE894";
            public const string Guardar = "\uE74E";
            public const string Restaurar = "\uE777";
            public const string Imprimir = "\uE749";
            public const string Filtrar = "\uE71C";
            public const string Inicio = "\uE80F";
            public const string Prestamo = "\uE8F1";
            public const string Devolucion = "\uE7A7";
            public const string Multa = "\uE8C7";
            public const string Donacion = "\uEB51";
            public const string Socios = "\uE716";
            public const string Libros = "\uE82D";
            public const string Ejemplares = "\uE8A5";
            public const string Usuarios = "\uE77B";
            public const string Bitacora = "\uE81C";
            public const string Roles = "\uE8D7";
            public const string Respaldo = "\uE74E";
            public const string Reportes = "\uE9D2";
            public const string Ayuda = "\uE897";
            public const string CambiarUsuario = "\uE748";
            public const string Clave = "\uE72E";
            public const string CerrarSesion = "\uE7E8";
            public const string Desbloquear = "\uE785";
            public const string Activar = "\uE8FB";
        }

        // ------------------------------------------------ Utilidades de dibujo

        // Primer color de fondo no transparente subiendo por los contenedores
        public static Color FondoEfectivo(Control? control)
        {
            while (control != null)
            {
                if (control.BackColor.A == 255) return control.BackColor;
                control = control.Parent;
            }
            return Fondo;
        }
        public static GraphicsPath Redondeado(Rectangle r, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radio * 2;
            if (d <= 0 || r.Width < d || r.Height < d)
            {
                path.AddRectangle(r);
                return path;
            }
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
