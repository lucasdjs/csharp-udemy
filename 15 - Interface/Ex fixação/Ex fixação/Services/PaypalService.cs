using Ex_fixação.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_fixação.Services
{
    public class PaypalService : IOnlineServicePayment
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;
        public double Interest(double amount, int mounths)
        {
            return amount * MonthlyInterest * mounths;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
