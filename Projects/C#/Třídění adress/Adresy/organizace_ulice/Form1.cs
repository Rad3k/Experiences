using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace organizace_ulice
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button_organizace_Click(object sender, EventArgs e)
        {
            selectDataFromDB("organizace", sender as BackgroundWorker);
            updateDataToDB("organizace", sender as BackgroundWorker);

            Definitions definition = new Definitions();
            definition.Ulice.Clear();
            definition.cp.Clear();
            definition.cSubjekt.Clear();
            definition.co.Clear();

            selectDataFromDB("expozitura", sender as BackgroundWorker);
            updateDataToDB("expozitura", sender as BackgroundWorker);
            //this.backgroundWorker1.RunWorkerAsync();
        }

        
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            selectDataFromDB("organizace", sender as BackgroundWorker);
            selectDataFromDB("expozitura", sender as BackgroundWorker);
        }

        public int subjekt;
        public string s;

        public void selectDataFromDB(string tab, BackgroundWorker bw)
        {
            Definitions definition = new Definitions();
            string connection = @"";
            int err_cnt = 0;

            //MessageBox.Show(err_cnt.ToString());

            using (SqlConnection sql = new SqlConnection(connection))
            {
                sql.Open();
                using (SqlCommand select_org = new SqlCommand("SELECT " + tab + ".cislo_subjektu, " + tab + ".ulice FROM " + tab + " WHERE (zeme = 1041073 or zeme = 79) and ulice is not null", sql))
                using (SqlDataReader reader_org = select_org.ExecuteReader())
                {
                    while (reader_org.Read())
                    {
                        if (reader_org.IsDBNull(0) | reader_org.IsDBNull(1))
                            continue;

                        subjekt = reader_org.GetInt32(0);
                        s = reader_org.GetString(1);

                        // v proměnné s je celá ulice
                        s = s.Trim();

                        Match mt;

                        try
                        {
                            mt = Regex.Match(s, @"([\.\,\ A-Ža-ž0-9]*) ([0-9]+[a-zA-Z]?\s*[\/]\s*)?([0-9]+[a-zA-Z]?)$");
                        }
                        catch (Exception e)
                        {
                            definition.cSubjekt.Add(subjekt);
                            definition.Ulice.Add(s);
                            definition.cp.Add("");
                            definition.co.Add("");
                            //this.updateDataToDB(sql, tab, subjekt, s, "", "", bw);
                            //pgb.Value++;
                            err_cnt++;
                            MessageBox.Show(e.Message + "0");
                            continue;
                        }

                        /*
                        for (int k = 0; k < mt.Groups.Count; k++)
                        {
                            MessageBox.Show(mt.Groups[k].Value);
                        }
                        */

                        if (mt.Groups.Count > 1) // je tam nejaky match, v indexu nula je to nejako komplet, to vynechavat
                        {
                            // index 1 = ulice
                            // index 2 = čp
                            // index 3 = čo

                            string ulice = mt.Groups[1].Value.Trim(); //.Replace("/", "");
                            string cp = mt.Groups[2].Value.Replace("/", "").Trim();
                            string co = mt.Groups[3].Value.Replace("/", "").Trim();

                            if (cp.Length == 0)
                            {
                                cp = co;
                                co = "";
                            }
                            try
                            {
                                definition.cSubjekt.Add(subjekt);
                                definition.Ulice.Add(ulice);
                                definition.cp.Add(cp);
                                definition.co.Add(co);
                            }
                            catch (Exception e)
                            {
                                //pgb.Value++;
                                err_cnt++;
                                MessageBox.Show(e.Message + "1");
                                continue;
                            }
                        }
                        else
                        {
                            try
                            {
                                definition.cSubjekt.Add(subjekt);
                                definition.Ulice.Add(s);
                                definition.cp.Add("");
                                definition.co.Add("");
                                //this.updateDataToDB(sql, tab, subjekt, s, "", "", bw);
                            }
                            catch (Exception e)
                            {
                                err_cnt++;
                                //pgb.Value++;
                                MessageBox.Show(e.Message + "2");
                                continue;
                            }
                        }
                    }
                    reader_org.Close();
                }
                sql.Close();
            }

            MessageBox.Show("" + definition.cSubjekt.Count() + " " + definition.Ulice.Count() + " " + definition.cp.Count() + " " + definition.co.Count());
            MessageBox.Show(err_cnt.ToString());

        }

        //public void updateDataToDB(SqlConnection sql, string tab, int cislo_subjektu, string ulice, string cp, string co, BackgroundWorker bw)
        public void updateDataToDB(string tab, BackgroundWorker bw)
        {
            Definitions definition = new Definitions();
            string connection = @"";

            //MessageBox.Show(err_cnt.ToString());

            using (SqlConnection sql = new SqlConnection(connection))
            {
                sql.Open();
                SqlCommand update_org = new SqlCommand("UPDATE " + tab + " SET ulice_ds = @ulice, cislo_cp = @cp, cislo_co = @co where " + tab + ".cislo_subjektu = @subjekt", sql);

                for (int i = 0; i < definition.cSubjekt.Count(); i++)
                {

                    update_org.Parameters.Clear();

                    SqlParameter subjektParam = new SqlParameter("@subjekt", SqlDbType.Int);
                    SqlParameter uliceParam = new SqlParameter("@ulice", SqlDbType.VarChar, 255);
                    SqlParameter cpParam = new SqlParameter("@cp", SqlDbType.VarChar, 5);
                    SqlParameter coParam = new SqlParameter("@co", SqlDbType.VarChar, 5);

                    subjektParam.Value = definition.cSubjekt[i];
                    uliceParam.Value = definition.Ulice[i];
                    cpParam.Value = definition.cp[i];
                    coParam.Value = definition.co[i];

                    /*subjektParam.Value = cislo_subjektu;
                    uliceParam.Value = ulice;
                    cpParam.Value = co;
                    coParam.Value = cp;*/

                    // Command for name
                    update_org.Parameters.Add(subjektParam);
                    update_org.Parameters.Add(uliceParam);
                    update_org.Parameters.Add(cpParam);
                    update_org.Parameters.Add(coParam);

                    // Call Prepare after setting the Commandtext and Parameters.
                    update_org.Prepare();


                    //MessageBox.Show(subjektParam.Value.ToString());
                    //MessageBox.Show(uliceParam.Value.ToString());

                    update_org.ExecuteNonQuery();
                    //bw.ReportProgress((int)(++updated) / 3600);
                    //label2.Text = updated.ToString();
                }
            }
        }

        public int updated = 0;

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Tak jsem skončil s updatem...");
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
            label1.Text = progressBar2.Value.ToString();
        }

    }
}
