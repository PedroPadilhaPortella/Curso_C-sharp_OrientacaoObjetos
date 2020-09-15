using System;
using System.Globalization;

namespace _01_dadosUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.Write("Dados do primeiro funcionario:\nNome:");
            p1.nome = Console.ReadLine();
            System.Console.Write("Idade:");
            p1.idade = int.Parse(Console.ReadLine());
            System.Console.Write("Salário:");
            p1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Dados do segundo funcionário:\nNome:");
            p2.nome = Console.ReadLine();
            System.Console.Write("Idade:");
            p2.idade = int.Parse(Console.ReadLine());
            System.Console.Write("Salário:");
            p2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(p1.idade > p2.idade){
                System.Console.WriteLine($"{p1.nome} é mais velho");
            }else if(p1.idade < p2.idade){
                System.Console.WriteLine($"{p2.nome} é mais velho");
            }else{
                System.Console.WriteLine($"{p1.nome} e {p2.nome} tem a mesma idade");
            }

            double salario = (p1.salario + p2.salario) / 2.0;
            System.Console.WriteLine($"Salario Médio: " + salario.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
