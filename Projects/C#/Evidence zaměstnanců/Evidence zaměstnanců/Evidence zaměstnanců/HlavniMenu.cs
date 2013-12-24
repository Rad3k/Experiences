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
            selectDB.Items.Add(new ComboBox_selectDB("1", "Evidence"));
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

        private void addZam_Click(object sender, EventArgs e)
        {
            pridatUzivatele addZam = new pridatUzivatele();
            addZam.Show();
        }

        private void delZam_Click(object sender, EventArgs e)
        {
            odstraneniUzivatele delZam = new odstraneniUzivatele();
            delZam.Show();
        }

        private void controlZam_Click(object sender, EventArgs e)
        {
            controlZam control = new controlZam();
            control.Show();
        }

        private void smlouvyZam_Click(object sender, EventArgs e)
        {
            ukonceneSmlouvy smlouvy = new ukonceneSmlouvy();
            smlouvy.Show();
        }

        private void problemZam_Click(object sender, EventArgs e)
        {
            problemsZam zam = new problemsZam();
            zam.Show();
        }

        private void addCVs_Click(object sender, EventArgs e)
        {

        }

        private void editCVs_Click(object sender, EventArgs e)
        {

        }

        private void delCVs_Click(object sender, EventArgs e)
        {

        }

        private void statisticsMenu_Click(object sender, EventArgs e)
        {
            Statistics stat = new Statistics();
            stat.Show();
        }
    }
}
