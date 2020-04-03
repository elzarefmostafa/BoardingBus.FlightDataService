using BoardingBus.FlightData.Infrastructure.Models;
using BoardingBus.FlightData.Infrastructure.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoardingBus.FlightData.Infrastructure.Business
{
	public class Flight : IFlight
	{
		private readonly IService _service;
		//To Do config
		public Flight(IService service)
		{
			_service = service;
		}

		public async Task<List<FlightDataResponse>> GetAllFlightData()
		{
			string URL = $"http://aviation-edge.com/v2/public/timetable?key=3c9a2f-46b944";

			List<FlightDataResponse> flights = (List<FlightDataResponse>)_service.CallService<List<FlightDataResponse>>(URL).Result;
			if (flights != null && flights.Count > 0)
				return flights;
			return null;
		}

		public async Task<FlightDataResponse> GetFlightData(FlightDataRequest flightDataRequest)
		{
			string URL = $"http://aviation-edge.com/v2/public/flights?key=3c9a2f-46b944&limit=30000";

			RootObject<FlightDataResponse> flightsRoot = (RootObject<FlightDataResponse>)_service.CallService<RootObject<FlightDataResponse>>(URL).Result;
			if (flightsRoot !=null&& flightsRoot.flights!=null&& flightsRoot.flights.Count > 0)
				return flightsRoot.flights[0];
			return null;
		}
	}
	public class RootObject<T>
	{
		public List<T> flights = new List<T>();
	}
}
