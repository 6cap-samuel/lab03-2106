using System;
using ConsoleApp1.CPF;

namespace SOLIDLab.CPF
{
    /**
     * Client Model Class, the Add() function has been removed and
     * placed into the repository class to abstract the data access
     * away from the model (SRP)
     */
    public class Client : IClient
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataRegister { get; set; }
    }
}