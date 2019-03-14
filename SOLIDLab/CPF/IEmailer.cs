using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CPF
{
    interface IEmailer
    {
        string sendEmail(string clientEmail);
    }
}
