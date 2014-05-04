using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin.database;

namespace rad3k_eu.admin
{
    public partial class manage_stream_links : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            transaction tran = new transaction();
            if (tran.selectQuickBar())
            {
                nadpisText.Text = tran.section[0];
                doplnText.Text = tran.section[1];
                program_1.Text = tran.section[2];
                program_2.Text = tran.section[4];
                program_3.Text = tran.section[6];
                program_4.Text = tran.section[8];
                alisy_1.Text = tran.section[3];
                alisy_2.Text = tran.section[5];
                alisy_3.Text = tran.section[7];
                alisy_4.Text = tran.section[9];
            }
        }
    }
}