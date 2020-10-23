using System;
using System.Collections.Generic;
using CursosOnline.Entities;

namespace CursosOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Students> estudantes = new HashSet<Students>();
            int id = 0;
            Console.Write("How many students from course A: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++) {
                id = int.Parse(Console.ReadLine());
                estudantes.Add(new Students(id));
            }

            Console.Write("How many students from course B: ");
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++) {
                id = int.Parse(Console.ReadLine());
                estudantes.Add(new Students(id));
            }

            Console.Write("How many students from course C: ");
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++) {
                id = int.Parse(Console.ReadLine());
                estudantes.Add(new Students(id));
            }

            System.Console.WriteLine($"Total Students: {estudantes.Count}");
        }
    }
}
