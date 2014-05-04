using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin.database;

namespace rad3k_eu
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            transaction kontakt = new transaction();
            if (kontakt.selectPagesInformation('K'))
            {
                nadpis.Text = kontakt.nadpis;
                popis.Text = kontakt.text;
            }
            if (kontakt.selectQuickBar())
            {
                support_me.Text = kontakt.section[0];
                text.Text = kontakt.section[1];
                /*program_1.Text = kontakt.section[2];
                program_2.Text = kontakt.section[4];
                program_3.Text = kontakt.section[6];
                program_4.Text = kontakt.section[8];*/
                alias_1.Text = kontakt.section[3];
                alias_2.Text = kontakt.section[5];
                alias_3.Text = kontakt.section[7];
                alias_4.Text = kontakt.section[9];
            }
        }
    }
}