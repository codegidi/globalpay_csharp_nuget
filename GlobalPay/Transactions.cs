using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using GlobalPay.Net.Globals;
using GlobalPay.Net.Interfaces;
using GlobalPay.Net.Models;
using System.Collections.Generic;

namespace GlobalPay.Net
{
    public class GlobalPayTransactions : ITransaction {

        private string _token;

        public GlobalPayTransactions(string token) {
            this._token = token;
        }

        public async Task<TransactionRegistrationResponse> InitializeTransaction(string _returnurl, string _merchantreference, string _description, string _totalamount, string _currencycode, string _customerEmail, string _customerNumber, string _customerFirstName, string _customerLastName, bool isLive) {
            var client = HttpConnection.call(_token, isLive);
            List<Product> _products = new List<Product>();

            var _product = new Product {
                Name = _description,
                Quantity = "1",
                Unitprice = _totalamount
            };
            _products.Add(_product);

            var _customer = new Customer {
                Email = _customerEmail,
                Firstname = _customerFirstName,
                Lastname = _customerLastName,
                Mobile = _customerNumber,
            };

            var transactionRegistrationRequest = new TransactionRegistrationRequest {
                Returnurl = _returnurl,
                Customerip = "",
                Merchantreference = _merchantreference,
                Description = _description,
                Currencycode = _currencycode,
                Totalamount = _totalamount,
                Paymentmethod = "card",
                TransactionType = "Payment",
                Connectionmode = "redirect",
                Customer = _customer,
                Product = _products
            };

            var requestJson = JsonConvert.SerializeObject(transactionRegistrationRequest);
            var stringContent = new StringContent(requestJson, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/api/v3/Payment/SetRequest", stringContent);
            var responseJson = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<TransactionRegistrationResponse>(responseJson);
        }

        public async Task<RetrieveTransactionResponse> RetrieveTransaction(string _merchantId, string _merchantReference, string _transactionReference, bool isLive) {
            var client = HttpConnection.call(_token, isLive);
            var _retrieveTransactionRequest = new RetrieveTransactionRequest {
                Merchantid = _merchantId,
                Merchantreference = _merchantReference,
                Transactionreference = _transactionReference,
            };


            var requestJson = JsonConvert.SerializeObject(_retrieveTransactionRequest);
            var stringContent = new StringContent(requestJson, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/api/v3/Payment/Retrieve", stringContent);
            var responseJson = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<RetrieveTransactionResponse>(responseJson);

        }

    }
}
