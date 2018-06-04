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
    }

}
