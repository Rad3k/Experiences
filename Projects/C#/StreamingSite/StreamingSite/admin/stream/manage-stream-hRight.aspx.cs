using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin.database;

namespace rad3k_eu.admin
{
    public partial class manage_stream_hRight : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            transaction tran = new transaction();
            if (tran.selectHomePage('R'))
            {
                nameProgram.Text = tran.title[0];
                timeProgram.Text = tran.title[1];
                namePeople.Text = tran.title[2];
                descriptionText.Text = tran.description;
                program_1.Text = tran.section[0];
                program_2.Text = tran.section[1];
                program_3.Text = tran.section[2];
                program_4.Text = tran.section[3];
                program_5.Text = tran.section[4];
                time_1.Text = tran.section[5];
                time_2.Text = tran.section[6];
                time_3.Text = tran.section[7];
                time_4.Text = tran.section[8];
                time_5.Text = tran.section[9];
            }
        }
    }
}