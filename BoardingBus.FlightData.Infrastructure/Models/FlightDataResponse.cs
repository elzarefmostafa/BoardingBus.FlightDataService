using BoardingBus.FlightData.Infrastructure.Models.SubModels;
using Newtonsoft.Json;
using System;

namespace BoardingBus.FlightData.Infrastructure.Models
{
	public class FlightDataResponse
    {
		[JsonProperty("airline")]
		public Airline airline { get; set; }
		[JsonProperty("arrival")]
		public Arrival arrival { get; set; }
		[JsonProperty("codeshared")]
		public CodeShared CodeShared { get; set; }
		[JsonProperty("departure")]
		public Departure departure { get; set; }
		[JsonProperty("flight")]
		public Flight flight { get; set; }
		
		[JsonProperty("status")]
		public string Status { get; set; }
		[JsonProperty("type")]
		public string Type { get; set; }
		

	}
}
