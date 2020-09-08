using System;

namespace _04_in_out
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de Numeros: ");
            int quant = int.Parse(Console.ReadLine());
            int valorIN = 0;
            int valorOUT = 0;
            for (int i = 1; i <= quant; i++) {
                int valor = int.Parse(Console.ReadLine());
                if (valor >= 10 && valor <= 20) {
                    valorIN ++;
                }else{
                    valorOUT ++;
                }
            }

            System.Console.WriteLine($"in: {valorIN}");
            System.Console.WriteLine($"out: {valorOUT}");
        }
    }
}
