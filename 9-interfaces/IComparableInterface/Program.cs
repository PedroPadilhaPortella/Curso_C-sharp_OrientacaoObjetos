using System;
using System.IO;
using System.Collections.Generic;
using IComparableInterface.Entities;

namespace IComparableInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\Users\pedro\Documents\GitHub\Curso_C-sharp_OrientacaoObjetos\9-interfaces\IComparableInterface\names.txt";

            try
            {
                using(StreamReader sr = File.OpenText(path1)){
                    List<string> list = new List<string>();
                    while(!sr.EndOfStream){
                        list.Add(sr.ReadLine());
                    }
                    list.Sort();
                    Console.Write("Employees: ");

                    foreach (string str in list){
                        Console.Write(str + ", ");
                    }
                }
            }
            catch (IOException error){
                Console.WriteLine("An error occured: " + error);
            }

            string path2 = @"C:\Users\pedro\Documents\GitHub\Curso_C-sharp_OrientacaoObjetos\9-interfaces\IComparableInterface\names.csv";

            try
            {
                using(StreamReader file = File.OpenText(path2)){
                    List<Employee> employees = new List<Employee>();
                    while(!file.EndOfStream){
                        employees.Add(new Employee(file.ReadLine()));
                    }

                    employees.Sort();
                    foreach (Employee employee in employees){
                        Console.WriteLine(employee);
                    }
                }
            }
            catch (IOException error){
                Console.WriteLine("An error occured: " + error);
            }
        }
    }
}
