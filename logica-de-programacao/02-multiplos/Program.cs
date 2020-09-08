using System;

namespace _02_multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores em ordem crescente?");
            string[] valores = Console.ReadLine().Split(' ');
            int v1 = int.Parse(valores[0]);
            int v2 = int.Parse(valores[1]);

            if(v1 > v2){
                int alter = v1;
                v1 = v2;
                v2 = alter;
            }

            if (v2 % v1 == 0)
                System.Console.WriteLine($"{v2} é multiplo de {v1}");
            else
                System.Console.WriteLine($"Os valores não são mutiplos");
        }
    }
}
