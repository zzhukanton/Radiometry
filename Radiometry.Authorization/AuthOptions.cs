using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Radiometry.Authorization
{
	public class AuthOptions
    {
        public const string ISSUER = "RadiometryAuthServer";

        public const string AUDIENCE = "RadiometryClient";

        const string KEY = "mysupersecret_secretkey!123";

        /// <summary>
        /// Token's lifetime in minutes
        /// </summary>
        public const int LIFETIME = 1;

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
