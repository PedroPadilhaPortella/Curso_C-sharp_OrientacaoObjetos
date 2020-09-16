using System;

namespace _03_gasStation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0, gasolina = 0, alcool = 0, diesel = 0;

            System.Console.WriteLine("Alcool => 1\nGasolina => 2\nDiesel => 3");
            while (number != 4){
                number = int.Parse(Console.ReadLine());

                if(number == 1){
                    alcool ++;
                }else if(number == 2){
                    gasolina ++;
                }else if(number == 3){
                    diesel ++;
                }
            }
            System.Console.WriteLine("MUITO OBRIGADO!");
            System.Console.WriteLine($"Alcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}");
        }
    }
}
