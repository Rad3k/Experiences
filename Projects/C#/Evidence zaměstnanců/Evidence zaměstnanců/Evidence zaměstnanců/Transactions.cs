using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Evidence_zaměstnanců
{
    class Transactions : Collections
    {
        public Transactions(string connection)
        {
            try
            {
                SqlConnection sql = new SqlConnection(connection);
            }
            catch (Exception e)
            {
                MessageBox.Show("Chyba s připojením: " + e);
            }
        }

        public void GetDataFromAboutProgram(SqlConnection sql)
        {
            sql.Open();
            using (SqlCommand aboutPrograms = new SqlCommand("SELECT * FROM dbo.AboutPrograms", sql))
            {
                using (SqlDataReader readerData = aboutPrograms.ExecuteReader())
                {
                    while (readerData.Read())
                    {
                        if (readerData.IsDBNull(1) || readerData.IsDBNull(2) || readerData.IsDBNull(3))
                            continue;

                        // Dynamic value for login dialog
                        version = readerData.GetString(1);
                        date = readerData.GetDateTime(2);
                        lastChanged = readerData.GetDateTime(3);
                    }
                }
            }
            sql.Close();
        }

        public void ChangePassword(string newPassword, SqlConnection sql)
        {
            sql.Open();
            using (SqlCommand updatePassword = new SqlCommand("UPDATE dbo.Login SET password = @password WHERE username = @login", sql))
            {
                updatePassword.Parameters.Clear();
                SqlParameter loginParam = new SqlParameter("@login", SqlDbType.VarChar, 30);
                SqlParameter passwordParam = new SqlParameter("@password", SqlDbType.VarChar, 255);
                loginParam.Value = UniqueValue.Login;
                passwordParam.Value = HashPassword.CreateHash(newPassword);
                updatePassword.Parameters.Add(loginParam);
                updatePassword.Parameters.Add(passwordParam);
                updatePassword.Prepare();
                updatePassword.ExecuteNonQuery();

                MessageBox.Show("Heslo bylo úspěšně změněno");
            }
            sql.Close();
        }

        public void addZam(SqlConnection sql, string jmeno, string prijmeni, string Email, string rodneCislo, string pracovniPozice, string telefonPrace, string faxPrace, string telefonDomu
            , string mobilDomu, string doplnujiciUdaje, string ulice, string mesto, string stat, string cp, string co, string mzda, string pobocka, string utvar, DateTimePicker denNastupu, DateTimePicker denUkonceni, int problem)
        {
            sql.Open();
            using (SqlCommand addZam = new SqlCommand("INSERT INTO dbo.Employee VALUES (1, @jmeno, @prijmeni, @email, @rodneCislo, @pracovniPozice, @telefonPrace, @faxPrace, @telefonDomu, " +
                "@mobilDomu, @doplnUdaje, @ulice, @mesto, @stat, @cp, @co, @mzda, @pobocka, @utvar, @denNastupu, @denUkonceni, 1, 0)", sql))
            {
                addZam.Parameters.Clear();
                // Parameters
                SqlParameter jmenoParam = new SqlParameter("@jmeno", SqlDbType.VarChar, 20);
                SqlParameter prijmeniParam = new SqlParameter("@prijmeni", SqlDbType.VarChar, 20);
                SqlParameter emailParam = new SqlParameter("@email", SqlDbType.VarChar, 30);
                SqlParameter rodneCisloParam = new SqlParameter("@rodneCislo", SqlDbType.VarChar, 30);
                SqlParameter pracovniPoziceParam = new SqlParameter("@pracovniPozice", SqlDbType.VarChar, 100);
                SqlParameter telefonPraceParam = new SqlParameter("@telefonPrace", SqlDbType.VarChar, 15);
                SqlParameter faxPraceParam = new SqlParameter("@faxPrace", SqlDbType.VarChar, 15);
                SqlParameter telefonDomuParam = new SqlParameter("@telefonDomu", SqlDbType.VarChar, 15);
                SqlParameter mobilDomuParam = new SqlParameter("@mobilDomu", SqlDbType.VarChar, 15);
                SqlParameter doplnUdajeParam = new SqlParameter("@doplnUdaje", SqlDbType.VarChar, 255);
                SqlParameter uliceParam = new SqlParameter("@ulice", SqlDbType.VarChar, 255);
                SqlParameter mestoParam = new SqlParameter("@mesto", SqlDbType.VarChar, 100);
                SqlParameter statParam = new SqlParameter("@stat", SqlDbType.VarChar, 2);
                SqlParameter cpParam = new SqlParameter("@cp", SqlDbType.Int);
                SqlParameter coParam = new SqlParameter("@co", SqlDbType.Int);
                SqlParameter mzdaParam = new SqlParameter("@mzda", SqlDbType.Money);
                SqlParameter pobockaParam = new SqlParameter("@pobocka", SqlDbType.Char, 2);
                SqlParameter utvarParam = new SqlParameter("@utvar", SqlDbType.Char, 2);
                SqlParameter denNastupuParam = new SqlParameter("@denNastupu", SqlDbType.Date);
                SqlParameter denUkonceniParam = new SqlParameter("@denUkonceni", SqlDbType.Date);
                SqlParameter problemParam = new SqlParameter("@problem", SqlDbType.Int);

                // Definitions for parameters
                jmenoParam.Value = jmeno;
                prijmeniParam.Value = prijmeni;
                emailParam.Value = Email;
                rodneCisloParam.Value = rodneCislo;
                pracovniPoziceParam.Value = pracovniPozice;
                telefonPraceParam.Value = telefonPrace;
                faxPraceParam.Value = faxPrace;
                telefonDomuParam.Value = telefonDomu;
                mobilDomuParam.Value = mobilDomu;
                doplnUdajeParam.Value = doplnujiciUdaje;
                uliceParam.Value = ulice;
                mestoParam.Value = mesto;
                statParam.Value = stat;
                cpParam.Value = cp;
                coParam.Value = co;
                mzdaParam.Value = mzda;
                pobockaParam.Value = pobocka;
                utvarParam.Value = utvar;
                denNastupuParam.Value = denNastupu.Value;
                denUkonceniParam.Value = denUkonceni.Value;
                problemParam.Value = problem;

                // Add parameters
                addZam.Parameters.Add(jmenoParam);
                addZam.Parameters.Add(prijmeniParam);
                addZam.Parameters.Add(emailParam);
                addZam.Parameters.Add(rodneCisloParam);
                addZam.Parameters.Add(pracovniPoziceParam);
                addZam.Parameters.Add(telefonPraceParam);
                addZam.Parameters.Add(faxPraceParam);
                addZam.Parameters.Add(telefonDomuParam);
                addZam.Parameters.Add(mobilDomuParam);
                addZam.Parameters.Add(doplnUdajeParam);
                addZam.Parameters.Add(uliceParam);
                addZam.Parameters.Add(mestoParam);
                addZam.Parameters.Add(statParam);
                addZam.Parameters.Add(cpParam);
                addZam.Parameters.Add(coParam);
                addZam.Parameters.Add(mzdaParam);
                addZam.Parameters.Add(pobockaParam);
                addZam.Parameters.Add(utvarParam);
                addZam.Parameters.Add(denNastupuParam);
                addZam.Parameters.Add(denUkonceniParam);
                addZam.Parameters.Add(problemParam);

                // Execute command
                addZam.Prepare();
                addZam.ExecuteNonQuery();

                MessageBox.Show("Uživatel úspěšně přidán");
            }
            sql.Close();
        }

        public void delZam(SqlConnection sql, string jmeno, string prijmeni)
        {
            sql.Open();
            using (SqlCommand delZam = new SqlCommand("DELETE FROM dbo.Employee WHERE Jmeno = @jmeno or Prijmeni = @prijmeni", sql))
            {
                delZam.Parameters.Clear();
                // Parameters
                SqlParameter jmenoParam = new SqlParameter("@jmeno", SqlDbType.VarChar, 20);
                SqlParameter prijmeniParam = new SqlParameter("@prijmeni", SqlDbType.VarChar, 20);

                // Definitions for parameters
                jmenoParam.Value = jmeno;
                prijmeniParam.Value = prijmeni;

                // Add parameters
                delZam.Parameters.Add(jmenoParam);
                delZam.Parameters.Add(prijmeniParam);

                // Execute command
                delZam.Prepare();
                delZam.ExecuteNonQuery();

                MessageBox.Show("Uživatel úspěšně přidán");
            }
            sql.Close();
        }

        public void selectZam(SqlConnection sql, string jmeno, string prijmeni)
        {
            sql.Open();
            using (SqlCommand selectZam = new SqlCommand("SELECT * FROM dbo.Employee WHERE Jmeno = @jmeno or Prijmeni = @prijmeni", sql))
            {
                selectZam.Parameters.Clear();
                SqlParameter jmenoParam = new SqlParameter("@jmeno", SqlDbType.VarChar, 20);
                SqlParameter prijmeniParam = new SqlParameter("@prijmeni", SqlDbType.VarChar, 20);
                jmenoParam.Value = jmeno;
                prijmeniParam.Value = prijmeni;
                selectZam.Parameters.Add(jmenoParam);
                selectZam.Parameters.Add(prijmeniParam);
                selectZam.Prepare();

                using (SqlDataReader readerData = selectZam.ExecuteReader())
                {
                    while (readerData.Read())
                    {
                        for (int i = 0; i < readerData.FieldCount; i++)
                            if (readerData.IsDBNull(i))
                                continue;

                        // Dynamic value for login dialog
                        ID = readerData.GetInt32(0);
                        Jmeno = readerData.GetString(1);
                        Prijmeni = readerData.GetString(2);
                        email = readerData.GetString(3);
                        RodneCislo = readerData.GetString(4);
                        PracovniPozice = readerData.GetString(5);
                        TelefonPrace = readerData.GetString(6);
                        FaxPrace = readerData.GetString(7);
                        TelefonDomu = readerData.GetString(8);
                        MobilDomu = readerData.GetString(9);
                        DoplnujiciUdaje = readerData.GetString(10);
                        Ulice = readerData.GetString(11);
                        Mesto = readerData.GetString(12);
                        Stat = readerData.GetString(13);
                        CP = readerData.GetInt32(14);
                        CO = readerData.GetInt32(15);
                        Mzda = readerData.GetDouble(16);
                        Pobocka = readerData.GetString(17);
                        Utvar = readerData.GetString(18);
                        datumNastupu = readerData.GetDateTime(19);
                        datumUkonceni = readerData.GetDateTime(20);
                    }
                }
            }
            sql.Close();
        }
    }
}
