using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin.database;

namespace rad3k_eu.smlouvy
{
    public partial class smlouvy : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void addData_Click(object sender, EventArgs e)
        {
            transaction tran = new transaction();
            if (tran.ulozeniSmlovuy(jmenoText.Text, prijmeniText.Text, pozice.Text, Calendar1.SelectedDate.Date, Calendar2.SelectedDate.Date, doplnInformaceText.Text).Contains("done"))
            {
                jmeno.Visible = false;
                jmenoText.Visible = false;
                prijmeni.Visible = false;
                prijmeniText.Visible = false;
                pozice.Visible = false;
                poziceText.Visible = false;
                Calendar1.Visible = false;
                Calendar2.Visible = false;
                datumNastupu.Visible = false;
                datumUkonceni.Visible = false;
                doplnInformaceLabel.Visible = false;
                doplnInformaceText.Visible = false;

                nadpis.ForeColor = System.Drawing.Color.DarkGreen;
                nadpis.Text = "Smlouva byla úspěšně přidána do evidence";
            }
        }
    }
}