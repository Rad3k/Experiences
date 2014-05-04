using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin.database;
using rad3k_eu.admin;

namespace rad3k_eu.admin
{
    public partial class manage_stream_links : System.Web.UI.Page
    {
        transaction tran = new transaction();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (tran.selectQuickBar() && UniqueValue.update)
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
                UniqueValue.update = false;
            }
        }

        protected void navigatePanel_Click(object sender, EventArgs e)
        {
            tran.saveQuickBar(nadpisText.Text, doplnText.Text, program_1.Text, program_2.Text, program_3.Text, program_4.Text, alisy_1.Text, alisy_2.Text, alisy_3.Text, alisy_4.Text);

            UniqueValue.update = true;
            Response.Redirect("http://rad3k.eu/admin/message/success.aspx");
        }
    }
}