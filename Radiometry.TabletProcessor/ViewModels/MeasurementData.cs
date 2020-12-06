using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Radiometry.TabletProcessor.ViewModels
{
	[Bind("TabletData")]
	public class MeasurementData
	{
		[JsonProperty("tabletId")]
		public int TabletId { get; set; }

		[JsonProperty("tabletData")]
		public decimal[][] TabletData { get; set; }
	}
}
