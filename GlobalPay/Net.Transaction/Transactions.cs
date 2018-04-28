using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using GlobalPay.Net.Globals;
using GlobalPay.Net.Interfaces;
using GlobalPay.Net.Models;

namespace GlobalPay.Net.Transaction
{
    public class Transactions : ITransaction {

        public async Task<TransactionRegistrationResponse> InitializeTransaction(string _returnurl, string _merchantreference, string _description, string _totalamount, string _currencycode, string _customerEmail, string _customerNumber, string _customerFirstName, string _customerLastName, string _token) {
            var client = HttpConnection.call(_token);
            var _customer = new Customer {
                email = _customerEmail,
                firstname = _customerFirstName,
                lastname = _customerLastName,
                mobile = _customerNumber,
            };

            var transactionRegistrationRequest = new TransactionRegistrationRequest {
                returnurl = _returnurl,
                customerip = "",
                merchantreference = _merchantreference,
                description = _description,
                currencycode = _currencycode,
                totalamount = _totalamount,
                paymentmethod = "card",
                transactionType = "Payment",
                connectionmode = "redirect",
                customer = _customer
            };


            var requestJson = JsonConvert.SerializeObject(transactionRegistrationRequest);
            var stringContent = new StringContent(requestJson, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/api/Payment/SetRequest", stringContent);
            var responseJson = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<TransactionRegistrationResponse>(responseJson);
        }

        public async Task<RetrieveTransactionResponse> RetrieveTransaction(string _merchantId, string _merchantReference, string _transactionReference, string _token) {
            var client = HttpConnection.call(_token);
            var _retrieveTransactionRequest = new RetrieveTransactionRequest {
                merchantid = _merchantId,
                merchantreference = _merchantReference,
                transactionreference = _transactionReference,
            };


            var requestJson = JsonConvert.SerializeObject(_retrieveTransactionRequest);
            var stringContent = new StringContent(requestJson, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/api/Payment/Retrieve", stringContent);
            var responseJson = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<RetrieveTransactionResponse>(responseJson);

        }

    }
}
