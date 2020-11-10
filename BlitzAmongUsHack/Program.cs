using Auth.GG_Winform_Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlitzAmongUsHack
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            OnProgramStart.Initialize("Blitz-Among-Us-hack", "630524", "YzlJ3aFp5Me8GQ4j8eS9Zt5CS7c3kMVJiaB", "1.0");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
