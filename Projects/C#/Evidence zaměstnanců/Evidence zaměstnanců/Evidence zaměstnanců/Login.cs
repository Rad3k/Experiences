using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidence_zaměstnanců
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginToProgram_Click(object sender, EventArgs e)
        {
            ReadFromConfig config = new ReadFromConfig();
            config.ReadFromFile();
            LoginInformation login = new LoginInformation(loginText.Text);
            LoginValidation access = new LoginValidation();
            access.ValidateLogin(loginText.Text, passwordText.Text, login.Login, login.Password);

            if (access.access == true)
            {
                Main main = new Main();
                main.Show();
            }
            else
                MessageBox.Show("Přihlašovací jméno nebo heslo neni správné");
        }
    }
}
