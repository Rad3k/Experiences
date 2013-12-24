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
    public partial class delCVs : Form
    {
        public delCVs()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (jmenoText.Text == null && prijmeniText.Text == null)
                MessageBox.Show("Jméno nebo přijmení neni vyplněno, prosím vyplňte je!");
            else
            {
                Transactions tran = new Transactions(UniqueValue.FullPathConfig);
                tran.selectID(new SqlConnection(UniqueValue.FullPathConfig), jmenoText.Text, prijmeniText.Text);
                tran.delCVs(new SqlConnection(UniqueValue.FullPathConfig), tran.ID);
            }
        }
    }
}
