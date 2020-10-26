using System;

namespace Operacao
{
    class Program
    {
        delegate void Calculo(int x, int y);

        static void Main(string[] args)
        {
            Matematica m = new Matematica();

            Calculo calculo = null;

            calculo += m.Somar;
            calculo += m.Subtrair;
            calculo += m.Multiplicar;
            calculo += m.Dividir;

            calculo(10, 2);

            calculo -= m.Dividir;
            calculo -= m.Soma;

            calculo(15, 3)
        }
    }
}
