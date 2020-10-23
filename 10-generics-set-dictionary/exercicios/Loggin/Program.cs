using System;
using System.IO;
using System.Collections.Generic;
using Loggin.Entities;


namespace Loggin
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Registros> registros = new HashSet<Registros>();
            Console.Write("Enter full path: ");
            string path = Console.ReadLine();

            try{
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        registros.Add(new Registros() {User = name, Instant = instant});
                    }
                    System.Console.WriteLine("Total Users: " + registros.Count);
                    foreach (Registros reg in registros) {
                        System.Console.WriteLine(reg);
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
