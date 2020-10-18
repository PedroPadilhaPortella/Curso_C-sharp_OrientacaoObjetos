using System;
using System.IO;
using System.Collections.Generic;

namespace _5_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Files";

            try{
                //listando todos os diretorios e subdiretorios da pasta Files
                /*IEnumerable<string>*/var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folders){
                    Console.WriteLine(s);
                }

                //listando todos os arquivos e subarquivos da pasta Files
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("\nFILES: ");
                foreach (string s in files){
                    Console.WriteLine(s);
                }
                
                //Criando uma nova pasta
                Directory.CreateDirectory(path + @"\emptyFolder");
                System.Console.WriteLine("\nFolder Created");
            }
            catch (IOException e){
                Console.WriteLine("An error ocurred:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
