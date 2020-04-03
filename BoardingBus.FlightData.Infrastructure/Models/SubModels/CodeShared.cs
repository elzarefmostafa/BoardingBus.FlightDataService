using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardingBus.FlightData.Infrastructure.Models.SubModels
{
    public class CodeShared
    {
        [JsonProperty("airline")]
        public Airline airline { get; set; }
        [JsonProperty("flight")]
        public Flight flight { get; set; }
    }
}
