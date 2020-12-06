using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Radiometry.TabletProcessor.ViewModels
{
	[Bind("TabletId, IsProcessed")]
	public class ProcessingStatus
	{
		[JsonProperty("tabletId")]
		public int TabletId { get; set; }

		[JsonProperty("isProcessed")]
		public bool IsProcessed { get; set; }
	}
}
