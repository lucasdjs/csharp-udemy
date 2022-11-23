using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herdar_VS_Interface.Model.Entities
{
    public class Circle : AbstractShape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle color = "
                + Color
                + ", Radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
