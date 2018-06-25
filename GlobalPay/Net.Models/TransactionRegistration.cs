using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalPay.Net.Models
{
    public class TransactionRegistrationRequest {
        public string Returnurl { get; set; }
        public string Customerip { get; set; }
        public string Merchantreference { get; set; }
        public string Merchantid { get; set; }
        public string Description { get; set; }
        public string Currencycode { get; set; }
        public string Totalamount { get; set; }
        public string Paymentmethod { get; set; }
        public string TransactionType { get; set; }
        public string Connectionmode { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Product { get; set; }
    }

    public class Product {
        public string Name { get; set; }
        public string Unitprice { get; set; }
        public string Quantity { get; set; }
    }

    public class Customer {
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }

    public class TransactionRegistrationResponse {
        public Status Status { get; set; }
        public string RedirectUri { get; set; }
        public string TransactionReference { get; set; }
    }

    public class Status {
        public string StatusCode { get; set; }
        public ErrorDescription ErrorDescription { get; set; }
    }

    public class ErrorDescription {
        public bool Iserror { get; set; }
        public string Errorcode { get; set; }
        public string Errorparameter { get; set; }
        public string Reason { get; set; }
    }
}
