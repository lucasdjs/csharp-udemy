
namespace Exercicio_resolvido.Entities
{
    internal class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }

        public Product(double price, string name)
        {
            Price = price;
            Name = name;
        }
    }
}
