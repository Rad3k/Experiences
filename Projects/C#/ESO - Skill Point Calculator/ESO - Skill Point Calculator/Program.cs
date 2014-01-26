using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace ESO___Skill_Point_Calculator
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
                using (BasePreview fLogin = new BasePreview())
                {
                    switch (fLogin.ShowDialog())
                    {
                        case DialogResult.OK:
                            Application.Run(new ChooseClass());
                            validated = true;
                            break;

                        case DialogResult.No:
                            fLogin.Close();
                            validated = true;
                            break;
                    }
                }
            }
        }
    }
}
