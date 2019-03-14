using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CPF
{
    /**
     * Use of interface so that implementing class is
     * open to extension but closed for modification
     *
     * Ensures that all concrete classes that want to be
     * used as an Emailer has a method that sends emails
     */
    interface IEmailer
    {
        string sendEmail(string clientEmail);
    }
}
