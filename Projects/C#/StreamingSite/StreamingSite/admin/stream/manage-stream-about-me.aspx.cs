using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin.database;

namespace rad3k_eu
{
    public partial class manage_stream_favourite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            transaction tran = new transaction();
            if (tran.selectPagesInformation('O'))
            {
                nadpisText.Text = tran.nadpis;
                popisText.Text = tran.text;
                doplnInformace.Text = tran.informace;
            }
            else
            {
                nadpisText.Text = tran.nadpis;
                popisText.Text = tran.text;
            }
            if (tran.selectFavouriteGames('O'))
            {
                favouriteGames.Text = tran.title[0];
                program_1.Text = tran.section[0];
                program_2.Text = tran.section[1];
                program_3.Text = tran.section[2];
                program_4.Text = tran.section[3];
            }
        }
    }
}