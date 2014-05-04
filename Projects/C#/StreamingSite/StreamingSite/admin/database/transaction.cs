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
        public string description, nadpis, text, informace;
        public string[] section = new string[15];

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

            commandS = new SqlCommand("SELECT * FROM dbo.users WHERE [user] like @user", conn);
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
            switch (pos)
            {
                case 'L':
                    commandS = new SqlCommand("SELECT title.text, title1.text, title2.text, home.description, section1.text, section2.text, section3.text, section4.text, section5.text "
                        + ", section6.text, section7.text, section8.text, section9.text, section10.text, section11.text, section12.text, section13.text, section14.text, section15.text "
                        + "FROM dbo.page home "
                        + "JOIN dbo.titles title ON title.ID = home.titul1 "
                        + "JOIN dbo.titles title1 ON title1.ID = home.titul2 "
                        + "JOIN dbo.titles title2 ON title2.ID = home.titul3 "
                        + "JOIN dbo.sections section1 ON section1.ID = home.section1 "
                        + "JOIN dbo.sections section2 ON section2.ID = home.section2 "
                        + "JOIN dbo.sections section3 ON section3.ID = home.section3 "
                        + "JOIN dbo.sections section4 ON section4.ID = home.section4 "
                        + "JOIN dbo.sections section5 ON section5.ID = home.section5 "
                        + "JOIN dbo.sections section6 ON section6.ID = home.section6 "
                        + "JOIN dbo.sections section7 ON section7.ID = home.section7 "
                        + "JOIN dbo.sections section8 ON section8.ID = home.section8 "
                        + "JOIN dbo.sections section9 ON section9.ID = home.section9 "
                        + "JOIN dbo.sections section10 ON section10.ID = home.section10 "
                        + "JOIN dbo.sections section11 ON section11.ID = home.section11 "
                        + "JOIN dbo.sections section12 ON section12.ID = home.section12 "
                        + "JOIN dbo.sections section13 ON section13.ID = home.section13 "
                        + "JOIN dbo.sections section14 ON section14.ID = home.section14 "
                        + "JOIN dbo.sections section15 ON section15.ID = home.section15 "
                        + "WHERE inicial like @pos", conn);
                    break;
                case 'R':
                    commandS = new SqlCommand("SELECT title.text, title1.text, title2.text, home.description, section1.text, section2.text, section3.text, section4.text, section5.text "
                        + ", section6.text, section7.text, section8.text, section9.text, section10.text "
                        + "FROM dbo.page home "
                        + "JOIN dbo.titles title ON title.ID = home.titul1 "
                        + "JOIN dbo.titles title1 ON title1.ID = home.titul2 "
                        + "JOIN dbo.titles title2 ON title2.ID = home.titul3 "
                        + "JOIN dbo.sections section1 ON section1.ID = home.section1 "
                        + "JOIN dbo.sections section2 ON section2.ID = home.section2 "
                        + "JOIN dbo.sections section3 ON section3.ID = home.section3 "
                        + "JOIN dbo.sections section4 ON section4.ID = home.section4 "
                        + "JOIN dbo.sections section5 ON section5.ID = home.section5 "
                        + "JOIN dbo.sections section6 ON section6.ID = home.section6 "
                        + "JOIN dbo.sections section7 ON section7.ID = home.section7 "
                        + "JOIN dbo.sections section8 ON section8.ID = home.section8 "
                        + "JOIN dbo.sections section9 ON section9.ID = home.section9 "
                        + "JOIN dbo.sections section10 ON section10.ID = home.section10 "
                        + "WHERE inicial like @pos", conn);
                    break;
            }

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
                        if (pos == 'L')
                        {
                            section[10] = reader.GetString(14);
                            section[11] = reader.GetString(15);
                            section[12] = reader.GetString(16);
                            section[13] = reader.GetString(17);
                            section[14] = reader.GetString(18);
                        }
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
                    commandI = new SqlCommand("INSERT INTO dbo.tickets VALUES (@type, @atribute, @message, 0, @typeName, 0, @email, 'N', GETDATE())", conn);
                    break;
                case 2:
                    commandI = new SqlCommand("INSERT INTO dbo.tickets VALUES (@type, @atribute, @message, 0, 0, 0, @email, 'N', GETDATE())", conn);
                    break;
                case 3:
                    commandI = new SqlCommand("INSERT INTO dbo.tickets VALUES (@type, @atribute, @message, 0, @typeName, @value, @email, 'N', GETDATE())", conn);
                    break;
                case 4:
                    commandI = new SqlCommand("INSERT INTO dbo.tickets VALUES (@type, @atribute, @message, @typePotion, 0, @value, @email, 'N', GETDATE())", conn);
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
            commandS = new SqlCommand("SELECT typeTicket, typeMethod, message, typeName, value, status FROM dbo.tickets WHERE typeTicket LIKE 'Objednávka' AND typeMethod LIKE 'Hry' ORDER BY datum", conn);

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
            commandS = new SqlCommand("SELECT typeTicket, typeMethod, message, typePotion, value, email, status FROM dbo.tickets WHERE typeTicket LIKE 'Objednávka' AND typeMethod LIKE 'Craft' ORDER BY datum", conn);

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

        public string ulozeniSmlovuy(string jmeno, string prijmeni, string pozice, DateTime datumNastupu, DateTime datumUkonceni, string zprava)
        {
            commandI = new SqlCommand("INSERT INTO dbo.smlouvy VALUES (@jmeno, @prijmeni, @pozice, @zprava, @datumOd, @datumDo)");

            try
            {
                conn.Open();
                commandI.Parameters.Clear();

                // Parameters
                SqlParameter jmenoParam = new SqlParameter("@jmeno", SqlDbType.VarChar, 80);
                jmenoParam.Value = jmeno;
                SqlParameter prijmeniParam = new SqlParameter("@prijmeni", SqlDbType.VarChar, 80);
                prijmeniParam.Value = prijmeni;
                SqlParameter poziceParam = new SqlParameter("@pozice", SqlDbType.VarChar, 80);
                poziceParam.Value = pozice;
                SqlParameter datumNastupuParam = new SqlParameter("@datumOd", SqlDbType.Date);
                datumNastupuParam.Value = datumNastupu;
                SqlParameter datumUkonceniParam = new SqlParameter("@datumDo", SqlDbType.Date);
                datumUkonceniParam.Value = datumUkonceni;
                SqlParameter zpravaParam = new SqlParameter("@zprava", SqlDbType.VarChar, 255);
                zpravaParam.Value = zprava;

                // Add parameters
                commandI.Parameters.Add(jmenoParam);
                commandI.Parameters.Add(prijmeniParam);
                commandI.Parameters.Add(poziceParam);
                commandI.Parameters.Add(datumNastupuParam);
                commandI.Parameters.Add(datumUkonceniParam);
                commandI.Parameters.Add(zpravaParam);

                commandI.Prepare();
                commandI.ExecuteNonQuery();

                return "done";
            }
            finally
            {
                conn.Close();
            }
        }

        public bool selectPagesInformation(char pos)
        {
            bool access = true;
            switch (pos)
            {
                case 'O':
                    commandS = new SqlCommand("SELECT page.nadpis, page.text, page.other FROM dbo.pages page WHERE inicial LIKE @pos", conn);
                    break;
                case 'P':
                    commandS = new SqlCommand("SELECT page.nadpis, page.text FROM dbo.pages page WHERE inicial LIKE @pos", conn);
                    break;
                case 'K':
                    commandS = new SqlCommand("SELECT page.nadpis, page.text FROM dbo.pages page WHERE inicial LIKE @pos", conn);
                    break;
            }

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
                        nadpis = reader.GetString(0);
                        text = reader.GetString(1);
                        if (pos == 'O')
                            informace = reader.GetString(2);
                    }
                }

                return access;
            }

            finally
            {
                conn.Close();
            }
        }

        public bool selectFavouriteGames(char pos)
        {
            bool access = true;
            commandS = new SqlCommand("SELECT title.text, section1.text, section2.text, section3.text, section4.text "
            + "FROM dbo.page page "
            + "JOIN dbo.titles title ON title.ID = page.titul1 "
            + "JOIN dbo.sections section1 ON section1.ID = page.section1 "
            + "JOIN dbo.sections section2 ON section2.ID = page.section2 "
            + "JOIN dbo.sections section3 ON section3.ID = page.section3 "
            + "JOIN dbo.sections section4 ON section4.ID = page.section4 "
            + "WHERE inicial LIKE @pos", conn);

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
                        section[0] = reader.GetString(1);
                        section[1] = reader.GetString(2);
                        section[2] = reader.GetString(3);
                        section[3] = reader.GetString(4);
                    }
                }

                return access;
            }

            finally
            {
                conn.Close();
            }
        }

        public bool selectQuickBar()
        {
            bool access = true;
            commandS = new SqlCommand("SELECT quick.nadpis, quick.text, odkazy.url, odkazy.alias, odkazy_2.url, odkazy_2.alias, odkazy_3.url, odkazy_3.alias, odkazy_4.url, odkazy_4.alias "
            + "FROM dbo.quickbar quick "
            + "JOIN dbo.odkazy odkazy ON odkazy.ID = quick.odkaz_1 "
            + "JOIN dbo.odkazy odkazy_2 ON odkazy_2.ID = quick.odkaz_2 "
            + "JOIN dbo.odkazy odkazy_3 ON odkazy_3.ID = quick.odkaz_3 "
            + "JOIN dbo.odkazy odkazy_4 ON odkazy_4.ID = quick.odkaz_4", conn);

            try
            {
                conn.Open();
                commandS.Prepare();
                SqlDataReader reader = commandS.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                        if (reader.IsDBNull(i))
                            return access = false;

                    if (access)
                    {
                        section[0] = reader.GetString(0);
                        section[1] = reader.GetString(1);
                        section[2] = reader.GetString(2);
                        section[3] = reader.GetString(3);
                        section[4] = reader.GetString(4);
                        section[5] = reader.GetString(5);
                        section[6] = reader.GetString(6);
                        section[7] = reader.GetString(7);
                        section[8] = reader.GetString(8);
                        section[9] = reader.GetString(9);
                    }
                }

                return access;
            }

            finally
            {
                conn.Close();
            }
        }

        // Save stream functions
        public void saveHomePage(string titul, string titul_2, string titul_3, string section_1, string section_2, string section_3, string section_4, string section_5, string section_6,
            string section_7, string section_8, string section_9, string section_10, string section_11, string section_12, string section_13, string section_14, string section_15, char pos)
        {
            if (pos == 'L')
            {
                commandU = new SqlCommand("UPDATE dbo.titles SET text = @titul WHERE ID = 1 "
                + "UPDATE dbo.titles SET text = @titul_2 WHERE ID = 2 "
                + "UPDATE dbo.titles SET text = @titul_3 WHERE ID = 3 "
                + "UPDATE dbo.sections SET text = @section WHERE ID = 1 "
                + "UPDATE dbo.sections SET text = @section_2 WHERE ID = 2 "
                + "UPDATE dbo.sections SET text = @section_3 WHERE ID = 3 "
                + "UPDATE dbo.sections SET text = @section_4 WHERE ID = 4 "
                + "UPDATE dbo.sections SET text = @section_5 WHERE ID = 5 "
                + "UPDATE dbo.sections SET text = @section_6 WHERE ID = 6 "
                + "UPDATE dbo.sections SET text = @section_7 WHERE ID = 7 "
                + "UPDATE dbo.sections SET text = @section_8 WHERE ID = 8 "
                + "UPDATE dbo.sections SET text = @section_9 WHERE ID = 9 "
                + "UPDATE dbo.sections SET text = @section_10 WHERE ID = 10 "
                + "UPDATE dbo.sections SET text = @section_11 WHERE ID = 11 "
                + "UPDATE dbo.sections SET text = @section_12 WHERE ID = 83 "
                + "UPDATE dbo.sections SET text = @section_13 WHERE ID = 13 "
                + "UPDATE dbo.sections SET text = @section_14 WHERE ID = 14 "
                + "UPDATE dbo.sections SET text = @section_15 WHERE ID = 15", conn);
            }
            else
            {
                commandU = new SqlCommand("UPDATE dbo.titles SET text = @titul WHERE ID = 6 "
                + "UPDATE dbo.titles SET text = @titul_2 WHERE ID = 4 "
                + "UPDATE dbo.titles SET text = @titul_3 WHERE ID = 5 "
                + "UPDATE dbo.page SET description = @section_11 WHERE inicial LIKE 'R' "
                + "UPDATE dbo.sections SET text = @section WHERE ID = 16 "
                + "UPDATE dbo.sections SET text = @section_2 WHERE ID = 17 "
                + "UPDATE dbo.sections SET text = @section_3 WHERE ID = 18 "
                + "UPDATE dbo.sections SET text = @section_4 WHERE ID = 19 "
                + "UPDATE dbo.sections SET text = @section_5 WHERE ID = 20 "
                + "UPDATE dbo.sections SET text = @section_6 WHERE ID = 21 "
                + "UPDATE dbo.sections SET text = @section_7 WHERE ID = 22 "
                + "UPDATE dbo.sections SET text = @section_8 WHERE ID = 23 "
                + "UPDATE dbo.sections SET text = @section_9 WHERE ID = 24 "
                + "UPDATE dbo.sections SET text = @section_10 WHERE ID = 25", conn);
            }

            try
            {
                conn.Open();
                commandU.Parameters.Clear();

                // New parameters
                SqlParameter titulP = new SqlParameter("@titul", SqlDbType.VarChar, 50);
                SqlParameter titulP_2 = new SqlParameter("@titul_2", SqlDbType.VarChar, 50);
                SqlParameter titulP_3 = new SqlParameter("@titul_3", SqlDbType.VarChar, 50);
                SqlParameter sectionP_1 = new SqlParameter("@section", SqlDbType.VarChar, 255);
                SqlParameter sectionP_2 = new SqlParameter("@section_2", SqlDbType.VarChar, 255);
                SqlParameter sectionP_3 = new SqlParameter("@section_3", SqlDbType.VarChar, 255);
                SqlParameter sectionP_4 = new SqlParameter("@section_4", SqlDbType.VarChar, 255);
                SqlParameter sectionP_5 = new SqlParameter("@section_5", SqlDbType.VarChar, 255);
                SqlParameter sectionP_6 = new SqlParameter("@section_6", SqlDbType.VarChar, 255);
                SqlParameter sectionP_7 = new SqlParameter("@section_7", SqlDbType.VarChar, 255);
                SqlParameter sectionP_8 = new SqlParameter("@section_8", SqlDbType.VarChar, 255);
                SqlParameter sectionP_9 = new SqlParameter("@section_9", SqlDbType.VarChar, 255);
                SqlParameter sectionP_10 = new SqlParameter("@section_10", SqlDbType.VarChar, 255);
                SqlParameter sectionP_11 = new SqlParameter("@section_11", SqlDbType.VarChar, 255);
                SqlParameter sectionP_12 = new SqlParameter("@section_12", SqlDbType.VarChar, 255);
                SqlParameter sectionP_13 = new SqlParameter("@section_13", SqlDbType.VarChar, 255);
                SqlParameter sectionP_14 = new SqlParameter("@section_14", SqlDbType.VarChar, 255);
                SqlParameter sectionP_15 = new SqlParameter("@section_15", SqlDbType.VarChar, 255);

                // New value parameters
                titulP.Value = titul;
                titulP_2.Value = titul_2;
                titulP_3.Value = titul_3;
                sectionP_1.Value = section_1;
                sectionP_2.Value = section_2;
                sectionP_3.Value = section_3;
                sectionP_4.Value = section_4;
                sectionP_5.Value = section_5;
                sectionP_6.Value = section_6;
                sectionP_7.Value = section_7;
                sectionP_8.Value = section_8;
                sectionP_9.Value = section_9;
                sectionP_10.Value = section_10;
                sectionP_11.Value = section_11;
                sectionP_12.Value = section_12;
                sectionP_13.Value = section_13;
                sectionP_14.Value = section_14;
                sectionP_15.Value = section_15;

                // Add new parameters
                commandU.Parameters.Add(titulP);
                commandU.Parameters.Add(titulP_2);
                commandU.Parameters.Add(titulP_3);
                commandU.Parameters.Add(sectionP_1);
                commandU.Parameters.Add(sectionP_2);
                commandU.Parameters.Add(sectionP_3);
                commandU.Parameters.Add(sectionP_4);
                commandU.Parameters.Add(sectionP_5);
                commandU.Parameters.Add(sectionP_6);
                commandU.Parameters.Add(sectionP_7);
                commandU.Parameters.Add(sectionP_8);
                commandU.Parameters.Add(sectionP_9);
                commandU.Parameters.Add(sectionP_10);
                commandU.Parameters.Add(sectionP_11);
                commandU.Parameters.Add(sectionP_12);
                commandU.Parameters.Add(sectionP_13);
                commandU.Parameters.Add(sectionP_14);
                commandU.Parameters.Add(sectionP_15);

                commandU.Prepare();
                commandU.ExecuteNonQuery();
            }

            finally
            {
                conn.Close();
            }
        }

        public void saveAboutMe(string nadpis_o, string text_o, string titul, string hra_1, string hra_2, string hra_3, string hra_4, string doplnInformace)
        {
            commandU = new SqlCommand("UPDATE dbo.titles SET text = @titul WHERE ID = 7 "
                + "UPDATE dbo.sections SET text = @hra_1 WHERE ID = 87 "
                + "UPDATE dbo.sections SET text = @hra_2 WHERE ID = 88 "
                + "UPDATE dbo.sections SET text = @hra_3 WHERE ID = 89 "
                + "UPDATE dbo.sections SET text = @hra_4 WHERE ID = 90 "
                + "UPDATE dbo.pages SET nadpis = @nadpis, text = @text, other = @dopln WHERE ID = 1", conn);
            try
            {
                conn.Open();
                commandU.Parameters.Clear();

                // New parameters
                SqlParameter nadpisP = new SqlParameter("@nadpis", SqlDbType.VarChar, 80);
                SqlParameter textP = new SqlParameter("@text", SqlDbType.VarChar, 255);
                SqlParameter doplnInformaceP = new SqlParameter("@dopln", SqlDbType.VarChar, 255);
                SqlParameter titulP = new SqlParameter("@titul", SqlDbType.VarChar, 255);
                SqlParameter hra_1P = new SqlParameter("@hra_1", SqlDbType.VarChar, 255);
                SqlParameter hra_2P = new SqlParameter("@hra_2", SqlDbType.VarChar, 255);
                SqlParameter hra_3P = new SqlParameter("@hra_3", SqlDbType.VarChar, 255);
                SqlParameter hra_4P = new SqlParameter("@hra_4", SqlDbType.VarChar, 255);

                // New value parameters
                nadpisP.Value = nadpis_o;
                textP.Value = text_o;
                doplnInformaceP.Value = doplnInformace;
                titulP.Value = titul;
                hra_1P.Value = hra_1;
                hra_2P.Value = hra_2;
                hra_3P.Value = hra_3;
                hra_4P.Value = hra_4;

                // Add new parameters
                commandU.Parameters.Add(nadpisP);
                commandU.Parameters.Add(textP);
                commandU.Parameters.Add(doplnInformaceP);
                commandU.Parameters.Add(titulP);
                commandU.Parameters.Add(hra_1P);
                commandU.Parameters.Add(hra_2P);
                commandU.Parameters.Add(hra_3P);
                commandU.Parameters.Add(hra_4P);

                commandU.Prepare();
                commandU.ExecuteNonQuery();
            }

            finally
            {
                conn.Close();
            }
        }

        public void saveQuickBar(string nadpis_o, string text_o, string odkaz_1, string odkaz_2, string odkaz_3, string odkaz_4, string alias_1, string alias_2, string alias_3, string alias_4)
        {
            commandU = new SqlCommand("UPDATE dbo.quickbar SET nadpis = @nadpis, text = @text "
                + "UPDATE dbo.odkazy SET url = @url_1, alias = @alias_1 WHERE ID = 4 "
                + "UPDATE dbo.odkazy SET url = @url_2, alias = @alias_2 WHERE ID = 5 "
                + "UPDATE dbo.odkazy SET url = @url_3, alias = @alias_3 WHERE ID = 6 "
                + "UPDATE dbo.odkazy SET url = @url_4, alias = @alias_4 WHERE ID = 7", conn);
            try
            {
                conn.Open();
                commandU.Parameters.Clear();

                // New parameters
                SqlParameter nadpisP = new SqlParameter("@nadpis", SqlDbType.VarChar, 80);
                SqlParameter textP = new SqlParameter("@text", SqlDbType.VarChar, 255);
                SqlParameter url_1P = new SqlParameter("@url_1", SqlDbType.VarChar, 255);
                SqlParameter url_2P = new SqlParameter("@url_2", SqlDbType.VarChar, 255);
                SqlParameter url_3P = new SqlParameter("@url_3", SqlDbType.VarChar, 255);
                SqlParameter url_4P = new SqlParameter("@url_4", SqlDbType.VarChar, 255);
                SqlParameter alias_1P = new SqlParameter("@alias_1", SqlDbType.VarChar, 255);
                SqlParameter alias_2P = new SqlParameter("@alias_2", SqlDbType.VarChar, 255);
                SqlParameter alias_3P = new SqlParameter("@alias_3", SqlDbType.VarChar, 255);
                SqlParameter alias_4P = new SqlParameter("@alias_4", SqlDbType.VarChar, 255);

                // New value parameters
                nadpisP.Value = nadpis_o;
                textP.Value = text_o;
                url_1P.Value = odkaz_1;
                url_2P.Value = odkaz_2;
                url_3P.Value = odkaz_3;
                url_4P.Value = odkaz_4;
                alias_1P.Value = alias_1;
                alias_2P.Value = alias_2;
                alias_3P.Value = alias_3;
                alias_4P.Value = alias_4;

                // Add new parameters
                commandU.Parameters.Add(nadpisP);
                commandU.Parameters.Add(textP);
                commandU.Parameters.Add(url_1P);
                commandU.Parameters.Add(url_2P);
                commandU.Parameters.Add(url_3P);
                commandU.Parameters.Add(url_4P);
                commandU.Parameters.Add(alias_1P);
                commandU.Parameters.Add(alias_2P);
                commandU.Parameters.Add(alias_3P);
                commandU.Parameters.Add(alias_4P);

                commandU.Prepare();
                commandU.ExecuteNonQuery();
            }

            finally
            {
                conn.Close();
            }
        }

        public void saveSupportMe(string nadpis_o, string text_o)
        {
            commandU = new SqlCommand("UPDATE dbo.pages SET nadpis = @nadpis, text = @text WHERE ID = 2", conn);
            try
            {
                conn.Open();
                commandU.Parameters.Clear();

                // New parameters
                SqlParameter nadpisP = new SqlParameter("@nadpis", SqlDbType.VarChar, 80);
                SqlParameter textP = new SqlParameter("@text", SqlDbType.Text, 1000);

                // New value parameters
                nadpisP.Value = nadpis_o;
                textP.Value = text_o;

                // Add new parameters
                commandU.Parameters.Add(nadpisP);
                commandU.Parameters.Add(textP);

                commandU.Prepare();
                commandU.ExecuteNonQuery();
            }

            finally
            {
                conn.Close();
            }
        }

        public void saveContactMe(string nadpis_o, string text_o)
        {
            commandU = new SqlCommand("UPDATE dbo.pages SET nadpis = @nadpis, text = @text WHERE ID = 6", conn);
            try
            {
                conn.Open();
                commandU.Parameters.Clear();

                // New parameters
                SqlParameter nadpisP = new SqlParameter("@nadpis", SqlDbType.VarChar, 80);
                SqlParameter textP = new SqlParameter("@text", SqlDbType.Text, 1000);

                // New value parameters
                nadpisP.Value = nadpis_o;
                textP.Value = text_o;

                // Add new parameters
                commandU.Parameters.Add(nadpisP);
                commandU.Parameters.Add(textP);

                commandU.Prepare();
                commandU.ExecuteNonQuery();
            }

            finally
            {
                conn.Close();
            }
        }
    }
}