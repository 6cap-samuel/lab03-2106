using System;
using ConsoleApp1.CPF;

namespace SOLIDLab.CPF
{
    public class Client : IClient
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataRegister { get; set; }
    }
}