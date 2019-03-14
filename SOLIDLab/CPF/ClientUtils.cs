using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLIDLab.CPF;

namespace ConsoleApp1.CPF
{
    class ClientUtils
    {
        /**
         * Utility class that handles validation of clients
         */
        public static Boolean validateClient(Client client)
        {
            if (!client.Email.Contains("@"))
                return false;

            if (client.Cpf.Length != 11)
                return false;

            return true;
        }
    }
}
