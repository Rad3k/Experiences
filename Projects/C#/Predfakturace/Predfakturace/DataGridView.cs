using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predfakturace
{
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (filePathText.Text == "")
                MessageBox.Show("Nebyl zvolen žádný soubor!");
            else
            {
                for (int i = 0; i < UniqueValue.traceToFile.Count; i++)
                {
                    ReadFromExcel read = new ReadFromExcel();
                    read.ReadData(UniqueValue.traceToFile[i]);
                }

                DataTable table = new DataTable();

                foreach (int money in UniqueValue.money)
                    table.Rows.Add(money);
                seznamPenez.DataSource = table;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void traceToFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string souborFilename = openFileDialog1.FileName;
                filePathText.Text = souborFilename;
                UniqueValue.finalyPath = filePathText.Text;
            }
        }
    }
}
