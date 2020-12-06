using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Radiometry.TabletProcessor.Models
{
	public class Profile
	{
		[Required]
		[JsonProperty("id")]
		public int ProfileId { get; set; }

		[JsonProperty("tabletId")]
		public int TabletId { get; set; }

		[JsonProperty("profileX")]
		public int ProfileX { get; set; }

		[JsonIgnore]
		public byte[] Chart { get; set; }

		[JsonProperty("average")]
		public decimal Avegare { get; set; }

		[JsonProperty("max")]
		public decimal Max { get; set; }

		[JsonProperty("min")]
		public decimal Min { get; set; }
	}
}
