﻿
namespace Herança.Entities
{
    internal class BusinessAcount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAcount()
        {
           
        }
        public BusinessAcount(int number, string holder, double balance, double loanLimit)
            :base(number,holder,balance)
        { 
            
            LoanLimit = balance;
        
        }

        public void Loan(double amount) 
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }

        }

    }
}
