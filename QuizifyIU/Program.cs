using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quizify.Services;
using Quizify.Persistence;

namespace QuizifyIU
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //NuevoServicio servicio = new NuevoServicio();
            NuevoServicio servicio = NuevoServicio.getServicio();
            //Servicio servicio = new Servicio(new DAL());
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal(servicio));
        }

    }
}
