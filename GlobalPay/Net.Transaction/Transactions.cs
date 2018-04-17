using System;
using System.Collections.Generic;
using System.Text;
using GlobalPay.Net.Interfaces;
using GlobalPay.Net.Models;
using System.Threading.Tasks;
using GlobalPay.Net.Globals;
using System.Net.Http;
using Newtonsoft.Json;

namespace GlobalPay.Net.Transaction
{
    class Transactions : ITransaction {

        public async Task<TransactionRegistrationResponse> InitializeTransaction(string returnurl, string merchantreference, string description, string totalamount, string currencycode, string customerEmail, string customerNumber) {
            var client = HttpConnection.CreateClient();

            var bodyKeyValues = new List<KeyValuePair<string, string>>();
            //bodyKeyValues.Add(new KeyValuePair<string, string>("email", email));
            //bodyKeyValues.Add(new KeyValuePair<string, string>("amount", amount.ToString()));

            var formContent = new FormUrlEncodedContent(bodyKeyValues);

            var response = await client.PostAsync("transaction/initialize", formContent);

            var json = await response.Content.ReadAsStringAsync();

            //return JsonConvert.DeserializeObject<PaymentInitalizationResponseModel>(json);
        }

    }
}
