using Exercicio_Resolvido_01.Entities;
using System.Collections.Generic;
using System.Globalization;

Employee lista = new Employee();


Console.Write("Enter the number of employees: ");
int employees = int.Parse(Console.ReadLine());
Console.WriteLine();


for (int i = 0; i < employees; i++) {


    Console.WriteLine($"Employee #{i + 1} data:");
    Console.Write("Outsourced (s/n)? ");
    char typeEmployeed = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (typeEmployeed == 's')
    {
        Console.Write("Additional charge: ");
        double addValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        lista.Employees.Add(new OutsourcedEmployee(name, hours, value,addValue));


    }
    else { 
        lista.Employees.Add(new Employee(name, hours, value)); 
    }
   

    Console.WriteLine();

}



Console.WriteLine(lista);






