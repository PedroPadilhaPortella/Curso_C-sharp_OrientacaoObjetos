using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Pedro"); //adiciona elemento na ultima posição da lista
            list.Add("Alex");
            list.Add("Mahal");
            list.Add("Roger");
            list.Insert(2, "Paulo"); //Insere elementos em uma determinada posição e empurra os outros para trás
            list.Insert(5, "Edwin");
            list.Insert(6, "Daniel");
            list.Insert(7, "Danilo");

            foreach (string obj in list) {
                Console.Write(obj + " - ");
            }

            Console.WriteLine("Contagem de elementos: " + list.Count); //conta os elementos

            string s1 = list.Find(x => x[0] == 'A'); //expressão lambda, arrow function
            Console.WriteLine("First A : " + s1);

            string s2 = list.FindLast(x => x[0] == 'P');
            Console.WriteLine("Last P : " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position A : " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'P');
            Console.WriteLine("Last position P : " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------------------\nElementos de 5 caracteres:");
            foreach (string item in list2) {
                Console.WriteLine(item);
            }

            list.Remove("Roger");
            list.RemoveAll(x => x[0] == 'D');
            list.RemoveAt(2);

            Console.WriteLine("-----------------------\nRemovendo elementos 'Roger' e os que começam com 'D' e o segundo elemento:");
            foreach (string item in list) {
                Console.WriteLine(item);
            }

            list.RemoveRange(0, 4);
            Console.WriteLine("-----------------------\nRemovendo Range:");
            foreach (string item in list) {
                Console.WriteLine(item);
            }
        }
    }
}
