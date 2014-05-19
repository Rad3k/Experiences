using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin.classes;

namespace rad3k_eu
{
    public partial class contact1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void send_button_Click(object sender, EventArgs e)
        {
            email mail = new email();
            if (mail.sendEmail(name_text.Text, email_text.Text, duvod_text.Text, full_text.Text, "Portfólio"))
                Response.Write("Email byl úspěšně odeslán!");
            else
                Response.Write("Vyskytla se chyba při odesílání emailu! " + Environment.NewLine + mail.error);
        }
    }
}