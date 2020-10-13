using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Radiometry.Authorization.Models;
using Radiometry.Authorization.Services;

namespace Radiometry.Authorization
{
	public class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public void ConfigureServices(IServiceCollection services)
		{
			string connection = Configuration.GetConnectionString("DefaultConnection");
			services.AddDbContext<RadiometryUserContext>(options =>
				options.UseSqlServer(connection));

			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
					.AddJwtBearer(options =>
					{
						options.RequireHttpsMetadata = false;
						options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
						{
							ValidateIssuer = true,
							ValidIssuer = AuthOptions.ISSUER,
							ValidateAudience = true,
							ValidAudience = AuthOptions.AUDIENCE,
							ValidateLifetime = true,
							IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
							ValidateIssuerSigningKey = true,
						};
					});

			services.AddControllers();

			services.AddTransient<IUserAuthorizationService, UserAuthorizationService>();
		}

		public void Configure(IApplicationBuilder app)
		{
			app.UseDeveloperExceptionPage();

			app.UseDefaultFiles();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapDefaultControllerRoute();
			});
		}
	}
}