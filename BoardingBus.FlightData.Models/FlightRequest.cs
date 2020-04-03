using System;
using System.Collections.Generic;
using System.Text;

namespace BoardingBus.FlightData.Models
{
    public class FlightRequest
    {
		public string flightName { get; set; }
		public bool includedelays { get; set; }

	}
}
