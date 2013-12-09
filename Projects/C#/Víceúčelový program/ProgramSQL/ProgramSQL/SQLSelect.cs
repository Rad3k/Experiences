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
using ProgramSQL;
using System.Data.SqlClient;

namespace ProgramSQL
{
    class SQLSelect
    {
        public void selectDataFromDB()
        {
            string connection = "Data Source=RADEK-PC\\SQLEXPRESS;Initial Catalog=Organization;Integrated Security=True;";

            using (SqlConnection sql = new SqlConnection(connection))
            {
                sql.Open();
                using (SqlCommand select_org = new SqlCommand("SELECT * FROM dbo.org where organizace = '' or adresa_ulice = '' or psc = '' or ico = ''", sql))
                using (SqlDataReader reader_org = select_org.ExecuteReader())
                {
                    while (reader_org.Read())
                    {
                        Definitions.jmeno_org.Add(reader_org.GetString(2));
                        Definitions.adresa_org.Add(reader_org.GetString(3));
                        Definitions.psc_org.Add(reader_org.GetString(4));
                        Definitions.ico_org.Add(reader_org.GetString(5));
                    }
                }
                using (SqlCommand select_expo = new SqlCommand("SELECT * FROM dbo.expozitura where organizace = '' or adresa_ulice = '' or psc = '' or ico = ''", sql))
                using (SqlDataReader reader_expo = select_expo.ExecuteReader())
                {
                    while (reader_expo.Read())
                    {
                        Definitions.jmeno_exp.Add(reader_expo.GetString(2));
                        Definitions.adresa_exp.Add(reader_expo.GetString(3));
                        Definitions.psc_exp.Add(reader_expo.GetString(4));
                        Definitions.ico_exp.Add(reader_expo.GetString(5));
                    }
                }
                using (SqlCommand select_fa = new SqlCommand("SELECT * FROM dbo.fakturacni_adresa where organizace = '' or adresa_ulice = '' or psc = '' or ico = ''", sql))
                using (SqlDataReader reader_fa = select_fa.ExecuteReader())
                {
                    while (reader_fa.Read())
                    {
                        Definitions.jmeno_fa.Add(reader_fa.GetString(2));
                        Definitions.adresa_fa.Add(reader_fa.GetString(3));
                        Definitions.psc_fa.Add(reader_fa.GetString(4));
                        Definitions.ico_fa.Add(reader_fa.GetString(5));
                    }
                }
            }
        }
    }
}
