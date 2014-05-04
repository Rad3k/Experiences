using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin;
using rad3k_eu.admin.database;

namespace rad3k_eu
{
    public partial class manage_stream_favourite : System.Web.UI.Page
    {
        transaction tran = new transaction();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (tran.selectPagesInformation('O') && UniqueValue.update)
            {
                nadpisText.Text = tran.nadpis;
                popisText.Text = tran.text;
                doplnInformace.Text = tran.informace;
            }
            else
            {
                if (UniqueValue.update)
                {
                    nadpisText.Text = tran.nadpis;
                    popisText.Text = tran.text;
                }
            }
            if (tran.selectFavouriteGames('O') && UniqueValue.update)
            {
                favouriteGames.Text = tran.title[0];
                program_1.Text = tran.section[0];
                program_2.Text = tran.section[1];
                program_3.Text = tran.section[2];
                program_4.Text = tran.section[3];
            }
            UniqueValue.update = false;
        }

        protected void aboutMe_Click(object sender, EventArgs e)
        {
            tran.saveAboutMe(nadpisText.Text, popisText.Text, favouriteGames.Text, program_1.Text, program_2.Text, program_3.Text, program_4.Text, doplnInformace.Text);

            UniqueValue.update = true;
            Response.Redirect("http://rad3k.eu/admin/message/success.aspx");
        }
    }
}