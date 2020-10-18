using System;
using System.IO;

namespace _4_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = "archive.txt";
            string targetpath = "newArchive.txt";

            try{
                string[] lines = File.ReadAllLines(sourcepath);

                using(StreamWriter sw = File.AppendText(targetpath)){
                    foreach (string line in lines){
                        sw.WriteLine(line.ToUpper());
                    }
                    System.Console.WriteLine("Linhas copiadas!");
                }
                
            }catch (IOException e){
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }finally{

            }
        }
    }
}
