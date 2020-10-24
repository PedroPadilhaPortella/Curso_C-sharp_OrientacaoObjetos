using System;
using System.Collections.Generic;
using System.Globalization;


namespace Comparison
{
    class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString(){
            return $"{Name}, R${Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(Product other)
        {
            return Name.ToUpper().CompareTo(other.Name.ToUpper());
        }
    }
}