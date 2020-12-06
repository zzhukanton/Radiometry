using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Radiometry.TabletProcessor.Models
{
	public class Data
	{
		[Required]
		[JsonProperty("id")]
		public int DataId { get; set; }

		[JsonProperty("profileId")]
		public int ProfileId { get; set; }

		[JsonProperty("data")]
		public decimal[] DataArray { get; set; }
	}
}
