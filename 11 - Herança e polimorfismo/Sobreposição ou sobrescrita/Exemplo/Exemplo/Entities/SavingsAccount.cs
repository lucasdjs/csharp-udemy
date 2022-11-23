
namespace Herança.Entities
{
     class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(double interestRate, int number, string holder, double balance) : base(number, holder, balance)
        {
            InterestRate = interestRate;

        }

        public SavingsAccount()
        {
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        public sealed override void Withdraw(double amount)
        {
           base.Withdraw(amount);
           Balance -= 2.0;
        }


    }
}
