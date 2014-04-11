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
    public partial class hry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }

        protected void FillPage()
        {
            string endTable = "</table>";
            transaction tran = new transaction();
            ArrayList gameList = new ArrayList();
            if (IsPostBack)
                labelOutput.Text = "Při načítaní došlo k chybě";
            else
                gameList = tran.selectOrderGame();

            StringBuilder data = new StringBuilder();
            StringBuilder table = new StringBuilder();

            table.Append(string.Format(@"<table>
                <tr>
                    <th width='100'>Typ</th>
                    <th width='80'>Druh</th>
                    <th width='800'>Zpráva</th>
                    <th width='350'>Hra</th>
                    <th width='80'>Počet kusů</th>
                    <th width='20'>Status</th>
                </tr>"));

            foreach (games game in gameList)
            {
                data.Append(string.Format(@"
                <tr>
                    <td>{0}</td>
                    <td>{1}</td>
                    <td>{2}</td>
                    <td>{3}</td>
                    <td>{4}</td>
                    <td>{5}</td>
                </tr>", game.typeTicket, game.typeMethod, game.message, game.typeName, game.value, game.status));
            }
            labelOutput.Text = table.ToString() + data.ToString() + endTable;
        }
    }
}