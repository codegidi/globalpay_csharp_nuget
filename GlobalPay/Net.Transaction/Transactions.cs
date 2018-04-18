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

        public async Task<TransactionRegistrationResponse> InitializeTransaction(string returnurl, string merchantreference, string description, string totalamount, string currencycode, string customerEmail, string customerNumber, string customerFirstName, string customerLastName) {
            var client = HttpConnection.CreateClient();
            var customer = new Customer {
                email = customerEmail,
                firstname = customerFirstName,
                lastname = customerLastName,
                mobile = customerNumber,
            };

            var transactionRegistrationRequest = new TransactionRegistrationRequest {
                returnurl = returnurl,
                customerip = "",
                merchantreference = merchantreference,
                description = description,
                currencycode = currencycode,
                totalamount = totalamount,
                paymentmethod = "card",
                transactionType = "Payment",
                connectionmode = "redirect",
                customer = customer
            };


            var requestJson = JsonConvert.SerializeObject(transactionRegistrationRequest);
            var stringContent = new StringContent(requestJson, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("transaction/initialize", stringContent);
            var responseJson = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<TransactionRegistrationResponse>(responseJson);
        }

    }
}
