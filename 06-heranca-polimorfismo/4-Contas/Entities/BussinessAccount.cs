using System;

namespace Contas.Entities
{
    class BussinessAccount : Account
    {
        public double LoanLimit { get; set; }
        public BussinessAccount(){}
        public BussinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            // Number = number;
            // Holder = holder;
            // Balance = balance;
            LoanLimit = loanLimit;
        }
        public void Loan(double amount)
        {
            if(amount <= LoanLimit){
                Balance += amount;
            }
        }
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 5;
        }
    }
}