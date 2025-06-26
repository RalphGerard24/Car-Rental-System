using System.Runtime.InteropServices;
using Car_Rental_System.Forms;

namespace Car_Rental_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Load global font once
            FontManager.LoadCustomFont();

            Application.Run(new LoginPage());
        }
    }
}