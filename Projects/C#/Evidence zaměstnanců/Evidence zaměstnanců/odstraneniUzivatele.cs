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
    public partial class odstraneniUzivatele : Form
    {
        public odstraneniUzivatele()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (jmenoText.Text == "" && prijmeniText.Text == "")
                MessageBox.Show("Jméno nebo přijmení neni vyplněno, prosím vyplňte je!");
            else
            {
                Transactions tran = new Transactions(UniqueValue.FullPathConfig);
                tran.delZam(new SqlConnection(UniqueValue.FullPathConfig), jmenoText.Text, prijmeniText.Text);
            }
        }
    }
}
