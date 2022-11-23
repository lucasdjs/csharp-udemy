using ColecoesHash;
using ColecoesHash.Entities;

HashSet<Product> a = new HashSet<Product>();

a.Add(new Product("Nome", 900.00));

a.Add(new Product("Notebook", 1200.00));

HashSet<Point> b = new HashSet<Point>();

b.Add(new Point(3,4));
b.Add(new Point(5,10));

Product prod = new Product("Notebook", 1200.00);
Product prodc = new Product("Notebook", 1200.00);

Console.WriteLine(prod.Equals(prodc));

Console.WriteLine(a.Contains(prod));

Point p = new Point(5, 10);

Console.WriteLine(b.Contains(p));