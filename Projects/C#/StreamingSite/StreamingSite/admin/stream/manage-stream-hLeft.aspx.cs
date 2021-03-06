﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin.database;

namespace rad3k_eu.admin
{
    public partial class homeLeft : System.Web.UI.Page
    {
        transaction tran = new transaction();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (tran.selectHomePage('L') && UniqueValue.update)
            {
                nameProgram.Text = tran.title[0];
                timeProgram.Text = tran.title[1];
                namePeople.Text = tran.title[2];
                program_1.Text = tran.section[0];
                program_2.Text = tran.section[1];
                program_3.Text = tran.section[2];
                program_4.Text = tran.section[3];
                program_5.Text = tran.section[4];
                program_6.Text = tran.section[5];
                time_1.Text = tran.section[6];
                time_2.Text = tran.section[7];
                time_3.Text = tran.section[8];
                time_4.Text = tran.section[9];
                time_5.Text = tran.section[10];
                time_6.Text = tran.section[11];
                name_1.Text = tran.section[12];
                name_2.Text = tran.section[13];
                name_3.Text = tran.section[14];
                UniqueValue.update = false;
            }
        }

        protected void hLeftButton_Click(object sender, EventArgs e)
        {
            tran.saveHomePage(nameProgram.Text, timeProgram.Text, namePeople.Text, program_1.Text, program_2.Text, program_3.Text, program_4.Text, program_5.Text,
                program_6.Text, time_1.Text, time_2.Text, time_3.Text, time_4.Text, time_5.Text, time_6.Text, name_1.Text, name_2.Text, name_3.Text, 'L');

            UniqueValue.update = true;
            Response.Redirect("http://rad3k.eu/admin/message/success.aspx");
        }
    }
}