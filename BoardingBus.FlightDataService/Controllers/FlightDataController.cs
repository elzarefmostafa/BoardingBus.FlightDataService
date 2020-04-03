using AutoMapper;
using BoardingBus.FlightData.Infrastructure.Business;
using BoardingBus.FlightData.Infrastructure.Models;
using BoardingBus.FlightData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BoardingBus.FlightDataService.Controllers
{
	[Route("api/[controller]/[action]")]
	//[ApiController]
	public class FlightDataController : ControllerBase
    {
		private readonly IFlight _flight;
		private readonly IMapper _mapper;
		public FlightDataController(IFlight flight,IMapper mapper)
		{
			_flight = flight;
			_mapper = mapper;
		}

        [HttpGet]
        public FlightResponse GetAllFlightDataByNumber(FlightRequest flightRequest)
        {
			var response = _flight.GetFlightData(_mapper.Map<FlightDataRequest>(flightRequest)).Result;
			return _mapper.Map<FlightResponse>(response);
        }
		[HttpGet]
		public List<FlightDataResponse> GetAllFlightData()
		{
			var response = _flight.GetAllFlightData().Result;
			return response;
		}
	}
}