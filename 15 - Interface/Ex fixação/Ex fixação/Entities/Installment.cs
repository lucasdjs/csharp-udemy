using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_fixação.Entities
{
    public class Installment
    {
        public DateTime DueData { get; set; }
        public double Amount { get; set; }



        public Installment(DateTime dueDate, double amount)
        {
            DueData = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueData.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    
    

}
