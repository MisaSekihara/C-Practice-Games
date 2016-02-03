using System;
using System.Windows.Forms;
using MT_WinForm.Forms;

namespace MT_Game
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
            Application.Run(new FormTitle());
        }
    }
}
