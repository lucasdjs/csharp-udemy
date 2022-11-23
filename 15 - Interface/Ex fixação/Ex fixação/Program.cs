using Ex_fixação.Entities;
using Ex_fixação.Services;
using System.Globalization;

Console.WriteLine("Enter contract data:");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy" , CultureInfo.InvariantCulture);
Console.Write("Contract value: ");
double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");
int installments = int.Parse(Console.ReadLine());

Contract mycontract = new Contract(number, date, value);

ContractService contractService = new ContractService(new PaypalService());
contractService.ProcessContract(mycontract, installments);

Console.WriteLine("Installments:");
foreach (Installment installment in mycontract.Installments)
{
    Console.WriteLine(installment);
}