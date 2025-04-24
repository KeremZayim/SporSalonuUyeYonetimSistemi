using SporSalonuUyeYonetimSistemi.Forms;
using SporSalonuUyeYonetimSistemi.Forms.Member.MemberInformation;
using System;
using System.Windows.Forms;
using SporSalonuUyeYonetimSistemi.Classes;

namespace SporSalonuUyeYonetimSistemi
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
