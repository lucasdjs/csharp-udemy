using Herança.Entities;
using System.Globalization;


List<Account>List = new List<Account>();

List.Add(new SavingsAccount(1001.55,41, "Alex", 0.01));
List.Add(new BusinessAcount(1005,  "Alex", 41, 0.01));
List.Add(new SavingsAccount(1004.55, 411, "Bob", 0.01));
List.Add(new BusinessAcount(1006, "Ana", 48, 0.01));

double soma = 0.0;

foreach (Account acc in List) {
    soma += acc.Balance;
}


Console.WriteLine("Total Balance: " + soma.ToString("F2", CultureInfo.InvariantCulture));


foreach (Account item in List)
{
    item.Withdraw(10.00);
}
foreach (Account item in List)
{
    Console.WriteLine("Update balance for account " + soma.ToString("F2", CultureInfo.InvariantCulture) +" "+  item.Number +" " + item.Balance);
}