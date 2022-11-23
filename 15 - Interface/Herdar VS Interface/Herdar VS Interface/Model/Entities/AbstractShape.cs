using Herdar_VS_Interface.Model.Entities.Interface;
using Herdar_VS_Interface.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herdar_VS_Interface.Model.Entities
{
  public abstract class AbstractShape: IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
