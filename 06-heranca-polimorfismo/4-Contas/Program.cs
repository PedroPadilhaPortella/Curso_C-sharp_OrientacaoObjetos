using System;
using System.Globalization;
using System.Collections.Generic;
using Contas.Entities;

namespace Contas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> lista = new List<Account>();
            lista.Add(new SavingsAccount(1001, "Pedro", 500, 0.01));
            lista.Add(new SavingsAccount(1002, "Maria", 500, 0.02));
            lista.Add(new BussinessAccount(1003, "Hector", 3200, 400));
            lista.Add(new BussinessAccount(1004, "Joao", 1200, 600));

            double soma = 0;
            foreach (Account acc in lista)
            {
                soma += acc.Balance;
            }
            System.Console.WriteLine("Total Balance: R$" + soma.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account acc in lista)
            {
                acc.Withdraw(10.00);
            }
            foreach (Account item in lista)
            {
                System.Console.WriteLine($"Saldo Atualizado para a conta {item.Number}: ${item.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}