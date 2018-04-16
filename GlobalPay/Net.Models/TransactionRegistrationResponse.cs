using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalPay.Net.Models
{
    public class TransactionRegistrationResponse {
        public Status status { get; set; }
        public string redirectUri { get; set; }
        public string transactionReference { get; set; }
    }

    public class Status {
        public string statusCode { get; set; }
        public string errorDescription { get; set; }
    }

}
