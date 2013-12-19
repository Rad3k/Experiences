using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Net;

namespace Evidence_zaměstnanců
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void selectDB_Click(object sender, EventArgs e)
        {
            selectDB.Items.Clear();
            selectDB.Items.Add(new ComboBox_selectDB("1", "HlavníDB"));
            selectDB.Items.Add(new ComboBox_selectDB("2", "Test"));
        }

        private void infoProgram_Click(object sender, EventArgs e)
        {
            infoProgram infoProgram = new infoProgram();
            infoProgram.Show();
        }

        private void websiteItem_Click(object sender, EventArgs e)
        {
            website web = new website();
            web.BaseWebsite();
        }

        private void repozitaryLink_Click(object sender, EventArgs e)
        {
            website web = new website();
            web.OpenGitHubRepozitary();
        }

        private void technickSupportLink_Click(object sender, EventArgs e)
        {
            website web = new website();
            web.OpenWebsiteFaQ();
        }
    }
}
