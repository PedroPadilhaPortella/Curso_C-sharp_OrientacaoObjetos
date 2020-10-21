using System;
using System.Collections.Generic;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() {0, 2, 4, 6, 8, 10};
            SortedSet<int> b = new SortedSet<int>() {1, 3, 5, 6, 8, 10};

            //union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection("União de a e b: ", c);

            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection("Interseção entre a e b: ", d);

            //difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection("Diferença entre a e b: ", e);
        }

        static void PrintCollection<T>(string message, IEnumerable<T> collection)
        {
            Console.Write(message);
            foreach (T obj in collection) {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
