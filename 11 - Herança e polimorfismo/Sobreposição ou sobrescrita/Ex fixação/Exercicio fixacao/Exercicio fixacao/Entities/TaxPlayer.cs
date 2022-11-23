using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_fixacao.Entities
{
    abstract class TaxPlayer
    {
        public string Name { get; set; }
        public double AnualInCome { get; set; }

        protected TaxPlayer(string name, double anualInCome)
        {
            Name = name;
            AnualInCome = anualInCome;
        }

        abstract public double Tax();
    }
}
