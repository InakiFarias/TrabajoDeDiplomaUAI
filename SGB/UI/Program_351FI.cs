using BLL.BLL_SER;
using QuestPDF.Infrastructure;

namespace UI
{
    internal static class Program_351FI
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            QuestPDF.Settings.License = LicenseType.Community;
            ApplicationConfiguration.Initialize();

            // Antes del login: si la base no existe, se crea. Los mensajes van en español fijo
            // porque, si falla la conexión, todavía no se pueden leer los idiomas de la base.
            try
            {
                BLL_InicializacionBD_351FI bll_inicializacion_351FI = new BLL_InicializacionBD_351FI();
                if (bll_inicializacion_351FI.InicializarBase_351FI())
                    MessageBox.Show("Se creó la base de datos del sistema con los datos de prueba.", "SGB", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string rutaEnv = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".env");
                MessageBox.Show($"No se pudo iniciar el sistema.\n\n{ex.Message}\n\nLa conexión a SQL Server se configura en el archivo:\n{rutaEnv}", "SGB - Error de inicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new FrmLogin_351FI());
        }
    }
}
