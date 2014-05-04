using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin.database;

namespace rad3k_eu.admin.stream
{
    public partial class manage_stream_support_me : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            transaction tran = new transaction();
            if (tran.selectPagesInformation('P'))
            {
                nadpisText.Text = tran.nadpis;
                doplnText.Text = tran.text;
            }
        }
    }
}