//Representa um metodo que recebe um objeto do tipo T e retorna um valor booleano
using System.Collections.Generic;
using Predicate.Entities;


List<Product> list = new List<Product>();

list.Add(new Product("Tv", 900.00));
list.Add(new Product("Tablet", 400.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("HD", 80.90));


list.RemoveAll(ProductTest);

foreach (Product p in list)
{
   
    Console.WriteLine(p);
}

 static bool ProductTest(Product p)
{
    return p.Price >= 100;
}