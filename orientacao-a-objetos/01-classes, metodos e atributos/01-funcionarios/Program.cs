using System;
using System.Globalization;

namespace _01_funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios func01 = new Funcionarios();
            Funcionarios func02 = new Funcionarios();

            Console.WriteLine("Dados do Primeiro Funcionário:");
            System.Console.Write("Nome:");
            func01.nome = Console.ReadLine();
            System.Console.Write("Salario:");
            func01.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Primeiro Funcionário:");
            System.Console.Write("Nome:");
            func02.nome = Console.ReadLine();
            System.Console.Write("Salario:");
            func02.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = Funcionarios.calcularMedia(func01.salario, func02.salario);

            System.Console.WriteLine($"Média salarial: {media}");
        }
    }
}
