using System;
using System.Globalization;

namespace _01_raio
{
    class Calculadora
    {
        public static double PI = 3.14159;
        public static double Circuferencia(double raio){
            return 2.0 * PI * raio;
        }

        public static double Volume(double raio){
            return 4.0 / 3.0 * PI * (raio * raio * raio);
        }
    }
}
