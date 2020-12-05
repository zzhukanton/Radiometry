using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Radiometry.Authorization.Models
{
	[Bind("")]
	public class User
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("login")]
		public string Login { get; set; }
		
		[JsonProperty("password")]
		public string Password { get; set; }

		[JsonIgnore]
		public string Role { get; set; }

		[JsonProperty("organization")]
		public string Organization { get; set; }

		[JsonProperty("dateRegistred")]
		public DateTime DateRegistred { get; set; }
	}
}
