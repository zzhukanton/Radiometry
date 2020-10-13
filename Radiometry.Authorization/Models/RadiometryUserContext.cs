using Microsoft.EntityFrameworkCore;

namespace Radiometry.Authorization.Models
{
	public class RadiometryUserContext: DbContext
	{
		public DbSet<User> Users { get; set; }

		public RadiometryUserContext(DbContextOptions<RadiometryUserContext> options)
			: base(options)
		{
			Database.EnsureCreated();
		}
	}
}