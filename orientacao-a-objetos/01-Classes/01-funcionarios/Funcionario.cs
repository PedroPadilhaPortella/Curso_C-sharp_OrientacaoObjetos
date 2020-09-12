using System;

namespace _01_funcionarios
{
    class Funcionarios
    {
        public string nome;
        public double salario;

        public static double calcularMedia(double salario1, double salario2) {
            return (salario1 + salario2) / 2.0;
        }

    }
}