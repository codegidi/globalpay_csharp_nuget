using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalPay.Net.Globals
{
    public class Constants
    {
        public const string BaseEndURlLive = "https://api.globalpay.com.ng/v2/PaymentGateway/PaymentGatewayCapture";
        public const string BaseEndURlStaging = "https://gpaygatewayapi.azurewebsites.net/v2/PaymentGateway/PaymentGatewayCapture";
        public const string AuthURLStaging = "https://gpayauthorisation.azurewebsites.net/";
        public const string AuthURLLive = "https://auth.globalpay.com.ng";
        public const string ContentTypeHeaderJson = "application/json";
        public const string AuthorizationHeaderType = "Bearer";
    }
}


