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
    public partial class infoProgram : Form
    {
        public infoProgram()
        {
            InitializeComponent();
            DateTime time = new DateTime();
            textBoxUser.Text = UniqueValue.Login;
            textBoxVersion.Text = ".";
            textBoxDatabase.Text = "Evidence";
            textBoxGetDate.Text = time.ToLongDateString() + " -- " + time.ToLongTimeString();
            textBoxDateChanged.Text = "17.12.2013 -- 01:32 AM";
        }

        private void continuePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
