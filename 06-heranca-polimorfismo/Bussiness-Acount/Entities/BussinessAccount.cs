using System;

namespace Bussiness_Acount.Entities
{
    class BussinessAcount : Account
    {
        public double LoanLimit { get; set; }
        public BussinessAcount(){}
        public BussinessAcount(int number, string holder, double balance, double loanLimit)
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