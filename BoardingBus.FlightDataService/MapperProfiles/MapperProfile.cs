using AutoMapper;
using BoardingBus.FlightData.Infrastructure.Models;
using BoardingBus.FlightData.Infrastructure.Models.SubModels;
using BoardingBus.FlightData.Models;
using BoardingBus.FlightData.Models.SubModels;

namespace BoardingBus.FlightDataService.MapperProfiles
{
	public class MapperProfile:Profile
    {
		public MapperProfile()
		{
			CreateMap<FlightRequest, FlightDataRequest>(MemberList.None).ReverseMap();
			CreateMap<FlightResponse, FlightDataResponse>(MemberList.None).ReverseMap();

			//CreateMap<FlightData.Infrastructure.Models.SubModels.AircraftType, FlightData.Models.SubModels.AircraftType>(MemberList.None).ReverseMap();
			//CreateMap<FlightData.Infrastructure.Models.SubModels.BaggageClaim, FlightData.Models.SubModels.BaggageClaim>(MemberList.None).ReverseMap();
			//CreateMap<FlightData.Infrastructure.Models.SubModels.CodeShares, FlightData.Models.SubModels.CodeShares>(MemberList.None).ReverseMap();
			//CreateMap<FlightData.Infrastructure.Models.SubModels.PublicFlightState, FlightData.Models.SubModels.PublicFlightState>(MemberList.None).ReverseMap();
			//CreateMap<FlightData.Infrastructure.Models.SubModels.Route, FlightData.Models.SubModels.Route>(MemberList.None).ReverseMap();

		}
	}
}
