namespace Operacao
{
    public class Matematica
    {
        public void Somar(int a, int b){
            System.Console.WriteLine($"Soma: {a + b}");
        }
        public void Subtrair(int a, int b){
            System.Console.WriteLine($"Subtração: {a - b}");
        }
        public void Multiplicar(int a, int b){
            System.Console.WriteLine($"Multiplicação: {a * b}");
        }
        public void Dividir(int a, int b){
            System.Console.WriteLine($"Divisão: {a / b}");
        }
    }
}