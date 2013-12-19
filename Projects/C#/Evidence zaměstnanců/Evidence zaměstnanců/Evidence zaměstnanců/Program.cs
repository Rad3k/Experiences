using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidence_zaměstnanců
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
            bool validated = false;
            while (!validated)
            {
                using (Login fLogin = new Login())
                {
                    if (fLogin.ShowDialog() == DialogResult.OK)
                        validated = true;
                    else
                    {
                        fLogin.Close();
                        break;
                    }
                }
                if (validated && UniqueValue.access)
                    Application.Run(new Main());
                else
                {
                    MessageBox.Show("Přihlašovací jméno nebo heslo neni správné");
                    validated = false;
                }
            }
        }
    }
}
