using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_de_fixação.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }


        public Product _product { get; set; }





        public OrderItem(double price, int quantity, Product product)
        {
            Quantity = quantity;
            Price = price;
            _product = product;
        }

        public OrderItem()
        {
        }

        public double Subtotal() {
            return Price * Quantity;
        
        }

        public override string ToString()
        {
            return _product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + Subtotal().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
