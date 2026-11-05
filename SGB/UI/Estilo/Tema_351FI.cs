using System.Drawing.Drawing2D;

namespace UI
{
    // Paleta, tipografía e íconos del sistema. Todos los colores de la interfaz salen de acá.
    public static class Tema_351FI
    {
        // ------------------------------------------------ Colores
        public static readonly Color Bordo_351FI = Color.FromArgb(123, 30, 46);
        public static readonly Color BordoOscuro_351FI = Color.FromArgb(96, 22, 35);
        public static readonly Color BordoClaro_351FI = Color.FromArgb(248, 231, 234);

        public static readonly Color Fondo_351FI = Color.FromArgb(244, 245, 247);
        public static readonly Color Tarjeta_351FI = Color.White;
        public static readonly Color Borde_351FI = Color.FromArgb(226, 228, 233);
        public static readonly Color FondoSuave_351FI = Color.FromArgb(243, 244, 246);

        public static readonly Color Texto_351FI = Color.FromArgb(31, 41, 55);
        public static readonly Color TextoSecundario_351FI = Color.FromArgb(107, 114, 128);

        public static readonly Color Lateral_351FI = Color.FromArgb(33, 37, 41);
        public static readonly Color LateralHover_351FI = Color.FromArgb(48, 53, 59);
        public static readonly Color LateralTexto_351FI = Color.FromArgb(209, 213, 219);
        public static readonly Color LateralSeccion_351FI = Color.FromArgb(134, 142, 150);

        public static readonly Color Peligro_351FI = Color.FromArgb(185, 28, 28);
        public static readonly Color PeligroOscuro_351FI = Color.FromArgb(153, 27, 27);
        public static readonly Color Advertencia_351FI = Color.FromArgb(180, 83, 9);

        // ------------------------------------------------ Tipografía
        public const string Familia = "Segoe UI";
        public const string FamiliaIconos = "Segoe MDL2 Assets";

        public static readonly Font Fuente_351FI = new Font(Familia, 11F);
        public static readonly Font FuenteSemibold_351FI = new Font("Segoe UI Semibold", 11F);
        public static readonly Font FuenteIconos_351FI = new Font(FamiliaIconos, 12F);

        // ------------------------------------------------ Íconos (Segoe MDL2 Assets)
        public static class Iconos_351FI
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
        public static Color FondoEfectivo_351FI(Control? control_351FI)
        {
            while (control_351FI != null)
            {
                if (control_351FI.BackColor.A == 255) return control_351FI.BackColor;
                control_351FI = control_351FI.Parent;
            }
            return Fondo_351FI;
        }
        public static GraphicsPath Redondeado_351FI(Rectangle r_351FI, int radio_351FI)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radio_351FI * 2;
            if (d <= 0 || r_351FI.Width < d || r_351FI.Height < d)
            {
                path.AddRectangle(r_351FI);
                return path;
            }
            path.AddArc(r_351FI.X, r_351FI.Y, d, d, 180, 90);
            path.AddArc(r_351FI.Right - d, r_351FI.Y, d, d, 270, 90);
            path.AddArc(r_351FI.Right - d, r_351FI.Bottom - d, d, d, 0, 90);
            path.AddArc(r_351FI.X, r_351FI.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
