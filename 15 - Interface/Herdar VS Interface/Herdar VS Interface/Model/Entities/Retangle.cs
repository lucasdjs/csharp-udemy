using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herdar_VS_Interface.Model.Entities
{
    public class Retangle: AbstractShape
    {
        public double Heigth { get; set; }
        public double Width { get; set; }

        public override double Area()
        {
            return Heigth * Width;
        }

        public override string ToString()
        {
            return "Retangle color = "
                + Color
                + ", width = "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", height = "
                + Heigth.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
