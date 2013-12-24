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
    public partial class problemsZam : Form
    {
        public problemsZam()
        {
            InitializeComponent();
        }

        private void problemsZam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EvidenceDB.TroubledEmployees' table. You can move, or remove it, as needed.
            this.TroubledEmployeesTableAdapter.Fill(this.EvidenceDB.TroubledEmployees);

            this.reportProblemZam.RefreshReport();
        }
    }
}
