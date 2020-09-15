using System;

namespace diagonalprincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Ordem da Matriz: ");
            int ordem = int.Parse(Console.ReadLine());
            int[,] matriz = new int[ordem, ordem];

            for (int x = 0; x < ordem; x++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int y = 0; y < ordem; y++)
                {
                    matriz[x, y] = int.Parse(values[y]);
                }
            }
            
            Console.Write("Main Diagonal: ");
            for (int i = 0; i < ordem; i++) {
                Console.Write(matriz[i, i] + " ");
            }
            int negativos = 0;
            int positivos = 0;
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    if(matriz[i, j] > 0){
                        positivos++;
                    }else if(matriz[i, j] < 0){
                        negativos++;
                    }
                }
            }

            Console.WriteLine($"\nValores Negativos: {negativos}");
            Console.WriteLine($"Valores Positivos: {positivos}");
        }
    }
}
