using System;

namespace _05_multiplicacaomatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat1 = new int[2, 3];
            int[,] mat2 = new int[3, 2];
            int[,] resultado = new int[2, 2];

            for (int line = 0; line < 2; line++) {
                for (int column = 0; column < 3; column++) {
                    Console.Write($"M1 Posicao [{line}, {column}]: ");
                    mat1[line, column] = int.Parse(Console.ReadLine());
                }
            }

            for (int line = 0; line < 3; line++) {
                for (int column = 0; column < 2; column++) {
                    Console.Write($"M2 Posicao [{line}, {column}]: ");
                    mat2[line, column] = int.Parse(Console.ReadLine());
                }
            }
            resultado[0, 0] = (mat1[0, 0] * mat2[0, 0] + mat1[0, 1] * mat2[1, 0] + mat1[0, 2] * mat2[2, 0]);
            resultado[1, 0] = (mat1[1, 0] * mat2[0, 0] + mat1[1, 1] * mat2[1, 0] + mat1[1, 2] * mat2[2, 0]);
            resultado[0, 1] = (mat1[0, 0] * mat2[0, 1] + mat1[0, 1] * mat2[1, 1] + mat1[0, 2] * mat2[2, 1]);
            resultado[1, 1] = (mat1[1, 0] * mat2[0, 1] + mat1[1, 1] * mat2[1, 1] + mat1[1, 2] * mat2[2, 1]);

            Console.WriteLine($"[{resultado[0,0]}][{resultado[0,1]}]");
            Console.WriteLine($"[{resultado[1,0]}][{resultado[1,1]}]");
        }
    }
}
