using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardingBus.FlightData.Infrastructure.Models.SubModels
{
    public class Arrival
    {
		[JsonProperty("actualRunway")]
		public DateTime? ActualRunway { get; set; }
		[JsonProperty("actualTime")]
		public DateTime? ActualTime { get; set; }
		[JsonProperty("baggage")]
		public string Baggage { get; set; }
		[JsonProperty("delay")]
		public string Delay { get; set; }
		[JsonProperty("estimatedRunway")]
		public DateTime? EstimatedRunway { get; set; }
		[JsonProperty("estimatedTime")]
		public DateTime? EstimatedTime { get; set; }
		[JsonProperty("gate")]
		public string Gate { get; set; }
		[JsonProperty("iataCode")]
		public string IataCode { get; set; }
		[JsonProperty("icaoCode")]
		public string IcaoCode { get; set; }
		[JsonProperty("ScheduledTime")]
		public DateTime? ScheduledTime { get; set; }
		[JsonProperty("terminal")]
		public string Terminal { get; set; }
	}
}
