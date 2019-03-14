using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CPF
{
    /**
     * Emailer class for handling email sending (SRP)
     */
    class Emailer
    {
        public string sendEmail(String clientEmail)
        {
            var mail = new MailMessage("admin@sit.singaporetech.edu.sg", clientEmail);
            var smtpClient = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Welcome";
            mail.Body = "You have just registered with us";
            smtpClient.Send(mail);

            return "Client registered successfully !";
        }
    }
}
