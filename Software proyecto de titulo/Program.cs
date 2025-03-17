using System;
using System.Collections.Generic;
using System.Linq;
using Presentacion;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_proyecto_de_titulo
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginUsu());
        }
    }
}
