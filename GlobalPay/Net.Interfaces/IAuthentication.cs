using GlobalPay.Net.Models;
using System.Threading.Tasks;

namespace GlobalPay.Net.Interfaces
{
    public interface IAuthentication
    {
        Task<ClientAuthenticationResponse> AuthenticateClient(string username, string password, string clientId, string clientSecret);

    }
}
