using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_fixacao.Entities
{
    internal class Company : TaxPlayer
    {

        public int NumberOfEmployees { get; set; }

        public Company(int numberOfEmployees, string name, double anualincome):base(name, anualincome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
           if (NumberOfEmployees > 10)
            {
                return AnualInCome * 0.14;
            }
            else {
                return AnualInCome * 0.16;
            }
        }
    }
}
