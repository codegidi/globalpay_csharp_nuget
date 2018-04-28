using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalPay.Net.Models
{
    public class RetrieveTransactionRequest
    {
        public string merchantid { get; set; }
        public string merchantreference { get; set; }
        public string transactionreference { get; set; }
    }

    public class RetrieveTransactionResponse {
        public string merchantid { get; set; }
        public string merchantreference { get; set; }
        public string transactionreference { get; set; }
    }

}
