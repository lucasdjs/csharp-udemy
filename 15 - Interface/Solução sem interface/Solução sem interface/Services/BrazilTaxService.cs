using Solução_sem_interface.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solução_sem_interface.Services
{
    public class BrazilTaxService : ITaxService
    {
        public double Tax(double amount) {
            if (amount <= 100.00)
            {
                return amount * 0.2;

            }
            return amount * 0.15;
        
        }


    }
}
