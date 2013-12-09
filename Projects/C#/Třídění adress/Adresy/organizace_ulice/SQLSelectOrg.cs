using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using organizace_ulice;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace organizace_ulice
{
    class SQLSelectOrg
    {
        public int subjekt;
        public string s;

        public void selectDataFromDB(string tab)
        {
            string connection = @"";
            int err_cnt = 0;

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
                            mt = Regex.Match(s, @"([\.\,\ A-Ža-ž0-9]*) ([0-9]+[a-zA-Z]?[\/]?)?([0-9]+[a-zA-Z]?)$");
                        }
                        catch (Exception e)
                        {
                            this.updateDataToDB(sql, tab, subjekt, s, "", "");
                            //pgb.Value++;
                            err_cnt++;
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
                            try
                            {
                                this.updateDataToDB(sql, tab, subjekt, ulice, cp, co);
                            }
                            catch (Exception e)
                            {
                                //pgb.Value++;
                                err_cnt++;
                                continue;
                            }
                        }
                        else
                        {
                            try
                            {
                                this.updateDataToDB(sql, tab, subjekt, s, "", "");
                            }
                            catch (Exception e)
                            {
                                err_cnt++;
                                //pgb.Value++;
                                continue;
                            }
                        }
                    }
                }
            }

            MessageBox.Show(err_cnt.ToString());

        }

        public void updateDataToDB(SqlConnection sql, string tab, int cislo_subjektu, string ulice, string cp, string co)
        {
            using (SqlCommand update_org = new SqlCommand("UPDATE " + tab + " SET ulice_ds = @ulice, cislo_cp = @cp, cislo_co = @co where " + tab + ".cislo_subjektu = @subjekt", sql))
            {
                    update_org.Parameters.Clear();

                    SqlParameter subjektParam = new SqlParameter("@subjekt", SqlDbType.Int);
                    SqlParameter uliceParam = new SqlParameter("@ulice", SqlDbType.VarChar, 255);
                    SqlParameter cpParam = new SqlParameter("@cp", SqlDbType.VarChar, 5);
                    SqlParameter coParam = new SqlParameter("@co", SqlDbType.VarChar, 5);

                    subjektParam.Value = cislo_subjektu;
                    uliceParam.Value = ulice;
                    cpParam.Value = co;
                    coParam.Value = cp;

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
            }
        }
    }
}
