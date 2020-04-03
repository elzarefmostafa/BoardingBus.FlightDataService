using System.Collections.Generic;

namespace BoardingBus.FlightData.Models.SubModels
{
	public class Route
    {
		public List<string> Destinations { get; set; }
		public string Eu { get; set; }
		public string Visa { get; set; }
	}
}
