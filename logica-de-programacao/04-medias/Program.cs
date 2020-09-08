using System;

namespace _04_medias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de Médias: ");
            int quant = int.Parse(Console.ReadLine());

            double nota = 0; 
            double[] media = new double[quant];
            
            for (int i = 0; i < quant; i++) {
                string[] notas = Console.ReadLine().Split(' ');
                for (int j = 0; j < notas.Length; j++) {
                    nota += double.Parse(notas[j]);
                }
                media[i] = nota / 3.0;
                nota = 0;
            }

            for (int i = 0; i < media.Length; i++) {
                System.Console.WriteLine(media[i]);
            }
        }
    }
}
