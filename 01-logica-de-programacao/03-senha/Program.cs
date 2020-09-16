using System;

namespace _03_senha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira sua Senha:: ");
            string senha = Console.ReadLine();

            while (senha != "2002"){
                System.Console.WriteLine("Senha Inválida");
                senha = Console.ReadLine();
            }
            System.Console.WriteLine("Acesso Permitido");
        }
    }
}
