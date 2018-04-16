﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalPay.Net.Models
{
    class TransactionRequest
    {
        public string name { get; set; }
        public string returnurl { get; set; }
        public string customerip { get; set; }
        public string merchantreference { get; set; }
        public string description { get; set; }
        public string currencycode { get; set; }
        public string totalamount { get; set; }
        public string paymentmethod { get; set; }
        public string connectionmode { get; set; }
        public Customer customer { get; set; }
        public Product[] product { get; set; }
    }
}
