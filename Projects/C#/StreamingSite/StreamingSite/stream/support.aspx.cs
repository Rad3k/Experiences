using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin.database;

namespace rad3k_eu
{
    public partial class support : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            transaction support = new transaction();
            if (support.selectPagesInformation('P'))
            {
                podpora.Text = support.nadpis;
                popis.Text = support.text;
            }
            if (support.selectQuickBar())
            {
                support_me.Text = support.section[0];
                text.Text = support.section[1];
                /*program_1.Text = support.section[2];
                program_2.Text = support.section[4];
                program_3.Text = support.section[6];
                program_4.Text = support.section[8];*/
                alias_1.Text = support.section[3];
                alias_2.Text = support.section[5];
                alias_3.Text = support.section[7];
                alias_4.Text = support.section[9];
            }
        }
    }
}