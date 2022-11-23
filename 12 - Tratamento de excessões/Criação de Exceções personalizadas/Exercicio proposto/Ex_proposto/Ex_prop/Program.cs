using Ex_prop.Entities;
using Ex_prop.Entities.Exceptions;
using System.Globalization;

try
{
    Console.WriteLine("Enter acconunt data: ");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw limit: ");
    double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



    Account account = new Account(number, holder, initialBalance, withDrawLimit);


    Console.WriteLine();
    Console.Write("Enter amount for withdraw: ");

    double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    account.WithDraw(withDraw);


    Console.WriteLine(account);

}
catch (DomainException e)
{
    Console.WriteLine("Error: " + e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Format invalid" + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("unrecognized exception! " + e.Message);
}