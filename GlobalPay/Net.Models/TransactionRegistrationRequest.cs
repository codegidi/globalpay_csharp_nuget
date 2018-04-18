using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalPay.Net.Models
{
    public class TransactionRegistrationRequest
    {
        public string name { get; set; }
        public string returnurl { get; set; }
        public string customerip { get; set; }
        public string merchantreference { get; set; }
        public string description { get; set; }
        public string currencycode { get; set; }
        public string totalamount { get; set; }
        public string paymentmethod { get; set; }
        public string transactionType { get; set; }
        public string connectionmode { get; set; }
        public Customer customer { get; set; }
        //public Product[] product { get; set; }
    }

    public class Product {
        public string name { get; set; }
        public string unitprice { get; set; }
        public string quantity { get; set; }
    }

    public class Customer {
        public string email { get; set; }
        public string mobile { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
    }
}
