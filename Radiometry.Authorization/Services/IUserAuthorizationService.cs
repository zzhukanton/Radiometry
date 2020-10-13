using System.Security.Claims;

namespace Radiometry.Authorization.Services
{
	public interface IUserAuthorizationService
	{
		ClaimsIdentity GetIdentity(string username, string password);

		string GetAccessToken(ClaimsIdentity identity);
	}
}