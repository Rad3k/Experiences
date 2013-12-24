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
    class LoginInformation : Collections
    {
        public string connection = "Data Source=RADEK-PC\\SQLEXPRESS;Initial Catalog=Evidence;Integrated Security=True;";

        public LoginInformation(string login)
        {
            UniqueValue.FullPathConfig = connection;

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
                                if (readerLogin.IsDBNull(0) || readerLogin.IsDBNull(1) || readerLogin.IsDBNull(2))
                                    continue;

                                // Dynamic value for login dialog
                                Login = readerLogin.GetString(0);
                                Email = readerLogin.GetString(1);
                                Password = readerLogin.GetString(2);
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
        }
    }
}
