using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin;
using rad3k_eu.admin.database;
using rad3k_eu.order.classes;

namespace rad3k_eu.order
{
    public partial class craft : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }

        protected void FillPage()
        {
            string endTable = "</table>";
            transaction tran = new transaction();
            ArrayList craftList = new ArrayList();
            if (IsPostBack)
                labelOutputCraft.Text = "Při načítaní došlo k chybě";
            else
                craftList = tran.selectOrderCraft();

            StringBuilder data = new StringBuilder();
            StringBuilder table = new StringBuilder();

            table.Append(string.Format(@"<table>
                <tr>
                    <th width='100'>Typ</th>
                    <th width='80'>Druh</th>
                    <th width='800'>Zpráva</th>
                    <th width='350'>Potion</th>
                    <th width='80'>Počet kusů</th>
                    <th width='100'>Váš nick</th>
                    <th width='20'>Status</th>
                </tr>"));

            foreach (crafting craft in craftList)
            {
                data.Append(string.Format(@"
                <tr>
                    <td>{0}</td>
                    <td>{1}</td>
                    <td>{2}</td>
                    <td>{3}</td>
                    <td>{4}</td>
                    <td>{5}</td>
                    <td>{6}</td>
                </tr>", craft.typeTicket, craft.typeMethod, craft.message, craft.typePotion, craft.value, craft.nick, craft.status));
            }
            labelOutputCraft.Text = table.ToString() + data.ToString() + endTable;
        }
    }
}