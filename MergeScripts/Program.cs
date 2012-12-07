using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace MergeScripts
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool runone;
            Mutex run = new Mutex(true, "MergeScripts", out runone);
            if (runone)
            {
                run.ReleaseMutex();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form_MergeScripts());
            }
        }
    }
}
