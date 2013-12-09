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
    public partial class PrekladSoubor : Form
    {
        public PrekladSoubor()
        {
            InitializeComponent();
        }
        
        private void Button_SelectTrace(object sender, EventArgs e)
        {
            OpenFileDialog openFIleDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string souborFilename = openFileDialog1.FileName;
                textBox1.Text = souborFilename;
                Definitions.zdroj = textBox1.Text;
            }
        }

        private void Button_Continue(object sender, EventArgs e)
        {
            PrekladEditor editor = new PrekladEditor();
            editor.Show();
            Close();
        }
    }
}
