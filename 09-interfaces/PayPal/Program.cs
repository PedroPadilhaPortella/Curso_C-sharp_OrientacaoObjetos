using PayPal.Entities;
using PayPal.Services;
using System;
using System.Globalization;

namespace PayPal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Contract Data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: R$");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of Installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(number, date, value);
            ContractService myContractService = new ContractService(new PaypalService());
            myContractService.ProcessContract(myContract, months);

            Console.WriteLine("\n\nInstallments: ");
            foreach (Installment installment in myContract.Installments){
                Console.WriteLine(installment);
            }
        }
    }
}
