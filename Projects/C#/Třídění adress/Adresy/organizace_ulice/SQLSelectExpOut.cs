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
    class SQLSelectExpOut
    {
        public int subjekt;
        public string s;
        public string ulice;
        public string firstRightDigit;
        public string secondRightDigit;
        public string cp;

        public void selectDataFromDB()
        {
            string connection = @"";

            using (SqlConnection sql = new SqlConnection(connection))
            {
                sql.Open();
                using (SqlCommand select_org = new SqlCommand("SELECT lcs.expozitura_cizi.cislo_subjektu, lcs.expozitura_cizi.ulice FROM lcs.expozitura_cizi WHERE (zeme = 1041073 or zeme = 79) and ulice is not null", sql))
                using (SqlDataReader reader_org = select_org.ExecuteReader())
                {
                    while (reader_org.Read())
                    {
                        if (reader_org.IsDBNull(0) | reader_org.IsDBNull(1))
                            continue;

                        subjekt = reader_org.GetInt32(0);
                        s = reader_org.GetString(1);
                        var input = new List<string>() { s };

                        ulice = "";
                        secondRightDigit = "";
                        firstRightDigit = "";

                        foreach (var item in input)
                        {
                            var workItem = item.Trim().Replace("/", " ").Split(' ').Where(i => "" != i.Trim()).ToList();

                            if (workItem.Count() > 1)
                            {
                                if (s.Contains('/'))
                                {
                                    firstRightDigit = workItem[workItem.Count() - 1];
                                    secondRightDigit = workItem[workItem.Count() - 2];

                                    ulice = s;
                                    ulice = ulice.Replace('/', ' ');
                                    ulice = ulice.Replace(secondRightDigit, "");
                                    ulice = ulice.Replace(firstRightDigit, "");
                                }
                                else
                                {
                                    Match m = Regex.Match(firstRightDigit = workItem[workItem.Count() - 1], @"((\d+)/?(\d+))");
                                    cp = m.Groups[0].Value;
                                    firstRightDigit = cp;

                                    ulice = s;
                                    if (firstRightDigit != "")
                                        ulice = s.Replace(firstRightDigit, "").Trim();
                                }

                                int CO = 0;
                                if (!Int32.TryParse(secondRightDigit, out CO))
                                {
                                    Match m = Regex.Match(secondRightDigit = firstRightDigit, @"((\d+)/?(\d+))");
                                    cp = m.Groups[0].Value;
                                    secondRightDigit = cp;

                                    firstRightDigit = "";
                                }
                            }
                        }

                        Definitions.cSubjekt.Add(subjekt);
                        Definitions.Ulice.Add(ulice);
                        Definitions.cp.Add(secondRightDigit);
                        Definitions.co.Add(firstRightDigit);
                    }
                }
            }
        }
        public void updateDataToDB()
        {
            string connection = @"";

            using (SqlConnection sql = new SqlConnection(connection))
            {
                sql.Open();
                using (SqlCommand update_org = new SqlCommand("UPDATE lcs.expozitura_cizi SET ulice_ds = @ulice where lcs.expozitura_cizi.cislo_subjektu = @subjekt", sql))
                {
                    for (int i = 0; i < Definitions.cSubjekt.Count(); i++)
                    {
                        update_org.Parameters.Clear();

                        SqlParameter subjektParam = new SqlParameter("@subjekt", SqlDbType.Int);
                        SqlParameter uliceParam = new SqlParameter("@ulice", SqlDbType.VarChar, 255);

                        subjektParam.Value = Definitions.cSubjekt[i];
                        uliceParam.Value = Definitions.Ulice[i];

                        // Command for name
                        update_org.Parameters.Add(subjektParam);
                        update_org.Parameters.Add(uliceParam);

                        // Call Prepare after setting the Commandtext and Parameters.
                        update_org.Prepare();
                        update_org.ExecuteNonQuery();
                    }
                }
            }
            using (SqlConnection sql = new SqlConnection(connection))
            {
                sql.Open();
                using (SqlCommand update_org = new SqlCommand("UPDATE lcs.expozitura_cizi SET cislo_cp = @cp where lcs.expozitura_cizi.cislo_subjektu = @subjekt", sql))
                {
                    for (int i = 0; i < Definitions.cSubjekt.Count(); i++)
                    {
                        update_org.Parameters.Clear();

                        SqlParameter subjektParam = new SqlParameter("@subjekt", SqlDbType.Int);
                        SqlParameter cpParam = new SqlParameter("@cp", SqlDbType.VarChar, 5);

                        subjektParam.Value = Definitions.cSubjekt[i];
                        cpParam.Value = Definitions.cp[i]; ;

                        // Command for name
                        update_org.Parameters.Add(subjektParam);
                        update_org.Parameters.Add(cpParam);

                        // Call Prepare after setting the Commandtext and Parameters.
                        update_org.Prepare();
                        update_org.ExecuteNonQuery();
                    }
                }
            }
            using (SqlConnection sql = new SqlConnection(connection))
            {
                sql.Open();
                using (SqlCommand update_org = new SqlCommand("UPDATE lcs.expozitura_cizi SET cislo_co = @co where lcs.expozitura_cizi.cislo_subjektu = @subjekt", sql))
                {
                    for (int i = 0; i < Definitions.cSubjekt.Count(); i++)
                    {
                        update_org.Parameters.Clear();

                        SqlParameter subjektParam = new SqlParameter("@subjekt", SqlDbType.Int);
                        SqlParameter coParam = new SqlParameter("@co", SqlDbType.VarChar, 5);

                        subjektParam.Value = Definitions.cSubjekt[i];
                        coParam.Value = Definitions.co[i];

                        // Command for name
                        update_org.Parameters.Add(subjektParam);
                        update_org.Parameters.Add(coParam);

                        // Call Prepare after setting the Commandtext and Parameters.
                        update_org.Prepare();
                        update_org.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
