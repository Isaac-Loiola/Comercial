using ComercialTDSClass;
using System.Security.Cryptography.X509Certificates;

namespace ComercialTDSDesk
{
    internal static class Program
    {
        public static Usuario UsuarioLogado = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmPrincipal());
        }
    }
}