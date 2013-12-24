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
        int number;

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
            number = 0;

            if (troubledZamCheck.Checked)
                number++;

            if (jmenoText.Text == "" && prijmeniText.Text == "")
                MessageBox.Show("Jméno nebo přijmení neni vyplněno, prosím vyplňte je!");
            else
            {
                Transactions tran = new Transactions(UniqueValue.FullPathConfig);
                tran.addZam(new SqlConnection(UniqueValue.FullPathConfig), jmenoText.Text, prijmeniText.Text, emailText.Text, rodneCisloText.Text, pracovniPoziceText.Text
                    , telPraceText.Text, faxPraceText.Text, telDomuText.Text, mobilText.Text, doplnUdajeText.Text, uliceText.Text, mestoText.Text, statText.Text, cpText.Text, coText.Text
                    , mzdaText.Text, pobockaText.Text, utvarText.Text, datumNastupuTime, datumUkonceniTime, number);
            }

            Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (jmenoText.Text == "" && prijmeniText.Text == "")
                MessageBox.Show("Jméno nebo přijmení neni vyplněno, prosím vyplňte je!");
            else
            {
                Transactions tran = new Transactions(UniqueValue.FullPathConfig);
                tran.selectZam(new SqlConnection(UniqueValue.FullPathConfig), jmenoText.Text, prijmeniText.Text);

                jmenoText.Text = tran.Jmeno;
                prijmeniText.Text = tran.Prijmeni;
                emailText.Text = tran.email;
                rodneCisloText.Text = tran.RodneCislo;
                pracovniPoziceText.Text = tran.PracovniPozice;
                telPraceText.Text = tran.TelefonPrace;
                faxPraceText.Text = tran.FaxPrace;
                telDomuText.Text = tran.TelefonDomu;
                mobilText.Text = tran.MobilDomu;
                doplnUdajeText.Text = tran.DoplnujiciUdaje;
                uliceText.Text = tran.Ulice;
                mestoText.Text = tran.Mesto;
                statText.Text = tran.Stat;
                cpText.Text = tran.CP.ToString();
                coText.Text = tran.CO.ToString();
                mzdaText.Text = tran.Mzda.ToString();
                pobockaText.Text = tran.Pobocka;
                utvarText.Text = tran.Utvar;
                datumNastupuTime.Value = tran.datumNastupu;
                datumUkonceniTime.Value = tran.datumUkonceni;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            number = 0;

            if (troubledZamCheck.Checked)
                number++;

            if (jmenoText.Text == "" && prijmeniText.Text == "")
                MessageBox.Show("Jméno nebo přijmení neni vyplněno, prosím vyplňte je!");
            else
            {
                Transactions tran = new Transactions(UniqueValue.FullPathConfig);
                tran.delZam(new SqlConnection(UniqueValue.FullPathConfig), jmenoText.Text, prijmeniText.Text);
                tran.addZam(new SqlConnection(UniqueValue.FullPathConfig), jmenoText.Text, prijmeniText.Text, emailText.Text, rodneCisloText.Text, pracovniPoziceText.Text
                    , telPraceText.Text, faxPraceText.Text, telDomuText.Text, mobilText.Text, doplnUdajeText.Text, uliceText.Text, mestoText.Text, statText.Text, cpText.Text, coText.Text
                    , mzdaText.Text, pobockaText.Text, utvarText.Text, datumNastupuTime, datumUkonceniTime, number);
            }
        }
    }
}
