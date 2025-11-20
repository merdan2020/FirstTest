using System;
using System.Windows.Forms;

namespace KareAlanHesaplama
{
    internal static class Program
    {
        /// <summary>
        ///  Uygulamanın ana giriş noktasıdır.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
