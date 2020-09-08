using System;

namespace _02_duracao_jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qula foi o horário inicial e final do jogo?");
            string[] valores = Console.ReadLine().Split(' ');
            int inicio = int.Parse(valores[0]);
            int fim = int.Parse(valores[1]);
            int total = 0;
            if(inicio >= fim){
                total = 24 - inicio + fim;
            }else{
                total = fim - inicio;
            }

            System.Console.WriteLine($"O jogo durou {total} horas");
        }
    }
}
