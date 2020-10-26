using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;
using Emails.Entities;

namespace Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full path file: ");
            string path = Console.ReadLine();

            List<Employee> empregados = new List<Employee>();

            try {
                using(StreamReader sr = File.OpenText(path)){
                    while(!sr.EndOfStream){
                        string[] employee = sr.ReadLine().Split(',');
                        string name = employee[0];
                        string email = employee[1];
                        double salary = double.Parse(employee[2], CultureInfo.InvariantCulture);
                        empregados.Add(new Employee(name, email, salary));
                    }
                }

                var result01 = empregados.Where(e => e.Salary > 2000).Select(e => e.Email);
                // System.Console.WriteLine("Email of people whose salary is more than 2000.00:");
                foreach (var item in result01){
                    System.Console.WriteLine(item);
                }

                var result02 = empregados.Where(e => e.Name[0] == 'M').Select(e => e.Salary).DefaultIfEmpty(0.0).Sum();
                System.Console.Write("Sum of salary of people whose name starts with 'M':" + result02);



            }catch(IOException e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
