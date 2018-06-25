﻿using GlobalPay.Net.Models;
using System.Threading.Tasks;

namespace GlobalPay.Net.Interfaces
{
    public interface ITransaction
    {
        Task<TransactionRegistrationResponse> InitializeTransaction(string returnUrl, string merchantReference, string merchantId, string description, string totalAmount, string currencyCode, string customerEmail, string customerNumber, string customerFirstName, string customerLastName, bool isLive);
        Task<RetrieveTransactionResponse> RetrieveTransaction(string merchantId, string merchantReference, string transactionReference, bool isLive);
    }
}
