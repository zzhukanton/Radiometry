using Microsoft.IdentityModel.Tokens;
using Radiometry.Authorization.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace Radiometry.Authorization.Services
{
	public class AuthorizationService : IAuthorizationService
	{
		private readonly RadiometryUserContext context;

		public AuthorizationService(RadiometryUserContext context)
		{
			this.context = context;
		}

		public string GetAccessToken(ClaimsIdentity identity)
		{
			DateTime now = DateTime.UtcNow;
			JwtSecurityToken jwt = new JwtSecurityToken(
				issuer: AuthOptions.ISSUER,
				audience: AuthOptions.AUDIENCE,
				notBefore: now,
				claims: identity.Claims,
				expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
				signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

			return new JwtSecurityTokenHandler().WriteToken(jwt);
		}

		public ClaimsIdentity GetIdentity(string username, string password)
		{
			User person = context.Users.FirstOrDefault(user => user.Login == username && user.Password == password);

			if (person != null)
			{
				var claims = new List<Claim>
				{
					new Claim(ClaimsIdentity.DefaultNameClaimType, person.Login),
					new Claim(ClaimsIdentity.DefaultRoleClaimType, person.Role)
				};

				ClaimsIdentity claimsIdentity = new ClaimsIdentity(
					claims,
					"Token",
					ClaimsIdentity.DefaultNameClaimType,
					ClaimsIdentity.DefaultRoleClaimType);

				return claimsIdentity;
			}

			return null;
		}
	}
}