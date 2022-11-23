//Representa um metodo que recebe zero ou mais argumentos, e retorna um valor

using Comparison.Entities;
using System.Linq;

List<Product> list = new List<Product>();

list.Add(new Product("Tv", 900.00));
list.Add(new Product("Notebook", 1900.00));
list.Add(new Product("Tablet", 450.00));
list.Add(new Product("HD", 70.90));

//Func<Product, string> func = NameUper;
Func<Product, string> func = p => p.Name.ToUpper() ;

//List<string> result = list.Select(NameUper).ToList();
//List<string> result = list.Select(func).ToList();
List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

//static string NameUper(Product p)
//{
//    return p.Name.ToUpper();
//}

foreach(string p in result)
{
    Console.WriteLine(p);
}