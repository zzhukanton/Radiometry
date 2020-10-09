using SQLite;
using System;

namespace Radiometry.Models
{
	public class Tablet
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		public string Title { get; set; }

		public int XCount { get; set; }

		public int YCount { get; set; }

		public int XDelta { get; set; }

		public int YDelta { get; set; }

		public bool IsCompleted { get; set; }

		public DateTime DateCompleted { get; set; }

		public decimal Latitude { get; set; }

		public decimal Longitude { get; set; }
	}
}