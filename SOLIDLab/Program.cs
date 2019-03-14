using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using SOLIDLab.CPF;

namespace SOLIDLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            var input = Console.ReadKey();
            switch (input.KeyChar)
            {
                case '1':
                    Client client = new Client();
                    client.AddClient();
                    break;
                case '2':
          
                    break;
            }

            Console.ReadKey();
        }
    }
}
