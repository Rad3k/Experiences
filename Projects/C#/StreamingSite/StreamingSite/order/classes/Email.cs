using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace rad3k_eu.order.classes
{
    public class Email
    {
        public void sendEmail(string from, string to, string subject, string message)
        {
            SmtpClient smtpClient = new SmtpClient("mail.MyWebsiteDomainName.com", 25);

            smtpClient.Credentials = new System.Net.NetworkCredential("info@rad3k.eu", "myIDPassword");
            smtpClient.UseDefaultCredentials = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            MailMessage mail = new MailMessage();

            //Setting From , To and CC
            mail.From = new MailAddress(from, "http://rad3k.eu");
            mail.To.Add(new MailAddress(to));
            mail.Subject = subject;
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = message;
            mail.BodyEncoding = System.Text.Encoding.UTF8;

            smtpClient.Send(mail);
        }
    }
}