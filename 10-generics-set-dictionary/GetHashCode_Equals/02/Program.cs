using System;
using _02.Entities;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client() { Nome = "Pedro", Email = "pedro@gmail.com" };
            Client b = new Client() { Nome = "Pedro", Email = "pedro@gmail.com" };
            Client c = new Client() { Nome = "Daniel", Email = "daniel@gmail.com" };

            Console.WriteLine($"{a.Nome} == {b.Nome} ? {a.Equals(b)}");
            Console.WriteLine($"{a.Nome} == {c.Nome} ? {a.Equals(c)}");

            Console.WriteLine($"{a.Nome} == {b.Nome} ? {a.GetHashCode() == b.GetHashCode()}");
            Console.WriteLine($"{b.Nome} == {c.Nome} ? {b.GetHashCode() == c.GetHashCode()}");

            Console.WriteLine($"A referencia de {a.Nome} é a mesma de {b.Nome} ? {a == b}");
        }
    }
}
