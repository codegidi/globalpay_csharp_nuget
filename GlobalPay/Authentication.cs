v using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;
using GlobalPay.Net.Globals;
using GlobalPay.Net.Interfaces;
using GlobalPay.Net.Models;

namespace GlobalPay.Net
{
    public class GlobalPayAuthentication : IAuthentication
    {
        public async Task<ClientAuthenticationResponse> AuthenticateClient(string _clientId, string _clientSecret) {
            var client = HttpConnection.callClient();

            var bodyKeyValues = new List<KeyValuePair<string, string>>();
            bodyKeyValues.Add(new KeyValuePair<string, string>("client_id", _clientId));
            bodyKeyValues.Add(new KeyValuePair<string, string>("client_secret", _clientSecret));
            bodyKeyValues.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));

            var formContent = new FormUrlEncodedContent(bodyKeyValues);
            var response = await client.PostAsync("/connect/token", formContent);
            var responseJson = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ClientAuthenticationResponse>(responseJson);
        }
    }
}
