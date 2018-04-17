using System;
using System.Collections.Generic;
using System.Text;
using GlobalPay.Net.Models;
using System.Threading.Tasks;

namespace GlobalPay.Net.Interfaces
{
    public interface ITransaction
    {
        Task<TransactionRegistrationResponse> InitializeTransaction(string returnurl, string merchantreference, string description, string totalamount, string currencycode, string customerEmail, string customerNumber);

        //Task<TransactionResponseModel> VerifyTransaction(string reference);
    }
}
