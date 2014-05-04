using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin.database;

namespace rad3k_eu.admin
{
    public partial class login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            transaction tran = new transaction();
            if (tran.loginVerification(nameText.Text, passwordText.Text) == true)
                Response.Redirect("admin.aspx");
            else
                Response.Write("Přihlašovací jméno nebo heslo je špatné.");
        }
    }
}