using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Evidence_zaměstnanců
{
    public partial class pridatUzivatele : Form
    {
        public pridatUzivatele()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pridat_Click(object sender, EventArgs e)
        {
            Transactions tran = new Transactions(UniqueValue.FullPathConfig);
            tran.addZam(new SqlConnection(UniqueValue.FullPathConfig), jmenoText.Text, prijmeniText.Text, emailText.Text, rodneCisloText.Text, pracovniPoziceText.Text
                , telPraceText.Text, faxPraceText.Text, telDomuText.Text, mobilText.Text, doplnUdajeText.Text, uliceText.Text, mestoText.Text, statText.Text, cpText.Text, coText.Text
                , mzdaText.Text, pobockaText.Text, utvarText.Text);
        }
    }
}
