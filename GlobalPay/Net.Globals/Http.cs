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

        public static string baseURL = Constants.BaseEndURlStaging;

        public static HttpClient call(string secretKey, bool isLive) {
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            
            if (isLive) {
                baseURL =  Constants.BaseEndURlLive;
            }

                var client = new HttpClient() {
                    BaseAddress = new Uri(baseURL)
                };


                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue(Constants.ContentTypeHeaderJson));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Constants.AuthorizationHeaderType, secretKey);

            return client;
            }

        public static HttpClient callClient(bool isLive) {
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            if (isLive) {
                baseURL = Constants.BaseEndURlLive;
            }

            var client = new HttpClient() {
                BaseAddress = new Uri(baseURL)
            };


            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue(Constants.ContentTypeHeaderJson));

            return client;
        }
    }

}


