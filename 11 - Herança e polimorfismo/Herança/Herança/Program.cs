using Herança.Entities;

Account acc = new Account(1001, "ALEX" , 0.0);

BusinessAcount bacc = new BusinessAcount(1002, "Maria", 0.0, 500);

//UPCASTING 

Account acc1 = bacc;
Account acc2 = new BusinessAcount(1003, "Bob", 0.0, 2000.00);
Account acc3 = new SavingsAccount(0.01, 1004,"Anna", 0.0);

//DOWNCASTING

BusinessAcount acc4 = (BusinessAcount)acc2;
acc4.Loan(100.0);

//BusinessAcount acc5 = (BusinessAcount)acc3;

if (acc3 is BusinessAcount) {
    BusinessAcount acc5 = (BusinessAcount)acc3;
    acc5.Loan(200.00);

    Console.WriteLine("Loan!");
}
if (acc3 is SavingsAccount)
{
    // SavingsAccount acc5 = (SavingsAccount)acc3;
    SavingsAccount acc5 = acc3 as SavingsAccount;
    acc5.UpdateBalance();
    Console.WriteLine("Update!");
}