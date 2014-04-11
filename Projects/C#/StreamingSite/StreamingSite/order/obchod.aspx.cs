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
    public partial class obchod : System.Web.UI.Page
    {
        transaction tran = new transaction();
        ArrayList obchodList = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }

        protected void nakup_Click(object sender, EventArgs e)
        {
            UniqueValue.inicial = 'N';
            Response.Redirect("obchod.aspx");
        }

        protected void prodej_Click(object sender, EventArgs e)
        {
            UniqueValue.inicial = 'P';
            Response.Redirect("obchod.aspx");
        }

        protected void vymena_Click(object sender, EventArgs e)
        {
            UniqueValue.inicial = 'V';
            Response.Redirect("obchod.aspx");
        }

        protected void FillPage()
        {
            string endTable = "</table>";
            if (IsPostBack)
                labelOutput.Text = "Při načítaní došlo k chybě";
            else
                obchodList = tran.selectBusinessType(UniqueValue.inicial);

            StringBuilder data = new StringBuilder();
            StringBuilder table = new StringBuilder();

            table.Append(string.Format(@"<table>
                <tr>
                    <th width='100'>Typ</th>
                    <th width='80'>Druh</th>
                    <th width='350'>Zpráva</th>
                    <th width='100'>Věc</th>
                    <th width='350'>Jméno zboží</th>
                    <th width='80'>Počet kusů</th>
                    <th width='150'>Váš nick</th>
                    <th width='80'>Datum</th>
                </tr>"));

            foreach (Obchod obchod in obchodList)
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
                    <td>{7}</td>
                </tr>", obchod.type, obchod.typeMethod, obchod.vec, obchod.message, obchod.name, obchod.value, obchod.nick, obchod.datum));
            }
            labelOutput.Text = table.ToString() + data.ToString() + endTable;
        }
    }
}