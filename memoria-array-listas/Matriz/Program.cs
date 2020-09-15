using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[3, 3];
            System.Console.WriteLine("Comprimento da Matriz: " + matriz.Length);
            System.Console.Write("Comprimento da Dimensão: " + matriz.Rank + "\nMatriz de ");
            System.Console.Write(matriz.GetLength(0) + " x ");
            System.Console.WriteLine(matriz.GetLength(1));
        }
    }
}
