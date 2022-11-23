using System.Globalization;

int a = int.Parse(Console.ReadLine());
char b = char.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

string [] vetor = Console.ReadLine().Split(' ');
string nome = vetor[0];
char sexo = char.Parse(vetor[1]);
int idade = int.Parse(vetor[2]);
double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);


Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(nome);
Console.WriteLine(sexo);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


