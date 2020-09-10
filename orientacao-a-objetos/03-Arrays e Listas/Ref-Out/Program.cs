using System;

namespace Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            // passando variaveis por referencia sem usar o return de funcoes, usando ref e out, a diferenca é que o REF exige que a variavel seja iniciada e o OUT não exige.
            int a = 8;
            Calcular.Triplo1(ref a);
            Console.WriteLine(a);

            int b = 5;
            int triplo;
            Calcular.Triplo2(b, out triplo);
            Console.WriteLine(triplo);
        }
    }
}
