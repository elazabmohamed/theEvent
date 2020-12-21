using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theEvent
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //initialize the database connections
            theEvent.Models.GlobalConf.InitializeConnection(true);
            Application.Run(new Log());
            // Application.Run(new Log());
        }
    }
}
