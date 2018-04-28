using GlobalPay.Net.Models;
using System.Threading.Tasks;

namespace GlobalPay.Net.Interfaces
{
    public interface IAuthorisation
    {
        Task<TransactionRegistrationResponse> AuthenticateClient(string username, string password, string clientId, string clientSecret);

    }
}
