using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rad3k_eu.admin.database;

namespace rad3k_eu
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            transaction right = new transaction();
            transaction left = new transaction();
            if (right.selectHomePage('L'))
            {
                nadpisProgram.Text = right.title[0];
                casStream.Text = right.title[1];
                playerNadpis.Text = right.title[2];
                program_1.Text = right.section[0];
                program_2.Text = right.section[1];
                program_3.Text = right.section[2];
                program_4.Text = right.section[3];
                program_5.Text = right.section[4];
                program_6.Text = right.section[5];
                cas_1.Text = right.section[6];
                cas_2.Text = right.section[7];
                cas_3.Text = right.section[8];
                cas_4.Text = right.section[9];
                cas_5.Text = right.section[10];
                cas_6.Text = right.section[11];
                jmeno_1.Text = right.section[12];
                jmeno_2.Text = right.section[13];
                jmeno_3.Text = right.section[14];
            }
            if (left.selectHomePage('R'))
            {
                hlavniNadpis.Text = left.title[0];
                nadpisHry.Text = left.title[1];
                InformaceNadpis.Text = left.title[2];
                popisPrace.Text = left.description;
                hra_1.Text = left.section[0];
                hra_2.Text = left.section[1];
                hra_3.Text = left.section[2];
                hra_4.Text = left.section[3];
                hra_5.Text = left.section[4];
                rozliseniPC.Text = left.section[5];
                rozliseniStream.Text = left.section[6];
                Kvalita.Text = left.section[7];
                upload.Text = left.section[8];
                odezva.Text = left.section[9];
            }
        }
    }
}