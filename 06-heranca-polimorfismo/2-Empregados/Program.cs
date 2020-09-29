using System;
using System.Collections.Generic;
using Empregados.Entities;
using System.Globalization;

namespace Empregados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> funcionarios = new List<Employee>();

            Console.Write("Enter the Number of Emplyees: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++){
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsorced (y/n):");
                char type = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(type == 'y'){
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    funcionarios.Add(new OutsorcedEmployee(name, hours, valuePerHour, additionalCharge));
                }else{
                    funcionarios.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("PAYMENTS:");
            foreach(Employee emp in funcionarios)
            {
                Console.WriteLine($"{emp.Name} -> ${emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
