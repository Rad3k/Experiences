using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgramSQL
{
    public partial class SQLCreator : Form
    {
        public int podminka;

        public SQLCreator()
        {
            InitializeComponent();
            MessageBox.Show("Kapacita čisla subjektu = " + Definitions.CisloSubjektu.Count + " Reference subjektu = " + Definitions.ReferenceSubjektu.Count + " Prekladů = " + Definitions.Preklady.Count + " Popis = " + Definitions.Popis.Count);
        }

        private void Button_Done(object sender, EventArgs e)
        {
            string connectionString = @"";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand commandN = new SqlCommand(null, connection);
                SqlCommand commandP = new SqlCommand(null, connection);

                progressBar1.Refresh();
                progressBar1.Maximum = Definitions.ReferenceSubjektu.Count;
                progressBar1.Step = 1;
                progressBar1.Minimum = 0;

                if (checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == false)
                {
                    for (int i = 0; i < Definitions.ReferenceSubjektu.Count(); i++)
                    {
                        try
                        {
                            commandN.Parameters.Clear();
                            // Create and prepare an SQL statement.
                            commandN.CommandText = "UPDATE uda_sklad SET nazev_ru = @nazev " +
                                "from uda_sklad left outer join sklad on sklad.cislo_subjektu = uda_sklad.cislo_subjektu " +
                                "WHERE sklad = @referenceN";

                            SqlParameter referenceParam = new SqlParameter("@referenceN", SqlDbType.VarChar, 30);
                            SqlParameter nazevParam = new SqlParameter("@nazev", SqlDbType.VarChar, 100);

                            referenceParam.Value = Definitions.ReferenceSubjektu[i];
                            nazevParam.Value = Definitions.Preklady[i];

                            // Command for Název
                            commandN.Parameters.Add(referenceParam);
                            commandN.Parameters.Add(nazevParam);

                            // Call Prepare after setting the Commandtext and Parameters.
                            commandN.Prepare();
                            commandN.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            richTextBox1.Text = "Error " + ex.Number +  " has occurred: " + ex.Message;
                        }
                        progressBar1.PerformStep();
                    }
                }
                else if (checkBox2.Checked == true && checkBox4.Checked == true && checkBox3.Checked == false)
                {
                    for (int i = 0; i < Definitions.ReferenceSubjektu.Count(); i++)
                    {
                        try
                        {
                            // Create and prepare an SQL statement.
                            commandP.CommandText = "UPDATE uda_sklad SET popis_ru = @popis " +
                                "from uda_sklad left outer join sklad on sklad.cislo_subjektu = uda_sklad.cislo_subjektu " +
                                "WHERE sklad.reference = @referenceP";

                            SqlParameter referenceParamPopis = new SqlParameter("@referenceP", SqlDbType.VarChar, 30);
                            SqlParameter popisParam = new SqlParameter("@popis", SqlDbType.VarChar, 4000);

                            referenceParamPopis.Value = Definitions.ReferenceSubjektu[i];
                            popisParam.Value = Definitions.Popis[i];

                            // Command for Popis
                            commandP.Parameters.Clear();
                            commandP.Parameters.Add(referenceParamPopis);
                            commandP.Parameters.Add(popisParam);

                            // Call Prepare after setting the Commandtext and Parameters.
                            commandP.Prepare();
                            commandP.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            richTextBox1.Text = "Error " + ex.Number + " has occurred: " + ex.Message;
                        }
                        progressBar1.PerformStep();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
