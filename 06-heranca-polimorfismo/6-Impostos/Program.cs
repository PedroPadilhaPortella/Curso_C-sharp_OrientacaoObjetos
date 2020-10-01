using System;
using System.Globalization;
using System.Collections.Generic;
using _6_Impostos.Entities;

namespace _6_Impostos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> lista = new List<TaxPayer>();

            System.Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write($"Individual or company (i/c)?");
                char kind = char.Parse(Console.ReadLine());

                Console.Write($"Name: ");
                string name = Console.ReadLine();

                Console.Write($"Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(kind == 'i'){
                    Console.Write($"Health expenditures:");
                    double healthExpeditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Individual(name, anualIncome, healthExpeditures));
                
                }else{
                    Console.Write($"Number of employees");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    lista.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            double total = 0;
            foreach (TaxPayer elemento in lista)
            {
                double taxa = elemento.Tax();
                Console.WriteLine(elemento.Name + ": " + taxa.ToString("F2", CultureInfo.InvariantCulture));
                total += taxa;
            }
            Console.WriteLine("\nTOTAL TAXES: " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
