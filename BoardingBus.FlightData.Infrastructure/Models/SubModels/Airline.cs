using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardingBus.FlightData.Infrastructure.Models.SubModels
{
    public class Airline
    {
		[JsonProperty("iataCode")]
		public string IataCode { get; set; }
		[JsonProperty("icaoCode")]
		public string IcaoCode { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		
	}
}
