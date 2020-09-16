using System;

namespace _02_intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor entre 0 e 100");
            decimal valor = decimal.Parse(Console.ReadLine());
            if(valor >= 0 && valor <= 25){
                System.Console.WriteLine("Intervalo [0,25]");
            }else if(valor > 25 && valor <= 50){
                System.Console.WriteLine("Intervalo [25,50]");
            }else if(valor > 50 && valor <= 75){
                System.Console.WriteLine("Intervalo [50,75]");
            }else if(valor > 75 && valor <= 100){
                System.Console.WriteLine("Intervalo [75,100]");
            }else{
                System.Console.WriteLine("Valor fora do intervalo!");
            }
        }
    }
}
