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
        private SqlCommand command;

        public transaction()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Rad3kConnection"].ToString();
            conn = new SqlConnection(connectionString);
        }

        public bool loginVerification(string name, string password)
        {
            bool access = true;
            string checkLogin, checkPassword;
            command = new SqlCommand("SELECT * FROM dbo.users WHERE user = @name", conn);
            try
            {
                conn.Open();
                command.Parameters.Clear();

                // Parameters
                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 30);
                nameParam.Value = name;
                command.Parameters.Add(nameParam);
                command.Prepare();
                SqlDataReader reader = command.ExecuteReader();

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
    }
}