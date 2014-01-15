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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void pojNext_Click(object sender, EventArgs e)
        {
            ControlFile control = new ControlFile();
            control.Show();
        }

        private void spoNext_Click(object sender, EventArgs e)
        {
            ControlFile control = new ControlFile();
            control.Show();
        }

        private void csobNext_Click(object sender, EventArgs e)
        {
            ControlFile control = new ControlFile();
            control.Show();
        }
    }
}
