using System;

namespace _posicaomatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ordem da Matriz: ");
            string[] ordens = Console.ReadLine().Split(' ');

            int row = int.Parse(ordens[0]);
            int column = int.Parse(ordens[1]);

            int[,] matriz = new int[row, column];

            for (int x = 0; x < row; x++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int y = 0; y < column; y++)
                {
                    matriz[x, y] = int.Parse(values[y]);
                }
            }

            Console.Write("Busque por um valor:");
            int valor = int.Parse(Console.ReadLine());

            for (int x = 0; x < row; x++){
                for (int y = 0; y < column; y++){
                    if (matriz[x, y] == valor){
                        Console.WriteLine($"Posição: {x}, {y}");

                        if (y > 0){
                            Console.WriteLine("Left: " + matriz[x, y - 1]);
                        }
                        if (x > 0){
                            Console.WriteLine("Up: " + matriz[x - 1, y]);
                        }
                        if (y < row - 1){
                            Console.WriteLine("Right: " + matriz[x, y + 1]);
                        }
                        if (x < column - 1){
                            Console.WriteLine("Down: " + matriz[x + 1, y]);
                        }
                    }else{
                        System.Console.WriteLine($"Valor {valor} não encontrado nessa matriz!");
                    }
                }
            }
        }
    }
}
