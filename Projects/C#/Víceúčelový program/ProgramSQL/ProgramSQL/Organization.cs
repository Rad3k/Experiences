using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramSQL
{
    public partial class uncomplete_inform : Form
    {
        int calculate;

        public uncomplete_inform()
        {
            InitializeComponent();
            calculate = 0;

            // Organizace
            textBox_jmeno_org.Text = Definitions.jmeno_org.First();
            textBox_adresa_org.Text = Definitions.adresa_org.First();
            textBox_psc_org.Text = Definitions.psc_org.First();
            textBox_ico_org.Text = Definitions.ico_org.First();

            // Fakturační adresa
            textBox_jmeno_fa.Text = Definitions.jmeno_fa.First();
            textBox_adresa_fa.Text = Definitions.adresa_fa.First();
            textBox_psc_fa.Text = Definitions.psc_fa.First();
            textBox_ico_fa.Text = Definitions.ico_fa.First();

            // Expozitura
            textBox_jmeno_exp.Text = Definitions.jmeno_exp.First();
            textBox_adresa_exp.Text = Definitions.adresa_exp.First();
            textBox_psc_exp.Text = Definitions.psc_exp.First();
            textBox_ico_exp.Text = Definitions.ico_fa.First();
        }

        private void next_inform_Click(object sender, EventArgs e)
        {
            if (calculate < Definitions.jmeno_org.Count() && Definitions.jmeno_org.Count() > calculate)
            {
                calculate++;
                if (calculate >= Definitions.jmeno_org.Count())
                    calculate = calculate - 1;
            }

            if (calculate < Definitions.jmeno_org.Count() && Definitions.jmeno_org.Count() > calculate)
            {

                // Organizace
                textBox_jmeno_org.Text = Definitions.jmeno_org[calculate];
                textBox_adresa_org.Text = Definitions.adresa_org[calculate];
                textBox_psc_org.Text = Definitions.psc_org[calculate];
                textBox_ico_org.Text = Definitions.ico_org[calculate];

                // Fakturační adresa
                textBox_jmeno_fa.Text = Definitions.jmeno_fa[calculate];
                textBox_adresa_fa.Text = Definitions.adresa_fa[calculate];
                textBox_psc_fa.Text = Definitions.psc_fa[calculate];
                textBox_ico_fa.Text = Definitions.ico_fa[calculate];

                // Expozitura
                textBox_jmeno_exp.Text = Definitions.jmeno_exp[calculate];
                textBox_adresa_exp.Text = Definitions.adresa_exp[calculate];
                textBox_psc_exp.Text = Definitions.psc_exp[calculate];
                textBox_ico_exp.Text = Definitions.ico_fa[calculate];
            }
        }

        private void back_inform_Click(object sender, EventArgs e)
        {
            if (calculate > 0)
                calculate = calculate - 1;

            if (calculate < Definitions.jmeno_org.Count() && Definitions.jmeno_org.Count() > calculate)
            {
                // Organizace
                textBox_jmeno_org.Text = Definitions.jmeno_org[calculate];
                textBox_adresa_org.Text = Definitions.adresa_org[calculate];
                textBox_psc_org.Text = Definitions.psc_org[calculate];
                textBox_ico_org.Text = Definitions.ico_org[calculate];

                // Fakturační adresa
                textBox_jmeno_fa.Text = Definitions.jmeno_fa[calculate];
                textBox_adresa_fa.Text = Definitions.adresa_fa[calculate];
                textBox_psc_fa.Text = Definitions.psc_fa[calculate];
                textBox_ico_fa.Text = Definitions.ico_fa[calculate];

                // Expozitura
                textBox_jmeno_exp.Text = Definitions.jmeno_exp[calculate];
                textBox_adresa_exp.Text = Definitions.adresa_exp[calculate];
                textBox_psc_exp.Text = Definitions.psc_exp[calculate];
                textBox_ico_exp.Text = Definitions.ico_fa[calculate];
            }
        }

        private void update_inform_Click(object sender, EventArgs e)
        {

        }

        private void cancel_inform_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}