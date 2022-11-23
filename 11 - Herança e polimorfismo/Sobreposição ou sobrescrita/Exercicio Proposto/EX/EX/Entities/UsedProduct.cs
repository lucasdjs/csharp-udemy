using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EX.Entities
{
    internal class UsedProduct: Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public UsedProduct() { }

        public override string PriceTag()
        {
            return Name + $"(Used) ${Price.ToString("F2", CultureInfo.InvariantCulture )} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")} )" ;
        }
    }
}
