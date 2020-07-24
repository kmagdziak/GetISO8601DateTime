using System;
using System.Windows.Forms;

namespace GetISO8601DateTime
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string currentDateTime = DateTime.Now.ToString("s");
            Clipboard.SetText(currentDateTime);
            Application.Exit();
        }
    }
}