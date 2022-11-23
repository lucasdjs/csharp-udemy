using System.Linq;

//especificar o data Source

int[] numbers = new int[] {2,3,4,5 };

//Definir a consulta

var result = numbers
    .Where(x => x % 2 == 0)
    .Select(x=>x*10);

//Execute the query

foreach (int x in result)
{
    Console.WriteLine(x);
}