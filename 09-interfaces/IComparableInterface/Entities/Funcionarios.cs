using System.Globalization;
using System;

namespace IComparableInterface.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(string csvEmployee)
        {
            string[] attributes = csvEmployee.Split(',');
            Name = attributes[0];
            Salary = double.Parse(attributes[1], CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return $"Name: {Name}, Salary: ${Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
        public int CompareTo(object obj)
        {
            if(!(obj is Employee)){
                throw new ArgumentException("Comparing Error: Argument is not a Employee.");
            }
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }
    }
}