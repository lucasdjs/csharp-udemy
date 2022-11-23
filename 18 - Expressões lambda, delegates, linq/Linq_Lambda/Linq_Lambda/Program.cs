using Linq_Lambda.Entities;

static void Print<T>(string message, IEnumerable<T> collection)
{
    Console.WriteLine(message);

    foreach (T obj in collection)
    {
        Console.WriteLine(obj);
    }
}

Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

List<Product> products = new List<Product>()
{
    new Product(){Id = 1, Name = "Computer", Price = 1100.00, Category = c2 },
    new Product(){Id = 2, Name = "Hammer", Price = 800.00, Category = c1 },
    new Product(){Id = 3, Name = "Tv", Price = 90.00, Category = c3 },
    new Product(){Id = 4, Name = "Notebook", Price = 051.00, Category = c2 },
    new Product(){Id = 5, Name = "saw", Price = 5100.00, Category = c1 },
    new Product(){Id = 6, Name = "Tablet", Price = 700.00, Category = c3 },
    new Product(){Id = 7, Name = "Camera", Price = 1700.00, Category = c2 },
    new Product(){Id = 8, Name = "Printer", Price = 1100.00, Category = c3 },
    new Product(){Id = 9, Name = "Macbook", Price = 1100.00, Category = c1 },
    new Product(){Id = 10, Name = "Sound bar", Price = 1100.00, Category = c3 },
    new Product(){Id = 11, Name = "Level", Price = 1100.00, Category = c1 }



};



//var r1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900);
var r1 =
    from p in products
    where p.Category.Tier == 1 && p.Price < 900.00
    select p;

Console.WriteLine();
Print("Tier 1 and price < 900: ", r1);
Console.WriteLine();
//var r2 = products.Where(x => x.Category.Name == "Tools").Select(x=> x.Name);


var r2 = from p in products
         where p.Category.Name == "Tools"
         select p.Name;
Console.WriteLine();
Print("Names of products from tools: ", r2);

//var r3 = products.Where(x => x.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name }) ;
var r3 =
    from p in products
    where p.Name[0] == 'C'
    select new
    {
        p.Name,
        p.Price,
        CategoryName = p.Category.Name
    };

Console.WriteLine();
Print("Name começado com C e objetos anonimos: ", r3);

//var r4 = products.Where(x => x.Category.Tier == 1).OrderBy(x => x.Price).ThenBy(p=>p.Name);
var r4 = from p in products
         where p.Category.Tier == 1
         orderby p.Name
         orderby p.Price
         select p;

Console.WriteLine();
Print("Tier 1 ordenado por preço e depois por nome: ", r4);

var r6 = r4.Skip(1).Take(1);
var r5 = (from p in r4
         select p).Skip(2).Take(4);



Console.WriteLine();
Print("Tier 1 ordenado por preço e depois por nome skip 2 e take 4: ", r5);

//var r6 = products.FirstOrDefault();
//var r6 = (from p in products select p).FirstOrDefault();

Console.WriteLine();
Console.WriteLine("First test1: " + r6);

Console.WriteLine();

var r7 = products.Where(p=> p.Price>10000.00).FirstOrDefault();

Console.WriteLine("First test2: " + r7);

Console.WriteLine();

var r8 = products.Where(x=> x.Id ==3).SingleOrDefault();

Console.WriteLine("Single or default test1: " + r8);


var r9 = products.Where(x=> x.Id ==30).SingleOrDefault();

Console.WriteLine("Single or default test2: " + r9);
Console.WriteLine();

var r10 = products.Max(x => x.Price);

Console.WriteLine("Max price: " + r10);

Console.WriteLine();

var r11 = products.Min(x => x.Price);

Console.WriteLine("Min price: " + r11);

var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);

Console.WriteLine("Category 1 sum price: " + r12);

var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price); //média

Console.WriteLine("Category 1 average price: " + r13);
Console.WriteLine();
//média com categoria nao existente
var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.00).Average(); 

Console.WriteLine("Category 1 average price: " + r14);
Console.WriteLine();

var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0,(x, y) => x + y);

Console.WriteLine("Category 1 aggregate sum: " + r15);

Console.WriteLine();

//var r16 = products.GroupBy(x => x.Category);

var r16 = from p in products
          group p by p.Category;


foreach (IGrouping<Category, Product> group in r16)
{
    Console.WriteLine("Category " + group.Key.Name + ": ");

    foreach (Product product in group)
    {
        Console.WriteLine(product);

    }
    Console.WriteLine();
}