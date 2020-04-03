using BoardingBus.FlightData.Infrastructure.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoardingBus.FlightData.Infrastructure.Business
{
    public interface IFlight
    {
		Task<FlightDataResponse> GetFlightData(FlightDataRequest flightDataRequest);
		Task<List<FlightDataResponse>> GetAllFlightData();
	}
}
