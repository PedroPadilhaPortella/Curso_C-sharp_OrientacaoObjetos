using System;
using System.Globalization;
using ContaBancaria.Entities;
using ContaBancaria.Entities.Exceptions;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Account Data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Initial Balance: R$");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("WithDraw Limit: R$");
                double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account conta = new Account(number, name, balance, withDrawLimit);

                Console.Write("Enter Amount for WithDraw: R$");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.WithDraw(amount);
                Console.WriteLine($"New Balance: R${conta.Balance}");
            }
            catch (DomainException error)
            {
                Console.WriteLine($"Error: {error.Message}");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Withdraw Error: {error.Message}");
            }
        }
    }
}