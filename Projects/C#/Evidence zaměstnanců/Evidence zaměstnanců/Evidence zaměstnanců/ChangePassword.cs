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

namespace Evidence_zaměstnanců
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();

            oldPasswordText.Text = UniqueValue.Password;
            oldPasswordText.ReadOnly = true;
        }

        private void finish_Click(object sender, EventArgs e)
        {
            Transactions tran = new Transactions(UniqueValue.FullPathConfig);
            tran.ChangePassword(newPasswordText.Text, new SqlConnection(UniqueValue.FullPathConfig));
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
