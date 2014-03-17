using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace rad3k_eu.admin.database
{
    public class transaction
    {
        private static SqlConnection conn;
        private SqlCommand commandS;
        private SqlCommand commandU;
        private SqlCommand commandI;

        // Home page - definiton
        public string[] title = new string[3];
        public string description;
        public string[] section = new string[13];

        public transaction()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Rad3kConnection"].ToString();
            conn = new SqlConnection(connectionString);
        }

        public bool loginVerification(string name, string password)
        {
            bool access = false;
            string checkLogin, checkPassword;
            commandS = new SqlCommand("SELECT * FROM dbo.users WHERE user = @name", conn);
            try
            {
                conn.Open();
                commandS.Parameters.Clear();

                // Parameters
                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 30);
                nameParam.Value = name;
                commandS.Parameters.Add(nameParam);
                commandS.Prepare();
                SqlDataReader reader = commandS.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.IsDBNull(1) || reader.IsDBNull(2))
                    {
                        access = false;
                        continue;
                    }
                    else
                    {
                        checkLogin = reader.GetString(1);
                        checkPassword = reader.GetString(2);

                        if (name == checkLogin && hashPassword.ValidatePassword(password, checkPassword) == true)
                            access = true;
                    }
                }

                return access;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool selectHomePage(char pos)
        {
            bool access = true;
            commandS = new SqlCommand("SELECT title.text, title1.text, title2.text, home.description, "
                + "section1.text, section2.text, section3.text, section4.text, section5.text, section6.text, section7.text, section8.text "
                + "section9.text, section10.text, section11.text, section12.text, section13.text "
                + "FROM dbo.page home JOIN dbo.titles title ON title.ID = home.titul1 "
                + "JOIN dbo.titles title1 ON title1.ID = home.titul2 JOIN dbo.titles title2 ON title2.ID = home.titul3 "
                + "JOIN dbo.sections section1 ON section1.ID = home.section1 JOIN dbo.sections section2 ON section2.ID = home.section2 "
                + "JOIN dbo.sections section3 ON section3.ID = home.section3 JOIN dbo.sections section4 ON section4.ID = home.section4 "
                + "JOIN dbo.sections section5 ON section5.ID = home.section5 JOIN dbo.sections section6 ON section6.ID = home.section6 "
                + "JOIN dbo.sections section7 ON section7.ID = home.section7 JOIN dbo.sections section8 ON section8.ID = home.section8 "
                + "JOIN dbo.sections section9 ON section9.ID = home.section9 JOIN dbo.sections section10 ON section10.ID = home.section10 "
                + "JOIN dbo.sections section11 ON section11.ID = home.section11 JOIN dbo.sections section12 ON section12.ID = home.section12 "
                + "JOIN dbo.sections section13 ON section13.ID = home.section13 "
                + "WHERE inicial like @pos", conn);

            try
            {
                conn.Open();
                commandS.Parameters.Clear();

                // Parameters
                SqlParameter posParam = new SqlParameter("@pos", SqlDbType.Char, 1);
                posParam.Value = pos;
                commandS.Parameters.Add(posParam);
                commandS.Prepare();
                SqlDataReader reader = commandS.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < 11; i++)
                    {
                        if (reader.IsDBNull(i))
                        {
                            access = false;
                            continue;
                        }
                    }
                    if (access)
                    {
                        title[0] = reader.GetString(0);
                        title[1] = reader.GetString(1);
                        title[2] = reader.GetString(2);
                        description = reader.GetString(3);
                        section[0] = reader.GetString(4);
                        section[1] = reader.GetString(5);
                        section[2] = reader.GetString(6);
                        section[3] = reader.GetString(7);
                        section[4] = reader.GetString(8);
                        section[5] = reader.GetString(9);
                        section[6] = reader.GetString(10);
                        section[7] = reader.GetString(11);
                        section[8] = reader.GetString(12);
                        section[9] = reader.GetString(13);
                        section[10] = reader.GetString(14);
                        section[11] = reader.GetString(15);
                        section[12] = reader.GetString(16);
                    }
                }

                return access;
            }

            finally
            {
                conn.Close();
            }
        }
    }
}