using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GlobalPay.helpers
{
    public class Rest { 
        public async Task<string> HttpWebRequestCall(string requestUrl, object jsonRequest, string jsonMethod,
            string jsonContentType) {
            try {
                var request = WebRequest.Create(requestUrl) as HttpWebRequest;
                var sb = JsonConvert.SerializeObject(jsonRequest);
                request.Method = jsonMethod;
                request.ContentType = jsonContentType;
                if (jsonMethod == "POST" || jsonMethod == "PUT") {
                    var bt = Encoding.UTF8.GetBytes(sb);
                    var st = request.GetRequestStream();
                    st.Write(bt, 0, bt.Length);
                    st.Close();
                }

                using (var response = await request.GetResponseAsync() as HttpWebResponse) {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception(string.Format(
                            "Server error (HTTP {0}: {1}).", response.StatusCode,
                            response.StatusDescription));

                    // DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Response));
                    //object objResponse = JsonConvert.DeserializeObject();
                    var stream1 = response.GetResponseStream();
                    var sr = new StreamReader(stream1);
                    var strsb = sr.ReadToEnd();


                    return strsb;
                }
            } catch (Exception e) {
                //Todo: log errors to event store
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}