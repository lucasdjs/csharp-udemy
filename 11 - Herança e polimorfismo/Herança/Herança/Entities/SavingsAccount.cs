
namespace Herança.Entities
{
    internal class SavingsAccount:Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(double interestRate, int number, string holder, double balance):base(number, holder, balance)
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


    }
}
