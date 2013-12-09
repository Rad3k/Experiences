using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgramSQL
{
    public partial class ExcelSoubor : Form
    {
        public ExcelSoubor()
        {
            InitializeComponent();
            textBox1.Text = "Pattern.xls";
            textBox2.Text = "DxDiag.txt";
        }

        private void Button_SelectTrace(object sender, EventArgs e)
        {
            OpenFileDialog openFIleDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string souborFilename = openFileDialog1.FileName;
                textBox2.Text = souborFilename;
                Definitions.zdroj = textBox2.Text;
            }
        }

        private void Button_Predloha(object sender, EventArgs e)
        {
            OpenFileDialog openFIleDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string souborFilename = openFileDialog1.FileName;
                textBox1.Text = souborFilename;
                Definitions.predloha = textBox1.Text;
            }
        }

        private void Button_Continue(object sender, EventArgs e)
        {
            ConvertExcel convert = new ConvertExcel();
            convert.Show();
            Close();
        }

        private void Button_Cancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}
