﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace rad3k_eu.admin
{
    public partial class manage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void refreshData_Click(object sender, EventArgs e)
        {
            UniqueValue.update = true;
            Response.Redirect(Request.Url.AbsoluteUri);
        }
    }
}