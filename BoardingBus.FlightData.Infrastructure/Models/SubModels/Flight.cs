using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardingBus.FlightData.Infrastructure.Models.SubModels
{
    public class Flight
    {
		[JsonProperty("iataNumber")]
		public string IataNumber { get; set; }
		[JsonProperty("icaoNumber")]
		public string IcaoNumber { get; set; }
		[JsonProperty("number")]
		public string number { get; set; }
	}
}
