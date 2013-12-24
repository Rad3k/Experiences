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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EvidenceDB.Employee' table. You can move, or remove it, as needed.
            this.EmployeeTableAdapter.Fill(this.EvidenceDB.Employee);

            this.reportMzdy.RefreshReport();
        }
    }
}
