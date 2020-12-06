using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Radiometry.TabletProcessor.Models
{
	public class Tablet
	{
		[Required]
		[JsonProperty("id")]
		public int TabletId { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("isProcessed")]
		public bool IsProcessed { get; set; }

		[JsonProperty("deltaX")]
		public decimal DeltaX { get; set; }

		[JsonProperty("distanceX")]
		public decimal DistanceX { get; set; }

		[JsonProperty("pointsX")]
		public int PointsX { get; set; }

		[JsonProperty("deltaY")]
		public decimal DeltaY { get; set; }

		[JsonProperty("distanceY")]
		public decimal DistanceY { get; set; }

		[JsonProperty("pointsY")]
		public int PointsY { get; set; }

		[JsonIgnore]
		public byte[] Map { get; set; }

		[JsonIgnore]
		public byte[] Anomaly { get; set; }

		[JsonProperty("completed")]
		public bool Completed { get; set; }

		[JsonProperty("gpsStart")]
		public string Start { get; set; }

		[JsonProperty("dateCreated")]
		public DateTime DateCreated { get; set; }

		[JsonProperty("avg")]
		public decimal Average { get; set; }

		[JsonProperty("max")]
		public decimal Max { get; set; }

		[JsonProperty("min")]
		public decimal Min { get; set; }
	}
}
