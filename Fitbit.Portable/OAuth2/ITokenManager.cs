using FitbitSNHP.Api.Portable.OAuth2;
using System.Threading.Tasks;

namespace FitbitSNHP.Api.Portable
{
    public interface ITokenManager
    {
        Task<OAuth2AccessToken> RefreshTokenAsync(FitbitClient client);
    }
}