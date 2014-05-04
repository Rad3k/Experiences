using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin.database;
using rad3k_eu.admin;

namespace rad3k_eu.admin.stream
{
    public partial class manage_stream_support_me : System.Web.UI.Page
    {
        transaction tran = new transaction();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (tran.selectPagesInformation('P') && UniqueValue.update)
            {
                nadpisText.Text = tran.nadpis;
                doplnText.Text = tran.text;
                UniqueValue.update = false;
            }
        }

        protected void save_id_Click(object sender, EventArgs e)
        {
            tran.saveSupportMe(nadpisText.Text, doplnText.Text);

            UniqueValue.update = true;
            Response.Redirect("http://rad3k.eu/admin/message/success.aspx");
        }
    }
}