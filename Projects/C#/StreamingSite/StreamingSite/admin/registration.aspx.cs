using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin.database;

namespace rad3k_eu.admin
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Registration_Click(object sender, EventArgs e)
        {
            transaction tran = new transaction();
            Response.Write(tran.signInToSystem(nameText.Text, passwordText.Text));
        }
    }
}