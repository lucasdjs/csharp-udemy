using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest_Generics.Entities
{
    public class Product: IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return "Product: " + Name + ", Preço: " + Price;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product)) {
                throw new ArgumentException("Comparin erro: argument is not a product");
            }
            Product other = obj as Product;

            return Price.CompareTo(other.Price);
        }
    }
}
