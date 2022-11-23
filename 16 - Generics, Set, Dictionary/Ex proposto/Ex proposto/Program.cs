using Ex_proposto.Entities;

HashSet<Alunos> Alunos = new HashSet<Alunos>();

Console.Write("How many students for course A: ");
int a = int.Parse(Console.ReadLine());


for (int i = 0; i < a; i++)
{
    int n = int.Parse(Console.ReadLine());
    Alunos.Add(new Alunos(n));
}


Console.Write("How many students for course B: ");
int b = int.Parse(Console.ReadLine());

for (int i = 0; i < b; i++)
{
    int n = int.Parse(Console.ReadLine());
    Alunos.Add(new Alunos(n));
}

Console.Write("How many students for course C: ");
int c = int.Parse(Console.ReadLine());

for (int i = 0; i < c; i++)
{
    int n = int.Parse(Console.ReadLine());
    Alunos.Add(new Alunos(n));
}

Console.WriteLine("Total students: " + Alunos.Count);