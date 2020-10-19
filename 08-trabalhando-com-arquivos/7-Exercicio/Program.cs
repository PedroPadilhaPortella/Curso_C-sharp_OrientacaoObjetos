using _7_Exercicios.Entities;
using System;
using System.Globalization;
using System.IO;

namespace _7_Exercicios {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine(); //recebe o path do arquivo

            try {
                string[] lines = File.ReadAllLines(sourceFilePath); //lê todo o arquivo

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath); //path do diretório de origem
                string targetFolderPath = sourceFolderPath + @"\out"; //path da pasta de destino
                string targetFilePath = targetFolderPath + @"\summary.csv"; //path do arquivo de destino

                Directory.CreateDirectory(targetFolderPath); //cria o diretório de destion

                using (StreamWriter sw = File.AppendText(targetFilePath)) { //StreamWriter para escrever texto na variavel
                    foreach (string line in lines) {//passa linha por linha

                        string[] fields = line.Split(','); //divide os campos do arquivo csv pela virgula
                        string name = fields[0]; //nome
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture); //preco
                        int quantity = int.Parse(fields[2]); //quantidade

                        Product prod = new Product(name, price, quantity); //instancia de Product

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                        //escreve o nome e o total no arquivo sw
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}