using GlobalPay.Net.Models;
using System.Threading.Tasks;

namespace GlobalPay.Net.Interfaces
{
    public interface IAuthentication
    {
        Task<ClientAuthenticationResponse> AuthenticateClient(string clientId, string clientSecret, bool isLive);

    }
}
