using Microsoft.AspNetCore.Mvc;
using Radiometry.Authorization.Services;
using System.Security.Claims;

namespace Radiometry.Authorization.Controllers
{
	public class AccountController : Controller
	{
		private readonly IAuthorizationService authorizationService;

		public AccountController(IAuthorizationService authorizationService)
		{
			this.authorizationService = authorizationService;
		}

		[HttpPost("/token")]
		public IActionResult Token(string username, string password)
		{
			ClaimsIdentity identity = this.authorizationService.GetIdentity(username, password);
			if (identity == null)
			{
				return BadRequest(new { errorText = "Invalid username or password." });
			}

			string accessToken = this.authorizationService.GetAccessToken(identity);

			return Json(new
			{
				access_token = accessToken,
				username = identity.Name
			});
		}
	}
}