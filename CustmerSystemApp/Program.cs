using System;
using System.Windows.Forms;
using Customer_System_App;
using CustomerSystemApp;

namespace CustomerSystemApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}
