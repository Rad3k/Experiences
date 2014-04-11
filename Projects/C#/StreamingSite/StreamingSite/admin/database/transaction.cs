using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using rad3k_eu.order.classes;

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
        public string test;

        public transaction()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Rad3kConnection"].ToString();
            conn = new SqlConnection(connectionString);
        }

        public string signInToSystem(string name, string password)
        {
            string hodnota;
            string newPass = hashPassword.CreateHash(password);
            commandI = new SqlCommand("INSERT INTO dbo.users VALUES (3, @name, @password, 0)", conn);
            try
            {
                conn.Open();
                commandI.Parameters.Clear();

                // Parameters
                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 30);
                SqlParameter passwordParam = new SqlParameter("@password", SqlDbType.VarChar, 255);

                nameParam.Value = name;
                passwordParam.Value = newPass;
                commandI.Parameters.Add(nameParam);
                commandI.Parameters.Add(passwordParam);
                commandI.Prepare();
                commandI.ExecuteNonQuery();

                return hodnota = "Transakce byla úspěšně provedena";
            }
            catch (SqlException e)
            {
                return hodnota = "Nastala chyba během samotné transakce: " + e;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool loginVerification(string name, string password)
        {
            bool access = false;
            string checkLogin, checkPassword;
            int level;

            commandS = new SqlCommand("SELECT * FROM dbo.users WHERE user like 'Rad3k'", conn);
            try
            {
                conn.Open();
                commandS.Parameters.Clear();

                // Parameters
                SqlParameter nameParam = new SqlParameter("@user", SqlDbType.VarChar, 30);
                nameParam.Value = name;
                commandS.Parameters.Add(nameParam);
                commandS.Prepare();
                SqlDataReader reader = commandS.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                        if (reader.IsDBNull(i))
                            return access = false;

                    checkLogin = reader.GetString(1);
                    checkPassword = reader.GetString(2);
                    level = reader.GetInt32(3);
                    test = name;

                    if (name == checkLogin && hashPassword.ValidatePassword(password, checkPassword) == true)
                        access = true;
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
                    for (int i = 0; i < reader.FieldCount; i++)
                        if (reader.IsDBNull(i))
                            return access = false;

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

        public string saveTicket(string type, string atribute, string message, string typePotion, string typeName, string value, string email)
        {
            switch (UniqueValue.value)
            {
                case 1:
                    commandI = new SqlCommand("INSERT INTO dbo.tickets VALUES (@type, @atribute, @message, 0, @typeName, 0, @email, 'N')", conn);
                    break;
                case 2:
                    commandI = new SqlCommand("INSERT INTO dbo.tickets VALUES (@type, @atribute, @message, 0, 0, 0, @email, 'N')", conn);
                    break;
                case 3:
                    commandI = new SqlCommand("INSERT INTO dbo.tickets VALUES (@type, @atribute, @message, 0, @typeName, @value, @email, 'N')", conn);
                    break;
                case 4:
                    commandI = new SqlCommand("INSERT INTO dbo.tickets VALUES (@type, @atribute, @message, @typePotion, 0, @value, @email, 'N')", conn);
                    break;
            }

            try
            {
                conn.Open();
                commandI.Parameters.Clear();

                // Parameters
                SqlParameter typeParam = new SqlParameter("@type", SqlDbType.VarChar, 80);
                typeParam.Value = type;
                SqlParameter atributeParam = new SqlParameter("@atribute", SqlDbType.VarChar, 80);
                atributeParam.Value = atribute;
                SqlParameter messageParam = new SqlParameter("@message", SqlDbType.VarChar, 255);
                messageParam.Value = message;
                SqlParameter potionParam = new SqlParameter("@typePotion", SqlDbType.VarChar, 80);
                potionParam.Value = typePotion;
                SqlParameter nameParam = new SqlParameter("@typeName", SqlDbType.VarChar, 80);
                nameParam.Value = typeName;
                SqlParameter valueParam = new SqlParameter("@value", SqlDbType.VarChar, 80);
                valueParam.Value = value;
                SqlParameter emailParam = new SqlParameter("@email", SqlDbType.VarChar, 80);
                emailParam.Value = email;

                // Add parameters
                commandI.Parameters.Add(typeParam);
                commandI.Parameters.Add(atributeParam);
                commandI.Parameters.Add(messageParam);
                commandI.Parameters.Add(potionParam);
                commandI.Parameters.Add(nameParam);
                commandI.Parameters.Add(valueParam);
                commandI.Parameters.Add(emailParam);

                commandI.Prepare();
                commandI.ExecuteNonQuery();

                return "done";
            }
            finally
            {
                conn.Close();
            }
        }

        public ArrayList selectOrderGame()
        {
            ArrayList hry = new ArrayList();
            commandS = new SqlCommand("SELECT typeTicket, typeMethod, message, typeName, value, status FROM dbo.tickets WHERE typeTicket LIKE 'Objednávka' AND typeMethod LIKE 'Hry'", conn);

            try
            {
                conn.Open();
                SqlDataReader reader = commandS.ExecuteReader();

                while (reader.Read())
                {
                    string typeTicket = reader.GetString(0);
                    string typeMethod = reader.GetString(1);
                    string message = reader.GetString(2);
                    string typeName = reader.GetString(3);
                    string value = reader.GetString(4);
                    string status = reader.GetString(5);

                    games game = new games(typeTicket, typeMethod, message, typeName, value, status);
                    hry.Add(game);
                }

                return hry;
            }
            finally
            {
                conn.Close();
            }
        }

        public ArrayList selectOrderCraft()
        {
            ArrayList craftList = new ArrayList();
            commandS = new SqlCommand("SELECT typeTicket, typeMethod, message, typePotion, value, email, status FROM dbo.tickets WHERE typeTicket LIKE 'Objednávka' AND typeMethod LIKE 'Craft'", conn);

            try
            {
                conn.Open();
                SqlDataReader reader = commandS.ExecuteReader();

                while (reader.Read())
                {
                    string typeTicket = reader.GetString(0);
                    string typeMethod = reader.GetString(1);
                    string message = reader.GetString(2);
                    string typePotion = reader.GetString(3);
                    string value = reader.GetString(4);
                    string nick = reader.GetString(5);
                    string status = reader.GetString(6);

                    crafting craft = new crafting(typeTicket, typeMethod, message, typePotion, value, nick, status);
                    craftList.Add(craft);
                }

                return craftList;
            }
            finally
            {
                conn.Close();
            }
        }

        public string saveBusiness(string type, string atribute, string message, string typZbozi, string jmenoZbozi, string value, string nick)
        {
            commandI = new SqlCommand("INSERT INTO dbo.obchod VALUES (@type, @atribute, @message, @typeThing, @typeName, @value, @nick, GETDATE())", conn);

            try
            {
                conn.Open();
                commandI.Parameters.Clear();

                // Parameters
                SqlParameter typeParam = new SqlParameter("@type", SqlDbType.VarChar, 80);
                typeParam.Value = type;
                SqlParameter atributeParam = new SqlParameter("@atribute", SqlDbType.VarChar, 80);
                atributeParam.Value = atribute;
                SqlParameter messageParam = new SqlParameter("@message", SqlDbType.VarChar, 255);
                messageParam.Value = message;
                SqlParameter typZboziParam = new SqlParameter("@typeThing", SqlDbType.VarChar, 80);
                typZboziParam.Value = typZbozi;
                SqlParameter nameParam = new SqlParameter("@typeName", SqlDbType.VarChar, 80);
                nameParam.Value = jmenoZbozi;
                SqlParameter valueParam = new SqlParameter("@value", SqlDbType.VarChar, 80);
                valueParam.Value = value;
                SqlParameter nickParam = new SqlParameter("@nick", SqlDbType.VarChar, 80);
                nickParam.Value = nick;

                // Add parameters
                commandI.Parameters.Add(typeParam);
                commandI.Parameters.Add(atributeParam);
                commandI.Parameters.Add(messageParam);
                commandI.Parameters.Add(typZboziParam);
                commandI.Parameters.Add(nameParam);
                commandI.Parameters.Add(valueParam);
                commandI.Parameters.Add(nickParam);

                commandI.Prepare();
                commandI.ExecuteNonQuery();

                return "done";
            }
            finally
            {
                conn.Close();
            }
        }

        public ArrayList selectBusinessType(char typeN)
        {
            ArrayList obchodList = new ArrayList();
            switch (typeN)
            {
                case 'D':
                    commandS = new SqlCommand("SELECT * FROM dbo.obchod ORDER BY datum", conn);
                    break;
                case 'N':
                    commandS = new SqlCommand("SELECT * FROM dbo.obchod WHERE methods LIKE 'Nakoupím' ORDER BY datum", conn);
                    break;
                case 'P':
                    commandS = new SqlCommand("SELECT * FROM dbo.obchod WHERE methods LIKE 'Prodám' ORDER BY datum", conn);
                    break;
                case 'V':
                    commandS = new SqlCommand("SELECT * FROM dbo.obchod WHERE methods LIKE 'Vyměním' ORDER BY datum", conn);
                    break;
            }

            try
            {
                conn.Open();
                SqlDataReader reader = commandS.ExecuteReader();

                while (reader.Read())
                {
                    Int64 id = reader.GetInt64(0);
                    string type = reader.GetString(1);
                    string typeMethod = reader.GetString(2);
                    string vec = reader.GetString(3);
                    string message = reader.GetString(4);
                    string name = reader.GetString(5);
                    string value = reader.GetString(6);
                    string nick = reader.GetString(7);
                    string datum = reader.GetDateTime(8).ToString().Replace("0:00:00", "");

                    Obchod obchod = new Obchod(type, typeMethod, vec, message, name, value, nick, datum);
                    obchodList.Add(obchod);
                }

                return obchodList;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}