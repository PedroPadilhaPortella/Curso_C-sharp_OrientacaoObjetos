using System;
using System.Globalization;

namespace Conta
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public void Depositar()
        {
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Saldo += quantia;
            Console.WriteLine(Atualizar());
        }

        public void Sacar()
        {
            Console.Write("Entre um valor para saque: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Saldo -= quantia + 5.0;
            Console.WriteLine(Atualizar());
        }

        public override string ToString()
        {
            return $"Dados da Conta:\nConta {Numero}, Titular: {Titular}, Saldo: R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public string Atualizar()
        {
            return $"Dados da Conta Atualizados:\nConta {Numero}, Titular: {Titular}, Saldo: R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}