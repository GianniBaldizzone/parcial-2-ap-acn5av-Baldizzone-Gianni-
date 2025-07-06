using FlameTome.Frontend;
using FlameTome.Modelos;

namespace FlameTome
{
    internal static class Program
    {
        /// <summary>
        ///  Usuario logueado actual.
        /// </summary>
        public static Usuario UsuarioLogueado { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}