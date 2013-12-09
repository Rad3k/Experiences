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
    class SQLSelectExpIn
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
                using (SqlCommand select_org = new SqlCommand("SELECT lcs.expozitura_vlastni.cislo_subjektu, lcs.expozitura_vlastni.ulice FROM lcs.expozitura_vlastni WHERE zeme = 1041073 or zeme = 79", sql))
                using (SqlDataReader reader_org = select_org.ExecuteReader())
                {
                    while (reader_org.Read())
                    {
                        subjekt = reader_org.GetInt32(0);
                        s = reader_org.GetString(1);
                        var input = new List<string>() { s };

                        foreach (var item in input)
                        {
                            var workItem = item.Trim().Replace("/", " ").Split(' ').Where(i => "" != i.Trim()).ToList();

                            if (workItem.Count() > 1)
                            {
                                if (s.Contains('/'))
                                {
                                    firstRightDigit = workItem[workItem.Count() - 1];
                                    secondRightDigit = workItem[workItem.Count() - 2];
                                }
                                else
                                    firstRightDigit = workItem[workItem.Count() - 1];

                                int CO = 0;
                                if (!Int32.TryParse(secondRightDigit, out CO))
                                {
                                    secondRightDigit = firstRightDigit;
                                    firstRightDigit = "";
                                }

                                ulice = s.Replace(secondRightDigit, "");
                                ulice = ulice.Replace(firstRightDigit, "");
                                ulice = ulice.Replace('/', ' ');
                            }
                        }
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
                using (SqlCommand update_org = new SqlCommand("UPDATE lcs.expozitura_vlastni SET ulice = @ulice where lcs.expozitura_vlastni.cislo_subjektu = @subjekt", sql))
                {
                    update_org.Parameters.Clear();

                    SqlParameter subjektParam = new SqlParameter("@subjekt", SqlDbType.Int);
                    SqlParameter uliceParam = new SqlParameter("@ulice", SqlDbType.VarChar, 50);

                    subjektParam.Value = subjekt;
                    uliceParam.Value = ulice;

                    // Command for name
                    update_org.Parameters.Add(subjektParam);
                    update_org.Parameters.Add(uliceParam);

                    // Call Prepare after setting the Commandtext and Parameters.
                    update_org.Prepare();
                    update_org.ExecuteNonQuery();
                }
            }
            using (SqlConnection sql = new SqlConnection(connection))
            {
                sql.Open();
                using (SqlCommand update_org = new SqlCommand("UPDATE lcs.expozitura_vlastni SET cislo_cp = @cp where lcs.expozitura_vlastni.cislo_subjektu = @subjekt", sql))
                {
                    update_org.Parameters.Clear();

                    SqlParameter subjektParam = new SqlParameter("@subjekt", SqlDbType.Int);
                    SqlParameter cpParam = new SqlParameter("@cp", SqlDbType.VarChar, 50);

                    subjektParam.Value = subjekt;
                    cpParam.Value = secondRightDigit;

                    // Command for name
                    update_org.Parameters.Add(subjektParam);
                    update_org.Parameters.Add(cpParam);

                    // Call Prepare after setting the Commandtext and Parameters.
                    update_org.Prepare();
                    update_org.ExecuteNonQuery();
                }
            }
            using (SqlConnection sql = new SqlConnection(connection))
            {
                sql.Open();
                using (SqlCommand update_org = new SqlCommand("UPDATE lcs.expozitura_vlastni SET cislo_co = @co where lcs.expozitura_vlastni.cislo_subjektu = @subjekt", sql))
                {
                    update_org.Parameters.Clear();

                    SqlParameter subjektParam = new SqlParameter("@subjekt", SqlDbType.Int);
                    SqlParameter coParam = new SqlParameter("@co", SqlDbType.VarChar, 50);

                    subjektParam.Value = subjekt;
                    coParam.Value = firstRightDigit;

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