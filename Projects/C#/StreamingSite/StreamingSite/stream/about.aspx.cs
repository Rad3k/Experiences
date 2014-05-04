using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin.database;

namespace rad3k_eu
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            transaction o_me = new transaction();
            if (o_me.selectPagesInformation('O'))
            {
                nadpis.Text = o_me.nadpis;
                popis.Text = o_me.text;
                doplnInformace.Text = o_me.informace;
            }
            else
            {
                nadpis.Text = o_me.nadpis;
                popis.Text = o_me.text;

            }
            if (o_me.selectFavouriteGames('O'))
            {
                titul.Text = o_me.title[0];
                hra_1.Text = o_me.section[0];
                hra_2.Text = o_me.section[1];
                hra_3.Text = o_me.section[2];
                hra_4.Text = o_me.section[3];
            }
            if (o_me.selectQuickBar())
            {
                support_me.Text = o_me.section[0];
                text.Text = o_me.section[1];
                /*program_1.Text = o_me.section[2];
                program_2.Text = o_me.section[4];
                program_3.Text = o_me.section[6];
                program_4.Text = o_me.section[8];*/
                alias_1.Text = o_me.section[3];
                alias_2.Text = o_me.section[5];
                alias_3.Text = o_me.section[7];
                alias_4.Text = o_me.section[9];
            }
        }
    }
}