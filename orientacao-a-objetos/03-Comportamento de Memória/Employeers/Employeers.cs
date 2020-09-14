using System;
using System.Globalization;

namespace Employeers
{
    class Employeers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employeers(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage) {
            Salary += Salary * percentage / 100.0; 
        }

        public override string ToString() {
            return $"Id: {Id}, Name: {Name}, Salary: US$ {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
