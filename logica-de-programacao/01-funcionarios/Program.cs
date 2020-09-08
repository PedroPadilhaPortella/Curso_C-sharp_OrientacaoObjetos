using System;

namespace _01_funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Id Funcionário: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.Write("Valor/Hora: ");
            double valor_hora = float.Parse(Console.ReadLine());

            double salario = horas * valor_hora;

            System.Console.WriteLine($"CÓDIGO ID: {id} \nSALÁRIO: R${salario.ToString("N2")}");
        }
    }
}
