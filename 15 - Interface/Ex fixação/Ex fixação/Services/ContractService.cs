using Ex_fixação.Entities;
using Ex_fixação.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_fixação.Services
{
    public class ContractService
    {
        private IOnlineServicePayment _onlinePaymentService;

        public ContractService(IOnlineServicePayment onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }
        public void ProcessContract(Contract contract, int mounths) {
            double basicQuota = contract.TotalValue / mounths;

            for (int i = 0; i <= mounths; i++) {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updateQuota + _onlinePaymentService.PaymentFee(updateQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            
            }
        }
    }
}
