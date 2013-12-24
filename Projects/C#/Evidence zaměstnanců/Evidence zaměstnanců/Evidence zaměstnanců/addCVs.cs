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
    public partial class addCVs : Form
    {
        public addCVs()
        {
            InitializeComponent();
        }

        private void traceToFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFIleDialog = new OpenFileDialog();

            if (openFIleDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string souborFilename = openFIleDialog.FileName;
                traceToFileText.Text = souborFilename;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void finish_Click(object sender, EventArgs e)
        {
            if (jmenoText.Text == null && prijmeniText.Text == null)
                MessageBox.Show("Jméno nebo přijmení neni vyplněno, prosím vyplňte je!");
            else
            {
                Transactions tran = new Transactions(UniqueValue.FullPathConfig);
                tran.selectID(new SqlConnection(UniqueValue.FullPathConfig), jmenoText.Text, prijmeniText.Text);
                tran.addCVs(new SqlConnection(UniqueValue.FullPathConfig), tran.ID, traceToFileText.Text);
            }
        }
    }
}
