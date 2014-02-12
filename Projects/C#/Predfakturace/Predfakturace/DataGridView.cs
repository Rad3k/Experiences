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
        ReadFromExcel read = new ReadFromExcel();

        public DataGridView()
        {
            InitializeComponent();
            for (int i = 0; i < UniqueValue.traceToFile.Count(); i++)
            {
                read.ReadData(UniqueValue.traceToFile[i]);
                MessageBox.Show("Hodnota: " + UniqueValue.traceToFile[i]);
            }
            seznamPenez.DataSource = UniqueValue.money.Sum();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (filePathText.Text == "")
                MessageBox.Show("Nebyl zvolen žádný soubor!");
            else
            {
                //Bad code
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
