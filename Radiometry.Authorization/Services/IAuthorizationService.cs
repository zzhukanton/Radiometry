using System.Security.Claims;

namespace Radiometry.Authorization.Services
{
	public interface IAuthorizationService
	{
		ClaimsIdentity GetIdentity(string username, string password);

		string GetAccessToken(ClaimsIdentity identity);
	}
}