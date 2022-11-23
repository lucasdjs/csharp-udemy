// 

double? x = null;
double? y = 10.00;

Console.WriteLine(x.GetValueOrDefault()); //pega o valor que tem ou valor default
Console.WriteLine(y.GetValueOrDefault());//pega o valor que tem ou valor default

Console.WriteLine(x.HasValue); //Dentro da variavel x existe ou nao o valor boolean
Console.WriteLine(y.HasValue); //Dentro da variavel x existe ou nao o valor boolean

if(x.HasValue)
Console.WriteLine(x.Value);
else
    Console.WriteLine("X is null");


if (y.HasValue)
    Console.WriteLine(y.Value);
else
    Console.WriteLine("y is null");

Console.WriteLine("-------------------------------------------------------");

double? z = null;
double? a = 10;

double b = z ?? 5;
double c = a ?? 5;

Console.WriteLine(b);
Console.WriteLine(c);

