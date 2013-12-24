using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Evidence_zaměstnanců
{
    public partial class infoProgram : Form
    {
        public infoProgram()
        {
            InitializeComponent();
            try
            {
                Transactions tran = new Transactions(UniqueValue.FullPathConfig);
                tran.GetDataFromAboutProgram(new SqlConnection(UniqueValue.FullPathConfig));
                textBoxUser.Text = UniqueValue.Login;
                textBoxVersion.Text = tran.version;
                textBoxDatabase.Text = "Evidence";
                textBoxGetDate.Text = tran.date.ToString();
                textBoxDateChanged.Text = tran.lastChanged.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Chyba: " + e);
            }
        }

        private void continuePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePass = new ChangePassword();
            changePass.Show();
        }
    }
}
