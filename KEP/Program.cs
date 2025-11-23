using System;
using System.Windows.Forms;

namespace KEP
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Database.Initialize();          
            Application.Run(new Form1());  
        }
    }
}
