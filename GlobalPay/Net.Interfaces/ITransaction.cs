using System;
using System.Collections.Generic;
using System.Text;
using GlobalPay.Net.Models;
using System.Threading.Tasks;

namespace GlobalPay.Net.Interfaces
{
    public class ITransaction
    {
        Task<TransactionRegistrationResponse> RegisterTransaction(TransactionRegistrationRequest transactionRegistrationRequest);

        //Task<TransactionResponseModel> VerifyTransaction(string reference);
    }
}
