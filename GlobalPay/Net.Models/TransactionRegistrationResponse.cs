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
        public ErrorDescription errorDescription { get; set; }
    }

    public class ErrorDescription {
        public bool iserror { get; set; }
        public string errorcode { get; set; }
        public string errorparameter { get; set; }
        public string reason { get; set; }
    }
}
