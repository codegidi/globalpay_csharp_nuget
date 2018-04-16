using System;
using System.Collections.Generic;
using System.Text;
using GlobalPay.Net.Interfaces;
using GlobalPay.Net.Models;
using System.Threading.Tasks;

namespace GlobalPay.Net.Transaction
{
    class Transactions : ITransaction {

        public async Task<TransactionRegistrationResponse> InitializeTransaction(string email, int amount, string firstName = null,
                                                                               string lastName = null, string callbackUrl = null, string reference = null, bool makeReferenceUnique = false) {

        }

    }
}
