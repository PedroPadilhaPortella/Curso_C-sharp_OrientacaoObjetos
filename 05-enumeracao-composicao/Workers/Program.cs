using System;
using Workers.Entities.Enums;
using Workers.Entities;
using System.Globalization;

namespace Workers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Department Name: ");
            string dept = Console.ReadLine();
            Console.WriteLine("Enter Workers Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior):");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: R$");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(dept);
            Worker worker = new Worker(name, level, baseSalary, department);

            Console.Write("How many contracts to this workers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} data contract:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(data, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.Write("\nEnter with month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");


            Console.Write($"Income for {monthAndYear}: R${worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}