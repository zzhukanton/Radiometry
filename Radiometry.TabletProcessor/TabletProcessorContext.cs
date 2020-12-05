using Microsoft.EntityFrameworkCore;
using Radiometry.TabletProcessor.Models;

namespace Radiometry.TabletProcessor
{
	public class TabletProcessorContext: DbContext
	{
		public DbSet<Tablet> Tablets { get; set; }

		public DbSet<Profile> Profiles { get; set; }

		public DbSet<Data> Datas { get; set; }

		public TabletProcessorContext(DbContextOptions<TabletProcessorContext> options)
			: base(options)
		{
			Database.EnsureCreated();
		}
	}
}
