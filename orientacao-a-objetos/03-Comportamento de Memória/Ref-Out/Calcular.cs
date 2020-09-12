using System;

namespace Ref_Out
{
    class Calcular
    {
        public static void Triplo1(ref int x) {
            x = x * 3;
        }

        public static void Triplo2(int x, out int resultado) {
            resultado = x * 3;
        }
    }
}