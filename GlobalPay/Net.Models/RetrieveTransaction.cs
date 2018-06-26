using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalPay.Net.Models
{
    public class RetrieveTransactionRequest
    {
        public string Merchantid { get; set; }
        public string Merchantreference { get; set; }
        public string Transactionreference { get; set; }
    }

    public class RetrieveTransactionResponse {
        public string Merchantid { get; set; }
        public string Merchantreference { get; set; }
        public string Transactionreference { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string Transactiontype { get; set; }
        public Status Status { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Product { get; set; }
        public string Paymentmethods { get; set; }
    }

}
