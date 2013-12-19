using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_zaměstnanců
{
    class LoginValidation
    {
        public bool ValidateLogin(string login, string password, string checkLogin, string checkPassword)
        {
            if (login == checkLogin && HashPassword.ValidatePassword(password, checkPassword) == true)
                UniqueValue.access = true;
            else
                UniqueValue.access = false;

            return UniqueValue.access;
        }
    }
}
