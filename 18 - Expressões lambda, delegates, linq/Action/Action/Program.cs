//representa um metodo void que recebe zero ou mais argumentos

using Action.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.00));
list.Add(new Product("HD", 80.90));

Action<Product> act = p=> { p.Price += p.Price * 0.1; };


list.ForEach(act);


foreach (Product product in list)
{
   Console.WriteLine(product);
}

        //foreach (Product product in list)
        //{
        //    product.Price+= (product.Price * 0.10);
        //    Console.WriteLine(product);
        //}
static void UpdatePrice(Product p)
{
    p.Price += p.Price * 0.1;
}