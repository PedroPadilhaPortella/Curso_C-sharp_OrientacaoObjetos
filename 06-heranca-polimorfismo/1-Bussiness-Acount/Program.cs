using System;
using Bussiness_Acount.Entities;

namespace Bussiness_Acount
{
    class Program
    {
        static void Main(string[] args)
        {
            //PARTE 1
            BussinessAcount conta = new BussinessAcount(8019, "Pedro Portella", 1600, 600);
            System.Console.WriteLine(conta.Balance);
            // conta1.Balance = 200; Não pode alterar pois é protected

            //PARTE 2
            //upcasting -> conversao de subclasse para superclasse
            Account conta1 = new Account(1008, "Alex dos Anjos", 0);
            BussinessAcount bussiness1 = new BussinessAcount(1934, "Maria de Fatima", 0, 500);
            Account conta2 = bussiness1;

            Account conta3 = new BussinessAcount(3452, "Bob Springer", 800, 600);
            Account conta4 = new SavingsAccount(1094, "Ana Carolina", 400, 100);

            //downcasting -> conversao da superclasse para a subclasse
            BussinessAcount bussiness2 = (BussinessAcount)conta2; //casting
            bussiness2.Loan(100);
            // conta2.Loan();

            //Não é possivel converter de SavingsAccount para BussinessAcount
            if(conta4 is BussinessAcount)
            {
                BussinessAcount bussiness5 = conta4 as BussinessAcount; //outra forma de fazer casting
                bussiness5.Loan(400);
                Console.WriteLine("Loaned");
            }
            if(conta4 is SavingsAccount)
            {
                SavingsAccount savings1 = conta4 as SavingsAccount; //outra forma de fazer casting
                savings1.UpdateBalance();
                Console.WriteLine("Updated");
            }

            //PARTE 3
            //virtual e override de metodos, sobreposição de um metodo da superclasse na subclasse
            Account cc1 = new Account(1314, "Rafel Brandao", 1200);
            Account cc2 = new SavingsAccount(1456, "Jorge Marcelo", 1200, 0.01);
            Account cc3 = new BussinessAcount(2421, "Roger Smith", 1200, 500);
            cc1.Withdraw(100);
            cc2.Withdraw(100);
            cc3.Withdraw(100);
            Console.WriteLine(cc1.Balance); //Account -> discount -105
            Console.WriteLine(cc2.Balance); //SavingsAccount -> discount - 100
            Console.WriteLine(cc3.Balance); //BussinessAccount -> discount -110
        }
    }
}
