using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using Global;

namespace Acs_Finder
{
    internal static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Task.Run(() => App.Init()).Wait();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AcsFinderMain());
        }
    }
}
