using System;
using System.Collections.Generic;
using System.Text;

namespace BoardingBus.FlightData.Infrastructure.Models
{
    public class FlightDataRequest
    {
		public string flightName { get; set; }
		public bool includedelays { get; set; }

	}
}
