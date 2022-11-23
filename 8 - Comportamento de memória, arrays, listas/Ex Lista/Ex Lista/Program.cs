using System.Globalization;
using System.Collections.Generic;
using Ex_Lista;

Console.Write("How many employees will be registered?");

int n = int.Parse(Console.ReadLine());

List<Employee> list = new List<Employee>();


for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Emplyoee #" + i + ":");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string nome = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


    list.Add(new Employee(id, nome, salary));

}
Console.WriteLine("Enter the employee id that will have salary increase: ");
int idSalary = int.Parse(Console.ReadLine());

Employee emp = list.Find(x => x.Id == idSalary);
Console.WriteLine(emp);
if (emp != null)
{
    Console.WriteLine("Enter the percentage: ");

    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    emp.IncreaseSalary(percentage);
}
else
{
    Console.WriteLine("This id does not exist!");
}

Console.WriteLine("Updated list of employees:");

foreach (Employee employe in list)
{
    Console.WriteLine(employe);
}










