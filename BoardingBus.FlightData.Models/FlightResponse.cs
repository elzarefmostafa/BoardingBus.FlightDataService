using BoardingBus.FlightData.Models.SubModels;
using System;

namespace BoardingBus.FlightData.Models
{
	public class FlightResponse
    {
		public DateTime LastUpdatedAt { get; set; }
		public DateTime ActualLandingTime { get; set; }
		public string ActualOffBlockTime { get; set; }
		public string AircraftRegistration { get; set; }
		public AircraftType AircraftType { get; set; }
		public BaggageClaim BaggageClaim { get; set; }
		public string CheckinAllocations { get; set; }
		public CodeShares CodeShares { get; set; }
		public DateTime EstimatedLandingTime { get; set; }
		public string ExpectedTimeBoarding { get; set; }
		public string ExpectedTimeGateClosing { get; set; }
		public string ExpectedTimeGateOpen { get; set; }
		public DateTime ExpectedTimeOnBelt { get; set; }
		public string ExpectedSecurityFilter { get; set; }
		public string FlightDirection { get; set; }
		public string FlightName { get; set; }
		public int FlightNumber { get; set; }
		public string Gate { get; set; }
		public string Pier { get; set; }
		public string Id { get; set; }
		public string MainFlight { get; set; }
		public string PrefixIATA { get; set; }
		public string PrefixICAO { get; set; }
		public int AirlineCode { get; set; }
		public string PublicEstimatedOffBlockTime { get; set; }
		public PublicFlightState PublicFlightState { get; set; }
		public Route Route { get; set; }
		public DateTime ScheduleDateTime { get; set; }
		public DateTime ScheduleDate { get; set; }
		public TimeSpan ScheduleTime { get; set; }
		public string ServiceType { get; set; }
		public int Terminal { get; set; }
		public string TransferPositions { get; set; }
		public string SchemaVersion { get; set; }

	}
}
