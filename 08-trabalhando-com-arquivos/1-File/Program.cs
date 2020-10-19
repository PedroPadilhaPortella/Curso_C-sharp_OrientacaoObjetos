using System;
using System.IO;

namespace _1_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\pedro\Documents\GitHub\Curso_C-sharp_OrientacaoObjetos\8-trabalhando-com-arquivos\1-File_FileInfo\teste.txt";
            string targetPath = @"C:\Users\pedro\Documents\GitHub\Curso_C-sharp_OrientacaoObjetos\8-trabalhando-com-arquivos\1-File_FileInfo\teste2.txt";

            try{
                FileInfo fileinfo = new FileInfo(sourcePath);
                fileinfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                System.Console.WriteLine("Arquivo copiado!");
                foreach (string line in lines){
                    System.Console.WriteLine(line);
                }

            }catch(IOException e){
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
