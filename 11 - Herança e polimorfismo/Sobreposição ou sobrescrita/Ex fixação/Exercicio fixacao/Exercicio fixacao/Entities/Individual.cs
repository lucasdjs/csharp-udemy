using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_fixacao.Entities
{
    internal class Individual:TaxPlayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double anualinhome): base(name, anualinhome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double total = 0.00;
            if (AnualInCome < 20000)
            {
                total = AnualInCome * 0.15;

                if (HealthExpenditures>0)
                {
                   total -= (HealthExpenditures * 0.5);

                }
            }
            else {
                total = AnualInCome * 0.25;
                if (HealthExpenditures > 0)
                {
                    total -=(HealthExpenditures * 0.5);

                }
            }

            return total;


        }
    }
}
