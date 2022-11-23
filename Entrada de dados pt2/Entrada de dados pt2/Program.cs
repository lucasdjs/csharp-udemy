using System.Globalization;

int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

string[] var = Console.ReadLine().Split(' ');

String nome = var[0];
char sexo = char.Parse(var[1]);
int idade = int.Parse(var[2]);
double altura = double.Parse(var[3], CultureInfo.InvariantCulture);


Console.WriteLine("voce digitou: " + n1 + ch + n2.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(nome);
Console.WriteLine(sexo);
Console.WriteLine(altura);
Console.WriteLine(idade.ToString("F2", CultureInfo.InvariantCulture));
