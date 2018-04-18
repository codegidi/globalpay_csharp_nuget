using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

    namespace GlobalPay.Net.Globals {
        public static class HttpConnection {
            public static HttpClient CreateClient(/*string secretKey*/) {
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

                var client = new HttpClient() {
                    BaseAddress = new Uri(Constants.BaseEndURlLive)
                };


                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue(Constants.ContentTypeHeaderJson));

            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(BaseConstants.AuthorizationHeaderType, secretKey);

            return client;
            }
        }

}


