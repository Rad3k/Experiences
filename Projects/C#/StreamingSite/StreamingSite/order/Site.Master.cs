using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin;

namespace rad3k_eu.order
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            Response.Redirect("orderAdd.aspx");
        }

        protected void craftNav_Click(object sender, EventArgs e)
        {
            Response.Redirect("craft.aspx");
        }

        protected void gameNav_Click(object sender, EventArgs e)
        {
            Response.Redirect("hry.aspx");
        }

        protected void obchodNav_Click(object sender, EventArgs e)
        {
            UniqueValue.inicial = 'D';
            Response.Redirect("obchod.aspx");
        }
    }
}