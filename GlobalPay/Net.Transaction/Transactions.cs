using System;
using System.Collections.Generic;
using System.Text;
using GlobalPay.Net.Interfaces;
using GlobalPay.Net.Models;
using System.Threading.Tasks;

namespace GlobalPay.Net.Transaction
{
    class Transactions : ITransaction {

        public async Task<TransactionRegistrationResponse> InitializeTransaction(String returnurl, String customerip,) {

        }

    }
}
