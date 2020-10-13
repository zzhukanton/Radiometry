using System;

namespace Radiometry.Authorization.Models
{
	public class User
	{
		public int Id { get; set; }

		public string Login { get; set; }
		
		public string Password { get; set; }

		public string Role { get; set; }

		public string Organization { get; set; }

		public DateTime DateRegistred { get; set; }
	}
}
