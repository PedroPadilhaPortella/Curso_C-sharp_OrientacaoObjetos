using System;
using System.Collections.Generic;
using System.Linq;
using LinqProductSql.Entities;

namespace LinqProductSql
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T item in collection){
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() {Id = 1, Name = "Tools", Tier = 2};
            Category c2 = new Category() {Id = 2, Name = "Computers", Tier = 1};
            Category c3 = new Category() {Id = 3, Name = "Eletronics", Tier = 1};

            List<Product> products = new List<Product>() {
                new Product() {Id = 1, Name = "Computer", Price = 1200.00, Category = c2},
                new Product() {Id = 2, Name = "Notebook", Price = 2100.00, Category = c2},
                new Product() {Id = 3, Name = "Cellphone", Price = 900.00, Category = c3},
                new Product() {Id = 4, Name = "Hammer", Price = 50.00, Category = c1},
                new Product() {Id = 5, Name = "Printer", Price = 2500.00, Category = c3},
                new Product() {Id = 6, Name = "Saw", Price = 80.00, Category = c1},
                new Product() {Id = 7, Name = "Sound Bar", Price = 100.00, Category = c3},
                new Product() {Id = 8, Name = "Camera", Price = 500.00, Category = c3},
                new Product() {Id = 9, Name = "Notebook Charger", Price = 100.00, Category = c2},
                new Product() {Id = 10, Name = "Phillip Key", Price = 15.00, Category = c1}
            };

            // var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            var r1 = from p in products
                where p.Category.Tier == 1 && p.Price < 900
                select p;
            Print("TIER 1 AND PRICE < 900:", r1);
            
            // var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var r2 = from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("NAMES OF PRODUCTS FROM TOOLS:", r2);
            
            // var r3 = products.Where(p =>p.Name[0] == 'C').Select(p => new{p.Name, p.Price, CatName = p.Category.Name});
            var r3 = from p in products
                    where p.Name[0] == 'C'
                    select new {p.Name, p.Price, CatName = p.Category.Name};
            Print("NAMES START WITH C AND ANONYMOUS OBJECT:", r3);

            // var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 = from p in products
                    where p.Category.Tier == 1
                    orderby p.Name orderby p.Price
                    select p;
            Print("TIER 1 ORDER BY PRICE AND THEN BY NAME:", r4);

            // var r5 = r4.Skip(2).Take(4);
            var r5 = (from p in r4 select p).Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE AND THEN BY NAME, SKIPPING 2 AND TAKING 4:", r5);

            // var r6 = products.First();
            var r6 = (from p in products select p).First();
            Console.WriteLine($"First element: {r6}");

            // var r7 = products.Where(p => p.Price == 0).FirstOrDefault();
            var r7 = (from p in products where p.Price == 0 select p).FirstOrDefault();
            Console.WriteLine($"First or default element: {r7}");

            // var r8 = products.Where(p => p.Id == 3).Single();
            var r8 = (from p in products where p.Id == 3 select p).Single();
            Console.WriteLine($"Single element: {r8}");

            // var r9 = products.Where(p => p.Id == 0).SingleOrDefault();
            var r9 = (from p in products where p.Id == 0 select p).SingleOrDefault();
            Console.WriteLine($"Single or default element: {r9}");


            // var r16 = products.GroupBy(p => p.Category);
            var r16 = from p in products group p by p.Category;
            foreach (IGrouping<Category, Product> group in r16){
                Console.WriteLine("\nCategory " + group.Key.Name + " :");
                foreach (Product p in group){
                    Console.WriteLine(p);
                }
            }
        }
    }
}
