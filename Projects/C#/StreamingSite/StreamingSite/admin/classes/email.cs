using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace rad3k_eu.admin.classes
{
	public class email
	{
        string my_mail;
        bool control;
        public string error;

        public email()
        {
            my_mail = "Rad3k.T@seznam.cz";
        }

        public bool sendEmail(string jmeno, string email, string duvod, string zprava, string type)
        {
            try
            {
                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Port = 25;
                client.Timeout = 10000;
                client.Host = "localhost";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(email);
                mail.To.Add(new MailAddress(my_mail));
                mail.Subject = duvod + "(" + type + "@rad3k.eu)";
                mail.Body = "Jméno osoby: " + jmeno
                    + Environment.NewLine + Environment.NewLine
                    + zprava;

                client.UseDefaultCredentials = true;
                client.Send(mail);
                control = true;
            }
            catch (Exception e)
            {
                error = e.ToString();
                control = false;
            }
            return control;
        }
	}
}