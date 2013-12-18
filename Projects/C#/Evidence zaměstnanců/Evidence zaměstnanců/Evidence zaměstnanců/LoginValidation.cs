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
    class LoginValidation : Login
    {
        public string connection = "Data Source=RADEK-PC\\SQLEXPRESS;Initial Catalog=Evidence;Integrated Security=True;";
        public string loginVal, passwordVal;

        public LoginValidation(string login, string password)
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(connection))
                {
                    sql.Open();

                    using (SqlCommand selectLogin = new SqlCommand("SELECT * FROM dbo.Login WHERE username = @login", sql))
                    {
                        selectLogin.Parameters.Clear();
                        SqlParameter subjektParam = new SqlParameter("@login", SqlDbType.VarChar, 30);
                        subjektParam.Value = login;
                        selectLogin.Parameters.Add(subjektParam);
                        selectLogin.Prepare();

                        using (SqlDataReader readerLogin = selectLogin.ExecuteReader())
                        {
                            while (readerLogin.Read())
                            {
                                if (readerLogin.IsDBNull(0) || readerLogin.IsDBNull(2))
                                    continue;

                                loginVal = readerLogin.GetString(0);
                                passwordVal = readerLogin.GetString(2);
                            }
                        }
                        sql.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Chyba: " + e);
            }

            if (login == loginVal && HashPassword.ValidatePassword(password, passwordVal) == true)
            {
                Main main = new Main();
                main.Show();
            }
            else
                MessageBox.Show("Přihlašovací jméno nebo heslo neni správné");
        }
    }
}
