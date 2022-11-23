using Ex_prop.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_prop.Entities
{
    internal class Account
    {
        public int Number { get; set; } //numero da conta
        public string Holder { get; set; } //nome
        public double Balance  { get; set; } //saldo
        public double WithDrawLimit { get; set; } //limite de saque

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
          
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;

            if (Balance <= 0)
            {
                throw new DomainException("Balance must be greater than 0.00");

            }
        }

        public void Deposit(double amount){
        
            Balance += amount;
        }
        public void WithDraw(double amount)
        {
            if (amount > WithDrawLimit) {
                throw new DomainException("The amount exceeds withdraw limit");    
            }
            if (amount > Balance) {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return "New balance $" + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
