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
    }
}
