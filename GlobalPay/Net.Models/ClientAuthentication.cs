using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalPay.Net.Models
{
    public class ClientAuthenticationResponse {
        public string Access_token { get; set; }
        public string Expires_in { get; set; }
        public string Token_type { get; set; }
    }

    public class ClientAuthenticationRequest {
        public string Grant_type { get; set; }
        public string Client_id { get; set; }
        public string Client_secret { get; set; }
    }
}
